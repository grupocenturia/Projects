using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Centuria
{
    public partial class FrmMainMenu : Form
    {
        long lCompanyId;

        DataTable ObjDtCompany;
        DataTable ObjDtModule;

        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void FrmMainMenu_Resize(object sender, EventArgs e)
        {
            FxResize();
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FxExit();
        }

        private void CmbCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbCompany.DataSource != null)
            {
                FxGetModule();
            }
        }

        private void LnkChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FxChangePassword();
        }

        private void FxCancel()
        {
            FxResize();

            Text = ClsVariables.gTitle;

            LblStatus.Text = ClsFunctions.FxStatusBar();

            ObjDtCompany = null;
            ObjDtModule = null;

            lCompanyId = 0;

            PanModule.Controls.Clear();

            FxGetCompany();

            if (ObjDtCompany.Rows.Count > 0)
            {
                FxGetModule();
            }
        }

        private void FxResize()
        {
            CmbCompany.Left = (Width / 2) - (CmbCompany.Width / 2) - 8;
        }

        private void FxGetCompany()
        {
            ObjDtCompany = null;

            CmbCompany.DataSource = null;

            CmbCompany.Enabled = false;

            ObjDtCompany = ClsSql.Fx_sel_tblCompany(true); //ClsSql.Fx_sel_tblUser_company(ClsVariables.gUserId);

            if (ObjDtCompany != null)
            {
                if (ObjDtCompany.Rows.Count > 0)
                {
                    CmbCompany.DataSource = ObjDtCompany.DefaultView;

                    CmbCompany.DisplayMember = "Name";
                    CmbCompany.ValueMember = "CompanyId";

                    CmbCompany.Enabled = true;
                }
            }
        }

        private void FxGetModule()
        {
            ObjDtModule = null;

            try
            {
                lCompanyId = long.Parse(CmbCompany.SelectedValue.ToString());
            }
            catch
            {
                lCompanyId = 0;
            }

            if (lCompanyId > 0)
            {
                ObjDtModule = ClsSql.Fx_sel_tblModule(true); //ClsSql.Fx_sel_tblUser_companyModule(ClsVariables.gUserId, lCompanyId);

                if (ObjDtModule != null)
                {
                    if (ObjDtModule.Rows.Count > 0)
                    {
                        FxCreateModules(ObjDtModule.Rows.Count);
                    }
                }
            }
        }

        private void FxCreateModules(int lTotal)
        {
            PanModule.Controls.Clear();

            SplitContainer[] ObjModule = new SplitContainer[lTotal];
            FlowLayoutPanel[] ObjModuleText = new FlowLayoutPanel[lTotal];
            PictureBox[] ObjImage = new PictureBox[lTotal];
            Label[] ObjLabelName = new Label[lTotal];
            Label[] ObjLabelDescription = new Label[lTotal];

            for (int lCounter = 0; lCounter < lTotal; lCounter++)
            {
                ObjModule[lCounter] = new SplitContainer
                {
                    IsSplitterFixed = true,
                    Width = 300,
                    Height = 80,
                    SplitterDistance = 80,
                    TabStop = false
                };

                ObjImage[lCounter] = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Cursor = Cursors.Hand,
                    //Image = Properties.Resources.Administrator,
                    Tag = lCounter.ToString()
                };

                long lModuleId = 0;

                try
                {
                    lModuleId = long.Parse(ObjDtModule.Rows[lCounter][3].ToString());
                }
                catch
                {
                    lModuleId = 0;
                }

                if (lModuleId > 0)
                {
                    Bitmap ObjLogo = ClsFunctions.FxGetModuleLogo(lModuleId);

                    if (ObjImage != null)
                    {
                        ObjImage[lCounter].Image = ObjLogo;
                    }
                }

                ObjModuleText[lCounter] = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false
                };

                ObjLabelName[lCounter] = new Label
                {
                    AutoSize = true,
                    Cursor = Cursors.Hand,
                    Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(76, 106, 169),
                    Text = ObjDtModule.Rows[lCounter][0].ToString(),
                    Tag = lCounter.ToString()
                };

                ObjLabelDescription[lCounter] = new Label
                {
                    AutoSize = true,
                    Cursor = Cursors.Hand,
                    Text = ObjDtModule.Rows[lCounter][1].ToString(),
                    Tag = lCounter.ToString()
                };

                ObjImage[lCounter].Click += new EventHandler(ObjImage_Click);

                ObjLabelName[lCounter].Click += new EventHandler(ObjLabel_Click);
                ObjLabelDescription[lCounter].Click += new EventHandler(ObjLabel_Click);

                ObjModuleText[lCounter].Controls.Add(ObjLabelName[lCounter]);
                ObjModuleText[lCounter].Controls.Add(ObjLabelDescription[lCounter]);

                ObjModule[lCounter].Panel1.Controls.Add(ObjImage[lCounter]);
                ObjModule[lCounter].Panel2.Controls.Add(ObjModuleText[lCounter]);

                PanModule.Controls.Add(ObjModule[lCounter]);
            }
        }

        private void ObjLabel_Click(object sender, EventArgs e)
        {
            int lCounter;

            try
            {
                lCounter = Int32.Parse(((Label)sender).Tag.ToString());
            }
            catch
            {
                lCounter = -1;
            }

            if (lCounter >= 0)
            {
                FxModule(lCounter);
            }
        }

        private void ObjImage_Click(object sender, EventArgs e)
        {
            int lCounter;

            try
            {
                lCounter = Int32.Parse(((PictureBox)sender).Tag.ToString());
            }
            catch
            {
                lCounter = -1;
            }

            if (lCounter >= 0)
            {
                FxModule(lCounter);
            }
        }

        private void FxModule(int pCounter)
        {
            long lModuleId;
            string lExecutable;

            try
            {
                lModuleId = long.Parse(ObjDtModule.Rows[pCounter][3].ToString());
                lExecutable = ClsVariables.gPathBin + ObjDtModule.Rows[pCounter][2].ToString();
            }
            catch
            {
                lModuleId = 0;
                lExecutable = "";
            }

            if (lModuleId == 0)
            {
                ClsFunctions.FxMessage(1, "Módulo no ha sido seleccionado");
            }
            else
            {
                string lParameter = ClsFunctions.FxModuleParameters(lCompanyId, lModuleId);

                Hide();

                ClsFunctions.FxRunModule(lExecutable, lParameter);

                Show();
            }

            FxGetModule();
        }

        private void FxChangePassword()
        {
            FrmChangePassword ObjForm = new FrmChangePassword();

            ObjForm.ShowDialog();
        }

        private void FxExit()
        {
            ObjDtCompany = null;
            ObjDtModule = null;

            CmbCompany.DataSource = null;

            CmbCompany.Enabled = false;

            PanModule.Controls.Clear();
        }
    }
}
