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
    public partial class fSub2 : Form
    {
        public fSub2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fBSub1 _dlg = new fBSub1();
            _dlg.ShowDialog();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            fBSub2 _dlg = new fBSub2();
            _dlg.ShowDialog();

        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            fBSub3 _dlg = new fBSub3();
            _dlg.ShowDialog();

        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            fBSub4 _dlg = new fBSub4();
            _dlg.ShowDialog();

        }
    }
}
