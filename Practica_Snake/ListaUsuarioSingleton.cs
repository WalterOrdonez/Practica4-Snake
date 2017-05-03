using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Snake
{
    class ListaUsuarioSingleton
    {
        private static ListaUsuarioSingleton instance = null;
        private Lista_Usuario lstUsuario;

        protected ListaUsuarioSingleton()
        {
            lstUsuario = new Lista_Usuario();
        }

        public static ListaUsuarioSingleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListaUsuarioSingleton();

                return instance;
            }
        }

        public Lista_Usuario LstUsuario
        {
            get { return lstUsuario; }
            set { lstUsuario = value; }
        }
    }
}
