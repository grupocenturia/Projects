using System;
using System.Windows.Forms;

namespace Centuria
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            FxCancel();
        }
        private void TmrExit_Tick(object sender, EventArgs e)
        {
            FxExit();
        }

        private void FxCancel()
        {
            ImgSplashScreen.Enabled = true;

            ClsFunctions.FxCreateWorkingPath();

            TmrExit.Enabled = true;
        }

        private void FxExit()
        {
            TmrExit.Enabled = false;

            FrmLogin ObjForm = new FrmLogin();

            Hide();

            ImgSplashScreen.Enabled = false;

            ObjForm.ShowDialog();

            Close();
        }
    }
}
