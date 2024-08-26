namespace Entidades
{
    public class NumeroDivCincoSiete
    {
        public int valor;


        public int Valor
        {
            get { return valor; }
            set
            {
                if (Validar(value))
                {
                    valor = value;
                }
                else
                {
                    throw new ArgumentException("El valor debe ser divisible por 5 o 7.");
                }
            }
        }

        public NumeroDivCincoSiete(int valor)
        {
            Valor = valor;
        }

        public bool Validar(int valor)
        {
            return valor % 5 == 0 || valor % 7 == 0;
        }

        public override string ToString()
        {
            return $"Valor: {Valor}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is NumeroDivCincoSiete))
            {
                return false;
            }
            return this.Valor == ((NumeroDivCincoSiete)obj).Valor;
        }

        public override int GetHashCode()
        {
            return Valor.GetHashCode();
        }

        public static bool operator ==(NumeroDivCincoSiete a, NumeroDivCincoSiete b)
        {
            if (ReferenceEquals(a, b))
            {
                return true;
            }
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            {
                return false;
            }
            return a.Valor == b.Valor;
        }

        public static bool operator !=(NumeroDivCincoSiete a, NumeroDivCincoSiete b)
        {
            return !(a == b);
        }
    }
}
