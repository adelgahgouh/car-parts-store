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
    public partial class billproviders : Form
    { Form1 f1;
    addbillprovider add;
        public billproviders( Form1 fo1)
        {
            InitializeComponent();
        f1=fo1;
        }

        

        private void billproviders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientdata.billprovider' table. You can move, or remove it, as needed.
            this.billproviderTableAdapter.Fill(this.clientdata.billprovider);
      
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            add=new addbillprovider(f1,this);
            add.Show();
            f1.Enabled = false;
        }
        public void refersh()
        {
            this.billproviderTableAdapter.Fill(this.clientdata.billprovider);
            bunifuCustomDataGrid1.Refresh();
        }
        public void exitfunction()
        {
            f1.Enabled = true;
            add.Visible = false;


        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.RowCount > 0)
            {
                if (MessageBox.Show("tu as sure pour supprimer ce facture ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (MessageBox.Show("voulez-vous diminuer qunatite de chaque produit dans cette facture  ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowindex = bunifuCustomDataGrid1.CurrentRow.Index;
                        int billnbr = int.Parse(bunifuCustomDataGrid1[0, rowindex].Value.ToString());
                        using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

                        //using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
                        {
                            connection.Open();
                            using (SqlCeCommand command1 = connection.CreateCommand())
                            {
                                try
                                {
                                    string sqlproductsell = "select * from listproductsprovider where idbill=" + billnbr;
                                    command1.CommandText = sqlproductsell;
                                    SqlCeDataReader myReader = null;

                                    myReader = command1.ExecuteReader();


                                    while (myReader.Read())
                                    {
                                        SqlCeCommand command5 = connection.CreateCommand();
                                        string sqlclient = "update   products set  quntity=quntity -" + int.Parse(myReader["productquntity"].ToString()) + " where name='" + myReader["productname"].ToString() + "'";
                                        command5.CommandText = sqlclient;
                                        command5.ExecuteNonQuery();
                                    }
                                }
                                catch (SqlCeException ex)
                                {
                                    MessageBox.Show("" + ex);
                                }
                            }
                            
                            using (SqlCeCommand command2 = connection.CreateCommand())
                            {
                                string sqlbil = "delete from listproductsprovider where idbill=" + billnbr;
                                command2.CommandText = sqlbil;
                                command2.ExecuteNonQuery();
                            }
                            using (SqlCeCommand command1 = connection.CreateCommand())
                            {
                                string sqlbil = "delete from billprovider where idbillprovider=" + billnbr;
                                command1.CommandText = sqlbil;
                                command1.ExecuteNonQuery();
                            }

                            this.billproviderTableAdapter.Fill(this.clientdata.billprovider);
                            bunifuCustomDataGrid1.Refresh();
                            connection.Close();
                        }
                    }
                    else { 
                        int rowindex = bunifuCustomDataGrid1.CurrentRow.Index;
                        int billnbr = int.Parse(bunifuCustomDataGrid1[0, rowindex].Value.ToString());
                        using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

                       // using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
                        {
                            connection.Open();
                            
                            using (SqlCeCommand command1 = connection.CreateCommand())
                            {
                                string sqlbil = "delete from billprovider where idbillprovider=" + billnbr;
                                command1.CommandText = sqlbil;
                                command1.ExecuteNonQuery();
                            }
                            using (SqlCeCommand command2 = connection.CreateCommand())
                            {
                                string sqlbil = "delete from listsellprovider where idbillprovider=" + billnbr;
                                command2.CommandText = sqlbil;
                                command2.ExecuteNonQuery();
                            }

                            this.billproviderTableAdapter.Fill(this.clientdata.billprovider);
                            bunifuCustomDataGrid1.Refresh();
                            connection.Close();
                        }
                    
                    }
                }
            }
             
            
        }
       
        private void btnshow_Click(object sender, EventArgs e)
        {
            int rowindex = bunifuCustomDataGrid1.CurrentRow.Index;
            int billnbr = int.Parse(bunifuCustomDataGrid1[0, rowindex].Value.ToString());
            string clientname = bunifuCustomDataGrid1[1, rowindex].Value.ToString();
            string datebill = bunifuCustomDataGrid1[3, rowindex].Value.ToString();
            string pricebill = bunifuCustomDataGrid1[2, rowindex].Value.ToString();
            //MessageBox.Show(""+rowindex);
            showbillprovider shbill;
            shbill = new showbillprovider(f1, billnbr, clientname, datebill, pricebill);
            shbill.Show();
        }

        private void tsearchbc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!string.IsNullOrEmpty(tsearchbc.Text))
                {
                    billproviderBindingSource.Filter = string.Format("date like '*{0}*' OR nameclient like '*{1}*' ", tsearchbc.Text, tsearchbc.Text);
                }
                else
                {
                    billproviderBindingSource.Filter = string.Empty;
                }

            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            this.billproviderTableAdapter.Fill(this.clientdata.billprovider);
            bunifuCustomDataGrid1.Refresh();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.RowCount > 0)
            {

                PrintDialog printDlg = new PrintDialog();

                printDlg.AllowCurrentPage = true;
                printDlg.AllowSelection = true;
                printDlg.AllowSomePages = true;
                printDbp.DocumentName = "Print Document";

                printDlg.Document = printDbp;


                if (printDlg.ShowDialog() == DialogResult.OK)
                    printDbp.Print();
            }
        }

        private void printDbp_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
             int rowindex = bunifuCustomDataGrid1.CurrentRow.Index;
            int billnbr = int.Parse(bunifuCustomDataGrid1[0, rowindex].Value.ToString());
            string emailstore = null, phonestore = null, companystore = null, addressstore = null, clientname = bunifuCustomDataGrid1[1, rowindex].Value.ToString(), totalprice = bunifuCustomDataGrid1[2, rowindex].Value.ToString(), datebill = bunifuCustomDataGrid1[3, rowindex].Value.ToString();
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

                e.Graphics.DrawString("NOM DU FOURNISSEUR: " + clientname, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(25, 160));
                e.Graphics.DrawString("FACTURE N= " + billnbr, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width - 100) / 2, 200));

                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

                e.Graphics.DrawString("NOM DU PRODUIT", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(50, 255));
                e.Graphics.DrawString("QUANTITE", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(380, 255));
                e.Graphics.DrawString("PRIX ", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(660, 255));
                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));

                int yPos = 295;
                using (SqlCeCommand command2 = connection.CreateCommand())
                {
                    string sqlproducts = "select * from listproductsprovider where idbill=" + billnbr;
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

                e.Graphics.DrawString("PRIX TOTAL:" + totalprice + "  DA"  /*TotalAmountTextBox.Text.Trim()*/, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, yPos + 30));
            }
        }
    }
}
