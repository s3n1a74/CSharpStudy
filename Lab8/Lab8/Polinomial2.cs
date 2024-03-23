//описать класс Polinomial2 квадратных многочленов вида ax^2+bx+c. Определить в нем:
//-конструктор, принимающий коэффициенты многочлена.
//-копирующий конструктор.
//-метод Value, позвращающий значение многочлена в данной точке.
//-операции сложения и и вычитания.
//-операции умножения и деления на действительное число.
//-определение целочисленного остатка от деления одного многочлена на другой.
//-переопределенный унаследованный метод ToString.
namespace Lab8
{
    internal class Polinomial2
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Polinomial2(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public Polinomial2(Polinomial2 polinomial2)
        {
            A = polinomial2.A;
            B = polinomial2.B;
            C = polinomial2.C;
        }

        public double Value(double x)
        {
            return A * Math.Pow(x, 2) + B * x + C;
        }

        public static Polinomial2 operator +(Polinomial2 p, Polinomial2 q)
        {
            return new Polinomial2 ( p.A + q.A, p.B + q.B, p.C + q.C );
        }

        public static Polinomial2 operator -(Polinomial2 q, Polinomial2 p)
        {
            return new Polinomial2 (p.A - q.A, p.B - q.B, p.C - q.C);
        }

        public static Polinomial2 operator *(Polinomial2 q, double x)
        {
            return new Polinomial2 (q.A * x, q.B * x, q.C * x);
        }

        public static Polinomial2 operator /(Polinomial2 q, double x)
        {
            return new Polinomial2 (Math.Round((q.A / x), 3),  Math.Round((q.B / x), 3),  Math.Round((q.C / x), 3) );
        }

        public static Polinomial2 operator %(Polinomial2 p, Polinomial2 q)
        {
            return new Polinomial2 (p.A % q.A, p.B % q.B, p.C % q.C);
        }

        public override string ToString()
        {
            return $"{A}*x^2 + {B}*x + {C}";
        }
    }
}
