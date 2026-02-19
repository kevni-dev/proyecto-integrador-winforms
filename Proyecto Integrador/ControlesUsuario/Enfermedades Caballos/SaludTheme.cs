using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    internal static class SaludTheme
    {
        // Paleta (misma vibra del módulo principal)
        public static readonly Color Canvas = Color.FromArgb(245, 239, 230);
        public static readonly Color Card = Color.FromArgb(242, 236, 226);
        public static readonly Color Border = Color.FromArgb(155, 140, 120);

        public static readonly Color Text = Color.FromArgb(60, 40, 25);
        public static readonly Color MutedText = Color.FromArgb(95, 82, 66);

        public static readonly Color HeaderBack = Color.FromArgb(232, 221, 208);
        public static readonly Color RowAlt = Color.FromArgb(248, 244, 238);
        public static readonly Color Selected = Color.FromArgb(120, 116, 105);
        public static readonly Color SelectedText = Color.FromArgb(245, 239, 230);

        // Nombres de recursos (si existen en Properties.Resources)
        public const string ResBtnVerde = "btn_verde";
        public const string ResBtnRojo = "btn_rojo";
        public const string ResBtnAmarillo = "btn_amarillo";
        public const string ResBtnAzul = "btn_azul";

        public static void ApplyRoot(UserControl uc)
        {
            if (uc == null) return;

            uc.BackColor = Color.Transparent; // para que se vea el fondo del establo
            uc.Font = new Font("Segoe UI", 10F);

            // Anti-parpadeo (sin usar APIs protected)
            EnableDoubleBuffer(uc);
        }

        public static void MakeCard(Panel p, Padding? padding = null)
        {
            if (p == null) return;

            p.BackColor = Card;
            p.Padding = padding ?? new Padding(16);

            p.Paint -= PanelCardPaint;
            p.Paint += PanelCardPaint;

            EnableDoubleBuffer(p);
        }

        public static void StyleTitle(Label lbl)
        {
            if (lbl == null) return;

            lbl.ForeColor = Text;
            lbl.Font = new Font("Georgia", 16F, FontStyle.Bold);
        }

        public static void StyleLabel(Label lbl)
        {
            if (lbl == null) return;

            lbl.ForeColor = MutedText;
            lbl.Font = new Font("Georgia", 12F, FontStyle.Bold);
        }

        public static void StyleInput(Control c)
        {
            if (c == null) return;

            c.Font = new Font("Segoe UI", 10F);
            c.ForeColor = Text;

            if (c is TextBox tb)
            {
                tb.BorderStyle = BorderStyle.FixedSingle;
                tb.BackColor = Color.White;
            }
            else if (c is ComboBox cb)
            {
                cb.FlatStyle = FlatStyle.Flat;
                cb.BackColor = Color.White;
            }
            else if (c is RichTextBox rtb)
            {
                rtb.BorderStyle = BorderStyle.FixedSingle;
                rtb.BackColor = Color.White;
            }
        }

        public static void StylePrimaryButton(Button b, string? resourceKey = null)
        {
            if (b == null) return;

            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Cursor = Cursors.Hand;
            b.ForeColor = Color.White;
            b.Font = new Font("Georgia", 11F, FontStyle.Bold);

            // si hay imagen, la usa; si no, queda flat
            var img = GetImage(resourceKey ?? ResBtnVerde);
            if (img != null)
            {
                b.BackgroundImage = img;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.BackColor = Color.Transparent;
            }
            else
            {
                b.BackColor = Color.FromArgb(96, 109, 84); // oliva
            }
        }

        public static void StyleDangerButton(Button b, string? resourceKey = null)
        {
            if (b == null) return;

            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Cursor = Cursors.Hand;
            b.ForeColor = Color.White;
            b.Font = new Font("Georgia", 11F, FontStyle.Bold);

            var img = GetImage(resourceKey ?? ResBtnRojo);
            if (img != null)
            {
                b.BackgroundImage = img;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.BackColor = Color.Transparent;
            }
            else
            {
                b.BackColor = Color.FromArgb(140, 65, 50); // terracota
            }
        }

        public static void StyleWarningButton(Button b, string? resourceKey = null)
        {
            if (b == null) return;

            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Cursor = Cursors.Hand;
            b.ForeColor = Color.FromArgb(60, 40, 25);
            b.Font = new Font("Georgia", 11F, FontStyle.Bold);

            var img = GetImage(resourceKey ?? ResBtnAmarillo);
            if (img != null)
            {
                b.BackgroundImage = img;
                b.BackgroundImageLayout = ImageLayout.Stretch;
                b.BackColor = Color.Transparent;
            }
            else
            {
                b.BackColor = Color.FromArgb(190, 160, 90); // dorado
            }
        }

        public static void StyleGrid(DataGridView gv)
        {
            if (gv == null) return;

            EnableDoubleBuffer(gv);

            gv.BorderStyle = BorderStyle.FixedSingle;
            gv.BackgroundColor = Color.White;
            gv.GridColor = Border;

            gv.EnableHeadersVisualStyles = false;
            gv.ColumnHeadersDefaultCellStyle.BackColor = HeaderBack;
            gv.ColumnHeadersDefaultCellStyle.ForeColor = Text;
            gv.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 12F, FontStyle.Bold);
            gv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            gv.ColumnHeadersHeight = 34;

            gv.DefaultCellStyle.BackColor = Color.White;
            gv.DefaultCellStyle.ForeColor = Text;
            gv.DefaultCellStyle.Font = new Font("Segoe UI", 11.5F);
            gv.DefaultCellStyle.SelectionBackColor = Selected;
            gv.DefaultCellStyle.SelectionForeColor = SelectedText;
            gv.DefaultCellStyle.Padding = new Padding(6, 3, 6, 3);

            gv.AlternatingRowsDefaultCellStyle.BackColor = RowAlt;

            gv.RowTemplate.Height = 34;
            gv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        public static Image? GetImage(string? resourceKey)
        {
            if (string.IsNullOrWhiteSpace(resourceKey))
                return null;

            try
            {
                var obj = Properties.Resources.ResourceManager.GetObject(resourceKey);
                return obj as Image;
            }
            catch
            {
                return null;
            }
        }

        public static void EnableDoubleBuffer(Control c)
        {
            try
            {
                typeof(Control)
                    .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.SetValue(c, true, null);
            }
            catch { }
        }

        private static void PanelCardPaint(object? sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using var pen = new Pen(Border, 1f);
            var r = p.ClientRectangle;
            r.Width -= 1;
            r.Height -= 1;
            e.Graphics.DrawRectangle(pen, r);
        }
    }
}
