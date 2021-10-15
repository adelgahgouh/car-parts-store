namespace store
{
    partial class clients
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label addresssLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnprintcl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsavecl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancelcl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btndeletecl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btneditcl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnewcl = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clientdatagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idclientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresssDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientdata = new store.clientdata();
            this.label3 = new System.Windows.Forms.Label();
            this.tsearchcl = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addresssTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new store.clientdataTableAdapters.clientsTableAdapter();
            this.tableAdapterManager = new store.clientdataTableAdapters.TableAdapterManager();
            this.printD = new System.Windows.Forms.PrintDialog();
            this.print = new System.Drawing.Printing.PrintDocument();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            addresssLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdata)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(79, 117);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 18);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Nom:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.BackColor = System.Drawing.Color.Transparent;
            phoneLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.ForeColor = System.Drawing.Color.White;
            phoneLabel.Location = new System.Drawing.Point(79, 158);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(48, 18);
            phoneLabel.TabIndex = 6;
            phoneLabel.Text = "TEL:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.ForeColor = System.Drawing.Color.White;
            emailLabel.Location = new System.Drawing.Point(79, 203);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(63, 18);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // addresssLabel
            // 
            addresssLabel.AutoSize = true;
            addresssLabel.BackColor = System.Drawing.Color.Transparent;
            addresssLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addresssLabel.ForeColor = System.Drawing.Color.White;
            addresssLabel.Location = new System.Drawing.Point(79, 245);
            addresssLabel.Name = "addresssLabel";
            addresssLabel.Size = new System.Drawing.Size(81, 18);
            addresssLabel.TabIndex = 10;
            addresssLabel.Text = "Address:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(431, 117);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 18);
            label2.TabIndex = 12;
            label2.Text = "Recherche:";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnprintcl);
            this.bunifuGradientPanel1.Controls.Add(this.btnsavecl);
            this.bunifuGradientPanel1.Controls.Add(this.btncancelcl);
            this.bunifuGradientPanel1.Controls.Add(this.btndeletecl);
            this.bunifuGradientPanel1.Controls.Add(this.btneditcl);
            this.bunifuGradientPanel1.Controls.Add(this.btnnewcl);
            this.bunifuGradientPanel1.Controls.Add(this.clientdatagrid);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.tsearchcl);
            this.bunifuGradientPanel1.Controls.Add(label2);
            this.bunifuGradientPanel1.Controls.Add(nameLabel);
            this.bunifuGradientPanel1.Controls.Add(this.nameTextBox);
            this.bunifuGradientPanel1.Controls.Add(phoneLabel);
            this.bunifuGradientPanel1.Controls.Add(this.phoneTextBox);
            this.bunifuGradientPanel1.Controls.Add(emailLabel);
            this.bunifuGradientPanel1.Controls.Add(this.emailTextBox);
            this.bunifuGradientPanel1.Controls.Add(addresssLabel);
            this.bunifuGradientPanel1.Controls.Add(this.addresssTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuGradientPanel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(41)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(41)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(756, 611);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnprintcl
            // 
            this.btnprintcl.Activecolor = System.Drawing.Color.Maroon;
            this.btnprintcl.BackColor = System.Drawing.Color.Maroon;
            this.btnprintcl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprintcl.BorderRadius = 5;
            this.btnprintcl.ButtonText = "IMPRIMER";
            this.btnprintcl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprintcl.DisabledColor = System.Drawing.Color.Gray;
            this.btnprintcl.Iconcolor = System.Drawing.Color.Transparent;
            this.btnprintcl.Iconimage = null;
            this.btnprintcl.Iconimage_right = null;
            this.btnprintcl.Iconimage_right_Selected = null;
            this.btnprintcl.Iconimage_Selected = null;
            this.btnprintcl.IconMarginLeft = 0;
            this.btnprintcl.IconMarginRight = 0;
            this.btnprintcl.IconRightVisible = true;
            this.btnprintcl.IconRightZoom = 0D;
            this.btnprintcl.IconVisible = true;
            this.btnprintcl.IconZoom = 90D;
            this.btnprintcl.IsTab = false;
            this.btnprintcl.Location = new System.Drawing.Point(637, 543);
            this.btnprintcl.Margin = new System.Windows.Forms.Padding(4);
            this.btnprintcl.Name = "btnprintcl";
            this.btnprintcl.Normalcolor = System.Drawing.Color.Maroon;
            this.btnprintcl.OnHovercolor = System.Drawing.Color.White;
            this.btnprintcl.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnprintcl.selected = false;
            this.btnprintcl.Size = new System.Drawing.Size(106, 48);
            this.btnprintcl.TabIndex = 39;
            this.btnprintcl.Text = "IMPRIMER";
            this.btnprintcl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnprintcl.Textcolor = System.Drawing.Color.White;
            this.btnprintcl.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintcl.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnsavecl
            // 
            this.btnsavecl.Activecolor = System.Drawing.Color.Maroon;
            this.btnsavecl.BackColor = System.Drawing.Color.Maroon;
            this.btnsavecl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsavecl.BorderRadius = 5;
            this.btnsavecl.ButtonText = "ENREGISTRER";
            this.btnsavecl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsavecl.DisabledColor = System.Drawing.Color.Gray;
            this.btnsavecl.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsavecl.Iconimage = null;
            this.btnsavecl.Iconimage_right = null;
            this.btnsavecl.Iconimage_right_Selected = null;
            this.btnsavecl.Iconimage_Selected = null;
            this.btnsavecl.IconMarginLeft = 0;
            this.btnsavecl.IconMarginRight = 0;
            this.btnsavecl.IconRightVisible = true;
            this.btnsavecl.IconRightZoom = 0D;
            this.btnsavecl.IconVisible = true;
            this.btnsavecl.IconZoom = 90D;
            this.btnsavecl.IsTab = false;
            this.btnsavecl.Location = new System.Drawing.Point(492, 543);
            this.btnsavecl.Margin = new System.Windows.Forms.Padding(4);
            this.btnsavecl.Name = "btnsavecl";
            this.btnsavecl.Normalcolor = System.Drawing.Color.Maroon;
            this.btnsavecl.OnHovercolor = System.Drawing.Color.White;
            this.btnsavecl.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnsavecl.selected = false;
            this.btnsavecl.Size = new System.Drawing.Size(137, 48);
            this.btnsavecl.TabIndex = 38;
            this.btnsavecl.Text = "ENREGISTRER";
            this.btnsavecl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsavecl.Textcolor = System.Drawing.Color.White;
            this.btnsavecl.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavecl.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancelcl
            // 
            this.btncancelcl.Activecolor = System.Drawing.Color.Maroon;
            this.btncancelcl.BackColor = System.Drawing.Color.Maroon;
            this.btncancelcl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelcl.BorderRadius = 5;
            this.btncancelcl.ButtonText = "ANNULER";
            this.btncancelcl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancelcl.DisabledColor = System.Drawing.Color.Gray;
            this.btncancelcl.Iconcolor = System.Drawing.Color.Transparent;
            this.btncancelcl.Iconimage = null;
            this.btncancelcl.Iconimage_right = null;
            this.btncancelcl.Iconimage_right_Selected = null;
            this.btncancelcl.Iconimage_Selected = null;
            this.btncancelcl.IconMarginLeft = 0;
            this.btncancelcl.IconMarginRight = 0;
            this.btncancelcl.IconRightVisible = true;
            this.btncancelcl.IconRightZoom = 0D;
            this.btncancelcl.IconVisible = true;
            this.btncancelcl.IconZoom = 90D;
            this.btncancelcl.IsTab = false;
            this.btncancelcl.Location = new System.Drawing.Point(376, 543);
            this.btncancelcl.Margin = new System.Windows.Forms.Padding(4);
            this.btncancelcl.Name = "btncancelcl";
            this.btncancelcl.Normalcolor = System.Drawing.Color.Maroon;
            this.btncancelcl.OnHovercolor = System.Drawing.Color.White;
            this.btncancelcl.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btncancelcl.selected = false;
            this.btncancelcl.Size = new System.Drawing.Size(108, 48);
            this.btncancelcl.TabIndex = 37;
            this.btncancelcl.Text = "ANNULER";
            this.btncancelcl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancelcl.Textcolor = System.Drawing.Color.White;
            this.btncancelcl.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelcl.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndeletecl
            // 
            this.btndeletecl.Activecolor = System.Drawing.Color.Maroon;
            this.btndeletecl.BackColor = System.Drawing.Color.Maroon;
            this.btndeletecl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndeletecl.BorderRadius = 5;
            this.btndeletecl.ButtonText = "SUPPRIMER";
            this.btndeletecl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeletecl.DisabledColor = System.Drawing.Color.Gray;
            this.btndeletecl.Iconcolor = System.Drawing.Color.Transparent;
            this.btndeletecl.Iconimage = null;
            this.btndeletecl.Iconimage_right = null;
            this.btndeletecl.Iconimage_right_Selected = null;
            this.btndeletecl.Iconimage_Selected = null;
            this.btndeletecl.IconMarginLeft = 0;
            this.btndeletecl.IconMarginRight = 0;
            this.btndeletecl.IconRightVisible = true;
            this.btndeletecl.IconRightZoom = 0D;
            this.btndeletecl.IconVisible = true;
            this.btndeletecl.IconZoom = 90D;
            this.btndeletecl.IsTab = false;
            this.btndeletecl.Location = new System.Drawing.Point(248, 543);
            this.btndeletecl.Margin = new System.Windows.Forms.Padding(4);
            this.btndeletecl.Name = "btndeletecl";
            this.btndeletecl.Normalcolor = System.Drawing.Color.Maroon;
            this.btndeletecl.OnHovercolor = System.Drawing.Color.White;
            this.btndeletecl.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btndeletecl.selected = false;
            this.btndeletecl.Size = new System.Drawing.Size(120, 48);
            this.btndeletecl.TabIndex = 36;
            this.btndeletecl.Text = "SUPPRIMER";
            this.btndeletecl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndeletecl.Textcolor = System.Drawing.Color.White;
            this.btndeletecl.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletecl.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btneditcl
            // 
            this.btneditcl.Activecolor = System.Drawing.Color.Maroon;
            this.btneditcl.BackColor = System.Drawing.Color.Maroon;
            this.btneditcl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditcl.BorderRadius = 5;
            this.btneditcl.ButtonText = "MODIFIER";
            this.btneditcl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btneditcl.DisabledColor = System.Drawing.Color.Gray;
            this.btneditcl.Iconcolor = System.Drawing.Color.Transparent;
            this.btneditcl.Iconimage = null;
            this.btneditcl.Iconimage_right = null;
            this.btneditcl.Iconimage_right_Selected = null;
            this.btneditcl.Iconimage_Selected = null;
            this.btneditcl.IconMarginLeft = 0;
            this.btneditcl.IconMarginRight = 0;
            this.btneditcl.IconRightVisible = true;
            this.btneditcl.IconRightZoom = 0D;
            this.btneditcl.IconVisible = true;
            this.btneditcl.IconZoom = 90D;
            this.btneditcl.IsTab = false;
            this.btneditcl.Location = new System.Drawing.Point(135, 543);
            this.btneditcl.Margin = new System.Windows.Forms.Padding(4);
            this.btneditcl.Name = "btneditcl";
            this.btneditcl.Normalcolor = System.Drawing.Color.Maroon;
            this.btneditcl.OnHovercolor = System.Drawing.Color.White;
            this.btneditcl.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btneditcl.selected = false;
            this.btneditcl.Size = new System.Drawing.Size(105, 48);
            this.btneditcl.TabIndex = 35;
            this.btneditcl.Text = "MODIFIER";
            this.btneditcl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btneditcl.Textcolor = System.Drawing.Color.White;
            this.btneditcl.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditcl.Click += new System.EventHandler(this.btnedit_Click_1);
            // 
            // btnnewcl
            // 
            this.btnnewcl.Activecolor = System.Drawing.Color.Maroon;
            this.btnnewcl.BackColor = System.Drawing.Color.Maroon;
            this.btnnewcl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnewcl.BorderRadius = 5;
            this.btnnewcl.ButtonText = "AJOUTER";
            this.btnnewcl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnewcl.DisabledColor = System.Drawing.Color.Gray;
            this.btnnewcl.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnewcl.Iconimage = null;
            this.btnnewcl.Iconimage_right = null;
            this.btnnewcl.Iconimage_right_Selected = null;
            this.btnnewcl.Iconimage_Selected = null;
            this.btnnewcl.IconMarginLeft = 0;
            this.btnnewcl.IconMarginRight = 0;
            this.btnnewcl.IconRightVisible = true;
            this.btnnewcl.IconRightZoom = 0D;
            this.btnnewcl.IconVisible = true;
            this.btnnewcl.IconZoom = 90D;
            this.btnnewcl.IsTab = false;
            this.btnnewcl.Location = new System.Drawing.Point(18, 543);
            this.btnnewcl.Margin = new System.Windows.Forms.Padding(4);
            this.btnnewcl.Name = "btnnewcl";
            this.btnnewcl.Normalcolor = System.Drawing.Color.Maroon;
            this.btnnewcl.OnHovercolor = System.Drawing.Color.White;
            this.btnnewcl.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnnewcl.selected = false;
            this.btnnewcl.Size = new System.Drawing.Size(109, 48);
            this.btnnewcl.TabIndex = 34;
            this.btnnewcl.Text = "AJOUTER";
            this.btnnewcl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnewcl.Textcolor = System.Drawing.Color.White;
            this.btnnewcl.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewcl.Click += new System.EventHandler(this.btnnew_Click_1);
            // 
            // clientdatagrid
            // 
            this.clientdatagrid.AllowUserToAddRows = false;
            this.clientdatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            this.clientdatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.clientdatagrid.AutoGenerateColumns = false;
            this.clientdatagrid.BackgroundColor = System.Drawing.Color.Brown;
            this.clientdatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientdatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.clientdatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.clientdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclientDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addresssDataGridViewTextBoxColumn});
            this.clientdatagrid.DataSource = this.clientsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clientdatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.clientdatagrid.DoubleBuffered = true;
            this.clientdatagrid.EnableHeadersVisualStyles = false;
            this.clientdatagrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clientdatagrid.HeaderBgColor = System.Drawing.Color.Brown;
            this.clientdatagrid.HeaderForeColor = System.Drawing.Color.White;
            this.clientdatagrid.Location = new System.Drawing.Point(22, 321);
            this.clientdatagrid.Name = "clientdatagrid";
            this.clientdatagrid.ReadOnly = true;
            this.clientdatagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clientdatagrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.clientdatagrid.Size = new System.Drawing.Size(721, 215);
            this.clientdatagrid.TabIndex = 33;
            // 
            // idclientDataGridViewTextBoxColumn
            // 
            this.idclientDataGridViewTextBoxColumn.DataPropertyName = "idclient";
            this.idclientDataGridViewTextBoxColumn.HeaderText = "IDCLIENT";
            this.idclientDataGridViewTextBoxColumn.Name = "idclientDataGridViewTextBoxColumn";
            this.idclientDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclientDataGridViewTextBoxColumn.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "TEL";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "EMAIL";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addresssDataGridViewTextBoxColumn
            // 
            this.addresssDataGridViewTextBoxColumn.DataPropertyName = "addresss";
            this.addresssDataGridViewTextBoxColumn.HeaderText = "ADDRESS";
            this.addresssDataGridViewTextBoxColumn.Name = "addresssDataGridViewTextBoxColumn";
            this.addresssDataGridViewTextBoxColumn.ReadOnly = true;
            this.addresssDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "clients";
            this.clientsBindingSource.DataSource = this.clientdata;
            // 
            // clientdata
            // 
            this.clientdata.DataSetName = "clientdata";
            this.clientdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "LIST:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tsearchcl
            // 
            this.tsearchcl.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsearchcl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.tsearchcl.Location = new System.Drawing.Point(434, 143);
            this.tsearchcl.Name = "tsearchcl";
            this.tsearchcl.Size = new System.Drawing.Size(219, 25);
            this.tsearchcl.TabIndex = 13;
            this.tsearchcl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsearchcl_KeyDown);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.nameTextBox.Location = new System.Drawing.Point(177, 117);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(159, 25);
            this.nameTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "phone", true));
            this.phoneTextBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.phoneTextBox.Location = new System.Drawing.Point(177, 158);
            this.phoneTextBox.MaxLength = 50;
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(159, 25);
            this.phoneTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.emailTextBox.Location = new System.Drawing.Point(177, 203);
            this.emailTextBox.MaxLength = 50;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(159, 25);
            this.emailTextBox.TabIndex = 9;
            // 
            // addresssTextBox
            // 
            this.addresssTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "addresss", true));
            this.addresssTextBox.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresssTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.addresssTextBox.Location = new System.Drawing.Point(177, 245);
            this.addresssTextBox.MaxLength = 50;
            this.addresssTextBox.Name = "addresssTextBox";
            this.addresssTextBox.Size = new System.Drawing.Size(219, 25);
            this.addresssTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLIENTS";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.billclientTableAdapter = null;
            this.tableAdapterManager.billproviderTableAdapter = null;
            this.tableAdapterManager.caisserTableAdapter = null;
            this.tableAdapterManager.clientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.emloyesTableAdapter = null;
            this.tableAdapterManager.historyTableAdapter = null;
            this.tableAdapterManager.listbuyclientTableAdapter = null;
            this.tableAdapterManager.listsellproviderTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = null;
            this.tableAdapterManager.providersTableAdapter = null;
            this.tableAdapterManager.settingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = store.clientdataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printD
            // 
            this.printD.AllowCurrentPage = true;
            this.printD.AllowSelection = true;
            this.printD.AllowSomePages = true;
            this.printD.Document = this.print;
            this.printD.PrintToFile = true;
            this.printD.UseEXDialog = true;
            // 
            // print
            // 
            this.print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 611);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clients";
            this.Text = "clients";
            this.Load += new System.EventHandler(this.clients_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientdatagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tsearchcl;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addresssTextBox;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid clientdatagrid;
        private clientdata clientdata;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private clientdataTableAdapters.clientsTableAdapter clientsTableAdapter;
        private clientdataTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.Framework.UI.BunifuFlatButton btnnewcl;
        private Bunifu.Framework.UI.BunifuFlatButton btneditcl;
        private Bunifu.Framework.UI.BunifuFlatButton btndeletecl;
        private Bunifu.Framework.UI.BunifuFlatButton btnprintcl;
        private Bunifu.Framework.UI.BunifuFlatButton btnsavecl;
        private Bunifu.Framework.UI.BunifuFlatButton btncancelcl;
        private System.Windows.Forms.PrintDialog printD;
        private System.Drawing.Printing.PrintDocument print;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresssDataGridViewTextBoxColumn;
    }
}