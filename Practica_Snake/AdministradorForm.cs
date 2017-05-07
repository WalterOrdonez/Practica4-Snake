using System;
using System.Windows.Forms;

namespace Practica_Snake
{
    public partial class AdministradorForm : Form
    {
        private ListaUsuarioSingleton lst = ListaUsuarioSingleton.Instance;
        
        public AdministradorForm()
        {
            InitializeComponent();
        }

        private void AdministradorForm_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = lst.LstUsuario._administrador.getNombre();
        }

        private void btnTopT_Click(object sender, EventArgs e)
        {

        }

        private void btnTopPts_Click(object sender, EventArgs e)
        {

        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
