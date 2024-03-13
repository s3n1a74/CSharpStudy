namespace ConsoleApp1
{
    internal static class IntermediateTriangle
    {
        public static bool IsPointInTriangle(Triangle triangle1, Point point)
        {
            Triangle first = new Triangle(triangle1.points[0], triangle1.points[1], point);
            Triangle second = new Triangle(triangle1.points[1], triangle1.points[2], point);
            Triangle third = new Triangle(triangle1.points[2], triangle1.points[0], point);
            if (Math.Abs(first._area + second._area + third._area) == triangle1._area)
            {
                return true;
            }
            return false;
        }
        public static bool IsTriangleInTriangle(Triangle first, Triangle second)
        {
            if (IsPointInTriangle(first, second.points[0]) && IsPointInTriangle(first, second.points[1]) && IsPointInTriangle(first, second.points[2]))
            {
                return true;
            }
            return false;
        }
    }
}
