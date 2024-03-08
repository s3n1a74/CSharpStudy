using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Вычислить сумму: 1! + 2! + ... + n! (Определить метод для рассчета факториала натурального числа).
namespace Lab7.Models
{
    internal class FSum
    {


        public static int FSumm(int n)
        {
            int _f = 1;
            if (n == 0)
            {
                _f = 1;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    _f *= i;
                }
            }
            return _f;
        }
    }
}
