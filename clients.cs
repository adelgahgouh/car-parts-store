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
    public partial class clients : Form
    {
        bool newp = false;
     
        public clients()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientdata);

        }

        private void clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientdata.clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.clientdata.clients);
            edit(false);

        }
        void edit(bool val)
        {
            nameTextBox.Enabled = val;
            emailTextBox.Enabled = val;
            addresssTextBox.Enabled = val;
            phoneTextBox.Enabled = val;
        }
        void vide()
        {
            nameTextBox.Text = null;
            emailTextBox.Text = null;
            addresssTextBox.Text = null;
            phoneTextBox.Text = null;
        }
        
        private void btnnew_Click_1(object sender, EventArgs e)
        {
            
            edit(true);
            vide();
            newp = true;
            nameTextBox.Focus();
           



        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            if (clientdatagrid.RowCount > 0)
            {
                if (MessageBox.Show("Are sure to delete this client?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string namedel = nameTextBox.Text;
                    clientsBindingSource.RemoveCurrent();
                    clientsBindingSource.EndEdit();

                    clientsTableAdapter.Update(clientdata.clients);
                    clientdatagrid.Refresh();
                   /* SqlCeConnection conn1 = null;
                    try
                    {
                        conn1 = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");

                        conn1.Open();
                        SqlCeCommand cmdd = conn1.CreateCommand();
                        cmdd.CommandText = "insert into history(description,date) values('" + namedel + " as CLIENT has been DELETED','" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                        cmdd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        conn1.Close();
                    }*/
                }
            }
        }
        private void btncancel_Click(object sender, EventArgs e)
        {
         
            
            //vide();

            edit(false);
           
            newp = false;
            clientsBindingSource.ResetBindings(false);
            clientsTableAdapter.Fill(clientdata.clients);
        }
        private void bunifuCustomDataGrid1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void btnedit_Click_1(object sender, EventArgs e)
        {
            if (clientdatagrid.RowCount > 0)
            {
                edit(true);
                nameTextBox.Focus();
            }

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clientsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientdata);

        }
        private void btnsave_Click(object sender, EventArgs e)
        {

            if (newp)
            {
                newp = false;
                edit(false);
                SqlCeConnection conn = null;

                try
                {


                    conn = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);
                    conn.Open();

                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into clients(name,phone,email,addresss) values('" + nameTextBox.Text.ToString() + "','" + phoneTextBox.Text.ToString() + "','" + emailTextBox.Text.ToString() + "','" + addresssTextBox.Text.ToString() + "')";
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

                    clientsTableAdapter.Fill(clientdata.clients);
                    clientdatagrid.Refresh();

                 
                }
               /* SqlCeConnection conn1=null;
                try
                {
                    conn1 = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");

                    conn1.Open();
                    SqlCeCommand cmdd = conn1.CreateCommand();
                    cmdd.CommandText = "insert into history(description,date) values('" + nameTextBox.Text.ToString() + " as CLIENT has been ADDED','" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                    cmdd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                     conn1.Close();
                }*/

            }
            else
            {

                try
                {

                    edit(false);
                    clientsBindingSource.EndEdit();
                    clientsTableAdapter.Update(clientdata.clients);

                    clientdatagrid.Refresh();
                    nameTextBox.Focus();
                    clientdatagrid.Refresh();
                    /*SqlCeConnection conn1 = null;
                    try
                    {
                        conn1 = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");

                        conn1.Open();
                        SqlCeCommand cmdd = conn1.CreateCommand();
                        cmdd.CommandText = "insert into history(description,date) values('" + nameTextBox.Text.ToString() + " as CLIENT has been EDITED','" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                        cmdd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        conn1.Close();
                    }*/
                    edit(true);
                    vide();
                    edit(false);



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

      
        private void tsearchcl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!string.IsNullOrEmpty(tsearchcl.Text))
                {
                    clientsBindingSource.Filter = string.Format("name like '*{0}*' ", tsearchcl.Text);
                }
                else
                {
                    clientsBindingSource.Filter = string.Empty;
                }

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int yPos = 295;

            string emailstore = null, phonestore = null, companystore = null, addressstore = null;
            //MessageBox.Show(""+billnbr);
            //using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
            using (SqlCeConnection connection = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString))

            {
                connection.Open();
                using (SqlCeCommand command1 = connection.CreateCommand())
                {
                    string sqlsettings = "select * from settings where id=1";
                    command1.CommandText = sqlsettings;
                    SqlCeDataReader myReader = null;

                    myReader = command1.ExecuteReader();

                    while (myReader.Read())
                    {
                        phonestore = myReader["phone"].ToString();

                        emailstore = myReader["email"].ToString();
                        addressstore = myReader["address"].ToString();
                        companystore = myReader["company"].ToString();
                    }
                }

                Graphics g = e.Graphics;
                SolidBrush Brush = new SolidBrush(Color.Black);

                var bmp = new Bitmap(store.Properties.Resources.logos);
                var bgbmp = new Bitmap(store.Properties.Resources.bg);
               
                Image bg = bgbmp;
                Image image = bmp;

                e.Graphics.DrawImage(bg, (e.PageBounds.Width) / 2, 0, e.PageBounds.Width / 2, 120);
                int i = 0, rowcount = clientdatagrid.Rows.Count;

                e.Graphics.DrawImage(image, 0, 0, e.PageBounds.Width / 3, 120);
                e.Graphics.DrawString("SOCIETE:" + companystore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 20));
                e.Graphics.DrawString("ADDRESS:" + addressstore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 40));

                e.Graphics.DrawString("TEL:" + phonestore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 60));
                e.Graphics.DrawString("EMAIL:" + emailstore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 80));

                e.Graphics.DrawString("LIST DU CLIENTS  ", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width - 120) / 2, 200));
                e.Graphics.DrawString("NOMBRE DU CLIENTS:  " + rowcount, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(50, 220));

                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

                e.Graphics.DrawString("NOM DU CLIENT", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(50, 255));
                e.Graphics.DrawString("TEL", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(300, 255));
                e.Graphics.DrawString("EMAIL", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(460, 255));
                e.Graphics.DrawString("ADDRESS", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(600, 255));
                
                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));


                while (i < rowcount)
                {
                    e.Graphics.DrawString(clientdatagrid[1, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(50, yPos));
                    e.Graphics.DrawString(clientdatagrid[2, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(300, yPos));
                    e.Graphics.DrawString(clientdatagrid[3, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(460, yPos));
                    e.Graphics.DrawString(clientdatagrid[4, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(600, yPos));
                    yPos += 30;
                    i++;
                }
            }


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

        
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            

                PrintDialog printDlg = new PrintDialog();

                printDlg.AllowCurrentPage = true;
                printDlg.AllowSelection = true;
                printDlg.AllowSomePages = true;
                print.DocumentName = "Print Document";

                printDlg.Document = print;


                if (printDlg.ShowDialog() == DialogResult.OK)
                    print.Print();
            
        }


        

        

      
    }

}
