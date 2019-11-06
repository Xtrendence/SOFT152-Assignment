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

			// Ideally, I'd use a List and then loop through the Controls to get their values and such, but that isn't permitted.
			this.inputPropertyID.Text = property.Id.ToString();
			this.inputPropertyName.Text = property.Name.ToString();
			this.inputHostID.Text = property.HostID.ToString();
			this.inputHostName.Text = property.HostName.ToString();
			this.inputHostPropertyCount.Text = property.Count.ToString();
			this.inputRoomType.Text = property.RoomType.ToString(); ;
			this.inputRoomPrice.Text = property.RoomPrice.ToString();
			this.inputLongitude.Text = property.Longitude.ToString();
			this.inputLatitude.Text = property.Latitude.ToString();
			this.inputRoomNights.Text = property.RoomNights.ToString();
			this.inputRoomAvailability.Text = property.RoomAvailability.ToString();

			// If the user only wants to view the item, then the TextBox components are set to read-only.
			if(this.action == "view") {
				this.inputPropertyID.ReadOnly = true;
				this.inputPropertyName.ReadOnly = true;
				this.inputHostID.ReadOnly = true;
				this.inputHostName.ReadOnly = true;
				this.inputHostPropertyCount.ReadOnly = true;
				this.inputRoomType.ReadOnly = true;
				this.inputRoomPrice.ReadOnly = true;
				this.inputLongitude.ReadOnly = true;
				this.inputLatitude.ReadOnly = true;
				this.inputRoomNights.ReadOnly = true;
				this.inputRoomAvailability.ReadOnly = true;

				this.inputPropertyID.Enabled = false;
				this.inputPropertyName.Enabled = false;
				this.inputHostID.Enabled = false;
				this.inputHostName.Enabled = false;
				this.inputHostPropertyCount.Enabled = false;
				this.inputRoomType.Enabled = false;
				this.inputRoomPrice.Enabled = false;
				this.inputLongitude.Enabled = false;
				this.inputLatitude.Enabled = false;
				this.inputRoomNights.Enabled = false;
				this.inputRoomAvailability.Enabled = false;

				this.buttonNext.Hide();
			}

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
			else if(action == "view") {
				this.Text = "View Property";
			}
		}

		private void InputPropertyID_Enter(object sender, EventArgs e) {
			if(inputPropertyID.Text == "Property ID...") {
				inputPropertyID.Text = "";
				inputPropertyID.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputPropertyName_Enter(object sender, EventArgs e) {
			if(inputPropertyName.Text == "Property Name...") {
				inputPropertyName.Text = "";
				inputPropertyName.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputHostID_Enter(object sender, EventArgs e) {
			if(inputHostID.Text == "Host ID...") {
				inputHostID.Text = "";
				inputHostID.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputHostName_Enter(object sender, EventArgs e) {
			if(inputHostName.Text == "Host Name...") {
				inputHostName.Text = "";
				inputHostName.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputHostPropertyCount_Enter(object sender, EventArgs e) {
			if(inputHostPropertyCount.Text == "Number of Properties Owned by Host...") {
				inputHostPropertyCount.Text = "";
				inputHostPropertyCount.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputRoomType_Enter(object sender, EventArgs e) {
			if(inputRoomType.Text == "Room Type...") {
				inputRoomType.Text = "";
				inputRoomType.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputRoomPrice_Enter(object sender, EventArgs e) {
			if(inputRoomPrice.Text == "Room Price...") {
				inputRoomPrice.Text = "";
				inputRoomPrice.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputLongitude_Enter(object sender, EventArgs e) {
			if(inputLongitude.Text == "Longitude...") {
				inputLongitude.Text = "";
				inputLongitude.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputLatitude_Enter(object sender, EventArgs e) {
			if(inputLatitude.Text == "Latitude...") {
				inputLatitude.Text = "";
				inputLatitude.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputRoomNights_Enter(object sender, EventArgs e) {
			if(inputRoomNights.Text == "Minimum Nights...") {
				inputRoomNights.Text = "";
				inputRoomNights.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputRoomAvailability_Enter(object sender, EventArgs e) {
			if(inputRoomAvailability.Text == "Availability Days...") {
				inputRoomAvailability.Text = "";
				inputRoomAvailability.ForeColor = Color.FromArgb(250, 250, 250);
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

		private void ButtonDelete_Click(object sender, EventArgs e) {

		}

		private void ButtonNext_Click(object sender, EventArgs e) {
			// The boolean variable "valid" is used to determine whether or not the TextBoxes have been filled out. If they have, then the next button does what's it's actually meant to do.
			bool valid = true;
			// Again, a List and a for loop here would be ideal.
			if(inputPropertyID.Text == "Property ID..." || inputPropertyID.Text == "") {
				inputPropertyID.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputPropertyName.Text == "Property Name..." || inputPropertyName.Text == "") {
				inputPropertyName.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputHostID.Text == "Host ID..." || inputHostID.Text == "") {
				inputHostID.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputHostName.Text == "Host Name..." || inputHostName.Text == "") {
				inputHostName.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputHostPropertyCount.Text == "Number of Properties Owned by Host..." || inputHostPropertyCount.Text == "") {
				inputHostPropertyCount.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputRoomType.Text == "Room Type..." || inputRoomType.Text == "") {
				inputRoomType.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputRoomPrice.Text == "Room Price..." || inputRoomPrice.Text == "") {
				inputRoomPrice.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputLongitude.Text == "Longitude..." || inputLongitude.Text == "") {
				inputLongitude.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputLatitude.Text == "Latitude..." || inputLatitude.Text == "") {
				inputLatitude.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputRoomNights.Text == "Minimum Nights..." || inputRoomNights.Text == "") {
				inputRoomNights.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputRoomAvailability.Text == "Availability Days..." || inputRoomAvailability.Text == "") {
				inputRoomAvailability.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(valid) {

			}
		}
	}
}
