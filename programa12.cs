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
    public partial class programa12 : Form
    {
        int contador = 1;
        Queue<Automovil> cola_automoviles = new Queue<Automovil>();
        List<Automovil> historial_automoviles = new List<Automovil> { };
        public programa12()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel1.Visible = false;
            listBox1.Visible = false;
            listBox2.Visible = false;

        }

        private void programa12_Load(object sender, EventArgs e)
        {

        }
        public void EntradaCarros(string nombre, string placa)
        {
            Automovil auto = new Automovil(historial_automoviles.Count + 1, nombre, placa, DateTime.Now);


            cola_automoviles.Enqueue(auto);
            historial_automoviles.Add(auto);
            contador++;
            listBox1.Items.Clear();//esto faltaba
            foreach (Automovil item in cola_automoviles)
            {
                if (!listBox1.Items.Contains(item.nombre)) { listBox1.Items.Add("placas: " + item.placas + "     nombre: " + item.nombre + "     fecha: " + item.tiempoentrada); }

            }


            listBox2.Items.Clear();
            foreach (Automovil item in cola_automoviles)
            {
                listBox2.Items.Add("placas: " + item.placas + "     nombre: " + item.nombre + "     fecha: " + item.tiempoentrada);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            panel2.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length > 0 && textBox4.Text.Length > 0)
            {
                EntradaCarros(textBox3.Text, textBox4.Text);
                MessageBox.Show($"AGREGADO CORRACTAMENTE\n Nombre: {textBox3.Text}\n Placas: {textBox4.Text}\n HORA: {DateTime.Now}");
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("COMPLETA LOS DATOS");
                textBox3.Clear();
                textBox4.Clear();
            }


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            panel1.Visible = true;
        }
        public void salidaAutomoviles()
        {
            if (cola_automoviles.Count > 0)
            {
                Automovil auto = cola_automoviles.Dequeue();
                double costo = CalcularCosto(auto);
                MessageBox.Show($"Salio Correctamente \n Nombre: {auto.nombre}\n Placas: {auto.placas}\n Hora de entrada: {auto.tiempoentrada}\n Hora de salida: {DateTime.Now}\n Precio: {costo}");

                listBox2.Items.Clear();
                foreach (Automovil item in cola_automoviles)
                {
                    listBox2.Items.Add("placas: " + item.placas + "     nombre: " + item.nombre + "     fecha: " + item.tiempoentrada);
                }

            }
            else
            {
                MessageBox.Show("NO HAY AUTOS EN LA COLA");
            }
        }
        public double CalcularCosto(Automovil automovil)
        {
            DateTime tiempoSalida = DateTime.Now;
            TimeSpan tiempoEnCola = tiempoSalida - automovil.tiempoentrada;

            int tiempoEnSegundos = (int)tiempoEnCola.TotalSeconds;

            double costoPorSegundo = 2.0;

            double costoTotal = tiempoEnSegundos * costoPorSegundo;

            return costoTotal;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            salidaAutomoviles();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Visible = true;
            button1.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox2.Visible = true;


        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
            listBox2.Visible = false;
        }
    }
    public class Automovil
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string placas { get; set; }

        public DateTime tiempoentrada { get; set; }

        public Automovil(int Id, string Nombre, string Placas, DateTime TiempoEntrada)
        {
            this.id = Id;
            this.nombre = Nombre;
            this.placas = Placas;
            this.tiempoentrada = TiempoEntrada;

        }
    }
}
