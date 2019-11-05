using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152Assignment
{
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            showForm(new FormMain(), true);
        }
        private void showForm(Form form, bool matchSize)
        {
            this.Hide();
            form.Show();
            // Open form in the same location.
            form.Left = this.Left;
            form.Top = this.Top;
			// Most forms have the same size, but some (such as popups) might not.
			if (matchSize) {
				form.Size = this.Size;
			}
        }

        private void ButtonDistricts_Click(object sender, EventArgs e)
        {
			// Sets the "Districts" button's background color to brighter than the other two, letting the user know that it's the active one.
			buttonDistricts.BackColor = Color.FromArgb(100, 100, 100);
            buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
            buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

			// Sets the "Tag" property of the "Districts" button to "active-category". This is later used to determine which popup dialog form to display.
			buttonDistricts.Tag = "active-category";
			buttonNeighborhoods.Tag = "";
			buttonProperties.Tag = "";
		}

        private void ButtonNeighborhoods_Click(object sender, EventArgs e)
        {
			// Sets the "Neighborhoods" button's background color to brighter than the other two, letting the user know that it's the active one.
			buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
            buttonNeighborhoods.BackColor = Color.FromArgb(100, 100, 100);
            buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

			// Sets the "Tag" property of the "Neighborhoods" button to "active-category". This is later used to determine which popup dialog form to display.
			buttonDistricts.Tag = "";
			buttonNeighborhoods.Tag = "active-category";
			buttonProperties.Tag = "";
		}

        private void ButtonProperties_Click(object sender, EventArgs e)
        {
			// Sets the "Properties" button's background color to brighter than the other two, letting the user know that it's the active one.
			buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
            buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
            buttonProperties.BackColor = Color.FromArgb(100, 100, 100);

			// Sets the "Tag" property of the "Properties" button to "active-category". This is later used to determine which popup dialog form to display.
			buttonDistricts.Tag = "";
			buttonNeighborhoods.Tag = "";
			buttonProperties.Tag = "active-category";
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
	}
}
