namespace SOFT152Assignment
{
    partial class FormAccess
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccess));
			this.buttonPublic = new System.Windows.Forms.Button();
			this.buttonStaff = new System.Windows.Forms.Button();
			this.labelAccess = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonPublic
			// 
			this.buttonPublic.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonPublic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonPublic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonPublic.FlatAppearance.BorderSize = 0;
			this.buttonPublic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonPublic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonPublic.Location = new System.Drawing.Point(592, 239);
			this.buttonPublic.Name = "buttonPublic";
			this.buttonPublic.Size = new System.Drawing.Size(120, 60);
			this.buttonPublic.TabIndex = 0;
			this.buttonPublic.Text = "Public";
			this.buttonPublic.UseVisualStyleBackColor = false;
			this.buttonPublic.Click += new System.EventHandler(this.ButtonPublic_Click);
			// 
			// buttonStaff
			// 
			this.buttonStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonStaff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonStaff.FlatAppearance.BorderSize = 0;
			this.buttonStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonStaff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonStaff.Location = new System.Drawing.Point(727, 239);
			this.buttonStaff.Name = "buttonStaff";
			this.buttonStaff.Size = new System.Drawing.Size(120, 60);
			this.buttonStaff.TabIndex = 1;
			this.buttonStaff.Text = "Staff";
			this.buttonStaff.UseVisualStyleBackColor = false;
			this.buttonStaff.Click += new System.EventHandler(this.ButtonStaff_Click);
			// 
			// labelAccess
			// 
			this.labelAccess.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.labelAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.labelAccess.Location = new System.Drawing.Point(592, 183);
			this.labelAccess.Name = "labelAccess";
			this.labelAccess.Size = new System.Drawing.Size(255, 41);
			this.labelAccess.TabIndex = 2;
			this.labelAccess.Text = "Access Level";
			this.labelAccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.label1.Location = new System.Drawing.Point(327, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(785, 58);
			this.label1.TabIndex = 3;
			this.label1.Text = "Airbnb Management Tool";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormAccess
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(1438, 905);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelAccess);
			this.Controls.Add(this.buttonStaff);
			this.Controls.Add(this.buttonPublic);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormAccess";
			this.Text = "Access Level";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAccess_FormClosed);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPublic;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Label labelAccess;
		private System.Windows.Forms.Label label1;
	}
}

