using Shapes_StageOne.Shapes;

namespace Shapes_Paint
{
    public partial class TriangleForm : Form
    {
        private List<Triangle> triangles;
        public TriangleForm()
        {
            InitializeComponent();
        }

        
        public List<Triangle> Triangles
        {
            get
            { 
                return triangles; 
            }
            set
            {
                triangles = value;

                textBoxA.Multiline = true;
                textBoxB.Multiline = true;
                textBoxC.Multiline = true;
                side_box.Multiline = true;
                textBoxArea.Multiline = true;

                textBoxA.ScrollBars = ScrollBars.Both;
                textBoxB.ScrollBars = ScrollBars.Both;
                textBoxC.ScrollBars = ScrollBars.Both;
                side_box.ScrollBars = ScrollBars.Both;
                textBoxArea.ScrollBars = ScrollBars.Both;

                foreach (Triangle triangle in triangles)
                {
                    textBoxA.AppendText($"X:{triangle.PointA.X}, Y: {triangle.PointA.Y}" + Environment.NewLine);
                    textBoxB.AppendText($"X:{triangle.PointB.X}, Y: {triangle.PointB.Y}" + Environment.NewLine);
                    textBoxC.AppendText($"X:{triangle.PointC.X}, Y: {triangle.PointC.Y}" + Environment.NewLine);
                    side_box.AppendText(triangle.Side.ToString() + Environment.NewLine);
                    textBoxArea.AppendText(triangle.CalculateArea().ToString() + Environment.NewLine);
                }
            }
        }
    }
}
