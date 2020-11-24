using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (CheckIfPasswordCorrect())
            {
                this.Hide();  //Ẩn form Login
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không hợp lệ", "Đã có lỗi xảy ra", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool CheckIfPasswordCorrect()
        {
            string stored_password = "123";
            string entered_password = tb_password.Text.ToString();
            int result = string.Compare(stored_password, entered_password);

            if (result == 0)
                return true;
            else return false;
        }

    }
}
