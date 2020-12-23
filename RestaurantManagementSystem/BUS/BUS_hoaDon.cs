using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_hoaDon
    {
        DAL_hoaDon hoaDon_DAL = new DAL_hoaDon();
        public DataSet GetData()
        {
            return hoaDon_DAL.GetData();
        }
        public void InsertData(float giatri, DateTime ngaylaphoadon)
        {
            hoaDon_DAL.InsertData(giatri, ngaylaphoadon);
        }
       
    }
}
