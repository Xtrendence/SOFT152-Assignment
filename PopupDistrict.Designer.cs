namespace SOFT152Assignment
{
    partial class PopupDistrict
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
			this.buttonBack = new System.Windows.Forms.Button();
			this.inputName = new System.Windows.Forms.TextBox();
			this.panelName = new System.Windows.Forms.Panel();
			this.panelCount = new System.Windows.Forms.Panel();
			this.inputNeighborhoodCount = new System.Windows.Forms.TextBox();
			this.buttonNext = new System.Windows.Forms.Button();
			this.panelName.SuspendLayout();
			this.panelCount.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonBack.FlatAppearance.BorderSize = 0;
			this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonBack.Location = new System.Drawing.Point(12, 12);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(79, 60);
			this.buttonBack.TabIndex = 11;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
			// 
			// inputName
			// 
			this.inputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputName.Location = new System.Drawing.Point(13, 10);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(332, 16);
			this.inputName.TabIndex = 13;
			this.inputName.Text = "District Name...";
			this.inputName.Enter += new System.EventHandler(this.InputName_Enter);
			this.inputName.Leave += new System.EventHandler(this.InputName_Leave);
			// 
			// panelName
			// 
			this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelName.Controls.Add(this.inputName);
			this.panelName.Location = new System.Drawing.Point(12, 222);
			this.panelName.Name = "panelName";
			this.panelName.Size = new System.Drawing.Size(360, 34);
			this.panelName.TabIndex = 31;
			this.panelName.Click += new System.EventHandler(this.PanelName_Click);
			// 
			// panelCount
			// 
			this.panelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelCount.Controls.Add(this.inputNeighborhoodCount);
			this.panelCount.Location = new System.Drawing.Point(12, 268);
			this.panelCount.Name = "panelCount";
			this.panelCount.Size = new System.Drawing.Size(209, 34);
			this.panelCount.TabIndex = 32;
			this.panelCount.Click += new System.EventHandler(this.PanelCount_Click);
			// 
			// inputNeighborhoodCount
			// 
			this.inputNeighborhoodCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputNeighborhoodCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputNeighborhoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputNeighborhoodCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputNeighborhoodCount.Location = new System.Drawing.Point(13, 10);
			this.inputNeighborhoodCount.Name = "inputNeighborhoodCount";
			this.inputNeighborhoodCount.Size = new System.Drawing.Size(182, 16);
			this.inputNeighborhoodCount.TabIndex = 13;
			this.inputNeighborhoodCount.Text = "Number of Neighborhoods...";
			this.inputNeighborhoodCount.Enter += new System.EventHandler(this.InputNeighborhoodCount_Enter);
			this.inputNeighborhoodCount.Leave += new System.EventHandler(this.InputNeighborhoodCount_Leave);
			// 
			// buttonNext
			// 
			this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNext.FlatAppearance.BorderSize = 0;
			this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonNext.Location = new System.Drawing.Point(293, 315);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(79, 34);
			this.buttonNext.TabIndex = 19;
			this.buttonNext.Text = "Next";
			this.buttonNext.UseVisualStyleBackColor = false;
			this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
			// 
			// PopupDistrict
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.buttonNext);
			this.Controls.Add(this.panelCount);
			this.Controls.Add(this.panelName);
			this.Controls.Add(this.buttonBack);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "PopupDistrict";
			this.Text = "District";
			this.panelName.ResumeLayout(false);
			this.panelName.PerformLayout();
			this.panelCount.ResumeLayout(false);
			this.panelCount.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.Panel panelName;
		private System.Windows.Forms.Panel panelCount;
		private System.Windows.Forms.TextBox inputNeighborhoodCount;
		private System.Windows.Forms.Button buttonNext;
	}
}