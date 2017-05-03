# Practica4-Snake
Practica 4 - Snake - Orga. Juego de snake por conexión serial a arreglo de leds

**Clase PortInterport**
* Se encarga de enviar datos al puerto paralelo.
* `int address` Dirección de pines a enviar el dato. A los pines de datos es 888.
* `int value` Dato en decimal a enviar, para una salida en binario.

```cs
class PortAccess
    {
        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        public static extern void Output(int address, int value);
    }
```
