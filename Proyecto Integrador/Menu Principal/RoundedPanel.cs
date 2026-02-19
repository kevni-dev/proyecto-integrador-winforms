// RoundedPanel.cs  (REEMPLAZA TODO este archivo)
// Arregla: esquinas negras en el panel interno (inputs)
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    [DesignerCategory("Code")]
    public class RoundedPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Radius { get; set; } = 14;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color Fill { get; set; } = Color.FromArgb(245, 240, 236);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color Border { get; set; } = Color.FromArgb(30, 170, 160, 150);

        public RoundedPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
        }

        protected override void OnSizeChanged(System.EventArgs e)
        {
            base.OnSizeChanged(e);

            // Recorta el control con borde redondeado (quita “esquinas negras”)
            var r = new Rectangle(0, 0, Width - 1, Height - 1);
            using var path = RoundedRect(r, Radius);
            Region = new Region(path);
        }

        // Pinta el fondo del padre detrás (evita negro en transparencia)
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Parent == null) return;

            var g = e.Graphics;
            var st = g.Save();

            g.TranslateTransform(-Left, -Top);
            var pe = new PaintEventArgs(g, Parent.ClientRectangle);
            InvokePaintBackground(Parent, pe);
            InvokePaint(Parent, pe);

            g.Restore(st);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            var r = new Rectangle(0, 0, Width - 1, Height - 1);

            using var path = RoundedRect(r, Radius);
            using var b = new SolidBrush(Fill);
            using var p = new Pen(Border, 1f);

            g.FillPath(b, path);
            g.DrawPath(p, path);

            base.OnPaint(e);
        }

        private static GraphicsPath RoundedRect(Rectangle r, int radius)
        {
            int d = radius * 2;
            var path = new GraphicsPath();

            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
