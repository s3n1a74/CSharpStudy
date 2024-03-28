namespace Lab11.Polynormal
{
    internal class Quadratic : IPolynomial
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Quadratic(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool IsAbove(Point point)
        {
            if (A * Math.Pow(point.X, 2) + B * point.X + C > point.Y)
            {
                return true;
            }
            else return false;
        }

        public bool IsBelow(Point point)
        {
            if (A * Math.Pow(point.X, 2) + B * point.X + C < point.Y)
            {
                return true;
            }
            else return false;
        }
    }
}
