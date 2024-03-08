using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Определить метод int f(int a, int b, int c), который возвращает наибольшее из значений a,b,c.
namespace Lab7.Models
{
    internal class MaxValue
    {
        int _max;

        public int F(int a, int b, int c)
        {
            if (a > b & a > c)
            {
                _max = a;
            }
            else if (b > a & b > c)
            {
                _max = b;
            }
            else if (c > a & c > b)
            {
                _max = c;
            }
            return _max;
        }
    }
}
