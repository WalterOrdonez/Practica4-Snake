using System;

namespace Practica_Snake
{
    class Usuario
    {
        String nombre;
        String pass;
        int nivel;
        int puntos;
        int tiempo;

        public void setNombre(String nom)
        {
            this.nombre = nom;
        }
        public void setPass(String pas)
        {
            this.pass = pas;
        }
        public void setNivel(int niv)
        {
            this.nivel = niv;
        }
        public void setPuntos(int puntos)
        {
            this.puntos = puntos;
        }
        public void setTiempo(int Tiempo)
        {
            this.tiempo = Tiempo;
        }
        public int getTiempo()
        {
            return this.tiempo;
        }
        public int getPuntos()
        {
            return this.puntos;
        }
        public int getNivel()
        {
            return this.nivel;
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
            return (this.pass.Equals(pass));
        }
    }
}
