using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmModule_detail : Form
    {
        readonly long lModuleId;
        
        string lFileLogo;

        public FrmModule_detail(long pModuleId)
        {
            lModuleId = pModuleId;

            InitializeComponent();
        }

        private void FrmModule_detail_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtDescription_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void TxtExecutable_Enter(object sender, EventArgs e)
        {
            ClsFunctions.FxSelectAll(sender);
        }

        private void CmdLogo_Click(object sender, EventArgs e)
        {
            FxLogo();
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
            ImgLogo.Image = null;

            lFileLogo = "";

            TxtName.Text = "";
            TxtDescription.Text = "";
            TxtExecutable.Text = "";

            ChkEnabled.Checked = false;

            TxtName.Enabled = false;
            TxtDescription.Enabled = false;
            TxtExecutable.Enabled = false;

            ChkEnabled.Enabled = false;

            CmdLogo.Enabled = true;
            CmdSave.Enabled = false;

            if (lModuleId == 0)
            {
                Text += " - Adicionar";

                TxtName.Enabled = true;
                TxtDescription.Enabled = true;
                TxtExecutable.Enabled = true;

                ChkEnabled.Checked = true;

                CmdSave.Enabled = true;

                TxtName.Focus();
            }
            else
            {
                Text += " - Modificar";

                DataTable ObjDt = ClsSqlAdministrator.Fx_sel_tblModule_detail(lModuleId);

                if (ObjDt != null)
                {
                    if (ObjDt.Rows.Count > 0)
                    {
                        TxtName.Text = ObjDt.Rows[0][0].ToString();
                        TxtDescription.Text = ObjDt.Rows[0][1].ToString();
                        TxtExecutable.Text = ObjDt.Rows[0][2].ToString();

                        ChkEnabled.Checked = ClsFunctions.FxConvertStringToBool(ObjDt.Rows[0][3].ToString());

                        Bitmap ObjLogo;

                        try
                        {
                            ObjLogo = ClsSqlAdministrator.Fx_sel_tblModuleLogo(lModuleId);
                        }
                        catch
                        {
                            ObjLogo = null;
                        }

                        if (ObjLogo != null)
                        {
                            lFileLogo = ClsVariables.gPathTemp + "Img" + ClsFunctions.FxRandomNumber().ToString() + ".png";

                            if (File.Exists(lFileLogo))
                            {
                                ClsFunctions.FxDeleteFile(lFileLogo);
                            }

                            ObjLogo.Save(lFileLogo);

                            ObjLogo.Dispose();

                            ImgLogo.Image = Bitmap.FromFile(lFileLogo);
                        }

                        TxtName.Enabled = true;
                        TxtDescription.Enabled = true;
                        TxtExecutable.Enabled = true;

                        ChkEnabled.Enabled = true;

                        CmdSave.Enabled = true;

                        TxtName.Focus();
                    }
                }
            }
        }

        private void FxLogo()
        {
            OpenFileDialog ObjOpenFileDialog = new OpenFileDialog
            {
                Title = "Seleccionar logo",
                Filter = "PNG|*.png",
                InitialDirectory = ClsVariables.gPathDocs
            };

            lFileLogo = "";

            ImgLogo.Image = null;

            if(ObjOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                lFileLogo = ObjOpenFileDialog.FileName;

                if (lFileLogo.EndsWith(".png") == false)
                {
                    ClsFunctions.FxMessage(1, "No es un archivo válido. Intente de nuevo");

                    lFileLogo = "";
                }

                ImgLogo.Image = Image.FromFile(lFileLogo);
            }

            ObjOpenFileDialog.Dispose();
        }

        private void FxSave()
        {
            string lName = TxtName.Text.Trim();
            string lDescription = TxtDescription.Text.Trim();
            string lExecutable = TxtExecutable.Text.Trim();

            bool lEnabled = ChkEnabled.Checked;

            if (lName.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese nombre");

                TxtName.Text = "";

                TxtName.Focus();

                return;
            }

            if (lDescription.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese descripción");

                TxtDescription.Text = "";

                TxtDescription.Focus();

                return;
            }

            if (lExecutable.Length < 3)
            {
                ClsFunctions.FxMessage(1, "Ingrese ejecutable");

                TxtExecutable.Text = "";

                TxtExecutable.Focus();

                return;
            }

            if (ClsFunctions.FxMessage(2, "¿Está seguro de guardar los cambios?") == true)
            {
                long lModuleId_new;

                if (lModuleId == 0)
                {
                    lModuleId_new = ClsSqlAdministrator.Fx_ins_tblModule(lName, lDescription, lExecutable);
                }
                else
                {
                    lModuleId_new = ClsSqlAdministrator.Fx_upt_tblModule(lModuleId, lName, lDescription, lExecutable, lEnabled);
                }

                if (lModuleId_new > 0)
                {
                    if (lFileLogo.Length > 0)
                    {
                        lModuleId_new = ClsSqlAdministrator.Fx_ins_tblModuleLogo(lModuleId_new, lFileLogo);
                    }

                    ClsFunctions.FxMessage("Proceso concluido");

                    FxExit();
                }
            }
        }

        private void FxExit()
        {
            ImgLogo.Image = null;

            Close();
        }
    }
}
