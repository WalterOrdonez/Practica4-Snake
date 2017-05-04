using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Snake
{
    class nodoSnake
    {
        int x;
        int y;
        nodoSnake siguiente;
        public nodoSnake()
        {
            x = 0;
            y = 0;
            siguiente = null;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setSiguiente(nodoSnake siguiente)
        {
            this.siguiente = siguiente;
        }
        public int getX()
        {
            return this.x;
        }
        public int getY()
        {
            return this.y;
        }
        public nodoSnake getSiguiente()
        {
            return this.siguiente;
        }
    }
}
