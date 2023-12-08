namespace ComplexNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);
            Console.WriteLine("z1 = {0}", z1);
        }
    }
    /// <summary>
    /// Complex number: x + iy
    /// </summary>
    class Complex
    {
        public float x { get; set; }
        public float y { get; set; }

        public Complex(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public static Complex operator *(Complex x, Complex y)
        {
            float a = x.x;
            float b = x.y;
            float c = y.x;
            float d = y.y;
            return new Complex(a * c - b * d, b * c + a * d);
        }
        public static Complex operator -(Complex x, int y)
        {
            float m = x.x;
            float n = x.y;
            return new Complex(m - y, n);
        }
        public static Complex operator *(int a, Complex C)
        {
            return new Complex(a * C.x, a * C.y);
        }
        //division c1/c2
        public static Complex operator /(Complex C1, Complex C2)
        {
            float a = C1.x;
            float b = C1.y;
            float c = C2.x;
            float d = C2.y;
            return new Complex((a * c + b * d) / (c * c + d * d), (b * c - a * d) / (c * c + d * d));
        }
        public static Complex operator -(Complex C1, Complex C2)
        {
            float a = C1.x;
            float b = C1.y;
            float c = C2.x;
            float d = C2.y;
            return new Complex(a - c, b - d);
        }
        public override string ToString()
        {
            return $"{x} + {y}i";
        }
    }
}