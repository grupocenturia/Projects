using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmUser : Form
    {
        DataTable ObjDt;

        public FrmUser()
        {
            InitializeComponent();
        }

        private void FrmUser_Load(object sender, EventArgs e)
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

        private void CmdReset_Click(object sender, EventArgs e)
        {
            FxReset();
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
            CmdReset.Enabled = false;

            FxData();
        }

        private void FxData()
        {
            ObjDt = null;

            GrdData.DataSource = null;

            GrdData.Enabled = false;

            CmdEdit.Enabled = false;
            CmdReset.Enabled = false;

            ObjDt = ClsSqlAdministrator.Fx_sel_tblUser(false);

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
                    CmdReset.Enabled = true;

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
            long lUserId;

            try
            {
                lUserId = long.Parse(GrdData.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch
            {
                lUserId = 0;
            }

            if (lUserId == 0)
            {
                ClsFunctions.FxMessage(1, "Seleccione usuario");

                GrdData.Focus();

                return;
            }

            FxFormDetail(lUserId);
        }

        private void FxFormDetail(long pId)
        {
            FrmUser_detail ObjForm = new FrmUser_detail(pId);

            ObjForm.ShowDialog();

            FxCancel();
        }

        private void FxReset()
        {
            long lUserId;

            try
            {
                lUserId = long.Parse(GrdData.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch
            {
                lUserId = 0;
            }

            if (lUserId == 0)
            {
                ClsFunctions.FxMessage(1, "Seleccione usuario");

                GrdData.Focus();

                return;
            }

            if (ClsFunctions.FxMessage(2, "¿Está seguro de restablecer la constraseña?") == true)
            {
                long lUserId_new = ClsSqlAdministrator.Fx_upt_tblUser_resetPassword(lUserId);

                if (lUserId_new == 0)
                {
                    ClsFunctions.FxMessage(1, "Contraseña no fue restablecida. Intente de nuevo");
                }
                else
                {
                    ClsFunctions.FxMessage("Contraseña fue restablecida satisfactoriamente");

                    FxCancel();
                }
            }
        }

        private void FxExit()
        {
            ObjDt = null;

            GrdData.DataSource = null;

            Close();
        }
    }
}
