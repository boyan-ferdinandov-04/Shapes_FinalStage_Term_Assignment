using Shapes_StageOne.Shapes;
using System.Drawing;

namespace TriangleTests
{
    [TestFixture]
    public class Tests
    {

        [Test]
        public void CalculateArea_ReturnsCorrectArea()
        {
            int side = 5;
            Triangle triangle = new Triangle(Color.Black) { Side = side };
            float area = triangle.CalculateArea();
            Assert.AreEqual(10.82531755f, area, 0.0001f);
        }

        [Test]
        public void PointInFigure_PointInsideTriangle_ReturnsTrue()
        {
            
            Triangle triangle = new Triangle(Color.Black)
            {
                SideA = new Point(0, 0),
                SideB = new Point(4, 0),
                SideC = new Point(0, 3)
            };
            Point insidePoint = new Point(1, 1);

            
            bool isInside = triangle.PointInFigure(insidePoint);

            Assert.IsTrue(isInside);
        }

        [Test]
        public void PointInFigure_PointOutsideTriangle_ReturnsFalse()
        {
            Triangle triangle = new Triangle(Color.Black)
            {
                SideA = new Point(0, 0),
                SideB = new Point(4, 0),
                SideC = new Point(0, 3)
            };
            Point outsidePoint = new Point(5, 5);

            bool isInside = triangle.PointInFigure(outsidePoint);
            Assert.IsFalse(isInside);
        }
    }
}