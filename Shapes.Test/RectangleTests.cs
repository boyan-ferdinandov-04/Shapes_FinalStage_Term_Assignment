using Shapes_StageOne.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle = Shapes_StageOne.Shapes.Rectangle;

namespace Shapes.Test
{
    [TestFixture]
    public class RectangleTests
    {
        [Test]
        public void CalculateArea_ReturnsCorrectArea()
        {
            int height = 5;
            int width = 10;
            Rectangle rectangle = new Rectangle()
            {
                Height = height,
                Width = width
            };

            
            float area = rectangle.CalculateArea();
            Assert.That(area, Is.EqualTo(height * width));
        }

        [Test]
        public void PointInFigure_PointInsideRectangle_ReturnsTrue()
        {
            Rectangle rectangle = new Rectangle()
            {
                Coordinates = new Point(0, 0),
                Height = 5,
                Width = 10
                
            };
            Point insidePoint = new Point(2, 2);

            bool isInside = rectangle.PointInFigure(insidePoint);
            Assert.IsTrue(isInside);
        }

        [Test]
        public void PointInFigure_PointOutsideRectangle_ReturnsFalse()
        {
            Rectangle rectangle = new Rectangle()
            {
                Coordinates = new Point(0, 0),
                Height = 5,
                Width = 10
            };
            Point outsidePoint = new Point(15, 15);
            bool isInside = rectangle.PointInFigure(outsidePoint);
            Assert.IsFalse(isInside);
        }
    }
}
