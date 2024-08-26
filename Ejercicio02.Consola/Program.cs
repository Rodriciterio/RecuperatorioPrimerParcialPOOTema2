using Ejercicio02.Entidades;
using MiDll;

namespace Ejercicio02.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var isbn = ConsoleExtensions.ReadString("Ingrese un ISBN para validar: ");

            if (ValidadorISBN.Validar(isbn))
            {
                Console.WriteLine("El ISBN es válido.");
            }
            else
            {
                Console.WriteLine("El ISBN no es válido.");
            }
        }
    }
}
