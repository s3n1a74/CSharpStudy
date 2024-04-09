//Дан массив целых чисел размером N.Возведите в квадрат элементы a и b. Предусмотрите обработку исключительных ситуаций.
namespace Lab13
{
    internal class ArrayN1
    {
        private int[] ints;
        private int _firstPow;
        private int _secondPow;

        public (int,int) PowNumbers()
        {
            try
            {
                Console.WriteLine("Введите количество элементов массива");
                var _n = Convert.ToInt32(Console.ReadLine());
                if (_n <= 1) throw new ArgumentException("количество элементов не может быть меньше 1");

                ints = new int[_n];

                for (int i = 0; i < _n; i++)
                {
                    Console.WriteLine($"Введите {i + 1} элемент массива");
                    try
                    {
                        int element = Convert.ToInt32(Console.ReadLine());
                        ints[i] = element;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Число должно быть целым");
                        i--;
                    }
                }

                Console.WriteLine("Введите индекс первого числа");
                int firstIndex = Convert.ToInt32(Console.ReadLine());
                if (firstIndex < 0 || firstIndex >= _n)
                    throw new ArgumentOutOfRangeException("Введен недопустимый индекс");

                Console.WriteLine("Введите индекс второго числа");
                int secondIndex = Convert.ToInt32(Console.ReadLine());
                if (secondIndex < 0 || secondIndex >= _n)
                    throw new ArgumentOutOfRangeException("Введен недопустимый индекс");
                _firstPow = (int)Math.Pow(ints[firstIndex], 2);
                _secondPow = (int)Math.Pow(ints[secondIndex], 2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return (_firstPow,_secondPow);
        }
    }
}
