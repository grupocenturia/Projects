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

        private void CmdPathUpdateBrowse_Click(object sender, EventArgs e)
        {
            FxPathUpdateBrowse();
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
            TxtPathUpdate.Text = ClsVariables.gPathUpdate;

            TxtServer.Enabled = true;

            CmdPathUpdateBrowse.Enabled = true;
            CmdSave.Enabled = true;

            TxtServer.Focus();
        }

        private void FxPathUpdateBrowse()
        {
            string lPathUpdate = ClsFunctions.FxSelectPath();

            TxtPathUpdate.Text = lPathUpdate;
        }

        private void FxSave()
        {
            string lServer = TxtServer.Text.Trim();
            string lPathUpdate = TxtPathUpdate.Text.Trim();

            if (lServer.Length == 0)
            {
                ClsFunctions.FxMessage(1, "Ingrese servidor");

                TxtServer.Text = "";

                TxtServer.Focus();

                return;
            }

            if (ClsFunctions.FxCheckPath(lPathUpdate) == false)
            {
                ClsFunctions.FxMessage(1, "Carpeta de actualización no existe");

                TxtPathUpdate.Text = "";

                CmdPathUpdateBrowse.Focus();

                return;
            }

            if (ClsFunctions.FxMessage(2, "¿Está seguro de guardar los cambios?") == true)
            {
                ClsFunctions.FxWriteJsonSettings(lServer, lPathUpdate);

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
