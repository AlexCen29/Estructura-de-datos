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

        private void button3_Click(object sender, EventArgs e)
        {
            Form miFomr = new Form5();
            miFomr.Show();
        }
    }
}