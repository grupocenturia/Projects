using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmUser_detail : Form
    {
        readonly long lUserId;

        public FrmUser_detail(long pUserId)
        {
            lUserId = pUserId;

            InitializeComponent();
        }

        private void FrmUser_detail_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
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
            TxtName.Text = "";
            TxtUserName.Text = "";

            ChkEnabled.Checked = false;

            TxtName.Enabled = false;
            TxtUserName.Enabled = false;

            ChkEnabled.Enabled = false;

            CmdSave.Enabled = false;

            if (lUserId == 0)
            {
                Text += " - Adicionar";

                TxtName.Enabled = true;
                TxtUserName.Enabled = true;

                ChkEnabled.Checked = true;

                CmdSave.Enabled = true;

                TxtName.Focus();
            }
            else
            {
                Text += " - Modificar";

                DataTable ObjDt = ClsSqlAdministrator.Fx_sel_tblUser_detail(lUserId);

                if (ObjDt != null)
                {
                    if (ObjDt.Rows.Count > 0)
                    {
                        TxtName.Text = ObjDt.Rows[0][0].ToString();
                        TxtUserName.Text = ObjDt.Rows[0][1].ToString();

                        ChkEnabled.Checked = ClsFunctions.FxConvertStringToBool(ObjDt.Rows[0][2].ToString());

                        TxtName.Enabled = true;
                        TxtUserName.Enabled = true;

                        ChkEnabled.Enabled = true;

                        CmdSave.Enabled = true;

                        TxtName.Focus();
                    }
                }
            }
        }

        private void FxSave()
        {
            string lName = TxtName.Text.Trim();
            string lUserName = TxtUserName.Text.Trim();

            bool lEnabled = ChkEnabled.Checked;

            if (lName.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese nombre");

                TxtName.Text = "";

                TxtName.Focus();

                return;
            }

            if (lUserName.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese usuario");

                TxtUserName.Text = "";

                TxtUserName.Focus();

                return;
            }

            if (ClsFunctions.FxMessage(2, "¿Está seguro de guardar los cambios?") == true)
            {
                long lUserId_new;

                if (lUserId == 0)
                {
                    lUserId_new = ClsSqlAdministrator.Fx_ins_tblUser(lName, lUserName);
                }
                else
                {
                    lUserId_new = ClsSqlAdministrator.Fx_upt_tblUser(lUserId, lName, lUserName, lEnabled);
                }

                if (lUserId_new > 0)
                {
                    FxExit();
                }
            }
        }

        private void FxExit()
        {
            Close();
        }
    }
}
