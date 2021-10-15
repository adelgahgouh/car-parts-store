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
    public partial class settingcaisse : Form
    {
        public settingcaisse()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string caisse=tcaisse.Text.ToString();
            string pass=tpass.Text.ToString();
            if(string.IsNullOrEmpty(caisse) || string.IsNullOrEmpty(pass)){
                MessageBox.Show("il ya vide !!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            }else
            {
            //using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
                using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

                {
                connection.Open();
                using (SqlCeCommand command1 = connection.CreateCommand())
                {
                    string sqlsettings = "Update settings set password='"+pass+"' where id=2";
                    command1.CommandText = sqlsettings;
                    command1.ExecuteNonQuery();
                }
                using (SqlCeCommand command2 = connection.CreateCommand())
                {
                    string sqlsettings = "Update caisser set money="+float.Parse(caisse)+" where idcaisser=1";
                    command2.CommandText = sqlsettings;
                    command2.ExecuteNonQuery();
                }
                connection.Close();
            }
            }
        }

        private void settingcaisse_Load(object sender, EventArgs e)
        {
            restoredata();
        }
            void restoredata(){
                string currentpass = null;
                //using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
                using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

                {
                    connection.Open();
                    using (SqlCeCommand command1 = connection.CreateCommand())
                    {
                        string sqlsettings = "select * from settings where id=2";
                        command1.CommandText = sqlsettings;
                        SqlCeDataReader myReader = null;

                        myReader = command1.ExecuteReader();

                        while (myReader.Read())
                        {
                            currentpass = myReader["password"].ToString();
                        }
                        tpass.Text = currentpass;
                    }
                    using (SqlCeCommand command2 = connection.CreateCommand())
                    {
                        string caisse = null;
                        string sqlsettings = "select * from caisser where idcaisser=1";
                        command2.CommandText = sqlsettings;
                        SqlCeDataReader myReader = null;

                        myReader = command2.ExecuteReader();

                        while (myReader.Read())
                        {
                            caisse = myReader["money"].ToString();
                        }
                        tcaisse.Text = caisse;
                    }
                    connection.Close();
                }
            
            }
        
    }
}
