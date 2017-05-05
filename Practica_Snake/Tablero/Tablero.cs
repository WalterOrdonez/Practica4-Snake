using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Snake.Tablero
{
    class Tablero
    {
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
                Console.Write("1\t");
                for (int j = 0; j < 12; j++)
                {
                    Console.Write(tablero[i, j] + "\t");
                }
                Console.WriteLine("0");
            }
        }
    }
}
