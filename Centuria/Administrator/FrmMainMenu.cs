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

        private void OptProfile_Click(object sender, EventArgs e)
        {
            FrmProfile ObjForm = new FrmProfile();

            ObjForm.ShowDialog();
        }

        private void OptStore_Click(object sender, EventArgs e)
        {
            FrmStore ObjForm = new FrmStore();

            ObjForm.ShowDialog();
        }

        private void OptAction_Click(object sender, EventArgs e)
        {
            FrmAction ObjForm = new FrmAction();

            ObjForm.ShowDialog();
        }

        private void OptOptionType_Click(object sender, EventArgs e)
        {
            FrmOptionType ObjForm = new FrmOptionType();

            ObjForm.ShowDialog();
        }

        private void OptCompany_Click(object sender, EventArgs e)
        {
            FrmCompany ObjForm = new FrmCompany();

            ObjForm.ShowDialog();
        }
    }
}
