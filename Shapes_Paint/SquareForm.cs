using Shapes_StageOne.Shapes;

namespace Shapes_Paint
{
    public partial class Form2 : Form
    {
        private List<Square> squares = new List<Square>();

        public Form2()
        {
            InitializeComponent();
        }

        public List<Square> Squares
        {
            get => squares;

            set
            {
                squares = value;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                height_box.Clear();

                textBox1.Multiline = true;
                textBox2.Multiline = true;
                textBox3.Multiline = true;
                height_box.Multiline = true;

                textBox1.ScrollBars = ScrollBars.Both;
                textBox2.ScrollBars = ScrollBars.Both;
                textBox3.ScrollBars = ScrollBars.Both;
                height_box.ScrollBars = ScrollBars.Both;

                foreach (var square in squares)
                {
                    textBox1.AppendText(square.Coordinates.X.ToString() + Environment.NewLine);
                    textBox2.AppendText(square.Coordinates.Y.ToString() + Environment.NewLine);
                    textBox3.AppendText(square.CalculateArea().ToString() + Environment.NewLine);
                    height_box.AppendText(square.Height.ToString() + Environment.NewLine);
                }
            }
        }
    }
}
