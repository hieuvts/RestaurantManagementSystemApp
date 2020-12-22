using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_chiTietBanAn
    {
        DAL_chiTietBanAn chiTietBanAn_DAL;

        public BUS_chiTietBanAn()
        {
            chiTietBanAn_DAL = new DAL_chiTietBanAn();
        }
        public DataSet Get(int idbanan)
        {
            return chiTietBanAn_DAL.GetData(idbanan);
        }
        public void Insert(int idbanan,int idmonan,int soluong)
        {
            chiTietBanAn_DAL.InsertData(idbanan, idmonan, soluong);
        }
        public void UpdateCountWhenExist(int idbanan, int idmonan, int soluong)
        {
            chiTietBanAn_DAL.UpdateCountWhenExist(idbanan, idmonan, soluong);
        }
        public void Delete(int idbanan,int idmonan)
        {
            chiTietBanAn_DAL.Delete(idbanan, idmonan);
        }
    }
}
