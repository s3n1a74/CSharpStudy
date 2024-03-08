using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
//Даны 2 одномерных массива разной длины. Посчитать в них количество элементов, больше значения t
//и первым на экран вывести на экран массив, в котором этих элементов меньше.
namespace Lab7.Models
{
    internal class Arrays
    {


        public static void GetArr()
        {
            int _t = 10;
            int _counter = 0, _counter2 = 0;
            int[] array = new int[6];
            int[] array2 = new int[8];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 20);
            }

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(0, 20);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > _t)
                {
                    _counter++;
                }
            }

            for (int i = 0; i < array2.Length; i++)
            {
                if (array2[i] > _t)
                {
                    _counter2++;
                }
            }

            if (_counter > _counter2)
            {
                foreach (var elem in array)
                {
                    Console.Write(elem + " ");
                }
            }
            else if (_counter2 > _counter)
            {
                foreach (var elem in array2)
                {
                    Console.Write(elem + " ");
                }
            }
            else
            {
                Console.WriteLine("Количество элементов больше t равно в обоих массивах");
            }
        }
    }
}
