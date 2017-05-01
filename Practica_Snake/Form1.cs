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
                rectangleShape2.Width += 1;
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
