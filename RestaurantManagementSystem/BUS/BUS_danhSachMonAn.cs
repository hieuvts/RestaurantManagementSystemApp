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
        public void Add(string tenmonan, float giamoan, int soluong, int iddanhmuc)
        {
            danhSachMonAn_DAL.InsertData(tenmonan,giamoan,soluong,iddanhmuc);
        }
        public void Delete(int idmonan)
        {
            danhSachMonAn_DAL.Delete(idmonan);
        }
        public void Update(int idmonan, string tenmonan, float giamoan, int soluong, int iddanhmuc)
        {
            danhSachMonAn_DAL.UpdateData(idmonan,tenmonan,giamoan,soluong,iddanhmuc);
        }
    }
}
