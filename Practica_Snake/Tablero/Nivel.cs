using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Snake.Tablero
{
    public class Nivel
    {
        public List<Object> nivel1 = new List<Object>();
        public List<Object> nivel2 = new List<Object>();
        public List<Object> nivel3 = new List<Object>();

        public Nivel()
        {
            
            agregarNiveles();
        }

        /*

        #region GETTERS Y SETTERS
        public List<Coordenadas> _nivel1
        {
            get { return nivel1; }
            set { nivel1 = value; }
        }
        public List<Coordenadas> _nivel2
        {
            get { return nivel2; }
            set { nivel2 = value; }
        }
        public List<Coordenadas> _nivel3
        {
            get { return nivel3; }
            set { nivel3 = value; }
        }
        #endregion
        
        */

        private void agregarNiveles()
        {
            for (int i = 0; i <= 3; i++)
            {
                /*
                 * SETEAR NIVEL 1
                 * */
                nivel1.Add(new Coordenadas(0, i));
                nivel1.Add(new Coordenadas(11, i));
                nivel1.Add(new Coordenadas(0, i + 8));
                nivel1.Add(new Coordenadas(11, i + 8));
                nivel1.Add(new Coordenadas(i + 4, 2));
                nivel1.Add(new Coordenadas(i + 4, 9));
                /*
                 * SETEAR NIVEL 2
                 * */
                nivel3.Add(new Coordenadas(0, i));
                nivel3.Add(new Coordenadas(11, i));
                nivel3.Add(new Coordenadas(0, i + 8));
                nivel3.Add(new Coordenadas(11, i + 8));
                nivel3.Add(new Coordenadas(i, 0));
                nivel3.Add(new Coordenadas(i, 11));
                nivel3.Add(new Coordenadas(i + 8, 0));
                nivel3.Add(new Coordenadas(i + 8, 11));
                /*
                 * SETEAR NIVEL 3
                 * */
                nivel3.Add(new Coordenadas(0, i));
                nivel3.Add(new Coordenadas(11, i));
                nivel3.Add(new Coordenadas(0, i + 8));
                nivel3.Add(new Coordenadas(11, i + 8));
                nivel3.Add(new Coordenadas(i, 0));
                nivel3.Add(new Coordenadas(i, 11));
                nivel3.Add(new Coordenadas(i + 8, 0));
                nivel3.Add(new Coordenadas(i + 8, 11));
            }

            for (int i = 4; i < 9; i++)
            {
                nivel3.Add(new Coordenadas(3, i));
                nivel3.Add(new Coordenadas(8, i));
            }
        }
    }
}
