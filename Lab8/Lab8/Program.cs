using Lab8;
using Lab8.Models;

class Program
{
    static void Main(string[] args)
    {
        //first task
        Time time = new Time(2, 4, 3);
        var a = time.AllTimeInSeconds();
        Console.WriteLine(a);
        Console.WriteLine();
        Console.WriteLine();

        //second task
        TimeUpdate timeUpdate = new TimeUpdate(7, 4, 3);
        var d = timeUpdate.AllTimeInSeconds();
        Console.WriteLine(d);
        Console.WriteLine();
        Console.WriteLine();

        //third task
        SecondsOfTime secondsOfTime = new SecondsOfTime(7, 4, 3);
        var w = secondsOfTime.AlLTimeInSeconds();
        Console.WriteLine(w);
        Console.WriteLine();
        Console.WriteLine();

        //fourth task
        DateTime dateTime1 = new DateTime(2015, 7, 20, 15, 30, 25);
        DateTime dateTime2 = new DateTime(2015, 7, 20, 18, 30, 25);
        FlyOne flyOne = new FlyOne(15, dateTime1, dateTime2, "London");
        FlyOne flyOne1 = new FlyOne(16, dateTime1, dateTime2, "Lissbon");
        FlyOne flyOne2 = new FlyOne(17, dateTime1, dateTime2, "London");
        FlyOne[] flyOne3 = [flyOne, flyOne1, flyOne2];
        foreach (var t in flyOne3)
        {
            t.TripOnDisplay();
        }
        Console.WriteLine();
        Console.WriteLine();

        //fiveth task
        DateTime dateTime = new DateTime(2015, 7, 20, 15, 30, 25);
        DateTime dateTime0 = new DateTime(2015, 7, 20, 18, 30, 25);
        FlyOneUpdate flyOneUp1 = new FlyOneUpdate(15, dateTime, dateTime0, "London");
        FlyOneUpdate flyOneUp2 = new FlyOneUpdate(16, dateTime, dateTime0, "Lissbon");
        FlyOneUpdate flyOneUp3 = new FlyOneUpdate(17, dateTime, dateTime0, "London");
        FlyOneUpdate.flyOneUpdates.Add(flyOneUp1);
        FlyOneUpdate.flyOneUpdates.Add(flyOneUp2);
        FlyOneUpdate.flyOneUpdates.Add(flyOneUp3);
        FlyOneUpdate.flyOneUpdates[0].TripOnDisplay();
        FlyOneUpdate.flyOneUpdates[1].TripOnDisplay();
        FlyOneUpdate.flyOneUpdates[2].TripOnDisplay();
        Console.WriteLine();
        Console.WriteLine();

        //sixth task
        DateOnly dateOnly = new DateOnly(1997,3,31);
        DayNumber dayNumber = new DayNumber(dateOnly);
        var p = dayNumber.GetA();
        Console.WriteLine(p);
        var o = dayNumber.GetY();
        Console.WriteLine(o);
        var i = dayNumber.GetM();
        Console.WriteLine(i);
        var u = dayNumber.GetN();
        Console.WriteLine(u);
        var v = dayNumber.GetDayOfTheWeek();
        Console.WriteLine(v);
        Console.WriteLine();
        Console.WriteLine();

        //seventh task
        Polinomial2 polinomial = new Polinomial2(3,4,5);
        Polinomial2 polinomial2 = new Polinomial2(6,8,10);
        var e = polinomial.Value(2);
        Console.WriteLine(e);
        var r = polinomial.ToString();
        Console.WriteLine(r);
    }
}