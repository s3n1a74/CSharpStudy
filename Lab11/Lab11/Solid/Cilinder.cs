namespace Lab11.Solid
{
    internal class Cilinder : ISolid
    {
        public double H { get; set; }
        public double R { get; set; }

        public Cilinder(double h, double r)
        {
            H = h;
            R = r;
        }

        public string Display()
        {
            return $"Цилиндр с радиусом {R} см и высотой {H} см имеет объем {Volume()} см^3 и площадь поверхности {SurfaceArea()} см^2";
        }

        public double SurfaceArea()
        {
            return 2 * Math.PI * Math.Pow(R, 2) + 2 * Math.PI * H;
        }

        public double Volume()
        {
            return Math.PI * Math.Pow(R, 2) * H;
        }
    }
}
