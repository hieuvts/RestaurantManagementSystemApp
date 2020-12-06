using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Product_DTO
    {
        public int ID_matHang { get; set; }
        public string TenSanPham { get; set; }
        public string DonViTinh { get; set; }
        public float GiaNhap { get; set; }
        public float GiaBan { get; set; }

        public Product_DTO(int ID_matHang, string TenSanPham, string DonViTinh, float GiaNhap, float GiaBan)
        {
            this.ID_matHang = ID_matHang;
            this.TenSanPham = TenSanPham;
            this.DonViTinh = DonViTinh;
            this.GiaNhap = GiaNhap;
            this.GiaBan = GiaBan;
        }
    }
}
