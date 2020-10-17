using System;
using System.Windows.Forms;

namespace Centuria
{
    static class Centuria
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FrmSplashScreen());

            ClsFunctions.FxExit();
        }
    }
}
