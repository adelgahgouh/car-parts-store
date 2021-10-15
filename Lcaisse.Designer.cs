namespace store
{
    partial class Lcaisse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lcaisse));
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnnew = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnexit = new Bunifu.Framework.UI.BunifuImageButton();
            this.tpass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tnamec = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnnew);
            this.bunifuGradientPanel1.Controls.Add(this.btnexit);
            this.bunifuGradientPanel1.Controls.Add(this.tpass);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.tnamec);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(41)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(33)))), ((int)(((byte)(58)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(41)))), ((int)(((byte)(30)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(500, 200);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnnew
            // 
            this.btnnew.Activecolor = System.Drawing.Color.Maroon;
            this.btnnew.BackColor = System.Drawing.Color.Maroon;
            this.btnnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnew.BorderRadius = 5;
            this.btnnew.ButtonText = "ENTRER";
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
            this.btnnew.Location = new System.Drawing.Point(169, 129);
            this.btnnew.Name = "btnnew";
            this.btnnew.Normalcolor = System.Drawing.Color.Maroon;
            this.btnnew.OnHovercolor = System.Drawing.Color.White;
            this.btnnew.OnHoverTextColor = System.Drawing.Color.Maroon;
            this.btnnew.selected = false;
            this.btnnew.Size = new System.Drawing.Size(162, 48);
            this.btnnew.TabIndex = 44;
            this.btnnew.Text = "ENTRER";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnnew.Textcolor = System.Drawing.Color.White;
            this.btnnew.TextFont = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.ImageActive = null;
            this.btnexit.Location = new System.Drawing.Point(467, 8);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(30, 30);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexit.TabIndex = 43;
            this.btnexit.TabStop = false;
            this.btnexit.Zoom = 10;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // tpass
            // 
            this.tpass.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(39)))), ((int)(((byte)(17)))));
            this.tpass.Location = new System.Drawing.Point(137, 82);
            this.tpass.Name = "tpass";
            this.tpass.Size = new System.Drawing.Size(218, 31);
            this.tpass.TabIndex = 12;
            this.tpass.UseSystemPasswordChar = true;
            this.tpass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tpass_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(116, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(538, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "All RIGHT RESERVED TO DJELFA CODE © 2018";
            // 
            // tnamec
            // 
            this.tnamec.AutoSize = true;
            this.tnamec.BackColor = System.Drawing.Color.Transparent;
            this.tnamec.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnamec.ForeColor = System.Drawing.Color.White;
            this.tnamec.Location = new System.Drawing.Point(125, 427);
            this.tnamec.Name = "tnamec";
            this.tnamec.Size = new System.Drawing.Size(309, 25);
            this.tnamec.TabIndex = 9;
            this.tnamec.Text = "REGISTRED FOR CLIENT:  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "PARAMETRES SUR CAISSE";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Lcaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lcaisse";
            this.Text = "Lcaisse";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tnamec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tpass;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton btnexit;
        private Bunifu.Framework.UI.BunifuFlatButton btnnew;
    }
}