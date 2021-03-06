﻿using System;
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
	public partial class PopupDistrict : Form
	{
		public string level;
		public string action;
		public int districtIndex;

		// For adding.
		public PopupDistrict(string accessLevel, string desiredAction)
		{
			InitializeComponent();
			Utils.SetIcon(this);

			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			SetTitle();
		}

		// For editing and viewing.
		public PopupDistrict(string accessLevel, string desiredAction, int indexDistrict)
		{
			InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			this.districtIndex = indexDistrict;

			// Autofill for editing the district name and neighborhood count.
			this.inputName.Text = Data.districts[districtIndex].Name;
			this.inputNeighborhoodCount.Text = Data.districts[districtIndex].NeighborhoodCount.ToString();

			if(action == "edit")
			{
				// This used to allow users to delete a district, but I realized it'd count as adding to the functionality of the program, and it'd fall outside the brief.
				// this.buttonDelete.Visible = true;
			}
			// If the user only wants to view the item, then the TextBox components are set to read-only.
			else if(action == "view")
			{
				this.inputName.ReadOnly = true;
				this.inputName.Enabled = false;
				this.inputNeighborhoodCount.ReadOnly = true;
				this.inputNeighborhoodCount.Enabled = false;
				this.panelCount.Show();
				this.buttonConfirm.Hide();
			}
		}

		private void SetTitle()
		{
			// When a "popup" form is opened, the action the user wants to perform is passed to the popup form's class, and is used to determine what the window title of the form should be.
			if(action == "edit")
			{
				this.Text = "Edit District";
			}
			else if(action == "add")
			{
				this.Text = "Add District";
			}
			else if(action == "view")
			{
				this.Text = "View District";
			}
		}

		private void PanelName_Click(object sender, EventArgs e)
		{
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputName.Focus();
		}

		private void PanelCount_Click(object sender, EventArgs e)
		{
			// User might click on the panel instead of the TextBox. This takes care of that.
			inputNeighborhoodCount.Focus();
		}

		private void ButtonNext_Click(object sender, EventArgs e)
		{
			ProcessInput();
		}

		private void InputName_Enter(object sender, EventArgs e)
		{
			// Empty "placeholder".
			if(inputName.Text == "District Name...")
			{
				inputName.ForeColor = Color.FromArgb(250, 250, 250);
				inputName.Text = "";
			}
		}

		private void InputNeighborhoodCount_Enter(object sender, EventArgs e)
		{
			// Empty "placeholder".
			if(inputNeighborhoodCount.Text == "Number of Neighborhoods...")
			{
				inputNeighborhoodCount.ForeColor = Color.FromArgb(250, 250, 250);
				inputNeighborhoodCount.Text = "";
			}
		}

		private void InputName_Leave(object sender, EventArgs e)
		{
			// Fill "placeholder".
			if(inputName.Text.Trim() == "")
			{
				inputName.Text = "District Name...";
			}
		}
		
		private void InputName_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				ProcessInput();
			}
		}

		private void InputNeighborhoodCount_Leave(object sender, EventArgs e)
		{
			// Fill "placeholder".
			if(inputNeighborhoodCount.Text.Trim() == "")
			{
				inputNeighborhoodCount.Text = "Number of Neighborhoods...";
			}
		}

		private void ButtonDelete_Click(object sender, EventArgs e)
		{
			Data.districts[districtIndex] = null;
			District[] districts = new District[0];
			foreach(District district in Data.districts)
			{
				if(district != null)
				{
					int numberOfDistricts = districts.Length;
					Array.Resize(ref districts, numberOfDistricts + 1);
					districts[numberOfDistricts] = district;
				}
			}
			Data.districts = districts;
			Data.changed = true;
			Data.deletedDistrict = true;
			this.Hide();
		}

		private void ProcessInput()
		{
			// The boolean variable "valid" is used to determine whether or not the TextBoxes have been filled out. If they have, then the next button does what's it's actually meant to do.
			bool valid = true;
			if(inputName.Text.Trim() == "" || inputName.Text == "District Name...")
			{
				inputName.ForeColor = Color.FromArgb(240, 100, 50);
				valid = false;
			}
			if(valid)
			{
				if(this.action == "add")
				{
					District district = new District(inputName.Text, 0);
					int numberOfDistricts = Data.districts.Length;
					Array.Resize(ref Data.districts, numberOfDistricts + 1);
					Data.districts[numberOfDistricts] = district;
				}
				else if(this.action == "edit")
				{
					District district = Data.districts[districtIndex];
					district.Name = inputName.Text;
					Data.districts[districtIndex] = district;
				}
				Data.changed = true;
				this.Hide();
			}
		}
	}
}
