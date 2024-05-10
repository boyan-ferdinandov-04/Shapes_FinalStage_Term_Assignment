using NUnit.Framework;
using Shapes_StageOne.Shapes;
using System.Drawing;
namespace Shapes.Test
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void CalculateArea_ReturnsCorrectArea()
        {
            int height = 5;
            Square square = new Square()
            {
                Height = height
            };

            float area = square.CalculateArea();

            Assert.That(area, Is.EqualTo(height * height));
        }

        [Test]
        public void PointInFigure_PointInsideSquare_ReturnsTrue()
        {
            
            int height = 5;
            Square square = new Square() { Height = height };
            Point insidePoint = new Point(3, 3);
            bool isInside = square.PointInFigure(insidePoint);
            Assert.IsTrue(isInside);
        }

        [Test]
        public void PointInFigure_PointOutsideSquare_ReturnsFalse()
        {
            int height = 5;
            Square square = new Square() { Height = height };
            Point outsidePoint = new Point(10, 10);
            bool isInside = square.PointInFigure(outsidePoint);
            Assert.IsFalse(isInside);
        }
    }
}