using System;
using System.Windows.Forms;
using System.Threading;

namespace Practica_Snake
{
    class Juego
    {
        int puntos;
        double tiempo;
        int nivel;
        int velocidad;
        Usuario usuario;
        System.Windows.Forms.Timer timer;
        bool ganador;
        bool play;
        Snake serpiente;
        TextBox txtPuntos;
        TextBox txtNivel;

        public Juego(double tiempo, System.Windows.Forms.Timer timer, Usuario usuario, TextBox txtPuntos, TextBox txtNivel)
        {
            this.velocidad = 1000;
            this.puntos = 0;
            this.nivel = 0;
            this.usuario = usuario;
            this.timer=timer;
            this.txtNivel = txtNivel;
            this.txtPuntos = txtPuntos;
            ganador = false;
            serpiente = new Snake();
            play = false;
        }
        public void parar()
        {
            timer.Stop();
            play = false;
            usuario.setNivel(this.nivel);
            int tiempo_int = Convert.ToInt32(this.tiempo);
            usuario.setTiempo(tiempo_int);
            usuario.setPuntos(puntos);
            txtPuntos.Text = puntos.ToString();
            txtNivel.Text = nivel.ToString();
        }
        public void iniciar()
        {
            play=true;
            while (play && !ganador)
            {
                serpiente.Avanzar();
                Thread.Sleep(velocidad);
            }
            parar();
        }
        public void Derecha(){
            serpiente.setDireccion(Snake.derecha);
            Console.WriteLine("Derecha");
        }
        public void Izquierda()
        {
            serpiente.setDireccion(Snake.izquierda);
            Console.WriteLine("Izquierda");
        }
        public void Arriba()
        {
            serpiente.setDireccion(Snake.arriba);
            Console.WriteLine("Arriba");
        }
        public void Abajo()
        {
            serpiente.setDireccion(Snake.abajo);
            Console.WriteLine("Abajo");
        }
        public void Comer()
        {
            puntos += 1;
            serpiente.Crecer();
            txtPuntos.Text = puntos.ToString();
            switch (puntos)
            {
                case 10:
                    nivel = 1;
                    txtNivel.Text = nivel.ToString();
                    break;
                case 20:
                    nivel = 2;
                    velocidad = 600;
                    Console.WriteLine("nivel 2");
                    txtNivel.Text = nivel.ToString();
                    break;
                case 30:
                    nivel = 3;
                    velocidad = 200;
                    Console.WriteLine("nivel 3");
                    txtNivel.Text = nivel.ToString();
                    break;
                case 40:
                    ganador = true;
                    break;
            }
        }
    }
}
