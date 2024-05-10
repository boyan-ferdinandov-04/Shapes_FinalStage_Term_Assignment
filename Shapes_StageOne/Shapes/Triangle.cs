using Shapes_StageOne.Shapes.Interfaces;
using System.Drawing;

namespace Shapes_StageOne.Shapes
{
    [Serializable]
    public class Triangle:Shape
    {
        private int _side;

        public Triangle() : base(Color.Black)
        {
        }

        public Point PointA {  get; set; }
        public Point PointB { get; set; }
        public Point PointC { get; set; }

        public int Side
        {
            get => _side;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number must be positive!");
                }
                    
                _side = value;
            }
        }


        public override float CalculateArea()
        {
            float semiperimeter = (float)(_side + _side + _side) / 2;
            float area = (float)Math.Sqrt(semiperimeter * (semiperimeter - _side) * (semiperimeter - _side) * (semiperimeter - _side));
            return area;
        }

        public override void Draw(Graphics g)
        {
            using var brush = new SolidBrush(FilledColor);
            using var pen = new Pen(BorderColor, 5);
            Point[] points = { PointA, PointB, PointC };
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
        }

        
        public override bool PointInFigure(Point point)
        {
            var a = (PointA.X - PointC.X) * (point.Y - PointC.Y) - (PointA.Y - PointC.Y) * (point.X - PointC.X);
            var b = (PointB.X - PointA.X) * (point.Y - PointA.Y) - (PointB.Y - PointA.Y) * (point.X - PointA.X);
            var c = (PointC.X - PointB.X) * (point.Y - PointB.Y) - (PointC.Y - PointB.Y) * (point.X - PointB.X);

            if ((a < 0) != (b < 0) && a != 0 && b != 0)
            {
                return false;
            }
                
            else if(c == 0 || (c < 0) == (a + b <= 0))
            {
                return true;
            }
            return false;
        }
    }
}
