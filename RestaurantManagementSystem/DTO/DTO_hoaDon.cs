using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_hoaDon
    {
        public int ID_hoaDon { get; set; }
        public int IDbanAn { get; set; }
        public string dateCheckIn  { get; set; }
        public string dateCheckOut   { get; set; }
        public float totalPrice { get; set; }
        public float discount { get; set; }
        public DTO_hoaDon(int IDmonAn, int IDbanAn, string dateCheckIn, string dateCheckOut, float totalPrice, float discount)
        {
            this.ID_hoaDon = ID_hoaDon;
            this.IDbanAn = IDbanAn;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.totalPrice = totalPrice;
            this.discount = discount;
        }
    }
}
