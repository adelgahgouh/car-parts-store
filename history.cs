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
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        private void historyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.historyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientdata);

        }

        private void history_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientdata.history' table. You can move, or remove it, as needed.
            this.historyTableAdapter.FillBy(this.clientdata.history);
            
    
           // getdate();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.historyTableAdapter.Fill(this.clientdata.history);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
           

        }
        void getdate() {
            tsearchh.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");

        
        }

        private void tsearchh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!string.IsNullOrEmpty(tsearchh.Text))
                {
                    historyBindingSource.Filter = string.Format("date like '*{0}*' or description like '*{0}*' ", tsearchh.Text);
                }
                else
                {
                    historyBindingSource.Filter = string.Empty;
                }

            }
        }

        private void historyBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.historyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientdata);

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.historyTableAdapter.FillBy(this.clientdata.history);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            SqlCeConnection conn1 = null;
            try
            {
                conn1 = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);

                //conn1 = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");

                conn1.Open();
                SqlCeCommand cmdd = conn1.CreateCommand();
                cmdd.CommandText = "DELETE FROM history";
                cmdd.ExecuteNonQuery();
                SqlCeCommand cmdd1 = conn1.CreateCommand();
                cmdd1.CommandText = "ALTER TABLE history ALTER COLUMN id IDENTITY (1,1)";   

                cmdd1.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn1.Close();
                historyTableAdapter.FillBy(clientdata.history);
                bunifuCustomDataGrid1.Refresh();
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            historyTableAdapter.FillBy(clientdata.history);
            bunifuCustomDataGrid1.Refresh();
        }
       public void refresh() {
            historyTableAdapter.FillBy(clientdata.history);
            bunifuCustomDataGrid1.Refresh();
        }
    }
}
