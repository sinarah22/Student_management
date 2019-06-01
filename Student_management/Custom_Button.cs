using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Student_management
{
    [DefaultEvent("Click")]

    public partial class Custom_Button : UserControl
    {
        int wh = 20;float ang=45;

        Color cl10 = Color.Blue, cl11 = Color.Orange;

        Timer t = new Timer();

        public Custom_Button()
        {
            DoubleBuffered = true;
            t.Interval = 60;
            t.Start();

            t.Tick += (s, e) => { Angle = Angle  % 360 + 1; };
        }

        public float Angle
        {
            get { return ang; }
            set { ang = value; Invalidate(); }
        }

        public int BorderRadius
        {
            get { return wh; }
            set { wh = value; Invalidate(); }
        }

        public Color Color0
        {
            get { return cl10; }
            set { cl10 = value; Invalidate(); }
        }
        public Color Color1
        {
            get { return cl11; }
            set { cl11 = value; Invalidate(); }
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(new Rectangle(0, 0, wh, wh), 180, 90);
            gp.AddArc(new Rectangle(Width-wh, 0, wh, wh), -90, 90);
            gp.AddArc(new Rectangle(Width-wh, Height-wh, wh, wh), 0, 90);
            gp.AddArc(new Rectangle(0, Height-wh, wh, wh), 90, 90);


            e.Graphics.FillPath(new LinearGradientBrush(ClientRectangle,cl10,cl11,ang), gp);
            base.OnPaint(e);
        }
    }
}
