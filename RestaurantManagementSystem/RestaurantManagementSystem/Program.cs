using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DialogResult result;
            //using (var loginForm = new loginForm())
            //    result = loginForm.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    //Nếu loginForm trả về dialogResult OK thì mở mainForm
            //    Application.Run(new mainForm());
            //}
            //else
            //{
            //    //
            //}    
            Application.Run(new mainForm());
        }
    }
}
