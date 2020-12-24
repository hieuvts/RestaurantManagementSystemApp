using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
   public class BUS_danhSachMonAn
    {
        DAL_danhSachMonAn danhSachMonAn_DAL;

        public BUS_danhSachMonAn()
        {
            danhSachMonAn_DAL = new DAL_danhSachMonAn();
        }
        public DataSet Get()
        {
            return danhSachMonAn_DAL.GetData();
        }
        public DataSet GetDanhmuc()
        {
            return danhSachMonAn_DAL.GetDanhmuc();
        }
        public void Add(string tenmonan,string danhmuc, float giamoan)
        {
            danhSachMonAn_DAL.InsertData(tenmonan,danhmuc, giamoan);
        }
        public void Delete(int idmonan)
        {
            danhSachMonAn_DAL.Delete(idmonan);
        }
        public void Update(int idmonan, string tenmonan, string danhmuc, float giamonan)
        {
            danhSachMonAn_DAL.UpdateData(idmonan,tenmonan,danhmuc,giamonan);
        }
        public DataSet getMonAnByDanhMuc(string danhmuc)
        {
            return danhSachMonAn_DAL.GetMonAnByDanhMuc(danhmuc);
        }
    }
}
