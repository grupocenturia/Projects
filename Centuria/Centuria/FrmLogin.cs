using System;
using System.Windows.Forms;

namespace Centuria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void CmdEnter_Click(object sender, EventArgs e)
        {
            FxEnter();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            FxExit();
        }

        private void FxCancel()
        {
            Text = ClsVariables.gTitle;

            ClsVariables.gUserId = 0;
            ClsVariables.gUserName = "";

            TxtUserName.Text = "";
            TxtPassword.Text = "";
            
            CmdEnter.Enabled = true;

            TxtUserName.Focus();
        }

        private void FxEnter()
        {
            string lUserName = TxtUserName.Text.Trim();
            string lPassword = TxtPassword.Text.Trim();

            if (lUserName.Length == 0 || lPassword.Length == 0)
            {
                ClsFunctions.FxMessage(1, "Usuario y/o contraseña incorrectos");

                TxtUserName.Text = "";
                TxtPassword.Text = "";

                TxtUserName.Focus();

                return;
            }

            long lUserId = ClsSql.Fx_sel_tblUser_checkPassword(lUserName, lPassword);

            if (lUserId == 0)
            {
                ClsFunctions.FxMessage(1, "Usuario y/o contraseña incorrectos");

                TxtUserName.Text = "";
                TxtPassword.Text = "";

                TxtUserName.Focus();

                return;
            }

            if (lPassword == "centuria")
            {
                FrmChangePassword ObjForm = new FrmChangePassword();

                ObjForm.ShowDialog();

                if (ClsVariables.gPasswordChanged == false)
                {
                    ClsFunctions.FxMessage(1, "No es posible ingresar si no cambia su contraseña. Favor vuelva a intentar");

                    FxCancel();

                    return;
                }
            }

            if (ClsVariables.gPasswordExpiry > 0)
            {
                if (ClsVariables.gUserExpirationDate <= DateTime.Today)
                {
                    FrmChangePassword ObjForm = new FrmChangePassword();

                    ObjForm.ShowDialog();

                    if (ClsVariables.gPasswordChanged == false)
                    {
                        ClsFunctions.FxMessage(1, "No es posible ingresar si no cambia su contraseña. Favor vuelva a intentar");

                        FxCancel();

                        return;
                    }
                }
                else
                {
                    ClsFunctions.FxExpirationAlert();
                }
            }

            FxExit();
        }

        private void FxExit()
        {
            Close();
        }
    }
}
