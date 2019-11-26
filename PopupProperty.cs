using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
		public int districtIndex;
		public int neighborhoodIndex;
		public int propertyIndex;
		// For adding.
		public PopupProperty(string accessLevel, string desiredAction)
		{
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			SetTitle();
			GetTextBoxes();
		}

		// For editing or viewing.
		public PopupProperty(string accessLevel, string desiredAction, int indexDistrict, int indexNeighborhood, int indexProperty)
		{
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.districtIndex = indexDistrict;
			this.neighborhoodIndex = indexNeighborhood;
			this.propertyIndex = indexProperty;
			SetTitle();
			GetTextBoxes();

			// For editing and viewing, this sets/autofills the values of the TextBoxes.
			District district = Data.districts[districtIndex];
			Neighborhood neighborhood = district.Neighborhoods[neighborhoodIndex];
			Property property = neighborhood.Properties[propertyIndex];
			this.inputDistrictName.Text = district.Name;
			this.inputNeighborhoodName.Text = neighborhood.Name;
			this.inputPropertyID.Text = property.Id.ToString();
			this.inputPropertyName.Text = property.Name.ToString();
			this.inputHostID.Text = property.HostID.ToString();
			this.inputHostName.Text = property.HostName.ToString();
			this.inputHostPropertyCount.Text = property.Count.ToString();
			this.inputRoomType.Text = property.RoomType.ToString();
			this.inputRoomPrice.Text = property.RoomPrice.ToString();
			this.inputLongitude.Text = property.Longitude.ToString();
			this.inputLatitude.Text = property.Latitude.ToString();
			this.inputRoomNights.Text = property.RoomNights.ToString();
			this.inputRoomAvailability.Text = property.RoomAvailability.ToString();

			// The delete button is only visible when the user is modifying a property.
			if(this.action == "edit")
			{
				buttonDelete.Visible = true;
			}
			// If the user only wants to view the item, then the TextBox components are set to read-only and are disabled so the user can't trigger any focus events on them.
			else if(this.action == "view")
			{
				foreach(TextBox input in textBoxes)
				{
					input.ReadOnly = true;
					input.Enabled = false;
				}
				this.buttonConfirm.Hide();
			}
		}

		// For adding, but with the district name and neighborhood name autofilled.
		public PopupProperty(string accessLevel, string desiredAction, int indexDistrict, int indexNeighborhood)
		{
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.districtIndex = indexDistrict;
			this.neighborhoodIndex = indexNeighborhood;
			SetTitle();
			GetTextBoxes();

			// For editing and viewing, this sets/autofills the values of the TextBoxes.
			this.inputDistrictName.Text = Data.districts[districtIndex].Name;
			this.inputNeighborhoodName.Text = Data.districts[districtIndex].Neighborhoods[neighborhoodIndex].Name;

			// If the user only wants to view the item, then the TextBox components are set to read-only and are disabled so the user can't trigger any focus events on them.
			if(this.action == "view")
			{
				foreach(TextBox input in textBoxes)
				{
					input.ReadOnly = true;
					input.Enabled = false;
				}
				this.buttonConfirm.Hide();
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
			District district = Data.districts[districtIndex];
			Neighborhood neighborhood = district.Neighborhoods[neighborhoodIndex];
			neighborhood.Properties[propertyIndex] = null;
			Property[] properties = new Property[0];
			foreach(Property property in neighborhood.Properties)
			{
				if(property != null)
				{
					int numberOfProperties = properties.Length;
					Array.Resize(ref properties, numberOfProperties + 1);
					properties[numberOfProperties] = property;
				}
			}
			Data.districts[districtIndex].Neighborhoods[neighborhoodIndex].PropertyCount -= 1;
			Data.districts[districtIndex].Neighborhoods[neighborhoodIndex].Properties = properties;
			Data.changed = true;
			this.Hide();
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
			if(inputRoomAvailability.Text == "Availability Days..." || inputRoomAvailability.Text == "" || Convert.ToInt32(inputRoomAvailability.Text) > 365)
			{
				inputRoomAvailability.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(valid)
			{
				if(action == "add")
				{
					District district = Data.districts[districtIndex];
					Neighborhood neighborhood = district.Neighborhoods[neighborhoodIndex];
					Property property = new Property(Convert.ToInt32(this.inputPropertyID.Text), this.inputPropertyName.Text, Convert.ToInt32(this.inputHostID.Text), this.inputHostName.Text, Convert.ToInt32(this.inputHostPropertyCount.Text), Convert.ToDouble(this.inputLongitude.Text), Convert.ToDouble(this.inputLatitude.Text), this.inputRoomType.Text, Convert.ToDouble(this.inputRoomPrice.Text), Convert.ToInt32(this.inputRoomNights.Text), Convert.ToInt32(this.inputRoomAvailability.Text));
					int numberOfProperties = neighborhood.Properties.Length;
					neighborhood.AddProperty(property);
					Data.districts[districtIndex].Neighborhoods[neighborhoodIndex] = neighborhood;
				}
				else if(action == "edit")
				{
					District district = Data.districts[districtIndex];
					Neighborhood neighborhood = district.Neighborhoods[neighborhoodIndex];
					Property property = neighborhood.Properties[propertyIndex];
					property.Id = Convert.ToInt32(this.inputPropertyID.Text);
					property.Name = this.inputPropertyName.Text;
					property.HostID = Convert.ToInt32(this.inputHostID.Text);
					property.HostName = this.inputHostName.Text;
					property.Count = Convert.ToInt32(this.inputHostPropertyCount.Text);
					property.RoomType = this.inputRoomType.Text;
					property.RoomPrice = Convert.ToDouble(this.inputRoomPrice.Text);
					property.Longitude = Convert.ToDouble(this.inputLongitude.Text);
					property.Latitude = Convert.ToDouble(this.inputLatitude.Text);
					property.RoomNights = Convert.ToInt32(this.inputRoomNights.Text);
					property.RoomAvailability = Convert.ToInt32(this.inputRoomAvailability.Text);
					Data.districts[districtIndex].Neighborhoods[neighborhoodIndex].Properties[propertyIndex] = property;
				}
				Data.changed = true;
				this.Hide();
			}
		}
	}
}
