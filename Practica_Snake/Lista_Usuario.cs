using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Snake
{
    class Lista_Usuario 
    {
        ArrayList Usuarios;
        ArrayList Puntuaciones;
        ArrayList Tiempos;
        Usuario Administrador;

        #region GETTERS Y SETTERS
        public ArrayList _usuarios
        {
            get { return Usuarios; }
            set { Usuarios = value; }
        }
        public ArrayList _puntuaciones
        {
            get { return Puntuaciones; }
            set { Puntuaciones = value; }
        }
        public ArrayList _tiempos
        {
            get { return Tiempos; }
            set { Tiempos = value; }
        }
        public Usuario _administrador
        {
            get { return Administrador; }
            set { Administrador = value; }
        }
        #endregion

        public Lista_Usuario()
        {
            Usuarios = new ArrayList();
            Puntuaciones = new ArrayList();
            Tiempos = new ArrayList();
            Administrador = new Usuario();
            Administrador.setNombre("Admin_ORGA");
            Administrador.setPass("12345");
        }
        public void addUsuario(String Nombre, String Pass){
            Usuario nuevo=new Usuario();
            nuevo.setNombre(Nombre);
            nuevo.setPass(Pass);
            Usuarios.Add(nuevo);
            Puntuaciones.Add(nuevo);
            Tiempos.Add(nuevo);
        }
        public void deleteUsuario(String Nombre)
        {
            int posicion=buscarUsuario(Nombre);
            if (posicion>=0)
            {
                Usuarios.RemoveAt(posicion);
                posicion = buscarUsuario_Tiempo(Nombre);
                Tiempos.RemoveAt(posicion);
                posicion = buscarUsuario_Puntos(Nombre);
                Puntuaciones.RemoveAt(posicion);
            }
        }
        public int buscarUsuario(String Nombre)
        {
            foreach (Usuario u in Usuarios)
            {
                if (u.compararNombres(Nombre))
                {
                    return Usuarios.IndexOf(u);
                }
            }
            return -1;
        }

        public int buscarUsuario_Puntos(String Nombre)
        {
            foreach (Usuario u in Puntuaciones)
            {
                if (u.compararNombres(Nombre))
                {
                    return Puntuaciones.IndexOf(u);
                }
            }
            return -1;
        }

        public int buscarUsuario_Tiempo(String Nombre)
        {
            foreach (Usuario u in Tiempos)
            {
                if (u.compararNombres(Nombre))
                {
                    return Tiempos.IndexOf(u);
                }
            }
            return -1;
        }

        public bool validarUsuario(string nombre, string pass)
        {
            int cod = buscarUsuario(nombre);

            if (cod >= 0)
            {
                if (((Usuario)Usuarios[cod]).compararPass(pass))
                {
                    return true;
                }
            }
            return false;
        }

        private void ordenarTiempo()
        {
            Tiempos.Sort(new ComparaTiempos());
        }

        private void ordenarPuntos()
        {
            Puntuaciones.Sort(new ComparaPuntos());
        }

        public ArrayList generarReporteTiempo()
        {
            ordenarTiempo();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Tiempo.rep"))
            {
                foreach (Usuario U in Tiempos)
                {
                    file.WriteLine("Usuario: "+U.getNombre()+" Nivel: "+U.getNivel()+" Tiempo: "+U.getTiempo()+" seg");
                    file.WriteLine();
                }
            }
            return Tiempos;
        }

        public ArrayList generarReportePuntos()
        {
            ordenarPuntos();
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"Puntos.rep"))
            {
                foreach (Usuario U in Puntuaciones)
                {
                    file.WriteLine("Usuario: "+U.getNombre() + " Nivel: " + U.getNivel() + " Puntos: " + U.getPuntos());
                    file.WriteLine();
                }
            }
            return Puntuaciones;
        }

        public void modificarMarcas(String Nombre, int Nivel, int Puntos, int Tiempo)
        {
            int posicion = buscarUsuario(Nombre);
            try
            {
                Usuario Actual;
                Actual = (Usuario)Usuarios[posicion];
                Actual.setPuntos(Puntos);
                Actual.setTiempo(Tiempo);
                Actual.setNivel(Nivel);
            }
            catch (ArgumentOutOfRangeException error)
            {
                Console.WriteLine("Usuarios({0}) is out of range.", posicion);
            }
        }

        public bool validarAdmin(string user, string pass)
        {
            if (Administrador.getNombre().Equals(user,StringComparison.OrdinalIgnoreCase) && Administrador.getPass().Equals(pass))
                return true;
            else
                return false;
        }
    }

    public class ComparaTiempos : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Usuario)y).getTiempo() - ((Usuario)x).getTiempo();
        }
    }

    public class ComparaPuntos : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((Usuario)y).getPuntos() - ((Usuario)x).getPuntos();
        }
    }
}
