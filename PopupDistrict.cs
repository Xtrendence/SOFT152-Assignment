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
    public partial class PopupDistrict : Form
    {
		public string level;
		public string action;
        public PopupDistrict(string accessLevel, string desiredAction)
        {
            InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			setTitle();
        }

		private void buttonBack_Click(object sender, EventArgs e) {
			if(level == "public") {
				showForm(new FormPublic("districts"), false);
			}
			else if(level == "staff") {
				showForm(new FormStaff("districts"), false);
			}
		}

		private void setTitle() {
			// When a "popup" form is opened, the action the user wants to perform is passed to the popup form's class, and is used to determine what the window title of the form should be.
			if(action == "edit") {
				this.Text = "Edit District";
			}
			else if(action == "add") {
				this.Text = "Add District";
			}
			else if(action == "view") {
				this.Text = "View District";
			}
		}

		private void showForm(Form form, bool matchSize) {
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

		private void panelName_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputName.Focus();
		}

		private void panelCount_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputNeighborhoodCount.Focus();
		}

		private void buttonNext_Click(object sender, EventArgs e) {

		}

		private void inputName_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if (inputName.Text.Trim() == "") {
				inputName.Text = "District Name...";
			}
		}

		private void inputNeighborhoodCount_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if (inputNeighborhoodCount.Text.Trim() == "") {
				inputNeighborhoodCount.Text = "Number of Neighborhoods...";
			}
		}

		private void inputName_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if (inputName.Text == "District Name...") {
				inputName.Text = "";
			}
		}

		private void inputNeighborhoodCount_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if (inputNeighborhoodCount.Text == "Number of Neighborhoods...") {
				inputNeighborhoodCount.Text = "";
			}
		}
	}
}
