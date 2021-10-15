using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Data.SqlServerCe;

namespace store
{
    public partial class settings : Form
    {
       // SqlConnection conn = new SqlConnection();
        
       String username = null, password = null, email = null, name = null, phone = null, address = null, company = null;
        
        public settings()
        {
            InitializeComponent();
        }
        private void settings_Load(object sender, EventArgs e)
        {
            SqlCeConnection conn = null;

            try
            {
               // conn = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");
                conn = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);

                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM settings WHERE id =1";


                SqlCeDataReader myReader = null;
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    username = myReader["username"].ToString();

                    password = myReader["password"].ToString();
                    name = myReader["name"].ToString();
                    phone = myReader["phone"].ToString();

                    email = myReader["email"].ToString();
                    address = myReader["address"].ToString();
                    company = myReader["company"].ToString();
                }
                tuser.Text = username;
                tpass.Text = password;
                tname.Text = name;
                tphone.Text = phone;
                temail.Text = email;
                taddress.Text = address;
                tcompany.Text = company;


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

        private void btnsave_Click(object sender, EventArgs e)
        {
           
           
            SqlCeConnection conn = null;

            try
            {
                //conn = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");
                conn = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);

                conn.Open();

                SqlCeCommand cmd = conn.CreateCommand();
                cmd.CommandText = "Update settings set name='" + tname.Text.ToString() + "', username='" + tuser.Text.ToString() + "' ,password='" + tpass.Text.ToString() + "' ,email='" + temail.Text.ToString() + "' ,phone='" + tphone.Text.ToString() + "', company='" + tcompany.Text + "' ,address='" + taddress.Text.ToString() + "'  WHERE id =1";
                cmd.ExecuteNonQuery();

               


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
               // MessageBox.Show("success"+username);

                conn.Close();
            }
            
        }
       

    }
}
