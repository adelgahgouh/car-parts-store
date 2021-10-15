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
    public partial class worker : Form
    {
        bool newp = false;

        public worker()
        {
            InitializeComponent();
        }

        private void worker_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientdata.emloyes' table. You can move, or remove it, as needed.
            this.emloyesTableAdapter.Fill(this.clientdata.emloyes);
            edit(false);

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            edit(true);
            vide();
            newp = true;
            nameTextBox.Focus();
        }
        void edit(bool val)
        {
            nameTextBox.Enabled = val;
            salaireTextBox.Enabled = val;

            phoneTextBox.Enabled = val;
        }
        void vide()
        {
            nameTextBox.Text = null;
            salaireTextBox.Text = null;
            phoneTextBox.Text = null;
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.RowCount > 0)
            {
                edit(true);
                nameTextBox.Focus();
            }
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

                    //conn = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");
                    conn.Open();

                    SqlCeCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "insert into emloyes(name,tel,salaire) values('" + nameTextBox.Text.ToString() + "','" + phoneTextBox.Text.ToString() + "'," + float.Parse(salaireTextBox.Text.ToString() )+ ")";
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
                SqlCeConnection conn1 = null;
                try
                {
                    //conn1 = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");
                    conn1 = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);

                    conn1.Open();
                    SqlCeCommand cmdd = conn1.CreateCommand();
                    cmdd.CommandText = "insert into history(description,date) values('" + nameTextBox.Text.ToString() + " comme employe a ete ajouter ','" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                    cmdd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    conn1.Close();
                    emloyesTableAdapter.Fill(clientdata.emloyes);
                    bunifuCustomDataGrid1.Refresh();
                }

            }
            else
            {

                try
                {

                    edit(false);
                    emloyesBindingSource.EndEdit();
                    emloyesTableAdapter.Update(clientdata.emloyes);

                    bunifuCustomDataGrid1.Refresh();
                    nameTextBox.Focus();
                    bunifuCustomDataGrid1.Refresh();
                    SqlCeConnection conn1 = null;
                    try
                    {
                        //conn1 = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False");
                        conn1 = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);

                        conn1.Open();
                        SqlCeCommand cmdd = conn1.CreateCommand();
                        cmdd.CommandText = "insert into history(description,date) values('" + nameTextBox.Text.ToString() + "  comme employe a ete modifier','" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                        cmdd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        conn1.Close();
                    }
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.RowCount > 0)
            {
                if (MessageBox.Show("tu a sure pour supprimer ce employe?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string namedel = nameTextBox.Text;
                    emloyesBindingSource.RemoveCurrent();
                    emloyesBindingSource.EndEdit();

                    emloyesTableAdapter.Update(clientdata.emloyes);
                    bunifuCustomDataGrid1.Refresh();
                    SqlCeConnection conn1 = null;
                    try
                    {
                        conn1 = new SqlCeConnection(store.Properties.Settings.Default.Database1ConnectionString);

                        conn1.Open();
                        SqlCeCommand cmdd = conn1.CreateCommand();
                        cmdd.CommandText = "insert into history(description,date) values('" + namedel + " comme employe a ete supprimer','" + DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss") + "')";
                        cmdd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error");
                    }
                    finally
                    {
                        conn1.Close();
                    }
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            //vide();

            edit(false);
            emloyesBindingSource.ResetBindings(false);
            emloyesTableAdapter.Fill(clientdata.emloyes);
            newp = false;
        }

        private void printDocumentempl_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int yPos = 295;

            string emailstore = null, phonestore = null, companystore = null, addressstore = null;
            //MessageBox.Show(""+billnbr);
          //  using (SqlCeConnection connection = new SqlCeConnection("Data Source = Database1.sdf; Persist Security Info=False"))
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
                int i = 0, rowcount = bunifuCustomDataGrid1.Rows.Count;
                e.Graphics.DrawImage(bg, (e.PageBounds.Width) / 2, 0, e.PageBounds.Width / 2, 120);

                e.Graphics.DrawImage(image, 0, 0, e.PageBounds.Width / 3, 120);
                e.Graphics.DrawString("SOCIETE:" + companystore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 20));
                e.Graphics.DrawString("ADDRESS:" + addressstore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 40));

                e.Graphics.DrawString("TEL:" + phonestore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 60));
                e.Graphics.DrawString("EMAIL:" + emailstore, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width + 80) / 2, 80));

                e.Graphics.DrawString("LIST DU EMPLOYES  ", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point((e.PageBounds.Width - 120) / 2, 200));
                e.Graphics.DrawString("NOMBRE DU EMPLOYES :  " + rowcount, new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(50, 220));

                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 235));

                e.Graphics.DrawString("NOM DU EMPLOYE", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(50, 255));
                e.Graphics.DrawString("TEL", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(300, 255));
                e.Graphics.DrawString("SALAIRE", new Font("georgia", 12, FontStyle.Bold), Brushes.Black, new Point(460, 255));
              
                e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 270));



                while (i < rowcount)
                {
                    e.Graphics.DrawString(bunifuCustomDataGrid1[1, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(50, yPos));
                    e.Graphics.DrawString(bunifuCustomDataGrid1[2, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(300, yPos));
                    e.Graphics.DrawString(bunifuCustomDataGrid1[3, i].Value.ToString(), new Font("georgia", 12, FontStyle.Regular), Brushes.Black, new Point(460, yPos));
                   yPos += 30;
                    i++;
                }
            }


            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, yPos));

        }
        public void refresh() {
            emloyesTableAdapter.Fill(clientdata.emloyes);
            bunifuCustomDataGrid1.Refresh();
        }
        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();

            printDlg.AllowCurrentPage = true;
            printDlg.AllowSelection = true;
            printDlg.AllowSomePages = true;
            printDocumentempl.DocumentName = "Print Document";

            printDlg.Document = printDocumentempl;


            if (printDlg.ShowDialog() == DialogResult.OK)
                printDocumentempl.Print();
        }

        private void tsearshp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!string.IsNullOrEmpty(tsearshp.Text))
                {
                    emloyesBindingSource.Filter = string.Format(" name like '*{0}*' ", tsearshp.Text);
                }
                else
                {
                    emloyesBindingSource.Filter = string.Empty;
                }

            }
        }
    }
}
