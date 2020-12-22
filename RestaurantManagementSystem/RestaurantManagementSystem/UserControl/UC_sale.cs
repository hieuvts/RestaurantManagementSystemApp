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
            pn_hoadon.Enabled = false;
            pn_monan.Enabled = false;
            panel3.Enabled = false;
            btn_delete.Enabled = false;
        }
        BUS_banAn banAn_BUS = new BUS_banAn();
        string status;
        List<DTO_banAn> listTable = new List<DTO_banAn>();
        BUS_chiTietBanAn chiTietBanAn_BUS = new BUS_chiTietBanAn();
        BUS_danhSachMonAn danhSachMonAn_BUS = new BUS_danhSachMonAn();
        float tongtien;
        int tableID;
        int monAnID;
        int count;
        int tempIDmonAN;
        int tempIDbanAN;
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
            pn_hoadon.Enabled = true;
            pn_monan.Enabled = true;
            panel3.Enabled = true;
            tableID = ((sender as Button).Tag as DTO_banAn).IDbanAn;
            Showdata(tableID);
            getTrangThaiBanAn();
            
        }

        public void Showdata(int tableid)
        {
            dgv_hoadon.DataSource = chiTietBanAn_BUS.Get(tableid).Tables[0];
            totalPrice();
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
            cbb_danhsachmonan.ValueMember = "IDmonAn";
        }
        public void getDanhMucMonAn()
        {
            cbb_danhmucmonan.DataSource = danhSachMonAn_BUS.GetDanhmuc().Tables[0];
            cbb_danhmucmonan.DisplayMember = "danhmuc";
        }
        public void themMonAnVaoBan()
        {
            monAnID = Convert.ToInt32(cbb_danhsachmonan.SelectedValue);
            count = int.Parse(nmr_soluongmonan.Value.ToString());
            if(count==0)
            {
                MessageBox.Show("Số lượng không thể bằng 0");
                return;
            }
            checkExistData(tableID, monAnID, count);
            //MessageBox.Show(cbb_danhsachmonan.SelectedValue.ToString());
            chiTietBanAn_BUS.Insert(tableID, monAnID, count);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            themMonAnVaoBan();
            Showdata(tableID);
        }
        public void checkExistData(int tableID, int monAnID, int count)
        {
            for(int i=0;i<dgv_hoadon.Rows.Count-1;i++)
            {
                if(tableID== Convert.ToInt32(dgv_hoadon.Rows[i].Cells[0].Value)&&
                    monAnID==Convert.ToInt32(dgv_hoadon.Rows[i].Cells[1].Value))
                {
                    chiTietBanAn_BUS.UpdateCountWhenExist(tableID, monAnID, count);
                    Showdata(tableID);
                }
            }
            return;
        }
        public void deleteData(int tableID, int monanID)
        {
            chiTietBanAn_BUS.Delete(tableID, monanID);
            Showdata(tableID);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteData(tempIDbanAN, tempIDmonAN);
        }

        private void dgv_hoadon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            try
            {
                if (numrow >= 0)
                {
                    tempIDbanAN = int.Parse(string.Copy(dgv_hoadon.Rows[numrow].Cells[0].Value.ToString()));
                    tempIDmonAN = int.Parse(string.Copy(dgv_hoadon.Rows[numrow].Cells[1].Value.ToString()));
                }
                btn_delete.Enabled = true;
            }
            catch(Exception)
            {

            }
        }
        private void getTrangThaiBanAn()
        {
            cbb_trangthai.DataSource= banAn_BUS.getTrangThai().Tables[0];
            cbb_trangthai.DisplayMember = "tinhTrang";
            
        }
    }
}
