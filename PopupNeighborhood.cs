using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152Assignment {
	public partial class PopupNeighborhood : Form {
		public string level;
		public string action;
		public Neighborhood neighborhood;
		public PopupNeighborhood(string accessLevel, string desiredAction) {
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			SetTitle();
		}
		public PopupNeighborhood(string accessLevel, string desiredAction, Neighborhood neighborhoodObject) {
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.neighborhood = neighborhoodObject;

			// Autofill for changing the neighborhood name and property count.
			this.inputName.Text = neighborhood.Name;
			this.inputPropertyCount.Text = neighborhood.PropertyCount.ToString();

			// If the user only wants to view the item, then the TextBox components are set to read-only.
			if(action == "view") {
				this.inputName.ReadOnly = true;
				this.inputName.Enabled = false;
				this.inputPropertyCount.ReadOnly = true;
				this.inputPropertyCount.Enabled = false;
				this.buttonNext.Hide();
			}
		}

		private void SetTitle() {
			// When a "popup" form is opened, the action the user wants to perform is passed to the popup form's class, and is used to determine what the window title of the form should be.
			if(action == "edit") {
				this.Text = "Edit Neighborhood";
			}
			else if(action == "add") {
				this.Text = "Add Neighborhood";
			}
			else if(action == "view") {
				this.Text = "View Neighborhood";
			}
		}

		private void PanelName_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputName.Focus();
		}

		private void PanelCount_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputPropertyCount.Focus();
		}

		private void ButtonNext_Click(object sender, EventArgs e) {
			// The boolean variable "valid" is used to determine whether or not the TextBoxes have been filled out. If they have, then the next button does what's it's actually meant to do.
			bool valid = true;
			if(inputName.Text.Trim() == "" || inputName.Text == "District Name...") {
				inputName.ForeColor = Color.FromArgb(240, 100, 50);
				inputName.Text = "* Required";
				valid = false;
			}
			if(inputPropertyCount.Text.Trim() == "" || inputPropertyCount.Text == "Number of Neighborhoods...") {
				inputPropertyCount.ForeColor = Color.FromArgb(240, 100, 50);
				inputPropertyCount.Text = "* Required";
				valid = false;
			}
			if(valid) {

			}
		}

		private void InputName_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if(inputName.Text.Trim() == "") {
				inputName.Text = "Neighborhood Name...";
			}
		}

		private void InputPropertyCount_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if(inputPropertyCount.Text.Trim() == "") {
				inputPropertyCount.Text = "Number of Properties...";
			}
		}

		private void InputName_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if(inputName.Text == "Neighborhood Name..." || inputName.Text == "* Required") {
				inputName.ForeColor = Color.FromArgb(250, 250, 250);
				inputName.Text = "";
			}
		}

		private void InputPropertyCount_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if(inputPropertyCount.Text == "Number of Properties..." || inputPropertyCount.Text == "* Required") {
				inputPropertyCount.ForeColor = Color.FromArgb(250, 250, 250);
				inputPropertyCount.Text = "";
			}
		}
	}
}
