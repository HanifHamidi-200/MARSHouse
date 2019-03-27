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
    public partial class fBSub2 : Form
    {
        private void fShow(int nMode)
        {
            fra1.Visible = false;
            fra2.Visible = false;

            if (nMode == 1)
            {
                fra1.Visible = true;
            }
            else
            {
                fra2.Visible = true;
            }
        }
        public fBSub2()
        {
            InitializeComponent();
            fra2.Left = fra1.Left;
            fra2.Top = fra1.Top;

        }

        private void FBSub2_Load(object sender, EventArgs e)
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
    }
}
