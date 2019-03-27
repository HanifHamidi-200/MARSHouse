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
    public partial class fSub3 : Form
    {
        private void fShow(int nMode)
        {
            fra1.Visible = false;
            fra2.Visible = false;
            fra3.Visible = false;

            switch (nMode)
            {
                case 1:
                    fra1.Visible = true;
                    break;
                case 2:
                    fra2.Visible = true;
                    break;
                default:
                    fra3.Visible = true;
                    break;
            }
        }

        public fSub3()
        {
            InitializeComponent();
            fra2.Left = fra1.Left;
            fra2.Top = fra1.Top;
            fra3.Left = fra1.Left;
            fra3.Top = fra1.Top;
        }

        private void FSub3_Load(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            fShow(3);
        }
    }
}
