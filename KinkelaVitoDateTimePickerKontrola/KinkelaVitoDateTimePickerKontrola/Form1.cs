using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinkelaVitoDateTimePickerKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //upisuje neki početni tekst u text box
            richTextBox1.Text="Odaberite podatke.";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonRezervacija_Click(object sender, EventArgs e)
        {
            //čisti text box
            richTextBox1.Clear();

            //definira objekt dt1 klase DateTime i dodijeljuje mu vrijednost
            DateTime dt1 = dateTimePickerDatum.Value;

            //definira objekt sb1 klase StringBuilder te mu dodijeljuje neke vrijdnosti
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Vas datum leta je:\n");
            sb1.Append(dt1.ToShortDateString());

            //definira objekt dt2 klase DateTime i dodijeljuje mu vrijednosti
            DateTime dt2 = dateTimePickerVrijeme.Value;
            sb1.Append("\r\nVrijeme polaska je:\n");
            sb1.Append(dt2.ToShortTimeString());

            //upisuje u text box
            richTextBox1.AppendText(sb1.ToString());
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //definitra drugu formu
            Form2 oProgramu = new Form2();
            oProgramu.Show();
        }
    }
}
