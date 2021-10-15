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
    public partial class addbillclient : Form
    {
        Form1 f1;
        billclient b1;
        public addbillclient(Form1 fo1,billclient  b)
        {
            InitializeComponent();
            f1 = new Form1();
            f1 = fo1;
            b1 = b;
        }
        int datanbrbill = 0;
        private void addbillclient_Load(object sender, EventArgs e)
        {
            restoredata();
            
           
        }
        
        void restoredata(){
          //  using (SqlCeConnection connection = new SqlCeConnection("Data Source =|DataDirectory| Database1.sdf; Persist Security Info=False"))

            using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))
            {
                connection.Open();
                using (SqlCeCommand command1 = connection.CreateCommand())
                {
                    string sqlclient = "SELECT * FROM clients ";
                    command1.CommandText = sqlclient;


                    SqlCeDataReader myReaderclients = null;
                    myReaderclients = command1.ExecuteReader();

                    while (myReaderclients.Read())
                    {
                        comboBoxclients.Items.Add(myReaderclients["name"].ToString());
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
                  string sqlnbrbill = "SELECT TOP 1 idbillclient FROM billclient ORDER BY idbillclient DESC  ";
                   // string sqlnbrbill = "select IDENT_CURRENT('billclient') as idbillclient ";
                    
                    command3.CommandText = sqlnbrbill;


                    SqlCeDataReader myReadernbrbill = null;
                    myReadernbrbill = command3.ExecuteReader();

                    while (myReadernbrbill.Read())
                    {
                        datanbrbill = int.Parse(myReadernbrbill["idbillclient"].ToString());
                        
                    }
                    datanbrbill++;
                    billnbrlabel.Text += datanbrbill;
                    
                }
                connection.Close();
            }
        
        
        }
        /*
        void billnbr2() { 
        
        SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");
                conn.Open();

                SqlCeCommand cmdc = conn.CreateCommand();
                cmdc.CommandText = "SELECT TOP 1 idbillclient FROM billclient ORDER BY idbillclient DESC  ";


                SqlCeDataReader myReaderbillclient = null;
                myReaderbillclient = cmdc.ExecuteReader();

                while (myReaderbillclient.Read())
                {
                    nbrbill3 = int.Parse(myReaderbillclient["idbillclient"].ToString());
                }
               nbrbill3++;
               billnbrlabel.Text += nbrbill3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {


                conn.Close();
            }
        }
        void test() {
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");
                conn.Open();

                SqlCeCommand cmdc = conn.CreateCommand();
                cmdc.CommandText = "SELECT * FROM clients ";


                SqlCeDataReader myReaderclient = null;
                myReaderclient = cmdc.ExecuteReader();

                while (myReaderclient.Read())
                {
                    comboBoxclients.Items.Add(myReaderclient["name"].ToString());
                }
                SqlCeCommand cmdp = conn.CreateCommand();
                cmdp.CommandText = "SELECT * FROM products ";
                SqlCeDataReader myReaderproduct = null;
                myReaderproduct = cmdp.ExecuteReader();
                while (myReaderproduct.Read())
                {
                    comboBoxproducts.Items.Add(myReaderproduct["name"].ToString());
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
               

                conn.Close();
             
            }
            


        }*/

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Enabled=true;
            f1.Focus();
        }

        
        
        float uprice = 0f;
        int pquqntity = 0;
        string productname=null;
        private void comboBoxproducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectproduct();

        }
        void selectproduct() {
            labelqof.Text = "/";
            productname = (string)comboBoxproducts.SelectedItem;
           // using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
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
                        pquqntity = int.Parse(myReaderprice["quntity"].ToString());
                        uprice = float.Parse(myReaderprice["price"].ToString());
                    }
                    tprix.Text =""+ uprice;
                    labelqof.Text = "/" + pquqntity;
                }
                connection.Close();
            }

        
        }
       /* void selectproduct() {
            labelqof.Text = "/";
            productname = (string)comboBoxproducts.SelectedItem;
            //MessageBox.Show("" + productname);
            SqlCeConnection conn = null;
            try
            {
                conn = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");
                conn.Open();

                SqlCeCommand cmdc = conn.CreateCommand();
                cmdc.CommandText = "SELECT * FROM products where name ='" + productname + "'";


                SqlCeDataReader myReaderproduct = null;
                myReaderproduct = cmdc.ExecuteReader();

                while (myReaderproduct.Read())
                {
                    pquqntity = int.Parse(myReaderproduct["quntity"].ToString());
                    uprice = float.Parse(myReaderproduct["price"].ToString());
                }
                labelpricep.Text = "U.PRICE:" + uprice + " DA";
                labelqof.Text = "/"+pquqntity;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                //MessageBox.Show("success" + username);

                conn.Close();
                
            }
        
        }*/
        /*string[] s = null;
         int i = 0;
         while (i <= pquqntity)
         {
             s[i] = ""+i;
         }
         comboBoxquntity.Items.Add(s);*/

        private void comboBoxproducts_SelectedValueChanged(object sender, EventArgs e)
        {
          //  selectproduct();

        }
        float  currenttotal=0f;
         string clientname = null;
          
        List<string> currentproductlist = new List<string>();
        private void btnadd_Click(object sender, EventArgs e)
        { 
            clientname = (string)comboBoxclients.SelectedItem;
            if (clientname == "")
            {
                MessageBox.Show("you have to select client !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                if (!currentproductlist.Contains(productname))
                {


                    if (!string.IsNullOrEmpty(tquntite.Text))
                    {
                        float unprice = float.Parse(tprix.Text.ToString());
                        int currentquntity = int.Parse(tquntite.Text.ToString());
                        currenttotal = currenttotal + (currentquntity * unprice);
                        total.Text = "PRIX TOTAL: " + currenttotal + " DA";
                        if (currentquntity <= pquqntity && currentquntity > 0)
                        {
                            //MessageBox.Show(productname);
                            currentproductlist.Add(productname);
                            table.Rows.Add(productname,  currentquntity, unprice);
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
                total.Text = "PRIX TOTAL: " + currenttotal + " DA";
                currentproductlist.Remove(currentproduct);
                table.Rows.Remove(table.CurrentRow);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int numRows = table.Rows.Count;
            string currentdate = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");
            if (clientname == "" || currenttotal == 0)
            {
                MessageBox.Show("aucune produit a ete selectionner ou client !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))
                {
                    connection.Open();
                    
                        try
                        {
                            int k = 0;
                            while (k < numRows)
                            {SqlCeCommand command1 = connection.CreateCommand();
                    
                                string sqlproductinsert = "insert into listproductsclient(productname,productquntity,productprice,idbill) values('" + table[0, k].Value.ToString() + "','" + table[1, k].Value.ToString() + "','" + table[2, k].Value.ToString() + "'," + datanbrbill + ")";
                                command1.CommandText = sqlproductinsert;
                                command1.ExecuteNonQuery();
                                k++;
                            }
                        }
                        catch (SqlCeException ex) {
                            MessageBox.Show("" + ex);
                        }
                    
                    using (SqlCeCommand command2 = connection.CreateCommand())
                    {
                        string sqlbil = "insert into billclient(idbillclient,nameclient,price,date) values("+datanbrbill+",'" + clientname + "','" + currenttotal + "','" + currentdate + "')";
                        command2.CommandText = sqlbil;
                        command2.ExecuteNonQuery();
                    }
                   
                    using (SqlCeCommand command3 = connection.CreateCommand())
                    {
                        int i = 0;
                        while (i < numRows)
                        {
                            string sqlproductupdate = "update products set quntity=quntity-" + int.Parse(table[1, i].Value.ToString()) + " where name='" + table[0, i].Value.ToString() + "';";
                            command3.CommandText = sqlproductupdate;
                            command3.ExecuteNonQuery();
                            i++;
                        }
                    }


                    using (SqlCeCommand command5 = connection.CreateCommand())
                    {

                        string sqlclient = "update   caisser set  money=money +" + currenttotal + " where idcaisser=1";
                        command5.CommandText = sqlclient;
                        command5.ExecuteNonQuery();

                    }

                    using (SqlCeCommand command4 = connection.CreateCommand())
                    {

                        string sqlclient = "insert into history(description,date) values('la caisse a ete augmenter de valeur " + currenttotal + " DA a partir de idfacture de client  =" + datanbrbill + "','" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                        command4.CommandText = sqlclient;
                        command4.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                updatenbr();
                b1.exitfunction();
            
            
            
            }
        }
        void updatenbr() {
            using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))
            {
                connection.Open();
                using (SqlCeCommand command3 = connection.CreateCommand())
                {
                    string sqlnbrbill = "SELECT TOP 1 idbillclient FROM billclient ORDER BY idbillclient DESC  ";
                    command3.CommandText = sqlnbrbill;


                    SqlCeDataReader myReadernbrbill = null;
                    myReadernbrbill = command3.ExecuteReader();

                    while (myReadernbrbill.Read())
                    {
                        datanbrbill = int.Parse(myReadernbrbill["idbillclient"].ToString());
                    }
                    datanbrbill++;
                }
                connection.Close();
               
            }
        }
    
       
    }
    /*     using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

                       {
                           connection.Open();

                          // MessageBox.Show("" + table[2,0].Value.ToString());
                              using (SqlCeCommand command2 = connection.CreateCommand())
                              {
                                  int k = 0;
                                  while (k < numRows)
                                  {


                                     string sqlproductinsert = "insert into listbuyclient(productname,productquntity,productprice,idbillclient) values('" + table[0, k].Value.ToString() + "','" + table[1, k].Value.ToString() + "','" + table[2, k].Value.ToString() + "'," + datanbrbill + ")";
                                      command2.CommandText = sqlproductinsert;
                                      command2.ExecuteNonQuery();
                                      k++;
                                  }

                              }

                    
                    
                           using (SqlCeCommand command1 = connection.CreateCommand())
                           {
                               string sqlbil = "insert into billclient(nameclient,price,date) values('" + clientname + "','" + currenttotal + "','" + currentdate + "')";
                               command1.CommandText = sqlbil;
                               command1.ExecuteNonQuery();
                           }
                    
                    
                           using (SqlCeCommand command3 = connection.CreateCommand())
                           {
                               int i = 0;
                               while (i < numRows)
                               {
                                   string sqlproductupdate = "update products set quntity=quntity-" + int.Parse(table[1, i].Value.ToString()) + " where name='" + table[0, i].Value.ToString() + "';";
                                   command3.CommandText = sqlproductupdate;
                                   command3.ExecuteNonQuery();
                                   i++;
                               }
                           } 
                    
                        
                           using (SqlCeCommand command5 = connection.CreateCommand())
                           {
                        
                                   string sqlclient = "update   caisser set  money=money +" + currenttotal + " where idcaisser=1";
                                   command5.CommandText = sqlclient;
                                   command5.ExecuteNonQuery();
                       
                           }

                           using (SqlCeCommand command4 = connection.CreateCommand())
                           {

                               string sqlclient = "insert into history(description,date) values('la caisse a ete augmenter de valeur " + currenttotal + " DA a partir de idfacture de client  =" + datanbrbill + "','" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                               command4.CommandText = sqlclient;
                               command4.ExecuteNonQuery();
                           }
                           connection.Close();
                 
                    
                           // etc
                       }
                       //Close();
                       b1.exitfunction();
                   }
            
               }*/
}
