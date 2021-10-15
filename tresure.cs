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
    public partial class tresure : Form
    {
        Form1 f1;
        retirer r;
        public tresure(Form1 f)
        {
            InitializeComponent();
            f1 = f;
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Files|*.sdf";
            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string destinationFile = System.IO.Directory.GetCurrentDirectory() + "/Database1.sdf";
                string sourceFile = open.FileName;
                System.IO.File.Copy(sourceFile, destinationFile, true);
            }
        }

        private void tresure_Load(object sender, EventArgs e)
        {
            refresh();
        }
        void restoredata() {
            string currentmoney=null;
           // using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
            using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

            {
                connection.Open();
                using (SqlCeCommand command1 = connection.CreateCommand())
                {
                    string sqlcaisse = "select * from caisser where idcaisser=1";
                    command1.CommandText = sqlcaisse;
                    SqlCeDataReader myReader = null;

                    myReader = command1.ExecuteReader();

                    while (myReader.Read())
                    {
                        currentmoney = myReader["money"].ToString();
                    }
                }
                lmoney.Text = "l'argent courant dans la  caisse: " + currentmoney + " DA";
                connection.Close();

            }


        }
        public void refresh() {

            restoredata();
        }

        private void btnexporter_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    string sourceFile = System.IO.Directory.GetCurrentDirectory() + "/Database1.sdf";
                    string destinationFile = folderDialog.SelectedPath + "/database.sdf";
                    System.IO.File.Copy(sourceFile, destinationFile, true);
                    // folderDialog.SelectedPath -- your result
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnretirer_Click(object sender, EventArgs e)
        {
            r = new retirer(f1, this);


            r.Show();
            f1.Enabled = false;

        }
        public void exitfunction()
        {
            f1.Enabled = true;
            r.Visible = false;


        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            new Lcaisse(f1).Show();
        }
    }
}
