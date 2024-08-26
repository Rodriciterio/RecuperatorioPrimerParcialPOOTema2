using System.Text;

namespace Entidades._01
{
    public class Cilindro
    {
        public int Radio { get; }
        private double Altura;

        public Cilindro(int radio, double altura)
        {
            if (radio <= 0 || altura <= 0)
            {
                throw new ArgumentException("Datos no validos");
            }
            else
            {
                Radio = radio;
                Altura = altura;
            }
        }

        public bool ValidarRadio()
        {
            return Radio > 0;
        }

        public bool ValidarAltura()
        {
            return Altura > 0;
        }

        public double GetArea()
        {
            double areaLateral = 2 * Math.PI * Radio * Altura;
            double areaBases = 2 * Math.PI * Math.Pow(Radio, 2);
            return Math.Truncate(areaLateral + areaBases);
            //Uso truncate para que se asemeje más al caso del proyecto
        }

        public double GetVolumen()
        {
            return Math.Truncate(Math.PI * Math.Pow(Radio, 2) * Altura);
        }

        public string GetDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Altura: {Altura}");
            sb.AppendLine($"Radio: {Radio}");
            sb.AppendLine($"Area: {GetArea()}");
            sb.AppendLine($"Volumen: {GetVolumen()}");

            return sb.ToString();
        }

        public double GetAltura()
        {
            return Altura;
        }

        public int GetRadio()
        {
            return Radio;
        }
    }
}
