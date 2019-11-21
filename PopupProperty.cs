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
	public partial class PopupProperty : Form
	{
		public TextBox[] textBoxes;
		public string level;
		public string action;
		public string district;
		public string neighborhood;
		public Property property;
		// For adding.
		public PopupProperty(string accessLevel, string desiredAction)
		{
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.inputDistrictName.Enabled = true;
			this.inputNeighborhoodName.Enabled = true;
			SetTitle();
			GetTextBoxes();
		}

		// For editing or viewing.
		public PopupProperty(string accessLevel, string desiredAction, string districtName, string neighborhoodName, Property propertyObject)
		{
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.district = districtName;
			this.neighborhood = neighborhoodName;
			this.property = propertyObject;
			SetTitle();
			GetTextBoxes();

			this.inputDistrictName.Enabled = true;
			this.inputNeighborhoodName.Enabled = true;

			// For editing and viewing, this sets/autofills the values of the TextBoxes.
			this.inputDistrictName.Text = this.district;
			this.inputNeighborhoodName.Text = this.neighborhood;
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

			// If the user only wants to view the item, then the TextBox components are set to read-only and are disabled so the user can't trigger any focus events on them.
			if(this.action == "view")
			{
				foreach(TextBox input in textBoxes)
				{
					input.ReadOnly = true;
					input.Enabled = false;
				}

				this.buttonNext.Hide();
			}
		}

		// For adding, but with the district name and neighborhood name autofilled.
		public PopupProperty(string accessLevel, string desiredAction, string districtName, string neighborhoodName)
		{
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.district = districtName;
			this.neighborhood = neighborhoodName;
			SetTitle();
			GetTextBoxes();

			// For editing and viewing, this sets/autofills the values of the TextBoxes.
			this.inputDistrictName.Text = this.district;
			this.inputNeighborhoodName.Text = this.neighborhood;

			// If the user only wants to view the item, then the TextBox components are set to read-only and are disabled so the user can't trigger any focus events on them.
			if(this.action == "view")
			{
				foreach(TextBox input in textBoxes)
				{
					input.ReadOnly = true;
					input.Enabled = false;
				}

				this.buttonNext.Hide();
			}
		}

		private void SetTitle()
		{
			// When a "popup" form is opened, the action the user wants to perform is passed to the popup form's class, and is used to determine what the window title of the form should be.
			if(action == "edit")
			{
				this.Text = "Edit Property";
			}
			else if(action == "add")
			{
				this.Text = "Add Property";
			}
			else if(action == "view")
			{
				this.Text = "View Property";
			}
		}

		private void GetTextBoxes()
		{
			this.textBoxes = new TextBox[13] { inputDistrictName, inputNeighborhoodName, inputPropertyID, inputPropertyName, inputHostID, inputHostName, inputHostPropertyCount, inputRoomType, inputRoomPrice, inputLongitude, inputLatitude, inputRoomNights, inputRoomAvailability };
		}

		private void InputDistrictName_Enter(object sender, EventArgs e)
		{
			if(inputDistrictName.Text == "District Name...")
			{
				inputDistrictName.ForeColor = Color.FromArgb(250, 250, 250);
				inputDistrictName.Text = "";
			}
		}

		private void InputNeighborhoodName_Enter(object sender, EventArgs e)
		{
			if(inputNeighborhoodName.Text == "Neighborhood Name...")
			{
				inputNeighborhoodName.ForeColor = Color.FromArgb(250, 250, 250);
				inputNeighborhoodName.Text = "";
			}
		}

		private void InputPropertyID_Enter(object sender, EventArgs e)
		{
			if(inputPropertyID.Text == "Property ID...")
			{
				inputPropertyID.Text = "";
				inputPropertyID.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputPropertyName_Enter(object sender, EventArgs e)
		{
			if(inputPropertyName.Text == "Property Name...")
			{
				inputPropertyName.Text = "";
				inputPropertyName.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputHostID_Enter(object sender, EventArgs e)
		{
			if(inputHostID.Text == "Host ID...")
			{
				inputHostID.Text = "";
				inputHostID.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputHostName_Enter(object sender, EventArgs e)
		{
			if(inputHostName.Text == "Host Name...")
			{
				inputHostName.Text = "";
				inputHostName.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputHostPropertyCount_Enter(object sender, EventArgs e)
		{
			if(inputHostPropertyCount.Text == "Number of Properties Owned by Host...")
			{
				inputHostPropertyCount.Text = "";
				inputHostPropertyCount.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputRoomType_Enter(object sender, EventArgs e)
		{
			if(inputRoomType.Text == "Room Type...")
			{
				inputRoomType.Text = "";
				inputRoomType.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputRoomPrice_Enter(object sender, EventArgs e)
		{
			if(inputRoomPrice.Text == "Room Price...")
			{
				inputRoomPrice.Text = "";
				inputRoomPrice.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputLongitude_Enter(object sender, EventArgs e)
		{
			if(inputLongitude.Text == "Longitude...")
			{
				inputLongitude.Text = "";
				inputLongitude.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputLatitude_Enter(object sender, EventArgs e)
		{
			if(inputLatitude.Text == "Latitude...")
			{
				inputLatitude.Text = "";
				inputLatitude.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputRoomNights_Enter(object sender, EventArgs e)
		{
			if(inputRoomNights.Text == "Minimum Nights...")
			{
				inputRoomNights.Text = "";
				inputRoomNights.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputRoomAvailability_Enter(object sender, EventArgs e)
		{
			if(inputRoomAvailability.Text == "Availability Days...")
			{
				inputRoomAvailability.Text = "";
				inputRoomAvailability.ForeColor = Color.FromArgb(250, 250, 250);
			}
		}

		private void InputDistrictName_Leave(object sender, EventArgs e)
		{
			if(inputDistrictName.Text.Trim() == "")
			{
				inputDistrictName.Text = "District Name...";
			}
		}

		private void InputNeighborhoodName_Leave(object sender, EventArgs e)
		{
			if(inputNeighborhoodName.Text.Trim() == "")
			{
				inputNeighborhoodName.Text = "Neighborhood Name...";
			}
		}

		private void InputPropertyID_Leave(object sender, EventArgs e)
		{
			if(inputPropertyID.Text.Trim() == "")
			{
				inputPropertyID.Text = "Property ID...";
			}
		}

		private void InputPropertyName_Leave(object sender, EventArgs e)
		{
			if(inputPropertyName.Text.Trim() == "")
			{
				inputPropertyName.Text = "Property Name...";
			}
		}

		private void InputHostID_Leave(object sender, EventArgs e)
		{
			if(inputHostID.Text.Trim() == "")
			{
				inputHostID.Text = "Host ID...";
			}
		}

		private void InputHostName_Leave(object sender, EventArgs e)
		{
			if(inputHostName.Text.Trim() == "")
			{
				inputHostName.Text = "Host Name...";
			}
		}

		private void InputHostPropertyCount_Leave(object sender, EventArgs e)
		{
			if(inputHostPropertyCount.Text.Trim() == "")
			{
				inputHostPropertyCount.Text = "Number of Properties Owned by Host...";
			}
		}

		private void InputRoomType_Leave(object sender, EventArgs e)
		{
			if(inputRoomType.Text.Trim() == "")
			{
				inputRoomType.Text = "Room Type...";
			}
		}

		private void InputRoomPrice_Leave(object sender, EventArgs e)
		{
			if(inputRoomPrice.Text.Trim() == "")
			{
				inputRoomPrice.Text = "Room Price...";
			}
		}

		private void InputLongitude_Leave(object sender, EventArgs e)
		{
			if(inputLongitude.Text.Trim() == "")
			{
				inputLongitude.Text = "Longitude...";
			}
		}

		private void InputLatitude_Leave(object sender, EventArgs e)
		{
			if(inputLatitude.Text.Trim() == "")
			{
				inputLatitude.Text = "Latitude...";
			}
		}

		private void InputRoomNights_Leave(object sender, EventArgs e)
		{
			if(inputRoomNights.Text.Trim() == "")
			{
				inputRoomNights.Text = "Minimum Nights...";
			}
		}

		private void InputRoomAvailability_Leave(object sender, EventArgs e)
		{
			if(inputRoomAvailability.Text.Trim() == "")
			{
				inputRoomAvailability.Text = "Availability Days...";
			}
		}

		private void ButtonDelete_Click(object sender, EventArgs e)
		{

		}

		private void ButtonNext_Click(object sender, EventArgs e)
		{
			// The boolean variable "valid" is used to determine whether or not the TextBoxes have been filled out. If they have, then the next button does what's it's actually meant to do.
			bool valid = true;
			if(inputDistrictName.Text == "District Name..." || inputDistrictName.Text == "")
			{
				inputDistrictName.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputNeighborhoodName.Text == "Neighborhood Name..." || inputNeighborhoodName.Text == "")
			{
				inputNeighborhoodName.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputPropertyID.Text == "Property ID..." || inputPropertyID.Text == "")
			{
				inputPropertyID.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputPropertyName.Text == "Property Name..." || inputPropertyName.Text == "")
			{
				inputPropertyName.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputHostID.Text == "Host ID..." || inputHostID.Text == "")
			{
				inputHostID.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputHostName.Text == "Host Name..." || inputHostName.Text == "")
			{
				inputHostName.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputHostPropertyCount.Text == "Number of Properties Owned by Host..." || inputHostPropertyCount.Text == "")
			{
				inputHostPropertyCount.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputRoomType.Text == "Room Type..." || inputRoomType.Text == "")
			{
				inputRoomType.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputRoomPrice.Text == "Room Price..." || inputRoomPrice.Text == "")
			{
				inputRoomPrice.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputLongitude.Text == "Longitude..." || inputLongitude.Text == "")
			{
				inputLongitude.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputLatitude.Text == "Latitude..." || inputLatitude.Text == "")
			{
				inputLatitude.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputRoomNights.Text == "Minimum Nights..." || inputRoomNights.Text == "")
			{
				inputRoomNights.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(inputRoomAvailability.Text == "Availability Days..." || inputRoomAvailability.Text == "")
			{
				inputRoomAvailability.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(valid)
			{

			}
		}
	}
}
