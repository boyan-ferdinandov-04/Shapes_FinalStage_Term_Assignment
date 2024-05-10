using Shapes_StageOne.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Shapes_StageOne.Shapes.Rectangle;

namespace Shapes_Paint
{
    public partial class RectangleForm : Form
    {
        private List<Rectangle> rects;  
        
        public RectangleForm()
        {
            InitializeComponent();
        }

        public List<Rectangle> Rectangles
        {
            get => rects;

            set
            {
                rects = value;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                height_box.Clear();
                width_box.Clear();

                textBox1.Multiline = true;
                textBox2.Multiline = true;
                textBox3.Multiline = true;
                height_box.Multiline = true;
                width_box.Multiline = true;

                textBox1.ScrollBars = ScrollBars.Both;
                textBox2.ScrollBars = ScrollBars.Both;
                textBox3.ScrollBars = ScrollBars.Both;
                height_box.ScrollBars = ScrollBars.Both;
                width_box.ScrollBars = ScrollBars.Both;


                foreach (var rect in rects)
                {
                    textBox1.AppendText(rect.Coordinates.X.ToString() + Environment.NewLine);
                    textBox2.AppendText(rect.Coordinates.Y.ToString() + Environment.NewLine);
                    textBox3.AppendText(rect.CalculateArea().ToString() + Environment.NewLine);
                    height_box.AppendText(rect.Height.ToString() + Environment.NewLine);
                    width_box.AppendText(rect.Width.ToString() + Environment.NewLine);
                }

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
