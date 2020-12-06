using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ACCOUNT
    {
        public int accountID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string accountType { get; set; }
        public int IDnhanVien { get; set; }
        public Product_DTO(int accountID, string userName, string password, string accountType, int IDnhanVien)
        {
            this.accountID = accountID;
            this.userName = userName;
            this.password = password;
            this.accountType = accountType;
            this.IDnhanVien = IDnhanVien;
        }
    }
}
