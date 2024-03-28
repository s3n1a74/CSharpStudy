using Lab11;
using Lab11.Polynormal;
using Lab11.Solid;

class Program
{
    static void Main(string[] args)
    {
        //the 10 variant\ first task
        Point point = new Point(2, 2);
        Linear linear = new Linear(3, 5);
        Quadratic quadratic = new Quadratic(3, 4, 5);
        var a = IsBetween(quadratic, linear, point);
        Console.WriteLine(a);
        Console.WriteLine();
        Console.WriteLine();

        //the 1 variant\ first task
        Cube cube1 = new Cube(5);
        Cube cube2 = new Cube(4);
        Cilinder cilinder1 = new Cilinder(5, 6);
        Cilinder cilinder2 = new Cilinder(4, 6);
        ISolid[] solids = new ISolid[4] { cube1, cube2, cilinder1, cilinder2 };
        foreach (ISolid solid in solids)
        {
            Console.WriteLine(solid.Display());
        }
        Console.WriteLine();
        Console.WriteLine();

        //the 1 variant\ second task
        Time time = new Time(15, 15);
        Time time2 = new Time(14, 15);
        Time time1 = new Time(15, 16);
        var e = time<time1;
        Console.WriteLine(e);
        var d = time.GetHashCode();
        var r = time2 > time;
        Console.WriteLine(d);
        Console.WriteLine(r);
        Console.WriteLine();
        Console.WriteLine();

        //the 6 variant\second task
        Rate rate = new Rate(20,10,10);
        Rate rate1 = new Rate(30,10,10);
        var t = rate<rate1;
        Console.WriteLine(t);
    }

    public static bool IsBetween(IPolynomial polynomial1, IPolynomial polynomial2, Point point)
    {
        if(polynomial1.IsAbove(point) && polynomial2.IsBelow(point))
        {
            return true;
        }
        else return false;
    }
}