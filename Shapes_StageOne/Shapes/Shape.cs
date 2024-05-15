using Shapes_StageOne.Shapes.Interfaces;
using System.Drawing;
using System.Xml.Serialization;

namespace Shapes_StageOne.Shapes
{
    [Serializable]
    [XmlInclude(typeof(Square))]
    [XmlInclude(typeof(Rectangle))]
    [XmlInclude(typeof(Triangle))]
    [XmlInclude(typeof(Circle))]
    public abstract class Shape
    {
        private Color _color;
        public Color FilledColor { get; set; } = Color.Transparent;
        public Color BorderColor { get; set; }
        public Point Coordinates { get; set; }
        public bool IsSelected { get; set; }
        
        //Protected Constructor
        protected Shape(Color color)
        {
            _color = color;
        }

        public abstract float CalculateArea();

        public abstract void Draw(Graphics g);

        public abstract bool PointInFigure(Point point);
        
    }
}
