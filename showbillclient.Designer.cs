namespace store
{
    partial class showbillclient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showbillclient));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.datebill = new System.Windows.Forms.Label();
            this.billnbr = new System.Windows.Forms.Label();
            this.btnexit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnprint = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tablelist = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.totalprice = new System.Windows.Forms.Label();
            this.clientname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.printshbc = new System.Drawing.Printing.PrintDocument();
            this.printDshbc = new System.Windows.Forms.PrintDialog();
            this.nameproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelist)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.datebill);
            this.bunifuGradientPanel1.Controls.Add(this.billnbr);
            this.bunifuGradientPanel1.Controls.Add(this.btnexit);
            this.bunifuGradientPanel1.Controls.Add(this.btnprint);
            this.bunifuGradientPanel1.Controls.Add(this.tablelist);
            this.bunifuGradientPanel1.Controls.Add(this.totalprice);
            this.bunifuGradientPanel1.Controls.Add(this.clientname);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(41)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(41)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 500);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // datebill
            // 
            this.datebill.AutoSize = true;
            this.datebill.BackColor = System.Drawing.Color.Transparent;
            this.datebill.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebill.ForeColor = System.Drawing.Color.White;
            this.datebill.Location = new System.Drawing.Point(26, 142);
            this.datebill.Name = "datebill";
            this.datebill.Size = new System.Drawing.Size(147, 18);
            this.datebill.TabIndex = 46;
            this.datebill.Text = "DATE FACTURE:";
            // 
            // billnbr
            // 
            this.billnbr.AutoSize = true;
            this.billnbr.BackColor = System.Drawing.Color.Transparent;
            this.billnbr.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billnbr.ForeColor = System.Drawing.Color.White;
            this.billnbr.Location = new System.Drawing.Point(405, 49);
            this.billnbr.Name = "billnbr";
            this.billnbr.Size = new System.Drawing.Size(113, 18);
            this.billnbr.TabIndex = 45;
            this.billnbr.Text = "FACTURE N:";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageActive = null;
            this.btnexit.Location = new System.Drawing.Point(758, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(30, 30);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexit.TabIndex = 42;
            this.btnexit.TabStop = false;
            this.btnexit.Zoom = 10;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
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
            this.btnprint.Location = new System.Drawing.Point(338, 443);
            this.btnprint.Name = "btnprint";
            this.btnprint.Normalcolor = System.Drawing.Color.Maroon;
            this.btnprint.OnHovercolor = System.Drawing.Color.White;
            this.btnprint.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnprint.selected = false;
            this.btnprint.Size = new System.Drawing.Size(139, 45);
            this.btnprint.TabIndex = 38;
            this.btnprint.Text = "IMPRIMER";
            this.btnprint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnprint.Textcolor = System.Drawing.Color.White;
            this.btnprint.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // tablelist
            // 
            this.tablelist.AllowUserToAddRows = false;
            this.tablelist.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Brown;
            this.tablelist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablelist.BackgroundColor = System.Drawing.Color.Brown;
            this.tablelist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablelist.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.tablelist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablelist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablelist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameproduct,
            this.quantity,
            this.price});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablelist.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablelist.DoubleBuffered = true;
            this.tablelist.EnableHeadersVisualStyles = false;
            this.tablelist.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablelist.HeaderBgColor = System.Drawing.Color.Brown;
            this.tablelist.HeaderForeColor = System.Drawing.Color.White;
            this.tablelist.Location = new System.Drawing.Point(29, 166);
            this.tablelist.Name = "tablelist";
            this.tablelist.ReadOnly = true;
            this.tablelist.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablelist.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablelist.Size = new System.Drawing.Size(759, 271);
            this.tablelist.TabIndex = 36;
            // 
            // totalprice
            // 
            this.totalprice.AutoSize = true;
            this.totalprice.BackColor = System.Drawing.Color.Transparent;
            this.totalprice.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalprice.ForeColor = System.Drawing.Color.White;
            this.totalprice.Location = new System.Drawing.Point(405, 100);
            this.totalprice.Name = "totalprice";
            this.totalprice.Size = new System.Drawing.Size(121, 18);
            this.totalprice.TabIndex = 11;
            this.totalprice.Text = "PRIX TOTAL:";
            // 
            // clientname
            // 
            this.clientname.AutoSize = true;
            this.clientname.BackColor = System.Drawing.Color.Transparent;
            this.clientname.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientname.ForeColor = System.Drawing.Color.White;
            this.clientname.Location = new System.Drawing.Point(26, 100);
            this.clientname.Name = "clientname";
            this.clientname.Size = new System.Drawing.Size(129, 18);
            this.clientname.TabIndex = 7;
            this.clientname.Text = "NOM CLIENT :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "VOIR FACTURE CLIENT";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // printshbc
            // 
            this.printshbc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printshbc_PrintPage);
            // 
            // printDshbc
            // 
            this.printDshbc.UseEXDialog = true;
            // 
            // nameproduct
            // 
            this.nameproduct.HeaderText = "NOM DU PRODUCT";
            this.nameproduct.Name = "nameproduct";
            this.nameproduct.ReadOnly = true;
            this.nameproduct.Width = 300;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "QUANTITE";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 200;
            // 
            // price
            // 
            this.price.HeaderText = "PRIX DU UNITE";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 200;
            // 
            // showbillclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "showbillclient";
            this.Text = "showbillclient";
            this.Load += new System.EventHandler(this.showbillclient_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablelist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label billnbr;
        private Bunifu.Framework.UI.BunifuImageButton btnexit;
        private Bunifu.Framework.UI.BunifuFlatButton btnprint;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablelist;
        private System.Windows.Forms.Label totalprice;
        private System.Windows.Forms.Label clientname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datebill;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Drawing.Printing.PrintDocument printshbc;
        private System.Windows.Forms.PrintDialog printDshbc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}