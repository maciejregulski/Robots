using System.Drawing;
using System.Windows.Forms;

namespace RobotsUI
{
    public partial class RobotIcon : Control
    {
        public RobotIcon()
        {
            InitializeComponent();
            this.Size = new Size(27, 27);
            this.DoubleBuffered = true;
        }

        private void Draw(Graphics g)
        {
            using (var pen = new Pen(this.ForeColor, 1.5f))
            using (var brush = new SolidBrush(this.ForeColor))
            {
                int w = this.Width - 1;
                int h = this.Height - 1;

                var shapeDown = new Point[]
                {
                    new Point(0, 0),
                    new Point(w / 2, h),
                    new Point(w, 0),
                };

                var shapeUp = new Point[]
                {
                    new Point(0, h),
                    new Point(w, h),
                    new Point(w / 2, 0),
                };
                
                g.FillPolygon(brush, shapeUp);
                //g.DrawPolygon(pen, shapeDown);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e.Graphics);
            base.OnPaint(e);
        }
    }
}
