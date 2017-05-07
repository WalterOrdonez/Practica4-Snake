using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 

namespace Practica_Snake
{
    public partial class UsuarioForm : Form
    {
        private int id = -1;
        private ListaUsuarioSingleton lst = ListaUsuarioSingleton.Instance;
        private Juego juego;
        Double Total;
        
        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public UsuarioForm()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {
            /*
             * SETEAR USUARIO, PUNTOS Y NIVEL
             * */
            Usuario u = (Usuario) lst.LstUsuario._usuarios[id];
            txtUsuario.Text = u.getNombre();
            txtNivel.Text = u.getNivel().ToString();
            txtPts.Text = u.getPuntos().ToString();
            txtTiempo.Text = u.getTiempo().ToString();
            juego = new Juego(Total, timer1, u, txtPts, txtNivel);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //juego = new Juego(txtTiempo);
            timer1.Start();
            //Creamos el delegado 

            ThreadStart delegado = new ThreadStart(play_juego);
            //Creamos la instancia del hilo 
            Thread hilo = new Thread(delegado);
            //Iniciamos el hilo 
            hilo.Start(); 
        }

        private void play_juego()
        {
            juego.iniciar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            juego.parar();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Total = Convert.ToDouble(txtTiempo.Text);
            Total = Total + 1;
            txtTiempo.Text = Total.ToString();
        }

        private void UsuarioForm_KeyDown_1(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Left:
                    juego.Izquierda();
                    break;
                case Keys.Right:
                    juego.Derecha();
                    break;
                case Keys.Down:
                    juego.Abajo();
                    break;
                case Keys.Up:
                    juego.Arriba();
                    break;
                case Keys.A:
                    juego.Comer();
                    break;
                default:
                    break;
            }
        }

        private void txtNivel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
