
namespace Lab10
{
    internal class SharewareSoftware : Software
    {
        public DateOnly date = new DateOnly(2015, 3, 3);
        public override string Name { get; set; }
        public override string Company { get; set; }
        public override bool IsAct { get; set; }
        public DateOnly DateOnly { get; set; }
        public int FreeDays { get; set; }
        public DateOnly DateInstalling { get; set; }

        public SharewareSoftware(string name, string company, DateOnly dateOnly, int freeDays, DateOnly dateInstalling) : base(name, company)
        {
            Name = name;
            Company = company;
            DateOnly = dateOnly;
            FreeDays = freeDays;
            DateInstalling = dateInstalling;
        }

        public override string IsActual()
        {
            if (DateOnly.Year>date.Year && FreeDays > 60)
            {
                IsAct = true;
            }
            return $"{Name} - {IsAct}";
        }

        public override string ToString()
        {
            return $"ПО {Name} от компании {Company} выпущено в {DateOnly.Year} и имеет срок бесплатного использования {FreeDays} дней";
        }
    }
}
