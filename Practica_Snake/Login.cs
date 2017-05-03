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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void EnterLabel(object sender, EventArgs e)
        {
            TextBox caja = (TextBox) sender;
            caja.BackColor = Color.FromArgb(192, 57, 43);
        }

        private void LeaveTextBox(object sender, EventArgs e)
        {
            TextBox caja = (TextBox)sender;
            caja.BackColor = Color.FromArgb(231, 76, 60);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            Lista_Usuario lst = ListaUsuarioSingleton.Instance.LstUsuario;

            if (lst.validarUsuario(textBoxNombre.Text,textBoxPass.Text))
            {
                UsuarioForm u = new UsuarioForm();
                u._id = lst.buscarUsuario(textBoxNombre.Text);
                u.Show();
            }
            else if (lst.validarAdmin(textBoxNombre.Text, textBoxPass.Text))
            {
                AdministradorForm a = new AdministradorForm();
                a.Show();
            } else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta");
            }

            textBoxNombre.Text = "";
            textBoxPass.Text = "";
        }
    }
}
