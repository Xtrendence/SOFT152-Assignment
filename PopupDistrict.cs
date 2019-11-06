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
	public partial class PopupDistrict : Form {
		public string level;
		public string action;
		public District district;
		public PopupDistrict(string accessLevel, string desiredAction) {
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			SetTitle();
		}
		public PopupDistrict(string accessLevel, string desiredAction, District districtObject) {
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.district = districtObject;

			// Autofill for editing the district name and neighborhood count.
			this.inputName.Text = district.Name;
			this.inputNeighborhoodCount.Text = district.NeighborhoodCount.ToString();

			// If the user only wants to view the item, then the TextBox components are set to read-only.
			if(action == "view") {
				this.inputName.ReadOnly = true;
				this.inputName.Enabled = false;
				this.inputNeighborhoodCount.ReadOnly = true;
				this.inputNeighborhoodCount.Enabled = false;
				this.buttonNext.Hide();
			}
		}

		private void SetTitle() {
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

		private void PanelName_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputName.Focus();
		}

		private void PanelCount_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputNeighborhoodCount.Focus();
		}

		private void ButtonNext_Click(object sender, EventArgs e) {
			// The boolean variable "valid" is used to determine whether or not the TextBoxes have been filled out. If they have, then the next button does what's it's actually meant to do.
			bool valid = true;
			if(inputName.Text.Trim() == "" || inputName.Text == "District Name...") {
				inputName.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputNeighborhoodCount.Text.Trim() == "" || inputNeighborhoodCount.Text == "Number of Neighborhoods...") {
				inputNeighborhoodCount.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(valid) {

			}
		}

		private void InputName_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if(inputName.Text.Trim() == "") {
				inputName.Text = "District Name...";
			}
		}

		private void InputNeighborhoodCount_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if(inputNeighborhoodCount.Text.Trim() == "") {
				inputNeighborhoodCount.Text = "Number of Neighborhoods...";
			}
		}

		private void InputName_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if(inputName.Text == "District Name...") {
				inputName.ForeColor = Color.FromArgb(250, 250, 250);
				inputName.Text = "";
			}
		}

		private void InputNeighborhoodCount_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if(inputNeighborhoodCount.Text == "Number of Neighborhoods...") {
				inputNeighborhoodCount.ForeColor = Color.FromArgb(250, 250, 250);
				inputNeighborhoodCount.Text = "";
			}
		}
	}
}
