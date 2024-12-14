using System;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Класс для вычисления площади различных геометрических фигур.
    /// </summary>
    public class NotNounFigure
    {
        /// <summary>
        /// Вычисляет площадь переданной фигуры.
        /// </summary>
        /// <param "name="shape"">Фигура, площадь которой необходимо вычислить.</param>
        /// <returns>Площадь фигуры.</returns>
        /// <exception "ArgumentNullException" возникает, если передана пустая фигура (null).</exception>
        public static double CalculateArea(Shape shape)
        {
            if (shape == null)
            {
                throw new ArgumentNullException("shape cannot be null");
            }
            return shape.CalculateArea();
        }
    }
}
