using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmCompany_detail : Form
    {
        readonly long lCompanyId;

        public FrmCompany_detail(long pCompanyId)
        {
            lCompanyId = pCompanyId;

            InitializeComponent();
        }

        private void FrmCompany_detail_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtTradeName_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);

        }

        private void TxtShortName_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtDBName_Enter(object sender, EventArgs e)
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
            TxtTradeName.Text = "";
            TxtShortName.Text = "";
            TxtDBName.Text = "";

            ChkEnabled.Checked = false;

            TxtName.Enabled = false;
            TxtTradeName.Enabled = false;
            TxtShortName.Enabled = false;
            TxtDBName.Enabled = false;

            ChkEnabled.Enabled = false;

            CmdSave.Enabled = false;

            if (lCompanyId == 0)
            {
                Text += " - Adicionar";

                TxtName.Enabled = true;
                TxtTradeName.Enabled = true;
                TxtShortName.Enabled = true;
                TxtDBName.Enabled = true;

                ChkEnabled.Checked = true;

                CmdSave.Enabled = true;

                TxtName.Focus();
            }
            else
            {
                Text += " - Modificar";

                DataTable ObjDt = ClsSqlAdministrator.Fx_sel_tblCompany_detail( lCompanyId);

                if (ObjDt != null)
                {
                    if (ObjDt.Rows.Count > 0)
                    {
                        TxtName.Text = ObjDt.Rows[0][0].ToString();
                        TxtTradeName.Text = ObjDt.Rows[0][1].ToString();
                        TxtShortName.Text = ObjDt.Rows[0][2].ToString();
                        TxtDBName.Text = ObjDt.Rows[0][3].ToString();

                        ChkEnabled.Checked = ClsFunctions.FxConvertStringToBool(ObjDt.Rows[0][4].ToString());

                        TxtName.Enabled = true;
                        TxtTradeName.Enabled = true;
                        TxtShortName.Enabled = true;
                        TxtDBName.Enabled = true;

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
            string lTradeName = TxtTradeName.Text.Trim();
            string lShortName = TxtShortName.Text.Trim();
            string lDBName = TxtDBName.Text.Trim();

            bool lEnabled = ChkEnabled.Checked;

            if (lName.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese nombre de compañia");

                TxtName.Text = "";

                TxtName.Focus();

                return;
            }

            if (lTradeName.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese nombre de comercio");

                TxtTradeName.Text = "";

                TxtTradeName.Focus();

                return;
            }

            if (lShortName.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese nombre corto");

                TxtShortName.Text = "";

                TxtShortName.Focus();

                return;
            }

            if (lDBName.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese Base de datos");

                TxtDBName.Text = "";

                TxtDBName.Focus();

                return;
            }

            if (ClsFunctions.FxMessage(2, "¿Está seguro de guardar los cambios?") == true)
            {
                long lCompanyId_new;

                if (lCompanyId == 0)
                {
                    lCompanyId_new = ClsSqlAdministrator.Fx_ins_tblCompany(lName, lTradeName, lShortName, lDBName);
                }
                else
                {
                    lCompanyId_new = ClsSqlAdministrator.Fx_upt_tblCompany(lCompanyId, lName, lTradeName, lShortName, lDBName, lEnabled);
                }

                if (lCompanyId_new > 0)
                {
                    FxExit();
                }
            }
        }

        private void FxExit()
        {
            Close();
        }

        private void ChkEnabled_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
