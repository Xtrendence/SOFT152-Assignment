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

			this.inputName.Text = neighborhood.Name;
			this.inputPropertyCount.Text = neighborhood.PropertyCount.ToString();
		}

		private void ButtonBack_Click(object sender, EventArgs e) {
			if(level == "public") {
				ShowForm(new FormMain("neighborhoods", "public"), false);
			}
			else if(level == "staff") {
				ShowForm(new FormMain("neighborhoods", "staff"), false);
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
		}

		private void ShowForm(Form form, bool matchSize) {
			form.Show();
			this.Hide();
			// Open form in the same location.
			form.Left = this.Left;
			form.Top = this.Top;
			// Most forms have the same size, but some (such as popups) might not.
			if(matchSize) {
				form.Size = this.Size;
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
			if(inputName.Text == "Neighborhood Name...") {
				inputName.Text = "";
			}
		}

		private void InputPropertyCount_Enter(object sender, EventArgs e) {
			// Empty "placeholder".
			if(inputPropertyCount.Text == "Number of Properties...") {
				inputPropertyCount.Text = "";
			}
		}
	}
}
