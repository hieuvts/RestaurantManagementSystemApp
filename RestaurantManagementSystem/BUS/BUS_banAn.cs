using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BUS
{
    public class BUS_banAn
    {
        banAn_DAL banAn_DAL = new banAn_DAL();
        List<DTO_banAn> listable = new List<DTO_banAn>();
        
        public List<DTO_banAn> Get()
        {
            listable = banAn_DAL.GET();
            return listable;
        }
        public DataSet getDataByIDBanAN(int idbanan)
        {
            return banAn_DAL.GetDataByIDbanAN(idbanan);
        }
        public DataSet getTrangThai()
        {
            return banAn_DAL.GetTrangThai();
        }
    }
}
