using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WDOOR
{
    public partial class fSub5 : Form
    {
        private void fShow(int nMode)
        {
            pic1.Visible = false;
            pic2.Visible = false;
            pic3.Visible = false;
            pic4.Visible = false;

            switch (nMode)
            {
                case 1:
                    pic1.Visible = true;
                    break;
                case 2:
                    pic2.Visible = true;
                    break;
                case 3:
                    pic3.Visible = true;
                    break;
                default:
                    pic4.Visible = true;
                    break;
            }
        }
        public fSub5()
        {
            InitializeComponent();
            pic2.Left = pic1.Left;
            pic2.Top = pic1.Top;
            pic3.Left = pic1.Left;
            pic3.Top = pic1.Top;
            pic4.Left = pic1.Left;
            pic4.Top = pic1.Top;
        }

        private void fSub5_Load(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fShow(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            fShow(4);
        }
    }
}
