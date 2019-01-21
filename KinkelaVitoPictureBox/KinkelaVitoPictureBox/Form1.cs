using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinkelaVitoPictureBox
{
    public partial class Form1 : Form
    {
        bool a = false;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Hide();
            textBox1.Hide();
            
        }

        private void btm1_Click(object sender, EventArgs e)
        {

            
            if (!a)
            {
                pictureBox1.Show();              
            }
            else
            {
                pictureBox1.Hide();
            }
            a = !a;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
