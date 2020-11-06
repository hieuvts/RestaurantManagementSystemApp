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
    public partial class mainForm : Form
    {
        UserControl uc_dashboard = new UC_dashboard();
        UserControl uc_sale = new UC_sale();
        UserControl uc_warehouse = new UC_warehouse();

        public mainForm()
        {
            InitializeComponent();
            
        }

        private void pn_exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        private void pn_saleButton_Click(object sender, EventArgs e)
        {
            pn_switchableWndw.Controls.Clear();
            pn_switchableWndw.Controls.Add(uc_sale);
        }

        private void pn_dashboardButton_Click(object sender, EventArgs e)
        {
            pn_switchableWndw.Controls.Clear();
            pn_switchableWndw.Controls.Add(uc_dashboard);
        }

        private void pn_warehouseButton_Click(object sender, EventArgs e)
        {
            pn_switchableWndw.Controls.Clear();
            pn_switchableWndw.Controls.Add(uc_warehouse);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
