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
    public partial class fCSub3 : Form
    {
        private void fShow(int nMode)
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            tab1.Visible = false;
            tab2.Visible = false;
            tab3.Visible = false;

            switch (nMode)
            {
                case 1:
                    pictureBox1.Visible = true;
                    tab1.Visible = true;
                    break;
                case 2:
                    pictureBox2.Visible = true;
                    tab2.Visible = true;
                    break;
                default:
                    pictureBox3.Visible = true;
                    tab3.Visible = true;
                    break;
            }
        }
        public fCSub3()
        {
            InitializeComponent();
            pictureBox2.Left = pictureBox1.Left;
            pictureBox2.Top = pictureBox1.Top;

            pictureBox3.Left = pictureBox1.Left;
            pictureBox3.Top = pictureBox1.Top;
            tab2.Left = tab1.Left;
            tab2.Top = tab1.Top;
            tab3.Left = tab1.Left;
            tab3.Top = tab1.Top;
        }

        private void fCSub3_Load(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nMode = rnd1.Next(1, 4);

            fShow(nMode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fShow(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fShow(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fShow(3);
        }

       
    }
}
