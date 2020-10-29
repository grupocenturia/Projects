using System;
using System.Windows.Forms;

namespace Centuria
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void FrmSettings_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void TxtServer_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            FxSave();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            FxExit();
        }

        private void FxCancel()
        {
            TxtServer.Text = ClsVariables.gServer;

            TxtServer.Enabled = true;

            CmdSave.Enabled = true;

            TxtServer.Focus();
        }

        private void FxSave()
        {
            string lServer = TxtServer.Text.Trim();

            if (lServer.Length == 0)
            {
                ClsFunctions.FxMessage(1, "Ingrese servidor");

                TxtServer.Text = "";

                TxtServer.Focus();

                return;
            }

            if (ClsFunctions.FxMessage(2, "¿Está seguro de guardar los cambios?") == true)
            {
                ClsFunctions.FxWriteJsonSettings(lServer);

                ClsFunctions.FxMessage("Proceso concluido");

                FxExit();
            }
        }

        private void FxExit()
        {
            Close();
        }
    }
}
