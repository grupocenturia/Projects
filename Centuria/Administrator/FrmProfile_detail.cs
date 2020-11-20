using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmProfile_detail : Form
    {
        readonly long lProfileId;

        public FrmProfile_detail(long pProfileId)
        {
            lProfileId = pProfileId;

            InitializeComponent();
        }

        private void FrmProfile_detail_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void TxtName_Enter(object sender, EventArgs e)
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
           

            ChkEnabled.Checked = false;

            TxtName.Enabled = false;
           

            ChkEnabled.Enabled = false;

            CmdSave.Enabled = false;

            if (lProfileId == 0)
            {
                Text += " - Adicionar";

                TxtName.Enabled = true;
              

                ChkEnabled.Checked = true;

                CmdSave.Enabled = true;

                TxtName.Focus();
            }
            else
            {
                Text += " - Modificar";

                DataTable ObjDt = ClsSqlAdministrator.Fx_sel_tblProfile_detail(lProfileId);

                if (ObjDt != null)
                {
                    if (ObjDt.Rows.Count > 0)
                    {
                        TxtName.Text = ObjDt.Rows[0][0].ToString();
                      

                        ChkEnabled.Checked = ClsFunctions.FxConvertStringToBool(ObjDt.Rows[0][1].ToString());

                        TxtName.Enabled = true;
                        

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
        

            bool lEnabled = ChkEnabled.Checked;

            if (lName.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese nombre");

                TxtName.Text = "";

                TxtName.Focus();

                return;
            }

     

            if (ClsFunctions.FxMessage(2, "¿Está seguro de guardar los cambios?") == true)
            {
                long lProfileId_new;

                if (lProfileId == 0)
                {
                    lProfileId_new = ClsSqlAdministrator.Fx_ins_tblProfile(lName);
                }
                else
                {
                    lProfileId_new = ClsSqlAdministrator.Fx_upt_tblProfile(lProfileId, lName, lEnabled);
                }

                if (lProfileId_new > 0)
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

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

