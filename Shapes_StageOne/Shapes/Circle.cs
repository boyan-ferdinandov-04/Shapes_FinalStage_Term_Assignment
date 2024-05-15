using Shapes_StageOne.Shapes.Interfaces;
using System.Drawing;

namespace Shapes_StageOne.Shapes
{
    [Serializable]
    public class Circle:Shape,IShapeInfo
    {
        private int _width;
        private int _height;

        public Circle() : base(Color.Black)
        {

        }

        public int Width
        {
            get => _width;

            set
            {
                if (value < 0)
                    throw new ArgumentException("Number must be positive!");

                _width = value;
            }
        }

        public int Height
        {
            get => _height;

            set
            {
                if (value < 0)
                    throw new ArgumentException("Number must be positive!");

                _height = value;
            }
        }

        public override float CalculateArea()
        {
            return (float)(Math.PI * (Width * Height));
        }

        public string Details()
        {
            return $"Coordinates: ({Coordinates.X}, {Coordinates.Y}), Width: {Width}, Height: {Height}, Area: {CalculateArea()}";
        }

        public override void Draw(Graphics g)
        {
            using var brush = new SolidBrush(FilledColor);
            using var pen = new Pen(BorderColor, 5);
            g.FillEllipse(brush, Coordinates.X - Width / 2, Coordinates.Y - Height / 2, Width, Height);
            g.DrawEllipse(pen, Coordinates.X - Width / 2, Coordinates.Y - Height / 2, Width, Height);
        }

        public override bool PointInFigure(Point point)
        {
            if ((Coordinates.X <= point.X && point.X <= Coordinates.X + Width) &&
              (Coordinates.Y <= point.Y && point.Y <= Coordinates.Y + Height))
            {
                return true;
            }
            return false;
        }
    }
}
