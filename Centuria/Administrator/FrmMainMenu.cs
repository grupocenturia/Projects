using System;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            FxCancel();
        }

        private void FxCancel()
        {
            Text = ClsVariables.gTitle;

            LblStatus.Text = ClsFunctions.FxStatusBar();
        }

        private void OptUser_Click(object sender, EventArgs e)
        {
            FrmUser ObjForm = new FrmUser();

            ObjForm.ShowDialog();
        }

        private void OptModule_Click(object sender, EventArgs e)
        {
            FrmModule ObjForm = new FrmModule();

            ObjForm.ShowDialog();
        }
    }
}
