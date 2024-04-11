/* Определить делегат double Operation (int m,int n). Экземпляру делегата присвоить лямда выражение,которое вычисляет и 
 * возвращает среднее арифметическое чисел от m до n.*/
namespace Lab14
{
    internal class AverageNumbers
    {
        private double _averageSum;

        public double AverageSum(int m, int n)
        {
            if (n > m )
            {
                int _lenght = (n - m) + 1;
                int[] ints = new int[_lenght];
                int value = m;
                int _sum = 0;
                for (int i = 0; i < _lenght; i++)
                {
                    ints[i] = value;
                    value++;
                }
                for (int i = 0; i < _lenght; ++i)
                {
                    _sum += ints[i];
                }
                _averageSum = _sum / _lenght;
            }
            else Console.WriteLine("invalid values");
            return _averageSum;
        }
    }
}

