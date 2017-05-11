using System;


namespace Practica_Snake
{
    class Snake
    {
        public const int derecha = 1;
        public const int arriba = 2;
        public const int izquierda = 3;
        public const int abajo = 4;

        int direccion;
        
        nodoSnake Cabeza;
        nodoSnake Ultimo;

        public nodoSnake _cabeza
        {
            get { return Cabeza; }
            set { Cabeza = value; }
        }

        public nodoSnake _ultimo
        {
            get { return Ultimo; }
            set { Ultimo = value; }
        }
        public int getDireccion()
        {
            return this.direccion;
        }
        public Snake()
        {
            Cabeza = new nodoSnake();
            Cabeza.setX(2);
            Cabeza.setY(1);
            Ultimo = Cabeza;
            direccion = 1;
            Crecer();
            Crecer();
        }
        public void setDireccion(int direccion)
        {
            this.direccion = direccion;
        }
        public void Crecer()
        {
            nodoSnake nuevo=new nodoSnake();
            int x = Ultimo.getX();
            int y = Ultimo.getY();
            nuevo.setX(x);
            nuevo.setY(y);

            //Agregar el nuevo nodo
            Ultimo.setSiguiente(nuevo);
            nuevo.setAnterior(Ultimo);
            Ultimo = nuevo;
        }
        public void Avanzar()
        {
            
            nodoSnake Actual = Ultimo;

            switch (direccion)
            {
                case derecha:
                    //Mover cada nodo de la serpiente a la derecha
                    while (Actual != Cabeza)
                    {
                        Actual.setX(Actual.getAnterior().getX());
                        Actual.setY(Actual.getAnterior().getY());
                        Actual = Actual.getAnterior();
                    }
                    Cabeza.setX(Cabeza.getX() + 1);
                    if (Cabeza.getX() > 11)
                    {
                        Cabeza.setX(0);
                    }
                    break;
                case izquierda:
                    //Mover cada nodo de la serpiente a la izquierda
                    while (Actual != Cabeza)
                    {
                        Actual.setX(Actual.getAnterior().getX());
                        Actual.setY(Actual.getAnterior().getY());
                        Actual = Actual.getAnterior();
                    }
                    Cabeza.setX(Cabeza.getX() - 1);
                    if (Cabeza.getX() < 0)
                    {
                        Cabeza.setX(11);
                    }
                    break;
                case arriba:
                    //Mover cada nodo de la serpiente hacia arriba
                    while (Actual != Cabeza)
                    {
                        Actual.setY(Actual.getAnterior().getY());
                        Actual.setX(Actual.getAnterior().getX());
                        Actual = Actual.getAnterior();
                    }
                    Cabeza.setY(Cabeza.getY() - 1);
                    if (Cabeza.getY() < 0)
                    {
                        Cabeza.setY(11);
                    }
                    break;
                case abajo:
                    //Mover cada nodo de la serpiente hacia abajo
                    while (Actual != Cabeza)
                    {
                        Actual.setY(Actual.getAnterior().getY());
                        Actual.setX(Actual.getAnterior().getX());
                        Actual = Actual.getAnterior();
                    }
                    Cabeza.setY(Cabeza.getY() + 1);
                    if (Cabeza.getY() > 11)
                    {
                        Cabeza.setY(0);
                    }
                    break;
            }
            //Console.WriteLine("X:"+Cabeza.getX().ToString() + " - Y:" + Cabeza.getY().ToString());
            //Console.WriteLine("Xf:" +Ultimo.getX().ToString() + " - Yf:" + Ultimo.getY().ToString());
        }
        public void setSerpienteNivel(int nivel)
        {
            nodoSnake Actual = Ultimo;
            switch (nivel){
                case 2:
                    while (Actual != Cabeza)
                    {
                        Actual.setY(5);
                        Actual.setX(0);
                        Actual = Actual.getAnterior();
                    }
                    Cabeza.setX(0);
                    Cabeza.setY(5);
                    direccion = Snake.derecha;
                break;
                case 3:
                    while (Actual != Cabeza)
                    {
                        Actual.setY(0);
                        Actual.setX(5);
                        Actual = Actual.getAnterior();
                    }
                    Cabeza.setX(5);
                    Cabeza.setY(0);
                    direccion = Snake.abajo;
                break;
            }
        }
    }
}
