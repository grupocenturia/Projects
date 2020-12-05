﻿
using System;
using System.Data;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmCompany : Form
    {
        DataTable ObjDt;

        public FrmCompany()
        {
            InitializeComponent();
        }

        private void FrmCompany_Load(object sender, EventArgs e)
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
          

            ObjDt = ClsSqlAdministrator.Fx_sel_tblCompany(false);

            if (ObjDt != null)
            {
                if (ObjDt.Rows.Count > 0)
                {
                    GrdData.DataSource = ObjDt.DefaultView;

                    GrdData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    GrdData.Columns[5].Visible = false;

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
            long lCompanyId;

            try
            {
                lCompanyId = long.Parse(GrdData.SelectedRows[0].Cells[5].Value.ToString());
            }
            catch
            {
                lCompanyId = 0;
            }

            if (lCompanyId == 0)
            {
                ClsFunctions.FxMessage(1, "Seleccione usuario");

                GrdData.Focus();

                return;
            }

            FxFormDetail(lCompanyId);
        }

        private void FxFormDetail(long pId)
        {
            FrmCompany_detail ObjForm = new FrmCompany_detail(pId);

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
