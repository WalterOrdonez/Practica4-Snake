using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Snake
{
    public partial class UsuarioForm : Form
    {
        private int id = -1;
        private ListaUsuarioSingleton lst = ListaUsuarioSingleton.Instance;
        
        public int _id
        {
            get { return id; }
            set { id = value; }
        }

        public UsuarioForm()
        {
            InitializeComponent();
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
        }

        private void ActualizarDatos()
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
