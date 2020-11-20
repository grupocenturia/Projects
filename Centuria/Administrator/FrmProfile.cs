using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmProfile : Form
    { 
        DataTable ObjDt;

        public FrmProfile()
        {
            InitializeComponent();
        }

        private void FrmProfile_Load(object sender, EventArgs e)
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
           

            ObjDt = ClsSqlAdministrator.Fx_sel_tblProfile(false);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    GrdData.DataSource = ObjDt.DefaultView;

                    GrdData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    GrdData.Columns[2].Visible = false;

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
            long lProfileId;

            try
            {
                lProfileId = long.Parse(GrdData.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch
            {
                lProfileId = 0;
            }

            if (lProfileId == 0)
            {
                ClsFunctions.FxMessage(1, "Seleccione Perfil");

                GrdData.Focus();

                return;
            }

            FxFormDetail(lProfileId);
        }

        private void FxFormDetail(long pId)
        {
            FrmProfile_detail ObjForm = new FrmProfile_detail(pId);

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

