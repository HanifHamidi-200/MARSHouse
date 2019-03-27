using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STRAY
{
    public partial class Form1 : Form
    {
        private List<int> _col1 = new List<int> { 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0 };
        private List<bool> _house1 = new List<bool> { false, false, false, false };
        private List<bool> _house2 = new List<bool> { false, false, false, false };
        private List<bool> _house3 = new List<bool> { false, false, false, false };
        private List<bool> _house4 = new List<bool> { false, false, false, false };
        private int mnCol, mnRow;
        private int nNumber;
        private int mnType, mnCol2;

        private void fPlace(int nType,int nCol)
        {
            bool bFound = false;
            int nRow = 0;

            for(int i = 4; i >= 1; i--)
            {
                switch (nCol)
                {
                    case 1:
                        if (_col1[i - 1] <= 2)
                        {
                            bFound = true;
                            nRow = i;
                        }
                        break;
                    case 2:
                        if (_col2[i - 1] <= 2)
                        {
                            bFound = true;
                            nRow = i;
                        }
                        break;
                    case 3:
                        if (_col3[i - 1] <= 2)
                        {
                            bFound = true;
                            nRow = i;
                        }
                        break;
                    default:
                        if (_col4[i - 1] <= 2)
                        {
                            bFound = true;
                            nRow = i;
                        }
                        break;
                }
                if (bFound)
                {
                    switch (nCol)
                    {
                        case 1:
                            _col1[nRow - 1] = nType;
                            break;
                        case 2:
                            _col2[nRow - 1] = nType;
                            break;
                        case 3:
                            _col3[nRow - 1] = nType;
                            break;
                        default:
                            _col4[nRow - 1] = nType;
                            break;
                    }
                    goto lineend;
                }
            }

            lineend:;
        }
        private void fPlaceHouse(int nCol,int nRow)
        {
            switch (nCol)
            {
                case 1:
                    _house1[nRow - 1] = true;
                    break;
                case 2:
                    _house2[nRow - 1] = true;
                    break;
                case 3:
                    _house3[nRow - 1] = true;
                    break;
                default:
                    _house4[nRow - 1] = true;
                    break;
            }
        }
        private bool fTypeHouse(int nCol,int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _house1[nRow - 1];
                case 2:
                    return _house2[nRow - 1];
                case 3:
                    return _house3[nRow - 1];
                default:
                    return _house4[nRow - 1];
            }
        }
        private void fFree(ref int nCol,ref int nRow)
        {
            Random rnd1 = new Random();
            bool bFound = false;
            bool nType;

            do
            {
                 nCol = rnd1.Next(1, 5);
                 nRow = rnd1.Next(1, 5);
                 nType = fTypeHouse(nCol, nRow);
                 if (!nType)
                 {
                    bFound = true;
                 }
            } while (!bFound);
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            bool bError = false;
            int nCol=1, nRow=1;
            int nCount;
            int nType;

            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int i2 = 1; i2 <= 4; i2++)
                    {
                        _house1[i2 - 1] = false;
                        _house2[i2 - 1] = false;
                        _house3[i2 - 1] = false;
                        _house4[i2 - 1] = false;
                        nNumber = rnd1.Next(1, 10);                          
                        if (nNumber <= 5)
                        {
                            _col1[i2 - 1] = 1;
                        }
                        else
                        {
                            _col1[i2 - 1] = 2;
                        }
                        nNumber = rnd1.Next(1, 10);
                        if (nNumber <= 5)
                        {
                            _col2[i2 - 1] = 1;
                        }
                        else
                        {
                            _col2[i2 - 1] = 2;
                        }
                        nNumber = rnd1.Next(1, 10);
                        if (nNumber <= 5)
                        {
                            _col3[i2 - 1] = 1;
                        }
                        else
                        {
                            _col3[i2 - 1] = 2;
                        }
                        nNumber = rnd1.Next(1, 10);
                        if (nNumber <= 5)
                        {
                            _col4[i2 - 1] = 1;
                        }
                        else
                        {
                            _col4[i2 - 1] = 2;
                        }
                    }
                    fFree(ref nCol, ref nRow);
                    fPlaceHouse(nCol, nRow);
                    fFree(ref nCol, ref nRow);
                    fPlaceHouse(nCol, nRow);

                    nCount = rnd1.Next(2, 13);
                    for (int i2 = 1; i2 <= nCount; i2++)
                    {
                        nCol = rnd1.Next(1, 5);
                        nType = rnd1.Next(3, 9);
                        fPlace(nType, nCol);
                    }

                    bError = false;
                    fDatabase2(ref bError, i, j);
                    if (bError)
                    {
                        goto lineend;
                    }
                }
            }

              lineend:;

        }

        private void fDatabase( ref bool bError)
        {
            String sName = "dialog1.txt";
            try
            {   // Open the text file using a stream reader.
                using (StreamWriter sw = new StreamWriter(sName))
                {
                    sw.WriteLine(Convert.ToString(mnCol));
                    sw.WriteLine(Convert.ToString(mnRow));
                    sw.WriteLine(Convert.ToString(mnType));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! = " + ex);
                bError = true;
            }
        }
        private void fDatabase2(ref bool bError,int nCol,int nRow)
        {
            String sName = "grid"+Convert.ToString(nCol)+Convert.ToString(nRow)+".txt";
            try
            {   // Open the text file using a stream reader.
                using (StreamWriter sw = new StreamWriter(sName))
                {
                    for (int i = 1; i <= 4; i ++)
                    { 
                        sw.WriteLine(Convert.ToString(_col1[i-1]));
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sw.WriteLine(Convert.ToString(_col2[i - 1]));
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sw.WriteLine(Convert.ToString(_col3[i - 1]));
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sw.WriteLine(Convert.ToString(_col4[i - 1]));
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_house1[i - 1])
                        {
                            sw.WriteLine("1");
                        }
                        else
                        {
                            sw.WriteLine("0");
                        }
                     }
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_house2[i - 1])
                        {
                            sw.WriteLine("1");
                        }
                        else
                        {
                            sw.WriteLine("0");
                        }
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_house3[i - 1])
                        {
                            sw.WriteLine("1");
                        }
                        else
                        {
                            sw.WriteLine("0");
                        }
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        if (_house4[i - 1])
                        {
                            sw.WriteLine("1");
                        }
                        else
                        {
                            sw.WriteLine("0");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! = " + ex);
                bError = true;
            }
        }

        private void fDialog(int nCol,int nRow)
        {
            bool bError = false;
            mnCol = nCol;
            mnRow = nRow;

            if (nCol == mnCol2)
            {

            }
            else
            {
                goto lineend;
            }

            fDatabase(ref bError);
            if (!bError)
            {
                fSub1 _dlg = new fSub1();
                _dlg.ShowDialog();
            }

            lineend:;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnA1_Click(object sender, EventArgs e)
        {
            fDialog(1, 1);
        }

        private void btnA2_Click(object sender, EventArgs e)
        {
            fDialog(1, 2);
        }

        private void btnA3_Click(object sender, EventArgs e)
        {
            fDialog(1, 3);
        }

        private void btnA4_Click(object sender, EventArgs e)
        {
            fDialog(1, 4);

        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            fDialog(2, 1);
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            fDialog(2, 2);
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            fDialog(2, 3);
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            fDialog(2, 4);

        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            fDialog(3, 1);
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            fDialog(3, 2);
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            fDialog(3, 3);

        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            fDialog(3, 4);
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            fDialog(4, 1);

        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            fDialog(4, 2);
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            fDialog(4, 3);

        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            fDialog(4, 4);
        }

        private void btnE1_Click(object sender, EventArgs e)
        {
            fDialog(5, 1);

        }

        private void btnE2_Click(object sender, EventArgs e)
        {
            fDialog(5, 2);

        }

        private void btnE3_Click(object sender, EventArgs e)
        {
            fDialog(5, 3);
        }

        private void btnE4_Click(object sender, EventArgs e)
        {
            fDialog(6, 4);

        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            fDialog(6, 1);

        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            fDialog(6, 2);
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            fDialog(6, 3);
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            fDialog(6, 4);

        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnSNext_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nType = rnd1.Next(3, 9);
            int nCol = rnd1.Next(1, 7);
            String sType = null;

            switch (nType)
            {
                case 3:
                    sType = "cobalt";
                    break;
                case 4:
                    sType = "eugenie";
                    break;
                case 5:
                    sType = "mollusc";
                    break;
                case 6:
                    sType = "pillars";
                    break;
                case 7:
                    sType = "rocks";
                    break;
                default:
                    sType = "thymoid";
                    break;
            }

            mnType = nType;
            mnCol2 = nCol;
            MessageBox.Show(sType + " found at Col" + Convert.ToString(nCol));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
