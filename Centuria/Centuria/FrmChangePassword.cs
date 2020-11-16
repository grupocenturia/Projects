using System;
using System.Windows.Forms;

namespace Centuria
{
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtConfirm_Enter(object sender, EventArgs e)
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
            ClsVariables.gPasswordChanged = false;

            TxtUser.Text = ClsVariables.gUserName;
            TxtPassword.Text = "";
            TxtConfirm.Text = "";

            TxtPassword.Enabled = true;
            TxtConfirm.Enabled = true;

            CmdSave.Enabled = true;

            TxtPassword.Focus();
        }

        private void FxSave()
        {
            string lPassword = TxtPassword.Text.Trim();
            string lConfirm = TxtConfirm.Text.Trim();

            if (lPassword.Length == 0 || lConfirm.Length == 0 || lPassword != lConfirm)
            {
                ClsFunctions.FxMessage(1, "Ingrese contraseña");

                TxtPassword.Text = "";
                TxtConfirm.Text = "";

                TxtPassword.Focus();

                return;
            }

            bool lValidPassword = ClsFunctions.FxValidPassword(lPassword);

            if (lValidPassword == false)
            {
                TxtPassword.Text = "";
                TxtConfirm.Text = "";

                TxtPassword.Focus();

                return;
            }

            if (ClsFunctions.FxMessage(2, "¿Está seguro de cambiar la contraseña?") == true)
            {
                long lUserId = ClsSql.Fx_upt_tblUser_password(ClsVariables.gUserId, lPassword);

                if (lUserId == 0)
                {
                    ClsFunctions.FxMessage(1, "Contraseña no fue cambiada. Intente de nuevo");

                    TxtPassword.Focus();
                }
                else
                {
                    ClsVariables.gPasswordChanged = true;

                    ClsFunctions.FxMessage("Proceso concluido");

                    Close();
                }
            }
        }

        private void FxExit()
        {
            ClsVariables.gPasswordChanged = false;

            Close();
        }
    }
}
