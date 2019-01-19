using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KinkelaVitoRichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //kreira string
            string tekst = richTxtBox.Text;

            //provjerava postoji li krajnja datoteka, te ako ne postoji je napravi
            /*if (File.Exists(@"TempProba.rtf"))
            {
                StreamWriter pisanje = new StreamWriter(@"C:\TempProba.rtf");
            }
            else
            {
                File.Create(@"C:\TempProba.rtf");
                StreamWriter pisanje = new StreamWriter(@"C:\TempProba.rtf");
            }*/

        }

        //Upisuje iz textboxa u datoteku
        private void btm2_Click(object sender, EventArgs e)
        {
            /*pisanje.WriteLine(tekst);
            pisanje.Close();*/

            richTxtBox.SaveFile(@"C:TempProba.rtf");
            MessageBox.Show("Tekst spremljen");
        }

        private void richTxtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        //ispisuje iz datoteke u textbox
        private void btm1_Click(object sender, EventArgs e)
        {
            /*while (!pisanje.EndOfStream)
            {
                richTxtBox.Text = +pisanje.ReadLine();
            }
            pisanje.Close();*/

            richTxtBox.LoadFile(@"C:TempProba.rtf");
        }

        //Izbriše sadržaj textboxa
        private void btm3_Click(object sender, EventArgs e)
        {
            richTxtBox.Clear();
        }
    }
}
