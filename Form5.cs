using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2Pilas
{
    public partial class Form5 : Form
    {
        int turnoAuto = 1;
        Cliente miCliente;
        Queue<Cliente> misClientes = new Queue<Cliente>();

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text) || comboBox1.Text == "Movimiento")
            {
                MessageBox.Show("Llena todos los campos");
            }
            else
            {
                if (ColaLleno())
                {
                    miCliente = new Cliente(turnoAuto, textBox2.Text, comboBox1.Text, DateTime.Now);
                    misClientes.Enqueue(miCliente);
                    turnoAuto++;
                    textBox2.Clear();
                    textBox1.Text = turnoAuto.ToString();
                    MensajeLlegada(miCliente);
                    ActualizarDataGrid();
                }
                else
                {
                    MessageBox.Show("Cola llena");
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ColaVacia())
            {
                EliminaCola();
                ActualizarDataGrid();
            }
            else
            {
                MessageBox.Show("Cola vacia");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ActualizarDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in misClientes)
            {
                dataGridView1.Rows.Add(item.Turno, item.Nombre, item.Tipo, item.Fecha);
            }
            //textBox3.Text = (misClientes.Count > 0) ? misClientes.Peek().Turno.ToString() : "";
            int temp = turnoAuto;
            temp--;
            textBox4.Text = (misClientes.Count > 0) ? temp.ToString() : "";
        }
        public void EliminaCola()
        {
            textBox3.Text = (misClientes.Count > 0) ? misClientes.Peek().Turno.ToString() : "";
            MensajeSalida(misClientes.Dequeue());
            textBox3.Text = "";
        }
        public bool ColaLleno()
        {
            if (misClientes.Count < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ColaVacia()
        {
            if (misClientes.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void MensajeLlegada(Cliente esteMen)
        {
            string mensaje = "Cliente formado en la cola:\n";
            mensaje += "No. Turno: " + esteMen.Turno + "\n";
            mensaje += "Nombre: " + esteMen.Nombre + "\n";
            mensaje += "Tipo de movimiento: " + esteMen.Tipo + "\n";
            mensaje += "Hora de llegada: " + esteMen.Fecha;

            MessageBox.Show(mensaje, "Se agrego un cliente al final de la cola", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void MensajeSalida(Cliente esteMen)
        {
            TimeSpan espera = DateTime.Now - esteMen.Fecha;
            string mensaje = "Cliente atendido: " + esteMen.Nombre + "\n";
            mensaje += "Tiempo de espera en la cola: " + espera.Minutes + " minutos y " + espera.Seconds + " segundos";

            MessageBox.Show(mensaje, "Tiempo de espera en la cola", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    public class Cliente
    {
        public int Turno { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }

        public Cliente(int turno, string nombre, string tipo, DateTime fecha)
        {
            Turno = turno;
            Nombre = nombre;
            Tipo = tipo;
            Fecha = fecha;
        }
    }
}
