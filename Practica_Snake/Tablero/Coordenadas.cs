using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Snake.Tablero
{
    public class Coordenadas
    {
        public int x;
        public int y;

        public Coordenadas(int x, int y)
        {
            // TODO: Complete member initialization
            this.x = x;
            this.y = y;
        }

        #region GETTERS Y SETTERS
        public int _x
        {
            get { return x; }
            set { x = value; }
        }

        public int _y
        {
            get { return y; }
            set { y = value; }
        } 
        #endregion

    }
}
