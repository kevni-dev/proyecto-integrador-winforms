// ShadowCardPanel.cs  (REEMPLAZA TODO este archivo)
// Arregla: sombra con esquina “sin redondear” + reduce negros raros recortando (Region)
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    [DesignerCategory("Code")]
    public class ShadowCardPanel : Panel
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int CardRadius { get; set; } = 18;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color CardFill { get; set; } = Color.FromArgb(235, 245, 242, 238);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color CardBorder { get; set; } = Color.FromArgb(35, 160, 150, 140);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ShadowSize { get; set; } = 28;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int ShadowAlpha { get; set; } = 16;

        public ShadowCardPanel()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint |
                     ControlStyles.SupportsTransparentBackColor, true);

            BackColor = Color.Transparent;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            // Recorta el “contenido” del card para que no salgan esquinas raras
            // (dejamos un margen para la sombra)
            int m = Math.Max(ShadowSize / 2, 10);
            var r = new Rectangle(0, 0, Width - 1 - m, Height - 1 - m);
            using var path = RoundedRect(r, CardRadius);
            Region = new Region(path);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Pintar el fondo del padre detrás (evita cuadros negros)
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

            // 1) Sombra (siempre dentro de bounds, para que no se “corte” una esquina)
            DrawSoftShadow(g);

            // 2) Tarjeta
            int m = Math.Max(ShadowSize / 2, 10);
            var cardRect = new Rectangle(0, 0, Width - 1 - m, Height - 1 - m);

            using (var path = RoundedRect(cardRect, CardRadius))
            using (var fill = new SolidBrush(CardFill))
            using (var pen = new Pen(CardBorder, 1f))
            {
                g.FillPath(fill, path);
                g.DrawPath(pen, path);
            }

            base.OnPaint(e);
        }

        private void DrawSoftShadow(Graphics g)
        {
            int offsetX = 10;
            int offsetY = 14;

            // Base del card (misma que el cardRect pero más pequeña para el blur)
            int m = Math.Max(ShadowSize / 2, 10);
            var cardRect = new Rectangle(0, 0, Width - 1 - m, Height - 1 - m);

            // Un poquito más adentro para que el blur no pegue a los bordes
            var baseRect = Rectangle.Inflate(cardRect, -6, -6);

            for (int i = ShadowSize; i >= 1; i--)
            {
                int a = (int)(ShadowAlpha * (i / (float)ShadowSize));
                a = Math.Clamp(a, 0, 255);

                var r = Rectangle.Inflate(baseRect, i, i);
                r.Offset(offsetX, offsetY);

                using var path = RoundedRect(r, CardRadius + i);
                using var b = new SolidBrush(Color.FromArgb(a, 55, 48, 40));
                g.FillPath(b, path);
            }
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
