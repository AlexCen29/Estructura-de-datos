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
    public partial class Form4 : Form
    {
        Random miRandom = new Random();
        Stack<int> original = new Stack<int>();
        Stack<int> auxiliar = new Stack<int>();
        public Form4()
        {
            InitializeComponent();
            Llnear();
            listBox1.Items.Add(">>>Pila<<<");
            MostrarPila(original);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int viejo, nuevo;
            bool mostrar=true;

            
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Debes llenar todos los campos");
            }
            else
            {
                viejo = int.Parse(textBox1.Text);
                nuevo = int.Parse(textBox2.Text);

                foreach (var item in original)
                {
                    if (item == viejo) 
                    {
                        auxiliar.Push(nuevo);
                        mostrar= false;
                    }
                    else
                    {
                        auxiliar.Push(item);
                    }
                }
                original.Clear();
                foreach (var item in auxiliar)
                {
                    original.Push(item);
                }
                auxiliar.Clear();//la limpio para que no se acumulen los valores
                listBox1.Items.Clear();
                listBox1.Items.Add(">>>Pila<<<");
                MostrarPila(original);
                if (mostrar) MessageBox.Show("Numero viejo no encontrado");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        private void Llnear() 
        {
            for (int i = 0; i < 15; i++)
            {
                original.Push(miRandom.Next(1,100));
            }
        }
        public void MostrarPila(Stack<int> pila)
        {
            foreach (var digito in pila)
            {
                listBox1.Items.Add(digito);
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
       

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1_KeyPress(sender, e);
        }
    }
}
