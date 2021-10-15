namespace store
{
    partial class billproviders
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(billproviders));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnprint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnshow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btndelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnnew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnrefresh = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tsearchbc = new System.Windows.Forms.TextBox();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idbillproviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameproviderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billproviderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientdata = new store.clientdata();
            this.label1 = new System.Windows.Forms.Label();
            this.billproviderTableAdapter = new store.clientdataTableAdapters.billproviderTableAdapter();
            this.printDpb1 = new System.Windows.Forms.PrintDialog();
            this.printDbp = new System.Drawing.Printing.PrintDocument();
            label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billproviderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(83, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(101, 18);
            label2.TabIndex = 41;
            label2.Text = "Recherche:";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnprint);
            this.bunifuGradientPanel1.Controls.Add(this.btnshow);
            this.bunifuGradientPanel1.Controls.Add(this.btndelete);
            this.bunifuGradientPanel1.Controls.Add(this.btnnew);
            this.bunifuGradientPanel1.Controls.Add(this.btnrefresh);
            this.bunifuGradientPanel1.Controls.Add(this.tsearchbc);
            this.bunifuGradientPanel1.Controls.Add(label2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomDataGrid1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
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
            this.btnprint.Location = new System.Drawing.Point(608, 511);
            this.btnprint.Name = "btnprint";
            this.btnprint.Normalcolor = System.Drawing.Color.Maroon;
            this.btnprint.OnHovercolor = System.Drawing.Color.White;
            this.btnprint.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnprint.selected = false;
            this.btnprint.Size = new System.Drawing.Size(109, 48);
            this.btnprint.TabIndex = 47;
            this.btnprint.Text = "IMPRIMER";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnprint.Textcolor = System.Drawing.Color.White;
            this.btnprint.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnshow
            // 
            this.btnshow.Activecolor = System.Drawing.Color.Maroon;
            this.btnshow.BackColor = System.Drawing.Color.Maroon;
            this.btnshow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnshow.BorderRadius = 5;
            this.btnshow.ButtonText = "VOIR";
            this.btnshow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnshow.DisabledColor = System.Drawing.Color.Gray;
            this.btnshow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnshow.Iconimage = null;
            this.btnshow.Iconimage_right = null;
            this.btnshow.Iconimage_right_Selected = null;
            this.btnshow.Iconimage_Selected = null;
            this.btnshow.IconMarginLeft = 0;
            this.btnshow.IconMarginRight = 0;
            this.btnshow.IconRightVisible = true;
            this.btnshow.IconRightZoom = 0D;
            this.btnshow.IconVisible = true;
            this.btnshow.IconZoom = 90D;
            this.btnshow.IsTab = false;
            this.btnshow.Location = new System.Drawing.Point(517, 511);
            this.btnshow.Name = "btnshow";
            this.btnshow.Normalcolor = System.Drawing.Color.Maroon;
            this.btnshow.OnHovercolor = System.Drawing.Color.White;
            this.btnshow.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnshow.selected = false;
            this.btnshow.Size = new System.Drawing.Size(85, 48);
            this.btnshow.TabIndex = 46;
            this.btnshow.Text = "VOIR";
            this.btnshow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnshow.Textcolor = System.Drawing.Color.White;
            this.btnshow.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
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
            this.btndelete.Location = new System.Drawing.Point(190, 511);
            this.btndelete.Name = "btndelete";
            this.btndelete.Normalcolor = System.Drawing.Color.Maroon;
            this.btndelete.OnHovercolor = System.Drawing.Color.White;
            this.btndelete.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btndelete.selected = false;
            this.btndelete.Size = new System.Drawing.Size(120, 48);
            this.btndelete.TabIndex = 45;
            this.btndelete.Text = "SUPPRIMER";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btndelete.Textcolor = System.Drawing.Color.White;
            this.btndelete.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
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
            this.btnnew.Location = new System.Drawing.Point(75, 511);
            this.btnnew.Name = "btnnew";
            this.btnnew.Normalcolor = System.Drawing.Color.Maroon;
            this.btnnew.OnHovercolor = System.Drawing.Color.White;
            this.btnnew.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnnew.selected = false;
            this.btnnew.Size = new System.Drawing.Size(109, 48);
            this.btnnew.TabIndex = 44;
            this.btnnew.Text = "AJOUTER";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnew.Textcolor = System.Drawing.Color.White;
            this.btnnew.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Activecolor = System.Drawing.Color.Maroon;
            this.btnrefresh.BackColor = System.Drawing.Color.Maroon;
            this.btnrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnrefresh.BorderRadius = 5;
            this.btnrefresh.ButtonText = "REFRESH";
            this.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefresh.DisabledColor = System.Drawing.Color.Gray;
            this.btnrefresh.Iconcolor = System.Drawing.Color.Transparent;
            this.btnrefresh.Iconimage = null;
            this.btnrefresh.Iconimage_right = null;
            this.btnrefresh.Iconimage_right_Selected = null;
            this.btnrefresh.Iconimage_Selected = null;
            this.btnrefresh.IconMarginLeft = 0;
            this.btnrefresh.IconMarginRight = 0;
            this.btnrefresh.IconRightVisible = true;
            this.btnrefresh.IconRightZoom = 0D;
            this.btnrefresh.IconVisible = true;
            this.btnrefresh.IconZoom = 90D;
            this.btnrefresh.IsTab = false;
            this.btnrefresh.Location = new System.Drawing.Point(561, 68);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Normalcolor = System.Drawing.Color.Maroon;
            this.btnrefresh.OnHovercolor = System.Drawing.Color.White;
            this.btnrefresh.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnrefresh.selected = false;
            this.btnrefresh.Size = new System.Drawing.Size(156, 42);
            this.btnrefresh.TabIndex = 43;
            this.btnrefresh.Text = "REFRESH";
            this.btnrefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnrefresh.Textcolor = System.Drawing.Color.White;
            this.btnrefresh.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // tsearchbc
            // 
            this.tsearchbc.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsearchbc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.tsearchbc.Location = new System.Drawing.Point(190, 79);
            this.tsearchbc.Name = "tsearchbc";
            this.tsearchbc.Size = new System.Drawing.Size(219, 25);
            this.tsearchbc.TabIndex = 42;
            this.tsearchbc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tsearchbc_KeyDown);
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
            this.idbillproviderDataGridViewTextBoxColumn,
            this.nameproviderDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.bunifuCustomDataGrid1.DataSource = this.billproviderBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Brown;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(75, 116);
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
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(642, 389);
            this.bunifuCustomDataGrid1.TabIndex = 40;
            // 
            // idbillproviderDataGridViewTextBoxColumn
            // 
            this.idbillproviderDataGridViewTextBoxColumn.DataPropertyName = "idbillprovider";
            this.idbillproviderDataGridViewTextBoxColumn.HeaderText = "ID FACTURE FOURNISSUER";
            this.idbillproviderDataGridViewTextBoxColumn.Name = "idbillproviderDataGridViewTextBoxColumn";
            this.idbillproviderDataGridViewTextBoxColumn.ReadOnly = true;
            this.idbillproviderDataGridViewTextBoxColumn.Width = 120;
            // 
            // nameproviderDataGridViewTextBoxColumn
            // 
            this.nameproviderDataGridViewTextBoxColumn.DataPropertyName = "nameprovider";
            this.nameproviderDataGridViewTextBoxColumn.HeaderText = "NOM FOURNISSEUR";
            this.nameproviderDataGridViewTextBoxColumn.Name = "nameproviderDataGridViewTextBoxColumn";
            this.nameproviderDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameproviderDataGridViewTextBoxColumn.Width = 250;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "PRIX";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 120;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "DATE";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // billproviderBindingSource
            // 
            this.billproviderBindingSource.DataMember = "billprovider";
            this.billproviderBindingSource.DataSource = this.clientdata;
            // 
            // clientdata
            // 
            this.clientdata.DataSetName = "clientdata";
            this.clientdata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "FACTURE FORNISSEUR";
            // 
            // billproviderTableAdapter
            // 
            this.billproviderTableAdapter.ClearBeforeFill = true;
            // 
            // printDpb1
            // 
            this.printDpb1.UseEXDialog = true;
            // 
            // printDbp
            // 
            this.printDbp.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDbp_PrintPage);
            // 
            // billproviders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 611);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "billproviders";
            this.Text = "billproviders";
            this.Load += new System.EventHandler(this.billproviders_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billproviderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnprint;
        private Bunifu.Framework.UI.BunifuFlatButton btnshow;
        private Bunifu.Framework.UI.BunifuFlatButton btndelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnnew;
        private Bunifu.Framework.UI.BunifuFlatButton btnrefresh;
        private System.Windows.Forms.TextBox tsearchbc;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
        private clientdata clientdata;
        private System.Windows.Forms.BindingSource billproviderBindingSource;
        private clientdataTableAdapters.billproviderTableAdapter billproviderTableAdapter;
        private System.Windows.Forms.PrintDialog printDpb1;
        private System.Drawing.Printing.PrintDocument printDbp;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbillproviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproviderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
    }
}