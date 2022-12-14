using System.Drawing;
using System.Drawing.Drawing2D;

namespace DrawingLesson5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Pen pn = new Pen(Brushes.Blue, 5);
            pn.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            graphics.DrawEllipse(pn, 50, 100, 170, 40);
            
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(100, 100));
            LinearGradientBrush lgBrush = new LinearGradientBrush(rect, Color.Red, Color.Green, 0.0f, true);
            graphics.FillRectangle(lgBrush, rect);
            Rectangle rect2 = new Rectangle(300,300,300,500);
            HatchBrush htchBrush = new HatchBrush(HatchStyle.Cross, Color.Blue);
            graphics.FillRectangle(htchBrush, rect2);
            TextureBrush txBrush = new TextureBrush(new Bitmap("texture.bmp"));
            Rectangle rect3 = new Rectangle(300, 50, 200, 300);
            graphics.FillRectangle(txBrush, rect3);
            Font f = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);
            graphics.DrawString("Hello Font!", f, Brushes.Blue, 30, 55);
            Rectangle rect4 = this.ClientRectangle;
            Image im = new Bitmap("orig.jpg");
            graphics.DrawImage(im, rect4);
            pictureBox1.Image = new Bitmap("orig.jpg");
            Point[] points = {
                     new Point(5, 10),
                     new Point(23, 130),
                     new Point(130, 57)
            };
            GraphicsPath path = new GraphicsPath();
            // рисуем первую траекторию path.StartFigure();
            path.AddEllipse(170, 170, 100, 50);
            // заливаем траекторию цветом
            graphics.FillPath(Brushes.Aqua, path);
            // рисуем вторую траекторию
            path.StartFigure();
            path.AddCurve(points, 0.5F);
            path.AddArc(100, 50, 100, 100, 0, 120);

            path.AddLine(50, 150, 50, 220);
            // Закрываем траекторию
            path.AddArc(180, 30, 60, 60, 0, -170);
            path.CloseFigure();
            graphics.DrawPath(new Pen(Color.Blue, 3), path);
            graphics.Dispose();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 400), new Point(400, 500));
            g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 420), new Point(360, 460));
            g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 420), new Point(440, 460));
            g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 500), new Point(360, 540));
            g.DrawLine(new Pen(Brushes.Red, 5), new Point(400, 500), new Point(440, 540));
            g.DrawEllipse(new Pen(Brushes.Blue, 5), 375,350,50,50);
            g.DrawLine(new Pen(Brushes.Red, 5), new Point(440, 430), new Point(440, 490));
            g.DrawEllipse(new Pen(Brushes.Blue, 5), 430, 410, 20, 20);
            g.DrawEllipse(new Pen(Brushes.Blue, 2), 426, 403, 8, 8);
            g.DrawEllipse(new Pen(Brushes.Blue, 2), 437, 400, 8, 8);
            g.DrawEllipse(new Pen(Brushes.Blue, 2), 423, 410, 8, 8);
            g.DrawEllipse(new Pen(Brushes.Blue, 2), 448, 410, 8, 8);
            g.DrawEllipse(new Pen(Brushes.Blue, 2), 444, 403, 8, 8);
            g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(320,310,40,40), 0, 180);
            g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(280, 300, 40, 40), 30, 180);
            g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(280, 280, 40, 40), 144, 180);
            g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(310, 280, 40, 40), 216, 135);
            g.DrawArc(new Pen(Brushes.Blue, 2), new Rectangle(330, 295, 40, 40), 270, 150);
            g.Dispose();
        }
    }
}