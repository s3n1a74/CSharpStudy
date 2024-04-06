//Описать структуру Triangle с полями a,b,c - длины 3-х сторон. Определить метод, определяющий тип треугольника по сторонам
//(равносторонний, равнобедренный, разносторонний). Для N заданных треугольников определить k1 - количество разносторонних 
// треугольников, k2 - количество равнобедренных треугольников и k3 - количество равносторонних треугольников.
namespace Lab12
{
    internal struct Triangle
    {
        // Можно решить по-другому. В конструкторе для type ставишь дефолтным значением TriangleType = None (не триугольник)
        // потом проверяешь, если триугольник существует, то выполняешь gettype, иначе нет. Это всё можно вызвать в конструкторе
        
        private readonly int _a;
        private readonly int _b;
        private readonly int _c;
        public TriangleType type;

        public Triangle(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                _a = a;
                _b = b;
                _c = c;
                type = GetTypeT();
            }
            else
            {
                Console.WriteLine("Одна из сторон отрицательна или равна нулю. Треугольник не может быть создан.");
                _a = _b = _c = 0;
                type = TriangleType.NoTriangle;
            }
        }

        public bool IsPositive()
        {
            if (_a >0 && _b > 0 && _c > 0) return true;
            else return false;
        }

        public TriangleType GetTypeT()
        {
            if (IsPositive())
            {
                if (_a == _b && _a != _c || _a != _c && _b == _c || _a == _c && _b != _c)
                {
                    type = TriangleType.Isosceles;
                }
                else if (_a == _b && _b == _c)
                {
                    type = TriangleType.Scalene;
                }
                else return TriangleType.Equilateral;
            }
            else
            {
                return TriangleType.NoTriangle;
            }
            return type;
        }
    }
}
