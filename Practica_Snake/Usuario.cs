using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Snake
{
    class Usuario
    {
        String nombre;
        String pass;
        public void setNombre(String nom)
        {
            this.nombre = nom;
        }
        public void setPass(String pas)
        {
            this.pass = pas;
        }

        public String getNombre()
        {
            return this.nombre;
        }
        public String getPass()
        {
            return this.pass;
        }
        public bool compararNombres(String nom)
        {
            return (this.nombre.Equals(nom, StringComparison.OrdinalIgnoreCase));
        }
        public bool compararPass(String pass)
        {
            return (this.pass.Equals(pass, StringComparison.OrdinalIgnoreCase));
        }
    }
}
