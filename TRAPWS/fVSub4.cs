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
    public partial class fVSub4 : Form
    {
        private List<String> _columns = new List<String> { "DMDE_LiftEffect", "DMDE_ActualPulley", "Planet9" };
        private List<int> _count = new List<int> { 4, 6, 5 };
        private List<String> _col1 = new List<String> { "aEde", "jikl", "nemtode", "quince", null, null, null };
        private List<String> _col2 = new List<String> { "phasMAT", "triANG", "plusNET", "wollum", "fasttude", "Eboleys", null };
        private List<String> _col3 = new List<String> { "IMMCinterrupt", "MowgliAttitude", "DiamondRange", "EarthAndromeda_MC", "RigelEarth_outcrop", null, null };
        private List<String> _data = new List<string> { null, null, null };
        private List<int> _value1 = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _value2 = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _value3 = new List<int> { 0, 0, 0, 0, 0, 0, 0 };
        private int mnItem;
        private int nNumber;

        private void fReset()
        {
            Random rnd1 = new Random();

            for (int i = 1; i <= 7; i++)
            {
                _value1[i - 1] = rnd1.Next(1, 401);
                _value2[i - 1] = rnd1.Next(1, 401);
                _value3[i - 1] = rnd1.Next(1, 401);
            }

            for (int i = 1; i <= 3; i++)
            {
                _data[i - 1] = null;
            }
            mnItem = rnd1.Next(1, 4);
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            String sText = null;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            fra1.Text = _columns[mnItem - 1];
            for (int i = 1; i <= _count[mnItem - 1]; i++)
            {
                switch (mnItem)
                {
                    case 1:
                        sText = _col1[i - 1] + " = " + Convert.ToString(_value1[i - 1]);
                        break;
                    case 2:
                        sText = _col2[i - 1] + " = " + Convert.ToString(_value2[i - 1]);
                        break;
                    default:
                        sText = _col3[i - 1] + " = " + Convert.ToString(_value3[i - 1]);
                        break;
                }
                lst1.Items.Add(sText);
            }


            txtEntry.Text = _data[mnItem - 1];
        }

        private void fSave(String sText)
        {
            _data[mnItem - 1] = sText;
        }


        public fVSub4()
        {
            InitializeComponent();
        }

        private void fVSub4_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            fSave(txtEntry.Text);

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            mnItem = 1;
            fUpdateDisplay();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            mnItem = 2;
            fUpdateDisplay();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            mnItem = 3;
            fUpdateDisplay();

        }
    }
}
