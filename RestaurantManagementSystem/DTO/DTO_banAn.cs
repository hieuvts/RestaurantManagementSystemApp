using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_banAn
    {
        public int IDbanAn { get; set; }
        public int soBanAn { get; set; }
        public int tinhTrang { get; set; }
        public Product_DTO(int IDbanAn, int soBanAn, int tinhTrang)
        {
            this.IDbanAnn = IDbanAn;
            this.soBanAn = soBanAn;
            this.tinhTrang = tinhTrang;
        }
    }
}
