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
    public partial class fSub1 : Form
    {
        private String msShuffle1;
        private String msShuffle2;
        private int nNumber;
        private int mnDice1, mnDice2;
        private bool mbDiceFirst;
        private int mnPlayer1, mnPlayer2;
        private bool mbPlayer1;
        private int mnWins1, mnWins2;
        private void fRoll()
        {
            Random rnd1 = new Random();
            PictureBox _pic1 = new PictureBox();
            PictureBox _pic2 = new PictureBox();

            int nDice1 = rnd1.Next(3, 13);
            int nDice2 = rnd1.Next(3, 13);

            mnDice1 = nDice1;
            mnDice2 = nDice2;
            mbDiceFirst = true;

            fPeek2(nDice1, ref _pic1, nDice2, ref _pic2);
            picDice1.Image = _pic1.Image;
            picDice2.Image = _pic2.Image;

        }

        private string fShuffle(string sText)
        {
            string sText2 = null;
            int nPos = 0, nLength = 28;

            Random rnd1 = new Random();

            for (int i = 1; i <= 28; i++)
            {
                nLength = 29 - i;
                nPos = rnd1.Next(1, nLength + 1);
                sText2 = sText2 + sText.Substring(nPos * 2 - 2, 2);
                sText = sText.Substring(0, nPos * 2 - 2) + sText.Substring(nPos * 2, (nLength - nPos) * 2);
            }

            return sText2;
        }

        private int fType(int nSquare)
        {
            String sTwo;
            sTwo = msShuffle2.Substring(nSquare * 2 - 2, 2);

            return Convert.ToInt32(sTwo);
        }
        private void fReset()
        {
            Random rnd1 = new Random();
            int nCount = rnd1.Next(2, 7);
            int nCol, nRow;

            msShuffle1 = "01020304050607080910111213141516171819202122232425262728";
            msShuffle2 = "01010101010101020202020202020101010101010102020202020202";
            mnPlayer1 = 0;
            mnPlayer2 = 0;
            mbPlayer1 = true;

            fUpdateDisplay();
            for (int i = 1; i <= nCount; i++)
            {
                nCol = rnd1.Next(1, 8);
                nRow = rnd1.Next(1, 5);
                nNumber = rnd1.Next(1, 10);
                if (nNumber<=5)
                {
                    fPlace(13, nCol, nRow);
                }
                else
                {
                    fPlace(32, nCol, nRow);
                }
            }

            fUpdateDisplay();
            fUpdatePlayers();
            fRoll();
        }

        private int fSquare(int nCol,int nRow)
        {
            switch (nRow)
            {
                case 1:
                    switch (nCol)
                    {
                        case 1:
                            return 28;
                        case 2:
                            return 27;
                        case 3:
                            return 26;
                        case 4:
                            return 25;
                        case 5:
                            return 24;
                        case 6:
                            return 23;
                        default:
                            return 22;
                    }
                case 2:
                    switch (nCol)
                    {
                        case 1:
                            return 15;
                        case 2:
                            return 16;
                        case 3:
                            return 17;
                        case 4:
                            return 18;
                        case 5:
                            return 19;
                        case 6:
                            return 20;
                        default:
                            return 21;
                    }
                case 3:
                    switch (nCol)
                    {
                        case 1:
                            return 14;
                        case 2:
                            return 13;
                        case 3:
                            return 12;
                        case 4:
                            return 11;
                        case 5:
                            return 10;
                        case 6:
                            return 9;
                        default:
                            return 8;
                    }
                default:
                    switch (nCol)
                    {
                        case 1:
                            return 1;
                        case 2:
                            return 2;
                        case 3:
                            return 3;
                        case 4:
                            return 4;
                        case 5:
                            return 5;
                        case 6:
                            return 6;
                        default:
                            return 7;
                    }
            
            }
        }
        private void fPlace(int nType,int nCol,int nRow)
        {
            String sTwo;
            int nSquare = fSquare(nCol, nRow);

            sTwo = Convert.ToString(nType);
            if (sTwo.Length == 1)
            {
                sTwo = "0" + sTwo;
            }
            msShuffle2 = msShuffle2.Substring(0, nSquare * 2 - 2) + sTwo + msShuffle2.Substring(nSquare * 2, (28 - nSquare) * 2);
        }
        private int fHoletype(String sShuffle, int nSquare)
        {
            int nType = 0;

            nType = Convert.ToInt32(sShuffle.Substring(nSquare * 2 - 2, 2));
            return nType;
        }

        private void fUpdatePlayers()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            if (mnPlayer1 != 0)
            {
                nType = 14;
                switch (mnPlayer1)
                {
                    case 1:
                        fPeek(nType, nRotate, ref _pic);
                        pic14.Image = _pic.Image;
                        break;
                    case 2:
                        fPeek(nType, nRotate, ref _pic);
                        pic24.Image = _pic.Image;
                        break;
                    case 3:
                        fPeek(nType, nRotate, ref _pic);
                        pic34.Image = _pic.Image;
                        break;
                    case 4:
                        fPeek(nType, nRotate, ref _pic);
                        pic44.Image = _pic.Image;
                        break;
                    case 5:
                        fPeek(nType, nRotate, ref _pic);
                        pic54.Image = _pic.Image;
                        break;
                    case 6:
                        fPeek(nType, nRotate, ref _pic);
                        pic64.Image = _pic.Image;
                        break;
                    case 7:
                        fPeek(nType, nRotate, ref _pic);
                        pic74.Image = _pic.Image;
                        break;
                    case 8:
                        fPeek(nType, nRotate, ref _pic);
                        pic73.Image = _pic.Image;
                        break;
                    case 9:
                        fPeek(nType, nRotate, ref _pic);
                        pic63.Image = _pic.Image;
                        break;
                    case 10:
                        fPeek(nType, nRotate, ref _pic);
                        pic53.Image = _pic.Image;
                        break;
                    case 11:
                        fPeek(nType, nRotate, ref _pic);
                        pic43.Image = _pic.Image;
                        break;
                    case 12:
                        fPeek(nType, nRotate, ref _pic);
                        pic33.Image = _pic.Image;
                        break;
                    case 13:
                        fPeek(nType, nRotate, ref _pic);
                        pic23.Image = _pic.Image;
                        break;
                    case 14:
                        fPeek(nType, nRotate, ref _pic);
                        pic13.Image = _pic.Image;
                        break;
                    case 15:
                        fPeek(nType, nRotate, ref _pic);
                        pic12.Image = _pic.Image;
                        break;
                    case 16:
                        fPeek(nType, nRotate, ref _pic);
                        pic22.Image = _pic.Image;
                        break;
                    case 17:
                        fPeek(nType, nRotate, ref _pic);
                        pic32.Image = _pic.Image;
                        break;
                    case 18:
                        fPeek(nType, nRotate, ref _pic);
                        pic42.Image = _pic.Image;
                        break;
                    case 19:
                        fPeek(nType, nRotate, ref _pic);
                        pic52.Image = _pic.Image;
                        break;
                    case 20:
                        fPeek(nType, nRotate, ref _pic);
                        pic62.Image = _pic.Image;
                        break;
                    case 21:
                        fPeek(nType, nRotate, ref _pic);
                        pic72.Image = _pic.Image;
                        break;
                    case 22:
                        fPeek(nType, nRotate, ref _pic);
                        pic71.Image = _pic.Image;
                        break;
                    case 23:
                        fPeek(nType, nRotate, ref _pic);
                        pic61.Image = _pic.Image;
                        break;
                    case 24:
                        fPeek(nType, nRotate, ref _pic);
                        pic51.Image = _pic.Image;
                        break;
                    case 25:
                        fPeek(nType, nRotate, ref _pic);
                        pic41.Image = _pic.Image;
                        break;
                    case 26:
                        fPeek(nType, nRotate, ref _pic);
                        pic31.Image = _pic.Image;
                        break;
                    case 27:
                        fPeek(nType, nRotate, ref _pic);
                        pic21.Image = _pic.Image;
                        break;
                    default:
                        fPeek(nType, nRotate, ref _pic);
                        pic11.Image = _pic.Image;
                        break;
                }
            }
            if (mnPlayer2 != 0)
            {
                nType = 15;
                switch (mnPlayer2)
                {
                    case 1:
                        fPeek(nType, nRotate, ref _pic);
                        pic14.Image = _pic.Image;
                        break;
                    case 2:
                        fPeek(nType, nRotate, ref _pic);
                        pic24.Image = _pic.Image;
                        break;
                    case 3:
                        fPeek(nType, nRotate, ref _pic);
                        pic34.Image = _pic.Image;
                        break;
                    case 4:
                        fPeek(nType, nRotate, ref _pic);
                        pic44.Image = _pic.Image;
                        break;
                    case 5:
                        fPeek(nType, nRotate, ref _pic);
                        pic54.Image = _pic.Image;
                        break;
                    case 6:
                        fPeek(nType, nRotate, ref _pic);
                        pic64.Image = _pic.Image;
                        break;
                    case 7:
                        fPeek(nType, nRotate, ref _pic);
                        pic74.Image = _pic.Image;
                        break;
                    case 8:
                        fPeek(nType, nRotate, ref _pic);
                        pic73.Image = _pic.Image;
                        break;
                    case 9:
                        fPeek(nType, nRotate, ref _pic);
                        pic63.Image = _pic.Image;
                        break;
                    case 10:
                        fPeek(nType, nRotate, ref _pic);
                        pic53.Image = _pic.Image;
                        break;
                    case 11:
                        fPeek(nType, nRotate, ref _pic);
                        pic43.Image = _pic.Image;
                        break;
                    case 12:
                        fPeek(nType, nRotate, ref _pic);
                        pic33.Image = _pic.Image;
                        break;
                    case 13:
                        fPeek(nType, nRotate, ref _pic);
                        pic23.Image = _pic.Image;
                        break;
                    case 14:
                        fPeek(nType, nRotate, ref _pic);
                        pic13.Image = _pic.Image;
                        break;
                    case 15:
                        fPeek(nType, nRotate, ref _pic);
                        pic12.Image = _pic.Image;
                        break;
                    case 16:
                        fPeek(nType, nRotate, ref _pic);
                        pic22.Image = _pic.Image;
                        break;
                    case 17:
                        fPeek(nType, nRotate, ref _pic);
                        pic32.Image = _pic.Image;
                        break;
                    case 18:
                        fPeek(nType, nRotate, ref _pic);
                        pic42.Image = _pic.Image;
                        break;
                    case 19:
                        fPeek(nType, nRotate, ref _pic);
                        pic52.Image = _pic.Image;
                        break;
                    case 20:
                        fPeek(nType, nRotate, ref _pic);
                        pic62.Image = _pic.Image;
                        break;
                    case 21:
                        fPeek(nType, nRotate, ref _pic);
                        pic72.Image = _pic.Image;
                        break;
                    case 22:
                        fPeek(nType, nRotate, ref _pic);
                        pic71.Image = _pic.Image;
                        break;
                    case 23:
                        fPeek(nType, nRotate, ref _pic);
                        pic61.Image = _pic.Image;
                        break;
                    case 24:
                        fPeek(nType, nRotate, ref _pic);
                        pic51.Image = _pic.Image;
                        break;
                    case 25:
                        fPeek(nType, nRotate, ref _pic);
                        pic41.Image = _pic.Image;
                        break;
                    case 26:
                        fPeek(nType, nRotate, ref _pic);
                        pic31.Image = _pic.Image;
                        break;
                    case 27:
                        fPeek(nType, nRotate, ref _pic);
                        pic21.Image = _pic.Image;
                        break;
                    default:
                        fPeek(nType, nRotate, ref _pic);
                        pic11.Image = _pic.Image;
                        break;
                }
            }
            }
            private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            //1
            nType = fHoletype(msShuffle2, 28);
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 15);
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 14);
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 1);
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;

            //2
            nType = fHoletype(msShuffle2, 27);
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 16);
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 13);
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 2);
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;

            //3
            nType = fHoletype(msShuffle2, 26);
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 17);
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 12);
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 3);
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;

            //4
            nType = fHoletype(msShuffle2, 25);
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 18);
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 11);
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 4);
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;

            //5
            nType = fHoletype(msShuffle2, 24);
            fPeek(nType, nRotate, ref _pic);
            pic51.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 19);
            fPeek(nType, nRotate, ref _pic);
            pic52.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 10);
            fPeek(nType, nRotate, ref _pic);
            pic53.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 5);
            fPeek(nType, nRotate, ref _pic);
            pic54.Image = _pic.Image;

            //6
            nType = fHoletype(msShuffle2, 23);
            fPeek(nType, nRotate, ref _pic);
            pic61.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 20);
            fPeek(nType, nRotate, ref _pic);
            pic62.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 9);
            fPeek(nType, nRotate, ref _pic);
            pic63.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 6);
            fPeek(nType, nRotate, ref _pic);
            pic64.Image = _pic.Image;

            //7
            nType = fHoletype(msShuffle2, 22);
            fPeek(nType, nRotate, ref _pic);
            pic71.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 21);
            fPeek(nType, nRotate, ref _pic);
            pic72.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 8);
            fPeek(nType, nRotate, ref _pic);
            pic73.Image = _pic.Image;
            nType = fHoletype(msShuffle2, 7);
            fPeek(nType, nRotate, ref _pic);
            pic74.Image = _pic.Image;

        }


        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F back_blue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F back_red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F die1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F die2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F die3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F die4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F die5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F die6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F die7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F die8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F die9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F die10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F ladder.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F player1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F player2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F player11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F player12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F player13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F player14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F player21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F player22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F player23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F player24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F player31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F player32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F player33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"F player34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"F player41.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"F player42.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"F player43.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"F player44.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"F snake.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
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
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                case 12:
                    _pic2 = picture12;
                    break;
                case 13:
                    _pic2 = picture13;
                    break;
                case 14:
                    _pic2 = picture14;
                    break;
                case 15:
                    _pic2 = picture15;
                    break;
                case 16:
                    _pic2 = picture16;
                    break;
                case 17:
                    _pic2 = picture17;
                    break;
                case 18:
                    _pic2 = picture18;
                    break;
                case 19:
                    _pic2 = picture19;
                    break;
                case 20:
                    _pic2 = picture20;
                    break;
                case 21:
                    _pic2 = picture21;
                    break;
                case 22:
                    _pic2 = picture22;
                    break;
                case 23:
                    _pic2 = picture23;
                    break;
                case 24:
                    _pic2 = picture24;
                    break;
                case 25:
                    _pic2 = picture25;
                    break;
                case 26:
                    _pic2 = picture26;
                    break;
                case 27:
                    _pic2 = picture27;
                    break;
                case 28:
                    _pic2 = picture28;
                    break;
                case 29:
                    _pic2 = picture29;
                    break;
                case 30:
                    _pic2 = picture30;
                    break;
                case 31:
                    _pic2 = picture31;
                    break;
                case 32:
                    _pic2 = picture32;
                    break;
                default:
                    _pic2 = picture33;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }
        private void fPeek2(int nValue1, ref PictureBox _pic1, int nValue2, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F back_blue.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F back_red.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F die1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F die2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F die3.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F die4.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F die5.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F die6.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F die7.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
                Image = Image.FromFile(@"F die8.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture11 = new PictureBox
            {
                Name = "pictureBox11",
                Image = Image.FromFile(@"F die9.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture12 = new PictureBox
            {
                Name = "pictureBox12",
                Image = Image.FromFile(@"F die10.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture13 = new PictureBox
            {
                Name = "pictureBox13",
                Image = Image.FromFile(@"F ladder.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture14 = new PictureBox
            {
                Name = "pictureBox14",
                Image = Image.FromFile(@"F player1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture15 = new PictureBox
            {
                Name = "pictureBox15",
                Image = Image.FromFile(@"F player2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture16 = new PictureBox
            {
                Name = "pictureBox16",
                Image = Image.FromFile(@"F player11.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture17 = new PictureBox
            {
                Name = "pictureBox17",
                Image = Image.FromFile(@"F player12.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture18 = new PictureBox
            {
                Name = "pictureBox18",
                Image = Image.FromFile(@"F player13.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture19 = new PictureBox
            {
                Name = "pictureBox19",
                Image = Image.FromFile(@"F player14.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture20 = new PictureBox
            {
                Name = "pictureBox20",
                Image = Image.FromFile(@"F player21.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture21 = new PictureBox
            {
                Name = "pictureBox21",
                Image = Image.FromFile(@"F player22.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture22 = new PictureBox
            {
                Name = "pictureBox22",
                Image = Image.FromFile(@"F player23.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture23 = new PictureBox
            {
                Name = "pictureBox23",
                Image = Image.FromFile(@"F player24.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture24 = new PictureBox
            {
                Name = "pictureBox24",
                Image = Image.FromFile(@"F player31.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture25 = new PictureBox
            {
                Name = "pictureBox25",
                Image = Image.FromFile(@"F player32.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture26 = new PictureBox
            {
                Name = "pictureBox26",
                Image = Image.FromFile(@"F player33.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture27 = new PictureBox
            {
                Name = "pictureBox27",
                Image = Image.FromFile(@"F player34.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture28 = new PictureBox
            {
                Name = "pictureBox28",
                Image = Image.FromFile(@"F player41.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture29 = new PictureBox
            {
                Name = "pictureBox29",
                Image = Image.FromFile(@"F player42.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture30 = new PictureBox
            {
                Name = "pictureBox30",
                Image = Image.FromFile(@"F player43.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture31 = new PictureBox
            {
                Name = "pictureBox31",
                Image = Image.FromFile(@"F player44.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture32 = new PictureBox
            {
                Name = "pictureBox32",
                Image = Image.FromFile(@"F snake.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture33 = new PictureBox
            {
                Name = "pictureBox33",
                Image = Image.FromFile(@"F NullGate.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            switch (nValue1)
            {
                case 3:
                    _pic1 = picture3;
                    break;
                case 4:
                    _pic1 = picture4;
                    break;
                case 5:
                    _pic1 = picture5;
                    break;
                case 6:
                    _pic1 = picture6;
                    break;
                case 7:
                    _pic1 = picture7;
                    break;
                case 8:
                    _pic1 = picture8;
                    break;
                case 9:
                    _pic1 = picture9;
                    break;
                case 10:
                    _pic1 = picture10;
                    break;
                case 11:
                    _pic1 = picture11;
                    break;
                default:
                    _pic1 = picture12;
                    break;
            }
            switch (nValue2)
            {
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
                case 7:
                    _pic2 = picture7;
                    break;
                case 8:
                    _pic2 = picture8;
                    break;
                case 9:
                    _pic2 = picture9;
                    break;
                case 10:
                    _pic2 = picture10;
                    break;
                case 11:
                    _pic2 = picture11;
                    break;
                default:
                    _pic2 = picture12;
                    break;
            }

        }

        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            mnWins1 = 0;
            mnWins2 = 0;

            fReset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fReset();
        }

        private void picDice1_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nType;
            int nExtra = rnd1.Next(1, 7);

            mbDiceFirst = true;
            if (mbPlayer1)
            {
                mnPlayer1 += mnDice1-2;
                if (mnPlayer1 >= 28)
                {
                    mnWins1 += 1;
                    MessageBox.Show("Player1 wins", "GWin" + Convert.ToString(mnWins1));
                    fReset();
                    goto exitlabel;
                }
                fUpdateDisplay();
                fUpdatePlayers();
                mbPlayer1 = false;
                nType = fType(mnPlayer1);
                switch (nType)
                {
                    case 13:
                        mnPlayer1 += nExtra;
                        if (mnPlayer1 >= 28)
                        {
                            mnWins1 += 1;
                            MessageBox.Show("Player1 wins", "GWin" + Convert.ToString(mnWins1));
                            fReset();
                            goto exitlabel;
                        }
                        break;
                    case 32:
                        mnPlayer1 -= nExtra;
                        if (mnPlayer1 < 1)
                        {
                            mnWins2 += 1;
                            MessageBox.Show("Player2 wins", "GWin" + Convert.ToString(mnWins2));
                            fReset();
                            goto exitlabel;
                        }
                        break;
                    default:
                        break;
                }
                fUpdateDisplay();
                fUpdatePlayers();

            }
            else
            {
                mnPlayer2 += mnDice1-2;
                if (mnPlayer2 >= 28)
                {
                    mnWins2 += 1;
                    MessageBox.Show("Player2 wins", "GWin" + Convert.ToString(mnWins2));
                    fReset();
                    goto exitlabel;
                }
                fUpdateDisplay();
                fUpdatePlayers();
                mbPlayer1 = true;
                nType = fType(mnPlayer2);
                switch (nType)
                {
                    case 13:
                        mnPlayer2 += nExtra;
                        if (mnPlayer2 >= 28)
                        {
                            mnWins2 += 1;
                            MessageBox.Show("Player2 wins", "GWin" + Convert.ToString(mnWins2));
                            fReset();
                            goto exitlabel;
                        }
                        break;
                    case 32:
                        mnPlayer2 -= nExtra;
                        if (mnPlayer2 < 1)
                        {
                            mnWins1 += 1;
                            MessageBox.Show("Player1 wins", "GWin" + Convert.ToString(mnWins1));
                            fReset();
                            goto exitlabel;
                        }
                        break;
                    default:
                        break;
                }
                fUpdateDisplay();
                fUpdatePlayers();
            }

        exitlabel:;
        }

        private void picDice2_Click(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            int nType;
            int nExtra = rnd1.Next(1, 7);

            mbDiceFirst = false;
            if (mbPlayer1)
            {
                mnPlayer1 += mnDice2 - 2;
                if (mnPlayer1 >= 28)
                {
                    mnWins1 += 1;
                    MessageBox.Show("Player1 wins", "GWin" + Convert.ToString(mnWins1));
                    fReset();
                    goto exitlabel;
                }
                fUpdateDisplay();
                fUpdatePlayers();
                mbPlayer1 = false;
                nType = fType(mnPlayer1);
                switch (nType)
                {
                    case 13:
                        mnPlayer1 += nExtra;
                        if (mnPlayer1 >= 28)
                        {
                            mnWins1 += 1;
                            MessageBox.Show("Player1 wins", "GWin" + Convert.ToString(mnWins1));
                            fReset();
                            goto exitlabel;
                        }
                        break;
                    case 32:
                        mnPlayer1 -= nExtra;
                        if (mnPlayer1 < 1)
                        {
                            mnWins2 += 1;
                            MessageBox.Show("Player2 wins", "GWin" + Convert.ToString(mnWins2));
                            fReset();
                            goto exitlabel;
                        }
                        break;
                    default:
                        break;
                }
                fUpdateDisplay();
                fUpdatePlayers();

            }
            else
            {
                mnPlayer2 += mnDice2 - 2;
                if (mnPlayer2 >= 28)
                {
                    mnWins2 += 1;
                    MessageBox.Show("Player2 wins", "GWin" + Convert.ToString(mnWins2));
                    fReset();
                    goto exitlabel;
                }
                fUpdateDisplay();
                fUpdatePlayers();
                mbPlayer1 = true;
                nType = fType(mnPlayer2);
                switch (nType)
                {
                    case 13:
                        mnPlayer2 += nExtra;
                        if (mnPlayer2 >= 28)
                        {
                            mnWins2 += 1;
                            MessageBox.Show("Player2 wins", "GWin" + Convert.ToString(mnWins2));
                            fReset();
                            goto exitlabel;
                        }
                        break;
                    case 32:
                        mnPlayer2 -= nExtra;
                        if (mnPlayer2 < 1)
                        {
                            mnWins1 += 1;
                            MessageBox.Show("Player1 wins", "GWin" + Convert.ToString(mnWins1));
                            fReset();
                            goto exitlabel;
                        }
                        break;
                    default:
                        break;
                }
                fUpdateDisplay();
                fUpdatePlayers();
            }

        exitlabel:;
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            fRoll();
           }
    }
}


