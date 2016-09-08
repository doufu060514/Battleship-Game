using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_Battleship
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BSContoller bsc = new BSContoller();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bsc.showViews();
            Application.Run();
        }
    }
}
