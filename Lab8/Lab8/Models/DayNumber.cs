//Описать структуру Date, соответствующую датам григорианского календаря после 1583 г. Дата задается тройкой
//день, месяц и год. Определить функцию , возвращающую название дня недели, соответствующего дате.
namespace Lab8.Models
{
    public class DayNumber
    {
        public DateOnly _dayNumber;
        public DateOnly date = new DateOnly(1583, 12, 31);
        public DateOnly DayNumber1
        {
            get { return _dayNumber; }
            set
            {
                if (value.Year < date.Year)
                {
                    throw new ArgumentOutOfRangeException("invalid value");
                }

                _dayNumber = value;
            }
        }

        public DayNumber(DateOnly _dayNumber)
        {
            DayNumber1 = _dayNumber;
        }

        public double GetA()
        {
            return (14 - _dayNumber.Month) / 12;
        }

        public double GetY()
        {
            return _dayNumber.Year - GetA();
        }

        public double GetM()
        {
            return _dayNumber.Month - GetA() * 12 - 2;
        }

        public int GetN()
        {
            return (int)(7000 + _dayNumber.Day + GetY() + GetY() / 4 - GetY() / 100 + GetY() / 400 + 31 * GetM() / 12) % 7;
        }

        public string GetDayOfTheWeek()
        {
            GetN();
            int day = GetN();
            switch (day)
            {
                case 0:
                    return "Воскресенье";
                    break;
                case 1:
                    return "Понедельник";
                    break;
                case 3:
                    return "Вторник";
                    break;
                case 4:
                    return "Среда";
                    break;
                case 5:
                    return "Четверг";
                    break;
                case 6:
                    return "Пятница";
                    break;
                case 7:
                    return "Суббота";
                    break;
                default:
                    return "Invalid Day";
            }
        }
    }
}
