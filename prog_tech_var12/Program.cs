using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace prog_tech_var12
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //init start conditions
            utils.Globals.glob_canDraw = false;
            utils.Globals.glob_graphType = 255;
            //
            Application.Run(new f_main());
        }
    }
}
