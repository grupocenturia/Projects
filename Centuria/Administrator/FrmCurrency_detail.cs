using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmCurrency_detail : Form
    {
        readonly long lCurrencyId;

        public FrmCurrency_detail(long pCurrencyId)
        {
            lCurrencyId = pCurrencyId;

            InitializeComponent();
        }

        private void FrmCurrency_detail_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtIsoCode_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtSymbol_Enter(object sender, EventArgs e)
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
            TxtSymbol.Text = "";

            ChkEnabled.Checked = false;

            TxtName.Enabled = false;
            TxtIsoCode.Enabled = false;
            TxtSymbol.Enabled = false;

            ChkEnabled.Enabled = false;

            CmdSave.Enabled = false;

            if (lCurrencyId == 0)
            {
                Text += " - Adicionar";

                TxtName.Enabled = true;
                TxtIsoCode.Enabled = true;
                TxtSymbol.Enabled = true;

                ChkEnabled.Checked = true;

                CmdSave.Enabled = true;

                TxtName.Focus();
            }
            else
            {
                Text += " - Modificar";

                DataTable ObjDt = ClsSqlCore.Fx_sel_tblCurrency_detail(lCurrencyId);

                if (ObjDt != null)
                {
                    if (ObjDt.Rows.Count > 0)
                    {
                        TxtName.Text = ObjDt.Rows[0][0].ToString();
                        TxtIsoCode.Text = ObjDt.Rows[0][2].ToString();
                        TxtSymbol.Text = ObjDt.Rows[0][3].ToString();

                        ChkEnabled.Checked = ClsFunctions.FxConvertStringToBool(ObjDt.Rows[0][1].ToString());

                        TxtName.Enabled = true;
                        TxtIsoCode.Enabled = true;
                        TxtSymbol.Enabled = true;

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
            string lSymbol = TxtSymbol.Text.Trim();

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

            if (lSymbol.Length < 1)
            {
                ClsFunctions.FxMessage(1, "Ingrese símbolo");

                TxtSymbol.Text = "";

                TxtSymbol.Focus();

                return;
            }

            if (ClsFunctions.FxMessage(2, "¿Está seguro de guardar los cambios?") == true)
            {
                long lCurrencyId_new;

                if (lCurrencyId == 0)
                {
                    lCurrencyId_new = ClsSqlCore.Fx_ins_tblCurrency(lName, lIsoCode, lSymbol);
                }
                else
                {
                    lCurrencyId_new = ClsSqlCore.Fx_upt_tblCurrency(lCurrencyId, lName, lIsoCode, lSymbol, lEnabled);
                }

                if (lCurrencyId_new > 0)
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
