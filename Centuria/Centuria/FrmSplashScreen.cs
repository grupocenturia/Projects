using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Centuria
{
    public partial class FrmSplashScreen : Form
    {
        bool lSettings = false;

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

            Color ObjColor = Color.FromArgb(100, Color.Black);

            LblMessage.BackColor = ObjColor;

            LblMessage.Visible = true;

            BgwProcess.RunWorkerAsync();
        }

        private void FxDoWork()
        {
            if (lSettings == false)
            {
                BgwProcess.ReportProgress(0, "Inicializando sistema...");

                ClsFunctions.FxPause(1);

                BgwProcess.ReportProgress(0, "Creando directorios de trabajo...");

                ClsFunctions.FxPause(0.1);

                ClsFunctions.FxCreateWorkingPath();

                BgwProcess.ReportProgress(0, "Obteniendo configuración...");

                ClsFunctions.FxPause(0.1);

                lSettings = ClsFunctions.FxGetSettings();
            }

            if (lSettings == true)
            {
                FxUpdateFiles();

                BgwProcess.ReportProgress(0, "Bienvenido!!!");

                ClsFunctions.FxPause(1);
            }
        }

        private void FxUpdateFiles()
        {
            string[] lFilesSource;

            try
            {
                lFilesSource = ClsFunctions.FxGetFilesFromPath(ClsVariables.gPathUpdate);
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

                    ClsFunctions.FxPause(0.1);

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
            if (lSettings == false)
            {
                FrmSettings ObjForm = new FrmSettings();

                ObjForm.ShowDialog();

                lSettings = ClsFunctions.FxGetSettings();

                if (lSettings == false)
                {
                    ClsFunctions.FxMessage(1, "No se ha realizado la configuración inicial");

                    FxExit();
                }
                else
                {
                    FxCancel();
                }
            }
            else
            {
                FxEnter();
            }
        }

        private void FxEnter()
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
