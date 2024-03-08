//Даны координаты вершин двух треугольников. Написать программу, проверяющую, лежит ли один треугольник внутри другого.
//(Определить функцию для проверки, находится ли точка внутри этого треугольника).
namespace Lab7
{
    internal class Triangles
    {
        public int _a1x, _a1y, _b1x, _b1y, _c1x, _c1y, _a2x, _a2y, _b2x, _b2y, _c2x, _c2y;
        double _ab, _bc, _ac, _s1;

        public Triangles(int a1x, int a1y, int b1x, int b1y, int c1x, int c1y)
        {
            _a1x = a1x;
            _a1y = a1y;
            _b1x = b1x;
            _b1y = b1y;
            _c1x = c1x;
            _c1y = c1y;
        }

        public bool SidesSearch()
        {
            //rectangle sides
            _ab = Math.Sqrt(Math.Pow((_b1x - _a1x), 2) + Math.Pow((_b1y - _a1y), 2));
            _bc = Math.Sqrt(Math.Pow((_c1x - _b1x), 2) + Math.Pow((_c1y - _b1y), 2));
            _ac = Math.Sqrt(Math.Pow((_c1x - _a1x), 2) + Math.Pow((_c1y - _a1y), 2));
            if( _ab + _bc > _ac && _ab + _ac > _bc && _bc + _ac > _ab)
            {
                return true;
            }
            return false;
        }

        public void Area()
        {
            if (SidesSearch())
            {
                //half perimeter
                double _p = (_ab + _bc + _ac) / 2;
                //Area first rectangle by Gerron's func
                _s1 = Math.Sqrt(_p * (_p - _ab) * (_p - _bc) * (_p - _ac));
            }
            else { Console.WriteLine("Точки не могут образовать треугольник"); }
        }

        public double BetwArea1(int ax, int ay)
        {
            //between first triangle 
            double firstSide = Math.Sqrt(Math.Pow((ax - _a1x), 2) + Math.Pow((ay - _a1y), 2));
            double secondSide = Math.Sqrt(Math.Pow((ax - _b1x), 2) + Math.Pow((ay - _b1y), 2));
            double thirdSide = _ab;
            double p = (firstSide + secondSide + thirdSide) / 2;
            double betwArea1 = Math.Sqrt(p*(p - firstSide)*(p - secondSide)*(p - thirdSide));
            return betwArea1;
        }

        public double BetwArea2(int ax, int ay)
        {
            //between second triangle
            double firstSide = Math.Sqrt(Math.Pow((ax - _c1x), 2) + Math.Pow((ay - _c1y), 2));
            double secondSide = Math.Sqrt(Math.Pow((ax - _b1x), 2) + Math.Pow((ay - _b1y), 2));
            double thirdSide = _bc;
            double p = (firstSide + secondSide + thirdSide) / 2;
            double betwArea2 = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            return betwArea2;
        }

        public double BetwArea3(int ax, int ay)
        {
            //between third triangle
            double firstSide = Math.Sqrt(Math.Pow((ax - _c1x), 2) + Math.Pow((ay - _c1y), 2));
            double secondSide = Math.Sqrt(Math.Pow((ax - _a1x), 2) + Math.Pow((ay - _a1y), 2));
            double thirdSide = _ac;
            double p = (firstSide + secondSide + thirdSide) / 2;
            double betwArea3 = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            return betwArea3;
        }
        public bool IsDotInTriangle(int ax, int ay)
        {
            Area();
            var q = BetwArea1(ax, ay);
            var w = BetwArea2(ax, ay);
            var e = BetwArea3(ax, ay);
            if(Math.Round(q+w+e) == Math.Round(_s1))
            {
                return true;
            }
            else return false;
        }

    }
}
