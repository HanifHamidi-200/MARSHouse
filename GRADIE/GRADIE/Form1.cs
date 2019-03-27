using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GRADIE
{
    public partial class Form1 : Form
    {
        private List<int> _part = new List<int> { 0, 0, 0 };
        private String msEquation;

        private void fClear()
        {
            if (lstAddX.Items.Count > 0)
            {
                do
                {
                    lstAddX.Items.RemoveAt(0);
                } while (lstAddX.Items.Count > 0);
            }
            if (lstAddY.Items.Count > 0)
            {
                do
                {
                    lstAddY.Items.RemoveAt(0);
                } while (lstAddY.Items.Count > 0);
            }
        }

        private void fAddX(double X)
        {
            double nY,nGradient;
            String sText;

            nY = _part[0] * (X * X) + _part[1] * (X) + _part[2];
            nGradient = 2 * (_part[0] * X) + _part[1];
            nGradient = Math.Round(nGradient, 4);

            sText = "X = " + Convert.ToString(X) + ", Y = " + Convert.ToString(nY) + ", gradient = " + Convert.ToString(nGradient);
            lstAddX.Items.Add(sText);
        }
        private void fAddY(double Y)
        {
            double nX1,nX2, nGradient1, nGradient2;
            String sText;
            double nDiscriminant;
            double nImaginerynumber1=0,nImaginerynumber2=0;
            double nPart3 = _part[2] - Y;

            nDiscriminant = Math.Sqrt((_part[1] * _part[1]) - (4 * _part[0] * nPart3));

            if (nDiscriminant > 0)
            {
                nX1 = ((-1) * (_part[1]) + nDiscriminant) / (2 * _part[0]);
                nX2 = ((-1) * (_part[1]) - nDiscriminant) / (2 * _part[0]);
            }
            else if (nDiscriminant == 0)
            {
                nX1 = ((-1) * (_part[1])) / (2 * _part[0]);
                nX2 = ((-1) * (_part[1])) / (2 * _part[0]);
            }
            else
            {
                nDiscriminant = (_part[1] * _part[1]) - (4 * _part[0] * nPart3);

                nImaginerynumber1 = Math.Sqrt((-1) * (nDiscriminant)) / (2 * _part[0]);
                nImaginerynumber2 = (-1) * nImaginerynumber1;
                goto complexline;
            }

            nGradient1 = 2 * (_part[0] * nX1) + _part[1];
            nGradient2 = 2 * (_part[0] * nX2) + _part[1];

            nX1 = Math.Round(nX1, 4);
            nX2 = Math.Round(nX2, 4);
            nGradient1 = Math.Round(nGradient1, 4);
            nGradient2 = Math.Round(nGradient2, 4);
            sText = "Y = " + Convert.ToString(Y) + ", X1 = " + Convert.ToString(nX1) + ", gradient = " + Convert.ToString(nGradient1);
            lstAddY.Items.Add(sText);
            sText = "Y = " + Convert.ToString(Y) + ", X2 = " + Convert.ToString(nX2) + ", gradient = " + Convert.ToString(nGradient2);
            lstAddY.Items.Add(sText);

            goto endline;
        complexline:;
            nX1 = ((-1) * (_part[1])) / (2 * _part[0]);
            nX2 = ((-1) * (_part[1])) / (2 * _part[0]);
            nX1 = Math.Round(nX1, 4);
            nX2 = Math.Round(nX2, 4);
            nGradient1 = 2 * (_part[0] * nX1) + _part[1];
            nGradient2 = 2 * (_part[0] * nX2) + _part[1];

            nGradient1 = Math.Round(nGradient1, 4);
            nGradient2 = Math.Round(nGradient2, 4);
            sText = "Y = " + Convert.ToString(Y) + ", X1 = -" + Convert.ToString(_part[0]) + "/2" + Convert.ToString(_part[1])  + "+"+ Convert.ToString(nImaginerynumber1) + "i, gradient = " + Convert.ToString(nGradient1);
            lstAddY.Items.Add(sText);
            sText = "Y = " + Convert.ToString(Y) + ", X2 = -" + Convert.ToString(_part[0]) + "/2" + Convert.ToString(_part[1])  + "-" + Convert.ToString(nImaginerynumber1) + "i, gradient = " + Convert.ToString(nGradient2);
            lstAddY.Items.Add(sText);

        endline:;

        }

        private void fReset()
        {
            _part[0] = 0;
            _part[1] = 0;
            _part[2] = 0;
            fEquation();
            fClear();
        }

        private void fEquationSave()
        {
            _part[0] = Convert.ToInt32(txtPart1.Text);
            _part[1] = Convert.ToInt32(txtPart2.Text);
            _part[2] = Convert.ToInt32(txtPart3.Text);
            fEquation();
        }
        private void fEquation()
        {
            msEquation = Convert.ToString(_part[0]) + "x^2 + " + Convert.ToString(_part[1]) + "x + " + Convert.ToString(_part[2]) + "c + ";
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            lblEquation.Text = "Equation is: " + msEquation;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnEquation_Click(object sender, EventArgs e)
        {
            fEquationSave();
        }

        private void btnAddX_Click(object sender, EventArgs e)
        {
            double nX = Convert.ToDouble(txtAdd.Text);

            fAddX(nX);
        }

        private void btnAddY_Click(object sender, EventArgs e)
        {
            double nY = Convert.ToDouble(txtAdd.Text);

            fAddY(nY);

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fClear();
        }
    }
}
