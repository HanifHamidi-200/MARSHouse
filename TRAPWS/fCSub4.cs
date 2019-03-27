using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRAPWS
{
    public partial class fCSub4 : Form
    {
        private void fShow(int nMode)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            switch (nMode)
            {
                case 1:
                    groupBox1.Visible = true;
                    break;
                case 2:
                    groupBox2.Visible = true;
                    break;
                default:
                    groupBox3.Visible = true;
                    break;
            }
        }
        public fCSub4()
        {
            InitializeComponent();
            groupBox2.Left = groupBox1.Left;
            groupBox2.Top = groupBox1.Top;
            groupBox3.Left = groupBox1.Left;
            groupBox3.Top = groupBox1.Top;

        }

        private void fCSub4_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nMode = rnd1.Next(1, 4);

            fShow(nMode);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fShow(3);
        }
    }
}
