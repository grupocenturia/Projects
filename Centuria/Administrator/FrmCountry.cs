using Core;
using System;
using System.Data;
using System.Windows.Forms;

namespace Administrator
{
    public partial class FrmCountry : Form
    {
        DataTable ObjDt;

        public FrmCountry()
        {
            InitializeComponent();
        }

        private void FrmCountry_Load(object sender, EventArgs e)
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

            ObjDt = ClsSqlCore.Fx_sel_tblCountry(false);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    GrdData.DataSource = ObjDt.DefaultView;

                    GrdData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    GrdData.Columns[0].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    GrdData.Columns[3].Visible = false;

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
            long lCountryId;

            try
            {
                lCountryId = long.Parse(GrdData.SelectedRows[0].Cells[3].Value.ToString());
            }
            catch
            {
                lCountryId = 0;
            }

            if (lCountryId == 0)
            {
                ClsFunctions.FxMessage(1, "Seleccione país");

                GrdData.Focus();

                return;
            }

            FxFormDetail(lCountryId);
        }

        private void FxFormDetail(long pId)
        {
            FrmCountry_detail ObjForm = new FrmCountry_detail(pId);

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
