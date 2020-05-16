using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lValue1 = "abc";
            long lValue2 = 123;
            double lValue3 = 123.45;
            bool lValue4 = false;
            DateTime lValue5 = DateTime.Today.Date;

            object[][] lParameters = new object[2][];

            lParameters[0] = new object[] { "Value1", "Value2", "Value3", "Value4", "Value5" };
            lParameters[1] = new object[] { lValue1, lValue2, lValue3, lValue4, lValue5 };

            for (int lCounter = 0; lCounter < lParameters[0].Length; lCounter++)
            {
                string lName = "@" + lParameters[0][lCounter];
                var lValue = lParameters[1][lCounter];
                var lType = lValue.GetType();

                MessageBox.Show("Name: " + lName);

                if (lType == typeof(int) || lType == typeof(long))
                {
                    MessageBox.Show("int");
                }
                else if (lType == typeof(double))
                {
                    MessageBox.Show("numeric");
                }
                else if (lType == typeof(bool))
                {
                    MessageBox.Show("bit");
                }
                else if (lType == typeof(DateTime))
                {
                    MessageBox.Show("date");
                }
                else
                {
                    MessageBox.Show("varchar");
                }
            }
        }
    }
}
