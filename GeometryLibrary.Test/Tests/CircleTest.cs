using GeometryLibrary.Shapes;
using System;
using Xunit;

namespace GeometryLibrary.Tests
{
    /// <summary>
    /// Набор тестов для проверки функциональности класса Circle.
    /// </summary>
    public class CircleTests
    {
        /// <summary>
        /// Тест проверяет, что метод Circle.CalculateArea возвращает корректное значение площади, если радиус круга задан правильно.
        /// </summary>
        [Fact]
        public void CalculateArea_WithValidRadius_ReturnsCorrectArea()
        {
            double radius = 5;
            var circle = new Circle(radius);

            double area = circle.CalculateArea();

            double expectedArea = Math.PI * Math.Pow(radius, 2);
            Assert.Equal(expectedArea, area, precision: 5);
        }

        /// <summary>
        /// Тест проверяет, что конструктор Circle выбрасывает ArgumentException, если радиус равен 0.
        /// </summary>
        [Fact]
        public void Constructor_WithZeroRadius_ThrowsArgumentException()
        {
            double radius = 0;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        /// <summary>
        /// Тест проверяет, что конструктор Circle выбрасывает ArgumentException, если радиус отрицательный.
        /// </summary>
        [Fact]
        public void Constructor_WithNegativeRadius_ThrowsArgumentException()
        {
            double radius = -5;

            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        /// <summary>
        /// Тест проверяет, что свойство Circle.Radius устанавливается правильно.
        /// </summary>
        [Fact]
        public void Radius_SetPropertyCorrectly()
        {
            double radius = 10;
            var circle = new Circle(radius);

            double actualRadius = circle.Radius;

            Assert.Equal(radius, actualRadius);
        }
    }
}
