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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void EnterLabel(object sender, EventArgs e)
        {
            TextBox caja = (TextBox)sender;
            caja.BackColor = Color.FromArgb(186, 54, 39);
        }

        private void LeaveTextBox(object sender, EventArgs e)
        {
            TextBox caja = (TextBox)sender;
            caja.BackColor = Color.FromArgb(235, 82, 66);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxFirstName.Text = "";
            textBoxPass.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Lista_Usuario lst = ListaUsuarioSingleton.Instance.LstUsuario;

            lst.addUsuario(textBoxFirstName.Text, textBoxPass.Text);

            buttonReset_Click(sender, e);
        }
    }
}
