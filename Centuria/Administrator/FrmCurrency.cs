using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmCurrency : Form
    {
        DataTable ObjDt;

        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            FxNew();
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            FxEdit();
        }

        private void CmdExit_Click(object sender, EventArgs e)
        {
            FxExit();
        }

        private void FxCancel()
        {
            ObjDt = null;

            GrdData.DataSource = null;

            GrdData.Enabled = false;

            CmdNew.Enabled = true;
            CmdEdit.Enabled = false;

            FxData();
        }

        private void FxData()
        {
            ObjDt = null;

            GrdData.DataSource = null;

            GrdData.Enabled = false;

            CmdEdit.Enabled = false;

            ObjDt = ClsSqlCore.Fx_sel_tblCurrency(false);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    GrdData.DataSource = ObjDt.DefaultView;

                    GrdData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    GrdData.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    GrdData.Columns[4].Visible = false;

                    GrdData.Enabled = true;

                    CmdEdit.Enabled = true;

                    GrdData.Focus();
                }
            }
        }

        private void FxNew()
        {
            FxFormDetail(0);
        }

        private void FxEdit()
        {
            long lCurrencyId;

            try
            {
                lCurrencyId = long.Parse(GrdData.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch
            {
                lCurrencyId = 0;
            }

            if (lCurrencyId == 0)
            {
                ClsFunctions.FxMessage(1, "Seleccione moneda");

                GrdData.Focus();

                return;
            }

            FxFormDetail(lCurrencyId);
        }

        private void FxFormDetail(long pId)
        {
            FrmCurrency_detail ObjForm = new FrmCurrency_detail(pId);

            ObjForm.ShowDialog();

            FxCancel();
        }


        private void FxExit()
        {
            ObjDt = null;

            GrdData.DataSource = null;

            Close();
        }

    }
}
