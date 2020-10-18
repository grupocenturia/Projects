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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void CmdLogin_Click(object sender, EventArgs e)
        {
            FxLogin();
        }

        private void FxLogin()
        {
            FrmMainMenu ObjForm = new FrmMainMenu();
            Hide();
            ObjForm.ShowDialog();
            Show();

        }

        private void LblLogin_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
