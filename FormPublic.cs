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
    public partial class FormPublic : Form
    {
        public FormPublic()
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
            // Open form in same location.
            form.Left = this.Left;
            form.Top = this.Top;
            // All forms have the same size.
            form.Size = this.Size;
        }

        private void InputSearch_Enter(object sender, EventArgs e)
        {
            // Empty "placeholder".
            if(inputSearch.Text == "Search...")
            {
                inputSearch.Text = "";
            }
        }

        private void InputSearch_Leave(object sender, EventArgs e)
        {
            // Fill "placeholder".
            if(inputSearch.Text.Trim() == "")
            {
                inputSearch.Text = "Search...";
            }
        }

		private void ButtonDistricts_Click(object sender, EventArgs e) {
			buttonDistricts.BackColor = Color.FromArgb(100, 100, 100);
			buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
			buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

			buttonDistricts.Tag = "active-category";
			buttonNeighborhoods.Tag = "";
			buttonProperties.Tag = "";
		}

		private void ButtonNeighborhoods_Click(object sender, EventArgs e) {
			buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
			buttonNeighborhoods.BackColor = Color.FromArgb(100, 100, 100);
			buttonProperties.BackColor = Color.FromArgb(60, 60, 60);

			buttonDistricts.Tag = "";
			buttonNeighborhoods.Tag = "active-category";
			buttonProperties.Tag = "";
		}

		private void ButtonProperties_Click(object sender, EventArgs e) {
			buttonDistricts.BackColor = Color.FromArgb(60, 60, 60);
			buttonNeighborhoods.BackColor = Color.FromArgb(60, 60, 60);
			buttonProperties.BackColor = Color.FromArgb(100, 100, 100);

			buttonDistricts.Tag = "";
			buttonNeighborhoods.Tag = "";
			buttonProperties.Tag = "active-category";
		}

		private void panelSearch_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputSearch.Focus();
		}

		private void buttonView_Click(object sender, EventArgs e) {
			if(buttonDistricts.Tag.ToString() == "active-category") {
				showForm(new PopupDistrict("public", "view"));
			}
			else if(buttonNeighborhoods.Tag.ToString() == "active-category") {
				showForm(new PopupNeighborhood("public", "view"));
			}
			else if(buttonProperties.Tag.ToString() == "active-category") {
				showForm(new PopupProperty("public", "view"));
			}
		}
	}
}
