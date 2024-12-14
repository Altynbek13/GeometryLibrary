using System;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Представляет треугольник и предоставляет методы для работы с ним.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса Triangle с указанными длинами сторон.
        /// </summary>
        /// <param name="sideA">Длина первой стороны треугольника.</param>
        /// <param name="sideB">Длина второй стороны треугольника.</param>
        /// <param name="sideC">Длина третьей стороны треугольника.</param>
        /// <exception ArgumentException
        /// Выбрасывается, если длина любой стороны меньше или равна нулю.
        /// </exception>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides must be positive.");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Вычисляет площадь треугольника с использованием формулы Герона.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public override double CalculateArea()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
}
