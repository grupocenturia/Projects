using System;
using System.Drawing;
using System.Windows.Forms;
using Core;

namespace Administrator
{
    public partial class FrmMainMenu : Form
    {
        private Form activeForm = null;

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

            LblTitle.Text = "";

            LblStatus.Text = ClsFunctions.FxStatusBar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = false;
            button7.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button5.Visible = true;
            button7.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            button3.Visible = false;
            button5.Visible = false;
            button7.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Para hacer pruebas
            openChildFormInPanel(new FrmLanguage());
        }

        private void openChildFormInPanel(Form childForm)
        {
            PanPrincipal.Panel1.Enabled = false;

            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.AutoScroll = true;
            childForm.Dock = DockStyle.Fill;
            childForm.FormClosing += OwnedFormOnFormClosing;

            PanDetail.Panel2.Controls.Add(childForm);

            LblTitle.Text = childForm.Text;

            childForm.BringToFront();
            childForm.Show();
        }

        private void OwnedFormOnFormClosing(object sender, FormClosingEventArgs formClosingEventArgs)
        {
            if (formClosingEventArgs.CloseReason == CloseReason.UserClosing)
            {
                PanPrincipal.Panel1.Enabled = true;

                LblTitle.Text = "";

                TxtSearch.Focus();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FrmProfile());
        }

        private void OptLanguage_Click(object sender, EventArgs e)
        {
            FrmLanguage ObjForm = new FrmLanguage();

            ObjForm.ShowDialog();
        }

        private void OptDataType_Click(object sender, EventArgs e)
        {
            FrmDataType ObjForm = new FrmDataType();

            ObjForm.ShowDialog();
        }

        private void OptCountry_Click(object sender, EventArgs e)
        {
            FrmCountry ObjForm = new FrmCountry();

            ObjForm.ShowDialog();
        }

        private void OptCurrency_Click(object sender, EventArgs e)
        {
            FrmCurrency ObjForm = new FrmCurrency();

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
