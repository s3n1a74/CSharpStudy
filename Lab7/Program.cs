using Lab7;
using Lab7.Models;

class Progrsm
{
    static void Main(string[] args)
    {
        //first task
        MaxValue max = new MaxValue();
        int maxValue = max.F(4, 53, 1);
        Console.WriteLine(maxValue);
        Console.WriteLine();
        Console.WriteLine();

        //second task
        var d = FSum.FSumm(4);
        Console.WriteLine(d);
        Console.WriteLine();
        Console.WriteLine();

        //third task
        var nok = NOKSearch.NokSearch(1, 2, 3, 4);
        Console.WriteLine(nok);
        Console.WriteLine();
        Console.WriteLine();

        //fourth task
        Arrays.GetArr();
        Console.WriteLine();
        Console.WriteLine();

        //fiveth task
        YesPow yesPow = new YesPow();
        var a = yesPow.RecAnswer(256);
        Console.WriteLine(a);
        var q = yesPow.NotRecAnswer(255);
        Console.WriteLine(q);
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine();
        Triangles triangles = new Triangles(2,3,6,7,7,1);
        var z =triangles.IsDotInTriangle(4,3);
        var x = triangles.IsDotInTriangle(5,5);
        var c =triangles.IsDotInTriangle(5,3);
        if(z && x && c)
        {
            Console.WriteLine("Треугольник вписан");
        }
        else
        {
            Console.WriteLine("error");
        }

    }
}