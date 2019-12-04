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
	public partial class FormAccess : Form
	{
		public bool open;

		public FormAccess()
		{
			InitializeComponent();
			Utils.SetIcon(this);

			// Only set the bread image if it exists as a resource.
			if(Properties.Resources.bread != null)
			{
				pictureBox1.Image = Properties.Resources.bread;
				label2.Text = "Royalty && Copyright Free Bread";
			}

			// Set the form to open. This is used later on to actually exit the application if the form is closed.
			open = true;

			int screenWidth = Screen.FromControl(this).Bounds.Width;

			// Center the window horizontally.
			this.Left = (screenWidth / 2) - (this.Width / 2);
			this.Top = 50;
		}

		private void ButtonPublic_Click(object sender, EventArgs e)
		{
			ShowForm(new FormMain("public"));
		}

		private void ButtonStaff_Click(object sender, EventArgs e)
		{
			ShowForm(new FormMain("staff"));
		}

		private void ShowForm(Form form)
		{
			form.Show();
			// Ensures that the new form opens on top of the current one.
			form.Left = this.Left;
			form.Top = this.Top;
			// Ensures that the new form is the same size as the current one.
			form.Size = this.Size;
			this.Hide();
		}

		private void FormAccess_FormClosed(object sender, FormClosedEventArgs e)
		{
			if(this.open)
			{
				this.open = false;

				// Ensures the application actually stops running.
				this.Close();
				Application.Exit();
			}
		}
	}
}
