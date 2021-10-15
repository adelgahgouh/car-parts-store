namespace store
{
    partial class products
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
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label quntityLabel;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(products));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnprint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnsave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btndelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnedit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quntityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientdata = new store.clientdata();
            this.tsearchpro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.quntityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productsTableAdapter = new store.clientdataTableAdapters.productsTableAdapter();
            this.tableAdapterManager = new store.clientdataTableAdapters.TableAdapterManager();
            this.printDpro = new System.Windows.Forms.PrintDialog();
            this.printpro = new System.Drawing.Printing.PrintDocument();
            nameLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            quntityLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdata)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.BackColor = System.Drawing.Color.Transparent;
            nameLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.Color.White;
            nameLabel.Location = new System.Drawing.Point(98, 112);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(53, 18);
            nameLabel.TabIndex = 16;
            nameLabel.Text = "Nom:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.BackColor = System.Drawing.Color.Transparent;
            priceLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            priceLabel.ForeColor = System.Drawing.Color.White;
            priceLabel.Location = new System.Drawing.Point(98, 153);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(49, 18);
            priceLabel.TabIndex = 18;
            priceLabel.Text = "Prix:";
            // 
            // quntityLabel
            // 
            quntityLabel.AutoSize = true;
            quntityLabel.BackColor = System.Drawing.Color.Transparent;
            quntityLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quntityLabel.ForeColor = System.Drawing.Color.White;
            quntityLabel.Location = new System.Drawing.Point(98, 196);
            quntityLabel.Name = "quntityLabel";
            quntityLabel.Size = new System.Drawing.Size(88, 18);
            quntityLabel.TabIndex = 20;
            quntityLabel.Text = "Quantite:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(417, 109);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 18);
            label3.TabIndex = 23;
            label3.Text = "Recherche :";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnprint);
            this.bunifuGradientPanel1.Controls.Add(this.btnsave);
            this.bunifuGradientPanel1.Controls.Add(this.btncancel);
            this.bunifuGradientPanel1.Controls.Add(this.btndelete);
            this.bunifuGradientPanel1.Controls.Add(this.btnedit);
            this.bunifuGradientPanel1.Controls.Add(this.btnnew);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.bunifuGradientPanel1.Controls.Add(this.tsearchpro);
            this.bunifuGradientPanel1.Controls.Add(label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(nameLabel);
            this.bunifuGradientPanel1.Controls.Add(this.nameTextBox);
            this.bunifuGradientPanel1.Controls.Add(priceLabel);
            this.bunifuGradientPanel1.Controls.Add(this.priceTextBox);
            this.bunifuGradientPanel1.Controls.Add(quntityLabel);
            this.bunifuGradientPanel1.Controls.Add(this.quntityTextBox);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(41)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(41)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(885, 611);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnprint
            // 
            this.btnprint.Activecolor = System.Drawing.Color.Maroon;
            this.btnprint.BackColor = System.Drawing.Color.Maroon;
            this.btnprint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnprint.BorderRadius = 5;
            this.btnprint.ButtonText = "IMPRIMER";
            this.btnprint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnprint.DisabledColor = System.Drawing.Color.Gray;
            this.btnprint.Iconcolor = System.Drawing.Color.Transparent;
            this.btnprint.Iconimage = null;
            this.btnprint.Iconimage_right = null;
            this.btnprint.Iconimage_right_Selected = null;
            this.btnprint.Iconimage_Selected = null;
            this.btnprint.IconMarginLeft = 0;
            this.btnprint.IconMarginRight = 0;
            this.btnprint.IconRightVisible = true;
            this.btnprint.IconRightZoom = 0D;
            this.btnprint.IconVisible = true;
            this.btnprint.IconZoom = 90D;
            this.btnprint.IsTab = false;
            this.btnprint.Location = new System.Drawing.Point(633, 523);
            this.btnprint.Name = "btnprint";
            this.btnprint.Normalcolor = System.Drawing.Color.Maroon;
            this.btnprint.OnHovercolor = System.Drawing.Color.White;
            this.btnprint.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnprint.selected = false;
            this.btnprint.Size = new System.Drawing.Size(108, 48);
            this.btnprint.TabIndex = 31;
            this.btnprint.Text = "IMPRIMER";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnprint.Textcolor = System.Drawing.Color.White;
            this.btnprint.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnsave
            // 
            this.btnsave.Activecolor = System.Drawing.Color.Maroon;
            this.btnsave.BackColor = System.Drawing.Color.Maroon;
            this.btnsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsave.BorderRadius = 5;
            this.btnsave.ButtonText = "ENREGISTRER";
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.DisabledColor = System.Drawing.Color.Gray;
            this.btnsave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnsave.Iconimage = null;
            this.btnsave.Iconimage_right = null;
            this.btnsave.Iconimage_right_Selected = null;
            this.btnsave.Iconimage_Selected = null;
            this.btnsave.IconMarginLeft = 0;
            this.btnsave.IconMarginRight = 0;
            this.btnsave.IconRightVisible = true;
            this.btnsave.IconRightZoom = 0D;
            this.btnsave.IconVisible = true;
            this.btnsave.IconZoom = 90D;
            this.btnsave.IsTab = false;
            this.btnsave.Location = new System.Drawing.Point(487, 523);
            this.btnsave.Name = "btnsave";
            this.btnsave.Normalcolor = System.Drawing.Color.Maroon;
            this.btnsave.OnHovercolor = System.Drawing.Color.White;
            this.btnsave.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnsave.selected = false;
            this.btnsave.Size = new System.Drawing.Size(140, 48);
            this.btnsave.TabIndex = 30;
            this.btnsave.Text = "ENREGISTRER";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnsave.Textcolor = System.Drawing.Color.White;
            this.btnsave.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btncancel
            // 
            this.btncancel.Activecolor = System.Drawing.Color.Maroon;
            this.btncancel.BackColor = System.Drawing.Color.Maroon;
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancel.BorderRadius = 5;
            this.btncancel.ButtonText = "ANNULER";
            this.btncancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncancel.DisabledColor = System.Drawing.Color.Gray;
            this.btncancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btncancel.Iconimage = null;
            this.btncancel.Iconimage_right = null;
            this.btncancel.Iconimage_right_Selected = null;
            this.btncancel.Iconimage_Selected = null;
            this.btncancel.IconMarginLeft = 0;
            this.btncancel.IconMarginRight = 0;
            this.btncancel.IconRightVisible = true;
            this.btncancel.IconRightZoom = 0D;
            this.btncancel.IconVisible = true;
            this.btncancel.IconZoom = 90D;
            this.btncancel.IsTab = false;
            this.btncancel.Location = new System.Drawing.Point(374, 523);
            this.btncancel.Name = "btncancel";
            this.btncancel.Normalcolor = System.Drawing.Color.Maroon;
            this.btncancel.OnHovercolor = System.Drawing.Color.White;
            this.btncancel.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btncancel.selected = false;
            this.btncancel.Size = new System.Drawing.Size(107, 48);
            this.btncancel.TabIndex = 29;
            this.btncancel.Text = "ANNULER";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btncancel.Textcolor = System.Drawing.Color.White;
            this.btncancel.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btndelete
            // 
            this.btndelete.Activecolor = System.Drawing.Color.Maroon;
            this.btndelete.BackColor = System.Drawing.Color.Maroon;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndelete.BorderRadius = 5;
            this.btndelete.ButtonText = "SUPPRIMER";
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.DisabledColor = System.Drawing.Color.Gray;
            this.btndelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btndelete.Iconimage = null;
            this.btndelete.Iconimage_right = null;
            this.btndelete.Iconimage_right_Selected = null;
            this.btndelete.Iconimage_Selected = null;
            this.btndelete.IconMarginLeft = 0;
            this.btndelete.IconMarginRight = 0;
            this.btndelete.IconRightVisible = true;
            this.btndelete.IconRightZoom = 0D;
            this.btndelete.IconVisible = true;
            this.btndelete.IconZoom = 90D;
            this.btndelete.IsTab = false;
            this.btndelete.Location = new System.Drawing.Point(245, 523);
            this.btndelete.Name = "btndelete";
            this.btndelete.Normalcolor = System.Drawing.Color.Maroon;
            this.btndelete.OnHovercolor = System.Drawing.Color.White;
            this.btndelete.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btndelete.selected = false;
            this.btndelete.Size = new System.Drawing.Size(123, 48);
            this.btndelete.TabIndex = 28;
            this.btndelete.Text = "SUPPRIMER";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Textcolor = System.Drawing.Color.White;
            this.btndelete.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnedit
            // 
            this.btnedit.Activecolor = System.Drawing.Color.Maroon;
            this.btnedit.BackColor = System.Drawing.Color.Maroon;
            this.btnedit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnedit.BorderRadius = 5;
            this.btnedit.ButtonText = "MODIFIER";
            this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnedit.DisabledColor = System.Drawing.Color.Gray;
            this.btnedit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnedit.Iconimage = null;
            this.btnedit.Iconimage_right = null;
            this.btnedit.Iconimage_right_Selected = null;
            this.btnedit.Iconimage_Selected = null;
            this.btnedit.IconMarginLeft = 0;
            this.btnedit.IconMarginRight = 0;
            this.btnedit.IconRightVisible = true;
            this.btnedit.IconRightZoom = 0D;
            this.btnedit.IconVisible = true;
            this.btnedit.IconZoom = 90D;
            this.btnedit.IsTab = false;
            this.btnedit.Location = new System.Drawing.Point(135, 523);
            this.btnedit.Name = "btnedit";
            this.btnedit.Normalcolor = System.Drawing.Color.Maroon;
            this.btnedit.OnHovercolor = System.Drawing.Color.White;
            this.btnedit.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnedit.selected = false;
            this.btnedit.Size = new System.Drawing.Size(104, 48);
            this.btnedit.TabIndex = 27;
            this.btnedit.Text = "MODIFIER";
            this.btnedit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnedit.Textcolor = System.Drawing.Color.White;
            this.btnedit.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnnew
            // 
            this.btnnew.Activecolor = System.Drawing.Color.Maroon;
            this.btnnew.BackColor = System.Drawing.Color.Maroon;
            this.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnew.BorderRadius = 5;
            this.btnnew.ButtonText = "AJOUTER";
            this.btnnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnew.DisabledColor = System.Drawing.Color.Gray;
            this.btnnew.Iconcolor = System.Drawing.Color.Transparent;
            this.btnnew.Iconimage = null;
            this.btnnew.Iconimage_right = null;
            this.btnnew.Iconimage_right_Selected = null;
            this.btnnew.Iconimage_Selected = null;
            this.btnnew.IconMarginLeft = 0;
            this.btnnew.IconMarginRight = 0;
            this.btnnew.IconRightVisible = true;
            this.btnnew.IconRightZoom = 0D;
            this.btnnew.IconVisible = true;
            this.btnnew.IconZoom = 90D;
            this.btnnew.IsTab = false;
            this.btnnew.Location = new System.Drawing.Point(35, 523);
            this.btnnew.Name = "btnnew";
            this.btnnew.Normalcolor = System.Drawing.Color.Maroon;
            this.btnnew.OnHovercolor = System.Drawing.Color.White;
            this.btnnew.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnnew.selected = false;
            this.btnnew.Size = new System.Drawing.Size(94, 48);
            this.btnnew.TabIndex = 26;
            this.btnnew.Text = "AJOUTER";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnew.Textcolor = System.Drawing.Color.White;
            this.btnnew.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.AutoGenerateColumns = false;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Brown;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quntityDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.productsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Brown;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(35, 302);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(706, 215);
            this.bunifuCustomDataGrid1.TabIndex = 25;
            this.bunifuCustomDataGrid1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bunifuCustomDataGrid1_KeyPress);
            // 
            // idproductDataGridViewTextBoxColumn
            // 
            this.idproductDataGridViewTextBoxColumn.DataPropertyName = "idproduct";
            this.idproductDataGridViewTextBoxColumn.HeaderText = "IDPRODUIT";
            this.idproductDataGridViewTextBoxColumn.Name = "idproductDataGridViewTextBoxColumn";
            this.idproductDataGridViewTextBoxColumn.ReadOnly = true;
            this.idproductDataGridViewTextBoxColumn.Width = 110;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "NOM";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "PRIX";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 120;
            // 
            // quntityDataGridViewTextBoxColumn
            // 
            this.quntityDataGridViewTextBoxColumn.DataPropertyName = "quntity";
            this.quntityDataGridViewTextBoxColumn.HeaderText = "QUANTITE";
            this.quntityDataGridViewTextBoxColumn.Name = "quntityDataGridViewTextBoxColumn";
            this.quntityDataGridViewTextBoxColumn.ReadOnly = true;
            this.quntityDataGridViewTextBoxColumn.Width = 120;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.clientdata;
            // 
            // clientdata
            // 
            this.clientdata.DataSetName = "clientdata";
            this.clientdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsearchpro
            // 
            this.tsearchpro.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsearchpro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.tsearchpro.Location = new System.Drawing.Point(420, 135);
            this.tsearchpro.Name = "tsearchpro";
            this.tsearchpro.Size = new System.Drawing.Size(219, 25);
            this.tsearchpro.TabIndex = 24;
            this.tsearchpro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsearchpro_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "LIST:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "name", true));
            this.nameTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.nameTextBox.Location = new System.Drawing.Point(209, 109);
            this.nameTextBox.MaxLength = 50;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 26);
            this.nameTextBox.TabIndex = 17;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "price", true));
            this.priceTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.priceTextBox.Location = new System.Drawing.Point(209, 150);
            this.priceTextBox.MaxLength = 50;
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(150, 26);
            this.priceTextBox.TabIndex = 19;
            // 
            // quntityTextBox
            // 
            this.quntityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productsBindingSource, "quntity", true));
            this.quntityTextBox.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quntityTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.quntityTextBox.Location = new System.Drawing.Point(209, 193);
            this.quntityTextBox.MaxLength = 50;
            this.quntityTextBox.Name = "quntityTextBox";
            this.quntityTextBox.Size = new System.Drawing.Size(150, 26);
            this.quntityTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUITS";
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.billclientTableAdapter = null;
            this.tableAdapterManager.billproviderTableAdapter = null;
            this.tableAdapterManager.caisserTableAdapter = null;
            this.tableAdapterManager.clientsTableAdapter = null;
            this.tableAdapterManager.emloyesTableAdapter = null;
            this.tableAdapterManager.historyTableAdapter = null;
            this.tableAdapterManager.listbuyclientTableAdapter = null;
            this.tableAdapterManager.listsellproviderTableAdapter = null;
            this.tableAdapterManager.productsTableAdapter = this.productsTableAdapter;
            this.tableAdapterManager.providersTableAdapter = null;
            this.tableAdapterManager.settingsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = store.clientdataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // printDpro
            // 
            this.printDpro.UseEXDialog = true;
            // 
            // printpro
            // 
            this.printpro.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printpro_PrintPage);
            // 
            // products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 611);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "products";
            this.Text = "products";
            this.Load += new System.EventHandler(this.products_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox quntityTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tsearchpro;
        private Bunifu.Framework.UI.BunifuFlatButton btnnew;
        private Bunifu.Framework.UI.BunifuFlatButton btnsave;
        private Bunifu.Framework.UI.BunifuFlatButton btncancel;
        private Bunifu.Framework.UI.BunifuFlatButton btndelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnedit;
        private Bunifu.Framework.UI.BunifuFlatButton btnprint;
        private clientdata clientdata;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private clientdataTableAdapters.productsTableAdapter productsTableAdapter;
        private clientdataTableAdapters.TableAdapterManager tableAdapterManager;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private System.Windows.Forms.PrintDialog printDpro;
        private System.Drawing.Printing.PrintDocument printpro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quntityDataGridViewTextBoxColumn;
    }
}