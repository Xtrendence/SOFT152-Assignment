namespace SOFT152Assignment
{
    partial class PopupNeighborhood
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
            if (disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopupNeighborhood));
			this.buttonConfirm = new System.Windows.Forms.Button();
			this.panelCount = new System.Windows.Forms.Panel();
			this.inputPropertyCount = new System.Windows.Forms.TextBox();
			this.panelName = new System.Windows.Forms.Panel();
			this.inputNeighborhoodName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.inputDistrictName = new System.Windows.Forms.TextBox();
			this.panelCount.SuspendLayout();
			this.panelName.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonConfirm.FlatAppearance.BorderSize = 0;
			this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonConfirm.Location = new System.Drawing.Point(293, 92);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(79, 34);
			this.buttonConfirm.TabIndex = 33;
			this.buttonConfirm.Text = "Confirm";
			this.buttonConfirm.UseVisualStyleBackColor = false;
			this.buttonConfirm.Click += new System.EventHandler(this.ButtonNext_Click);
			// 
			// panelCount
			// 
			this.panelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelCount.Controls.Add(this.inputPropertyCount);
			this.panelCount.Location = new System.Drawing.Point(12, 92);
			this.panelCount.Name = "panelCount";
			this.panelCount.Size = new System.Drawing.Size(179, 34);
			this.panelCount.TabIndex = 35;
			this.panelCount.Visible = false;
			this.panelCount.Click += new System.EventHandler(this.PanelCount_Click);
			// 
			// inputPropertyCount
			// 
			this.inputPropertyCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputPropertyCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputPropertyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputPropertyCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputPropertyCount.Location = new System.Drawing.Point(13, 10);
			this.inputPropertyCount.Name = "inputPropertyCount";
			this.inputPropertyCount.Size = new System.Drawing.Size(150, 16);
			this.inputPropertyCount.TabIndex = 13;
			this.inputPropertyCount.Text = "Number of Properties...";
			this.inputPropertyCount.Enter += new System.EventHandler(this.InputPropertyCount_Enter);
			this.inputPropertyCount.Leave += new System.EventHandler(this.InputPropertyCount_Leave);
			// 
			// panelName
			// 
			this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelName.Controls.Add(this.inputNeighborhoodName);
			this.panelName.Location = new System.Drawing.Point(12, 52);
			this.panelName.Name = "panelName";
			this.panelName.Size = new System.Drawing.Size(360, 34);
			this.panelName.TabIndex = 34;
			this.panelName.Click += new System.EventHandler(this.PanelName_Click);
			// 
			// inputNeighborhoodName
			// 
			this.inputNeighborhoodName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputNeighborhoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputNeighborhoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputNeighborhoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputNeighborhoodName.Location = new System.Drawing.Point(13, 10);
			this.inputNeighborhoodName.Name = "inputNeighborhoodName";
			this.inputNeighborhoodName.Size = new System.Drawing.Size(331, 16);
			this.inputNeighborhoodName.TabIndex = 13;
			this.inputNeighborhoodName.Text = "Neighborhood Name...";
			this.inputNeighborhoodName.Enter += new System.EventHandler(this.InputNeighborhoodName_Enter);
			this.inputNeighborhoodName.Leave += new System.EventHandler(this.InputNeighborhoodName_Leave);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panel1.Controls.Add(this.inputDistrictName);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 34);
			this.panel1.TabIndex = 36;
			// 
			// inputDistrictName
			// 
			this.inputDistrictName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputDistrictName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputDistrictName.Enabled = false;
			this.inputDistrictName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputDistrictName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputDistrictName.Location = new System.Drawing.Point(13, 10);
			this.inputDistrictName.Name = "inputDistrictName";
			this.inputDistrictName.ReadOnly = true;
			this.inputDistrictName.Size = new System.Drawing.Size(332, 16);
			this.inputDistrictName.TabIndex = 13;
			this.inputDistrictName.Text = "District Name...";
			this.inputDistrictName.Enter += new System.EventHandler(this.InputDistrictName_Enter);
			this.inputDistrictName.Leave += new System.EventHandler(this.InputDistrictName_Leave);
			// 
			// PopupNeighborhood
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(384, 136);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttonConfirm);
			this.Controls.Add(this.panelCount);
			this.Controls.Add(this.panelName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PopupNeighborhood";
			this.Text = "Neighborhood";
			this.panelCount.ResumeLayout(false);
			this.panelCount.PerformLayout();
			this.panelName.ResumeLayout(false);
			this.panelName.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.Button buttonConfirm;
		private System.Windows.Forms.Panel panelCount;
		private System.Windows.Forms.TextBox inputPropertyCount;
		private System.Windows.Forms.Panel panelName;
		private System.Windows.Forms.TextBox inputNeighborhoodName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox inputDistrictName;
	}
}