//Описать класс Time, соответствующий времени суток(часы и минуты). Определить операции и методы сравнения. Более ранние моменты
//считать меньшими, чем более поздние.
namespace Lab11
{
    public class Time : IEquatable<Time>
    {
        public int Hours {  get; set; }
        public int Minutes { get; set; }

        public Time(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }


        public override bool Equals(object obj)
        {
            return Equals(obj as Time);
        }

        public bool Equals(Time time)
        {
            if ((object)time == null)
            {
                return false;
            }

            if((object)time == this)
            {
                return true;
            }

            if(this.Minutes > time.Minutes && this.Hours == time.Hours)
            {
                return true;
            }
            if (this.Hours > time.Hours)
            {
                return true ;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator >(Time time, Time other)
        {
            return time.Equals(other);
        }

        public static bool operator <(Time time, Time other)
        {
            return !time.Equals(other);
        }
    }
}
