using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes_StageOne.Shapes.Interfaces
{
    public interface IDrawable
    {
        void DrawSquare(int x, int y, Color borderColor, Color fillColor, int height);
        void DrawRectangle(int x, int y, Color borderColor, Color fillColor, int height, int width);
        void DrawTriangle(Point sideA, Point sideB, Point sideC, Color borderColor, Color fillColor);
        void DrawCircle(Color colorBorder, Color colorFill, int x, int y, int radius1, int radius2);
    }
}
