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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnalysis));
			this.panelNeighborhood = new System.Windows.Forms.Panel();
			this.labelNeighborhood = new System.Windows.Forms.Label();
			this.panelDistrictNames = new System.Windows.Forms.Panel();
			this.panelProperty = new System.Windows.Forms.Panel();
			this.labelProperty = new System.Windows.Forms.Label();
			this.panelNeighborhoodNames = new System.Windows.Forms.Panel();
			this.panelNeighborhood.SuspendLayout();
			this.panelProperty.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelNeighborhood
			// 
			this.panelNeighborhood.AutoSize = true;
			this.panelNeighborhood.Controls.Add(this.labelNeighborhood);
			this.panelNeighborhood.Location = new System.Drawing.Point(12, 12);
			this.panelNeighborhood.Name = "panelNeighborhood";
			this.panelNeighborhood.Size = new System.Drawing.Size(1424, 371);
			this.panelNeighborhood.TabIndex = 4;
			this.panelNeighborhood.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelNeighborhood_Paint);
			// 
			// labelNeighborhood
			// 
			this.labelNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.labelNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.labelNeighborhood.Location = new System.Drawing.Point(20, 10);
			this.labelNeighborhood.Name = "labelNeighborhood";
			this.labelNeighborhood.Size = new System.Drawing.Size(0, 1);
			this.labelNeighborhood.TabIndex = 3;
			this.labelNeighborhood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelDistrictNames
			// 
			this.panelDistrictNames.AutoSize = true;
			this.panelDistrictNames.Location = new System.Drawing.Point(12, 389);
			this.panelDistrictNames.Name = "panelDistrictNames";
			this.panelDistrictNames.Size = new System.Drawing.Size(1414, 65);
			this.panelDistrictNames.TabIndex = 1;
			// 
			// panelProperty
			// 
			this.panelProperty.AutoSize = true;
			this.panelProperty.Controls.Add(this.labelProperty);
			this.panelProperty.Location = new System.Drawing.Point(12, 460);
			this.panelProperty.Name = "panelProperty";
			this.panelProperty.Size = new System.Drawing.Size(1424, 349);
			this.panelProperty.TabIndex = 5;
			this.panelProperty.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelProperty_Paint);
			// 
			// labelProperty
			// 
			this.labelProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.labelProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.labelProperty.Location = new System.Drawing.Point(20, 10);
			this.labelProperty.Name = "labelProperty";
			this.labelProperty.Size = new System.Drawing.Size(0, 1);
			this.labelProperty.TabIndex = 3;
			this.labelProperty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelNeighborhoodNames
			// 
			this.panelNeighborhoodNames.AutoSize = true;
			this.panelNeighborhoodNames.Location = new System.Drawing.Point(12, 815);
			this.panelNeighborhoodNames.Name = "panelNeighborhoodNames";
			this.panelNeighborhoodNames.Size = new System.Drawing.Size(1414, 67);
			this.panelNeighborhoodNames.TabIndex = 6;
			// 
			// FormAnalysis
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(1438, 905);
			this.Controls.Add(this.panelNeighborhoodNames);
			this.Controls.Add(this.panelProperty);
			this.Controls.Add(this.panelDistrictNames);
			this.Controls.Add(this.panelNeighborhood);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1454, 944);
			this.Name = "FormAnalysis";
			this.Text = "Analysis";
			this.panelNeighborhood.ResumeLayout(false);
			this.panelProperty.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Panel panelNeighborhood;
		private System.Windows.Forms.Label labelNeighborhood;
		private System.Windows.Forms.Panel panelDistrictNames;
		private System.Windows.Forms.Panel panelProperty;
		private System.Windows.Forms.Label labelProperty;
		private System.Windows.Forms.Panel panelNeighborhoodNames;
	}
}