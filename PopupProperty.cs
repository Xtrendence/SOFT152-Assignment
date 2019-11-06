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
	public partial class PopupProperty : Form {
		public string level;
		public string action;
		public Property property;
		public PopupProperty(string accessLevel, string desiredAction) {
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			SetTitle();
		}
		public PopupProperty(string accessLevel, string desiredAction, Property propertyObject) {
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.property = propertyObject;
			SetTitle();
		}

		private void SetTitle() {
			// When a "popup" form is opened, the action the user wants to perform is passed to the popup form's class, and is used to determine what the window title of the form should be.
			if(action == "edit") {
				this.Text = "Edit Property";
			}
			else if(action == "add") {
				this.Text = "Add Property";
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

		private void InputPropertyID_Enter(object sender, EventArgs e) {
			if(inputPropertyID.Text == "Property ID...") {
				inputPropertyID.Text = "";
			}
		}

		private void InputPropertyName_Enter(object sender, EventArgs e) {
			if(inputPropertyName.Text == "Property Name...") {
				inputPropertyName.Text = "";
			}
		}

		private void InputHostID_Enter(object sender, EventArgs e) {
			if(inputHostID.Text == "Host ID...") {
				inputHostID.Text = "";
			}
		}

		private void InputHostName_Enter(object sender, EventArgs e) {
			if(inputHostName.Text == "Host Name...") {
				inputHostName.Text = "";
			}
		}

		private void InputHostPropertyCount_Enter(object sender, EventArgs e) {
			if(inputHostPropertyCount.Text == "Number of Properties Owned by Host...") {
				inputHostPropertyCount.Text = "";
			}
		}

		private void InputRoomType_Enter(object sender, EventArgs e) {
			if(inputRoomType.Text == "Room Type...") {
				inputRoomType.Text = "";
			}
		}

		private void InputRoomPrice_Enter(object sender, EventArgs e) {
			if(inputRoomPrice.Text == "Room Price...") {
				inputRoomPrice.Text = "";
			}
		}

		private void InputLongitude_Enter(object sender, EventArgs e) {
			if(inputLongitude.Text == "Longitude...") {
				inputLongitude.Text = "";
			}
		}

		private void InputLatitude_Enter(object sender, EventArgs e) {
			if(inputLatitude.Text == "Latitude...") {
				inputLatitude.Text = "";
			}
		}

		private void InputRoomNights_Enter(object sender, EventArgs e) {
			if(inputRoomNights.Text == "Minimum Nights...") {
				inputRoomNights.Text = "";
			}
		}

		private void InputRoomAvailability_Enter(object sender, EventArgs e) {
			if(inputRoomAvailability.Text == "Availability Days...") {
				inputRoomAvailability.Text = "";
			}
		}

		private void InputPropertyID_Leave(object sender, EventArgs e) {
			if(inputPropertyID.Text.Trim() == "") {
				inputPropertyID.Text = "Property ID...";
			}
		}

		private void InputPropertyName_Leave(object sender, EventArgs e) {
			if(inputPropertyName.Text.Trim() == "") {
				inputPropertyName.Text = "Property Name...";
			}
		}

		private void InputHostID_Leave(object sender, EventArgs e) {
			if(inputHostID.Text.Trim() == "") {
				inputHostID.Text = "Host ID...";
			}
		}

		private void InputHostName_Leave(object sender, EventArgs e) {
			if(inputHostName.Text.Trim() == "") {
				inputHostName.Text = "Host Name...";
			}
		}

		private void InputHostPropertyCount_Leave(object sender, EventArgs e) {
			if(inputHostPropertyCount.Text.Trim() == "") {
				inputHostPropertyCount.Text = "Number of Properties Owned by Host...";
			}
		}

		private void InputRoomType_Leave(object sender, EventArgs e) {
			if(inputRoomType.Text.Trim() == "") {
				inputRoomType.Text = "Room Type...";
			}
		}

		private void InputRoomPrice_Leave(object sender, EventArgs e) {
			if(inputRoomPrice.Text.Trim() == "") {
				inputRoomPrice.Text = "Room Price...";
			}
		}

		private void InputLongitude_Leave(object sender, EventArgs e) {
			if(inputLongitude.Text.Trim() == "") {
				inputLongitude.Text = "Longitude...";
			}
		}

		private void InputLatitude_Leave(object sender, EventArgs e) {
			if(inputLatitude.Text.Trim() == "") {
				inputLatitude.Text = "Latitude...";
			}
		}

		private void InputRoomNights_Leave(object sender, EventArgs e) {
			if(inputRoomNights.Text.Trim() == "") {
				inputRoomNights.Text = "Minimum Nights...";
			}
		}

		private void InputRoomAvailability_Leave(object sender, EventArgs e) {
			if(inputRoomAvailability.Text.Trim() == "") {
				inputRoomAvailability.Text = "Availability Days...";
			}
		}
	}
}
