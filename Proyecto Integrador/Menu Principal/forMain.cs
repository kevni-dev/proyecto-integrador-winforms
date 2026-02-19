// forMain.cs (REEMPLAZA este archivo COMPLETO)
// - Cerrar sesión vuelve al MISMO FormLogin (no crea uno nuevo)
// - Fix ObjectDisposedException en sidebar (Paint/Invalidate protegidos)
// - Botón "Cerrar sesión" un poco más a la izquierda + anclado a la derecha
using Proyecto_Integrador.ControlesUsuario;
using Proyecto_Integrador.ControlesUsuario.cuModulo4;
using Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento;
using Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class forMain : Form
    {
        private string _t1, _t2, _t3, _t4;

        private int menuAbierto = 220;
        private int menuCerrado = 80;
        private bool menuAfuera = true;

        private readonly string _usuarioActual;

        // referencia al login real (el que se ocultó)
        private readonly FormLogin _loginRef;

        // ===== Tema =====
        private readonly Color _txtClaro = Color.FromArgb(238, 226, 205);

        private readonly Color _hoverOscuro = Color.FromArgb(55, 0, 0, 0);
        private readonly Color _downOscuro = Color.FromArgb(90, 0, 0, 0);

        private readonly Color _hoverOverlay = Color.FromArgb(45, 0, 0, 0);
        private readonly Color _downOverlay = Color.FromArgb(85, 0, 0, 0);

        private readonly Color _activoDorado = Color.FromArgb(70, 200, 165, 90);
        private readonly Color _bordeDorado = Color.FromArgb(200, 190, 150, 80);

        private Button? _btnActivo;

        // ===== Texturas (solo botones “normales”, NO sidebar) =====
        private readonly Dictionary<Button, int> _btnVisualState = new(); // 0 normal, 1 hover, 2 down

        // evita crash al cerrar
        private bool _cerrandoSesion = false;

        // (tu proyecto también puede tener el constructor viejo; lo dejamos por compatibilidad)
        public forMain(string usuarioActual) : this(usuarioActual, new FormLogin()) { }

        public forMain(string usuarioActual, FormLogin loginRef)
        {
            InitializeComponent();

            _loginRef = loginRef;
            _usuarioActual = string.IsNullOrWhiteSpace(usuarioActual) ? "Usuario" : usuarioActual;

            _t1 = btnModulo1.Text;
            _t2 = btnModulo2.Text;
            _t3 = btnModulo3.Text;
            _t4 = btnModulo4.Text;

            // ===== ICONOS =====
            btnModulo1.Image = Properties.Resources.Icon_Registro;
            btnModulo2.Image = Properties.Resources.Icon_Alimentacion;
            btnModulo3.Image = Properties.Resources.Icon_Salud;
            btnModulo4.Image = Properties.Resources.Icon_Mental;

            btnModulo1.Image = new Bitmap(btnModulo1.Image, new Size(32, 32));
            btnModulo2.Image = new Bitmap(btnModulo2.Image, new Size(32, 32));
            btnModulo3.Image = new Bitmap(btnModulo3.Image, new Size(32, 32));
            btnModulo4.Image = new Bitmap(btnModulo4.Image, new Size(32, 32));

            // ===== Estilo =====
            AplicarEstiloBarraSuperior();
            AplicarEstiloSidebar();

            // Activo inicial
            MarcarActivo(btnModulo1);
            ActualizarMenuVisual();

            // ===== INICIO: cargar Turismo automáticamente =====
            CargarUserControl(new cuModulo1());
        }

        private void forMain_Load(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            usuario_label.Text = _usuarioActual;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _cerrandoSesion = true;
            base.OnFormClosing(e);
        }

        // =========================================================
        //  Helpers: botón con textura + hover/down (overlay)
        // =========================================================
        private void AplicarTexturaBoton(Button b, Image textura, Color colorTexto)
        {
            b.UseVisualStyleBackColor = false;
            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;

            b.BackgroundImage = textura;
            b.BackgroundImageLayout = ImageLayout.Stretch;

            b.ForeColor = colorTexto;

            _btnVisualState[b] = 0;

            b.Paint -= BotonTextura_Paint;
            b.Paint += BotonTextura_Paint;

            b.MouseEnter -= BotonTextura_MouseEnter;
            b.MouseLeave -= BotonTextura_MouseLeave;
            b.MouseDown -= BotonTextura_MouseDown;
            b.MouseUp -= BotonTextura_MouseUp;

            b.MouseEnter += BotonTextura_MouseEnter;
            b.MouseLeave += BotonTextura_MouseLeave;
            b.MouseDown += BotonTextura_MouseDown;
            b.MouseUp += BotonTextura_MouseUp;

            if (!b.IsDisposed && !b.Disposing && b.IsHandleCreated) b.Invalidate();
        }

        private void BotonTextura_MouseEnter(object? sender, System.EventArgs e)
        {
            if (_cerrandoSesion) return;

            if (sender is Button b)
            {
                if (b.IsDisposed || b.Disposing || !b.IsHandleCreated) return;
                _btnVisualState[b] = 1;
                b.Invalidate();
            }
        }

        private void BotonTextura_MouseLeave(object? sender, System.EventArgs e)
        {
            if (_cerrandoSesion) return;

            if (sender is Button b)
            {
                if (b.IsDisposed || b.Disposing || !b.IsHandleCreated) return;
                _btnVisualState[b] = 0;
                b.Invalidate();
            }
        }

        private void BotonTextura_MouseDown(object? sender, MouseEventArgs e)
        {
            if (_cerrandoSesion) return;

            if (sender is Button b && e.Button == MouseButtons.Left)
            {
                if (b.IsDisposed || b.Disposing || !b.IsHandleCreated) return;
                _btnVisualState[b] = 2;
                b.Invalidate();
            }
        }

        private void BotonTextura_MouseUp(object? sender, MouseEventArgs e)
        {
            if (_cerrandoSesion) return;

            if (sender is Button b)
            {
                if (b.IsDisposed || b.Disposing || !b.IsHandleCreated) return;

                _btnVisualState[b] = b.ClientRectangle.Contains(b.PointToClient(Cursor.Position)) ? 1 : 0;
                b.Invalidate();
            }
        }

        private void BotonTextura_Paint(object? sender, PaintEventArgs e)
        {
            if (_cerrandoSesion) return;

            if (sender is not Button b) return;
            if (b.IsDisposed || b.Disposing || !b.IsHandleCreated) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            if (_btnVisualState.TryGetValue(b, out int st))
            {
                if (st == 1)
                {
                    using var br = new SolidBrush(_hoverOverlay);
                    e.Graphics.FillRectangle(br, b.ClientRectangle);
                }
                else if (st == 2)
                {
                    using var br = new SolidBrush(_downOverlay);
                    e.Graphics.FillRectangle(br, b.ClientRectangle);
                }
            }
        }

        // =========================================================
        //  Barra superior
        // =========================================================
        private void AplicarEstiloBarraSuperior()
        {
            plTitulo.BackColor = Color.Transparent;

            lblTituloPrincipal.Font = new Font("Georgia", 14F, FontStyle.Bold);
            lblTituloPrincipal.ForeColor = _txtClaro;
            lblTituloPrincipal.BackColor = Color.Transparent;

            userPanel.BackColor = Color.Transparent;

            usuario_label.Font = new Font("Georgia", 10F, FontStyle.Bold);
            usuario_label.ForeColor = _txtClaro;
            usuario_label.BackColor = Color.Transparent;

            usuario_picture.BackColor = Color.Transparent;

            // Menú (AZUL)
            btnIconoMenu.Text = "☰";
            btnIconoMenu.Font = new Font("Georgia", 16F, FontStyle.Bold);
            AplicarTexturaBoton(btnIconoMenu, Properties.Resources.btn_azul, _txtClaro);

            // Cerrar sesión (ROJO)
            cerrarSesion_button.Text = "Cerrar sesión";
            cerrarSesion_button.Font = new Font("Georgia", 10F, FontStyle.Bold);
            AplicarTexturaBoton(cerrarSesion_button, Properties.Resources.btn_rojo, _txtClaro);

            // posicionarlo "un poco más a la izquierda" pero siempre pegado a la derecha
            cerrarSesion_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userPanel.SizeChanged += (_, __) => PosicionarCerrarSesion();
            PosicionarCerrarSesion();
        }

        private void PosicionarCerrarSesion()
        {
            if (_cerrandoSesion) return;
            if (cerrarSesion_button.IsDisposed || cerrarSesion_button.Disposing) return;

            int margenDerecho = 22; // sube/baja este número si quieres más a la izquierda/derecha
            int x = userPanel.ClientSize.Width - cerrarSesion_button.Width - margenDerecho;

            // evita que se pegue demasiado si el panel se hace muy pequeño
            if (x < 8) x = 8;

            cerrarSesion_button.Location = new Point(x, cerrarSesion_button.Location.Y);
        }

        // =========================================================
        //  Sidebar (SIN TEXTURA)
        // =========================================================
        private void AplicarEstiloSidebar()
        {
            Button[] botones = { btnModulo1, btnModulo2, btnModulo3, btnModulo4 };

            plModulos.Width = menuAbierto;

            foreach (var b in botones)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.UseVisualStyleBackColor = false;

                b.BackColor = Color.FromArgb(30, 0, 0, 0);

                b.FlatAppearance.MouseOverBackColor = _hoverOscuro;
                b.FlatAppearance.MouseDownBackColor = _downOscuro;

                b.Height = 52;

                b.Font = new Font("Georgia", 10F, FontStyle.Bold);
                b.ForeColor = _txtClaro;

                b.TextAlign = ContentAlignment.MiddleLeft;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Padding = new Padding(14, 0, 0, 0);

                b.Paint -= BotonSidebar_Paint;
                b.Paint += BotonSidebar_Paint;

                b.MouseEnter -= BotonSidebar_Refresh;
                b.MouseLeave -= BotonSidebar_Refresh;
                b.MouseEnter += BotonSidebar_Refresh;
                b.MouseLeave += BotonSidebar_Refresh;
            }
        }

        private void BotonSidebar_Refresh(object? sender, System.EventArgs e)
        {
            if (_cerrandoSesion) return;

            if (sender is Control c)
            {
                if (c.IsDisposed || c.Disposing || !c.IsHandleCreated) return;
                c.Invalidate();
            }
        }

        private void BotonSidebar_Paint(object? sender, PaintEventArgs e)
        {
            if (_cerrandoSesion) return;

            if (sender is not Button b) return;
            if (b.IsDisposed || b.Disposing || !b.IsHandleCreated) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            bool esActivo = ReferenceEquals(b, _btnActivo);

            if (esActivo)
            {
                using var br = new SolidBrush(_activoDorado);
                e.Graphics.FillRectangle(br, new Rectangle(0, 0, b.Width, b.Height));

                using var pen = new Pen(_bordeDorado, 4);
                e.Graphics.DrawLine(pen, 2, 6, 2, b.Height - 6);
            }

            using var penSep = new Pen(Color.FromArgb(70, 0, 0, 0), 1);
            e.Graphics.DrawLine(penSep, 12, b.Height - 1, b.Width - 12, b.Height - 1);
        }

        // =========================================================
        //  Menú abierto/cerrado
        // =========================================================
        private void ActualizarMenuVisual()
        {
            Button[] botones = { btnModulo1, btnModulo2, btnModulo3, btnModulo4 };

            if (menuAfuera)
            {
                btnModulo1.Text = _t1;
                btnModulo2.Text = _t2;
                btnModulo3.Text = _t3;
                btnModulo4.Text = _t4;

                foreach (var b in botones)
                {
                    b.Height = 52;
                    b.Region = null;

                    b.Padding = new Padding(14, 0, 0, 0);
                    b.TextAlign = ContentAlignment.MiddleLeft;
                    b.ImageAlign = ContentAlignment.MiddleLeft;
                    b.TextImageRelation = TextImageRelation.ImageBeforeText;

                    b.FlatAppearance.BorderSize = 0;
                }
            }
            else
            {
                btnModulo1.Text = "";
                btnModulo2.Text = "";
                btnModulo3.Text = "";
                btnModulo4.Text = "";

                foreach (var b in botones)
                {
                    b.Width = menuCerrado;
                    b.Height = 60;

                    b.Padding = new Padding(0);
                    b.TextAlign = ContentAlignment.MiddleCenter;
                    b.ImageAlign = ContentAlignment.MiddleCenter;
                    b.TextImageRelation = TextImageRelation.Overlay;

                    b.FlatAppearance.BorderSize = 1;
                    b.FlatAppearance.BorderColor = Color.FromArgb(90, 190, 150, 80);

                    RedondearBoton(b, 18);
                }
            }

            foreach (var b in botones)
            {
                if (!b.IsDisposed && !b.Disposing && b.IsHandleCreated)
                    b.Invalidate();
            }
        }

        private void RedondearBoton(Button b, int radio)
        {
            if (b.IsDisposed || b.Disposing || !b.IsHandleCreated) return;

            var path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(b.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(b.Width - radio, b.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, b.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();
            b.Region = new Region(path);
        }

        private void MarcarActivo(Button activo)
        {
            _btnActivo = activo;

            Button[] botones = { btnModulo1, btnModulo2, btnModulo3, btnModulo4 };
            foreach (var b in botones)
            {
                if (!b.IsDisposed && !b.Disposing && b.IsHandleCreated)
                    b.Invalidate();
            }
        }

        private void btnIconoMenu_Click(object sender, System.EventArgs e)
        {
            if (_cerrandoSesion) return;

            if (menuAfuera)
            {
                plModulos.Width = menuCerrado;
                menuAfuera = false;
            }
            else
            {
                plModulos.Width = menuAbierto;
                menuAfuera = true;
            }

            ActualizarMenuVisual();
        }

        // =========================================================
        //  Navegación
        // =========================================================
        private void btnModulo1_Click(object sender, System.EventArgs e)
        {
            if (_cerrandoSesion) return;
            MarcarActivo(btnModulo1);
            CargarUserControl(new cuModulo1());
        }

        private void btnModulo2_Click(object sender, System.EventArgs e)
        {
            if (_cerrandoSesion) return;
            MarcarActivo(btnModulo2);
            CargarUserControl(new desarrollo1());
        }

        private void btnModulo3_Click(object sender, System.EventArgs e)
        {
            if (_cerrandoSesion) return;
            MarcarActivo(btnModulo3);
            CargarUserControl(new Saludcaballos());
        }

        private void btnModulo4_Click(object sender, System.EventArgs e)
        {
            if (_cerrandoSesion) return;
            MarcarActivo(btnModulo4);
            CargarUserControl(new cuModulo4());
        }

        private void CargarUserControl(UserControl uc)
        {
            if (_cerrandoSesion) return;

            plContenido.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            plContenido.Controls.Add(uc);
        }

        // =========================================================
        //  Cerrar sesión con confirmación (VUELVE A LOGIN)
        // =========================================================
        private void cerrarSesion_button_Click(object sender, System.EventArgs e)
        {
            using var dlg = new ConfirmSalirForm();
            var r = dlg.ShowDialog(this);

            if (r == DialogResult.Yes)
            {
                _cerrandoSesion = true;
                cerrarSesion_button.Enabled = false;

                // corta estados visuales para evitar Paint tardío
                _btnVisualState.Clear();
                _btnActivo = null;

                // muestra el mismo login (no crees otro)
                if (_loginRef != null && !_loginRef.IsDisposed && !_loginRef.Disposing)
                {
                    _loginRef.Show();
                    _loginRef.Activate();
                }

                // cierra el main de forma segura
                BeginInvoke(new System.Action(() => Close()));
            }
        }

        // =========================================================
        //  Confirmación personalizada
        // =========================================================
        private class ConfirmSalirForm : Form
        {
            public ConfirmSalirForm()
            {
                FormBorderStyle = FormBorderStyle.FixedDialog;
                StartPosition = FormStartPosition.CenterParent;
                MaximizeBox = false;
                MinimizeBox = false;
                ShowInTaskbar = false;
                ClientSize = new Size(420, 190);

                BackgroundImage = Properties.Resources.madera_11;
                BackgroundImageLayout = ImageLayout.Stretch;

                var root = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent,
                    Padding = new Padding(16),
                    RowCount = 2
                };
                root.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
                root.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));

                var card = new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(120, 0, 0, 0),
                    Padding = new Padding(10)
                };

                var lbl = new Label
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "¿Seguro que deseas cerrar sesión?",
                    Font = new Font("Georgia", 12F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(238, 226, 205),
                    BackColor = Color.Transparent
                };
                card.Controls.Add(lbl);

                var pnlBtns = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent,
                    ColumnCount = 2
                };
                pnlBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                pnlBtns.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));

                var btnSi = new Button
                {
                    Text = "Sí, cerrar",
                    Dock = DockStyle.Fill,
                    Height = 38,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.FromArgb(238, 226, 205),
                    Font = new Font("Georgia", 9.5F, FontStyle.Bold),
                    Margin = new Padding(6, 10, 6, 0),
                    BackgroundImage = Properties.Resources.btn_rojo,
                    BackgroundImageLayout = ImageLayout.Stretch
                };
                btnSi.FlatAppearance.BorderSize = 0;

                var btnNo = new Button
                {
                    Text = "Cancelar",
                    Dock = DockStyle.Fill,
                    Height = 38,
                    FlatStyle = FlatStyle.Flat,
                    ForeColor = Color.FromArgb(238, 226, 205),
                    Font = new Font("Georgia", 9.5F, FontStyle.Bold),
                    Margin = new Padding(6, 10, 6, 0),
                    BackgroundImage = Properties.Resources.btn_azul,
                    BackgroundImageLayout = ImageLayout.Stretch
                };
                btnNo.FlatAppearance.BorderSize = 0;

                btnSi.Click += (_, __) => { DialogResult = DialogResult.Yes; Close(); };
                btnNo.Click += (_, __) => { DialogResult = DialogResult.No; Close(); };

                AcceptButton = btnSi;
                CancelButton = btnNo;

                pnlBtns.Controls.Add(btnSi, 0, 0);
                pnlBtns.Controls.Add(btnNo, 1, 0);

                root.Controls.Add(card, 0, 0);
                root.Controls.Add(pnlBtns, 0, 1);

                Controls.Add(root);
            }
        }

        private void plModulos_Paint(object sender, PaintEventArgs e)
        {
            // sin uso
        }
    }
}
