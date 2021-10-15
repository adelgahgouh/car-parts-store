using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;


namespace store
{
    public partial class billclient : Form
    {
        Form1 f1; addbillclient add;

        public billclient(Form1 fo1)
        {
            InitializeComponent();
            f1 = fo1;
        }

        private void billclient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientdata.billclient' table. You can move, or remove it, as needed.
            this.billclientTableAdapter.Fill(this.clientdata.billclient);
          
        }
      

        private void tsearchbc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!string.IsNullOrEmpty(tsearchbc.Text))
                {
                    billclientBindingSource.Filter = string.Format("date like '*{0}*' OR nameclient like '*{1}*' ", tsearchbc.Text, tsearchbc.Text);
                }
                else
                {
                    billclientBindingSource.Filter = string.Empty;
                }

            }
        }
        
        private void btnnew_Click(object sender, EventArgs e)
        {
            add = new addbillclient(f1, this);


            add.Show();
            f1.Enabled = false;

        }
        public void exitfunction()
        {
            f1.Enabled = true;
            add.Visible = false;
            
           
           // add.Close();
            //add.Hide();
            

        }
        public void refersh() {
            this.billclientTableAdapter.Fill(this.clientdata.billclient);
            billclienttable.Refresh();
        }
        private void btnrefresh_Click(object sender, EventArgs e)
        {
        this.billclientTableAdapter.Fill(this.clientdata.billclient); 
            billclienttable.Refresh();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();

                // or.. just minimize the child forms
                // frm.WindowState = FormWindowState.Minimized;
            }
           //f1.loadbillclient();
        }
       
        private void btnshow_Click(object sender, EventArgs e)
        {
            int rowindex = billclienttable.CurrentRow.Index;
            int billnbr = int.Parse(billclienttable[0, rowindex].Value.ToString());
            string clientname = billclienttable[1, rowindex].Value.ToString();
            string datebill = billclienttable[3, rowindex].Value.ToString();
            string pricebill = billclienttable[2, rowindex].Value.ToString();
            
            showbillclient shbill; 
            shbill = new showbillclient(f1, billnbr, clientname, datebill, pricebill);
            shbill.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (billclienttable.RowCount > 0)
            {
                if (MessageBox.Show("tu as sure pour supprimer ce facture ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);
                         
                             connection.Open();
                     if (MessageBox.Show("voulez-vous diminuer la caisse de ce prix de cette facture ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       

                      
                         
                            int rowindex = billclienttable.CurrentRow.Index;
                            int billnbr = int.Parse(billclienttable[0, rowindex].Value.ToString());
                            using (SqlCeCommand command1 = connection.CreateCommand())
                            {
                                    string sqlproductsell = "select * from listproductsclient where idbill=" + billnbr;
                                    command1.CommandText = sqlproductsell;
                                    SqlCeDataReader myReader = null;
                                    myReader = command1.ExecuteReader();
                                    while (myReader.Read())
                                    {
                                        SqlCeCommand command5 = connection.CreateCommand();
                                        string sqlclient = "update   products set  quntity=quntity +" + int.Parse(myReader["productquntity"].ToString()) + " where name='" + myReader["productname"].ToString() + "'";
                                        command5.CommandText = sqlclient;
                                        command5.ExecuteNonQuery();
                                    }
                            }
                            using (SqlCeCommand command2 = connection.CreateCommand())
                            {
                                string sqlbil = "delete from listproductsclient where idbill=" + billnbr;
                                command2.CommandText = sqlbil;
                                command2.ExecuteNonQuery();
                            }
                            using (SqlCeCommand command3 = connection.CreateCommand())
                            {
                                string sqlbil = "delete from billclient where idbillclient=" + billnbr;
                                command3.CommandText = sqlbil;
                                command3.ExecuteNonQuery();
                            }
                            using (SqlCeCommand command4 = connection.CreateCommand())
                            {
                                string sqlclient = "update   caisser set  money=money -" + float.Parse(billclienttable[2,rowindex].Value.ToString()) + " where idcaisser=1";
                                command4.CommandText = sqlclient;
                                command4.ExecuteNonQuery();
                            }
                            connection.Close();
                            this.billclientTableAdapter.Fill(this.clientdata.billclient);
                            billclienttable.Refresh();
                          
                         }
                    
                    else {
                     
                            int rowindex = billclienttable.CurrentRow.Index;
                            int billnbr = int.Parse(billclienttable[0, rowindex].Value.ToString());
                            connection.Open();
                            using (SqlCeCommand command2 = connection.CreateCommand())
                            {
                                string sqlbil = "delete from listbuyclient where idbillclient=" + billnbr;
                                command2.CommandText = sqlbil;
                                command2.ExecuteNonQuery();
                            }
                            using (SqlCeCommand command1 = connection.CreateCommand())
                            {
                                string sqlbil = "delete from billclient where idbillclient=" + billnbr;
                                command1.CommandText = sqlbil;
                                command1.ExecuteNonQuery();
                            }
                            this.billclientTableAdapter.Fill(this.clientdata.billclient);
                            billclienttable.Refresh();
                        }
                     connection.Close();
                           
                    
                }
            }
        }


        private void btnprint_Click(object sender, EventArgs e)
        {
            if (billclienttable.RowCount > 0)
            {

                PrintDialog printDlg = new PrintDialog();

                printDbc.AllowCurrentPage = true;
                printDbc.AllowSelection = true;
                printDbc.AllowSomePages = true;
                printbc.DocumentName = "Print Document";

                printDlg.Document = printbc;


                if (printDlg.ShowDialog() == DialogResult.OK)
                    printbc.Print();
            }
        }
      

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int rowindex = billclienttable.CurrentRow.Index;
            int billnbr = int.Parse(billclienttable[0, rowindex].Value.ToString());
            string emailstore = null, phonestore = null, companystore = null, addressstore = null, clientname = billclienttable[1, rowindex].Value.ToString(), totalprice = billclienttable[2, rowindex].Value.ToString(), datebill = billclienttable[3, rowindex].Value.ToString();
            //MessageBox.Show(""+billnbr);
           // using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
            using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

            {
                connection.Open();
                using (SqlCeCommand command1 = connection.CreateCommand())
                {
                    string sqlsettings = "select * from settings where id=1";
                    command1.CommandText = sqlsettings;
                    SqlCeDataReader myReader = null;

                    myReader = command1.ExecuteReader();

                    while (myReader.Read())
                    {
                        phonestore = myReader["phone"].ToString();

                        emailstore = myReader["email"].ToString();
                        addressstore = myReader["address"].ToString();
                        companystore = myReader["company"].ToString();
                    }
                }
               
          
            //This part sets up the data to be printed
            Graphics g = e.Graphics;
            SolidBrush Brush = new SolidBrush(Color.Black);

            var bmp = new Bitmap(store.Properties.Resources.logos);
            var bgbmp = new Bitmap(store.Properties.Resources.bg);
            // Image img = bmp;
            /*  string printText = "CLIENT NAME";
           //  g.DrawImage(image,25,);
              e.Graphics.DrawImage(img,
                  (e.PageBounds.Width - img.Width) / 2,0);
              g.DrawString(printText, new Font("georgia", 12,FontStyle.Bold), Brush, 10, 10);
              */
            Image bg = bgbmp;
            Image image = bmp;

            e.Graphics.DrawImage(bg, (e.PageBounds.Width) / 2, 0, e.PageBounds.Width / 2, 120);

            e.Graphics.DrawImage(image, 0, 0, e.PageBounds.Width / 3, 120);
            e.Graphics.DrawString("SOCIETE:" + companystore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 20));
            e.Graphics.DrawString("ADDRESS:" + addressstore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 40));

            e.Graphics.DrawString("TEL:" + phonestore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 60));
            e.Graphics.DrawString("EMAIL:" + emailstore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 80));

            e.Graphics.DrawString("DATE DU FACTURE:" + datebill, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(25, 140));

            e.Graphics.DrawString("NOM DU CLIENT : "+ clientname, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(25, 160));
            e.Graphics.DrawString("FACTURE N= " +billnbr, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width - 100) / 2, 200));

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

            e.Graphics.DrawString("NOM DU PRODUIT", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(50, 255));
            e.Graphics.DrawString("QUANTITE", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(380, 255));
            e.Graphics.DrawString("PRIX ", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(660, 255));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

            int yPos = 295;
            using (SqlCeCommand command2 = connection.CreateCommand())
            {
                string sqlproducts = "select * from listproductsclient where idbill=" + billnbr;
                command2.CommandText = sqlproducts;
                SqlCeDataReader myReader = null;

                myReader = command2.ExecuteReader();

                while (myReader.Read())
                {
                    e.Graphics.DrawString(myReader["productname"].ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(50, yPos));
                    e.Graphics.DrawString(myReader["productquntity"].ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(380, yPos));
                    e.Graphics.DrawString(myReader["productprice"].ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(660, yPos));

                    yPos += 30;
                }
            }
            connection.Close();
                /*
            foreach (var i in shoppingCart)
            {
                e.Graphics.DrawString(i.ItemName, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(i.Quantity.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, yPos));
                e.Graphics.DrawString(i.UnitPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(525, yPos));
                e.Graphics.DrawString(i.TotalPrice.ToString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(675, yPos));

                yPos += 30;
            }*/

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

            e.Graphics.DrawString("PRIX TOTAL:" + totalprice+ "  DA"  /*TotalAmountTextBox.Text.Trim()*/, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, yPos + 30));
            
            }
        }
        
    }
}
