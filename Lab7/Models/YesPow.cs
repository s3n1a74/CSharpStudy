using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Дано натуральное число n. Выведите слово Yes, если число n является точной степенью двойки, или слово Nо,
//в противном случае. Функцией возведения в степень пользоваться нельзя. Рекурсивный и не рекурсивный метод.
namespace Lab7.Models
{
    internal class YesPow
    {
        public string RecAnswer(int n)
        {
            if (n % 2 == 1 && n != 1) return "No";
            else if (n % 2 == 0 && n != 0)
            {
                n /= 2;
                return RecAnswer(n);
            }
            else
            {
                return "Yes";
            }
        }

        public string NotRecAnswer(int n)
        {
            int _div;
            do
            {
                _div = n % 2;
            } while (_div != 0 && _div != 1);
            if (_div == 1) return "No";
            else return "Yes";
        }
    }
}
