using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace RestaurantManagementSystem
{
    public partial class UC_dashboard : UserControl
    {
        public UC_dashboard()
        {
            InitializeComponent();
            showData();
            getTongDoanhThu();
        }
        BUS_hoaDon hoaDon_BUS = new BUS_hoaDon();
        float tongdoanhthu;
        public void showData()
        {
            dgv_danhsachhoadon.DataSource = hoaDon_BUS.GetData().Tables[0];
        }
        public void getTongDoanhThu()
        {
            tongdoanhthu = 0;
            for (int i = 0; i < dgv_danhsachhoadon.Rows.Count - 1; i++)
            {

                tongdoanhthu += float.Parse((dgv_danhsachhoadon.Rows[i].Cells[1].Value.ToString()));
            }
            txtb_tongdoanhthu.Text = tongdoanhthu.ToString();
        }

        private void UC_dashboard_Load(object sender, EventArgs e)
        {
            showData();
            getTongDoanhThu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_dashboard_Load(sender, e);
        }
    }
}
