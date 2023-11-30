using System.Windows.Forms;

namespace _09_Graphics_GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }
        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;
            public ArrayPoints(int size)
            {
                if (size <= 0) { size = 2; }
                points = new Point[size];

            }
            public void SetPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }
                points[index] = new Point(x, y);
                index++;
            }
            public void ResetPoints()
            {
                index = 0;
            }

            public int GetCountPoints()
            {
                return index;
            }
            public Point[] GetPoints()
            {
                return points;
            }
        }
        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        Bitmap map = new Bitmap(100, 100);
        Graphics graphics;
        Pen pen = new Pen(Color.Black, 3f);
        ColorDialog colorDialog = new ColorDialog();
        Pen eraserPen = new Pen(Color.White, 10);
        private bool eraseMode = false;

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            eraserPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraserPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetPoints();
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse)
            {
                return;
            }

            arrayPoints.SetPoint(e.X, e.Y);

            if (arrayPoints.GetCountPoints() >= 2)
            {
                if (eraseMode)
                {
                    graphics.DrawLines(eraserPen, arrayPoints.GetPoints());
                }
                else
                {
                    graphics.DrawLines(pen, arrayPoints.GetPoints());
                }

                pictureBox.Image = map;
                arrayPoints.SetPoint(e.X, e.Y);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                pen.Color = button.BackColor;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog.Color;
                if (sender is Button button)
                {
                    button.BackColor = colorDialog.Color;
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(pictureBox.BackColor);
            pictureBox.Image = map;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label3.Text = trackBar.Value.ToString();
            pen.Width = trackBar.Value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JPG(.jpg)|*.jpg";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (pictureBox.Image != null)
                {
                    pictureBox.Image.Save(saveFileDialog.FileName);
                }
            }
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Width / pb.Width;
            float py = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }
        private void colorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(colorPicker, e.Location);
            pic_color.BackColor = ((Bitmap)colorPicker.Image).GetPixel(point.X, point.Y);
            pen.Color = pic_color.BackColor;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            eraseMode = !eraseMode;

            if (eraseMode)
            {
                toolStripButton3.BackColor = Color.LightGray;
            }
            else
            {
                toolStripButton3.BackColor = Color.Transparent;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            eraserPen.Width = trackBar1.Value;
        }
    }
}
