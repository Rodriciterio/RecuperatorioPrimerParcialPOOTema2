using Entidades._03;

namespace Consola._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metro metro1 = new Metro(10);
            Yarda yarda1 = new Yarda(50);

            Metro metro2 = 75f;
            Yarda yarda2 = 35f;

            Metro metroConvertido = (Metro)yarda1;
            Yarda yardaConvertida = (Yarda)metro1;

            Metro metroResultado = metro1 + metroConvertido;
            Yarda yardaResultado = yarda1 + yardaConvertida;

            bool sonIgualesMetros = metro1 == metroConvertido;
            bool sonIgualesYardas = yarda1 == yardaConvertida;

            Console.WriteLine($"Metro 1: {metro1.GetLongitud()} M");
            Console.WriteLine($"Yarda 1: {yarda1.GetLongitud()} Y");
            Console.WriteLine($"Metros convertidos: {metroConvertido.GetLongitud()} M");
            Console.WriteLine($"Yardas convertidas: {yardaConvertida.GetLongitud()} Y");
            Console.WriteLine($"Metros resultado: {metroResultado.GetLongitud()} M");
            Console.WriteLine($"Yardas resultado: {yardaResultado.GetLongitud()} Y");
            Console.WriteLine($"Son iguales metros: {sonIgualesMetros}");
            Console.WriteLine($"Son iguales yardas: {sonIgualesYardas}");

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
