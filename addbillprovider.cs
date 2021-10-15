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
    public partial class addbillprovider : Form
    {
        Form1 f1;
        billproviders b;
        public addbillprovider(Form1 fo1,billproviders bo)
        {
            InitializeComponent();
            f1 = fo1;
            b = bo;
        }
        float currenttotal = 0f;
        int datanbrbill = 0;
        float uprice = 0f;
        string providername = null,productname=null;
        List<string> currentproductlist = new List<string>();
        private void btnadd_Click(object sender, EventArgs e)
        {
            providername = (string)comboBoxproviders.SelectedItem;


            if (providername == "")
            {
                MessageBox.Show("you have to select PROVIDER !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (!currentproductlist.Contains(productname))
                {


                    if (!string.IsNullOrEmpty(tproductquntite.Text) )
                    {
                        float unprix=float.Parse(tprix.Text.ToString());
                        int currentquntity = int.Parse(tproductquntite.Text.ToString());
                        currenttotal = currenttotal + (currentquntity * unprix);
                        total.Text = "TOTAL PRICE: " + currenttotal + " DA";
                        if (currentquntity > 0)
                        {
                            currentproductlist.Add(productname);
                            table.Rows.Add((string)productname, currentquntity, unprix);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("you have selected this product !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int numRows = table.Rows.Count;
            if (numRows != 0)
            {
                int selectedindex = table.CurrentRow.Index;

                int quntiteselected = int.Parse(table[1, selectedindex].Value.ToString());
                float priceselected = float.Parse(table[2, selectedindex].Value.ToString());
                string currentproduct = table[0, selectedindex].Value.ToString();
                currenttotal = currenttotal - (quntiteselected * priceselected);
                total.Text = "TOTAL PRICE: " + currenttotal + " DA";
                currentproductlist.Remove(currentproduct);
                table.Rows.Remove(table.CurrentRow);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int numRows = table.Rows.Count;
            string currentdate = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            if (providername == "" || currenttotal == 0)
            {
                MessageBox.Show("you have'nt selected any product  or any client !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

                  {
                    connection.Open();
                    int k = 0;
                    try
                    {
                        while (k < numRows)
                        {
                            SqlCeCommand command2 = connection.CreateCommand();

                            string sqlproductinsert = "insert into listproductsprovider(productname,productquntity,productprice,idbill) values('" + table[0, k].Value.ToString() + "','" + int.Parse(table[1, k].Value.ToString()) + "','" + float.Parse(table[2, k].Value.ToString()) + "'," + datanbrbill + ")";
                            command2.CommandText = sqlproductinsert;
                            command2.ExecuteNonQuery();
                            k++;
                        }
                    }
                    catch (SqlCeException ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                    using (SqlCeCommand command1 = connection.CreateCommand())
                    {
                        string sqlbil = "insert into billprovider(idbillprovider,nameprovider,price,date) values("+datanbrbill+",'" + providername + "','" + currenttotal + "','" + currentdate + "')";
                        command1.CommandText = sqlbil;
                        command1.ExecuteNonQuery();
                    }

                    using (SqlCeCommand command3 = connection.CreateCommand())
                    {
                        int i = 0;
                        while (i < numRows)
                        {
                            string sqlproductupdate = "update products set quntity=quntity+" + int.Parse(table[1, i].Value.ToString()) + " where name='" + table[0, i].Value.ToString() + "';";
                            command3.CommandText = sqlproductupdate;
                            command3.ExecuteNonQuery();
                            i++;
                        }
                    }
                    connection.Close();
                    // etc
                }
                b.exitfunction();
            }
        }

        private void addbillprovider_Load(object sender, EventArgs e)
        {
            restoredata();
        }
        
        void restoredata() {
            using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

            {
                connection.Open();
                using (SqlCeCommand command1 = connection.CreateCommand())
                {
                    string sqlprovider = "SELECT * FROM providers ";
                    command1.CommandText = sqlprovider;


                    SqlCeDataReader myReaderproviders = null;
                    myReaderproviders = command1.ExecuteReader();

                    while (myReaderproviders.Read())
                    {
                        comboBoxproviders.Items.Add(myReaderproviders["name"].ToString());
                    }
                }
                using (SqlCeCommand command2 = connection.CreateCommand())
                {
                    string sqlproduct = "SELECT * FROM products ";
                    command2.CommandText = sqlproduct;


                    SqlCeDataReader myReaderproducts = null;
                    myReaderproducts = command2.ExecuteReader();

                    while (myReaderproducts.Read())
                    {
                        comboBoxproducts.Items.Add(myReaderproducts["name"].ToString());
                    }
                }
                using (SqlCeCommand command3 = connection.CreateCommand())
                {
                    string sqlnbrbill = "SELECT TOP 1 idbillprovider FROM billprovider ORDER BY idbillprovider DESC  ";
                    command3.CommandText = sqlnbrbill;


                    SqlCeDataReader myReadernbrbill = null;
                    myReadernbrbill = command3.ExecuteReader();

                    while (myReadernbrbill.Read())
                    {
                        datanbrbill = int.Parse(myReadernbrbill["idbillprovider"].ToString());
                    }
                    datanbrbill++;
                    billnbrlabel.Text += datanbrbill;
                }
                connection.Close();
            }
        }

        private void comboBoxproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            productname = (string)comboBoxproducts.SelectedItem;
            using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

            {
                connection.Open();
                using (SqlCeCommand command1 = connection.CreateCommand())
                {
                    string sqlpriceproduct = "SELECT * FROM products where name ='" + productname + "'"; ;
                    command1.CommandText = sqlpriceproduct;


                    SqlCeDataReader myReaderprice = null;
                    myReaderprice = command1.ExecuteReader();

                    while (myReaderprice.Read())
                    {
                        uprice = float.Parse(myReaderprice["price"].ToString());
                    }
                    tprix.Text = "" + uprice;
                  
                }
                connection.Close();
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Enabled = true;
            f1.Focus();
        }
    }
}
