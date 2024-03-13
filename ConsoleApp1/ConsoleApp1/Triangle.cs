using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangle
    {
        public Point[] points {  get; set; }
        public double _ab, _bc, _ac, _halfPerimeter, _area;
        bool _isTrue;
        public Triangle(Point point1, Point point2, Point point3)
        {
            points = new [] { point1, point2, point3 };
        }

        public double SideSearch(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow((point2.X - point1.X), 2) + Math.Pow((point2.Y - point1.Y), 2));
        }

        public void SidesSearch()
        {
            _ab = SideSearch(points[0], points[1]);
            _bc = SideSearch(points[1], points[2]);
            _ac = SideSearch(points[2], points[0]);
        }

        public bool IsTrue()
        {
            if (_ac + _ab > _bc &&  _bc + _ac > _ab && _ab + _bc > _ac)
            {
                _isTrue = true;
            }
            return _isTrue;
        }
        public void HalfPerimeter()
        {
            _halfPerimeter = (_ab + _bc + _ac) / 2;
        }

        public double Area()
        {
            if (IsTrue())
            {
                _area = Math.Sqrt(_halfPerimeter * (_halfPerimeter - _ab) * (_halfPerimeter - _bc) * (_halfPerimeter - _ac));
            }
            else { Console.WriteLine("Triangle is error"); }
            return _area;
        }

        
    }
}
