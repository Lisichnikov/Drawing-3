using System.Windows.Forms;

namespace Drawing2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[800];

            for (int x, y, i = 0; i < 800; i++)
            {
                float PI = (float)(Math.PI / (800 - 1));
                x = i - 400;
                y = (int)(float)(125 * Math.Sin(i * 10 * PI) + 250);
                point[i] = new Point(x + 400, y);
            }

            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
            Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[800];
            for (int x = -200, y, i = 0; x < 200; x++, i++)
            {
                y = -(x * x / 100) + 250;
                point[i] = new Point(x + 400, y);
            }
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
            Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[800];
            for (int x = -200, y, i = 0; x < 600; x++, i++)
            {
                if (x < 0)
                {
                    y = -(x * x / 100) + 250;
                    point[i] = new Point(x + 400, y);
                }
                else
                {
                    y = (x * x / 100) + 250;
                    point[i] = new Point(x + 400, y);
                }

            }
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
            Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 1f);
            Point[] point = new Point[800];
            graphics.DrawLines(pen, point);
            Point[] pointy = new Point[2] { new Point(400, 0), new Point(400, 800) };
            Point[] pointx = new Point[2] { new Point(0, 250), new Point(800, 250) };
            graphics.DrawLines(pen, pointy);
            graphics.DrawLines(pen, pointx);
        }
    }
}