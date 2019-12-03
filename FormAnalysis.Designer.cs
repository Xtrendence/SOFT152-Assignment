namespace SOFT152Assignment
{
	partial class FormAnalysis
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelNeighborhood = new System.Windows.Forms.Panel();
			this.panelDistrictNames = new System.Windows.Forms.Panel();
			this.panelProperty = new System.Windows.Forms.Panel();
			this.panelNeighborhoodNames = new System.Windows.Forms.Panel();
			this.buttonPreviousDistrict = new System.Windows.Forms.Button();
			this.buttonNextDistrict = new System.Windows.Forms.Button();
			this.buttonPreviousNeighborhood = new System.Windows.Forms.Button();
			this.buttonNextNeighborhood = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// panelNeighborhood
			// 
			this.panelNeighborhood.Location = new System.Drawing.Point(12, 12);
			this.panelNeighborhood.Name = "panelNeighborhood";
			this.panelNeighborhood.Size = new System.Drawing.Size(1414, 331);
			this.panelNeighborhood.TabIndex = 4;
			this.panelNeighborhood.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelNeighborhood_Paint);
			// 
			// panelDistrictNames
			// 
			this.panelDistrictNames.AutoSize = true;
			this.panelDistrictNames.Location = new System.Drawing.Point(12, 361);
			this.panelDistrictNames.Name = "panelDistrictNames";
			this.panelDistrictNames.Size = new System.Drawing.Size(1414, 50);
			this.panelDistrictNames.TabIndex = 1;
			// 
			// panelProperty
			// 
			this.panelProperty.Location = new System.Drawing.Point(12, 457);
			this.panelProperty.Name = "panelProperty";
			this.panelProperty.Size = new System.Drawing.Size(1414, 327);
			this.panelProperty.TabIndex = 5;
			this.panelProperty.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProperty_Paint);
			// 
			// panelNeighborhoodNames
			// 
			this.panelNeighborhoodNames.AutoSize = true;
			this.panelNeighborhoodNames.Location = new System.Drawing.Point(12, 801);
			this.panelNeighborhoodNames.Name = "panelNeighborhoodNames";
			this.panelNeighborhoodNames.Size = new System.Drawing.Size(1414, 52);
			this.panelNeighborhoodNames.TabIndex = 6;
			// 
			// buttonPreviousDistrict
			// 
			this.buttonPreviousDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonPreviousDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPreviousDistrict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonPreviousDistrict.FlatAppearance.BorderSize = 0;
			this.buttonPreviousDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPreviousDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPreviousDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonPreviousDistrict.Location = new System.Drawing.Point(12, 417);
			this.buttonPreviousDistrict.Name = "buttonPreviousDistrict";
			this.buttonPreviousDistrict.Size = new System.Drawing.Size(86, 34);
			this.buttonPreviousDistrict.TabIndex = 19;
			this.buttonPreviousDistrict.Text = "Previous";
			this.buttonPreviousDistrict.UseVisualStyleBackColor = false;
			this.buttonPreviousDistrict.Visible = false;
			this.buttonPreviousDistrict.Click += new System.EventHandler(this.ButtonPreviousDistrict_Click);
			// 
			// buttonNextDistrict
			// 
			this.buttonNextDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNextDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonNextDistrict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNextDistrict.FlatAppearance.BorderSize = 0;
			this.buttonNextDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNextDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNextDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonNextDistrict.Location = new System.Drawing.Point(1340, 417);
			this.buttonNextDistrict.Name = "buttonNextDistrict";
			this.buttonNextDistrict.Size = new System.Drawing.Size(86, 34);
			this.buttonNextDistrict.TabIndex = 20;
			this.buttonNextDistrict.Text = "Next";
			this.buttonNextDistrict.UseVisualStyleBackColor = false;
			this.buttonNextDistrict.Click += new System.EventHandler(this.ButtonNextDistrict_Click);
			// 
			// buttonPreviousNeighborhood
			// 
			this.buttonPreviousNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonPreviousNeighborhood.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPreviousNeighborhood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonPreviousNeighborhood.FlatAppearance.BorderSize = 0;
			this.buttonPreviousNeighborhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPreviousNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPreviousNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonPreviousNeighborhood.Location = new System.Drawing.Point(12, 859);
			this.buttonPreviousNeighborhood.Name = "buttonPreviousNeighborhood";
			this.buttonPreviousNeighborhood.Size = new System.Drawing.Size(86, 34);
			this.buttonPreviousNeighborhood.TabIndex = 21;
			this.buttonPreviousNeighborhood.Text = "Previous";
			this.buttonPreviousNeighborhood.UseVisualStyleBackColor = false;
			this.buttonPreviousNeighborhood.Visible = false;
			this.buttonPreviousNeighborhood.Click += new System.EventHandler(this.ButtonPreviousNeighborhood_Click);
			// 
			// buttonNextNeighborhood
			// 
			this.buttonNextNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNextNeighborhood.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonNextNeighborhood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNextNeighborhood.FlatAppearance.BorderSize = 0;
			this.buttonNextNeighborhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNextNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNextNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonNextNeighborhood.Location = new System.Drawing.Point(1340, 859);
			this.buttonNextNeighborhood.Name = "buttonNextNeighborhood";
			this.buttonNextNeighborhood.Size = new System.Drawing.Size(86, 34);
			this.buttonNextNeighborhood.TabIndex = 22;
			this.buttonNextNeighborhood.Text = "Next";
			this.buttonNextNeighborhood.UseVisualStyleBackColor = false;
			this.buttonNextNeighborhood.Click += new System.EventHandler(this.ButtonNextNeighborhood_Click);
			// 
			// FormAnalysis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(1438, 905);
			this.Controls.Add(this.buttonNextNeighborhood);
			this.Controls.Add(this.buttonPreviousNeighborhood);
			this.Controls.Add(this.buttonNextDistrict);
			this.Controls.Add(this.buttonPreviousDistrict);
			this.Controls.Add(this.panelNeighborhoodNames);
			this.Controls.Add(this.panelProperty);
			this.Controls.Add(this.panelDistrictNames);
			this.Controls.Add(this.panelNeighborhood);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1454, 944);
			this.Name = "FormAnalysis";
			this.Text = "Analysis";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panelNeighborhood;
		private System.Windows.Forms.Panel panelDistrictNames;
		private System.Windows.Forms.Panel panelProperty;
		private System.Windows.Forms.Panel panelNeighborhoodNames;
		private System.Windows.Forms.Button buttonPreviousDistrict;
		private System.Windows.Forms.Button buttonNextDistrict;
		private System.Windows.Forms.Button buttonPreviousNeighborhood;
		private System.Windows.Forms.Button buttonNextNeighborhood;
	}
}