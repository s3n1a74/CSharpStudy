//Описать класс Mtrix2 матриц вида(a11,a12,a21,a22)? где а прин. R. Определить в нем:
//конструктор, принимающий 4 элемента матрицы
//конструктор, принимающий 2 элемента главной диагонали (остальные элементы равны нулю)
//копирующий конструктор
//метод Det, возвращающий определитель матрицы
//метод Transponce, возвращающий транспонированну матрицу
//операции сложения и вычитания матриц
//операцию умножения(аргументы могут быть как матрицами, так и матрицей и действительным числом)
//метод вывода матриц на консоль
namespace Lab9
{
    internal class Matrix2
    {
        public double A11 { get; set; }
        public double A12 { get; set; }
        public double A21 { get; set; }
        public double A22 { get; set; }

        public Matrix2(double a11, double a12, double a21, double a22)
        {
            A11 = a11;
            A12 = a12;
            A21 = a21;
            A22 = a22;
        }

        public Matrix2(double a11, double a22)
        {
            A11 = a11;
            A12 = 0;
            A21 = 0;
            A22 = a22;
        }

        public Matrix2(Matrix2 a)
        {
            A11 = a.A11;
            A12 = a.A12;
            A21 = a.A21;
            A22 = a.A22;
        }

        public double Det()
        {
            return A11 * A22 - A12 * A21;
        }

        public Matrix2 Transponce(Matrix2 a)
        {
            return new Matrix2(A11, A21, A12, A22);
        }

        public static Matrix2 operator +(Matrix2 a, Matrix2 b)
        {
            return new Matrix2(a.A11 + b.A11, a.A12 + b.A12, a.A21 + b.A21, a.A22 + b.A22);
        }

        public static Matrix2 operator -(Matrix2 a, Matrix2 b)
        {
            return new Matrix2(a.A11 -  b.A11, a.A12 - b.A12, a.A21 -  b.A21, a.A22 - b.A22);
        }

        public static Matrix2 operator *(Matrix2 a, Matrix2 b)
        {
            return new Matrix2(a.A11 * b.A11, a.A12 * b.A12, a.A21 * b.A21, a.A22 * b.A22);
        }

        public static Matrix2 operator *(Matrix2 a, double b)
        {
            return new Matrix2(a.A11 * b, a.A12 * b, a.A21 * b, a.A22 * b);
        }

        public override string ToString()
        {
            return $"{A11}   {A12} \n{A21}   {A22}";
        }
    }
}
