using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject_CoffeeShop.Interface;
using FinalProject_CoffeeShop.Query_Interface;

namespace FinalProject_CoffeeShop
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Database_Menu());

        }
    }
}
