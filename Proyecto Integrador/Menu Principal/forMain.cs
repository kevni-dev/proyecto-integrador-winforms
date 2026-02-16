using Proyecto_Integrador.ControlesUsuario.cuModulo4;
using Proyecto_Integrador.ControlesUsuario;
using Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento;
using Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos;
using System.Drawing.Drawing2D;

namespace Proyecto_Integrador
{
    public partial class forMain : Form
    {
        private string _t1, _t2, _t3, _t4;

        int menuAbierto = 220;
        int menuCerrado = 80;
        bool menuAfuera = true;

        private readonly string _usuarioActual;

        // ===== Tema (ajustable) =====
        private readonly Color _txtClaro = Color.FromArgb(238, 226, 205);     // beige
        private readonly Color _txtOscuro = Color.FromArgb(30, 22, 16);       // marrón muy oscuro
        private readonly Color _hoverOscuro = Color.FromArgb(55, 0, 0, 0);     // barniz (semi)
        private readonly Color _downOscuro = Color.FromArgb(90, 0, 0, 0);      // presionado (semi)
        private readonly Color _activoDorado = Color.FromArgb(70, 200, 165, 90); // activo (semi)
        private readonly Color _bordeDorado = Color.FromArgb(200, 190, 150, 80);

        private Button? _btnActivo;

        public forMain(string usuarioActual)
        {
            InitializeComponent();

            _usuarioActual = string.IsNullOrWhiteSpace(usuarioActual) ? "Usuario" : usuarioActual;

            _t1 = btnModulo1.Text;
            _t2 = btnModulo2.Text;
            _t3 = btnModulo3.Text;
            _t4 = btnModulo4.Text;

            // ===== ICONOS (Resources) =====
            btnModulo1.Image = Properties.Resources.Icon_Registro;
            btnModulo2.Image = Properties.Resources.Icon_Alimentacion;
            btnModulo3.Image = Properties.Resources.Icon_Salud;
            btnModulo4.Image = Properties.Resources.Icon_Mental;

            btnModulo1.Image = new Bitmap(btnModulo1.Image, new Size(36, 36));
            btnModulo2.Image = new Bitmap(btnModulo2.Image, new Size(36, 36));
            btnModulo3.Image = new Bitmap(btnModulo3.Image, new Size(36, 36));
            btnModulo4.Image = new Bitmap(btnModulo4.Image, new Size(36, 36));

            // ===== Estilo carcasa =====
            AplicarEstiloBarraSuperior();
            AplicarEstiloSidebar();

            // Activo inicial
            MarcarActivo(btnModulo1);

            ActualizarMenuVisual();
        }

        private void forMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            usuario_label.Text = _usuarioActual;
        }

        // =========================================================
        //  Barra superior
        // =========================================================
        private void AplicarEstiloBarraSuperior()
        {
            // Fondo ya lo tienes: plTitulo.BackgroundImage = madera_11 (Designer)
            plTitulo.BackColor = Color.Transparent;

            // Título
            lblTituloPrincipal.Font = new Font("Georgia", 14F, FontStyle.Bold);
            lblTituloPrincipal.ForeColor = _txtClaro;
            lblTituloPrincipal.BackColor = Color.Transparent;

            // Panel usuario (que no tape la madera)
            userPanel.BackColor = Color.Transparent;

            // Usuario
            usuario_label.Font = new Font("Georgia", 10F, FontStyle.Bold);
            usuario_label.ForeColor = _txtClaro;
            usuario_label.BackColor = Color.Transparent;

            // Foto usuario (si el png tiene transparencia, se verá mejor)
            usuario_picture.BackColor = Color.Transparent;

            // Botón menú (hamburguesa)
            btnIconoMenu.FlatStyle = FlatStyle.Flat;
            btnIconoMenu.FlatAppearance.BorderSize = 0;
            btnIconoMenu.BackColor = Color.Transparent;
            btnIconoMenu.UseVisualStyleBackColor = false;

            // Si tienes un icono propio, úsalo aquí (mejor que el texto)
            // CAMBIA el nombre del recurso al tuyo:
            // btnIconoMenu.Image = Properties.Resources.icon_menu;
            // btnIconoMenu.ImageAlign = ContentAlignment.MiddleCenter;
            // btnIconoMenu.Text = "";

            // Si NO tienes icono aún, deja texto pero con estilo rústico
            btnIconoMenu.Text = "☰";
            btnIconoMenu.Font = new Font("Georgia", 16F, FontStyle.Bold);
            btnIconoMenu.ForeColor = _txtClaro;
            btnIconoMenu.FlatAppearance.MouseOverBackColor = _hoverOscuro;
            btnIconoMenu.FlatAppearance.MouseDownBackColor = _downOscuro;

            // Botón salir: tú dijiste que será una imagen ya con letras
            cerrarSesion_button.FlatStyle = FlatStyle.Flat;
            cerrarSesion_button.FlatAppearance.BorderSize = 0;
            cerrarSesion_button.BackColor = Color.Transparent;
            cerrarSesion_button.UseVisualStyleBackColor = false;
            cerrarSesion_button.Text = "";
            cerrarSesion_button.ForeColor = Color.Transparent;

            // CAMBIA este recurso al que tú pongas para el botón salir (JPG/PNG):
            // cerrarSesion_button.BackgroundImage = Properties.Resources.btn_salir;
            // cerrarSesion_button.BackgroundImageLayout = ImageLayout.Stretch;

            cerrarSesion_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            cerrarSesion_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        // =========================================================
        //  Sidebar
        // =========================================================
        private void AplicarEstiloSidebar()
        {
            Button[] botones = { btnModulo1, btnModulo2, btnModulo3, btnModulo4 };

            // Fondo madera (ya lo tienes en Designer: Recurso_1)
            plModulos.BackColor = Color.Transparent;
            plModulos.Width = menuAbierto;

            foreach (var b in botones)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;

                // Importante: para que el fondo madera se vea, el botón NO debe ser azul sólido
                b.BackColor = Color.Transparent;
                b.UseVisualStyleBackColor = false;

                // Hover / Down tipo barniz (semi transparente)
                b.FlatAppearance.MouseOverBackColor = _hoverOscuro;
                b.FlatAppearance.MouseDownBackColor = _downOscuro;

                b.Height = 52;

                // Tipografía rústica
                b.Font = new Font("Georgia", 10F, FontStyle.Bold);
                b.ForeColor = _txtClaro;

                b.TextAlign = ContentAlignment.MiddleLeft;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Padding = new Padding(14, 0, 0, 0);

                // Pequeño “borde” visual al pasar por encima (sutil)
                b.Paint -= BotonSidebar_Paint;
                b.Paint += BotonSidebar_Paint;

                // Efecto hover (solo para refrescar pintura)
                b.MouseEnter -= BotonSidebar_Refresh;
                b.MouseLeave -= BotonSidebar_Refresh;
                b.MouseEnter += BotonSidebar_Refresh;
                b.MouseLeave += BotonSidebar_Refresh;
            }
        }

        private void BotonSidebar_Refresh(object? sender, EventArgs e)
        {
            if (sender is Control c) c.Invalidate();
        }

        // Dibujamos indicador dorado del botón activo (sin imágenes)
        private void BotonSidebar_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Button b) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            bool esActivo = ReferenceEquals(b, _btnActivo);

            if (esActivo)
            {
                // Fondo dorado semi
                using var br = new SolidBrush(_activoDorado);
                e.Graphics.FillRectangle(br, new Rectangle(0, 0, b.Width, b.Height));

                // Línea dorada izquierda
                using var pen = new Pen(_bordeDorado, 4);
                e.Graphics.DrawLine(pen, 2, 6, 2, b.Height - 6);
            }

            // Bordecito fino abajo (separación sutil)
            using var penSep = new Pen(Color.FromArgb(60, 0, 0, 0), 1);
            e.Graphics.DrawLine(penSep, 12, b.Height - 1, b.Width - 12, b.Height - 1);
        }

        // =========================================================
        //  Menú abierto/cerrado
        // =========================================================
        private void ActualizarMenuVisual()
        {
            Button[] botones = { btnModulo1, btnModulo2, btnModulo3, btnModulo4 };

            if (menuAfuera) // ABIERTO: icono + texto
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

                    // Borde apagado (no lo necesitamos)
                    b.FlatAppearance.BorderSize = 0;
                }
            }
            else // CERRADO: solo icono + forma redondeada
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
                    b.FlatAppearance.BorderColor = Color.FromArgb(70, 80, 60, 40);

                    RedondearBoton(b, 18);
                }
            }

            // Para que el activo se repinte bien
            foreach (var b in botones) b.Invalidate();
        }

        private void RedondearBoton(Button b, int radio)
        {
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
            foreach (var b in botones) b.Invalidate();
        }

        private void btnIconoMenu_Click(object sender, EventArgs e)
        {
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
        //  Navegación módulos (sin tocar contenido)
        // =========================================================
        private void btnModulo1_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnModulo1);
            CargarUserControl(new cuModulo1());
        }

        private void btnModulo2_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnModulo2);
            CargarUserControl(new desarrollo1());
        }

        private void btnModulo3_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnModulo3);
            CargarUserControl(new Saludcaballos());
        }

        private void btnModulo4_Click(object sender, EventArgs e)
        {
            MarcarActivo(btnModulo4);
            CargarUserControl(new cuModulo4());
        }

        private void CargarUserControl(UserControl uc)
        {
            plContenido.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            plContenido.Controls.Add(uc);
        }

        // =========================================================
        //  Salir con confirmación personalizada
        // =========================================================
        private void cerrarSesion_button_Click(object sender, EventArgs e)
        {
            using var dlg = new ConfirmSalirForm();
            var r = dlg.ShowDialog(this);

            if (r == DialogResult.Yes)
            {
                var login = new FormLogin();
                login.Show();
                Close();
            }
        }

        // Form de confirmación (simple, estilo madera)
        private class ConfirmSalirForm : Form
        {
            private readonly Button _btnSi;
            private readonly Button _btnNo;
            private readonly Label _lbl;

            public ConfirmSalirForm()
            {
                // Ventana
                FormBorderStyle = FormBorderStyle.FixedDialog;
                StartPosition = FormStartPosition.CenterParent;
                MaximizeBox = false;
                MinimizeBox = false;
                ShowInTaskbar = false;
                ClientSize = new Size(380, 170);

                // Fondo: usa tu madera (cambia si quieres otra)
                BackgroundImage = Properties.Resources.madera_11;
                BackgroundImageLayout = ImageLayout.Stretch;

                // Texto
                _lbl = new Label
                {
                    AutoSize = false,
                    Dock = DockStyle.Top,
                    Height = 90,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "¿Seguro que deseas salir?",
                    Font = new Font("Georgia", 12F, FontStyle.Bold),
                    BackColor = Color.Transparent,
                    ForeColor = Color.FromArgb(238, 226, 205)
                };

                // Botones
                _btnSi = new Button
                {
                    Text = "Sí, salir",
                    Width = 130,
                    Height = 36,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(180, 155, 90),
                    ForeColor = Color.FromArgb(25, 18, 12),
                    Font = new Font("Georgia", 9.5F, FontStyle.Bold)
                };
                _btnSi.FlatAppearance.BorderSize = 0;

                _btnNo = new Button
                {
                    Text = "Cancelar",
                    Width = 130,
                    Height = 36,
                    FlatStyle = FlatStyle.Flat,
                    BackColor = Color.FromArgb(90, 45, 35),
                    ForeColor = Color.FromArgb(238, 226, 205),
                    Font = new Font("Georgia", 9.5F, FontStyle.Bold)
                };
                _btnNo.FlatAppearance.BorderSize = 0;

                _btnSi.Click += (_, __) => { DialogResult = DialogResult.Yes; Close(); };
                _btnNo.Click += (_, __) => { DialogResult = DialogResult.No; Close(); };

                var pnlBtns = new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.Transparent
                };

                _btnSi.Location = new Point(55, 110);
                _btnNo.Location = new Point(195, 110);

                pnlBtns.Controls.Add(_btnSi);
                pnlBtns.Controls.Add(_btnNo);

                Controls.Add(pnlBtns);
                Controls.Add(_lbl);
            }
        }

        private void plModulos_Paint(object sender, PaintEventArgs e)
        {
            // No usamos esto por ahora
        }
    }
}
