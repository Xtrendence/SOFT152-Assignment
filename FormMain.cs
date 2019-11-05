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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonPublic_Click(object sender, EventArgs e)
        {
            showForm(new FormPublic());
        }

        private void ButtonStaff_Click(object sender, EventArgs e)
        {
            showForm(new FormStaff());
        }
        private void showForm(Form form)
        {
			this.Hide();
            form.Show();
			// Ensures that the new form opens on top of the current one.
            form.Left = this.Left;
            form.Top = this.Top;
			// Ensures that the new form is the same size as the current one.
            form.Size = this.Size;
        }
    }
}
