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
		public string district;
		public Neighborhood neighborhood;
		public PopupNeighborhood(string accessLevel, string desiredAction) {
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			SetTitle();
		}
		public PopupNeighborhood(string accessLevel, string desiredAction, string districtName, Neighborhood neighborhoodObject) {
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.district = districtName;
			this.neighborhood = neighborhoodObject;

			// Autofill for changing the neighborhood name and property count.
			this.inputDistrictName.Text = this.district;
			this.inputNeighborhoodName.Text = neighborhood.Name;
			this.inputPropertyCount.Text = neighborhood.PropertyCount.ToString();

			// If the user only wants to view the item, then the TextBox components are set to read-only.
			if(action == "view") {
				this.inputDistrictName.ReadOnly = true;
				this.inputDistrictName.Enabled = false;
				this.inputNeighborhoodName.ReadOnly = true;
				this.inputNeighborhoodName.Enabled = false;
				this.inputPropertyCount.ReadOnly = true;
				this.inputPropertyCount.Enabled = false;
				this.panelCount.Show();
				this.buttonNext.Hide();
			}
		}

		public PopupNeighborhood(string accessLevel, string desiredAction, string districtName) {
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.district = districtName;

			// Autofill for changing the neighborhood name and property count.
			this.inputDistrictName.Text = this.district;

			// If the user only wants to view the item, then the TextBox components are set to read-only.
			if(action == "view") {
				this.inputDistrictName.ReadOnly = true;
				this.inputDistrictName.Enabled = false;
				this.inputNeighborhoodName.ReadOnly = true;
				this.inputNeighborhoodName.Enabled = false;
				this.inputPropertyCount.ReadOnly = true;
				this.inputPropertyCount.Enabled = false;
				this.panelCount.Show();
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
			inputNeighborhoodName.Focus();
		}

		private void PanelCount_Click(object sender, EventArgs e) {
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputPropertyCount.Focus();
		}

		private void ButtonNext_Click(object sender, EventArgs e) {
			// The boolean variable "valid" is used to determine whether or not the TextBoxes have been filled out. If they have, then the next button does what's it's actually meant to do.
			bool valid = true;
			if(inputNeighborhoodName.Text.Trim() == "" || inputNeighborhoodName.Text == "Neighborhood Name...") {
				inputNeighborhoodName.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputPropertyCount.Text.Trim() == "" || inputPropertyCount.Text == "Number of Properties...") {
				inputPropertyCount.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(valid) {

			}
		}

		private void InputNeighborhoodName_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if(inputNeighborhoodName.Text.Trim() == "") {
				inputNeighborhoodName.Text = "Neighborhood Name...";
			}
		}

		private void InputPropertyCount_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if(inputPropertyCount.Text.Trim() == "") {
				inputPropertyCount.Text = "Number of Properties...";
			}
		}

		private void InputNeighborhoodName_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if(inputNeighborhoodName.Text == "Neighborhood Name...") {
				inputNeighborhoodName.ForeColor = Color.FromArgb(250, 250, 250);
				inputNeighborhoodName.Text = "";
			}
		}

		private void InputPropertyCount_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if(inputPropertyCount.Text == "Number of Properties...") {
				inputPropertyCount.ForeColor = Color.FromArgb(250, 250, 250);
				inputPropertyCount.Text = "";
			}
		}

		private void InputDistrictName_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if(inputDistrictName.Text == "District Name...") {
				inputDistrictName.ForeColor = Color.FromArgb(250, 250, 250);
				inputDistrictName.Text = "";
			}
		}

		private void InputDistrictName_Leave(object sender, EventArgs e) {
			// Fill "placeholder".
			if(inputDistrictName.Text == "") {
				inputDistrictName.Text = "District Name...";
			}
		}
	}
}
