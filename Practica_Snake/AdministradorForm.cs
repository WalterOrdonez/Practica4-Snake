using System;
using System.Diagnostics;
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
            lst.LstUsuario.generarReporteTiempo();
            Process.Start("Tiempo.rep");
        }

        private void btnTopPts_Click(object sender, EventArgs e)
        {
            lst.LstUsuario.generarReportePuntos();
            Process.Start("Puntos.rep");
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            lstbxUsuarios.Items.Clear();
            foreach (Usuario u in lst.LstUsuario._usuarios)
            {
                lstbxUsuarios.Items.Add(u.getNombre());
            }
        }

        private void btnEliminarUsuarios_Click(object sender, EventArgs e)
        {
            if (lstbxUsuarios.SelectedItem != null)
            {
                string usuario = lstbxUsuarios.SelectedItem.ToString();
                lst.LstUsuario.deleteUsuario(usuario);
            }

            btnVerUsuarios_Click(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
