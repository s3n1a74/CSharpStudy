namespace Lab11.Polynormal
{
    internal class Linear : IPolynomial
    {
        public double A { get; set; }
        public double C { get; set; }

        public Linear(double a, double c)
        {
            A = a; C = c;
        }

        public bool IsAbove(Point point)
        {
            if (point.X * A + C > point.Y)
            {
                return true;
            }
            else return false;
        }

        public bool IsBelow(Point point)
        {

            if (point.X * A + C < point.Y)
            {
                return true;
            }
            else return false;
        }
    }
}
