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
            showForm(new FormMain());
        }
        private void showForm(Form form)
        {
            this.Hide();
            form.Show();
            // Open form in the same location.
            form.Left = this.Left;
            form.Top = this.Top;
            // All forms have the same size.
            form.Size = this.Size;
        }

        private void ButtonDistricts_Click(object sender, EventArgs e)
        {
            buttonDistricts.BackColor = Color.FromArgb(100, 100, 100);
            buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
            buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

			buttonDistricts.Tag = "active-category";
			buttonNeighborhoods.Tag = "";
			buttonProperties.Tag = "";
		}

        private void ButtonNeighborhoods_Click(object sender, EventArgs e)
        {
            buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
            buttonNeighborhoods.BackColor = Color.FromArgb(100, 100, 100);
            buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

			buttonDistricts.Tag = "";
			buttonNeighborhoods.Tag = "active-category";
			buttonProperties.Tag = "";
		}

        private void ButtonProperties_Click(object sender, EventArgs e)
        {
            buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
            buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
            buttonProperties.BackColor = Color.FromArgb(100, 100, 100);

			buttonDistricts.Tag = "";
			buttonNeighborhoods.Tag = "";
			buttonProperties.Tag = "active-category";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
			if(buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
				showForm(new PopupDistrict("staff", "add"));
			}
			else if(buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
				showForm(new PopupNeighborhood("staff", "add"));
			}
			else if(buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
				showForm(new PopupProperty("staff", "add"));
			}
        }

		private void panelSearch_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputSearch.Focus();
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			if (buttonDistricts.Tag != null && buttonDistricts.Tag.ToString() == "active-category") {
				showForm(new PopupDistrict("staff", "edit"));
			}
			else if (buttonNeighborhoods.Tag != null && buttonNeighborhoods.Tag.ToString() == "active-category") {
				showForm(new PopupNeighborhood("staff", "edit"));
			}
			else if (buttonProperties.Tag != null && buttonProperties.Tag.ToString() == "active-category") {
				showForm(new PopupProperty("staff", "edit"));
			}
		}
	}
}
