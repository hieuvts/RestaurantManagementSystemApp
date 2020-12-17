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
        public DTO_banAn(int IDbanAn, int soBanAn, int tinhTrang)
        {
            this.IDbanAn = IDbanAn;
            this.soBanAn = soBanAn;
            this.tinhTrang = tinhTrang;
        }
    }
}
