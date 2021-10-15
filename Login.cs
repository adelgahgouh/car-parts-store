using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

using System.Data.SqlServerCe;

namespace store
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn = null;
            string username = null, password = null;
            try
            {
                conn = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);

               // conn = new SqlCeConnection("Data Source =|DataDirectory|Database1.sdf; "/*Persist Security Info=False"*/);
                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM settings WHERE id =1";


                SqlCeDataReader myReader = null;
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    username = myReader["username"].ToString();

                    password = myReader["password"].ToString();

                }
                if (tpassword.Text == password.ToString() && tusername.Text == username.ToString())
                {
                    new Form1().Show();

                    this.Hide();
                }



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
        }

        private void tpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
           {
               string username = null, password = null;
              // using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
               using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

                {
                   connection.Open();
                   using (SqlCeCommand command1 = connection.CreateCommand())
                   {
                       string sqlsettings = "SELECT * FROM settings WHERE id =1 ";
                       command1.CommandText = sqlsettings;
                       SqlCeDataReader myReadersettings = null;
                       myReadersettings = command1.ExecuteReader();
                       while (myReadersettings.Read())
                       {
                           username = myReadersettings["username"].ToString();

                           password = myReadersettings["password"].ToString();
                       }
                       if (tpassword.Text == password.ToString() && tusername.Text == username.ToString())
                       {
                           new Form1().Show();

                           this.Hide();
                       }

                   }
               }
           }
        }

       
    }
    /**/
}
