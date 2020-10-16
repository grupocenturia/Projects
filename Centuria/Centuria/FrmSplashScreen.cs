using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Centuria
{
    public partial class FrmSplashScreen : Form
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
        }

        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            FxCancel();
        }
        private void TmrExit_Tick(object sender, EventArgs e)
        {
            FxExit();
        }

        private void FxCancel()
        {
            TmrExit.Enabled = true;
        }

        private void FxExit()
        {
            TmrExit.Enabled = false;

            FrmLogin ObjForm = new FrmLogin();

            Hide();

            ObjForm.ShowDialog();

            Close();
        }
    }
}
