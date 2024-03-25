
namespace Lab10
{
    internal class CommercialSoftware : Software
    {
        DateOnly date = new DateOnly(2014,3,3);
        public override string Name { get; set; }
        public override string Company { get; set; }
        public override bool IsAct { get; set; }
        public double Price { get; set; }
        public DateOnly DateRelease { get; set; }
        public DateOnly DateInstalling { get; set; }

        public CommercialSoftware(string name, string company, double price, DateOnly dateRelease, DateOnly dateInstalling) : base(name, company)
        {
            Name = name;
            Company = company;
            Price = price;
            DateRelease = dateRelease;
            DateInstalling = dateInstalling;
        }

        public override string IsActual()
        {
            if (DateRelease.Year > date.Year)
            {
                IsAct = true;
            }
            return $"{Name} - {IsAct}";
        }

        public override string ToString()
        {
            return $"Коммерческое ПО {Name} от компании {Company} стоит {Price}$ и выпущено в {DateRelease.Year}";
        }
    }
}
