namespace SOFT152Assignment
{
    partial class FormPublic
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
			this.buttonProperties = new System.Windows.Forms.Button();
			this.buttonNeighborhoods = new System.Windows.Forms.Button();
			this.buttonDistricts = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.inputSearch = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.listDisplay = new System.Windows.Forms.ListBox();
			this.buttonView = new System.Windows.Forms.Button();
			this.panelSearch.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonProperties
			// 
			this.buttonProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonProperties.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonProperties.FlatAppearance.BorderSize = 0;
			this.buttonProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonProperties.Location = new System.Drawing.Point(648, 12);
			this.buttonProperties.Name = "buttonProperties";
			this.buttonProperties.Size = new System.Drawing.Size(124, 60);
			this.buttonProperties.TabIndex = 25;
			this.buttonProperties.Text = "Properties";
			this.buttonProperties.UseVisualStyleBackColor = false;
			this.buttonProperties.Click += new System.EventHandler(this.ButtonProperties_Click);
			// 
			// buttonNeighborhoods
			// 
			this.buttonNeighborhoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNeighborhoods.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonNeighborhoods.FlatAppearance.BorderSize = 0;
			this.buttonNeighborhoods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNeighborhoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonNeighborhoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonNeighborhoods.Location = new System.Drawing.Point(478, 12);
			this.buttonNeighborhoods.Name = "buttonNeighborhoods";
			this.buttonNeighborhoods.Size = new System.Drawing.Size(158, 60);
			this.buttonNeighborhoods.TabIndex = 24;
			this.buttonNeighborhoods.Text = "Neighborhoods";
			this.buttonNeighborhoods.UseVisualStyleBackColor = false;
			this.buttonNeighborhoods.Click += new System.EventHandler(this.ButtonNeighborhoods_Click);
			// 
			// buttonDistricts
			// 
			this.buttonDistricts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonDistricts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonDistricts.FlatAppearance.BorderSize = 0;
			this.buttonDistricts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDistricts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonDistricts.Location = new System.Drawing.Point(368, 12);
			this.buttonDistricts.Name = "buttonDistricts";
			this.buttonDistricts.Size = new System.Drawing.Size(98, 60);
			this.buttonDistricts.TabIndex = 23;
			this.buttonDistricts.Tag = "";
			this.buttonDistricts.Text = "Districts";
			this.buttonDistricts.UseVisualStyleBackColor = false;
			this.buttonDistricts.Click += new System.EventHandler(this.ButtonDistricts_Click);
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
			this.buttonBack.TabIndex = 19;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
			// 
			// panelSearch
			// 
			this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelSearch.Controls.Add(this.inputSearch);
			this.panelSearch.Location = new System.Drawing.Point(12, 415);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(297, 34);
			this.panelSearch.TabIndex = 30;
			this.panelSearch.Click += new System.EventHandler(this.panelSearch_Click);
			// 
			// inputSearch
			// 
			this.inputSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputSearch.Location = new System.Drawing.Point(13, 10);
			this.inputSearch.Name = "inputSearch";
			this.inputSearch.Size = new System.Drawing.Size(270, 16);
			this.inputSearch.TabIndex = 13;
			this.inputSearch.Text = "Search...";
			this.inputSearch.Enter += new System.EventHandler(this.InputSearch_Enter);
			this.inputSearch.Leave += new System.EventHandler(this.InputSearch_Leave);
			// 
			// buttonSearch
			// 
			this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonSearch.FlatAppearance.BorderSize = 0;
			this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonSearch.Location = new System.Drawing.Point(322, 415);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(79, 34);
			this.buttonSearch.TabIndex = 27;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = false;
			// 
			// listDisplay
			// 
			this.listDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.listDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.listDisplay.FormattingEnabled = true;
			this.listDisplay.ItemHeight = 16;
			this.listDisplay.Location = new System.Drawing.Point(12, 84);
			this.listDisplay.MultiColumn = true;
			this.listDisplay.Name = "listDisplay";
			this.listDisplay.Size = new System.Drawing.Size(760, 320);
			this.listDisplay.TabIndex = 26;
			// 
			// buttonView
			// 
			this.buttonView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonView.FlatAppearance.BorderSize = 0;
			this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonView.Location = new System.Drawing.Point(710, 415);
			this.buttonView.Name = "buttonView";
			this.buttonView.Size = new System.Drawing.Size(62, 34);
			this.buttonView.TabIndex = 31;
			this.buttonView.Text = "View";
			this.buttonView.UseVisualStyleBackColor = false;
			this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
			// 
			// FormPublic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.buttonView);
			this.Controls.Add(this.panelSearch);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.listDisplay);
			this.Controls.Add(this.buttonProperties);
			this.Controls.Add(this.buttonNeighborhoods);
			this.Controls.Add(this.buttonDistricts);
			this.Controls.Add(this.buttonBack);
			this.Name = "FormPublic";
			this.Text = "Public Access";
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Button buttonNeighborhoods;
        private System.Windows.Forms.Button buttonDistricts;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.Button buttonView;
    }
}