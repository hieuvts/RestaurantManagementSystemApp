using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_danhMucMonAn
    {
        public int IDmonAn { get; set; }
        public string tenDanhMuc { get; set; }
        public DTO_danhMucMonAn(int IDmonAn, string tenDanhMuc)
        {
           this.IDmonAn = IDmonAn;
           this.tenDanhMuc = tenDanhMuc;
        }
    }
}
