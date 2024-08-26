namespace Entidades._03
{
    public class Metro
    {
        private float Longitud;

        public Metro(float longitud = 5)
        {
            Longitud = longitud;
        }

        public float GetLongitud()
        {
            return Longitud;
        }

        public static implicit operator Metro(float m)
        {
            return new Metro(m);
        }

        public static explicit operator Yarda(Metro m)
        {
            return new Yarda(m.Longitud * 1.09361f);
        }

        public static bool operator ==(Metro m1, Metro m2)
        {
            return Math.Abs(m1.Longitud - m2.Longitud) < 0.0001f;
        }

        public static bool operator !=(Metro m1, Metro m2)
        {
            return !(m1 == m2);
        }

        public static Metro operator +(Metro m1, Metro m2)
        {
            return new Metro(m1.Longitud + m2.Longitud);
        }

        public override bool Equals(object? obj)
        {
            return obj is Metro metro &&
                   Longitud == metro.Longitud;
        }

        public override int GetHashCode()
        {
            return Longitud.GetHashCode();
        }

    }
}
