using BikeShop.Forms;
using BikeShop.Helpers;
using System.Linq;

namespace BikeShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
 
            ApplicationConfiguration.Initialize();

            using (var login = new frmlogin())
            {
                if (login.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new frmMainMenu());
                }
            }

            //Application.Run(new frmMainMenu());
            //Application.Run(new Error());
            //Application.Run(new frmErrorDetails());
            //Application.Run(new frmReport());
            //Application.Run(new frmCustomerMaintenance());
            //Application.Run(new frmReceipt());
            //Application.Run(new frmNewSale());
            //Application.Run(new frmProductMaintenance());
        }
    }
}