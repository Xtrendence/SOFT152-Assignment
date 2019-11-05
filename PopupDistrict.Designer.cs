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
			this.panel1 = new System.Windows.Forms.Panel();
			this.inputNeighborhoodCount = new System.Windows.Forms.TextBox();
			this.buttonNext = new System.Windows.Forms.Button();
			this.panelName.SuspendLayout();
			this.panel1.SuspendLayout();
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
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// inputName
			// 
			this.inputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputName.Location = new System.Drawing.Point(13, 10);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(270, 16);
			this.inputName.TabIndex = 13;
			this.inputName.Text = "District Name...";
			// 
			// panelName
			// 
			this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelName.Controls.Add(this.inputName);
			this.panelName.Location = new System.Drawing.Point(12, 84);
			this.panelName.Name = "panelName";
			this.panelName.Size = new System.Drawing.Size(297, 34);
			this.panelName.TabIndex = 31;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panel1.Controls.Add(this.inputNeighborhoodCount);
			this.panel1.Location = new System.Drawing.Point(12, 130);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(297, 34);
			this.panel1.TabIndex = 32;
			// 
			// inputNeighborhoodCount
			// 
			this.inputNeighborhoodCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputNeighborhoodCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputNeighborhoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputNeighborhoodCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputNeighborhoodCount.Location = new System.Drawing.Point(13, 10);
			this.inputNeighborhoodCount.Name = "inputNeighborhoodCount";
			this.inputNeighborhoodCount.Size = new System.Drawing.Size(270, 16);
			this.inputNeighborhoodCount.TabIndex = 13;
			this.inputNeighborhoodCount.Text = "Number of Neighborhoods...";
			// 
			// buttonNext
			// 
			this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNext.FlatAppearance.BorderSize = 0;
			this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonNext.Location = new System.Drawing.Point(12, 176);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(79, 34);
			this.buttonNext.TabIndex = 19;
			this.buttonNext.Text = "Next";
			this.buttonNext.UseVisualStyleBackColor = false;
			// 
			// PopupDistrict
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.buttonNext);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelName);
			this.Controls.Add(this.buttonBack);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.Name = "PopupDistrict";
			this.Text = "District";
			this.panelName.ResumeLayout(false);
			this.panelName.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.Panel panelName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox inputNeighborhoodCount;
		private System.Windows.Forms.Button buttonNext;
	}
}