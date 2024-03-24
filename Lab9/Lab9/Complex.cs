//Описать класс комплексное число Complex. Комплексные числа задаются своим модулем r и аргументом (углом) v. Определить в нем:
//конструктор, принимающий модуль и арумент числа.
//копирующий конструктор.
//методы Abs,Arg позвращающие модуль и аргумент числа.
//методы Re,Im, возвращащие действительную и мнимую части числа.
//Операции умножения и деления чисел.
//Операцию возведения числа в целую степень
//метод для вывода комплексного числа в виде r[cos v + i sin v].

namespace Lab9
{
    internal class Complex
    {
        public double _a;
        public double _sinA;
        public double _cosA;
        public int R
        {
            get { return R; }
            set
            {
                if (R < 0)
                {
                    throw new ArgumentOutOfRangeException("invalid value");
                }
                else R = value;
            }
        }
        public double V { get; set; }

        public Complex(int r, double v)
        {
            R = r;
            V = v;
            _a = V * Math.PI / 180;
            _cosA = Math.Cos(_a);
            _sinA = Math.Sin(_a);
        }

        public Complex(Complex complex)
        {
            R = complex.R;
            V = complex.V;
        }

        public int Abs()
        {
            return R;
        }

        public double Arg()
        {
            return V;
        }

        public double Re()
        {
            return _cosA;
        }

        public double Im()
        {
            return _sinA;
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(a.R * b.R, Math.Acos(a._cosA * b._cosA));
        }

        public static Complex operator /(Complex a, Complex b)
        {
            return new Complex(a.R / b.R, Math.Acos(a._cosA / b._cosA));
        }

        public static Complex Pow(Complex a, int x)
        {
            a.R = (int)Math.Pow(a.R, x);
            a.V = Math.Sin(a.V * x);
            return new Complex(a.R,a.V);
        }

        public override string ToString()
        {
            return $"{R}[sin{V}+cos{V}]";
        }
    }
}
