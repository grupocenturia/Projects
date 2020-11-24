using System;
using System.Data;
using System.Windows.Forms;
using Core;


namespace Administrator
{
    public partial class FrmDataType : Form
    {
        DataTable ObjDt;

        public FrmDataType()
        {
            InitializeComponent();
        }

        private void FrmDataType_Load(object sender, EventArgs e)
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


            ObjDt = ClsSqlCore.Fx_sel_tblDataType(false);

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
            long lDataTypeId;

            try
            {
                lDataTypeId = long.Parse(GrdData.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch
            {
                lDataTypeId = 0;
            }

            if (lDataTypeId == 0)
            {
                ClsFunctions.FxMessage(1, "Seleccione Tipo de dato");

                GrdData.Focus();

                return;
            }

            FxFormDetail(lDataTypeId);
        }

        private void FxFormDetail(long pId)
        {
            FrmDataType_detail ObjForm = new FrmDataType_detail(pId);

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

