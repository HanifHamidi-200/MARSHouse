using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSA
{
    public partial class fSub1 : Form
    {
        private String msShuffle;
        private String msShuffle2;
        private int nNumber;
        private List<String> _name1 = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _name2 = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _name3 = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _name4 = new List<string> { null, null, null, null, null, null, null, null };
        private List<String> _name5 = new List<string> { null, null, null, null, null, null, null, null };
        private List<int> _length1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _length2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _length3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _length4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _length5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _cost1 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _cost2 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _cost3 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _cost4 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private List<int> _cost5 = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0 };
        private int mnCol, mnRow;

        private void fReset()
        {
            Random rnd1 = new Random();
            String sTwo=null;
            int nPos;
            int nValue=0;
            int nCol = 0, nRow = 0;
            int nType;

            msShuffle = "01020304050607080910111213141516171819202122232425262728293031323334353637383940";
            msShuffle2 = null;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    switch (i)
                    {
                        case 2:
                            sTwo = "03";
                            break;
                        case 3:
                            sTwo = "03";
                            break;
                       default:
                            sTwo = "01";
                            break;
                    }
                    msShuffle2 = msShuffle2 + sTwo;
                }
            }

            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    nValue = rnd1.Next(4, 7);

                    sTwo = "0" + Convert.ToString(nValue);
                    nPos = (1 - 1) * 8 + i;
                    fPlace(sTwo, nPos);
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    nValue = rnd1.Next(4, 7);

                    sTwo = "0" + Convert.ToString(nValue);
                    nPos = (4 - 1) * 8 + i;
                    fPlace(sTwo, nPos);
                }
            }
            for (int i = 1; i <= 8; i++)
            {
                nNumber = rnd1.Next(1, 10);
                if (nNumber <= 5)
                {
                    nValue = rnd1.Next(4, 7);

                    sTwo = "02";
                    nPos = (5 - 1) * 8 + i;
                    fPlace(sTwo, nPos);
                }
            }

            for (int i = 1; i <= 8; i++)
            {
                nCol = 1;
                nRow = i;
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                switch (nType)
                {
                    case 1:
                        _name1[i - 1] = "marshland";
                        _length1[i - 1] = 0;
                        _cost1[i - 1] = 0;
                        break;
                    case 2:
                        _name1[i - 1] = "bridge";
                        _length1[i - 1] = rnd1.Next(1, 401);
                        _cost1[i - 1] = rnd1.Next(1, 8001);
                        break;
                    case 3:
                        _name1[i - 1] = "MAINroad";
                        _length1[i - 1] = rnd1.Next(1, 401);
                        _cost1[i - 1] = rnd1.Next(1, 8001);
                        break;
                    default:
                        _name1[i - 1] = "road";
                        _length1[i - 1] = rnd1.Next(1, 401);
                        _cost1[i - 1] = rnd1.Next(1, 8001);
                        break;
                }
                nCol = 2;
                nRow = i;
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                switch (nType)
                {
                    case 1:
                        _name2[i - 1] = "marshland";
                        _length2[i - 1] = 0;
                        _cost2[i - 1] = 0;
                        break;
                    case 2:
                        _name2[i - 1] = "bridge";
                        _length2[i - 1] = rnd1.Next(1, 401);
                        _cost2[i - 1] = rnd1.Next(1, 8001);
                        break;
                    case 3:
                        _name2[i - 1] = "MAINroad";
                        _length2[i - 1] = rnd1.Next(1, 401);
                        _cost2[i - 1] = rnd1.Next(1, 8001);
                        break;
                    default:
                        _name2[i - 1] = "road";
                        _length2[i - 1] = rnd1.Next(1, 401);
                        _cost2[i - 1] = rnd1.Next(1, 8001);
                        break;
                }
                nCol = 3;
                nRow = i;
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                switch (nType)
                {
                    case 1:
                        _name3[i - 1] = "marshland";
                        _length3[i - 1] = 0;
                        _cost3[i - 1] = 0;
                        break;
                    case 2:
                        _name3[i - 1] = "bridge";
                        _length3[i - 1] = rnd1.Next(1, 401);
                        _cost3[i - 1] = rnd1.Next(1, 8001);
                        break;
                    case 3:
                        _name3[i - 1] = "MAINroad";
                        _length3[i - 1] = rnd1.Next(1, 401);
                        _cost3[i - 1] = rnd1.Next(1, 8001);
                        break;
                    default:
                        _name3[i - 1] = "road";
                        _length3[i - 1] = rnd1.Next(1, 401);
                        _cost3[i - 1] = rnd1.Next(1, 8001);
                        break;
                }
                nCol = 4;
                nRow = i;
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                switch (nType)
                {
                    case 1:
                        _name4[i - 1] = "marshland";
                        _length4[i - 1] = 0;
                        _cost4[i - 1] = 0;
                        break;
                    case 2:
                        _name4[i - 1] = "bridge";
                        _length4[i - 1] = rnd1.Next(1, 401);
                        _cost4[i - 1] = rnd1.Next(1, 8001);
                        break;
                    case 3:
                        _name4[i - 1] = "MAINroad";
                        _length4[i - 1] = rnd1.Next(1, 401);
                        _cost4[i - 1] = rnd1.Next(1, 8001);
                        break;
                    default:
                        _name4[i - 1] = "road";
                        _length4[i - 1] = rnd1.Next(1, 401);
                        _cost4[i - 1] = rnd1.Next(1, 8001);
                        break;
                }
                nCol = 5;
                nRow = i;
                nPos = (nCol - 1) * 8 + nRow;
                nType = fHoletype(msShuffle2, nPos);
                switch (nType)
                {
                    case 1:
                        _name5[i - 1] = "marshland";
                        _length5[i - 1] = 0;
                        _cost5[i - 1] = 0;
                        break;
                    case 2:
                        _name5[i - 1] = "bridge";
                        _length5[i - 1] = rnd1.Next(1, 401);
                        _cost5[i - 1] = rnd1.Next(1, 8001);
                        break;
                    case 3:
                        _name5[i - 1] = "MAINroad";
                        _length5[i - 1] = rnd1.Next(1, 401);
                        _cost5[i - 1] = rnd1.Next(1, 8001);
                        break;
                    default:
                        _name5[i - 1] = "road";
                        _length5[i - 1] = rnd1.Next(1, 401);
                        _cost5[i - 1] = rnd1.Next(1, 8001);
                        break;
                }
            }

            mnCol = rnd1.Next(1, 6);
            mnRow = rnd1.Next(1, 9);

            fUpdateDisplay();
            fUpdateStatus();
            fUpdateList();
        }

        private void fClick(int nCol,int nRow)
        {
            mnCol = nCol;
            mnRow = nRow;
            fUpdateStatus();
        }
        private void fName(String sText)
        {
            int nPos = (mnCol - 1) * 8 + mnRow;
            int nType = fHoletype(msShuffle2, nPos);

            if (nType == 1)
            {
                goto endline;
            }
            if (nType == 3)
            {
                goto endline;
            }

            switch (mnCol)
            {
                case 1:
                    _name1[mnRow - 1] = sText;
                    break;
                case 4:
                    _name4[mnRow - 1] = sText;
                    break;
                default:
                    _name5[mnRow - 1] = sText;
                    break;
            }
            endline:;

        }

        private void fUpdateList()
        {
            int nCol;
            int nPos;
            int nType;

            if (lst1.Items.Count > 0)
            {
                do
                {
                    lst1.Items.RemoveAt(0);
                } while (lst1.Items.Count > 0);
            }

            for (int i = 1; i <= 8; i++)
            {
                nCol = 1;
                nPos = (nCol - 1) * 8 + i;
                nType = fHoletype(msShuffle2, nPos);
                switch (nType)
                {
                    case 1:
                        break;
                    case 3:
                        break;
                    default:
                        lst1.Items.Add(_name1[i - 1]);
                        break;
                }
                nCol = 4;
                nPos = (nCol - 1) * 8 + i;
                nType = fHoletype(msShuffle2, nPos);
                switch (nType)
                {
                    case 1:
                        break;
                    case 3:
                        break;
                    default:
                        lst1.Items.Add(_name4[i - 1]);
                        break;
                }
                nCol = 5;
                nPos = (nCol - 1) * 8 + i;
                nType = fHoletype(msShuffle2, nPos);
                switch (nType)
                {
                    case 1:
                        break;
                    case 3:
                        break;
                    default:
                        lst1.Items.Add(_name5[i - 1]);
                        break;
                }
            }

            lst1.Sorted = true;
            lst1.Sorted = false;
        }

        private void fUpdateStatus()
        {
            int nPos = (mnCol - 1) * 8 + mnRow;
            int nType = fHoletype(msShuffle2, nPos);
            String sName;
            int nLength, nCost;
           
            switch (mnCol)
            {
                case 1:
                    sName = _name1[mnRow - 1];
                    nLength = _length1[mnRow - 1];
                    nCost = _cost1[mnRow - 1];
                    break;
                case 2:
                    sName = _name2[mnRow - 1];
                    nLength = _length2[mnRow - 1];
                    nCost = _cost2[mnRow - 1];
                    break;
                case 3:
                    sName = _name3[mnRow - 1];
                    nLength = _length3[mnRow - 1];
                    nCost = _cost3[mnRow - 1];
                    break;
                case 4:
                    sName = _name4[mnRow - 1];
                    nLength = _length4[mnRow - 1];
                    nCost = _cost4[mnRow - 1];
                    break;
                default:
                    sName = _name5[mnRow - 1];
                    nLength = _length5[mnRow - 1];
                    nCost = _cost5[mnRow - 1];
                    break;
            }

            txtName.Text = sName;
            lbl1.Text = "Coordinates = (" + Convert.ToString(mnCol) + "," + Convert.ToString(mnRow) + ")";
            lbl2.Text = "Length = " + Convert.ToString(nLength);
            lbl3.Text = "Cost = " + Convert.ToString(nCost);

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
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic15.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic16.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic17.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic18.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic25.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic26.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic27.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic28.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 17);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 18);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 19);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 20);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 21);
            fPeek(nType, nRotate, ref _pic);
            pic35.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 22);
            fPeek(nType, nRotate, ref _pic);
            pic36.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 23);
            fPeek(nType, nRotate, ref _pic);
            pic37.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 24);
            fPeek(nType, nRotate, ref _pic);
            pic38.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 25);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 26);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 27);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 28);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 29);
            fPeek(nType, nRotate, ref _pic);
            pic45.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 30);
            fPeek(nType, nRotate, ref _pic);
            pic46.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 31);
            fPeek(nType, nRotate, ref _pic);
            pic47.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 32);
            fPeek(nType, nRotate, ref _pic);
            pic48.Image = _pic.Image;

            //5
            nType = fHoletype(msShuffle2, 33);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 34);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 35);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 36);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 37);
            fPeek(nType, nRotate, ref _pic);
            pic55.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 38);
            fPeek(nType, nRotate, ref _pic);
            pic56.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 39);
            fPeek(nType, nRotate, ref _pic);
            pic57.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 40);
            fPeek(nType, nRotate, ref _pic);
            pic58.Image = _pic.Image;

           
        }

        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F marshland.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F bridge.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F MAINroad.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F road1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F road2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F road3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
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
                case 5:
                    _pic2 = picture5;
                    break;
                case 6:
                    _pic2 = picture6;
                    break;
                default:
                    _pic2 = picture7;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }


        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }


        private void fPlace(String sText, int nPos)
        {
            msShuffle2 = msShuffle2.Substring(0, nPos * 2 - 2) + sText + msShuffle2.Substring(nPos * 2, (40 - nPos) * 2);
        }



        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            fReset();
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

        private void pic15_Click(object sender, EventArgs e)
        {
            fClick(1, 5);
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            fClick(1, 6);
        }

        private void pic17_Click(object sender, EventArgs e)
        {
            fClick(1, 7);
        }

        private void pic18_Click(object sender, EventArgs e)
        {
            fClick(1, 8);
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

        private void pic25_Click(object sender, EventArgs e)
        {
            fClick(2, 5);
        }

        private void pic26_Click(object sender, EventArgs e)
        {
            fClick(2, 6);
        }

        private void pic27_Click(object sender, EventArgs e)
        {
            fClick(2, 7);
        }

        private void pic28_Click(object sender, EventArgs e)
        {
            fClick(2, 8);
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

        private void pic35_Click(object sender, EventArgs e)
        {
            fClick(3, 5);
        }

        private void pic36_Click(object sender, EventArgs e)
        {
            fClick(3, 6);
        }

        private void pic37_Click(object sender, EventArgs e)
        {
            fClick(3, 7);
        }

        private void pic38_Click(object sender, EventArgs e)
        {
            fClick(3, 8);
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

        private void pic45_Click(object sender, EventArgs e)
        {
            fClick(4, 5);
        }

        private void pic46_Click(object sender, EventArgs e)
        {
            fClick(4, 6);
        }

        private void pic47_Click(object sender, EventArgs e)
        {
            fClick(4, 7);
        }

        private void pic48_Click(object sender, EventArgs e)
        {
            fClick(4, 8);
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

        private void pic55_Click(object sender, EventArgs e)
        {
            fClick(5, 5);
        }

        private void pic56_Click(object sender, EventArgs e)
        {
            fClick(5, 6);
        }

        private void pic57_Click(object sender, EventArgs e)
        {
            fClick(5, 7);
        }

        private void pic58_Click(object sender, EventArgs e)
        {
            fClick(5, 8);
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            fName(txtName.Text);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            fUpdateList();
        }

        private void btnQNext_Click(object sender, EventArgs e)
        {
            fReset();
        }
    }
}
