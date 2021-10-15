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
    public partial class Form1 : Form
    {
        settingcaisse settingcaisse = new settingcaisse();
        dashboard dashboad = new dashboard();
        tresure tresure ;
        about about = new about();
        settings settings = new settings();
        billclient billclient;
        billproviders billprovider ;
        history history=new history();
        products product = new products();
        providers provider = new providers();
        clients client = new clients();
        worker worker = new worker();

        public Form1()
        {
            InitializeComponent();
            billclient = new billclient(this);
            billprovider = new billproviders(this);
            tresure = new tresure(this);
        }
        

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            dashboad.TopLevel = false;
            dashboad.refresh();
            panel1.Controls.Add(dashboad);
            dashboad.Show();
        }

        private void btnclients_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            client.TopLevel = false;
            panel1.Controls.Add(client);
            
            client.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            dashboad.TopLevel = false;
            panel1.Controls.Add(dashboad);
            dashboad.Show();
        }

        private void btnproviders_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            provider.TopLevel = false;
            panel1.Controls.Add(provider);
            provider.Show();
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            product.TopLevel = false;
            product.refresh();
            panel1.Controls.Add(product);
            product.Show();
        }
        public void loadbillclient() {

            panel1.Controls.Clear();
            billclient.TopLevel = false;
            billclient.refersh();
            panel1.Controls.Add(billclient);
            billclient.Show();
        }
        private void btnbillclients_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            billclient.TopLevel = false;
            billclient.refersh();
            panel1.Controls.Add(billclient);
            billclient.Show();
        }

        private void btnhistory_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            history.TopLevel = false;
            history.refresh();
            panel1.Controls.Add(history);
            history.Show();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            settings.TopLevel = false;
            panel1.Controls.Add(settings);
            settings.Show();
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            about.TopLevel = false;
            panel1.Controls.Add(about);
            about.Show();
        }

        private void btnbillproviders_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            billprovider.TopLevel = false;
            billprovider.refersh();
            panel1.Controls.Add(billprovider);
            billprovider.Show();
        }


        public void showmain() {
            this.Enabled = true;
            this.Show();
            this.Focus();
        }

        private void btnworker_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            worker.TopLevel = false;
            worker.refresh();
            panel1.Controls.Add(worker);
            worker.Show();
        }

        private void btntresure_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            tresure.TopLevel = false;
            tresure.refresh();
            panel1.Controls.Add(tresure);
            tresure.Show();
        }
        public void settingscaisse() {
            panel1.Controls.Clear();
            settingcaisse.TopLevel = false;
           // tresure.refresh();
            panel1.Controls.Add(settingcaisse);
            settingcaisse.Show();
        }
    }
}
