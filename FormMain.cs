using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152Assignment {
	public partial class FormMain : Form {
		public string[] dataLines;
		public string category;
		public string level;
		public FormMain() {
			InitializeComponent();
			// By default, the districts category is shown.
			showCategory("districts");
		}
		// For back buttons to "remember" the category the user was looking at. Just a quality of life improvement.
		public FormMain(string activeCategory, string accessLevel) {
			InitializeComponent();
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

			showCategory(category);
		}

		private void ButtonBack_Click(object sender, EventArgs e) {
			showForm(new FormAccess(), true);
		}
		private void showForm(Form form, bool matchSize) {
			form.Show();
			this.Hide();
			// Open form in the same location.
			form.Left = this.Left;
			form.Top = this.Top;
			// Most forms have the same size, but some (such as popups) might not.
			if(matchSize) {
				form.Size = this.Size;
			}
		}
		private void showCategory(string desiredCategory) {
			this.category = desiredCategory.ToLower();

			// Reset all buttons to dark gray.
			buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
			buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
			buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

			// Reset all button tags so none are considered to be "active".
			buttonDistricts.Tag = "";
			buttonNeighborhoods.Tag = "";
			buttonProperties.Tag = "";

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
				populateLists(dataLines, this.category);
			}
		}

		private void ButtonDistricts_Click(object sender, EventArgs e) {
			showCategory("districts");
		}

		private void ButtonNeighborhoods_Click(object sender, EventArgs e) {
			showCategory("neighborhoods");
		}

		private void ButtonProperties_Click(object sender, EventArgs e) {
			showCategory("properties");
		}

		private void ButtonAdd_Click(object sender, EventArgs e) {
			// If the "Districts" button's "Tag" property isn't empty, and is set to "active-category", then the "PopupDistrict" form is opened. Checks for "null" first because using the "ToString()" method on null can result in an error.
			if(buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
				showForm(new PopupDistrict("staff", "add"), false);
			}
			// Same thing, but for the "Neighborhoods" button.
			else if(buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
				showForm(new PopupNeighborhood("staff", "add"), false);
			}
			// Same thing, but for the "Properties" button.
			else if(buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
				showForm(new PopupProperty("staff", "add"), false);
			}
		}

		private void panelSearch_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputSearch.Focus();
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			// If the "Districts" button's "Tag" property isn't empty, and is set to "active-category", then the "PopupDistrict" form is opened. Checks for "null" first because using the "ToString()" method on null can result in an error.
			if(buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
				showForm(new PopupDistrict("staff", "edit"), false);
			}
			// Same thing, but for the "Neighborhoods" button.
			else if(buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
				showForm(new PopupNeighborhood("staff", "edit"), false);
			}
			// Same thing, but for the "Properties" button.
			else if(buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
				showForm(new PopupProperty("staff", "edit"), false);
			}
		}

		private void labelFileDialog_Click(object sender, EventArgs e) {
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

		private void labelFileDialog_MouseEnter(object sender, EventArgs e) {
			labelFileDialog.BackColor = Color.FromArgb(70, 70, 70);
		}

		private void labelFileDialog_MouseLeave(object sender, EventArgs e) {
			labelFileDialog.BackColor = Color.FromArgb(60, 60, 60);
		}

		private void populateLists(string[] lines, string activeCategory) {
			// Clear ListViews of any existing data.
			listviewDistricts.Clear();
			listviewNeighborhoods.Clear();
			listviewProperties.Clear();

			// Hide all ListViews.
			listviewDistricts.Hide();
			listviewNeighborhoods.Hide();
			listviewProperties.Hide();

			// Add a column to the "Districts" ListView for the district names.
			listviewDistricts.Columns.Add("District Name", 510);
			// Add a column for the number of neighborhoods in the district.
			listviewDistricts.Columns.Add("Number of Neighborhoods", 250);
			// Add a column for the name of neighborhoods.
			listviewNeighborhoods.Columns.Add("Neighborhood Name", 510);
			// Add a column for the number of properties.
			listviewNeighborhoods.Columns.Add("Number of Properties", 250);

			// For each line in the file, add the line to an array that is later added as a row to the ListView.
			for(int i = 0; i < lines.Length; i++) {
				string districtName = lines[i].ToString();
				i++;
				string districtNeighborhoodCount = lines[i].ToString();
				i++;
				string neighborhoodName = lines[i].ToString();
				i++;
				string neighborhoodPropertyCount = lines[i].ToString();
				listviewDistricts.Items.Add(new ListViewItem(new string[2] { districtName, districtNeighborhoodCount }));
				listviewNeighborhoods.Items.Add(new ListViewItem(new string[2] { neighborhoodName, neighborhoodPropertyCount }));
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
			labelFileDialog.Hide();
		}

		private void readFile(string filename) {
			// Read every line from the data source file, and store the lines in an array.
			dataLines = File.ReadLines(filename).ToArray();
			populateLists(dataLines, this.category);
		}

		private void fileDialog_FileOk(object sender, CancelEventArgs e) {
			// Display the file name to the user along with "Loading" so they know they chose the right file.
			labelFileDialog.Text = "Loading " + fileDialog.SafeFileName;
			readFile(fileDialog.FileName);
		}

		private void buttonView_Click(object sender, EventArgs e) {
			// If the "Districts" button's "Tag" property isn't empty, and is set to "active-category", then the "PopupDistrict" form is opened. Checks for "null" first because using the "ToString()" method on null can result in an error.
			if(buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
				showForm(new PopupDistrict(this.level, "view"), false);
			}
			// Same as above but the "PopupNeighborhood" form is opened.
			else if(buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
				showForm(new PopupNeighborhood(this.level, "view"), false);
			}
			// The "PopupProperty" form is opened.
			else if(buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
				showForm(new PopupProperty(this.level, "view"), false);
			}
		}
	}
}
