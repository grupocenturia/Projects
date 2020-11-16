using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmModule : Form
    {
        DataTable ObjDt;

        public FrmModule()
        {
            InitializeComponent();
        }

        private void FrmModule_Load(object sender, EventArgs e)
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

            ObjDt = ClsSqlAdministrator.Fx_sel_tblModule(false);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    GrdData.DataSource = ObjDt.DefaultView;

                    GrdData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    GrdData.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                    GrdData.Columns[4].Visible = false;

                    GrdData.Enabled = true;

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
            long lModuleId;

            try
            {
                lModuleId = long.Parse(GrdData.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch
            {
                lModuleId = 0;
            }

            if (lModuleId == 0)
            {
                ClsFunctions.FxMessage(1, "Seleccione módulo");

                GrdData.Focus();

                return;
            }

            FxFormDetail(lModuleId);
        }

        private void FxFormDetail(long pId)
        {
            FrmModule_detail ObjForm = new FrmModule_detail(pId);

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
