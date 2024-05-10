using System.Drawing;
using Shapes_StageOne.Shapes;
namespace Rectangle.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void CalculateArea_ReturnsCorrectArea()
        {
            // Arrange
            int height = 5;
            int width = 10;
            Rectangle rectangle = new Rectangle(Color.Black)
            {
                Height = height,
                Width = width
            };

            // Act
            float area = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(height * width, area);
        }

        [Test]
        public void PointInFigure_PointInsideRectangle_ReturnsTrue()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(Color.Black)
            {
                Coordinates = new Point(0, 0),
                Height = 5,
                Width = 10
            };
            Point insidePoint = new Point(2, 2);

            // Act
            bool isInside = rectangle.PointInFigure(insidePoint);

            // Assert
            Assert.IsTrue(isInside);
        }

        [Test]
        public void PointInFigure_PointOutsideRectangle_ReturnsFalse()
        {
            // Arrange
            Rectangle rectangle = new Rectangle(Color.Black)
            {
                Coordinates = new Point(0, 0),
                Height = 5,
                Width = 10
            };
            Point outsidePoint = new Point(15, 15);

            // Act
            bool isInside = rectangle.PointInFigure(outsidePoint);

            // Assert
            Assert.IsFalse(isInside);
        }
    }
}