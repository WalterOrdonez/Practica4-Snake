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
        Usuario Administrador;
        public Lista_Usuario()
        {
            Usuarios = new ArrayList();
            Administrador.setNombre("Admin_ORGA");
            Administrador.setPass("12345");
        }
        public void addUsuario(String Nombre, String Pass){
            Usuario nuevo=new Usuario();
            nuevo.setNombre(Nombre);
            nuevo.setPass(Pass);
            Usuarios.Add(nuevo);
        }
        public void deleteUsuario(String Nombre)
        {
            int posicion=buscarUsuario(Nombre);
            if (posicion>=0)
            {
                Usuarios.RemoveAt(posicion);
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
    }
}
