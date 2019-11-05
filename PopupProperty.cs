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
		public string level;
		public string action;
        public PopupProperty(string accessLevel, string desiredAction)
        {
            InitializeComponent();
			this.level = accessLevel.ToLower();
			this.action = desiredAction.ToLower();
			setTitle();
        }

		private void buttonBack_Click(object sender, EventArgs e) {
			if(level == "public") {
				showForm(new FormMain("properties", "public"), false);
			}
			else if(level == "staff") {
				showForm(new FormMain("properties", "staff"), false);
			}
		}

		private void setTitle() {
			// When a "popup" form is opened, the action the user wants to perform is passed to the popup form's class, and is used to determine what the window title of the form should be.
			if (action == "edit") {
				this.Text = "Edit Property";
			}
			else if (action == "add") {
				this.Text = "Add Property";
			}
			else if (action == "view") {
				this.Text = "View Property";
			}
		}

		private void showForm(Form form, bool matchSize) {
			form.Show();
			this.Hide();
			// Open form in the same location.
			form.Left = this.Left;
			form.Top = this.Top;
			// Most forms have the same size, but some (such as popups) might not.
			if (matchSize) {
				form.Size = this.Size;
			}
		}
	}
}
