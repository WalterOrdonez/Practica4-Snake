using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_Snake.Tablero
{
    class Tablero
    {
        private int ADRESS = 888;
        private int DATO = 0;
        private int RELOJ = 0;
        private int[,] tablero = new int[12, 12];

        public Tablero()
        {
            setNivel(0);
        }

        public void setNivel(int nivel)
        {
            Nivel n = new Nivel();

            switch (nivel)
            {
                case 1:
                    foreach (Coordenadas item in n.nivel1)
                    {
                        tablero[item._x, item._y] = 1;
                    }
                    break;
                case 2:
                    foreach (Coordenadas item in n.nivel2)
                    {
                        tablero[item._x, item._y] = 1;
                    }
                    break;
                case 3:
                    foreach (Coordenadas item in n.nivel3)
                    {
                        tablero[item._x, item._y] = 1;
                    }
                    break;
                default:
                    for (int i = 0; i < 12; i++)
                    {
                        for (int j = 0; j < 12; j++)
                        {
                            tablero[i, j] = 0;
                        }
                    }
                    break;
            }
        }

        public void setSnake()
        {

        }

        public void enviarDatos()
        {
            for (int i = 0; i < 12; i++)
            {
                PortAccess.Output(ADRESS, 1);
                MessageBox.Show("DATO " + 1);
                PortAccess.Output(ADRESS, 3);
                MessageBox.Show("DATO " + 3);
                Console.Write("1\t");

                for (int j = 0; j < 12; j++)
                {
                    PortAccess.Output(ADRESS, tablero[i, j]);
                   // MessageBox.Show("DATO " + tablero[i, j]);
                    PortAccess.Output(ADRESS, tablero[i, j] + 2);
                    //MessageBox.Show("DATO " + tablero[i, j] + 2);

                    Console.Write(tablero[i, j] + "\t");
                }

                PortAccess.Output(ADRESS, 0);
                //MessageBox.Show("DATO " + 0);
                PortAccess.Output(ADRESS, 2);
                //MessageBox.Show("DATO " + 2);
                Console.WriteLine("0");
            }
        }
    }
}
