using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace store
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        public void refresh() {

            this.productsTableAdapter.Fill(this.clientdata.products);
            bunifuCustomDataGrid1.Refresh();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientdata.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.clientdata.products);

        }

        private void tsearchDP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (!string.IsNullOrEmpty(tsearchDP.Text))
                {
                    productsBindingSource.Filter = string.Format("name like '*{0}*'  ", tsearchDP.Text);
                }
                else
                {
                    productsBindingSource.Filter = string.Empty;
                }

            }
        }
    }
}
