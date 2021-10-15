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
    public partial class retirer : Form
    {
        Form1 f1; tresure b1;
        public retirer(Form1 fo1, tresure b)
        {
            InitializeComponent();
            f1 = fo1;
            b1 = b;
        }

        private void retirer_Load(object sender, EventArgs e)
        {
            restoredata();
        }
       void restoredata(){
           //using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
           using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

           {
               connection.Open();
               using (SqlCeCommand command1 = connection.CreateCommand())
               {
                   string sqlclient = "SELECT * FROM emloyes ";
                   command1.CommandText = sqlclient;


                   SqlCeDataReader myReaderclients = null;
                   myReaderclients = command1.ExecuteReader();

                   while (myReaderclients.Read())
                   {
                       comboBoxemployes.Items.Add(myReaderclients["name"].ToString());
                   }
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

       private void btnsave_Click(object sender, EventArgs e)
       {
           string mo = tmoney.Text;
           string nameem = (string)comboBoxemployes.SelectedItem;
           string comment = tcomment.Text;
           if (string.IsNullOrEmpty(mo) || string.IsNullOrEmpty(nameem) || string.IsNullOrEmpty(comment))
           {

               MessageBox.Show("il ya vide !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
           else
           {
              // using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
               using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

               {
                   connection.Open();
                   using (SqlCeCommand command1 = connection.CreateCommand())
                   {
                       string sqlclient = "update   caisser set  money=money -" + float.Parse(mo) + " where idcaisser=1";
                       command1.CommandText = sqlclient;
                       command1.ExecuteNonQuery();
                   }
              
                
                   using (SqlCeCommand command2 = connection.CreateCommand())
                   {
                      
                       string sqlclient ="insert into history(description,date) values('" + nameem + "  comme employe a ete pris l argent de valeur  "+mo+" DA la couse c est :"+comment+"','" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "')"; 
                           command2.CommandText = sqlclient;
                           command2.ExecuteNonQuery();
                   }
                   connection.Close();
               }
               b1.exitfunction();   
           }
       }
       }
}
