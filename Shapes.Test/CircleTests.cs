using Shapes_StageOne.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Test
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void CalculateArea_ValidCircle_ReturnsCorrectArea()
        {
            Circle circle = new Circle();
            circle.Width = 5;
            circle.Height = 5;
            float area = circle.CalculateArea();
            Assert.That(area, Is.EqualTo(78.54f).Within(0.01f)); 
        }

        [Test]
        public void PointInFigure_PointInsideCircle_ReturnsTrue()
        {
            Circle circle = new Circle();
            circle.Width = 5;
            circle.Height = 5;
            circle.Coordinates = new Point(0, 0);
            Point pointInsideCircle = new Point(2, 2);
            bool result = circle.PointInFigure(pointInsideCircle);
            Assert.IsTrue(result);
        }

        [Test]
        public void PointInFigure_PointOutsideCircle_ReturnsFalse()
        {
            Circle circle = new Circle();
            circle.Width = 5;
            circle.Height = 5;
            circle.Coordinates = new Point(0, 0);
            Point pointOutsideCircle = new Point(10, 10);
            bool result = circle.PointInFigure(pointOutsideCircle);
            Assert.IsFalse(result);
        }
    }
}
