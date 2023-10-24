using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Parcial2Pilas
{
    public partial class Form1 : Form
    {
        Form programa11 = new programa11();
        //Form miFomr = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form miFomr = new Form2();
            miFomr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form miFomr = new Form4();
            miFomr.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            programa11.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            programa12 foms12 = new programa12();
            foms12.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form3 = new Form5();
            form3.ShowDialog();
        }
    }
}