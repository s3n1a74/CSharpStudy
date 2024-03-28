namespace Lab11.Solid
{
    internal class Cube : ISolid
    {
        public double A { get; set; }

        public Cube(double A) { this.A = A; }

        public double SurfaceArea()
        {
            return 6 * Math.Pow(A, 2);
        }

        public double Volume()
        {
            return Math.Pow(A, 3);
        }

        public string Display()
        {
            return $"Куб со сторонами {A} см имеет площадь поверхности {SurfaceArea()} см^2 и объем {Volume()} см^3";
        }
    }
}
