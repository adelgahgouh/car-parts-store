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
    public partial class Lcaisse : Form
    {
        Form1 f1;
        public Lcaisse(Form1 fo1)
        {
            InitializeComponent();
            f1 = fo1;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            string passworddb=null;
            string pass=tpass.Text.ToString();
            if (string.IsNullOrEmpty(pass) )
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
                        string sqlclient = "SELECT * FROM settings WHERE id =2";
                        command1.CommandText = sqlclient;
                        SqlCeDataReader myReader = null;
                        myReader = command1.ExecuteReader();

                        while (myReader.Read())
                        {
                            passworddb = myReader["password"].ToString();
                        }
                    }
                    connection.Close();
                    if (pass==passworddb)
                    {
                        this.Hide();
                        f1.settingscaisse();
                      
                    }
                }
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            f1.Focus();
        }

        private void tpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string passworddb = null;
                string pass = tpass.Text.ToString();
                if (string.IsNullOrEmpty(pass))
                {

                    MessageBox.Show("il ya vide !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                  //  using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
                    using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

                    {
                        connection.Open();
                        using (SqlCeCommand command1 = connection.CreateCommand())
                        {
                            string sqlclient = "SELECT * FROM settings WHERE id =2";
                            command1.CommandText = sqlclient;
                            SqlCeDataReader myReader = null;
                            myReader = command1.ExecuteReader();

                            while (myReader.Read())
                            {
                                passworddb = myReader["password"].ToString();
                            }
                        }
                        connection.Close();
                        if (pass == passworddb)
                        {
                            this.Hide();
                            f1.settingscaisse();

                        }
                    }
                }
            }
        }
    }
}
