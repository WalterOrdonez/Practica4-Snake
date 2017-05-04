using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Snake
{
    class Snake
    {
        const int derecha = 1;
        const int arriba = 2;
        const int izquierda = 3;
        const int abajo = 4;
        
        nodoSnake Cabeza;
        nodoSnake Ultimo;
        int direccion;
        
        public Snake()
        {
            Cabeza = new nodoSnake();
            Cabeza.setX(4);
            Cabeza.setY(2);
            direccion = 1;
        }
        public void Crecer()
        {

        }

    }
}
