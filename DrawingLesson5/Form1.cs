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
    }
}