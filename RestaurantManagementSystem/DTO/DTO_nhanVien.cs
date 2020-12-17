using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_nhanVien
    {
        public int IDnhanVien { get; set; }
        public string tenNhanVien { get; set; }
        public string ngaySinhNhanVien {get; set; }
        public string gioiTinhNhanVien {get; set; }
        public string diaChiNhanVien {get; set; }
        public string SDTnhanVien {get; set; }
        public string ngayVaoLam {get; set; }
        public int viTriCongViec {get; set; }
        public DTO_nhanVien(int IDnhanVien, string tenNhanVien, string ngaySinhNhanVien, string gioiTinhNhanVien, string diaChiNhanVien, string SDTnhanVien, string ngayVaoLam, int viTriCongViec)
        {
           this.IDnhanVien = IDnhanVien;
           this.tenNhanVien = tenNhanVien;
           this.gioiTinhNhanVien = gioiTinhNhanVien;
           this.ngaySinhNhanVien = ngaySinhNhanVien;
           this.diaChiNhanVien = diaChiNhanVien;
           this.SDTnhanVien = SDTnhanVien;
           this.ngayVaoLam = ngayVaoLam;
           this.viTriCongViec = viTriCongViec;
        }
    }
}
