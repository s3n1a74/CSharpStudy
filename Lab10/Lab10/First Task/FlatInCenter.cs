namespace Lab10
{
    internal class FlatInCenter : Flat
    {
        public string _district;

        public FlatInCenter(double oneMeterPrice, double area, string district) : base(oneMeterPrice,area)
        {
            _district = district;
        }

        public override double FlatPrice()
        {
            return _oneMeterPrice * _area * 0.1;
        }

        public override string ToString()
        {
            return $"Квартира в районе {_district} будет стоить {FlatPrice()}";
        }
    }
}
