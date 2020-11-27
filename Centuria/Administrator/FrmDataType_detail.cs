using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmDataType_detail : Form
    {
        readonly long lDataTypeId;

        public FrmDataType_detail(long pDataTypeId)
        {
            lDataTypeId = pDataTypeId;

            InitializeComponent();
        }


        private void FrmDataType_detail_Load(object sender, EventArgs e)
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

            if (lDataTypeId == 0)
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

                DataTable ObjDt = ClsSqlCore.Fx_sel_tblDataType_detail(lDataTypeId);

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
                long lDataTypeId_new;

                if (lDataTypeId == 0)
                {
                    lDataTypeId_new = ClsSqlCore.Fx_ins_tblDataType(lName);
                }
                else
                {
                    lDataTypeId_new = ClsSqlCore.Fx_upt_tblDataType(lDataTypeId, lName, lEnabled);
                }

                if (lDataTypeId_new > 0)
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
    }
}

