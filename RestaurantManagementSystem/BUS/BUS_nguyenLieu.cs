using System;
using System.Collections.Generic;
using System.Data;
using DAL;
using DTO;

namespace BUS
{
   public class BUS_NguyenLieu
    {

        DAL_nguyenLieu nguyenLieu_DAL;

        public BUS_NguyenLieu()
        {
            nguyenLieu_DAL = new DAL_nguyenLieu();
        }
        public DataSet Get()
        {
            return nguyenLieu_DAL.GetData();
        }
        public void Add(string tennguyenlieu,int soLuong)
        {
            nguyenLieu_DAL.InsertData(tennguyenlieu,soLuong);
        }
        public void Delete(int IDnguyenLieu)
        {
            nguyenLieu_DAL.Delete(IDnguyenLieu);
        }
        public void Update(int IDnguyenLieu, string tenNguyenLieu, int soLuong)
        {
            nguyenLieu_DAL.UpdateData(IDnguyenLieu, tenNguyenLieu,soLuong);
        }
    }
}
