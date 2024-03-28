//Описать класс Rate, соответствующий пакетам услуг сотовой связи. Каждый пакет услуг определяется стоимостью, количеством
//минут и количеством бесплатных минут.
//Определить в классе операции и методы сравнения, сравнивающие пакеты по экономичности. Более экономичным считается тот пакет услуг,
//в котором стоимость одной минуты ниже.
namespace Lab11
{
    internal class Rate : IEquatable<Rate>
    {
        public double _oneMinutePrice;
        public double Price {  get; set; }
        public double Minutes {  get; set; }
        public double BonusMinutes { get; set; }

        public Rate(double price, double minutes, double bonusMinutes)
        {
            _oneMinutePrice = this.GetOneMinutePrice();
            Price = price;
            Minutes = minutes;
            BonusMinutes = bonusMinutes;
        }

        public double GetOneMinutePrice()
        {
        // договорились ведь, что цена на минуты будет включать в себя сумма платных и бонусных минут.
            return Price / Minutes;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Rate);
        }

        public bool Equals(Rate rate)
        {
            if (this._oneMinutePrice < rate._oneMinutePrice)
            {
                return true;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return _oneMinutePrice.GetHashCode();
        }

        public static bool operator >(Rate rate, Rate other)
        {
            return rate.Equals(other);
        }

        public static bool operator <(Rate rate, Rate other)
        {
            return !rate.Equals(other);
        }
    }
}
