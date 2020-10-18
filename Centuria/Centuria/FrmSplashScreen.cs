using System;
using System.ComponentModel;
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

        private void BgwProcess_DoWork(object sender, DoWorkEventArgs e)
        {
            FxDoWork();
        }

        private void BgwProcess_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            FxProcessChanged(e.UserState.ToString());
        }

        private void BgwProcess_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FxCompleteWork();
        }

        private void FxCancel()
        {
            ImgSplashScreen.Enabled = true;

            LblMessage.Parent = ImgSplashScreen;
            LblMessage.BackColor = System.Drawing.Color.Transparent;

            LblMessage.Visible = true;

            BgwProcess.RunWorkerAsync();
        }

        private void FxDoWork()
        {
            BgwProcess.ReportProgress(0, "Inicializando sistema...");

            ClsFunctions.FxPause(2000);

            BgwProcess.ReportProgress(0, "Creando directorios de trabajo...");

            ClsFunctions.FxPause(100);

            ClsFunctions.FxCreateWorkingPath();

            FxUpdateFiles();

            BgwProcess.ReportProgress(0, "Bienvenido!!!");

            ClsFunctions.FxPause(1000);
        }

        private void FxUpdateFiles()
        {
            string[] lFilesSource;

            try
            {
                lFilesSource = ClsFunctions.FxGetFilesFromPath(ClsVariables.gPathBinSource);
            }
            catch
            {
                lFilesSource = null;
            }

            if (lFilesSource != null)
            {
                foreach (string lFileSource in lFilesSource)
                {
                    string lFileName = ClsFunctions.FxGetFileName(lFileSource);

                    BgwProcess.ReportProgress(0, "Verificando " + lFileName + "...");

                    ClsFunctions.FxPause(100);

                    ClsFunctions.FxUpdateFile(lFileSource, ClsVariables.gPathBin);
                }
            }
        }

        private void FxProcessChanged(string pText)
        {
            LblMessage.Text = pText;

            LblMessage.Refresh();
        }

        private void FxCompleteWork()
        {
            Hide();

            ImgSplashScreen.Enabled = false;

            FrmLogin ObjForm = new FrmLogin();

            ObjForm.ShowDialog();

            FxExit();
        }

        private void FxExit()
        {
            Close();
        }
    }
}
