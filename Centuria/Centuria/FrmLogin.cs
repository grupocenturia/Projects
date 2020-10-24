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

            FrmMainMenu ObjFrm = new FrmMainMenu();

            Hide();

            ObjFrm.ShowDialog();

            FxExit();
        }

        private void FxExit()
        {
            Close();
        }
    }
}
