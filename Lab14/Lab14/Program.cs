using Lab14;

class Program
{
    delegate double Operation(int x, int y);
    delegate int Operation2(int x, int y, int c);
    static void Main(string[] args)
    {
        //3 variant first task
        AverageNumbers averageNumbers = new AverageNumbers();
        Operation operation = (int x, int y) => averageNumbers.AverageSum(x, y);
        var a = operation(2, 7);
        Console.WriteLine(a);
        Console.WriteLine();
        Console.WriteLine();

        //8 variant first task
        MaxOf maxOf = new MaxOf();
        Operation2 operation2 = (int x, int y, int c) => maxOf.GetMaxOf(x, y, c);
        var s = operation2(1, 9, 7);
        Console.WriteLine(s);
        Console.WriteLine();
        Console.WriteLine();

        //Common task
        Predicate<int> all = x => x != 50;
        Predicate<int> positive = x => x > 0;
        Predicate<int> negative = x => x < 0;
        Predicate<int> even = x => x % 2 == 0;
        Predicate<int> odd = x => x % 2 != 0;
        Predicate<int> negativeEven = x => x % 2 == 0 && x < 0;
        Predicate<int> negativeOdd = x => x % 2 != 0 && x < 0;
        Predicate<int> positiveEven = x => x % 2 == 0 && x > 0;
        Predicate<int> positiveOdd = x => x % 2 != 0 && x > 0;
        Random random = new Random();
        int[] ints = new int[10];
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = random.Next(-20, 20);
        }
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i] + " ");
        }
        CommonArray.Print(ints, all);
        Console.WriteLine();
        CommonArray.Print(ints, even);
        Console.WriteLine();
        CommonArray.Print(ints, odd);
        Console.WriteLine();
        var res1 = CommonArray.Count(ints, positive);
        Console.WriteLine(res1);
        var res2 = CommonArray.Count(ints, negative);
        Console.WriteLine(res2);
        var res3 = CommonArray.Sum(ints, negativeEven);
        Console.WriteLine(res3);
        var res4 = CommonArray.Sum(ints, positiveOdd);
        Console.WriteLine(res4);
        var res5 = CommonArray.Sum(ints, negativeOdd);
        Console.WriteLine(res5);
        var res6 = CommonArray.Sum(ints, positiveEven);
        Console.WriteLine(res6);
    }
}