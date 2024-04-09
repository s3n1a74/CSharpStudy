//Описать класс Time с полями часы, минуты и секунды. Определить метод, возвращающий количество секунд, прошедших с начала суток.
//+ свойства
namespace Lab8.Models
{
    internal class TimeUpdate

    {
        private int _hours;
        private int _minutes;
        private int _seconds;
        public int Hours
        {
            get { return _hours; }
            private set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("this value can't be negative");
                else
                    _hours = value;
            }
        }
        public int Minutes
        {
            get { return _minutes; }
            private set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentOutOfRangeException("invalid value of minutes");
                else
                    _minutes = value;
            }
        }

        public int Seconds
        {
            get { return _seconds; }
            private set
            {
                if (value < 0 || value > 60)
                    throw new ArgumentOutOfRangeException("invalid value of seconds");
                else
                    _seconds = value;
            }
        }

        public TimeUpdate(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }

        public int AllTimeInSeconds()
        {
            _seconds += _hours * 3600 + _minutes * 60;
            return _seconds;
        }
    }
}