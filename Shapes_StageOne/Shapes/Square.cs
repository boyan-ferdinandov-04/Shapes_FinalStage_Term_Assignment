using Shapes_StageOne.Shapes.Interfaces;
using System.Drawing;

namespace Shapes_StageOne.Shapes
{
    [Serializable]
    public class Square : Shape
    {
        private int _height;

        public Square() : base(Color.Black)
        {
        }

        public int Height
        {
            get
            {
                return _height;
            }

            set
            {
                if(_height < 0)
                {
                    throw new ArgumentException("No negative values");
                }

                _height = Math.Abs(value);
            }
        }

        public override float CalculateArea()
        {
            float area = (float)(Math.Pow(_height, 2));
            return area;  
          
        }

        public override void Draw(Graphics g)
        {
            using var brush = new SolidBrush(FilledColor);
            using var pen = new Pen(BorderColor, 5);
            g.FillRectangle(brush, Coordinates.X, Coordinates.Y, Height, Height);
            g.DrawRectangle(pen, Coordinates.X, Coordinates.Y, Height, Height);
        }

        public override bool PointInFigure(Point point)
        {

           if((Coordinates.X < point.X && point.X < Coordinates.X + Height) && Coordinates.Y < point.Y && point.Y < Coordinates.Y + Height)
           {
                return true;
           }
           
           return false;
        }
    }
}
