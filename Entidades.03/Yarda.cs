namespace Entidades._03
{
    public class Yarda
    {
        private float Longitud;

        public Yarda(float longitud = 5)
        {
            Longitud = longitud;
        }

        public float GetLongitud()
        {
            return Longitud;
        }

        public static implicit operator Yarda(float y)
        {
            return new Yarda(y);
        }

        public static explicit operator Metro(Yarda y)
        {
            return new Metro(y.Longitud * 0.9144f);
        }

        public static bool operator ==(Yarda y1, Yarda y2)
        {
            return Math.Abs(y1.Longitud - y2.Longitud) < 0.0001f;
        }

        public static bool operator !=(Yarda y1, Yarda y2)
        {
            return !(y1 == y2);
        }

        public static Yarda operator +(Yarda y1, Yarda y2)
        {
            return new Yarda(y1.Longitud + y2.Longitud);
        }

        public override bool Equals(object? obj)
        {
            return obj is Yarda yarda &&
                   Longitud == yarda.Longitud;
        }

        public override int GetHashCode()
        {
            return Longitud.GetHashCode();
        }

    }
}
