using Shapes_StageOne.Shapes;
using System.Drawing;

namespace Shapes.Test
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void CalculateArea_ReturnsCorrectArea()
        {
            int side = 6;
            Triangle triangle = new Triangle() { Side = side };
            float area = triangle.CalculateArea();
            Assert.That(15.58846f, Is.EqualTo(area).Within(0.00001f));
        }

        [Test]
        public void PointInFigure_PointInsideTriangle_ReturnsTrue()
        {
            
            Triangle triangle = new Triangle()
            {
                PointA = new Point(0, 0),
                PointB = new Point(4, 0),
                PointC = new Point(0, 3)
            };
            Point insidePoint = new Point(1, 1);

            
            bool isInside = triangle.PointInFigure(insidePoint);

            Assert.IsTrue(isInside);
        }

        [Test]
        public void PointInFigure_PointOutsideTriangle_ReturnsFalse()
        {
            Triangle triangle = new Triangle()
            {
                PointA = new Point(0, 0),
                PointB = new Point(4, 0),
                PointC = new Point(0, 3)
            };
            Point outsidePoint = new Point(5, 5);

            bool isInside = triangle.PointInFigure(outsidePoint);
            Assert.IsFalse(isInside);
        }
    }
}