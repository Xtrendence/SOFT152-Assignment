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
		// String containing the file path of the data file.
		public string dataFile;
		// The user's access level (staff or public).
		public string level;
		// To determine whether or not the form is open.
		public bool open;

		public FormMain(string accessLevel)
		{
			InitializeComponent();
			Utils.SetIcon(this);

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

		// Ensures the application actually closes when the form does.
		private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			if(this.open)
			{
				this.open = false;
				this.Close();
				Application.Exit();
			}
		}

		// The "Activated" event is triggered whenever the form gains focus. In this case, it's used to refresh the data (if it has changed) when a popup form is closed.
		private void FormMain_Activated(object sender, EventArgs e)
		{
			if(dataFile != null && dataFile != "")
			{
				if(Data.changed)
				{
					int indexDistrict = -1;
					int indexNeighborhood = -1;
					int indexProperty = -1;

					if(listviewDistricts.SelectedItems.Count == 1)
					{
						indexDistrict = listviewDistricts.SelectedIndices[0];
					}
					if(listviewNeighborhoods.SelectedItems.Count == 1)
					{
						indexNeighborhood = listviewNeighborhoods.SelectedIndices[0];
					}
					if(listviewProperties.SelectedItems.Count == 1)
					{
						indexProperty = listviewProperties.SelectedIndices[0];
					}

					PopulateList(Data.districts, "districts");

					listviewNeighborhoods.Clear();
					listviewProperties.Clear();

					labelSelectDistrict.Visible = true;
					labelSelectDistrictAndNeighborhood.Visible = true;

					// Reselect the district, neighborhood, or property that the user had selected before the ListView was refreshed.
					if(indexDistrict >= 0 && Data.deletedDistrict == false)
					{
						listviewDistricts.Items[indexDistrict].Selected = true;
						listviewDistricts.EnsureVisible(indexDistrict);
					}
					if(indexNeighborhood >= 0 && Data.deletedNeighborhood == false)
					{
						listviewNeighborhoods.Items[indexNeighborhood].Selected = true;
						listviewNeighborhoods.EnsureVisible(indexNeighborhood);
					}
					if(indexProperty >= 0 && Data.deletedProperty == false)
					{
						listviewProperties.Items[indexProperty].Selected = true;
						listviewProperties.EnsureVisible(indexProperty);
					}

					Data.changed = false;
					Data.unsaved = true;

					Data.deletedDistrict = false;
					Data.deletedNeighborhood = false;
					Data.deletedProperty = false;

					Utils.EnableControl(buttonSave);
				}
			}
		}

		private void ButtonBack_Click(object sender, EventArgs e)
		{
			listviewDistricts.Clear();
			listviewNeighborhoods.Clear();
			listviewProperties.Clear();

			labelSelectDistrict.Visible = true;
			labelSelectDistrictAndNeighborhood.Visible = true;

			ShowForm(new FormAccess(), true, false);
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			if(Data.unsaved)
			{
				StreamWriter writer = new StreamWriter(dataFile);

				foreach(District district in Data.districts)
				{
					writer.WriteLine(district.Name);
					writer.WriteLine(district.Neighborhoods.Length);

					foreach(Neighborhood neighborhood in district.Neighborhoods)
					{
						writer.WriteLine(neighborhood.Name);
						writer.WriteLine(neighborhood.Properties.Length);

						foreach(Property property in neighborhood.Properties)
						{
							writer.WriteLine(property.Id);
							writer.WriteLine(property.Name);
							writer.WriteLine(property.HostID);
							writer.WriteLine(property.HostName);
							writer.WriteLine(property.Count);
							writer.WriteLine(property.Latitude);
							writer.WriteLine(property.Longitude);
							writer.WriteLine(property.RoomType);
							writer.WriteLine(property.RoomPrice);
							writer.WriteLine(property.RoomNights);
							writer.WriteLine(property.RoomAvailability);
						}
					}
				}

				writer.Close();
				Data.unsaved = false;
				Utils.DisableControl(buttonSave);
			}
			else
			{
				MessageBox.Show("No changes have been made to save.", "Error");
			}
		}

		private void ButtonAnalysis_Click(object sender, EventArgs e)
		{
			if(dataFile != null && dataFile != "")
			{
				Form form = new FormAnalysis();
				form.StartPosition = FormStartPosition.Manual;
				form.Location = new Point(this.Left, this.Top);
				form.ShowDialog();
			}
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
					int index = listviewDistricts.SelectedIndices[0];

					ShowForm(new PopupNeighborhood("staff", "add", index), false, true);
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
					int districtIndex = listviewDistricts.SelectedIndices[0];
					int neighborhoodIndex = listviewNeighborhoods.SelectedIndices[0];

					ShowForm(new PopupNeighborhood("staff", "edit", districtIndex, neighborhoodIndex), false, true);
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
				int districtIndex = listviewDistricts.SelectedIndices[0];
				int neighborhoodIndex = listviewNeighborhoods.SelectedIndices[0];

				ShowForm(new PopupNeighborhood("staff", "view", districtIndex, neighborhoodIndex), false, true);
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
					int districtIndex = listviewDistricts.SelectedIndices[0];
					int neighborhoodIndex = listviewNeighborhoods.SelectedIndices[0];

					ShowForm(new PopupProperty("staff", "add", districtIndex, neighborhoodIndex), false, true);
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
					int districtIndex = listviewDistricts.SelectedIndices[0];
					int neighborhoodIndex = listviewNeighborhoods.SelectedIndices[0];
					int propertyIndex = listviewProperties.SelectedIndices[0];

					ShowForm(new PopupProperty("staff", "edit", districtIndex, neighborhoodIndex, propertyIndex), false, true);
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
				int districtIndex = listviewDistricts.SelectedIndices[0];
				int neighborhoodIndex = listviewNeighborhoods.SelectedIndices[0];
				int propertyIndex = listviewProperties.SelectedIndices[0];

				ShowForm(new PopupProperty("staff", "view", districtIndex, neighborhoodIndex, propertyIndex), false, true);
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

				listviewNeighborhoods.Clear();
				listviewProperties.Clear();

				labelSelectDistrict.Visible = false;
				labelSelectDistrictAndNeighborhood.Visible = true;
				labelSelectDistrictAndNeighborhood.Text = "Select a Neighborhood First...";

				AddColumns("neighborhoods");

				int districtIndex = listviewDistricts.SelectedIndices[0];
				District district = Data.districts[districtIndex];

				foreach(Neighborhood neighborhood in district.Neighborhoods)
				{
					listviewNeighborhoods.Items.Add(new ListViewItem(new string[2] { neighborhood.Name, neighborhood.PropertyCount.ToString() }));
				}
			}
			else
			{
				Utils.DisableControl(buttonViewDistrict);
				Utils.DisableControl(buttonEditDistrict);
				Utils.DisableControl(buttonAddNeighborhood);

				listviewNeighborhoods.Clear();
				listviewProperties.Clear();

				labelSelectDistrict.Visible = true;
				labelSelectDistrict.Text = "Select a District First...";
				labelSelectDistrictAndNeighborhood.Visible = true;
				labelSelectDistrictAndNeighborhood.Text = "Select a District && Neighborhood First...";
			}
		}

		private void ListviewNeighborhoods_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
		{
			// If there aren't any selected items in the ListView, then the edit button is "grayed out". I realize the "Disabled" property exists, but it's easier to style the button this way.
			if(listviewNeighborhoods.SelectedItems.Count == 1)
			{
				listviewProperties.Clear();

				labelSelectDistrictAndNeighborhood.Visible = false;

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
			}
			else
			{
				Utils.DisableControl(buttonViewNeighborhood);
				Utils.DisableControl(buttonEditNeighborhood);
				Utils.DisableControl(buttonAddProperty);

				listviewProperties.Clear();

				labelSelectDistrictAndNeighborhood.Visible = true;
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
			if(labelFileDialog.Text == "Select a Data Source...")
			{
				fileDialog.Title = "Select a Data Source File";
				fileDialog.FileName = "*.txt";

				// The "CurrentDirectory" returns the current "working" folder, which would be the "debug" folder.
				string debugDirectory = Environment.CurrentDirectory;
				// To set the initial directory of the FileDialog to the project folder.
				fileDialog.InitialDirectory = Directory.GetParent(debugDirectory).Parent.FullName;

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

		private void LabelFileDialog_DragEnter(object sender, DragEventArgs e)
		{
			labelFileDialog.BackColor = Color.FromArgb(70, 70, 70);
		}

		private void LabelFileDialog_DragLeave(object sender, EventArgs e)
		{
			labelFileDialog.BackColor = Color.FromArgb(60, 60, 60);
		}

		private void LabelFileDialog_DragOver(object sender, DragEventArgs e)
		{
			try
			{
				if(e.Data.GetDataPresent(DataFormats.FileDrop))
				{
					e.Effect = DragDropEffects.Copy;
				}
				else
				{
					e.Effect = DragDropEffects.None;
				}
			}
			catch(Exception error)
			{
				MessageBox.Show(error.Message, "Error");
			}
		}

		private void LabelFileDialog_DragDrop(object sender, DragEventArgs e)
		{
			try
			{
				string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
				if(files.Length > 1)
				{
					MessageBox.Show("You can only read one file.", "Error");
				}
				else
				{
					// Display the file name to the user along with "Loading" so they know they chose the right file.
					labelFileDialog.Text = "Loading " + files[0];
					ReadFile(files[0]);
					this.dataFile = files[0];

					if(this.dataFile != null && this.dataFile != "")
					{
						Utils.EnableControl(buttonAddDistrict);
					}
				}
			}
			catch(Exception error)
			{
				MessageBox.Show(error.Message, "Error");
			}
		}

		private void ShowForm(Form form, bool matchSize, bool keepOpen)
		{
			int screenWidth = Screen.FromControl(this).Bounds.Width;

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

			// The districts array is reset to 0 in case the user previously chose a different data file.
			Data.districts = new District[0];

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
							
							neighborhood.AddProperty(property);
						}

						// Add the neighborhood object to the neighborhood array in the district object.
						district.AddNeighborhood(neighborhood);
					}

					// Add each district to the main district array that'll contain all the data from the text file.
					Data.AddDistrict(district);
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

				// Show all ListViews.
				listviewDistricts.Show();
				listviewNeighborhoods.Show();
				listviewProperties.Show();

				Utils.EnableControl(buttonAnalysis);
				buttonAnalysis.Visible = true;

				if(this.level == "staff")
				{
					buttonSave.Visible = true;
				}
			}
			else
			{
				this.dataFile = "";
				Data.districts = new District[0];
				labelFileDialog.Text = "Select Data Source...";

				MessageBox.Show("Something went wrong. Make sure the data file is in the correct format. \n\nException Type: " + exception, "Error");
			}
		}

		private void PopulateList(District[] districts, string category)
		{
			// Clear ListViews of any existing data. Coded my own method to replace the "Clear()" shortcut.
			if(category == "districts")
			{
				listviewDistricts.Clear();
				AddColumns("districts");
				labelSelectDistrict.Visible = true;
				labelSelectDistrictAndNeighborhood.Visible = true;
			}
			else if(category == "neighborhoods")
			{
				listviewNeighborhoods.Clear();
				AddColumns("neighborhoods");
				labelSelectDistrict.Visible = false;
				labelSelectDistrictAndNeighborhood.Visible = true;
			}
			else if(category == "properties")
			{
				listviewProperties.Clear();
				AddColumns("properties");
				labelSelectDistrictAndNeighborhood.Visible = false;
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
				listviewDistricts.Columns.Add("District Name", 650);
				listviewDistricts.Columns.Add("Number of Neighborhoods", 450);
			}
			else if(category == "neighborhoods")
			{
				listviewNeighborhoods.Columns.Add("Neighborhood Name", 650);
				listviewNeighborhoods.Columns.Add("Number of Properties", 450);
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
