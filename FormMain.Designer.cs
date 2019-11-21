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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
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
			this.panelSearchNeighborhood = new System.Windows.Forms.Panel();
			this.inputSearchNeighborhood = new System.Windows.Forms.TextBox();
			this.buttonAddNeighborhood = new System.Windows.Forms.Button();
			this.buttonEditNeighborhood = new System.Windows.Forms.Button();
			this.buttonViewNeighborhood = new System.Windows.Forms.Button();
			this.panelSearchProperty = new System.Windows.Forms.Panel();
			this.inputSearchProperty = new System.Windows.Forms.TextBox();
			this.buttonAddProperty = new System.Windows.Forms.Button();
			this.buttonEditProperty = new System.Windows.Forms.Button();
			this.buttonViewProperty = new System.Windows.Forms.Button();
			this.panelSearchDistrict.SuspendLayout();
			this.panelSearchNeighborhood.SuspendLayout();
			this.panelSearchProperty.SuspendLayout();
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
			this.buttonBack.TabIndex = 10;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = false;
			this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
			// 
			// labelFileDialog
			// 
			this.labelFileDialog.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labelFileDialog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.labelFileDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelFileDialog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.labelFileDialog.Location = new System.Drawing.Point(12, 84);
			this.labelFileDialog.Name = "labelFileDialog";
			this.labelFileDialog.Size = new System.Drawing.Size(55, 47);
			this.labelFileDialog.TabIndex = 33;
			this.labelFileDialog.Text = "Select Data Source...";
			this.labelFileDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelFileDialog.Click += new System.EventHandler(this.LabelFileDialog_Click);
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
			this.listviewDistricts.Size = new System.Drawing.Size(1099, 124);
			this.listviewDistricts.Sorting = System.Windows.Forms.SortOrder.Ascending;
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
			this.listviewNeighborhoods.Location = new System.Drawing.Point(12, 214);
			this.listviewNeighborhoods.MultiSelect = false;
			this.listviewNeighborhoods.Name = "listviewNeighborhoods";
			this.listviewNeighborhoods.Size = new System.Drawing.Size(1099, 229);
			this.listviewNeighborhoods.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listviewNeighborhoods.TabIndex = 35;
			this.listviewNeighborhoods.UseCompatibleStateImageBehavior = false;
			this.listviewNeighborhoods.View = System.Windows.Forms.View.Details;
			this.listviewNeighborhoods.Visible = false;
			this.listviewNeighborhoods.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listviewNeighborhoods_ItemSelectionChanged);
			// 
			// listviewProperties
			// 
			this.listviewProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.listviewProperties.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listviewProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listviewProperties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.listviewProperties.FullRowSelect = true;
			this.listviewProperties.HideSelection = false;
			this.listviewProperties.Location = new System.Drawing.Point(12, 449);
			this.listviewProperties.MultiSelect = false;
			this.listviewProperties.Name = "listviewProperties";
			this.listviewProperties.Size = new System.Drawing.Size(1099, 447);
			this.listviewProperties.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listviewProperties.TabIndex = 36;
			this.listviewProperties.UseCompatibleStateImageBehavior = false;
			this.listviewProperties.View = System.Windows.Forms.View.Details;
			this.listviewProperties.Visible = false;
			this.listviewProperties.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listviewProperties_ItemSelectionChanged);
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
			this.panelSearchDistrict.Location = new System.Drawing.Point(1131, 129);
			this.panelSearchDistrict.Name = "panelSearchDistrict";
			this.panelSearchDistrict.Size = new System.Drawing.Size(297, 34);
			this.panelSearchDistrict.TabIndex = 19;
			this.panelSearchDistrict.Click += new System.EventHandler(this.PanelSearchDistrict_Click);
			// 
			// buttonViewDistrict
			// 
			this.buttonViewDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonViewDistrict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonViewDistrict.FlatAppearance.BorderSize = 0;
			this.buttonViewDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonViewDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonViewDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonViewDistrict.Location = new System.Drawing.Point(1131, 174);
			this.buttonViewDistrict.Name = "buttonViewDistrict";
			this.buttonViewDistrict.Size = new System.Drawing.Size(62, 34);
			this.buttonViewDistrict.TabIndex = 37;
			this.buttonViewDistrict.Text = "View";
			this.buttonViewDistrict.UseVisualStyleBackColor = false;
			this.buttonViewDistrict.Click += new System.EventHandler(this.ButtonViewDistrict_Click);
			// 
			// buttonEditDistrict
			// 
			this.buttonEditDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonEditDistrict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonEditDistrict.FlatAppearance.BorderSize = 0;
			this.buttonEditDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonEditDistrict.Location = new System.Drawing.Point(1215, 84);
			this.buttonEditDistrict.Name = "buttonEditDistrict";
			this.buttonEditDistrict.Size = new System.Drawing.Size(62, 34);
			this.buttonEditDistrict.TabIndex = 17;
			this.buttonEditDistrict.Text = "Edit";
			this.buttonEditDistrict.UseVisualStyleBackColor = false;
			this.buttonEditDistrict.Click += new System.EventHandler(this.ButtonEditDistrict_Click);
			// 
			// buttonAddDistrict
			// 
			this.buttonAddDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonAddDistrict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonAddDistrict.FlatAppearance.BorderSize = 0;
			this.buttonAddDistrict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonAddDistrict.Location = new System.Drawing.Point(1131, 84);
			this.buttonAddDistrict.Name = "buttonAddDistrict";
			this.buttonAddDistrict.Size = new System.Drawing.Size(64, 34);
			this.buttonAddDistrict.TabIndex = 18;
			this.buttonAddDistrict.Text = "Add";
			this.buttonAddDistrict.UseVisualStyleBackColor = false;
			this.buttonAddDistrict.Click += new System.EventHandler(this.ButtonAddDistrict_Click);
			// 
			// panelSearchNeighborhood
			// 
			this.panelSearchNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelSearchNeighborhood.Controls.Add(this.inputSearchNeighborhood);
			this.panelSearchNeighborhood.Location = new System.Drawing.Point(1131, 314);
			this.panelSearchNeighborhood.Name = "panelSearchNeighborhood";
			this.panelSearchNeighborhood.Size = new System.Drawing.Size(297, 34);
			this.panelSearchNeighborhood.TabIndex = 40;
			// 
			// inputSearchNeighborhood
			// 
			this.inputSearchNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputSearchNeighborhood.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputSearchNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputSearchNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputSearchNeighborhood.Location = new System.Drawing.Point(13, 10);
			this.inputSearchNeighborhood.Name = "inputSearchNeighborhood";
			this.inputSearchNeighborhood.Size = new System.Drawing.Size(270, 16);
			this.inputSearchNeighborhood.TabIndex = 13;
			this.inputSearchNeighborhood.Text = "Search...";
			// 
			// buttonAddNeighborhood
			// 
			this.buttonAddNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonAddNeighborhood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonAddNeighborhood.FlatAppearance.BorderSize = 0;
			this.buttonAddNeighborhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonAddNeighborhood.Location = new System.Drawing.Point(1131, 269);
			this.buttonAddNeighborhood.Name = "buttonAddNeighborhood";
			this.buttonAddNeighborhood.Size = new System.Drawing.Size(64, 34);
			this.buttonAddNeighborhood.TabIndex = 39;
			this.buttonAddNeighborhood.Text = "Add";
			this.buttonAddNeighborhood.UseVisualStyleBackColor = false;
			// 
			// buttonEditNeighborhood
			// 
			this.buttonEditNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonEditNeighborhood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonEditNeighborhood.FlatAppearance.BorderSize = 0;
			this.buttonEditNeighborhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonEditNeighborhood.Location = new System.Drawing.Point(1215, 269);
			this.buttonEditNeighborhood.Name = "buttonEditNeighborhood";
			this.buttonEditNeighborhood.Size = new System.Drawing.Size(62, 34);
			this.buttonEditNeighborhood.TabIndex = 38;
			this.buttonEditNeighborhood.Text = "Edit";
			this.buttonEditNeighborhood.UseVisualStyleBackColor = false;
			// 
			// buttonViewNeighborhood
			// 
			this.buttonViewNeighborhood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonViewNeighborhood.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonViewNeighborhood.FlatAppearance.BorderSize = 0;
			this.buttonViewNeighborhood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonViewNeighborhood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonViewNeighborhood.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonViewNeighborhood.Location = new System.Drawing.Point(1131, 359);
			this.buttonViewNeighborhood.Name = "buttonViewNeighborhood";
			this.buttonViewNeighborhood.Size = new System.Drawing.Size(62, 34);
			this.buttonViewNeighborhood.TabIndex = 41;
			this.buttonViewNeighborhood.Text = "View";
			this.buttonViewNeighborhood.UseVisualStyleBackColor = false;
			// 
			// panelSearchProperty
			// 
			this.panelSearchProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.panelSearchProperty.Controls.Add(this.inputSearchProperty);
			this.panelSearchProperty.Location = new System.Drawing.Point(1131, 672);
			this.panelSearchProperty.Name = "panelSearchProperty";
			this.panelSearchProperty.Size = new System.Drawing.Size(297, 34);
			this.panelSearchProperty.TabIndex = 44;
			// 
			// inputSearchProperty
			// 
			this.inputSearchProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.inputSearchProperty.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputSearchProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputSearchProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
			this.inputSearchProperty.Location = new System.Drawing.Point(13, 10);
			this.inputSearchProperty.Name = "inputSearchProperty";
			this.inputSearchProperty.Size = new System.Drawing.Size(270, 16);
			this.inputSearchProperty.TabIndex = 13;
			this.inputSearchProperty.Text = "Search...";
			// 
			// buttonAddProperty
			// 
			this.buttonAddProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonAddProperty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonAddProperty.FlatAppearance.BorderSize = 0;
			this.buttonAddProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAddProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonAddProperty.Location = new System.Drawing.Point(1131, 627);
			this.buttonAddProperty.Name = "buttonAddProperty";
			this.buttonAddProperty.Size = new System.Drawing.Size(64, 34);
			this.buttonAddProperty.TabIndex = 43;
			this.buttonAddProperty.Text = "Add";
			this.buttonAddProperty.UseVisualStyleBackColor = false;
			// 
			// buttonEditProperty
			// 
			this.buttonEditProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonEditProperty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonEditProperty.FlatAppearance.BorderSize = 0;
			this.buttonEditProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEditProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonEditProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonEditProperty.Location = new System.Drawing.Point(1215, 627);
			this.buttonEditProperty.Name = "buttonEditProperty";
			this.buttonEditProperty.Size = new System.Drawing.Size(62, 34);
			this.buttonEditProperty.TabIndex = 42;
			this.buttonEditProperty.Text = "Edit";
			this.buttonEditProperty.UseVisualStyleBackColor = false;
			// 
			// buttonViewProperty
			// 
			this.buttonViewProperty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
			this.buttonViewProperty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.buttonViewProperty.FlatAppearance.BorderSize = 0;
			this.buttonViewProperty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonViewProperty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonViewProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			this.buttonViewProperty.Location = new System.Drawing.Point(1131, 717);
			this.buttonViewProperty.Name = "buttonViewProperty";
			this.buttonViewProperty.Size = new System.Drawing.Size(62, 34);
			this.buttonViewProperty.TabIndex = 45;
			this.buttonViewProperty.Text = "View";
			this.buttonViewProperty.UseVisualStyleBackColor = false;
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.ClientSize = new System.Drawing.Size(1438, 905);
			this.Controls.Add(this.labelFileDialog);
			this.Controls.Add(this.panelSearchProperty);
			this.Controls.Add(this.buttonAddProperty);
			this.Controls.Add(this.panelSearchNeighborhood);
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
			this.Controls.Add(this.listviewDistricts);
			this.Controls.Add(this.listviewNeighborhoods);
			this.Controls.Add(this.listviewProperties);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1454, 944);
			this.Name = "FormMain";
			this.Text = "Access";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
			this.panelSearchDistrict.ResumeLayout(false);
			this.panelSearchDistrict.PerformLayout();
			this.panelSearchNeighborhood.ResumeLayout(false);
			this.panelSearchNeighborhood.PerformLayout();
			this.panelSearchProperty.ResumeLayout(false);
			this.panelSearchProperty.PerformLayout();
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
		private System.Windows.Forms.Panel panelSearchNeighborhood;
		private System.Windows.Forms.TextBox inputSearchNeighborhood;
		private System.Windows.Forms.Button buttonAddNeighborhood;
		private System.Windows.Forms.Button buttonEditNeighborhood;
		private System.Windows.Forms.Button buttonViewNeighborhood;
		private System.Windows.Forms.Panel panelSearchProperty;
		private System.Windows.Forms.TextBox inputSearchProperty;
		private System.Windows.Forms.Button buttonAddProperty;
		private System.Windows.Forms.Button buttonEditProperty;
		private System.Windows.Forms.Button buttonViewProperty;
	}
}