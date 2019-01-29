using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinkelaVitoMonthClaendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btm1_Click(object sender, EventArgs e)
        {
            //objektu klase TimeSpan se dodjeljuju vrijednosti s kalandara
            TimeSpan ts = mCal1.SelectionEnd - mCal1.SelectionStart;

            //ako je broj odabranih dana manji od 1
            if (ts.Days < 1)
            {
                MessageBox.Show("Uporabom tipke SHIFT odaberite više dana.");
                return;
            }

            //ispisuje koliko je dana odabrano
            MessageBox.Show("Izabrali ste " + ts.Days.ToString() + " dana.", "Rezervacija");

            //ispisuje izabrani interval
            MessageBox.Show("Vaša rezervacija počinje " + mCal1.SelectionStart.ToShortDateString() + ", a završava " + mCal1.SelectionEnd.ToShortDateString());
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.Show();
        }
    }
}
