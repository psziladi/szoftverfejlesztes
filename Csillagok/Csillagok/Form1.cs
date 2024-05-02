namespace Csillagok
{
    public partial class Form1 : Form
    {

        Hajos.hajosContext context = new Hajos.hajosContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stars = (from s in context.StarData 
                         select new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();

            Graphics g = this.CreateGraphics();

            g.Clear(Color.DarkBlue);

            Color c = Color.White;

            Pen pen = new Pen(c, 1);
            Brush brush = new SolidBrush(c);

            g.FillEllipse(brush, 10, 10, 10, 10);
            g.DrawLine(pen, 10, 10, 10, 10);

            float cx = ClientRectangle.Width / 2;
            float cy = ClientRectangle.Height / 2;
            double nagyítás = 200;


            foreach (var s in stars)
            {
                if (s.Magnitude > 6) continue;

                float x1 = (float)(nagyítás * s.X + cx);
                float y1 = (float)(nagyítás * s.Y + cy);

                double size = 20 * Math.Pow(10, (s.Magnitude) / -2.5);

                if (Math.Sqrt(Math.Pow(s.X, 2) + Math.Pow(s.Y, 2)) > 1) continue;
                              

                if (size < 1)
                {
                    size = 1;
                }

                g.FillEllipse(brush, (float)x1, (float)y1, (float)size, (float)size);
            }

            var lines = context.ConstellationLines.ToList();

            foreach (var line in lines)
            {
                var star1 = (from x in stars
                             where x.Hip == line.Star1
                             select x).FirstOrDefault();

                var star2 = (from y in stars
                             where y.Hip == line.Star2
                             select y).FirstOrDefault();

                if (star1 == null || star2 == null) continue;

                float x1 = (float)(nagyítás * star1.X + cx);
                float y1 = (float)(nagyítás * star1.Y + cy);

                float x2 = (float)(nagyítás * star2.X + cx);
                float y2 = (float)(nagyítás * star2.Y + cy);

                if (Math.Sqrt(Math.Pow(star1.X, 2) + Math.Pow(star1.Y, 2)) > 1) continue;

                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}