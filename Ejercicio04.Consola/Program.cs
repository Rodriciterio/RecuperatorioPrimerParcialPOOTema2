using Datos._04;
using MiDll;

namespace Ejercicio04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioNumeros repositorio = new RepositorioNumeros();

            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Agregar número");
                Console.WriteLine("2. Eliminar número");
                Console.WriteLine("3. Mostrar contenido");
                Console.WriteLine("4. Buscar número");
                Console.WriteLine("5. Sumar números");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        var numeroAgregar = ConsoleExtensions.ReadInt("Ingrese el número a agregar: ");
                        var resultadoAgregar = repositorio.AgregarNumeroDivisible(numeroAgregar);
                        Console.WriteLine(resultadoAgregar.Item2);
                        break;

                    case "2":
                        Console.WriteLine(repositorio.MostrarContenido());
                        var valorQuitar = ConsoleExtensions.ReadInt("Ingrese el número a quitar: ");
                        var resultadoQuitar = repositorio.QuitarNumeroDivisible(valorQuitar);
                        Console.WriteLine(resultadoQuitar.Item2);
                        break;

                    case "3":
                        Console.WriteLine("Contenido del repositorio:");
                        Console.WriteLine(repositorio.MostrarContenido());
                        break;

                    case "4":
                        var numeroBuscar = ConsoleExtensions.ReadInt("Ingrese el numero a buscar: ");
                            var resultadoBusqueda = repositorio.BuscarNumero(numeroBuscar);
                            if (resultadoBusqueda.Item1)
                            {
                                Console.WriteLine($"El número {numeroBuscar} se encuentra en la posición {resultadoBusqueda.Item2}.");
                            }
                            else
                            {
                                Console.WriteLine($"El número {numeroBuscar} no se encuentra en el repositorio.");
                            }
                        break;

                    case "5":
                        int suma = repositorio;
                        Console.WriteLine($"La suma de los números en el repositorio es: {suma}");
                        break;

                    case "6":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
