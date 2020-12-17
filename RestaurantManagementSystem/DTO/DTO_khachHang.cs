using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_khachHang
    {
        public int IDkhachHang { get; set; }
        public string tenKhachHang { get; set; }
        public string gioiTinhKhachHang {get; set; }
        public string SDTkhachHang {get; set; }
        public string thoiGianVao {get; set; }
        public int IDbanAn {get; set; }
        public DTO_khachHang(int IDkhachHang, string tenKhachHang, string gioiTinhKhachHang, string SDTkhachHang, string thoiGianVao, int IDbanAn)
        {
           this.IDkhachHang = IDkhachHang;
           this.tenKhachHang = tenKhachHang;
           this.gioiTinhKhachHang = gioiTinhKhachHang;
           this.SDTkhachHang = SDTkhachHang;
           this.thoiGianVao = thoiGianVao;
           this.IDbanAn = IDbanAn;
        }
    }
}
