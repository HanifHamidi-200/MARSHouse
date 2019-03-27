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
    public partial class fMatrix : Form
    {
        private List<String> _rotate1 = new List<string> { "dacb", "adbc", "cbda", "dcab", "bacd" };
        private List<String> _rotate2 = new List<string> { "cdba", "dcab", "bacd", "cbda", "adbc" };
        private List<String> _rotate3 = new List<string> { "bcad", "cbda", "adbc", "bacd", "dcab" };
        private List<String> _rotate4 = new List<string> { "abdc", "bacd", "dcab", "adbc", "cbda" };
        private int mnCol, mnRow;
        private String msCode;
        private bool bCorrect = false;

        private void fClick(int nCol,int nRow)
        {
            String sCode;

            switch (nCol)
            {
                case 1:
                    sCode = _rotate1[nRow - 1];
                    break;
                case 2:
                    sCode = _rotate2[nRow - 1];
                    break;
                case 3:
                    sCode = _rotate3[nRow - 1];
                    break;
                default:
                    sCode = _rotate4[nRow - 1];
                    break;
            }

            if (sCode == msCode)
            {
                bCorrect = true;
                MessageBox.Show("Correct", "Correct!");
            }

        }
        private void fReset()
        {
            Random rnd1 = new Random();

            mnCol = rnd1.Next(1, 5);
            mnRow = rnd1.Next(1, 6);
            switch (mnCol)
            {
                case 1:
                    msCode = _rotate1[mnRow - 1];
                    break;
                case 2:
                    msCode = _rotate2[mnRow - 1];
                    break;
                case 3:
                    msCode = _rotate3[mnRow - 1];
                    break;
                default:
                    msCode = _rotate4[mnRow - 1];
                    break;
            }

            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            lbl1.Text = msCode.Substring(0,1);
            lbl2.Text = msCode.Substring(1,1);
            lbl3.Text = msCode.Substring(2,1);
            lbl4.Text = msCode.Substring(3,1);
        }

        public fMatrix()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fClick(1, 1);

        }

        private void BtnComply_Click(object sender, EventArgs e)
        {
            if (bCorrect)
            {
                this.Close();
            }
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            fClick(1, 2);
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            fClick(1, 3);
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            fClick(1, 4);
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            fClick(1, 5);
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            fClick(2, 1);
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            fClick(2, 2);
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            fClick(2, 3);
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            fClick(2, 4);
        }

        private void Btn10_Click(object sender, EventArgs e)
        {
            fClick(2, 5);
        }

        private void Btn11_Click(object sender, EventArgs e)
        {
            fClick(3, 1);
        }

        private void Btn12_Click(object sender, EventArgs e)
        {
            fClick(3, 2);
        }

        private void Btn13_Click(object sender, EventArgs e)
        {
            fClick(3, 3);
        }

        private void Btn14_Click(object sender, EventArgs e)
        {
            fClick(3, 4);
        }

        private void Btn15_Click(object sender, EventArgs e)
        {
            fClick(3, 5);
        }

        private void Btn16_Click(object sender, EventArgs e)
        {
            fClick(4, 1);
        }

        private void Btn17_Click(object sender, EventArgs e)
        {
            fClick(4, 2);
        }

        private void Btn18_Click(object sender, EventArgs e)
        {
            fClick(4, 3);
        }

        private void Btn19_Click(object sender, EventArgs e)
        {
            fClick(4, 4);
        }

        private void Btn20_Click(object sender, EventArgs e)
        { 
            fClick(4, 5);
        }

        private void FMatrix_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
