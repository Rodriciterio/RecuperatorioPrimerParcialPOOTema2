using Entidades;
using System.Text;

namespace Datos._04
{
    public class RepositorioNumeros
    {
        private int Cantidad;
        private NumeroDivCincoSiete[] numerosdivisibles;

        public int GetCantidad()
        {
            return Cantidad;
        }

        public RepositorioNumeros(int cantidad)
        {
            Cantidad = cantidad;
            numerosdivisibles = new NumeroDivCincoSiete[cantidad];
        }

        public RepositorioNumeros()
        {
            Cantidad = 5;
            numerosdivisibles = new NumeroDivCincoSiete[Cantidad];
        }

        public bool Validar(int valor)
        {
            return valor % 5 == 0 || valor % 7 == 0;
        }

        private bool EstaCompleto()
        {
            return numerosdivisibles.All(numero => numero != null);
        }

        private bool EstaVacio()
        {
            return numerosdivisibles.All(numero => numero == null);
        }

        private bool ExisteNumero(NumeroDivCincoSiete numero)
        {
            return numerosdivisibles.Contains(numero);
        }

        public (bool, string) AgregarNumeroDivisible(int numero)
        {
            var numeroDivisible = new NumeroDivCincoSiete(numero);

            if (!numeroDivisible.Validar(numero))
            {
                return (false, "El número no es divisible por 5 o 7.");
            }

            if (ExisteNumero(numeroDivisible))
            {
                return (false, "El número ya existe en el repositorio.");
            }

            if (EstaCompleto())
            {
                return (false, "El repositorio está completo y no se pueden agregar más números.");
            }

            for (int i = 0; i < numerosdivisibles.Length; i++)
            {
                if (numerosdivisibles[i] == null)
                {
                    numerosdivisibles[i] = numeroDivisible;
                    return (true, "Número divisible agregado exitosamente.");
                }
            }

            return (false, "No se pudo agregar el número divisible.");
        }

        public (bool, string) QuitarNumeroDivisible(int numero)
        {
            var numerodivisible = new NumeroDivCincoSiete(numero);
            int index = Array.FindIndex(numerosdivisibles, n => n != null && n.Equals(numerodivisible));
            if (index >= 0)
            {
                numerosdivisibles[index] = null;
                return (true, "Número Divisible eliminado exitosamente.");
            }

            return (false, "El número Divisible no se encontró en el repositorio.");
        }

        public NumeroDivCincoSiete ObtenerNumero(int indice)
        {
            if (indice < 0 || indice >= numerosdivisibles.Length)
            {
                throw new IndexOutOfRangeException("El índice está fuera del rango del array.");
            }
            return numerosdivisibles[indice];
        }

        public string MostrarContenido()
        {
            if (EstaVacio())
            {
                return "No hay elementos almacenados todavía.";
            }

            StringBuilder contenido = new StringBuilder();
            for (int i = 0; i < numerosdivisibles.Length; i++)
            {
                if (numerosdivisibles[i] == null)
                {
                    contenido.Append("Elemento Nulo");
                }
                else
                {
                    contenido.Append(numerosdivisibles[i].ToString());
                }

                if (i < numerosdivisibles.Length - 1)
                {
                    contenido.Append(", ");
                }
            }

            return contenido.ToString();
        }

        public (bool, int) BuscarNumero(int numero)
        {
            var numeroDivisible = new NumeroDivCincoSiete(numero);
            int index = Array.IndexOf(numerosdivisibles, numeroDivisible);
            return (index >= 0, index);
        }

        public static implicit operator int(RepositorioNumeros repo)
        {
            return repo.numerosdivisibles
                .Where(n => n != null)
                .Sum(n => n.Valor);
        }
    }
}
