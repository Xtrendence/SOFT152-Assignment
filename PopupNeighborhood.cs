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
    public partial class PopupNeighborhood : Form
    {
		public string level;
		public string action;
        public PopupNeighborhood(string accessLevel, string desiredAction)
        {
            InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			setTitle();
        }

		private void buttonBack_Click(object sender, EventArgs e) {
			if(level == "public") {
				showForm(new FormPublic());
			}
			else if(level == "staff") {
				showForm(new FormStaff());
			}
		}

		private void setTitle() {
			// When a "popup" form is opened, the action the user wants to perform is passed to the popup form's class, and is used to determine what the window title of the form should be.
			if (action == "edit") {
				this.Text = "Edit Neighborhood";
			}
			else if (action == "add") {
				this.Text = "Add Neighborhood";
			}
			else if (action == "view") {
				this.Text = "View Neighborhood";
			}
		}

		private void showForm(Form form) {
			this.Hide();
			form.Show();
			// Open form in the same location.
			form.Left = this.Left;
			form.Top = this.Top;
			// All forms have the same size.
			form.Size = this.Size;
		}
	}
}
