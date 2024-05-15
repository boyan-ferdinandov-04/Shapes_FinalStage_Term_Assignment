using Shapes_StageOne.Shapes.Interfaces;
using System.Drawing;


namespace Shapes_StageOne.Shapes
{
    [Serializable]
    public class Rectangle:Shape,IShapeInfo
    {
        private int _height;
        private int _width;

        public Rectangle() : base(Color.Black)
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
                _height = value;

            }
        }

        public int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
              
            }
        }

        public override float CalculateArea()
        {
            float area = Height * Width;
            return area;
            
        }

        public string Details()
        {
            return $"Coordinates: X: ({Coordinates.X} Y: {Coordinates.Y}), Height: {Height}, Width: {Width}, Area: {CalculateArea()}";
        }

        public override void Draw(Graphics g)
        {
            using var brush = new SolidBrush(FilledColor);
            using var pen = new Pen(BorderColor, 5);
            g.FillRectangle(brush, Coordinates.X, Coordinates.Y, Width, Height);
            g.DrawRectangle(pen, Coordinates.X, Coordinates.Y, Width, Height);
        }

        public override bool PointInFigure(Point point)
        {
            if ((point.X >= Coordinates.X && Coordinates.X + _width >= point.X) &&
                (point.Y >= Coordinates.Y && Coordinates.Y + _height >= point.Y))
            {
                return true;
            }
            return false;
        }
    }
}
