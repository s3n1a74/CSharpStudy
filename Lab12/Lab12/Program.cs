using Lab12;
using static Lab12.TriangleType;
class Program
{
    static void Main(string[] args)
    {
        //first task
        Point point = new Point(2, 6);
        Point point1 = new Point(2, -6);
        Point point2 = new Point(0, 0);
        Point point3 = new Point(0, 8);
        Point[] points = { point, point1, point2, point3 };
        foreach (var po in points)
        {
            var a = po.GetPosition();
            Console.WriteLine(a);
        }
        Console.WriteLine();
        Console.WriteLine();

        //second task
        int k1 = 0;
        int k2 = 0;
        int k3 = 0;
        Triangle triangle = new Triangle(3, 4, 3);
        Triangle triangle1 = new Triangle(3, 4, -4);
        Triangle triangle2 = new Triangle(4, 4, 4);
        Triangle triangle3 = new Triangle(4, 5, 7);
        Triangle triangle4 = new Triangle(7, 8, 8);
        Triangle triangle5 = new Triangle(9, 9, 9);
        Triangle[] triangles = { triangle, triangle1, triangle2, triangle3, triangle4, triangle5 };
        foreach (var tri in triangles)
        {
            tri.GetTypeT();
            if (tri.type is TriangleType.Isosceles) k1++;
            else if (tri.type is TriangleType.Scalene) k2++;
            else if (tri.type is TriangleType.Equilateral) k3++;
        }
        Console.WriteLine($"В массиве {k1} равнобедренных треугольников");
        Console.WriteLine($"В массиве {k2} равносторонних треугольников");
        Console.WriteLine($"В массиве {k3} разносторонних треугольников");
    }
}
