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
    public partial class PopupNeighborhood : Form
    {
		public string level;
		public string action;
        public PopupNeighborhood(string accessLevel, string desiredAction)
        {
            InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			setTitle();
        }

		private void buttonBack_Click(object sender, EventArgs e) {
			if(level == "public") {
				showForm(new FormMain("neighborhoods", "public"), false);
			}
			else if(level == "staff") {
				showForm(new FormMain("neighborhoods", "staff"), false);
			}
		}

		private void setTitle() {
			// When a "popup" form is opened, the action the user wants to perform is passed to the popup form's class, and is used to determine what the window title of the form should be.
			if (action == "edit") {
				this.Text = "Edit Neighborhood";
			}
			else if (action == "add") {
				this.Text = "Add Neighborhood";
			}
			else if (action == "view") {
				this.Text = "View Neighborhood";
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
			inputPropertyCount.Focus();
		}

		private void buttonNext_Click(object sender, EventArgs e) {

		}

		private void inputName_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if (inputName.Text.Trim() == "") {
				inputName.Text = "Neighborhood Name...";
			}
		}

		private void inputPropertyCount_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if (inputPropertyCount.Text.Trim() == "") {
				inputPropertyCount.Text = "Number of Properties...";
			}
		}

		private void inputName_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if (inputName.Text == "Neighborhood Name...") {
				inputName.Text = "";
			}
		}

		private void inputPropertyCount_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if (inputPropertyCount.Text == "Number of Properties...") {
				inputPropertyCount.Text = "";
			}
		}
	}
}
