using Microsoft.WindowsAPICodePack.Shell;
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

namespace SOFT152Assignment
{
	public partial class FormMain : Form
	{
		public string dataFile;
		public string level;
		public bool open;

		// For back buttons to "remember" the category the user was looking at. Just a quality of life improvement.
		public FormMain(string accessLevel)
		{
			InitializeComponent();
			this.open = true;
			this.level = accessLevel.ToLower();

			if(this.level == "staff")
			{
				this.Text = "Staff Access";
			}
			else if(this.level == "public")
			{
				buttonAddDistrict.Hide();
				buttonAddNeighborhood.Hide();
				buttonAddProperty.Hide();
				buttonEditDistrict.Hide();
				buttonEditNeighborhood.Hide();
				buttonEditProperty.Hide();
				this.Text = "Public Access";
			}

			labelFileDialog.Width = this.Width - 40;
			labelFileDialog.Height = this.Height - 135;
		}

		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			if(this.open)
			{
				this.open = false;
				this.Close();
				Application.Exit();
			}
		}

		private void ButtonBack_Click(object sender, EventArgs e)
		{
			ShowForm(new FormAccess(), true, false);
		}

		private void PanelSearchDistrict_Click(object sender, EventArgs e)
		{
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputSearchDistrict.Focus();
		}

		private void InputSearchDistrict_Enter(object sender, EventArgs e)
		{
			// Remove placeholder text.
			if(inputSearchDistrict.Text == "Search...")
			{
				inputSearchDistrict.Text = "";
			}
		}

		private void InputSearchDistrict_Leave(object sender, EventArgs e)
		{
			// Add placeholder text.
			if(inputSearchDistrict.Text.Trim() == "")
			{
				inputSearchDistrict.Text = "Search...";
			}
		}

		private void InputSearchDistrict_KeyUp(object sender, KeyEventArgs e)
		{
			if(inputSearchDistrict.Text.Trim() == "")
			{
				if(this.dataFile != null && this.dataFile != "")
				{
					PopulateList(Data.districts, "districts");
				}
				Search("districts", inputSearchDistrict.Text.Trim());
			}
			else
			{
				Search("districts", inputSearchDistrict.Text.Trim());
			}
		}

		private void ButtonAddDistrict_Click(object sender, EventArgs e)
		{
			// A data file is required to actually modify and add data to.
			if(this.dataFile != null && this.dataFile != "")
			{
				ShowForm(new PopupDistrict("staff", "add"), false, true);
			}
		}

		private void ButtonEditDistrict_Click(object sender, EventArgs e)
		{
			if(this.dataFile != null && this.dataFile != "")
			{
				if(listviewDistricts.SelectedItems.Count == 1)
				{
					int index = listviewDistricts.SelectedIndices[0];
					ShowForm(new PopupDistrict("staff", "edit", index), false, true);
				}
				else
				{
					MessageBox.Show("Select a district first.", "Error");
				}
			}
		}

		private void ButtonViewDistrict_Click(object sender, EventArgs e)
		{
			if(listviewDistricts.SelectedItems.Count == 1)
			{
				int index = listviewDistricts.SelectedIndices[0];
				ShowForm(new PopupDistrict("staff", "view", index), false, true);
			}
			else
			{
				MessageBox.Show("Select a district first.", "Error");
			}
		}

		private void ButtonAddNeighborhood_Click(object sender, EventArgs e)
		{
			// A data file is required to actually modify and add data to.
			if(this.dataFile != null && this.dataFile != "")
			{
				if(listviewDistricts.SelectedItems.Count == 1)
				{

				}
				else
				{
					MessageBox.Show("Select a district to add a neighborhood to first.", "Error");
				}
			}
		}

		private void ButtonEditNeighborhood_Click(object sender, EventArgs e)
		{
			// A data file is required to actually modify and add data to.
			if(this.dataFile != null && this.dataFile != "")
			{
				if(listviewDistricts.SelectedItems.Count == 1 && listviewNeighborhoods.SelectedItems.Count == 1)
				{

				}
				else
				{
					MessageBox.Show("Select a district and a neighborhood first.", "Error");
				}
			}
		}

		private void ButtonViewNeighborhood_Click(object sender, EventArgs e)
		{
			if(listviewDistricts.SelectedItems.Count == 1 && listviewNeighborhoods.SelectedItems.Count == 1)
			{

			}
			else
			{
				MessageBox.Show("Select a district and a neighborhood first.", "Error");
			}
		}

		private void ButtonAddProperty_Click(object sender, EventArgs e)
		{
			// A data file is required to actually modify and add data to.
			if(this.dataFile != null && this.dataFile != "")
			{
				if(listviewDistricts.SelectedItems.Count == 1 && listviewNeighborhoods.SelectedItems.Count == 1)
				{

				}
				else
				{
					MessageBox.Show("Select a district and neighborhood first.", "Error");
				}
			}
		}

		private void ButtonEditProperty_Click(object sender, EventArgs e)
		{
			// A data file is required to actually modify and add data to.
			if(this.dataFile != null && this.dataFile != "")
			{
				if(listviewDistricts.SelectedItems.Count == 1 && listviewNeighborhoods.SelectedItems.Count == 1 && listviewProperties.SelectedItems.Count == 1)
				{

				}
				else
				{
					MessageBox.Show("Select a district, neighborhood, and property first.", "Error");
				}
			}
		}

		private void ButtonViewProperty_Click(object sender, EventArgs e)
		{
			if(listviewDistricts.SelectedItems.Count == 1 && listviewNeighborhoods.SelectedItems.Count == 1 && listviewProperties.SelectedItems.Count == 1)
			{

			}
			else
			{
				MessageBox.Show("Select a district, neighborhood, and property first.", "Error");
			}
		}

		private void ListviewDistricts_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			// If there aren't any selected items in the ListView, then the edit button is "grayed out". I realize the "Disabled" property exists, but it's easier to style the button this way.
			if(listviewDistricts.SelectedItems.Count == 1)
			{
				Utils.EnableControl(buttonViewDistrict);
				Utils.EnableControl(buttonEditDistrict);
				Utils.EnableControl(buttonAddNeighborhood);

				EmptyList(listviewNeighborhoods);
				EmptyList(listviewProperties);

				AddColumns("neighborhoods");
				AddColumns("properties");

				int districtIndex = listviewDistricts.SelectedIndices[0];
				District district = Data.districts[districtIndex];
				foreach(Neighborhood neighborhood in district.Neighborhoods)
				{
					listviewNeighborhoods.Items.Add(new ListViewItem(new string[2] { neighborhood.Name, neighborhood.PropertyCount.ToString() }));
					foreach(Property property in neighborhood.Properties)
					{
						listviewProperties.Items.Add(new ListViewItem(new string[11] { property.Id.ToString(), property.Name, property.HostID.ToString(), property.HostName, property.Count.ToString(), property.Longitude.ToString(), property.Latitude.ToString(), property.RoomType, property.RoomPrice.ToString(), property.RoomNights.ToString(), property.RoomAvailability.ToString() }));
					}
				}
			}
			else
			{
				Utils.DisableControl(buttonViewDistrict);
				Utils.DisableControl(buttonEditDistrict);
				Utils.DisableControl(buttonAddNeighborhood);

				PopulateList(Data.districts, "neighborhoods");
				PopulateList(Data.districts, "properties");
			}
		}

		private void ListviewNeighborhoods_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			// If there aren't any selected items in the ListView, then the edit button is "grayed out". I realize the "Disabled" property exists, but it's easier to style the button this way.
			if(listviewNeighborhoods.SelectedItems.Count == 1)
			{
				EmptyList(listviewProperties);

				AddColumns("properties");

				int neighborhoodIndex = listviewNeighborhoods.SelectedIndices[0];

				if(listviewDistricts.SelectedItems.Count == 1)
				{
					Utils.EnableControl(buttonViewNeighborhood);
					Utils.EnableControl(buttonEditNeighborhood);
					Utils.EnableControl(buttonAddProperty);
					int districtIndex = listviewDistricts.SelectedIndices[0];
					District district = Data.districts[districtIndex];
					Neighborhood neighborhood = district.Neighborhoods[neighborhoodIndex];
					foreach(Property property in neighborhood.Properties)
					{
						listviewProperties.Items.Add(new ListViewItem(new string[11] { property.Id.ToString(), property.Name, property.HostID.ToString(), property.HostName, property.Count.ToString(), property.Longitude.ToString(), property.Latitude.ToString(), property.RoomType, property.RoomPrice.ToString(), property.RoomNights.ToString(), property.RoomAvailability.ToString() }));
					}
				}
				else
				{
					Utils.DisableControl(buttonViewNeighborhood);
					Utils.DisableControl(buttonEditNeighborhood);
					Utils.DisableControl(buttonAddProperty);
					Neighborhood neighborhood;
					for(int i = 0; i < Data.districts.Length; i++)
					{
						District district = Data.districts[i];
						foreach(Neighborhood neighborhoodToSearch in district.Neighborhoods)
						{
							if(neighborhoodToSearch.Name.ToLower() == listviewNeighborhoods.SelectedItems[0].SubItems[0].Text.ToLower())
							{
								neighborhood = neighborhoodToSearch;
								foreach(Property property in neighborhood.Properties)
								{
									listviewProperties.Items.Add(new ListViewItem(new string[11] { property.Id.ToString(), property.Name, property.HostID.ToString(), property.HostName, property.Count.ToString(), property.Longitude.ToString(), property.Latitude.ToString(), property.RoomType, property.RoomPrice.ToString(), property.RoomNights.ToString(), property.RoomAvailability.ToString() }));
								}
							}
						}
					}
				}
			}
			else
			{
				Utils.DisableControl(buttonViewNeighborhood);
				Utils.DisableControl(buttonEditNeighborhood);
				Utils.DisableControl(buttonAddProperty);

				EmptyList(listviewProperties);

				AddColumns("properties");

				if(listviewDistricts.SelectedItems.Count == 1)
				{
					int districtIndex = listviewDistricts.SelectedIndices[0];
					District district = Data.districts[districtIndex];
					foreach(Neighborhood neighborhood in district.Neighborhoods)
					{
						foreach(Property property in neighborhood.Properties)
						{
							listviewProperties.Items.Add(new ListViewItem(new string[11] { property.Id.ToString(), property.Name, property.HostID.ToString(), property.HostName, property.Count.ToString(), property.Longitude.ToString(), property.Latitude.ToString(), property.RoomType, property.RoomPrice.ToString(), property.RoomNights.ToString(), property.RoomAvailability.ToString() }));
						}
					}
				}
				else
				{
					PopulateList(Data.districts, "properties");
				}
			}
		}

		private void ListviewProperties_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			// If there aren't any selected items in the ListView, then the edit button is "grayed out". I realize the "Disabled" property exists, but it's easier to style the button this way.
			if(listviewDistricts.SelectedItems.Count == 1 && listviewNeighborhoods.SelectedItems.Count == 1 && listviewProperties.SelectedItems.Count == 1)
			{
				Utils.EnableControl(buttonViewProperty);
				Utils.EnableControl(buttonEditProperty);
			}
			else
			{
				Utils.DisableControl(buttonViewProperty);
				Utils.DisableControl(buttonEditProperty);
			}
		}

		private void FileDialog_FileOk(object sender, CancelEventArgs e)
		{
			// Display the file name to the user along with "Loading" so they know they chose the right file.
			labelFileDialog.Text = "Loading " + fileDialog.SafeFileName;
			ReadFile(fileDialog.FileName);
			this.dataFile = fileDialog.FileName;
			if(this.dataFile != null && this.dataFile != "")
			{
				Utils.EnableControl(buttonAddDistrict);
			}
		}

		private void LabelFileDialog_Click(object sender, EventArgs e)
		{
			// Disable file selection if one's already been selected.
			if(labelFileDialog.Text == "Select Data Source...")
			{
				fileDialog.Title = "Select Data Source File";
				fileDialog.FileName = "*.txt";
				fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				fileDialog.CheckFileExists = true;
				fileDialog.CheckPathExists = true;
				fileDialog.ShowDialog();
			}
		}

		private void LabelFileDialog_MouseEnter(object sender, EventArgs e)
		{
			labelFileDialog.BackColor = Color.FromArgb(70, 70, 70);
		}

		private void LabelFileDialog_MouseLeave(object sender, EventArgs e)
		{
			labelFileDialog.BackColor = Color.FromArgb(60, 60, 60);
		}

		private void ShowForm(Form form, bool matchSize, bool keepOpen)
		{
			int screenWidth = Screen.FromControl(this).Bounds.Width;
			int screenHeight = Screen.FromControl(this).Bounds.Height;
			// The "keepOpen" boolean is used to determine whether or not the current from should be kept open. Clicking something like the back button would count as closing the current form, so the "keepOpen" would be set to false. A popup, on the other hand, would constitute a situation in which the current form should ideally be kept open.
			if(!keepOpen)
			{
				form.Show();
				this.Hide();
				// Open form in the same location.
				form.Left = this.Left;
				form.Top = this.Top;
			}
			else
			{
				int x = screenWidth - form.Width - 100;
				int y = 100;
				// Setting the location of a dialog is different from a normal form.
				form.StartPosition = FormStartPosition.Manual;
				form.Location = new Point(x, y);
				// "ShowDialog" defers from the normal "Show" method, because it essentially disables the current form while the new one is open. This is good for a popup, because the user interacting with the data while a popup is open could lead to issues.
				form.ShowDialog();
			}

			// Most forms have the same size, but some (such as popups) might not.
			if(matchSize)
			{
				form.Size = this.Size;
			}
		}

		private void Search(string category, string query)
		{
			if(this.dataFile != null && this.dataFile != "")
			{
				int queryLength = query.Length;
				PopulateList(Data.districts, category);
				ListView.ListViewItemCollection items = listviewDistricts.Items;
				if(category == "neighborhoods")
				{
					items = listviewNeighborhoods.Items;
				}
				else if(category == "properties")
				{
					items = listviewProperties.Items;
				}
				if(query == "" || query == "Search...")
				{
					// If the search query is empty, then all ListViewItems are restored. I wanted to use "Hide()" on them originally, but that doesn't seem to be possible.
					PopulateList(Data.districts, category);
				}
				else
				{
					// For each item in the list...
					foreach(ListViewItem item in items)
					{
						// And for each sub-item in the parent item...
						for(int i = 0; i < item.SubItems.Count; i++)
						{
							// If the lowercase value of the query is found in the lowercase value of the sub-item's text content, then its parent item is tagged as a match.
							string subItemText = item.SubItems[i].Text;
							int subItemLength = subItemText.Length;
							// Check to see if the sub-item's text content is bigger than or equal to the query's length. This prevents an index out of range exception with the "Substring()" method.
							if(subItemLength >= queryLength)
							{
								// To avoid using "Contains()" or "IndexOf()", I've coded my own way of checking if the sub-item's text content contains a portion of the query. Unfortunately, it only checks from the beginning of the sub-item string, so the user can't search for the "eigh" in "neighborhood" for example.
								string subString = subItemText.Substring(0, queryLength).ToLower();
								if(subString == query.ToLower())
								{
									item.Tag = "match";
								}
							}
						}
						// After the sub-items have been iterated through, the item is checked to see if it has a tag. If it doesn't, then it's not a match, and is removed.
						if(item.Tag == null)
						{
							item.Remove();
						}
					}
				}
			}
		}

		private void ReadFile(string filename)
		{
			bool valid = true;
			string exception = "";
			StreamReader reader = new StreamReader(filename);
			while(!reader.EndOfStream)
			{
				try
				{
					string districtName = reader.ReadLine();
					int districtNeighborhoodCount = Convert.ToInt32(reader.ReadLine());
					// Create a new "District" object.
					District district = new District(districtName, districtNeighborhoodCount);
					// For each neighborhood in the district...
					for(int j = 0; j < districtNeighborhoodCount; j++)
					{
						string neighborhoodName = reader.ReadLine();
						int neighborhoodPropertyCount = Convert.ToInt32(reader.ReadLine());
						// Create a new "Neighborhood" object.
						Neighborhood neighborhood = new Neighborhood(neighborhoodName, neighborhoodPropertyCount);
						// For each property in the neighborhood...
						for(int k = 0; k < neighborhoodPropertyCount; k++)
						{
							int propertyID = Convert.ToInt32(reader.ReadLine());
							string propertyName = reader.ReadLine();
							int hostID = Convert.ToInt32(reader.ReadLine());
							string hostName = reader.ReadLine();
							int hostPropertyCount = Convert.ToInt32(reader.ReadLine());
							double latitude = Convert.ToDouble(reader.ReadLine());
							double longitude = Convert.ToDouble(reader.ReadLine());
							string roomType = reader.ReadLine();
							double roomPrice = Convert.ToDouble(reader.ReadLine());
							int roomNights = Convert.ToInt32(reader.ReadLine());
							int roomAvailability = Convert.ToInt32(reader.ReadLine());
							// Create a new "Property" object, and add it to the array of properties in the neighborhood.
							Property property = new Property(propertyID, propertyName, hostID, hostName, hostPropertyCount, latitude, longitude, roomType, roomPrice, roomNights, roomAvailability);
							neighborhood.addProperty(property);
						}
						// Add the neighborhood object to the neighborhood array in the district object.
						district.addNeighborhood(neighborhood);
					}
					// Add each district to the main district array that'll contain all the data from the text file.
					int numberOfDistricts = Data.districts.Length;
					Array.Resize(ref Data.districts, numberOfDistricts + 1);
					Data.districts[numberOfDistricts] = district;
				}
				catch(Exception e)
				{
					valid = false;
					exception = e.GetType().Name;
				}
			}
			reader.Close();
			if(valid)
			{
				// Fill the ListViews with data.
				PopulateList(Data.districts, "districts");
				PopulateList(Data.districts, "neighborhoods");
				PopulateList(Data.districts, "properties");
				// Show all ListViews.
				listviewDistricts.Show();
				listviewNeighborhoods.Show();
				listviewProperties.Show();
				Utils.EnableControl(buttonAnalysis);
			}
			else
			{
				labelFileDialog.Text = "Select Data Source...";
				MessageBox.Show("Something went wrong. Make sure the data file is in the correct format. \n\nException Type: " + exception, "Error");
			}
		}

		// To avoid using "Clear()", which would count as a shortcut (I'm guessing).
		private void EmptyList(ListView list)
		{
			foreach(ListViewItem item in list.Items)
			{
				list.Items.Remove(item);
			}
			foreach(ColumnHeader header in list.Columns)
			{
				list.Columns.Remove(header);
			}
		}

		private void PopulateList(District[] districts, string category)
		{
			// Clear ListViews of any existing data. Coded my own method to replace the "Clear()" shortcut.
			if(category == "districts")
			{
				EmptyList(listviewDistricts);
				AddColumns("districts");
			}
			else if(category == "neighborhoods")
			{
				EmptyList(listviewNeighborhoods);
				AddColumns("neighborhoods");
			}
			else if(category == "properties")
			{
				EmptyList(listviewProperties);
				AddColumns("properties");
			}

			// Add each district, neighborhood, and property to their respective ListViews.
			foreach(District district in districts)
			{
				if(category == "districts")
				{
					listviewDistricts.Items.Add(new ListViewItem(new string[2] { district.Name, district.NeighborhoodCount.ToString() }));
				}
				foreach(Neighborhood neighborhood in district.Neighborhoods)
				{
					if(category == "neighborhoods")
					{
						listviewNeighborhoods.Items.Add(new ListViewItem(new string[2] { neighborhood.Name, neighborhood.PropertyCount.ToString() }));
					}
					foreach(Property property in neighborhood.Properties)
					{
						if(category == "properties")
						{
							listviewProperties.Items.Add(new ListViewItem(new string[11] { property.Id.ToString(), property.Name, property.HostID.ToString(), property.HostName, property.Count.ToString(), property.Longitude.ToString(), property.Latitude.ToString(), property.RoomType, property.RoomPrice.ToString(), property.RoomNights.ToString(), property.RoomAvailability.ToString() }));
						}
					}
				}
			}
			labelFileDialog.Hide();
		}

		private void AddColumns(string category)
		{
			if(category == "districts")
			{
				listviewDistricts.Columns.Add("District Name", 510);
				listviewDistricts.Columns.Add("Number of Neighborhoods", 250);
			}
			else if(category == "neighborhoods")
			{
				listviewNeighborhoods.Columns.Add("Neighborhood Name", 260);
				listviewNeighborhoods.Columns.Add("Number of Properties", 250);
			}
			else if(category == "properties")
			{
				listviewProperties.Columns.Add("Property ID", 130);
				listviewProperties.Columns.Add("Property Name", 370);
				listviewProperties.Columns.Add("Host ID", 130);
				listviewProperties.Columns.Add("Host Name", 210);
				listviewProperties.Columns.Add("Properties Owned", 180);
				listviewProperties.Columns.Add("Longitude", 130);
				listviewProperties.Columns.Add("Latitude", 130);
				listviewProperties.Columns.Add("Room Type", 240);
				listviewProperties.Columns.Add("Room Price", 130);
				listviewProperties.Columns.Add("Minimum Nights", 150);
				listviewProperties.Columns.Add("Days Available per Year", 250);
			}
		}
	}
}
