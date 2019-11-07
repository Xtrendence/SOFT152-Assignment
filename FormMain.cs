using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152Assignment {
	public partial class FormMain : Form {
		public string[] dataLines;
		public string dataSource;
		public string category;
		public string level;
		public bool open;
		public FormMain() {
			InitializeComponent();
			// Set the form as open.
			this.open = true;
			// By default, the districts category is shown.
			ShowCategory("districts");
		}
		// For back buttons to "remember" the category the user was looking at. Just a quality of life improvement.
		public FormMain(string activeCategory, string accessLevel) {
			InitializeComponent();
			this.open = true;
			this.category = activeCategory.ToLower();
			this.level = accessLevel.ToLower();

			if(this.level == "staff") {
				buttonAdd.Show();
				buttonEdit.Show();
				this.Text = "Staff Access";
			}
			else if(this.level == "public") {
				buttonAdd.Hide();
				buttonEdit.Hide();
				this.Text = "Public Access";
			}
			ShowCategory(category);
		}

		private void ButtonBack_Click(object sender, EventArgs e) {
			ShowForm(new FormAccess(), true, false);
		}
		private void ShowForm(Form form, bool matchSize, bool keepOpen) {
			// The "keepOpen" boolean is used to determine whether or not the current from should be kept open. Clicking something like the back button would count as closing the current form, so the "keepOpen" would be set to false. A popup, on the other hand, would constitute a situation in which the current form should ideally be kept open.
			if(!keepOpen) {
				form.Show();
				this.Hide();
				// Open form in the same location.
				form.Left = this.Left;
				form.Top = this.Top;
			}
			else {
				// Since the other form is open in the back, it'd make sense to open the new one out of the current one's screen real estate, so if the user accidentally clicks on the old form, the new one doesn't get hidden behind it and possibly get forgotten about.
				int x = this.Size.Width - 100;
				int y = this.Size.Height;
				// Setting the location of a dialog is different from a normal form.
				form.StartPosition = FormStartPosition.Manual;
				form.Location = new Point(x, y);
				// "ShowDialog" defers from the normal "Show" method, because it essentially disables the current form while the new one is open. This is good for a popup, because the user interacting with the data while a popup is open could lead to issues.
				form.ShowDialog();
			}
			
			// Most forms have the same size, but some (such as popups) might not.
			if(matchSize) {
				form.Size = this.Size;
			}
		}
		private void ShowCategory(string desiredCategory) {
			this.category = desiredCategory.ToLower();

			// Reset the search TextBox value.
			inputSearch.Text = "Search...";

			// The user can't have any ListViewItems selected if they've just switched categories.
			buttonView.BackColor = Color.FromArgb(20, 20, 20);
			buttonView.ForeColor = Color.FromArgb(150, 150, 150);
			buttonEdit.BackColor = Color.FromArgb(20, 20, 20);
			buttonEdit.ForeColor = Color.FromArgb(150, 150, 150);

			// Reset all buttons to dark gray.
			buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
			buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
			buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

			// Reset all button tags so none are considered to be "active".
			buttonDistricts.Tag = "";
			buttonNeighborhoods.Tag = "";
			buttonProperties.Tag = "";

			// If the data source isn't empty... (so the data an actually be saved and modified).
			if(this.dataSource != null && this.dataSource != "") {
				// The add button works without selecting any ListViewItems in the districts category.
				buttonAdd.BackColor = Color.FromArgb(60, 60, 60);
				buttonAdd.ForeColor = Color.FromArgb(250, 250, 250);
			}

			if(desiredCategory == "districts") {
				// Sets the "Districts" button's background color to brighter than the other two, letting the user know that it's the active one.
				buttonDistricts.BackColor = Color.FromArgb(100, 100, 100);
				// Sets the "Tag" property of the "Districts" button to "active-category". This is later used to determine which popup dialog form to display.
				buttonDistricts.Tag = "active-category";
			}
			else if(desiredCategory == "neighborhoods") {
				// Same as above, but for the "Neighborhoods" button.
				buttonNeighborhoods.BackColor = Color.FromArgb(100, 100, 100);
				// Same thing as above, but for the "Neighborhoods" button.
				buttonNeighborhoods.Tag = "active-category";
			}
			else if(desiredCategory == "properties") {
				// Same as above, but for the "Properties" button.
				buttonProperties.BackColor = Color.FromArgb(100, 100, 100);
				// Same as above, but for the "Properties" button.
				buttonProperties.Tag = "active-category";
			}
			// If the data source file isn't empty, then populate the ListViews.
			if(dataLines != null && dataLines.ToString() != "") {
				PopulateLists(dataLines, this.category);
			}
		}

		private void ButtonDistricts_Click(object sender, EventArgs e) {
			ShowCategory("districts");
		}

		private void ButtonNeighborhoods_Click(object sender, EventArgs e) {
			ShowCategory("neighborhoods");
		}

		private void ButtonProperties_Click(object sender, EventArgs e) {
			ShowCategory("properties");
		}

		private void ButtonAdd_Click(object sender, EventArgs e) {
			// A data file is required to actually modify and add data to.
			if(this.dataSource != null && this.dataSource != "") {
				// If the "Districts" button's "Tag" property isn't empty, and is set to "active-category", then the "PopupDistrict" form is opened. Checks for "null" first because using the "ToString()" method on null can result in an error.
				if(buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
					ShowForm(new PopupDistrict("staff", "add"), false, true);
				}
				// Same thing, but for the "Neighborhoods" button.
				else if(buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
					if(listviewNeighborhoods.SelectedItems.Count == 1) {
						ShowForm(new PopupNeighborhood("staff", "add", listviewNeighborhoods.SelectedItems[0].SubItems[0].Text), false, true);
					}
					else {
						ShowForm(new PopupNeighborhood("staff", "add"), false, true);
					}
				}
				// Same thing, but for the "Properties" button.
				else if(buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
					ShowForm(new PopupProperty("staff", "add"), false, true);
					if(listviewProperties.SelectedItems.Count == 1) {
						ShowForm(new PopupProperty("staff", "add", listviewProperties.SelectedItems[0].SubItems[0].Text, listviewProperties.SelectedItems[0].SubItems[1].Text), false, true);
					}
					else {
						ShowForm(new PopupProperty("staff", "add"), false, true);
					}
				}
			}
		}

		private void PanelSearch_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputSearch.Focus();
		}

		private void ButtonEdit_Click(object sender, EventArgs e) {
			// If "Districts" is the active category.
			if(buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
				// And if the "Districts" ListView has a selected item...
				if(listviewDistricts.SelectedItems.Count == 1) {
					// Then that items subitems are fetched.
					ListViewItem.ListViewSubItemCollection subItem = listviewDistricts.SelectedItems[0].SubItems;
					District district = new District(subItem[0].Text, Convert.ToInt32(subItem[1].Text));
					ShowForm(new PopupDistrict("staff", "edit", district), false, true);
				}
			}
			// If "Neighborhoods" is the active category.
			else if(buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
				// And if the "Neighborhoods" ListView has a selected item...
				if(listviewNeighborhoods.SelectedItems.Count == 1) {
					// Then that items subitems are fetched.
					ListViewItem.ListViewSubItemCollection subItem = listviewNeighborhoods.SelectedItems[0].SubItems;
					Neighborhood neighborhood = new Neighborhood(subItem[1].Text, Convert.ToInt32(subItem[2].Text));
					ShowForm(new PopupNeighborhood("staff", "edit", subItem[0].Text, neighborhood), false, true);
				}
			}
			// If "Properties" is the active category...
			else if(buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
				// And if the "Properties" ListView has a selected item...
				if(listviewProperties.SelectedItems.Count == 1) {
					// Then that items subitems are fetched.
					ListViewItem.ListViewSubItemCollection subItem = listviewProperties.SelectedItems[0].SubItems;
					// This looks terrifying, but it's just grabbing all 11 subitems, converting them to the appropriate data type, and then creating a "Property" object. 
					Property property = new Property(Convert.ToInt32(subItem[2].Text), subItem[3].Text, Convert.ToInt32(subItem[4].Text), subItem[5].Text, Convert.ToInt32(subItem[6].Text), Convert.ToDouble(subItem[7].Text), Convert.ToDouble(subItem[8].Text), subItem[9].Text, Convert.ToDouble(subItem[10].Text), Convert.ToInt32(subItem[11].Text), Convert.ToInt32(subItem[12].Text));
					ShowForm(new PopupProperty("staff", "edit", subItem[0].Text, subItem[1].Text, property), false, true);
				}
			}
		}

		private void LabelFileDialog_Click(object sender, EventArgs e) {
			// Disable file selection if one's already been selected.
			if(labelFileDialog.Text == "Select Data Source...") {
				fileDialog.Title = "Select Data Source File";
				fileDialog.FileName = "";
				fileDialog.InitialDirectory = @"C:\";
				fileDialog.CheckFileExists = true;
				fileDialog.CheckPathExists = true;
				fileDialog.ShowDialog();
			}
		}

		private void LabelFileDialog_MouseEnter(object sender, EventArgs e) {
			labelFileDialog.BackColor = Color.FromArgb(70, 70, 70);
		}

		private void LabelFileDialog_MouseLeave(object sender, EventArgs e) {
			labelFileDialog.BackColor = Color.FromArgb(60, 60, 60);
		}

		// To avoid using "Clear()", which would count as a shortcut (I'm guessing).
		private void EmptyList(ListView list) {
			foreach(ListViewItem item in list.Items) {
				list.Items.Remove(item);
			}
			foreach(ColumnHeader header in list.Columns) {
				list.Columns.Remove(header);
			}
		}

		private void PopulateLists(string[] lines, string activeCategory) {
			// Clear ListViews of any existing data. Coded my own method to replace the "Clear()" shortcut.
			EmptyList(listviewDistricts);
			EmptyList(listviewNeighborhoods);
			EmptyList(listviewProperties);

			// Hide all ListViews.
			listviewDistricts.Hide();
			listviewNeighborhoods.Hide();
			listviewProperties.Hide();

			// Add a column to the "Districts" ListView for the district names.
			listviewDistricts.Columns.Add("District Name", 510);
			// Add a column for the number of neighborhoods in the district.
			listviewDistricts.Columns.Add("Number of Neighborhoods", 250);
			// Add a column for the district name in the neighborhoods ListView.
			listviewNeighborhoods.Columns.Add("District Name", 250);
			// Add a column for the name of neighborhoods.
			listviewNeighborhoods.Columns.Add("Neighborhood Name", 260);
			// Add a column for the number of properties.
			listviewNeighborhoods.Columns.Add("Number of Properties", 250);

			// Add columns for properties ListView.
			listviewProperties.Columns.Add("District Name", 250);
			listviewProperties.Columns.Add("Neighborhood Name", 250);
			listviewProperties.Columns.Add("Property ID", 150);
			listviewProperties.Columns.Add("Property Name", 250);
			listviewProperties.Columns.Add("Host ID", 150);
			listviewProperties.Columns.Add("Host Name", 250);
			listviewProperties.Columns.Add("Properties Owned by Host", 250);
			listviewProperties.Columns.Add("Room Type", 250);
			listviewProperties.Columns.Add("Room Price", 150);
			listviewProperties.Columns.Add("Longitude", 250);
			listviewProperties.Columns.Add("Latitude", 250);
			listviewProperties.Columns.Add("Minimum Nights", 150);
			listviewProperties.Columns.Add("Days Available per Year", 250);

			// For each line in the file, add the line to an array that is later added as a row to the ListView.
			for(int i = 0; i < lines.Length; i++) {
				try {
					string districtName = lines[i].ToString();
					i++;
					string districtNeighborhoodCount = lines[i].ToString();
					i++;
					string neighborhoodName = lines[i].ToString();
					i++;
					string neighborhoodPropertyCount = lines[i].ToString();
					i++;
					string propertyID = lines[i].ToString();
					i++;
					string propertyName = lines[i].ToString();
					i++;
					string hostID = lines[i].ToString();
					i++;
					string hostName = lines[i].ToString();
					i++;
					string hostPropertyCount = lines[i].ToString();
					i++;
					string roomType = lines[i].ToString();
					i++;
					string roomPrice = lines[i].ToString();
					i++;
					string longitude = lines[i].ToString();
					i++;
					string latitude = lines[i].ToString();
					i++;
					string roomNights = lines[i].ToString();
					i++;
					string roomAvailability = lines[i].ToString();
					i++;
					listviewDistricts.Items.Add(new ListViewItem(new string[2] { districtName, districtNeighborhoodCount }));
					listviewNeighborhoods.Items.Add(new ListViewItem(new string[3] { districtName, neighborhoodName, neighborhoodPropertyCount }));
					listviewProperties.Items.Add(new ListViewItem(new string[13] { districtName, neighborhoodName, propertyID, propertyName, hostID, hostName, hostPropertyCount, roomType, roomPrice, longitude, latitude, roomNights, roomAvailability }));
				}
				catch(IndexOutOfRangeException e) {
					Debug.WriteLine(e.Message);
				}
			}

			if(activeCategory == "districts") {
				listviewDistricts.Show();
			}
			else if(activeCategory == "neighborhoods") {
				listviewNeighborhoods.Show();
			}
			else if(activeCategory == "properties") {
				listviewProperties.Show();
			}

			if(this.dataSource != null && this.dataSource.ToString() != "") {
				buttonAdd.BackColor = Color.FromArgb(60, 60, 60);
				buttonAdd.ForeColor = Color.FromArgb(250, 250, 250);
			}

			labelFileDialog.Hide();
		}

		private void ReadFile(string filename) {
			// Read every line from the data source file, and store the lines in an array.
			dataLines = File.ReadLines(filename).ToArray();
			PopulateLists(dataLines, this.category);
		}

		private void FileDialog_FileOk(object sender, CancelEventArgs e) {
			// Display the file name to the user along with "Loading" so they know they chose the right file.
			labelFileDialog.Text = "Loading " + fileDialog.SafeFileName;
			ReadFile(fileDialog.FileName);
			this.dataSource = fileDialog.FileName;
		}

		private void ListviewDistricts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
			// If there aren't any selected items in the ListView, then the edit button is "grayed out". I realize the "Disabled" property exists, but it's easier to style the button this way.
			if(listviewDistricts.SelectedItems.Count == 1) {
				buttonView.BackColor = Color.FromArgb(60, 60, 60);
				buttonView.ForeColor = Color.FromArgb(250, 250, 250);
				buttonEdit.BackColor = Color.FromArgb(60, 60, 60);
				buttonEdit.ForeColor = Color.FromArgb(250, 250, 250);
			}
			else {
				buttonView.BackColor = Color.FromArgb(20, 20, 20);
				buttonView.ForeColor = Color.FromArgb(150, 150, 150);
				buttonEdit.BackColor = Color.FromArgb(20, 20, 20);
				buttonEdit.ForeColor = Color.FromArgb(150, 150, 150);
			}
		}

		private void listviewNeighborhoods_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
			// If there aren't any selected items in the ListView, then the edit button is "grayed out". I realize the "Disabled" property exists, but it's easier to style the button this way.
			if(listviewNeighborhoods.SelectedItems.Count == 1) {
				buttonView.BackColor = Color.FromArgb(60, 60, 60);
				buttonView.ForeColor = Color.FromArgb(250, 250, 250);
				buttonEdit.BackColor = Color.FromArgb(60, 60, 60);
				buttonEdit.ForeColor = Color.FromArgb(250, 250, 250);
			}
			else {
				buttonView.BackColor = Color.FromArgb(20, 20, 20);
				buttonView.ForeColor = Color.FromArgb(150, 150, 150);
				buttonEdit.BackColor = Color.FromArgb(20, 20, 20);
				buttonEdit.ForeColor = Color.FromArgb(150, 150, 150);
			}
		}

		private void listviewProperties_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
			// If there aren't any selected items in the ListView, then the edit button is "grayed out". I realize the "Disabled" property exists, but it's easier to style the button this way.
			if(listviewProperties.SelectedItems.Count == 1) {
				buttonView.BackColor = Color.FromArgb(60, 60, 60);
				buttonView.ForeColor = Color.FromArgb(250, 250, 250);
				buttonEdit.BackColor = Color.FromArgb(60, 60, 60);
				buttonEdit.ForeColor = Color.FromArgb(250, 250, 250);
			}
			else {
				buttonView.BackColor = Color.FromArgb(20, 20, 20);
				buttonView.ForeColor = Color.FromArgb(150, 150, 150);
				buttonEdit.BackColor = Color.FromArgb(20, 20, 20);
				buttonEdit.ForeColor = Color.FromArgb(150, 150, 150);
			}
		}

		private void InputSearch_Enter(object sender, EventArgs e) {
			// Remove placeholder text.
			if(inputSearch.Text == "Search...") {
				inputSearch.Text = "";
			}
		}

		private void InputSearch_Leave(object sender, EventArgs e) {
			// Add placeholder text.
			if(inputSearch.Text.Trim() == "") {
				inputSearch.Text = "Search...";
			}
		}

		private void ButtonView_Click(object sender, EventArgs e) {
			// If "Districts" is the active category.
			if(buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
				// And if the "Districts" ListView has a selected item...
				if(listviewDistricts.SelectedItems.Count == 1) {
					// Then that items subitems are fetched.
					ListViewItem.ListViewSubItemCollection item = listviewDistricts.SelectedItems[0].SubItems;
					District district = new District(item[0].Text, Convert.ToInt32(item[1].Text));
					ShowForm(new PopupDistrict("staff", "view", district), false, true);
				}
			}
			// If "Neighborhoods" is the active category.
			else if(buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
				// And if the "Neighborhoods" ListView has a selected item...
				if(listviewNeighborhoods.SelectedItems.Count == 1) {
					// Then that items subitems are fetched.
					ListViewItem.ListViewSubItemCollection item = listviewNeighborhoods.SelectedItems[0].SubItems;
					Neighborhood neighborhood = new Neighborhood(item[1].Text, Convert.ToInt32(item[2].Text));
					ShowForm(new PopupNeighborhood("staff", "view", item[0].Text, neighborhood), false, true);
				}
			}
			// If "Properties" is the active category...
			else if(buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
				// And if the "Properties" ListView has a selected item...
				if(listviewProperties.SelectedItems.Count == 1) {
					// Then that items subitems are fetched.
					ListViewItem.ListViewSubItemCollection item = listviewProperties.SelectedItems[0].SubItems;
					// This looks terrifying, but it's just grabbing all 11 subitems, converting them to the appropriate data type, and then creating a "Property" object. 
					Property property = new Property(Convert.ToInt32(item[2].Text), item[3].Text, Convert.ToInt32(item[4].Text), item[5].Text, Convert.ToInt32(item[6].Text), Convert.ToDouble(item[7].Text), Convert.ToDouble(item[8].Text), item[9].Text, Convert.ToDouble(item[10].Text), Convert.ToInt32(item[11].Text), Convert.ToInt32(item[12].Text));
					ShowForm(new PopupProperty("staff", "view", item[0].Text, item[1].Text, property), false, true);
				}
			}
		}

		private void search(string query) {
			PopulateLists(dataLines, this.category);
			ListView.ListViewItemCollection items = listviewDistricts.Items;
			if(this.category == "neighborhoods") {
				items = listviewNeighborhoods.Items;
			}
			else if(this.category == "properties") {
				items = listviewProperties.Items;
			}
			if(query == "" || query == "Search...") {
				// If the search query is empty, then all ListViewItems are restored. I wanted to use "Hide()" on them originally, but that doesn't seem to be possible.
				PopulateLists(dataLines, this.category);
			}
			else {
				// For each item in the list...
				foreach(ListViewItem item in items) {
					// And for each sub-item in the parent item...
					for(int i = 0; i < item.SubItems.Count; i++) {
						// If the lowercase value of the query is found in the lowercase value of the sub-item's text content, then its parent item is tagged as a match.
						if(item.SubItems[i].Text.ToLower() == query.ToLower()) {
							item.Tag = "match";
						}
					}
					// After the sub-items have been iterated through, the item is checked to see if it has a tag. If it doesn't, then it's not a match, and is removed.
					if(item.Tag == null) {
						item.Remove();
					}
				}
			}
		}

		private void ButtonSearch_Click(object sender, EventArgs e) {
			if(inputSearch.Text.Trim() != "" && inputSearch.Text != "Search...") {
				search(inputSearch.Text.Trim());
			}
		}

		private void InputSearch_KeyUp(object sender, KeyEventArgs e) {
			if(inputSearch.Text.Trim() == "") {
				PopulateLists(dataLines, this.category);
				buttonSearch.BackColor = Color.FromArgb(20, 20, 20);
				buttonSearch.ForeColor = Color.FromArgb(150, 150, 150);
			}
			else {
				buttonSearch.BackColor = Color.FromArgb(60, 60, 60);
				buttonSearch.ForeColor = Color.FromArgb(250, 250, 250);
				search(inputSearch.Text.Trim());
			}
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e) {
			if(this.open) {
				this.open = false;
				this.Close();
				Application.Exit();
			}
		}
	}
}
