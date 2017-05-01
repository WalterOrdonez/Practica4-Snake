using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Practica_Snake
{
    public partial class LoginForm : Form
    {
        Registro registro = new Registro();
        Login login = new Login();

        public LoginForm()
        {
            Thread hilo = new Thread(new ThreadStart(StartSplash));
            hilo.Start();
            Thread.Sleep(7000);

            InitializeComponent();

            hilo.Abort();
        }

        private void StartSplash()
        {
            Application.Run(new Form1());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            pnlfrmRegistro.Size = new Size(520, 405);
            pnlfrmRegistro.Location = new Point(0, 100);
            pnlfrmRegistro.Hide();

            pnlfrmLogin.Size = new Size(520, 405);
            pnlfrmLogin.Location = new Point(0, 100);
            pnlfrmLogin.Hide();

            registroC();
        }

        private void buttonRegistro_Click(object sender, EventArgs e)
        {
            registroC();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginC();
        }

        #region TABPAGES
        private void loginC()
        {
            login.TopLevel = false;
            pnlfrmLogin.Controls.Add(login);
            login.FormBorderStyle = FormBorderStyle.None;
            login.Dock = DockStyle.Fill;
            login.Show();
            buttonLogin.BackColor = Color.FromArgb(235, 82, 66);
            buttonRegistro.BackColor = Color.FromArgb(186, 56, 39);
            pnlfrmLogin.Show();
            pnlfrmRegistro.Hide();
        }
        private void registroC()
        {
            registro.TopLevel = false;
            pnlfrmRegistro.Controls.Add(registro);
            registro.FormBorderStyle = FormBorderStyle.None;
            registro.Dock = DockStyle.Fill;
            registro.Show();
            buttonLogin.BackColor = Color.FromArgb(186, 56, 39);
            buttonRegistro.BackColor = Color.FromArgb(235, 82, 66);
            pnlfrmRegistro.Show();
            pnlfrmLogin.Hide();
        }
        #endregion
    }
}
