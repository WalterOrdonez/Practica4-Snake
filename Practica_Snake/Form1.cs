using System;
using System.Windows.Forms;

namespace Practica_Snake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            rectangleShape2.Width = 0;
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            try
            {
                rectangleShape2.Width += 3;
                if (rectangleShape2.Width >= 436)
                {
                    timerSplash.Stop();
                }
            }
            catch (Exception)
            {
                return;
            }
        }

    }
}
