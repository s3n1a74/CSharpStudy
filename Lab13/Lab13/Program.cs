using Lab13;
using Lab8.Models;

class Program
{
    static void Main(string[] args)
    {
        //first task
        ArrayN arrayN = new ArrayN();
        var s = arrayN.SumNumbers();
        Console.WriteLine(s);
        Console.WriteLine();
        Console.WriteLine();

        //second task
        TimeUpdate timeUpdate = new TimeUpdate(2, 54, 37);
        var a = timeUpdate.AllTimeInSeconds();
        Console.WriteLine(a);
        Console.WriteLine();
        Console.WriteLine();

        //third task
        ArrayN1 arrayN1 = new ArrayN1();
        var d = arrayN1.PowNumbers();
        Console.WriteLine(d);
    }
}