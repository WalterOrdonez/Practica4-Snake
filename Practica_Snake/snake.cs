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
        
        public Snake()
        {
            Cabeza = new nodoSnake();
            Cabeza.setX(6);
            Cabeza.setY(5);
            direccion = 1;
            Crecer();
            Crecer();
            Ultimo = Cabeza.getSiguiente().getSiguiente();
        }
        public void setDireccion(int direccion)
        {
            this.direccion = direccion;
        }
        public void Crecer()
        {
            nodoSnake nuevo=new nodoSnake();
            int x = Cabeza.getX();
            int y = Cabeza.getY();
            nuevo.setX(x);
            nuevo.setY(y);

            //Mover Cabeza del Snake antes de agregar los nuevos nodos
            switch (direccion)
            {
                case derecha:
                    Cabeza.setX(Cabeza.getX() + 1);
                    if(Cabeza.getX()>11)
                    {
                        Cabeza.setX(0);
                    }
                    break;
                case izquierda:
                    Cabeza.setX(Cabeza.getX() - 1);
                    break;
                case arriba:
                    Cabeza.setY(Cabeza.getY() - 1);
                    break;
                case abajo:
                    Cabeza.setY(Cabeza.getY() + 1);
                    {
                        Cabeza.setY(0);
                    }
                    break;
            }
            //Agregar el nuevo nodo
            if(Cabeza.getSiguiente()!=null){
                Cabeza.getSiguiente().setAnterior(nuevo);
            }
            nuevo.setSiguiente(Cabeza.getSiguiente());
            nuevo.setAnterior(Cabeza);
            Cabeza.setSiguiente(nuevo);
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
                        Actual = Actual.getAnterior();
                    }
                    Cabeza.setY(Cabeza.getY() + 1);
                    if (Cabeza.getY() > 11)
                    {
                        Cabeza.setY(0);
                    }
                    break;
            }
            Console.WriteLine("X:"+Cabeza.getX().ToString() + " - Y:" + Cabeza.getY().ToString());
            Console.WriteLine("Xf:" +Ultimo.getX().ToString() + " - Yf:" + Ultimo.getY().ToString());
        }
    }
}
