using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmAction : Form
    {
        DataTable ObjDt;

        public FrmAction()
        {
            InitializeComponent();
        }

        private void FrmAction_Load(object sender, EventArgs e)
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


            ObjDt = ClsSqlAdministrator.Fx_sel_tblAction(false);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    GrdData.DataSource = ObjDt.DefaultView;

                    GrdData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    GrdData.Columns[2].Visible = false;

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
            long lActionId;

            try
            {
                lActionId = long.Parse(GrdData.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch
            {
                lActionId = 0;
            }

            if (lActionId == 0)
            {
                ClsFunctions.FxMessage(1, "Seleccione Evento");

                GrdData.Focus();

                return;
            }

            FxFormDetail(lActionId);
        }

        private void FxFormDetail(long pId)
        {
            FrmAction_detail ObjForm = new FrmAction_detail(pId);

            ObjForm.ShowDialog();

            FxCancel();
        }



        private void FxExit()
        {
            ObjDt = null;

            GrdData.DataSource = null;

            Close();
        }

        private void GrdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
