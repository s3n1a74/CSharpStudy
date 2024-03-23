//Ввести информацию о N рейсах самолетов (№ рейса, время вылета, время прилета, пункт назначения). Вывести информацию обо всех рейсах
//в заданный город.
namespace Lab8.Models
{
    internal class FlyOne
    {

        public int TripNumber { get; set; }
        public DateTime TimeOut { get; set; }
        public DateTime TimeIn { get; set; }
        public string CityIn { get; set; }

        public FlyOne(int _tripNumber, DateTime _timeOut, DateTime _timeIn, string _cityIn)
        {
            TripNumber = _tripNumber;
            TimeOut = _timeOut;
            TimeIn = _timeIn;
            CityIn = _cityIn;
        }

        public void TripOnDisplay()
        {
            if (CityIn == "London")
            {
                Console.WriteLine($"Рейс №{TripNumber} отправляется в {TimeOut:t} и прибывает в {TimeIn:t} в город {CityIn}");
            }
        }
    }
}
