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
    public partial class fSub1 : Form
    {
        private List<int> _col1 = new List<int> { 0, 0, 0, 0 };
        private List<int> _col2 = new List<int> { 0, 0, 0, 0 };
        private List<int> _col3 = new List<int> { 0, 0, 0, 0 };
        private List<int> _col4 = new List<int> { 0, 0, 0, 0 };
        private List<bool> _house1 = new List<bool> { false, false, false, false };
        private List<bool> _house2 = new List<bool> { false, false, false, false };
        private List<bool> _house3 = new List<bool> { false, false, false, false };
        private List<bool> _house4 = new List<bool> { false, false, false, false };
        private int mnCol, mnRow,mnType;
        private bool bDone;

        private void fPlace(int nType,int nCol,int nRow)
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
        }
        private void fClick(int nCol,int nRow)
        {
            int nType = fType(nCol, nRow);

            if (bDone)
            {
                goto lineend;
            }
            if (nType > 2)
            {
                goto lineend;
            }

            fPlace(mnType, nCol, nRow);
            fUpdateType();
            fUpdateDisplay();
            bDone = true;

            lineend:;

            nType = fType(nCol, nRow);
            if (nType == 9)
            {
                MessageBox.Show("HouseFound", "Satisfaction");
            }
        }

        private void fGet()
        {
            bool bError = false;
            fDatabase2(ref bError);
            if (!bError)
            {
                fUpdateType();
                fUpdateDisplay();
            }

        }
        private void fPeek(int nValue, int nRotate, ref PictureBox _pic2)
        {
            PictureBox picture1 = new PictureBox
            {
                Name = "pictureBox1",
                Image = Image.FromFile(@"F blank1.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture2 = new PictureBox
            {
                Name = "pictureBox2",
                Image = Image.FromFile(@"F blank2.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture3 = new PictureBox
            {
                Name = "pictureBox3",
                Image = Image.FromFile(@"F cobalt.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture4 = new PictureBox
            {
                Name = "pictureBox4",
                Image = Image.FromFile(@"F eugenie.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture5 = new PictureBox
            {
                Name = "pictureBox5",
                Image = Image.FromFile(@"F mollusc.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture6 = new PictureBox
            {
                Name = "pictureBox6",
                Image = Image.FromFile(@"F pillars.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture7 = new PictureBox
            {
                Name = "pictureBox7",
                Image = Image.FromFile(@"F rocks.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture8 = new PictureBox
            {
                Name = "pictureBox8",
                Image = Image.FromFile(@"F thymoid.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture9 = new PictureBox
            {
                Name = "pictureBox9",
                Image = Image.FromFile(@"F housefound.png"),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            PictureBox picture10 = new PictureBox
            {
                Name = "pictureBox10",
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
                default:
                    _pic2 = picture10;
                    break;
            }
            for (int i = 1; i <= nRotate - 1; i++)
            {
                _pic2.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

        }

        private int fType(int nCol,int nRow)
        {
            switch (nCol)
            {
                case 1:
                    return _col1[nRow - 1];
                case 2:
                    return _col2[nRow - 1];
                case 3:
                    return _col3[nRow - 1];
                default:
                    return _col4[nRow - 1];
            }
        }

        private bool fTypeHouse(int nCol, int nRow)
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

        private void fUpdateType()
        {
            bool bHouse = false;
            int nType = 0;

            for (int i = 1; i <= 4; i++)
            {
                nType = fType(1,i);
                if (nType > 2)
                {
                    bHouse = fTypeHouse(1,i);
                    if (bHouse)
                    {
                        _col1[i - 1] = 9;
                    }
                }
                nType = fType( 2,i);
                if (nType > 2)
                {
                    bHouse = fTypeHouse( 2,i);
                    if (bHouse)
                    {
                        _col2[i - 1] = 9;
                    }
                }
                nType = fType(3,i);
                if (nType > 2)
                {
                    bHouse = fTypeHouse( 3,i);
                    if (bHouse)
                    {
                        _col3[i - 1] = 9;
                    }
                }
                nType = fType( 4,i);
                if (nType > 2)
                {
                    bHouse = fTypeHouse(4,i);
                    if (bHouse)
                    {
                        _col4[i - 1] = 9;
                    }
                }

            }
        }
        private void fUpdateDisplay()
        {
            PictureBox _pic = new PictureBox();
            int nType, nRotate = 1;

            nType = _col1[0];
            fPeek(nType, nRotate, ref _pic);
            pic11.Image = _pic.Image;
            nType = _col1[1];
            fPeek(nType, nRotate, ref _pic);
            pic12.Image = _pic.Image;
            nType = _col1[2];
            fPeek(nType, nRotate, ref _pic);
            pic13.Image = _pic.Image;
            nType = _col1[3];
            fPeek(nType, nRotate, ref _pic);
            pic14.Image = _pic.Image;
        
            //2
            nType = _col2[0];
            fPeek(nType, nRotate, ref _pic);
            pic21.Image = _pic.Image;
            nType = _col2[1];
            fPeek(nType, nRotate, ref _pic);
            pic22.Image = _pic.Image;
            nType = _col2[2];
            fPeek(nType, nRotate, ref _pic);
            pic23.Image = _pic.Image;
            nType = _col2[3];
            fPeek(nType, nRotate, ref _pic);
            pic24.Image = _pic.Image;
      
            //3
            nType = _col3[0];
            fPeek(nType, nRotate, ref _pic);
            pic31.Image = _pic.Image;
            nType = _col3[1];
            fPeek(nType, nRotate, ref _pic);
            pic32.Image = _pic.Image;
            nType = _col3[2];
            fPeek(nType, nRotate, ref _pic);
            pic33.Image = _pic.Image;
            nType = _col3[3];
            fPeek(nType, nRotate, ref _pic);
            pic34.Image = _pic.Image;
          
            //4
            nType = _col4[0];
            fPeek(nType, nRotate, ref _pic);
            pic41.Image = _pic.Image;
            nType = _col4[1];
            fPeek(nType, nRotate, ref _pic);
            pic42.Image = _pic.Image;
            nType = _col4[2];
            fPeek(nType, nRotate, ref _pic);
            pic43.Image = _pic.Image;
            nType = _col4[3];
            fPeek(nType, nRotate, ref _pic);
            pic44.Image = _pic.Image;
        }

        private void fDatabase2(ref bool bError)
        {
            String sText;
            String sName = "grid" + Convert.ToString(mnCol) + Convert.ToString(mnRow) + ".txt";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        sText = sr.ReadLine();
                        _col1[i - 1] = Convert.ToInt32(sText);
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sText = sr.ReadLine();
                        _col2[i - 1] = Convert.ToInt32(sText);
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sText = sr.ReadLine();
                        _col3[i - 1] = Convert.ToInt32(sText);
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sText = sr.ReadLine();
                        _col4[i - 1] = Convert.ToInt32(sText);
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sText = sr.ReadLine();
                        if (sText == "1")
                        {
                            _house1[i - 1] = true;
                        }
                        else
                        {
                            _house1[i - 1] = false;
                        }
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sText = sr.ReadLine();
                        if (sText == "1")
                        {
                            _house2[i - 1] = true;
                        }
                        else
                        {
                            _house2[i - 1] = false;
                        }
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sText = sr.ReadLine();
                        if (sText == "1")
                        {
                            _house3[i - 1] = true;
                        }
                        else
                        {
                            _house3[i - 1] = false;
                        }
                    }
                    for (int i = 1; i <= 4; i++)
                    {
                        sText = sr.ReadLine();
                        if (sText == "1")
                        {
                            _house4[i - 1] = true;
                        }
                        else
                        {
                            _house4[i - 1] = false;
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

        private void fDatabase3(ref bool bError)
        {
            String sName = "grid" + Convert.ToString(mnCol) + Convert.ToString(mnRow) + ".txt";
            try
            {   // Open the text file using a stream reader.
                using (StreamWriter sw = new StreamWriter(sName))
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        sw.WriteLine(Convert.ToString(_col1[i - 1]));
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

        private void fDatabase(ref bool bError)
        {
            String sText;

            String sName = "dialog1.txt";
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {
                    sText = sr.ReadLine();
                    mnCol = Convert.ToInt32(sText);
                    sText = sr.ReadLine();
                    mnRow = Convert.ToInt32(sText);
                    sText = sr.ReadLine();
                    mnType = Convert.ToInt32(sText);
                }          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! = " + ex);
                bError = true;
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            bool bError = false;

            fDatabase3(ref bError);
            this.Close();

        }

        public fSub1()
        {
            InitializeComponent();
        }

        private void fSub1_Load(object sender, EventArgs e)
        {
            bool bError = false;

            bDone = false;
            fDatabase(ref bError);
            if (!bError)
            {
                this.Text = "Dialog " + Convert.ToString(mnCol) + Convert.ToString(mnRow);
            }

            fGet();
        }
    }
}
