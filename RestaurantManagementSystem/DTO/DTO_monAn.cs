using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_monAn
    {
        public int IDmonAn { get; set; }
        public string tenMonAn { get; set; }
        public string giaMonAn { get; set; }
        public int IDdanhMuc { get; set; }
        public Product_DTO(int IDmonAn, string tenMonAn, float giaMonAn, int IDdanhMuc)
        {
            this.IDmonAn = IDmonAn;
            this.tenMonAn = tenMonAn;
            this.giaMonAn = giaMonAn;
            this.IDdanhMuc = IDdanhMuc;
        }
    }
}
