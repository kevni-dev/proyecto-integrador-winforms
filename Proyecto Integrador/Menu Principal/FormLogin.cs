// FormLogin.cs  (REEMPLAZA este archivo COMPLETO)
// Registro NO persistente: se guarda en memoria mientras la app esté abierta.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class FormLogin : Form
    {
        private const string UsuarioDefecto = "Usuario";
        private const string ClaveDefecto = "hola123";

        private const string UsuarioExtra = "1";
        private const string ClaveExtra = "1";

        private readonly string _bgPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "fondoestablo11.png");
        private readonly string _logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "caballito.png");

        private Image? _bg;
        private Image? _logo;

        // ===== Registro en memoria (NO persistente) =====
        private static readonly Dictionary<string, string> _usuariosTemp =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        // ===== Drag ventana =====
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        public FormLogin()
        {
            InitializeComponent();

            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            UpdateStyles();

            // Centrado logo + títulos
            header_panel.SizeChanged += (_, __) =>
            {
                logo_picture.Left = (header_panel.ClientSize.Width - logo_picture.Width) / 2;

                titulo_label.Left = 0;
                titulo_label.Width = card_layout.ClientSize.Width;

                subtitulo_label.Left = 0;
                subtitulo_label.Width = card_layout.ClientSize.Width;
            };

            this.Shown += (_, __) =>
            {
                logo_picture.Left = (header_panel.ClientSize.Width - logo_picture.Width) / 2;
                PositionCloseButton();
            };

            Resize += (_, __) => PositionCloseButton();

            // Enter para iniciar
            usuario_textbox.KeyDown += EnterInicia;
            clave_textbox.KeyDown += EnterInicia;

            // Drag desde el fondo
            this.MouseDown += DragWindow;
            layout_center.MouseDown += DragWindow;

            // Drag desde arriba del card
            AttachDrag(header_panel);
            AttachDrag(logo_picture);
            AttachDrag(titulo_label);
            AttachDrag(subtitulo_label);

            // Cargar imágenes
            _bg = TryLoadFromResources("fondoestablo11") ?? TryLoadFromFile(_bgPath);
            _logo = TryLoadFromResources("caballito") ?? TryLoadFromFile(_logoPath);
            logo_picture.Image = _logo;
        }

        private void AttachDrag(Control c)
        {
            if (c is TextBox || c is Button || c is LinkLabel) return;

            c.MouseDown += DragWindow;

            foreach (Control child in c.Controls)
                AttachDrag(child);
        }

        private void DragWindow(object? sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        private void PositionCloseButton()
        {
            closeBtn.Location = new Point(ClientSize.Width - closeBtn.Width - 18, 14);
            closeBtn.BringToFront();
        }

        // ===== Fondo =====
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            if (_bg != null) DrawCoverImage(g, _bg, ClientRectangle);
            else g.Clear(Color.FromArgb(235, 235, 235));

            using (var overlay = new SolidBrush(Color.FromArgb(110, 245, 240, 235)))
                g.FillRectangle(overlay, ClientRectangle);

            using var vignette = CreateVignetteBrush(ClientRectangle);
            g.FillRectangle(vignette, ClientRectangle);
        }

        private static void DrawCoverImage(Graphics g, Image img, Rectangle bounds)
        {
            float imgW = img.Width;
            float imgH = img.Height;
            float boxW = bounds.Width;
            float boxH = bounds.Height;

            float scale = Math.Max(boxW / imgW, boxH / imgH);
            float w = imgW * scale;
            float h = imgH * scale;

            float x = bounds.X + (boxW - w) / 2f;
            float y = bounds.Y + (boxH - h) / 2f;

            g.DrawImage(img, x, y, w, h);
        }

        private static Brush CreateVignetteBrush(Rectangle r)
        {
            var path = new GraphicsPath();
            path.AddRectangle(r);

            return new PathGradientBrush(path)
            {
                CenterPoint = new PointF(r.Left + r.Width / 2f, r.Top + r.Height / 2f),
                CenterColor = Color.FromArgb(0, 0, 0, 0),
                SurroundColors = new[] { Color.FromArgb(45, 0, 0, 0) }
            };
        }

        private Image? TryLoadFromResources(string name)
        {
            try
            {
                var prop = typeof(Properties.Resources).GetProperty(name);
                return prop?.GetValue(null) as Image;
            }
            catch { return null; }
        }

        private static Image? TryLoadFromFile(string path)
        {
            try { return File.Exists(path) ? Image.FromFile(path) : null; }
            catch { return null; }
        }

        // ===== Login =====
        private void EnterInicia(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                inicio_button.PerformClick();
            }
        }

        private void inicio_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;

            string u = usuario_textbox.Text.Trim();
            string p = clave_textbox.Text;

            if (string.IsNullOrWhiteSpace(u) || string.IsNullOrWhiteSpace(p))
            {
                error_label.Text = "Completa usuario y contraseña";
                error_label.Visible = true;
                return;
            }

            bool ok =
                (u.Equals(UsuarioDefecto, StringComparison.OrdinalIgnoreCase) && p == ClaveDefecto) ||
                (u.Equals(UsuarioExtra, StringComparison.OrdinalIgnoreCase) && p == ClaveExtra) ||
                (_usuariosTemp.TryGetValue(u, out var pass) && pass == p);

            if (ok)
            {
                // Importante: NO cierres el login cuando se cierre el main,
                // porque "Cerrar sesión" debe volver aquí y NO cerrar la app.
                var main = new forMain(u, this);

                this.Hide();
                main.Show();
            }
            else
            {
                error_label.Text = "Usuario o contraseña incorrectos";
                error_label.Visible = true;
            }
        }

        // ===== Registro (popup simple, NO persistente) =====
        private void registrar_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var dlg = new FormRegistroTemp();
            dlg.StartPosition = FormStartPosition.CenterParent;

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                string u = dlg.Usuario.Trim();
                string p = dlg.Clave;

                if (_usuariosTemp.ContainsKey(u) ||
                    u.Equals(UsuarioDefecto, StringComparison.OrdinalIgnoreCase) ||
                    u.Equals(UsuarioExtra, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Ese usuario ya existe.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _usuariosTemp[u] = p;

                MessageBox.Show("Usuario creado. Ya puedes iniciar sesión.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                usuario_textbox.Text = u;
                clave_textbox.Text = "";
                clave_textbox.Focus();
            }
        }

        private void closeBtn_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
