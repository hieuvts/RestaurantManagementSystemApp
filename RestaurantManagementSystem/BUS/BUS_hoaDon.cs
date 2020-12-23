using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_hoaDon
    {
        DAL_hoaDon hoaDon_DAL = new DAL_hoaDon();
        public void InsertData(float giatri, DateTime ngaylaphoadon)
        {
            hoaDon_DAL.InsertData(giatri, ngaylaphoadon);
        }
    }
}
