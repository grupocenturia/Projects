using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmStore_detail : Form
    {
        readonly long lStoreId;

        public FrmStore_detail(long pStoreId)
        {
            lStoreId = pStoreId;

            InitializeComponent();
        }

        private void FrmStore_detail_Load(object sender, EventArgs e)
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

            if (lStoreId == 0)
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

                DataTable ObjDt = ClsSqlAdministrator.Fx_sel_tblStore_detail(lStoreId);

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
                long lStoreId_new;

                if (lStoreId == 0)
                {
                    lStoreId_new = ClsSqlAdministrator.Fx_ins_tblStore(lName);
                }
                else
                {
                    lStoreId_new = ClsSqlAdministrator.Fx_upt_tblStore(lStoreId, lName, lEnabled);
                }

                if (lStoreId_new > 0)
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
