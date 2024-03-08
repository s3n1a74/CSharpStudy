using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Найти наименьшее общее кратное четырех заданных натуральных чисел (определить метод для рассчета НОК двух натуральных чисел).
namespace Lab7.Models
{
    internal class NOKSearch
    {
        public static int NokSearch(int a, int b, int c, int d)
        {
            int _nok;
            for (int i = 1; ; i++)
            {
                var res = a * i;
                if (res % b == 0 && res % c == 0 && res % d == 0)
                {
                    _nok = a * i;
                    return _nok;
                }
            }
            return _nok;
        }
    }
}
