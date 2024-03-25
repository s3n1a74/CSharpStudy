
namespace Lab10
{
    internal class FreeSoftware : Software
    {
        public override string Name {  get; set; }
        public override string Company {  get; set; }
        public override bool IsAct { get; set; } = true;

        public FreeSoftware(string name, string company) : base(name, company) { }


        public override string IsActual()
        {
            return $"{Name} - {IsAct}";
        }

        public override string ToString()
        {
            return $"Бесплатное ПО под названием {Name} от производителя {Company} актуально";
        }
    }
}
