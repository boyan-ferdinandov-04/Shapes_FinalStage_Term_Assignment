using Shapes_StageOne.Shapes;
using Shapes_StageOne.Shapes.Enum;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using Rectangle = Shapes_StageOne.Shapes.Rectangle;

namespace Shapes_Paint
{
    public partial class Form1 : Form
    {
        private Bitmap bitmap;
        Bitmap addedImage;
        ButtonTypes type;
        private bool painted = false;
        Point pointerY;
        Pen p = new Pen(Color.Black, 5);
        Triangle triangle;
        Square square;
        private Rectangle rectangle;
        private Color newColor;
        private List<Shape> shapes = new();
        Circle circle;
        private Stack<List<Shape>> undoHistory = new Stack<List<Shape>>();

        public Form1()
        {
            InitializeComponent();
            Width = 1920;
            Height = 1080;
            bitmap = new Bitmap(background.Width, background.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            background.Image = bitmap;
        }

        private void background_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            Shape shape = null;
            switch (type)
            {
                case ButtonTypes.Triangle:
                    if (triangle != null)
                    {
                        triangle.BorderColor = p.Color;
                        shape = triangle;
                    }
                    break;

                case ButtonTypes.Square:
                    if (square != null)
                    {
                        square.BorderColor = p.Color;
                        square.FilledColor = Color.Transparent;
                        shape = square;
                    }
                    break;

                case ButtonTypes.Rectangle:
                    if (rectangle != null)
                    {
                        rectangle.BorderColor = p.Color;
                        rectangle.FilledColor = Color.Transparent;
                        shape = rectangle;
                    }
                    break;

                case ButtonTypes.Ellipse:
                    if (circle != null)
                    {
                        circle.BorderColor = p.Color;
                        circle.FilledColor = Color.Transparent;
                        shape = circle;
                    }
                    break;
            }
            if (shape != null)
            {
                shapes.Add(shape);
                RedrawShapes();
            }
        }
        private void background_MouseDown(object sender, MouseEventArgs e)
        {
            painted = true;
            pointerY = e.Location;

            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            
            switch (type)
            {
                case ButtonTypes.Triangle:
                    triangle = new Triangle();
                    break;
                case ButtonTypes.Square:
                    square = new Square();
                    square.Coordinates = e.Location;
                    square.Height = 0;
                    break;

                case ButtonTypes.Rectangle:
                    rectangle = new Rectangle();
                    rectangle.Coordinates = e.Location;
                    rectangle.Width = 0;
                    rectangle.Height = 0;
                    break;

                case ButtonTypes.Ellipse:
                    circle = new Circle();
                    circle.Coordinates = e.Location;
                    circle.Width = 0;
                    circle.Height = 0;
                    break;
            }
        }


        private void background_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left || !painted)
            {
            }
            else
            {
                if (type != ButtonTypes.Triangle)
                {
                   
                    switch(type)
                    {
                        case ButtonTypes.Square:
                            square.Height = e.Location.X - square.Coordinates.X;
                            background.Refresh();
                        break;

                        case ButtonTypes.Rectangle:
                            rectangle.Width = e.Location.X - rectangle.Coordinates.X;
                            rectangle.Height = e.Location.Y - rectangle.Coordinates.Y;
                            background.Refresh(); 
                        break;

                        case ButtonTypes.Ellipse:
                           if(circle != null)
                           {
                                circle.Width = Math.Abs(e.Location.X - circle.Coordinates.X);
                                circle.Height = Math.Abs(e.Location.Y - circle.Coordinates.Y);
                                background.Refresh();
                           }
                        break;
                    }
                }
                else
                {
                    if (triangle != null)
                    {
                        float center = (pointerY.X + e.Location.X) / 2;
                        triangle.Coordinates = new Point
                        {
                            X = Math.Min(pointerY.X, e.Location.X),
                            Y = Math.Min(pointerY.Y, e.Location.Y)
                        };

                        Point pointA = new Point(pointerY.X, pointerY.Y);
                        Point pointB = new Point((int)center, e.Location.Y);
                        Point pointC = new Point(e.Location.X, pointerY.Y);

                        triangle.PointA = pointA;
                        triangle.PointB = pointB;
                        triangle.PointC = pointC;
                        triangle.Side = Math.Abs(pointerY.X - e.Location.X);
                    }
                    background.Refresh();
                }

            }
            background.Refresh();
        }


        private void clear_button_Click(object sender, EventArgs e)
        {
            for (int i = shapes.Count - 1; i >= 0; i--)
            {
                shapes.RemoveAt(i);
            }
            bitmap = new Bitmap(background.Width, background.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(background.BackColor);
            background.Image = bitmap;
            background.Refresh();
        }

        private void triangle_button_Click(object sender, EventArgs e)
        {
            type = ButtonTypes.Triangle;
        }
 
        private void square_button_Click(object sender, EventArgs e)
        {
            type = ButtonTypes.Square;
        }

        private void rectangle_button_Click(object sender, EventArgs e)
        {
            type = ButtonTypes.Rectangle;
        }

        private void circle_button_Click(object sender, EventArgs e)
        {
            type = ButtonTypes.Ellipse;
        }
 
        private void save_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG|*.png|JPEG|*.jpg";
            saveFileDialog.Title = "Save";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                string extension = Path.GetExtension(saveFileDialog.FileName);
                ImageFormat imageFormat = extension.ToLower() == ".jpg" ? ImageFormat.Jpeg : ImageFormat.Png;
                bitmap.Save(saveFileDialog.FileName, imageFormat);
            }
        }

        private void open_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images|*.png;*.jpg";
            openFileDialog.ShowDialog();
            if (openFileDialog.FileName != "")
            {
                addedImage = new Bitmap(openFileDialog.FileName);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.DrawImage(addedImage, Point.Empty);
                }
                background.Refresh();
            }
        }

        private void colorPicker_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.ShowDialog();
            newColor = cd.Color;
            currentColor.BackColor = cd.Color;
            p.Color = cd.Color;
        }
        private void BorderColorChange(Color newColor)
        {
            foreach (var shape in shapes)
            {
                if (shape.IsSelected)
                {
                    shape.BorderColor = newColor;
                }
            }
            background.Refresh();
        }

        private void undo_button_click(object sender, EventArgs e)
        {
            if (shapes.Count > 0)
            {
                undoHistory.Push(new List<Shape>(shapes));
                shapes.RemoveAt(shapes.Count - 1);
                RedrawShapes();
                background.Refresh();
            }
        }

        private void redo_button_Click(object sender, EventArgs e)
        {
            if (undoHistory.Count > 0)
            {
                shapes = undoHistory.Pop();
                RedrawShapes();
                background.Refresh();
            }
        }

        private void RedrawShapes()
        {
            bitmap = new Bitmap(background.Width, background.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                foreach (var shape in shapes)
                {
                    shape.Draw(g);
                }
            }
            background.Image = bitmap;
            background.Refresh();
        }


        private void background_color_Click(object sender, EventArgs e)
        {
            var backgroundColor = new ColorDialog();

            if (backgroundColor.ShowDialog() == DialogResult.OK)
            {
                using (Graphics g = Graphics.FromImage((Bitmap)background.Image))
                {
                    background.BackColor = backgroundColor.Color;
                    background_color.BackColor = backgroundColor.Color;
                    g.Clear(backgroundColor.Color);
                }
            }

        }

        static Point SetPoint(PictureBox pb, Point pt)
        {
            float pX = 1.1f * pb.Width / pb.Width;
            float pY = 1.1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = SetPoint(color_picker, e.Location);
            currentColor.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            newColor = currentColor.BackColor;
            p.Color = currentColor.BackColor;
        }

        private void background_OnPaint(object sender, PaintEventArgs e)
        {
            foreach (var shape in shapes)
            {
               shape.Draw(e.Graphics);
            }
        }

        private void fill_button_Click(object sender, EventArgs e)
        {
            BorderColorChange(newColor);
        }

        private void square_area_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            List<Square> selectedSquares = new List<Square>();

            foreach (var shape in shapes)
            {
                if (shape is Square)
                {
                    selectedSquares.Add((Square)shape);
                }
            }

            form2.Squares = selectedSquares;
            form2.ShowDialog();
        }

        private void rectangle_info_Click(object sender, EventArgs e)
        {
            List<Rectangle> rects = new();

            foreach (var shape in shapes)
            {
                if (shape is Rectangle)
                {
                    rects.Add((Rectangle)shape);
                }
            }
            RectangleForm rectangleForm = new RectangleForm();
            rectangleForm.Rectangles = rects;
            rectangleForm.ShowDialog();
        }

        private void triangle_area_Click(object sender, EventArgs e)
        {
            List<Triangle> triangles = new();
            foreach (var shape in shapes)
            {
                if (shape is Triangle)
                {
                    triangles.Add((Triangle)shape);
                }
            }
            TriangleForm triangleForm = new();
            triangleForm.Triangles = triangles;
            triangleForm.ShowDialog();
        }

        private void circle_area_Click(object sender, EventArgs e)
        {
            List<Circle> circles = new();
            foreach (var shape in shapes)
            {
                if (shape is Circle)
                {
                    circles.Add((Circle)shape);
                }

            }
            CircleForm circleForm = new();
            circleForm.Circles = circles;
            circleForm.ShowDialog();
        }

        private void save_serialize_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Brush(*.brush) | *.brush | (*.*|*.*";

                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    #pragma warning disable SYSLIB0011
                    BinaryFormatter formatterFile = new BinaryFormatter();
                    using (var fileStream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        formatterFile.Serialize(fileStream, shapes);
                        formatterFile.Serialize(fileStream, BackColor);
                    }
                    #pragma warning restore SYSLIB0011
                }
            }
        }

        private void open_serialize_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    #pragma warning disable SYSLIB0011
                    BinaryFormatter formatter = new BinaryFormatter();

                    using (var fileStream = new FileStream(ofd.FileName, FileMode.Open))
                    {
                        shapes = (List<Shape>)formatter.Deserialize(fileStream);
                        this.BackColor = (Color)formatter.Deserialize(fileStream);
                        background_color.BackColor = this.BackColor;
                    }
                    #pragma warning restore SYSLIB0011
                }
            }
        }

        private void background_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                bool selectedChanged = false;
                foreach (var shape in shapes)
                {
                    if (shape.PointInFigure(e.Location))
                    {
                        if (!shape.IsSelected)
                        {
                            shape.IsSelected = true;
                            selectedChanged = true;
                        }
                    }
                    else if (shape.IsSelected)
                    {
                        shape.IsSelected = false;
                        selectedChanged = true;
                    }
                }
                if (selectedChanged)
                {
                    background.Refresh();
                }
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var selectedShape = shapes
                    .FirstOrDefault(shape => shape.IsSelected);
                if (selectedShape != null)
                {
                    shapes.Remove(selectedShape);
                    background.Refresh();
                }
            }
        }

        private void xml_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "XML files (*.xml)|*.xml";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>));

                    using (var fileStream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        serializer.Serialize(fileStream, shapes);
                    }
                }
            }
        }

        private void xml_open_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "XML files (*.xml)|*.xml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Shape>));
                    using FileStream fileStream = new FileStream(ofd.FileName, FileMode.Open);
                    IEnumerable<Shape> loadedShapes = serializer.Deserialize(fileStream) as List<Shape>;
                    shapes.Clear();
                    shapes.AddRange(loadedShapes ?? Array.Empty<Shape>());
                    RedrawShapes();
                    background.Refresh();

                }
            }
        }

        private void FillShape(Color fillColor)
        {
            bool toRedraw = false;
            foreach (var shape in shapes)
            {
                if (shape.IsSelected && shape.FilledColor != fillColor)
                {
                    shape.FilledColor = fillColor;
                    toRedraw = true;
                }
            }

            if (toRedraw)
            {
                RedrawShapes();
                background.Refresh();
                background.BackColor = background.BackColor;
            }
        }

        private void fill_color_button_Click(object sender, EventArgs e)
        {
            FillShape(newColor);
        }
    }
}
