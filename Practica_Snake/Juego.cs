using System;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;


namespace Practica_Snake
{
    class Juego
    {
        string tiempo_pausa;
        int puntos;
        double tiempo;
        int nivel;
        int velocidad;
        Usuario usuario;
        System.Windows.Forms.Timer timer;
        ThreadStart delegadoDatosPuerto;
        Thread hiloDatosPuerto;
        bool ganador;
        bool play;
        Snake serpiente;
        TextBox txtPuntos;
        TextBox txtNivel;
        TextBox txtTiempo;
        Panel panel;
        Button btn_salir;
        Tablero.Tablero tablero;

        public Juego(double tiempo, System.Windows.Forms.Timer timer, Usuario usuario, TextBox txtPuntos, TextBox txtNivel, TextBox txtTiempo, Panel panel,Button btn_salir)
        {
            this.velocidad = 1000;
            this.tiempo = 0;
            this.puntos = 0;
            this.nivel = 1;
            this.usuario = usuario;
            this.timer=timer;
            this.txtNivel = txtNivel;
            this.txtPuntos = txtPuntos;
            this.txtTiempo = txtTiempo;
            this.panel = panel;
            this.btn_salir = btn_salir;
            ganador = false;
            txtNivel.Text = "1";
            serpiente = new Snake();
            tablero = new Tablero.Tablero();
            play = false;
        }
        public void parar()
        {
            hiloDatosPuerto.Abort();
            timer.Stop();
            play = false;
            usuario.setNivel(this.nivel);
            double tiempo_d = Convert.ToDouble(txtTiempo.Text);
            int tiempo_int = Convert.ToInt32(tiempo_d);
            usuario.setTiempo(tiempo_int);
            usuario.setPuntos(puntos);
            if (txtNivel.InvokeRequired || txtPuntos.InvokeRequired||btn_salir.InvokeRequired)
            {
                //si es así entonces volvemos a llamar a CambiarProgreso pero esta vez a través del delegado 
                //instanciamos el delegado indicandole el método que va a ejecutar 
                mostrarDatosDelegado delegado = new mostrarDatosDelegado(mostrarDatosForm);
                habilitarBotonDelegado delegadoBoton = new habilitarBotonDelegado(habilitarBoton);
                //ya que el delegado invocará a CambiarProgreso debemos indicarle los parámetros 
                //invocamos el método a través del mismo contexto del formulario (this) y enviamos los parámetros 
                txtNivel.Invoke(delegado);
                btn_salir.Invoke(delegadoBoton);
            }
            else
            {
                mostrarDatosForm();
                habilitarBoton();
            }
        }
        delegate void habilitarBotonDelegado();
        public void habilitarBoton()
        {
            btn_salir.Enabled = true;
        }
        delegate void mostrarDatosDelegado();
        public void mostrarDatosForm()
        {
            txtPuntos.Text = puntos.ToString();
            txtNivel.Text = nivel.ToString();
        }
        public void iniciar()
        {
            tiempo_pausa = Interaction.InputBox("Tiempo", "Tiempo pantalla", "0");
            play=true;
            tablero.setComida(0, 0);
            //Creamos el delegado con el nombre del metodo a ejecutar
            delegadoDatosPuerto = new ThreadStart(enviarDatosPuerto);
            hiloDatosPuerto = new Thread(delegadoDatosPuerto);
            hiloDatosPuerto.Start();
            //for (int i = 0; i < 20000;i++ )
            //{
            //    enviarDatosPuerto();
            //}
            
            while (play && !ganador)
            {
                int x = serpiente._cabeza.getX();
                int y = serpiente._cabeza.getY();
                int[,] tab = tablero.getTablero();
                switch (tab[x, y])
                {
                    case 1:
                        play = false;
                        break;
                    case 2:
                        Comer();
                        tablero.setComida(x, y);
                        break;
                }
                actualizarDatos();
                serpiente.Avanzar();
                Thread.Sleep(velocidad);
            }
            parar();
        }
        public void actualizarDatos()
        {
            tablero.setSnake(this.serpiente);

            //tablero.enviarDatosConsola();
            tablero.limpiar(panel);
            tablero.pintar(panel);
            Console.WriteLine();
        }
        public void enviarDatosPuerto()
        {
            int tiempoSleep;
            try
            {
                tiempoSleep=Convert.ToInt32(tiempo_pausa);
            }catch(Exception e)
            {
                tiempoSleep = 0;
            }
            while(play && !ganador)
            {
                tablero.enviarDatos(tiempoSleep);
            }
        }
        public bool getGanador()
        {
            return this.ganador;
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
            if (txtNivel.InvokeRequired || txtPuntos.InvokeRequired)
            {
                //si es así entonces volvemos a llamar a CambiarProgreso pero esta vez a través del delegado 
                //instanciamos el delegado indicandole el método que va a ejecutar 
                mostrarDatosDelegado delegado = new mostrarDatosDelegado(mostrarDatosForm);
                //ya que el delegado invocará a CambiarProgreso debemos indicarle los parámetros 
                //invocamos el método a través del mismo contexto del formulario (this) y enviamos los parámetros 
                txtPuntos.Invoke(delegado);
            }
            else
            {
                mostrarDatosForm();
            }
            switch (puntos)
            {
                case 10:
                    nivel = 2;
                    tablero.setNivel(nivel);
                    serpiente.setSerpienteNivel(nivel);
                    velocidad = 600;
                    txtNivel.Text = nivel.ToString();
                    break;
                case 20:
                    nivel = 3;
                    tablero.setNivel(nivel);
                    serpiente.setSerpienteNivel(nivel);
                    velocidad = 200;
                    Console.WriteLine("nivel 2");
                    txtNivel.Text = nivel.ToString();
                    break;
                case 30:
                    ganador = true;
                    break;
            }
        }
    }
}
