﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFT152Assignment
{
	class Utils
	{
		public static void SetIcon(Form form)
		{
			try
			{
				if(Properties.Resources.AMT != null)
				{
					form.Icon = Properties.Resources.AMT;
				}
			}
			catch(Exception e)
			{
				Debug.WriteLine(e.Message);
			}
		}

		public static void DisableControl(Control control)
		{
			control.BackColor = Color.FromArgb(20, 20, 20);
			control.ForeColor = Color.FromArgb(150, 150, 150);
		}

		public static void EnableControl(Control control)
		{
			control.BackColor = Color.FromArgb(60, 60, 60);
			control.ForeColor = Color.FromArgb(250, 250, 250);
		}
	}
}
