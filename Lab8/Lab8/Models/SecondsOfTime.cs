//Для каждой из N заданных моментов времени вывести сообщение о количестве секунд, прошедших с начала суток.
namespace Lab8.Models
{
    internal class SecondsOfTime
    {
        int _hours;
        int _minutes;
        int _seconds;


        public int Hours
        {
            get { return _hours; }
            set
            {
                if (value < 0 || value > 23)
                    throw new ArgumentOutOfRangeException("invalid hours value");
                else
                    _hours = value;
            }
        }
        public int Minutes
        {
            get { return _minutes; }
            set
            {
                if (value < 0 || _minutes > 59)
                    throw new ArgumentOutOfRangeException("invalid minutes value");
                else
                    _minutes = value;
            }
        }
        public int Seconds
        {
            get { return _seconds; }
            set
            {
                if (value < 0 || _minutes > 59)
                    throw new ArgumentOutOfRangeException("invalid minutes value");
                else
                    _seconds = value;
            }
        }

        public SecondsOfTime(int _hours, int _minutes, int _seconds)
        {
            Hours = _hours;
            Minutes = _minutes;
            Seconds = _seconds;
        }

        public int AlLTimeInSeconds()
        {
            return _hours * 3600 + _minutes * 60 + _seconds;
        }
    }
}
