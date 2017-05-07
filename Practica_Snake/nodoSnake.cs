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
        nodoSnake anterior;
        public nodoSnake()
        {
            x = 0;
            y = 0;
            siguiente = null;
            anterior = null;
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
        public void setAnterior(nodoSnake anterior)
        {
            this.anterior = anterior;
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
        public nodoSnake getAnterior()
        {
            return this.anterior;
        }
    }
}
