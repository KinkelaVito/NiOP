using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinkelaVitoImageList
{
    public partial class Form1 : Form
    {
        bool a = true;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imageList1.Images[0];
        }

        private void btm1_Click(object sender, EventArgs e)
        {
            if (a)
            {
                pictureBox1.Image = imageList1.Images[0];
            }
            else
            {
                pictureBox1.Image = imageList1.Images[1];
            }

            a = !a;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 licenca = new Form2();
            licenca.Show();
        }
    }
}
