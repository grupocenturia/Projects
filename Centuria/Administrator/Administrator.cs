using System;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    static class Administrator
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ClsFunctions.FxMessage(1, "Acceso denegado");
            }
            else
            {
                ClsFunctions.FxGetParametersFromCore(args[0]);

                if (ClsVariables.gUserId == 0)
                {
                    ClsFunctions.FxMessage(1, "Acceso denegado");
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    Application.Run(new FrmMainMenu());
                }
            }
        }
    }
}
