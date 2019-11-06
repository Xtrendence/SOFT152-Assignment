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

		private void ButtonBack_Click(object sender, EventArgs e) {
			if(level == "public") {
				ShowForm(new FormMain("properties", "public"), false);
			}
			else if(level == "staff") {
				ShowForm(new FormMain("properties", "staff"), false);
			}
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

		private void inputPropertyID_Enter(object sender, EventArgs e) {

		}

		private void inputPropertyName_Enter(object sender, EventArgs e) {

		}

		private void inputHostID_Enter(object sender, EventArgs e) {

		}

		private void inputHostName_Enter(object sender, EventArgs e) {

		}

		private void inputHostPropertyCount_Enter(object sender, EventArgs e) {

		}

		private void inputRoomType_Enter(object sender, EventArgs e) {

		}

		private void inputRoomPrice_Enter(object sender, EventArgs e) {

		}

		private void inputLongitude_Enter(object sender, EventArgs e) {

		}

		private void inputLatitude_Enter(object sender, EventArgs e) {

		}

		private void inputRoomNights_Enter(object sender, EventArgs e) {

		}

		private void inputRoomAvailability_Enter(object sender, EventArgs e) {

		}
	}
}
