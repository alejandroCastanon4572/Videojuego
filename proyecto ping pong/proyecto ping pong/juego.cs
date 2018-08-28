using System;
using System.Drawing;
using System.Windows.Forms;


namespace proyecto_ping_pong
{
    public partial class juego : Form
    {
        public juego()
        {
            InitializeComponent();
        }

        int velocidad = 5;
        int cont = 0;
        int puntaje = 0;

        bool Arriba;
        bool Izquierda;



        private void juego_Load(object sender, EventArgs e)
        {

            this.Text = "Puntaje: 0";
            Random aleatorio = new Random();
            pictureBox1.Location = new Point(0, aleatorio.Next(this.Height));
            Arriba = true;
            Izquierda = true;
            timer1.Enabled = true;
            puntaje = 0;
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Left > pictureBox2.Left)
            {
                timer1.Enabled = false;
                MessageBox.Show("Puntaje:" + puntaje.ToString() + "veces!", "Atencion");
                puntaje = 0;
                velocidad = 5;
                cont = 0;
            }

                if (Izquierda)
                {
                    pictureBox1.Left += velocidad;
                }
                else
                {
                    pictureBox1.Left -= velocidad;
                }
                if (Arriba)
                {
                    pictureBox1.Top += velocidad;
                }
                else
                {
                    pictureBox1.Top -= velocidad;
                }
                if (pictureBox1.Top >= this.Height - 60)
                {
                    Arriba = false;
                }
                if (pictureBox1.Top <= 0)
                {
                    Arriba = true;
                }
                if (pictureBox1.Left <= 0)
                {
                    Izquierda = true;
                }
            if (pictureBox1.Left + pictureBox1.Width >= pictureBox2.Left &&
           pictureBox1.Left + pictureBox1.Width <= pictureBox2.Left + pictureBox2.Width &&
           pictureBox1.Top + pictureBox1.Height >= pictureBox2.Top &&
           pictureBox1.Top + pictureBox1.Height <= pictureBox2.Top + pictureBox2.Height)
            {
                Izquierda = false;
                puntaje += 1;
                this.Text = "puntuacion:" + puntaje.ToString() + "";
                cont += 1;
                if (cont > 5)
                {
                    velocidad += 1;
                    cont = 0;
                }
            }
        }
        private void juego_FormClosing(object sender, FormClosedEventArgs e)
        {
            Owner.Close();

        }
        private void juego_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Top = e.Y;
        }
    }
}