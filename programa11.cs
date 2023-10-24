using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Threading;
using System.Windows.Forms;

namespace Parcial2Pilas
{
    public partial class programa11 : Form

    {
        Queue<Carro> lista_carros = new Queue<Carro>();
        Random random = new Random();
        private System.Windows.Forms.Timer creacionCarros;
        private int tiempoTranscurrido = 0;

        private System.Windows.Forms.Timer timerActualizarColores;
        int contador = 0;

        private int[] posicionesDestino = { 94, 252, 429, 618, 793 };
        private int segundosTranscurridos = 0;
        Dictionary<int, Color> coloresCarros = new Dictionary<int, Color>()
        {
            { 1, Color.FromArgb(255, 192, 192) },
            { 2, Color.FromArgb(255, 224, 192)},
            { 3, Color.FromArgb(192, 255, 192)},
            { 4, Color.FromArgb(192, 255, 255)},
            { 5, Color.FromArgb(192, 192, 255)},
            { 6, Color.FromArgb(255, 128, 128)},
            { 7, Color.FromArgb(255, 192, 128)},
            { 8, Color.FromArgb(128, 255, 128)},
            { 9, Color.FromArgb(128, 255, 255)},
            { 10, Color.FromArgb(128, 128, 255)},
            { 11, Color.Red},
            { 12, Color.FromArgb(255, 128, 0)},
            { 13, Color.Lime},
            { 14, Color.Cyan},
            { 15, Color.Blue}


        };
        public programa11()
        {
            InitializeComponent();
            panel1.Visible = false;

            CreateCarro();
            timerActualizarColores = new System.Windows.Forms.Timer();
            timerActualizarColores.Interval = 500;
            timerActualizarColores.Tick += new EventHandler(timerActualizarColores_Tick);
            timerActualizarColores.Start();
            foreach (Button boton in panel1.Controls.OfType<Button>())
            {
                boton.Click += Boton_Click;
            }



        }
        private void timerActualizarColores_Tick(object sender, EventArgs e)
        {
            AsignarColoresALabels();
        }



        private void AsignarColoresALabels()
        {
            Label[] labels = { label3, label4, label5, label6, label7 };

            for (int i = 0; i < labels.Length; i++)
            {
                if (lista_carros.Count > i)
                {
                    
                    labels[i].Text = "COLOR A PINTAR";
                    labels[i].BackColor = lista_carros.ElementAt(i).color;
                }
                else
                {
                    labels[i].Text = "Enfilandose...";
                    labels[i].BackColor = Color.White;
                }
            }
        }
       
        private void Boton_Click(object sender, EventArgs e)
        {
            Button botonPresionado = (Button)sender;
            int botonId = Convert.ToInt32(botonPresionado.Name.Replace("button", ""));

            Color colorBotonPresionado = botonPresionado.BackColor;

            if (lista_carros.Count > 0 && lista_carros.Peek().color == colorBotonPresionado)
            {
                Carro primerCarro = lista_carros.Peek();
                primerCarro.pictureBox.BackColor = colorBotonPresionado;


                System.Windows.Forms.Timer timerEliminarCarro = new System.Windows.Forms.Timer();
                timerEliminarCarro.Interval = 1000;
                timerEliminarCarro.Tick += (s, ev) =>
                {

                    lista_carros.Dequeue();
                    Controls.Remove(primerCarro.pictureBox);
                    primerCarro.pictureBox.Dispose();
                    timerEliminarCarro.Stop();//detiene mi timer

                    //contador
                    contador++;
                    label8.Text = contador.ToString() + " eliminados";
                };
                timerEliminarCarro.Start();
            }
        }






        private string ObtenerNombreColor(int colorID)
        {
            switch (colorID)
            {
                case 1:
                    return "Rojo Claro";
                case 2:
                    return "Naranja Claro";
                case 3:
                    return "Verde Claro";
                case 4:
                    return "Turquesa Claro";
                case 5:
                    return "Azul Claro";
                case 6:
                    return "Rojo Oscuro";
                case 7:
                    return "Naranja Oscuro";
                case 8:
                    return "Verde Oscuro";
                case 9:
                    return "Turquesa Oscuro";
                case 10:
                    return "Azul Oscuro";
                case 11:
                    return "Rojo Intenso";
                case 12:
                    return "Naranja Intenso";
                case 13:
                    return "Verde Lima";
                case 14:
                    return "Cian";
                case 15:
                    return "Azul Intenso";
                default:
                    return "Color Desconocido";
            }

        }




        private void creacionCarros_Tick(object sender, EventArgs e)
        {

            if (lista_carros.Count < 5)
            {
                CreateCarro();

                tiempoTranscurrido += creacionCarros.Interval / 1000;
                if (contador == 3) // Después de 1 minuto
                {
                    creacionCarros.Interval = 5000; // Cambia a 5 segundos
                }
                else if (contador == 6) // Después de 1 minuto y 30 segundos
                {
                    creacionCarros.Interval = 3000; // Cambia a 3 segundos
                }
                else if (contador == 9) // Después de 1 minuto y 35 segundos
                {
                    creacionCarros.Interval = 1000; // Cambia a 1 segundo
                }

            }
        }

        public void MoverCarros()
        {
            int desplazamiento = 1;
            for (int i = 0; i < lista_carros.Count; i++)
            {
                Carro carro = lista_carros.ElementAt(i);
                int posXDestino = posicionesDestino[i];


                if (carro.pictureBox.Location.X < posXDestino)
                {
                    carro.pictureBox.Location = new Point(carro.pictureBox.Location.X + desplazamiento, 414);
                }
                else
                {
                    carro.pictureBox.Location = new Point(posXDestino, 414);
                }
            }
        }



        public void ComprobarLlegadaDestino()
        {
            foreach (Carro carro in lista_carros)
            {
                int posXDestino = posicionesDestino[lista_carros.ToList().IndexOf(carro)];
                if (carro.pictureBox.Location.X == posXDestino)
                {
                    //por si quiero realizar una accion cuando llegue a su destino
                }
            }
        }
        public void CreateCarro()
        {
            if (lista_carros.Count < 5)
            {
                timerMovimientoCarros.Start();
                int[] posicionesDestino = { 94, 252, 429, 618, 793 };
                int posXDestino = posicionesDestino[4];

                Color carroColor = coloresCarros[random.Next(1, 15)];
                bool pintado = false;
                label2.Text = "carro nuevo";

                PictureBox pictureBox = new PictureBox();
                pictureBox.Name = "pictureBox" + DateTime.Now.Ticks.ToString();
                pictureBox.BackColor = Color.White;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = new Size(125, 62);
                pictureBox.Image = Properties.Resources.auto;
                pictureBox.ImageLocation = "";
                pictureBox.Location = new Point(posXDestino, 425);
                pictureBox.Visible = true;



                var carro = new Carro(carroColor, pintado, pictureBox);
                lista_carros.Enqueue(carro);

                this.Controls.Add(pictureBox);

                this.Update();
            }
            if (lista_carros.Count == 5)
            {
                MessageBox.Show($"Game Over\n Eliminados: {contador++}\n Tiempo: {tiempoTranscurrido}");
                this.Close();
                return;
            }

        }












        private void programa11_Load(object sender, EventArgs e)
        {

            label1.Text = "0 segundos.";
            label2.Text = "Esperando inicio...";


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            segundosTranscurridos++;
            label1.Text = segundosTranscurridos.ToString() + " segundos.";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            creacionCarros = new System.Windows.Forms.Timer();
            creacionCarros.Interval = 20000;
            creacionCarros.Tick += new EventHandler(creacionCarros_Tick);

            timerInicio.Start();
            creacionCarros.Start();

            button16.Visible = false;
            panel1.Visible = true;
        }

        private void timerCreacionCarros_Tick(object sender, EventArgs e)
        {
            CreateCarro();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            EliminarPrimerCarro();


            MoverCarros();
        }

        private void timerMovimientoCarros_Tick(object sender, EventArgs e)
        {
            MoverCarros();
            ComprobarLlegadaDestino();
        }
        private void EliminarPrimerCarro()
        {
            if (lista_carros.Count > 0)
            {
                Carro primerCarro = lista_carros.Dequeue();
                Controls.Remove(primerCarro.pictureBox);
                primerCarro.pictureBox.Dispose();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


    }

    public class Carro
    {
        public Color color { get; set; }
        public bool Estado { get; set; }
        public PictureBox pictureBox { get; set; }


        public Carro(Color color, bool estado, PictureBox pictureBox)
        {
            this.color = color;
            this.Estado = estado;
            this.pictureBox = pictureBox;


        }


    }


}
