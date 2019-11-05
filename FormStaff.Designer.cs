namespace SOFT152Assignment
{
    partial class FormStaff
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
			this.inputSearch = new System.Windows.Forms.TextBox();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.listDisplay = new System.Windows.Forms.ListBox();
			this.buttonBack = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.panelSearch = new System.Windows.Forms.Panel();
			this.buttonProperties = new System.Windows.Forms.Button();
			this.buttonNeighborhoods = new System.Windows.Forms.Button();
			this.buttonDistricts = new System.Windows.Forms.Button();
			this.panelSearch.SuspendLayout();
			this.SuspendLayout();
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
			this.buttonSearch.TabIndex = 12;
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
			this.listDisplay.TabIndex = 11;
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
			this.buttonBack.TabIndex = 10;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonAdd.Location = new System.Drawing.Point(708, 415);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(64, 34);
			this.buttonAdd.TabIndex = 18;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonEdit.FlatAppearance.BorderSize = 0;
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonEdit.Location = new System.Drawing.Point(634, 415);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(62, 34);
			this.buttonEdit.TabIndex = 17;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// panelSearch
			// 
			this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelSearch.Controls.Add(this.inputSearch);
			this.panelSearch.Location = new System.Drawing.Point(12, 415);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Size = new System.Drawing.Size(297, 34);
			this.panelSearch.TabIndex = 19;
			this.panelSearch.Click += new System.EventHandler(this.panelSearch_Click);
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
			this.buttonProperties.TabIndex = 28;
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
			this.buttonNeighborhoods.TabIndex = 27;
			this.buttonNeighborhoods.Text = "Neighborhoods";
			this.buttonNeighborhoods.UseVisualStyleBackColor = false;
			this.buttonNeighborhoods.Click += new System.EventHandler(this.ButtonNeighborhoods_Click);
			// 
			// buttonDistricts
			// 
			this.buttonDistricts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.buttonDistricts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonDistricts.FlatAppearance.BorderSize = 0;
			this.buttonDistricts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDistricts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.buttonDistricts.Location = new System.Drawing.Point(368, 12);
			this.buttonDistricts.Name = "buttonDistricts";
			this.buttonDistricts.Size = new System.Drawing.Size(98, 60);
			this.buttonDistricts.TabIndex = 26;
			this.buttonDistricts.Tag = "active-category";
			this.buttonDistricts.Text = "Districts";
			this.buttonDistricts.UseVisualStyleBackColor = false;
			this.buttonDistricts.Click += new System.EventHandler(this.ButtonDistricts_Click);
			// 
			// FormStaff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(784, 461);
			this.Controls.Add(this.buttonProperties);
			this.Controls.Add(this.panelSearch);
			this.Controls.Add(this.buttonNeighborhoods);
			this.Controls.Add(this.buttonDistricts);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonSearch);
			this.Controls.Add(this.listDisplay);
			this.Controls.Add(this.buttonBack);
			this.Name = "FormStaff";
			this.Text = "Staff Access";
			this.panelSearch.ResumeLayout(false);
			this.panelSearch.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox inputSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listDisplay;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button buttonProperties;
        private System.Windows.Forms.Button buttonNeighborhoods;
        private System.Windows.Forms.Button buttonDistricts;
    }
}