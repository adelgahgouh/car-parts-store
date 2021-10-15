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
    public partial class showbillclient : Form
    {
        Form1 f1;
        int datanbrbill = 0;
        string dataclientname=null, datadatebill=null,datapricebill=null;
         public showbillclient(Form1 fo1,int nbrbill,string clientname,string datebill,string pricebill)
          {
              InitializeComponent();
              f1 = fo1;
              datanbrbill = nbrbill;
              dataclientname = clientname;
              datadatebill=datebill;
              datapricebill = pricebill;
          }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
          
           
            f1.Enabled = true;
            f1.Focus();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            if (tablelist.Rows.Count > 0)
            {

                PrintDialog printDlg = new PrintDialog();

                printDlg.AllowCurrentPage = true;
                printDlg.AllowSelection = true;
                printDlg.AllowSomePages = true;
                printshbc.DocumentName = "Print Document";

                printDlg.Document = printshbc;


                if (printDlg.ShowDialog() == DialogResult.OK)
                    printshbc.Print();
            }
        }

        private void showbillclient_Load(object sender, EventArgs e)
        {
            restoredata();
        }
        void restoredata() {
            totalprice.Text = totalprice.Text + datapricebill+" DA";
            clientname.Text = clientname.Text + dataclientname;
            datebill.Text = datebill.Text + datadatebill;
            billnbr.Text = billnbr.Text + datanbrbill;
            using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

            {
                connection.Open();
                using (SqlCeCommand command1 = connection.CreateCommand())
                {
                    string sqlbil = "select * from listproductsclient where idbill="+datanbrbill ;
                    command1.CommandText = sqlbil;
                    SqlCeDataReader myReader = null;
                    myReader = command1.ExecuteReader();
                    while (myReader.Read())
                    {
                        tablelist.Rows.Add(myReader["productname"].ToString(), myReader["productquntity"].ToString(), myReader["productprice"].ToString());
                    }
                    
                }
                connection.Close();
            }
        }

        private void printshbc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int yPos = 295;

            string emailstore = null, phonestore = null, companystore = null, addressstore = null;
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
                Image bg = bgbmp;
                Image image = bmp;

                e.Graphics.DrawImage(bg, (e.PageBounds.Width) / 2, 0, e.PageBounds.Width / 2, 120);

                e.Graphics.DrawImage(image, 0, 0, e.PageBounds.Width /3, 120);
                e.Graphics.DrawString("SOCIETE:" + companystore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 20));
                e.Graphics.DrawString("ADDRESS:" + addressstore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 40));

                e.Graphics.DrawString("TEL:" + phonestore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 60));
                e.Graphics.DrawString("EMAIL:" + emailstore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 80));

                e.Graphics.DrawString("DATE DU FACTURE:" + datadatebill, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(25, 140));

                e.Graphics.DrawString("NOM DU CLIENT: " + dataclientname, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(25, 160));
                e.Graphics.DrawString("FACTURE N= " + datanbrbill, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width - 100) / 2, 200));

                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

                e.Graphics.DrawString("NOM DU PRODUIT", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(50, 255));
                e.Graphics.DrawString("QUANTITE", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(380, 255));
                e.Graphics.DrawString("PRIX ", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(660, 255));
                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));


                int i = 0, rowcount = tablelist.Rows.Count;
                while (i < rowcount)
                {
                    e.Graphics.DrawString(tablelist[0, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(50, yPos));
                    e.Graphics.DrawString(tablelist[1, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(380, yPos));
                    e.Graphics.DrawString(tablelist[2, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(660, yPos));

                    yPos += 30;
                    i++;
                }
            }

            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

            e.Graphics.DrawString( totalprice.Text  , new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(550, yPos + 30));

        }
    }
}
