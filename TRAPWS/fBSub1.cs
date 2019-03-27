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
    public partial class fBSub1 : Form
    {
        private List<String> _heading = new List<String> { "SiliconValleyNumber", "MountRushmoreNumber", "drivingthrough_PineapplePlantation", "TechnologyRooms(LeverPumpSpray)", "ResponsibleFor", "CTFACTNumber", "RINRTNumber", "WeiliessSINumber" };
        private List<String> _text = new List<string> { "  Indiana", "  Illinois", "  California", "  NorthDakota", "  SouthDakota", "  Montana", "  [1]",    "  [2]", "  [1]", "  [2]", "  TheCrime (resolvesitself)", "  TwoLanguages (BilingualTreaty)", "  the statue (MRSteppingstone)", "  [1]", "  [2]", "  [1]", "  [2]", "  [1]", "  [2]" };
        private List<int> _numbers = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private void fReset()
        {
            Random rnd1 = new Random();

            for(int i = 1; i <= 19; i++)
            {
                _numbers[i - 1] = rnd1.Next(1, 1001);
            }

            fUpdateList();
        }

        private void fUpdateList()
        {
            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            lst1.Items.Add(_heading[0]);
            lst1.Items.Add(_text[0] + " = " + Convert.ToString(_numbers[0]));
            lst1.Items.Add(_text[1] + " = " + Convert.ToString(_numbers[1]));
            lst1.Items.Add(_text[2] + " = " + Convert.ToString(_numbers[2]));
            lst1.Items.Add(_heading[1]);
            lst1.Items.Add(_text[3] + " = " + Convert.ToString(_numbers[3]));
            lst1.Items.Add(_text[4] + " = " + Convert.ToString(_numbers[4]));
            lst1.Items.Add(_text[5] + " = " + Convert.ToString(_numbers[5]));
            lst1.Items.Add(_heading[2]);
            lst1.Items.Add(_text[6] + " = " + Convert.ToString(_numbers[6]));
            lst1.Items.Add(_text[7] + " = " + Convert.ToString(_numbers[7]));
            lst1.Items.Add(_heading[3]);
            lst1.Items.Add(_text[8] + " = " + Convert.ToString(_numbers[8]));
            lst1.Items.Add(_text[9] + " = " + Convert.ToString(_numbers[9]));
            lst1.Items.Add(_heading[4]);
            lst1.Items.Add(_text[10] + " = " + Convert.ToString(_numbers[10]));
            lst1.Items.Add(_text[11] + " = " + Convert.ToString(_numbers[11]));
            lst1.Items.Add(_text[12] + " = " + Convert.ToString(_numbers[12]));
            lst1.Items.Add(_heading[5]);
            lst1.Items.Add(_text[13] + " = " + Convert.ToString(_numbers[13]));
            lst1.Items.Add(_text[14] + " = " + Convert.ToString(_numbers[14]));
            lst1.Items.Add(_heading[6]);
            lst1.Items.Add(_text[15] + " = " + Convert.ToString(_numbers[15]));
            lst1.Items.Add(_text[16] + " = " + Convert.ToString(_numbers[16]));
            lst1.Items.Add(_heading[7]);
            lst1.Items.Add(_text[17] + " = " + Convert.ToString(_numbers[17]));
            lst1.Items.Add(_text[18] + " = " + Convert.ToString(_numbers[18]));

        }

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
        public fBSub1()
        {
            InitializeComponent();
            fra2.Left = fra1.Left;
            fra2.Top = fra1.Top;
            fra3.Left = fra1.Left;
            fra3.Top = fra1.Top;
            fReset();
        }

        private void FBSub1_Load(object sender, EventArgs e)
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
