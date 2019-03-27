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

namespace TRAPWS
{
    public partial class fBlank : Form
    {
        private int mnFormnumber;

        private void fGet()
        {
            String sName = "Data.txt";
            String sLine;
       
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(sName))
                {

                    // Read the stream to a string, and write the string to the console.
                    sLine = sr.ReadLine();
                    sLine = sr.ReadLine();
                    mnFormnumber = Convert.ToInt32(sLine);
                    sr.Close();
                }
           
            }
            catch (Exception e1)
            {
                MessageBox.Show("The file could not be read:", e1.Message);
            }

        }

        private void fTitle()
        {
            String sTitle = null;

            switch (mnFormnumber)
            {
                case 1:
                    sTitle = "Car1";
                    break;
                case 2:
                    sTitle = "Car2";
                    break;
                case 3:
                    sTitle = "Car3";
                    break;
                case 4:
                    sTitle = "Computer1";
                    break;
                case 5:
                    sTitle = "Computer2";
                    break;
                case 6:
                    sTitle = "Construction1";
                    break;
                case 7:
                    sTitle = "Construction2";
                    break;
                case 8:
                    sTitle = "Construction3";
                    break;
                case 9:
                    sTitle = "Garden1";
                    break;
                default:
                    sTitle = "Garden2";
                    break;
            }
            this.Text = sTitle;
        }

        public fBlank()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fBlank_Load(object sender, EventArgs e)
        {
            fGet();
            fTitle();
        }
    }
}
