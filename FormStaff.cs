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

namespace SOFT152Assignment
{
    public partial class FormStaff : Form
    {
		public string[] dataLines;
		public string category;
        public FormStaff()
        {
            InitializeComponent();
			// By default, the districts category is shown.
			showCategory("districts");
        }
		// For back buttons to "remember" the category the user was looking at. Just a quality of life improvement.
		public FormStaff(string activeCategory) {
			InitializeComponent();
			this.category = activeCategory.ToLower();
			showCategory(category);
		}

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            showForm(new FormMain(), true);
        }
        private void showForm(Form form, bool matchSize)
        {
			form.Show();
            this.Hide();
            // Open form in the same location.
            form.Left = this.Left;
            form.Top = this.Top;
			// Most forms have the same size, but some (such as popups) might not.
			if (matchSize) {
				form.Size = this.Size;
			}
        }
		private void showCategory(string desiredCategory) {
			this.category = desiredCategory.ToLower();
			if (desiredCategory == "districts") {
				// Sets the "Districts" button's background color to brighter than the other two, letting the user know that it's the active one.
				buttonDistricts.BackColor = Color.FromArgb(100, 100, 100);
				buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
				buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

				// Sets the "Tag" property of the "Districts" button to "active-category". This is later used to determine which popup dialog form to display.
				buttonDistricts.Tag = "active-category";
				buttonNeighborhoods.Tag = "";
				buttonProperties.Tag = "";
			}
			else if (desiredCategory == "neighborhoods") {
				// Same as above, but for the "Neighborhoods" button.
				buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
				buttonNeighborhoods.BackColor = Color.FromArgb(100, 100, 100);
				buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

				// Same thing as above, but for the "Neighborhoods" button.
				buttonDistricts.Tag = "";
				buttonNeighborhoods.Tag = "active-category";
				buttonProperties.Tag = "";
			}
			else if (desiredCategory == "properties") {
				// Same as above, but for the "Properties" button.
				buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
				buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
				buttonProperties.BackColor = Color.FromArgb(100, 100, 100);

				// Same as above, but for the "Properties" button.
				buttonDistricts.Tag = "";
				buttonNeighborhoods.Tag = "";
				buttonProperties.Tag = "active-category";
			}
			if (dataLines != null && dataLines.ToString() != "") {
				populateList(dataLines, this.category);
			}
		}

		private void ButtonDistricts_Click(object sender, EventArgs e)
        {
			showCategory("districts");
		}

        private void ButtonNeighborhoods_Click(object sender, EventArgs e)
        {
			showCategory("neighborhoods");
		}

        private void ButtonProperties_Click(object sender, EventArgs e)
        {
			showCategory("properties");
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
			// If the "Districts" button's "Tag" property isn't empty, and is set to "active-category", then the "PopupDistrict" form is opened. Checks for "null" first because using the "ToString()" method on null can result in an error.
			if (buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
				showForm(new PopupDistrict("staff", "add"), false);
			}
			// Same thing, but for the "Neighborhoods" button.
			else if (buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
				showForm(new PopupNeighborhood("staff", "add"), false);
			}
			// Same thing, but for the "Properties" button.
			else if (buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
				showForm(new PopupProperty("staff", "add"), false);
			}
        }

		private void panelSearch_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputSearch.Focus();
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			// If the "Districts" button's "Tag" property isn't empty, and is set to "active-category", then the "PopupDistrict" form is opened. Checks for "null" first because using the "ToString()" method on null can result in an error.
			if (buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
				showForm(new PopupDistrict("staff", "edit"), false);
			}
			// Same thing, but for the "Neighborhoods" button.
			else if (buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
				showForm(new PopupNeighborhood("staff", "edit"), false);
			}
			// Same thing, but for the "Properties" button.
			else if (buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
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

		private void populateList(string[] lines, string activeCategory) {
			// Clear ListView of any existing data.
			listviewData.Clear();
			if (activeCategory == "districts") {
				// Add a column to the ListView for the district names.
				listviewData.Columns.Add("District Name", 510);
				// Add a column for the number of neighborhoods in the district.
				listviewData.Columns.Add("Number of Neighborhoods", 250);
				// For each line in the file, add the line to an array that is later added as a row to the ListView.
				for (int i = 0; i < lines.Length; i++) {
					string name = lines[i].ToString();
					i++;
					string count = lines[i].ToString();
					string[] row = new string[2] { name, count };
					listviewData.Items.Add(new ListViewItem(row));
				}
			}
			else if (activeCategory == "neighborhoods") {

			}
			else if (activeCategory == "properties") {

			}
			labelFileDialog.Hide();
		}

		private void readFile(string filename) {
			// Read every line from the data source file, and store the lines in an array.
			dataLines = File.ReadLines(filename).ToArray();
			populateList(dataLines, this.category);
		}

		private void fileDialog_FileOk(object sender, CancelEventArgs e) {
			// Display the file name to the user along with "Loading" so they know they chose the right file.
			labelFileDialog.Text = "Loading " + fileDialog.SafeFileName;
			readFile(fileDialog.FileName);
		}
	}
}
