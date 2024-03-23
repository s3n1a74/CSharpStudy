//Описать класс Time с полями часы, минуты и секунды. Определить метод, возвращающий количество секунд, прошедших с начала суток.
namespace Lab8.Models
{
    internal class Time
    {
        public int _hours;
        public int _minutes;
        public int _seconds;

        public Time(int hours, int minutes, int seconds)
        {
            _hours = hours;
            _minutes = minutes;
            _seconds = seconds;
        }

        public int AllTimeInSeconds()
        {
            _seconds += _hours * 3600 + _minutes * 60;
            return _seconds;
        }
    }
}
