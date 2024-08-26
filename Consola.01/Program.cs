using Entidades._01;
using MiDll;

namespace Consola._01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radio = ConsoleExtensions.ReadInt("Ingrese el radio del cilindro: ");
            int altura = ConsoleExtensions.ReadInt("Ingrese la altura del cilindro: ");
            Cilindro c = new Cilindro(radio, altura);

            Console.WriteLine(c.GetDatos());
        }
    }
}
