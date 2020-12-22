using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace RestaurantManagementSystem
{
    public partial class UC_Sale : UserControl
    {
        public UC_Sale()
        {
            InitializeComponent();
            loadTable();
            getDanhSachMonAn();
            getDanhMucMonAn();
        }
        BUS_banAn banAn_BUS = new BUS_banAn();
        string status;
        List<DTO_banAn> listTable = new List<DTO_banAn>();
        BUS_chiTietBanAn chiTietBanAn_BUS = new BUS_chiTietBanAn();
        BUS_danhSachMonAn danhSachMonAn_BUS = new BUS_danhSachMonAn();
        float tongtien;
        //Hiển thị danh sách bàn ăn
        public void loadTable()
        {
            listTable = banAn_BUS.Get();
            foreach (DTO_banAn item in listTable)
            {
                Button banAn = new Button() { Width = 100, Height = 100 };
                banAn.Tag = item;
                switch (item.tinhTrang)
                {
                    case 1:
                        status = "Đang chờ món";
                        banAn.BackColor = Color.Aqua;
                        break;
                    case 2:
                        status = "Đang dùng";
                        banAn.BackColor = Color.Red;
                        break;
                    default:
                        status = "Trống";
                        banAn.BackColor = Color.Green;
                        break;
                }
                banAn.Text = item.soBanAn.ToString() + Environment.NewLine + status;
                banAn.Click += BanAn_Click;
                flp_danhSachBanAn.Controls.Add(banAn);
            }
        }
       
        private void BanAn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as DTO_banAn).IDbanAn;
            Showdata(tableID);

            totalPrice();
        }

        public void Showdata(int tableid)
        {
            dgv_hoadon.DataSource = chiTietBanAn_BUS.Get(tableid).Tables[0];
        }
        public void totalPrice()
        {
            tongtien = 0;
                for (int i = 0; i < dgv_hoadon.Rows.Count-1; i++)
                {

                    tongtien +=float.Parse((dgv_hoadon.Rows[i].Cells[4].Value.ToString()))
                    *float.Parse((dgv_hoadon.Rows[i].Cells[5].Value.ToString()));
                }
            txtb_tongtien.Text = tongtien.ToString();
        }

        public void getDanhSachMonAn()
        {
            cbb_danhsachmonan.DataSource = danhSachMonAn_BUS.Get().Tables[0];
            
            cbb_danhsachmonan.DisplayMember = "tenMonAn";
            
        }
        public void getDanhMucMonAn()
        {
            cbb_danhmucmonan.DataSource = danhSachMonAn_BUS.GetDanhmuc().Tables[0];
            cbb_danhmucmonan.DisplayMember = "danhmuc";
        }
    }
}
