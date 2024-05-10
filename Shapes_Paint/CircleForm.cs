using Shapes_StageOne.Shapes;

namespace Shapes_Paint
{
    public partial class CircleForm : Form
    {
        List<Circle> circles = new List<Circle>();
        public CircleForm()
        {
            InitializeComponent();
        }

        public List<Circle> Circles
        {
            get => circles;

            set
            {
                circles = value;
                textBoxX.Clear();
                textBoxY.Clear();
                textBoxHeight.Clear();
                textBoxWidth.Clear();

                foreach (var circle in circles)
                {
                    textBoxX.Multiline = true;  
                    textBoxY.Multiline = true;
                    textBoxHeight.Multiline = true;
                    textBoxWidth.Multiline = true;
                    textBoxArea.Multiline = true;

                    textBoxX.ScrollBars = ScrollBars.Both;
                    textBoxY.ScrollBars = ScrollBars.Both;
                    textBoxHeight.ScrollBars = ScrollBars.Both;
                    textBoxWidth.ScrollBars = ScrollBars.Both;
                    textBoxArea.ScrollBars = ScrollBars.Both;

                    textBoxX.AppendText(circle.Coordinates.X.ToString() + Environment.NewLine);
                    textBoxY.AppendText(circle.Coordinates.Y.ToString() + Environment.NewLine);
                    textBoxHeight.AppendText(circle.Height.ToString() + Environment.NewLine);
                    textBoxWidth.AppendText(circle.Width.ToString() + Environment.NewLine);
                    textBoxArea.AppendText(circle.CalculateArea().ToString() + Environment.NewLine);
                }
            }
        } 
    }
}
