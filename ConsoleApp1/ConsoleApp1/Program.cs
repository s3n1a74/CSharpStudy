using ConsoleApp1;

Triangle first = new Triangle(new Point(0, 0), new Point(5, 0), new Point(0, 6));
Triangle second = new Triangle(new Point(2, 2), new Point(4, 1), new Point(2, 3));

Console.WriteLine(first._halfPerimeter);
Console.WriteLine(first._area);

Console.WriteLine();

Console.WriteLine(second._halfPerimeter);
Console.WriteLine(second._area);

Console.WriteLine();

Console.WriteLine(IntermediateTriangle.IsTriangleInTriangle(first,second));