using System.Runtime.InteropServices;

namespace Boton
{
    class PortAccess
    {
        [DllImport("inpout32.dll", EntryPoint = "Out32")]
        public static extern void Output(int address, int value);

    }
}
