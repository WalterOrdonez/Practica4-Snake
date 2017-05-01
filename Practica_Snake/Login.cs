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
            caja.BackColor = Color.FromArgb(186, 54, 39);
        }

        private void LeaveTextBox(object sender, EventArgs e)
        {
            TextBox caja = (TextBox)sender;
            caja.BackColor = Color.FromArgb(235, 82, 66);
        }

    }
}
