using System;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Представляет форму круга.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Получает или задает радиус круга.
        /// </summary>
        /// <exception "ArgumentException" возникает, если радиус меньше или равен нулю.</exception>
        public double Radius { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса "Circle" с указанным радиусом.
        /// </summary>
        /// <param "name="radius"">Радиус круга.</param>
        /// <exception "ArgumentException" возникает, если радиус меньше или равен нулю.</exception>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным");
            }
            Radius = radius;
        }

        /// <summary>
        /// Вычисляет площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);
    }
}
