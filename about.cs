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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void about_Load(object sender, EventArgs e)
        {
            string name = null;
            SqlCeConnection conn = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);

//            SqlCeConnection conn = new SqlCeConnection("Data Source =|DataDirectory| Database1.sdf; Persist Security Info=False");
            conn.Open();

            SqlCeCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM settings WHERE id =1";


            SqlCeDataReader myReader = null;
            myReader = cmd.ExecuteReader();

            while (myReader.Read())
            {
              
                name = myReader["name"].ToString();
              }
            tnamec.Text = tnamec.Text + name.ToUpper();
        }
    }
}
