using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMPL
{
    public partial class fSub3 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int nNumber;
        private int mnType;
        private List<int> _try1 = new List<int> { 1, 2, 3 };
        private List<int> _try2 = new List<int> { 2,3,4 };
        private List<int> _try3 = new List<int> {5,6,7 };
        private List<int> _try4 = new List<int> { 6,7,8 };
        private List<int> _try5 = new List<int> { 9,10,11};
        private List<int> _try6 = new List<int> { 10,11,12 };
        private List<int> _try7 = new List<int> { 13,14,15 };
        private List<int> _try8 = new List<int> { 14,15,16 };
        private List<int> _try9 = new List<int> { 17,18,19};
        private List<int> _try10 = new List<int> { 18,19,20 };
        private List<int> _try11 = new List<int> { 21,22,23 };
        private List<int> _try12 = new List<int> { 22,23,24};
        private List<int> _try13 = new List<int> { 25,26,27 };
        private List<int> _try14 = new List<int> { 26,27,28 };
        private List<int> _try15 = new List<int> { 1, 5,9 };
        private List<int> _try16 = new List<int> { 5,9,13 };
        private List<int> _try17 = new List<int> { 9,13,17 };
        private List<int> _try18 = new List<int> { 13,17,21 };
        private List<int> _try19 = new List<int> {17,21,25 };
        private List<int> _try20 = new List<int> { 2,6,10 };
        private List<int> _try21 = new List<int> { 6,10,14 };
        private List<int> _try22 = new List<int> { 10,14,18};
        private List<int> _try23 = new List<int> { 14,18,22 };
        private List<int> _try24 = new List<int> { 18,22,26 };
        private List<int> _try25 = new List<int> { 3,7,11 };
        private List<int> _try26 = new List<int> { 7,11,15 };
        private List<int> _try27 = new List<int> {11,15,19 };
        private List<int> _try28 = new List<int> {15,19,23 };
        private List<int> _try29 = new List<int> { 19,23,27 };
        private List<int> _try30 = new List<int> {4,8,12 };
        private List<int> _try31 = new List<int> {8,12,16 };
        private List<int> _try32 = new List<int> { 12,20,24 };
        private List<int> _try33 = new List<int> { 20,24,28 };
        private List<int> _try34 = new List<int> { 24,28,32 };


        private void fComply()
        {
            int nType = 3;
            bool bFound = false;

            bFound = fTry(nType, _try1[0], _try1[1], _try1[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try2[0], _try2[1], _try2[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try3[0], _try3[1], _try3[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try4[0], _try4[1], _try4[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try5[0], _try5[1], _try5[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try6[0], _try6[1], _try6[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try7[0], _try7[1], _try7[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try8[0], _try8[1], _try8[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try9[0], _try9[1], _try9[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try10[0], _try10[1], _try10[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try11[0], _try11[1], _try11[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try12[0], _try12[1], _try12[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try13[0], _try13[1], _try13[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try14[0], _try14[1], _try14[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try15[0], _try15[1], _try15[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try16[0], _try16[1], _try16[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try17[0], _try17[1], _try17[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try18[0], _try18[1], _try18[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try19[0], _try19[1], _try19[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try20[0], _try20[1], _try20[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try21[0], _try21[1], _try21[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try22[0], _try22[1], _try22[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try23[0], _try23[1], _try23[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try24[0], _try24[1], _try24[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try25[0], _try25[1], _try25[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try26[0], _try26[1], _try26[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try27[0], _try27[1], _try27[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try28[0], _try28[1], _try28[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try29[0], _try29[1], _try29[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try30[0], _try30[1], _try30[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try31[0], _try31[1], _try31[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try32[0], _try32[1], _try32[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try33[0], _try33[1], _try33[2]);
            if (bFound)
            {
                goto lineend;
            }
            bFound = fTry(nType, _try34[0], _try34[1], _try34[2]);
            if (bFound)
            {
                goto lineend;
            }


        lineend:;
            if (bFound)
            {

                if (mnType == 4)
                {
                    MessageBox.Show("X Wins", "GEnd");

                }
                else
                {
                    MessageBox.Show("O Wins", "GEnd");


                }
                fReset();
            }
        }
        private bool fTry(int nType,int nPos1,int nPos2,int nPos3)
        {
            int nType1 = fHoletype(msShuffle2, nPos1);
            int nType2 = fHoletype(msShuffle2, nPos2);
            int nType3 = fHoletype(msShuffle2, nPos3);

            if (nType1 == nType)
            {
                if (nType2 == nType)
                {
                    if (nType3 == nType)
                    {
                        return true;
                    }
                    else
                    {
                        goto lineend;
                    }
                }
                else
                {
                    goto lineend;
                }
            }

        lineend:;
            return false;
        }
        private void fClick(int nCol,int nRow)
        {
            int nPos = (nCol - 1) * 4 + nRow;
            int nType = fHoletype(msShuffle2, nPos);
            String sTwo = "0"+Convert.ToString(mnType);

            if (nType == 1)
            {
                fPlace(sTwo, nPos);
                fUpdateDisplay();
                if (mnType == 3)
                {
                    mnType = 4;
                }
                else
                {
                    mnType = 3;
                }
                fRandomHighlight();
            }
        }
        private void fPlace(String sText, int nPos)
        {
            msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (28 - nPos) * 2);
        }

        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }

        private void fRandomHighlight()
        {
            Random rnd1 = new Random();
            int nType;
            String sTwo = "02";
            int nX1, nY1;
            int nPos;
            int nCol=0, nRow = 0;

            nX1 = rnd1.Next(1, 5);
            nNumber = rnd1.Next(1, 10);
            if (nNumber <= 5)
            {
                nY1 = 1;
            }
            else
            {
                nY1 = 2;
            }

            for(int i = 1; i <= 28; i++)
            {
                nType = fHoletype(msShuffle2, i);
                if (nType == 1)
                {
                     fPlace(sTwo, i);
                }
            }

            sTwo = "01";
            for (int i = nX1; i <= nX1 + 2; i++)
            {
                for (int j = nY1; j <= nY1 + 2; j++)
                {
                    nPos = (i - 1) * 4 + j;
                    nType = fHoletype(msShuffle2, nPos);
                    switch (nType)
                    {
                        case 3:
                            break;
                        case 4:
                            break;
                        case 2:
                            fPlace(sTwo, nPos);
                            break;
                    }
                }
            }
            fUpdateDisplay();
        }

        private void fCoordinates(int nSquare, ref int nCol, ref int nRow)
        {
            nCol = 1;

            if (nSquare > 4)
            {
                do
                {
                    nSquare -= 4;
                    nCol += 1;
                } while (nSquare > 4);

            }
            nRow = nSquare;
        }

             
        private void fReset()
        {
            Random rnd1 = new Random();
            int nCol, nRow;

            msShuffle1 = "01020304050607080910111213141516171819202122232425262728";
            msShuffle2 = "02020202020202020202020202020202020202020202020202020202";
            mnType = 3;

            fRandomHighlight();
        
            fUpdateDisplay();
        }

        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;

            //5
            nType = fHoletype(msShuffle2, 17);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 18);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 19);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 20);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;

            //6
            nType = fHoletype(msShuffle2, 21);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 22);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 23);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 24);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;

            //7
            nType = fHoletype(msShuffle2, 25);
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 26);
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 27);
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 28);
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;

        }


        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F back_highlighted.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F back_normal.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F playerxo1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F playerxo2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue)
            {
                case 1:
                    _pic2 = picture1;
                    break;
                case 2:
                    _pic2 = picture2;
                    break;
                case 3:
                    _pic2 = picture3;
                    break;
                case 4:
                    _pic2 = picture4;
                    break;
                default:
                    _pic2 = picture5;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        public fSub3()
        {
            InitializeComponent();
        }

        private void fSub3_Load(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            fComply();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            fClick(1, 1);
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            fClick(1, 2);
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            fClick(1, 3);
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            fClick(1, 4);
        }

        private void pic21_Click(object sender, EventArgs e)
        {
            fClick(2, 1);
        }

        private void pic22_Click(object sender, EventArgs e)
        {
            fClick(2, 2);
        }

        private void pic23_Click(object sender, EventArgs e)
        {
            fClick(2, 3);
        }

        private void pic24_Click(object sender, EventArgs e)
        {
            fClick(2, 4);
        }

        private void pic31_Click(object sender, EventArgs e)
        {
            fClick(3, 1);
        }

        private void pic32_Click(object sender, EventArgs e)
        {
            fClick(3, 2);
        }

        private void pic33_Click(object sender, EventArgs e)
        {
            fClick(3, 3);
        }

        private void pic34_Click(object sender, EventArgs e)
        {
            fClick(3, 4);
        }

        private void pic41_Click(object sender, EventArgs e)
        {
            fClick(4, 1);
        }

        private void pic42_Click(object sender, EventArgs e)
        {
            fClick(4, 2);
        }

        private void pic43_Click(object sender, EventArgs e)
        {
            fClick(4, 3);
        }

        private void pic44_Click(object sender, EventArgs e)
        {
            fClick(4, 4);
        }

        private void pic51_Click(object sender, EventArgs e)
        {
            fClick(5, 1);
        }

        private void pic52_Click(object sender, EventArgs e)
        {
            fClick(5, 2);
        }

        private void pic53_Click(object sender, EventArgs e)
        {
            fClick(5, 3);
        }

        private void pic54_Click(object sender, EventArgs e)
        {
            fClick(5, 4);
        }

        private void pic61_Click(object sender, EventArgs e)
        {
            fClick(6, 1);
        }

        private void pic62_Click(object sender, EventArgs e)
        {
            fClick(6, 2);
        }

        private void pic63_Click(object sender, EventArgs e)
        {
            fClick(6, 3);
        }

        private void pic64_Click(object sender, EventArgs e)
        {
            fClick(6, 4);
        }

        private void pic71_Click(object sender, EventArgs e)
        {
            fClick(7, 1);
        }

        private void pic72_Click(object sender, EventArgs e)
        {
            fClick(7, 2);
        }

        private void pic73_Click(object sender, EventArgs e)
        {
            fClick(7, 3);
        }

        private void pic74_Click(object sender, EventArgs e)
        {
            fClick(7, 4);
        }
    }
}
