using System;
using GeometryLibrary.Shapes;
using Moq;
using Xunit;

namespace GeometryLibrary.Tests
{
    public class NotNounFigureTests
    {
        /// <summary>
        /// Проверяет, что метод CalculateArea корректно вызывает метод CalculateArea у фигуры.
        /// </summary>
        [Fact]
        public void CalculateArea_ValidShape_ReturnsCorrectArea()
        {
            var shapeMock = new Mock<Shape>();
            shapeMock.Setup(shape => shape.CalculateArea()).Returns(25);

            double area = NotNounFigure.CalculateArea(shapeMock.Object);

            Assert.Equal(25, area);
        }

        /// <summary>
        /// Проверяет выбрасывание исключения, если передана пустая фигура.
        /// </summary>
        [Fact]
        public void CalculateArea_NullShape_ThrowsArgumentNullException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => NotNounFigure.CalculateArea(null));
            Assert.Equal("shape cannot be null", exception.ParamName);
        }

        /// <summary>
        /// Проверяет, что метод CalculateArea вызывает правильное исключение, если фигура не инициализирована.
        /// </summary>
        [Fact]
        public void CalculateArea_NullShape_ThrowsArgumentNullExceptionMessage()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => NotNounFigure.CalculateArea(null));
            Assert.Contains("shape cannot be null", exception.Message);
        }
    }
}
