namespace SOFT152Assignment
{
    partial class FormMain
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
			this.labelFileDialog = new System.Windows.Forms.Label();
			this.fileDialog = new System.Windows.Forms.OpenFileDialog();
			this.listviewDistricts = new System.Windows.Forms.ListView();
			this.listviewNeighborhoods = new System.Windows.Forms.ListView();
			this.listviewProperties = new System.Windows.Forms.ListView();
			this.inputSearchDistrict = new System.Windows.Forms.TextBox();
			this.panelSearchDistrict = new System.Windows.Forms.Panel();
			this.buttonViewDistrict = new System.Windows.Forms.Button();
			this.buttonEditDistrict = new System.Windows.Forms.Button();
			this.buttonAddDistrict = new System.Windows.Forms.Button();
			this.buttonAddNeighborhood = new System.Windows.Forms.Button();
			this.buttonEditNeighborhood = new System.Windows.Forms.Button();
			this.buttonViewNeighborhood = new System.Windows.Forms.Button();
			this.buttonAddProperty = new System.Windows.Forms.Button();
			this.buttonEditProperty = new System.Windows.Forms.Button();
			this.buttonViewProperty = new System.Windows.Forms.Button();
			this.buttonAnalysis = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.labelSelectDistrict = new System.Windows.Forms.Label();
			this.labelSelectDistrictAndNeighborhood = new System.Windows.Forms.Label();
			this.panelSearchDistrict.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
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
			// labelFileDialog
			// 
			this.labelFileDialog.AllowDrop = true;
			this.labelFileDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.labelFileDialog.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFileDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.labelFileDialog.Location = new System.Drawing.Point(10, 84);
			this.labelFileDialog.Name = "labelFileDialog";
			this.labelFileDialog.Size = new System.Drawing.Size(1414, 803);
			this.labelFileDialog.TabIndex = 33;
			this.labelFileDialog.Text = "Select a Data Source...";
			this.labelFileDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelFileDialog.Click += new System.EventHandler(this.LabelFileDialog_Click);
			this.labelFileDialog.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelFileDialog_DragDrop);
			this.labelFileDialog.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelFileDialog_DragEnter);
			this.labelFileDialog.DragOver += new System.Windows.Forms.DragEventHandler(this.LabelFileDialog_DragOver);
			this.labelFileDialog.DragLeave += new System.EventHandler(this.LabelFileDialog_DragLeave);
			this.labelFileDialog.MouseEnter += new System.EventHandler(this.LabelFileDialog_MouseEnter);
			this.labelFileDialog.MouseLeave += new System.EventHandler(this.LabelFileDialog_MouseLeave);
			// 
			// fileDialog
			// 
			this.fileDialog.FileName = "openFileDialog1";
			this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.FileDialog_FileOk);
			// 
			// listviewDistricts
			// 
			this.listviewDistricts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.listviewDistricts.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listviewDistricts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listviewDistricts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.listviewDistricts.FullRowSelect = true;
			this.listviewDistricts.HideSelection = false;
			this.listviewDistricts.Location = new System.Drawing.Point(12, 84);
			this.listviewDistricts.MultiSelect = false;
			this.listviewDistricts.Name = "listviewDistricts";
			this.listviewDistricts.Size = new System.Drawing.Size(1100, 153);
			this.listviewDistricts.TabIndex = 34;
			this.listviewDistricts.UseCompatibleStateImageBehavior = false;
			this.listviewDistricts.View = System.Windows.Forms.View.Details;
			this.listviewDistricts.Visible = false;
			this.listviewDistricts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListviewDistricts_ItemSelectionChanged);
			// 
			// listviewNeighborhoods
			// 
			this.listviewNeighborhoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.listviewNeighborhoods.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listviewNeighborhoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listviewNeighborhoods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.listviewNeighborhoods.FullRowSelect = true;
			this.listviewNeighborhoods.HideSelection = false;
			this.listviewNeighborhoods.Location = new System.Drawing.Point(12, 243);
			this.listviewNeighborhoods.MultiSelect = false;
			this.listviewNeighborhoods.Name = "listviewNeighborhoods";
			this.listviewNeighborhoods.Size = new System.Drawing.Size(1100, 224);
			this.listviewNeighborhoods.TabIndex = 35;
			this.listviewNeighborhoods.UseCompatibleStateImageBehavior = false;
			this.listviewNeighborhoods.View = System.Windows.Forms.View.Details;
			this.listviewNeighborhoods.Visible = false;
			this.listviewNeighborhoods.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListviewNeighborhoods_ItemSelectionChanged);
			// 
			// listviewProperties
			// 
			this.listviewProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.listviewProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listviewProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listviewProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.listviewProperties.FullRowSelect = true;
			this.listviewProperties.HideSelection = false;
			this.listviewProperties.Location = new System.Drawing.Point(12, 473);
			this.listviewProperties.MultiSelect = false;
			this.listviewProperties.Name = "listviewProperties";
			this.listviewProperties.Size = new System.Drawing.Size(1100, 423);
			this.listviewProperties.TabIndex = 36;
			this.listviewProperties.UseCompatibleStateImageBehavior = false;
			this.listviewProperties.View = System.Windows.Forms.View.Details;
			this.listviewProperties.Visible = false;
			this.listviewProperties.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ListviewProperties_ItemSelectionChanged);
			// 
			// inputSearchDistrict
			// 
			this.inputSearchDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputSearchDistrict.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputSearchDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputSearchDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputSearchDistrict.Location = new System.Drawing.Point(13, 10);
			this.inputSearchDistrict.Name = "inputSearchDistrict";
			this.inputSearchDistrict.Size = new System.Drawing.Size(270, 16);
			this.inputSearchDistrict.TabIndex = 13;
			this.inputSearchDistrict.Text = "Search...";
			this.inputSearchDistrict.Enter += new System.EventHandler(this.InputSearchDistrict_Enter);
			this.inputSearchDistrict.KeyUp += new System.Windows.Forms.KeyEventHandler(this.InputSearchDistrict_KeyUp);
			this.inputSearchDistrict.Leave += new System.EventHandler(this.InputSearchDistrict_Leave);
			// 
			// panelSearchDistrict
			// 
			this.panelSearchDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelSearchDistrict.Controls.Add(this.inputSearchDistrict);
			this.panelSearchDistrict.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.panelSearchDistrict.Location = new System.Drawing.Point(1131, 182);
			this.panelSearchDistrict.Name = "panelSearchDistrict";
			this.panelSearchDistrict.Size = new System.Drawing.Size(297, 34);
			this.panelSearchDistrict.TabIndex = 19;
			this.panelSearchDistrict.Click += new System.EventHandler(this.PanelSearchDistrict_Click);
			// 
			// buttonViewDistrict
			// 
			this.buttonViewDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonViewDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonViewDistrict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonViewDistrict.FlatAppearance.BorderSize = 0;
			this.buttonViewDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonViewDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonViewDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonViewDistrict.Location = new System.Drawing.Point(1320, 137);
			this.buttonViewDistrict.Name = "buttonViewDistrict";
			this.buttonViewDistrict.Size = new System.Drawing.Size(106, 34);
			this.buttonViewDistrict.TabIndex = 37;
			this.buttonViewDistrict.Text = "View";
			this.buttonViewDistrict.UseVisualStyleBackColor = false;
			this.buttonViewDistrict.Click += new System.EventHandler(this.ButtonViewDistrict_Click);
			// 
			// buttonEditDistrict
			// 
			this.buttonEditDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonEditDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonEditDistrict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonEditDistrict.FlatAppearance.BorderSize = 0;
			this.buttonEditDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonEditDistrict.Location = new System.Drawing.Point(1223, 137);
			this.buttonEditDistrict.Name = "buttonEditDistrict";
			this.buttonEditDistrict.Size = new System.Drawing.Size(91, 34);
			this.buttonEditDistrict.TabIndex = 17;
			this.buttonEditDistrict.Text = "Edit";
			this.buttonEditDistrict.UseVisualStyleBackColor = false;
			this.buttonEditDistrict.Click += new System.EventHandler(this.ButtonEditDistrict_Click);
			// 
			// buttonAddDistrict
			// 
			this.buttonAddDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonAddDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAddDistrict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonAddDistrict.FlatAppearance.BorderSize = 0;
			this.buttonAddDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonAddDistrict.Location = new System.Drawing.Point(1131, 137);
			this.buttonAddDistrict.Name = "buttonAddDistrict";
			this.buttonAddDistrict.Size = new System.Drawing.Size(86, 34);
			this.buttonAddDistrict.TabIndex = 18;
			this.buttonAddDistrict.Text = "Add";
			this.buttonAddDistrict.UseVisualStyleBackColor = false;
			this.buttonAddDistrict.Click += new System.EventHandler(this.ButtonAddDistrict_Click);
			// 
			// buttonAddNeighborhood
			// 
			this.buttonAddNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonAddNeighborhood.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAddNeighborhood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonAddNeighborhood.FlatAppearance.BorderSize = 0;
			this.buttonAddNeighborhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonAddNeighborhood.Location = new System.Drawing.Point(1131, 319);
			this.buttonAddNeighborhood.Name = "buttonAddNeighborhood";
			this.buttonAddNeighborhood.Size = new System.Drawing.Size(86, 34);
			this.buttonAddNeighborhood.TabIndex = 39;
			this.buttonAddNeighborhood.Text = "Add";
			this.buttonAddNeighborhood.UseVisualStyleBackColor = false;
			this.buttonAddNeighborhood.Click += new System.EventHandler(this.ButtonAddNeighborhood_Click);
			// 
			// buttonEditNeighborhood
			// 
			this.buttonEditNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonEditNeighborhood.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonEditNeighborhood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonEditNeighborhood.FlatAppearance.BorderSize = 0;
			this.buttonEditNeighborhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonEditNeighborhood.Location = new System.Drawing.Point(1223, 319);
			this.buttonEditNeighborhood.Name = "buttonEditNeighborhood";
			this.buttonEditNeighborhood.Size = new System.Drawing.Size(91, 34);
			this.buttonEditNeighborhood.TabIndex = 38;
			this.buttonEditNeighborhood.Text = "Edit";
			this.buttonEditNeighborhood.UseVisualStyleBackColor = false;
			this.buttonEditNeighborhood.Click += new System.EventHandler(this.ButtonEditNeighborhood_Click);
			// 
			// buttonViewNeighborhood
			// 
			this.buttonViewNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonViewNeighborhood.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonViewNeighborhood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonViewNeighborhood.FlatAppearance.BorderSize = 0;
			this.buttonViewNeighborhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonViewNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonViewNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonViewNeighborhood.Location = new System.Drawing.Point(1320, 319);
			this.buttonViewNeighborhood.Name = "buttonViewNeighborhood";
			this.buttonViewNeighborhood.Size = new System.Drawing.Size(106, 34);
			this.buttonViewNeighborhood.TabIndex = 41;
			this.buttonViewNeighborhood.Text = "View";
			this.buttonViewNeighborhood.UseVisualStyleBackColor = false;
			this.buttonViewNeighborhood.Click += new System.EventHandler(this.ButtonViewNeighborhood_Click);
			// 
			// buttonAddProperty
			// 
			this.buttonAddProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonAddProperty.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAddProperty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonAddProperty.FlatAppearance.BorderSize = 0;
			this.buttonAddProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonAddProperty.Location = new System.Drawing.Point(1131, 524);
			this.buttonAddProperty.Name = "buttonAddProperty";
			this.buttonAddProperty.Size = new System.Drawing.Size(86, 34);
			this.buttonAddProperty.TabIndex = 43;
			this.buttonAddProperty.Text = "Add";
			this.buttonAddProperty.UseVisualStyleBackColor = false;
			this.buttonAddProperty.Click += new System.EventHandler(this.ButtonAddProperty_Click);
			// 
			// buttonEditProperty
			// 
			this.buttonEditProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonEditProperty.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonEditProperty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonEditProperty.FlatAppearance.BorderSize = 0;
			this.buttonEditProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonEditProperty.Location = new System.Drawing.Point(1223, 524);
			this.buttonEditProperty.Name = "buttonEditProperty";
			this.buttonEditProperty.Size = new System.Drawing.Size(91, 34);
			this.buttonEditProperty.TabIndex = 42;
			this.buttonEditProperty.Text = "Edit";
			this.buttonEditProperty.UseVisualStyleBackColor = false;
			this.buttonEditProperty.Click += new System.EventHandler(this.ButtonEditProperty_Click);
			// 
			// buttonViewProperty
			// 
			this.buttonViewProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonViewProperty.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonViewProperty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonViewProperty.FlatAppearance.BorderSize = 0;
			this.buttonViewProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonViewProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonViewProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonViewProperty.Location = new System.Drawing.Point(1320, 524);
			this.buttonViewProperty.Name = "buttonViewProperty";
			this.buttonViewProperty.Size = new System.Drawing.Size(107, 34);
			this.buttonViewProperty.TabIndex = 45;
			this.buttonViewProperty.Text = "View";
			this.buttonViewProperty.UseVisualStyleBackColor = false;
			this.buttonViewProperty.Click += new System.EventHandler(this.ButtonViewProperty_Click);
			// 
			// buttonAnalysis
			// 
			this.buttonAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAnalysis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonAnalysis.FlatAppearance.BorderSize = 0;
			this.buttonAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonAnalysis.Location = new System.Drawing.Point(106, 12);
			this.buttonAnalysis.Name = "buttonAnalysis";
			this.buttonAnalysis.Size = new System.Drawing.Size(90, 60);
			this.buttonAnalysis.TabIndex = 46;
			this.buttonAnalysis.Text = "Analysis";
			this.buttonAnalysis.UseVisualStyleBackColor = false;
			this.buttonAnalysis.Visible = false;
			this.buttonAnalysis.Click += new System.EventHandler(this.ButtonAnalysis_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.label1.Location = new System.Drawing.Point(1129, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 41);
			this.label1.TabIndex = 47;
			this.label1.Text = "Districts";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.label2.Location = new System.Drawing.Point(1129, 267);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(295, 41);
			this.label2.TabIndex = 48;
			this.label2.Text = "Neighborhoods";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.label3.Location = new System.Drawing.Point(1129, 473);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(295, 41);
			this.label3.TabIndex = 49;
			this.label3.Text = "Properties";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonSave.FlatAppearance.BorderSize = 0;
			this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonSave.Location = new System.Drawing.Point(1022, 12);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(90, 60);
			this.buttonSave.TabIndex = 50;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = false;
			this.buttonSave.Visible = false;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
			// 
			// labelSelectDistrict
			// 
			this.labelSelectDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.labelSelectDistrict.Cursor = System.Windows.Forms.Cursors.Default;
			this.labelSelectDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSelectDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.labelSelectDistrict.Location = new System.Drawing.Point(10, 243);
			this.labelSelectDistrict.Name = "labelSelectDistrict";
			this.labelSelectDistrict.Size = new System.Drawing.Size(1100, 224);
			this.labelSelectDistrict.TabIndex = 51;
			this.labelSelectDistrict.Text = "Select a District First...";
			this.labelSelectDistrict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSelectDistrict.Visible = false;
			// 
			// labelSelectDistrictAndNeighborhood
			// 
			this.labelSelectDistrictAndNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.labelSelectDistrictAndNeighborhood.Cursor = System.Windows.Forms.Cursors.Default;
			this.labelSelectDistrictAndNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSelectDistrictAndNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.labelSelectDistrictAndNeighborhood.Location = new System.Drawing.Point(10, 473);
			this.labelSelectDistrictAndNeighborhood.Name = "labelSelectDistrictAndNeighborhood";
			this.labelSelectDistrictAndNeighborhood.Size = new System.Drawing.Size(1100, 423);
			this.labelSelectDistrictAndNeighborhood.TabIndex = 52;
			this.labelSelectDistrictAndNeighborhood.Text = "Select a District && Neighborhood First";
			this.labelSelectDistrictAndNeighborhood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelSelectDistrictAndNeighborhood.Visible = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
			this.ClientSize = new System.Drawing.Size(1283, 690);
			this.Controls.Add(this.labelFileDialog);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAnalysis);
			this.Controls.Add(this.buttonAddProperty);
			this.Controls.Add(this.buttonEditProperty);
			this.Controls.Add(this.buttonAddNeighborhood);
			this.Controls.Add(this.buttonViewProperty);
			this.Controls.Add(this.buttonEditNeighborhood);
			this.Controls.Add(this.panelSearchDistrict);
			this.Controls.Add(this.buttonViewNeighborhood);
			this.Controls.Add(this.buttonAddDistrict);
			this.Controls.Add(this.buttonEditDistrict);
			this.Controls.Add(this.buttonViewDistrict);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.labelSelectDistrict);
			this.Controls.Add(this.labelSelectDistrictAndNeighborhood);
			this.Controls.Add(this.listviewDistricts);
			this.Controls.Add(this.listviewNeighborhoods);
			this.Controls.Add(this.listviewProperties);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1452, 938);
			this.Name = "FormMain";
			this.Text = "Access";
			this.Activated += new System.EventHandler(this.FormMain_Activated);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.panelSearchDistrict.ResumeLayout(false);
			this.panelSearchDistrict.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
		private System.Windows.Forms.Label labelFileDialog;
		private System.Windows.Forms.OpenFileDialog fileDialog;
		private System.Windows.Forms.ListView listviewDistricts;
		private System.Windows.Forms.ListView listviewNeighborhoods;
		private System.Windows.Forms.ListView listviewProperties;
		private System.Windows.Forms.TextBox inputSearchDistrict;
		private System.Windows.Forms.Panel panelSearchDistrict;
		private System.Windows.Forms.Button buttonViewDistrict;
		private System.Windows.Forms.Button buttonEditDistrict;
		private System.Windows.Forms.Button buttonAddDistrict;
		private System.Windows.Forms.Button buttonAddNeighborhood;
		private System.Windows.Forms.Button buttonEditNeighborhood;
		private System.Windows.Forms.Button buttonViewNeighborhood;
		private System.Windows.Forms.Button buttonAddProperty;
		private System.Windows.Forms.Button buttonEditProperty;
		private System.Windows.Forms.Button buttonViewProperty;
		private System.Windows.Forms.Button buttonAnalysis;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label labelSelectDistrict;
		private System.Windows.Forms.Label labelSelectDistrictAndNeighborhood;
	}
}