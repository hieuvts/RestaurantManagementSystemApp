using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class MainForm : Form
    {
        UserControl uc_dashboard = new UC_dashboard();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void pn_exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pn_saleButton_Click(object sender, EventArgs e)
        {

        }

        private void pn_dashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void pn_warehouseButton_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pn_switchableWndw.Controls.Add(uc_dashboard);
        }
    }
}
