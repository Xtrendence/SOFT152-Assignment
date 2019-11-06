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
			this.buttonNext = new System.Windows.Forms.Button();
			this.panelCount = new System.Windows.Forms.Panel();
			this.inputPropertyCount = new System.Windows.Forms.TextBox();
			this.panelName = new System.Windows.Forms.Panel();
			this.inputName = new System.Windows.Forms.TextBox();
			this.panelCount.SuspendLayout();
			this.panelName.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonNext
			// 
			this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNext.FlatAppearance.BorderSize = 0;
			this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonNext.Location = new System.Drawing.Point(293, 52);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(79, 34);
			this.buttonNext.TabIndex = 33;
			this.buttonNext.Text = "Next";
			this.buttonNext.UseVisualStyleBackColor = false;
			this.buttonNext.Click += new System.EventHandler(this.ButtonNext_Click);
			// 
			// panelCount
			// 
			this.panelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelCount.Controls.Add(this.inputPropertyCount);
			this.panelCount.Location = new System.Drawing.Point(12, 52);
			this.panelCount.Name = "panelCount";
			this.panelCount.Size = new System.Drawing.Size(179, 34);
			this.panelCount.TabIndex = 35;
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
			this.panelName.Controls.Add(this.inputName);
			this.panelName.Location = new System.Drawing.Point(12, 12);
			this.panelName.Name = "panelName";
			this.panelName.Size = new System.Drawing.Size(360, 34);
			this.panelName.TabIndex = 34;
			this.panelName.Click += new System.EventHandler(this.PanelName_Click);
			// 
			// inputName
			// 
			this.inputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputName.Location = new System.Drawing.Point(13, 10);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(331, 16);
			this.inputName.TabIndex = 13;
			this.inputName.Text = "Neighborhood Name...";
			this.inputName.Enter += new System.EventHandler(this.InputName_Enter);
			this.inputName.Leave += new System.EventHandler(this.InputName_Leave);
			// 
			// PopupNeighborhood
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(384, 95);
			this.Controls.Add(this.buttonNext);
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
			this.ResumeLayout(false);

        }

		#endregion
		private System.Windows.Forms.Button buttonNext;
		private System.Windows.Forms.Panel panelCount;
		private System.Windows.Forms.TextBox inputPropertyCount;
		private System.Windows.Forms.Panel panelName;
		private System.Windows.Forms.TextBox inputName;
	}
}