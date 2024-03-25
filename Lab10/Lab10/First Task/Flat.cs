//Базовый класс: Квартира(поля:стоимость квадратного метра, площадь).
//Метод: стоимость квартиры.
//Потомок: Квартира в центре(поле: название района).
//Изменения в потомке: увеличить стоимость квартиры с учетом надбавки за расположение
//2. Добавить переопределенный метод ToString
namespace Lab10
{
    internal class Flat
    {
        public double _oneMeterPrice;
        public double _area;

        public Flat(double oneMeterPrice, double area)
        {
            _oneMeterPrice = oneMeterPrice;
            _area = area;
        }

        public virtual double FlatPrice()
        {
            return _oneMeterPrice * _area;
        }
    }
}
