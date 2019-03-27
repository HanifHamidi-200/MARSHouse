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
    public partial class fCSub5 : Form
    {
        public fCSub5()
        {
            InitializeComponent();
        }

        private void BtnOpen1_Click(object sender, EventArgs e)
        {
            fVSub1 _dlg = new fVSub1();
            _dlg.ShowDialog();
        }

        private void BtnOpen2_Click(object sender, EventArgs e)
        {
            fVSub2 _dlg = new fVSub2();
            _dlg.ShowDialog();

        }

        private void BtnOpen3_Click(object sender, EventArgs e)
        {
            fVSub3 _dlg = new fVSub3();
            _dlg.ShowDialog();

        }

        private void BtnOpen4_Click(object sender, EventArgs e)
        {
            fVSub4 _dlg = new fVSub4();
            _dlg.ShowDialog();

        }
    }
}
