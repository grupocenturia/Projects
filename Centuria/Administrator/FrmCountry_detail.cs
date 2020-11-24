using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmCountry_detail : Form
    {
        readonly long lCountryId;

        public FrmCountry_detail(long pCountryId)
        {
            lCountryId = pCountryId;

            InitializeComponent();
        }

        private void FrmCountry_detail_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtCountryName_Enter(object sender, EventArgs e)
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
            TxtIsoCode.Text = "";

            ChkEnabled.Checked = false;

            TxtName.Enabled = false;
            TxtIsoCode.Enabled = false;

            ChkEnabled.Enabled = false;

            CmdSave.Enabled = false;

            if (lCountryId == 0)
            {
                Text += " - Adicionar";

                TxtName.Enabled = true;
                TxtIsoCode.Enabled = true;

                ChkEnabled.Checked = true;

                CmdSave.Enabled = true;

                TxtName.Focus();
            }
            else
            {
                Text += " - Modificar";

                DataTable ObjDt = ClsSqlCore.Fx_sel_tblCountry_detail(lCountryId);

                if (ObjDt != null)
                {
                    if (ObjDt.Rows.Count > 0)
                    {
                        TxtName.Text = ObjDt.Rows[0][0].ToString();
                        TxtIsoCode.Text = ObjDt.Rows[0][1].ToString();

                        ChkEnabled.Checked = ClsFunctions.FxConvertStringToBool(ObjDt.Rows[0][2].ToString());

                        TxtName.Enabled = true;
                        TxtIsoCode.Enabled = true;

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
            string lIsoCode = TxtIsoCode.Text.Trim();

            bool lEnabled = ChkEnabled.Checked;

            if (lName.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese nombre");

                TxtName.Text = "";

                TxtName.Focus();

                return;
            }

            if (lIsoCode.Length < 2)
            {
                ClsFunctions.FxMessage(1, "Ingrese código");

                TxtIsoCode.Text = "";

                TxtIsoCode.Focus();

                return;
            }

            if (ClsFunctions.FxMessage(2, "¿Está seguro de guardar los cambios?") == true)
            {
                long lCountryId_new;

                if (lCountryId == 0)
                {
                    lCountryId_new = ClsSqlCore.Fx_ins_tblCountry(lName, lIsoCode);
                }
                else
                {
                    lCountryId_new = ClsSqlCore.Fx_upt_tblCountry(lCountryId, lName, lIsoCode, lEnabled);
                }

                if (lCountryId_new > 0)
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
