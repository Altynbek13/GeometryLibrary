using System;
using GeometryLibrary.Shapes;
using Xunit;

namespace GeometryLibrary.Tests
{
    public class TriangleTests
    {
        /// <summary>
        /// Проверяет корректность вычисления площади треугольника.
        /// </summary>
        [Fact]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            var triangle = new Triangle(sideA, sideB, sideC);

            double area = triangle.CalculateArea();

            Assert.Equal(6, area, 0);  // Площадь треугольника с сторонами 3, 4 и 5 должна быть 6
        }

        /// <summary>
        /// Проверяет выбрасывание исключения, если одна из сторон треугольника меньше или равна нулю.
        /// </summary>
        [Theory]
        [InlineData(0, 4, 5)]
        [InlineData(3, -4, 5)]
        [InlineData(3, 4, 0)]
        public void Constructor_InvalidSide_ThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            var exception = Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
            Assert.Equal("Sides must be positive.", exception.Message);
        }

        /// <summary>
        /// Проверяет, что конструктор корректно инициализирует объект с положительными сторонами.
        /// </summary>
        [Fact]
        public void Constructor_ValidSides_CreatesTriangle()
        {
            double sideA = 6;
            double sideB = 8;
            double sideC = 10;

            var triangle = new Triangle(sideA, sideB, sideC);

            Assert.Equal(sideA, triangle.SideA);
            Assert.Equal(sideB, triangle.SideB);
            Assert.Equal(sideC, triangle.SideC);
        }
    }
}
