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
			this.inputName = new System.Windows.Forms.TextBox();
			this.panelName = new System.Windows.Forms.Panel();
			this.buttonConfirm = new System.Windows.Forms.Button();
			this.inputNeighborhoodCount = new System.Windows.Forms.TextBox();
			this.panelCount = new System.Windows.Forms.Panel();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.panelName.SuspendLayout();
			this.panelCount.SuspendLayout();
			this.SuspendLayout();
			// 
			// inputName
			// 
			this.inputName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputName.Location = new System.Drawing.Point(13, 10);
			this.inputName.Name = "inputName";
			this.inputName.Size = new System.Drawing.Size(379, 16);
			this.inputName.TabIndex = 13;
			this.inputName.Text = "District Name...";
			this.inputName.Enter += new System.EventHandler(this.InputName_Enter);
			this.inputName.Leave += new System.EventHandler(this.InputName_Leave);
			// 
			// panelName
			// 
			this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelName.Controls.Add(this.inputName);
			this.panelName.Location = new System.Drawing.Point(12, 12);
			this.panelName.Name = "panelName";
			this.panelName.Size = new System.Drawing.Size(406, 34);
			this.panelName.TabIndex = 31;
			this.panelName.Click += new System.EventHandler(this.PanelName_Click);
			// 
			// buttonConfirm
			// 
			this.buttonConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonConfirm.FlatAppearance.BorderSize = 0;
			this.buttonConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonConfirm.Location = new System.Drawing.Point(339, 52);
			this.buttonConfirm.Name = "buttonConfirm";
			this.buttonConfirm.Size = new System.Drawing.Size(79, 34);
			this.buttonConfirm.TabIndex = 19;
			this.buttonConfirm.Text = "Confirm";
			this.buttonConfirm.UseVisualStyleBackColor = false;
			this.buttonConfirm.Click += new System.EventHandler(this.ButtonNext_Click);
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
			// panelCount
			// 
			this.panelCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelCount.Controls.Add(this.inputNeighborhoodCount);
			this.panelCount.Location = new System.Drawing.Point(12, 52);
			this.panelCount.Name = "panelCount";
			this.panelCount.Size = new System.Drawing.Size(209, 34);
			this.panelCount.TabIndex = 32;
			this.panelCount.Visible = false;
			this.panelCount.Click += new System.EventHandler(this.PanelCount_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonDelete.Location = new System.Drawing.Point(254, 52);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(79, 34);
			this.buttonDelete.TabIndex = 33;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
			// 
			// PopupDistrict
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(430, 95);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonConfirm);
			this.Controls.Add(this.panelCount);
			this.Controls.Add(this.panelName);
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
		private System.Windows.Forms.TextBox inputName;
		private System.Windows.Forms.Panel panelName;
		private System.Windows.Forms.Button buttonConfirm;
		private System.Windows.Forms.TextBox inputNeighborhoodCount;
		private System.Windows.Forms.Panel panelCount;
		private System.Windows.Forms.Button buttonDelete;
	}
}