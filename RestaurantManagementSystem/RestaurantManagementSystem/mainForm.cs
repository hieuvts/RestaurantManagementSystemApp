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

        private void mainForm_Load(object sender, EventArgs e)
        {
            pn_switchableWndw.Controls.Clear();
            pn_switchableWndw.Controls.Add(uc_dashboard);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(76, 120, 146);
            pn_switchableWndw.Controls.Clear();
            pn_switchableWndw.Controls.Add(uc_dashboard);

        }
        private void btnDashboard_MouseEnter(object sender, EventArgs e)
        {
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(76, 120, 146);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private void btnDashboard_MouseLeave(object sender, EventArgs e)
        {
            this.btnDashboard.BackColor = System.Drawing.Color.White;
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
        }

        private void btnSale_MouseEnter(object sender, EventArgs e)
        {
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(76, 120, 146);
            this.btnSale.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            pn_switchableWndw.Controls.Clear();
            pn_switchableWndw.Controls.Add(uc_sale);
        }

        private void btnSale_MouseLeave(object sender, EventArgs e)
        {
            this.btnSale.BackColor = System.Drawing.Color.White;
            this.btnSale.ForeColor = System.Drawing.Color.Black;
        }

        private void btnWarehouse_MouseEnter(object sender, EventArgs e)
        {
            this.btnWarehouse.BackColor = System.Drawing.Color.FromArgb(76, 120, 146);
            this.btnWarehouse.ForeColor = System.Drawing.Color.FromArgb(230, 230, 230);
        }

        private void btnWarehouse_MouseLeave(object sender, EventArgs e)
        {
            this.btnWarehouse.BackColor = System.Drawing.Color.White;
            this.btnWarehouse.ForeColor = System.Drawing.Color.Black;
        }
        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            pn_switchableWndw.Controls.Clear();
            pn_switchableWndw.Controls.Add(uc_warehouse);
        }
    }
}
