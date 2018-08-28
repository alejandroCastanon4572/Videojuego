using System;
using System.Windows.Forms;

namespace proyecto_ping_pong
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            juego ventanajuego = new juego();

            ventanajuego.Show(this);
          
     
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
