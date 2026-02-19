// Saludcaballos.cs (REEMPLAZA este archivo COMPLETO)
// - Quita el panel de título (ya no existe panel1)
// - Tabs arriba estilo Turismo + TAB NUEVO "Caballos" para volver a la lista
// - Panel3: puedes poner fondo (opcional) para que no se vea gris el espacio vacío
// - NO toca sidebar azul ni barra madera (eso es del Main)

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class Saludcaballos : UserControl
    {
        private List<Caballo> _caballos = new();

        // ===== Caballos: tabla + vista previa =====
        private SplitContainer? _splitCaballos;
        private Panel? _preview;
        private PictureBox? _pic;
        private Label? _pvNombre;
        private Label? _pvRaza;
        private Label? _pvEdad;
        private Label? _pvSexo;
        private Label? _pvEnfTitle;
        private ListBox? _pvEnfList;
        private Button? _pvVerEnf;
        private Button? _pvAgregarEnf;
        private Label? _pvHint;

        // ===== Tabs estilo Turismo =====
        private Panel? _tabSeleccionado;

        private static readonly Color TopBack = Color.FromArgb(237, 224, 210);

        private static readonly Color IdleBack = TopBack;
        private static readonly Color HoverBack = Color.FromArgb(244, 236, 226);
        private static readonly Color DownBack = Color.FromArgb(232, 221, 208);

        private static readonly Color SelectedBack = Color.FromArgb(120, 116, 105);
        private static readonly Color TextIdle = Color.FromArgb(60, 40, 25);
        private static readonly Color TextSelected = Color.FromArgb(245, 239, 230);

        private static readonly Color BorderOuterIdle = Color.FromArgb(155, 140, 120);
        private static readonly Color BorderOuterSelected = Color.FromArgb(95, 82, 66);

        public Saludcaballos()
        {
            InitializeComponent();

            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            ActivarDoubleBuffer(panelTopMenu);
            ActivarDoubleBuffer(panel3);

            // ===== Tabs (5) =====
            PrepararTab(hostCaballos, layoutCaballos, iconCaballos, lblCaballos, GetIcon("ver_2"));
            PrepararTab(hostEnfermedades, layoutEnfermedades, iconEnfermedades, lblEnfermedades, GetIcon("Icon_Salud"));
            PrepararTab(hostTratamientos, layoutTratamientos, iconTratamientos, lblTratamientos, GetIcon("registrar"));
            PrepararTab(hostPrevencion, layoutPrevencion, iconPrevencion, lblPrevencion, GetIcon("carta_dorso"));
            PrepararTab(hostMinijuego, layoutMinijuego, iconMinijuego, lblMinijuego, GetIcon("jue_2"));

            AsignarClick(hostCaballos, iconCaballos, lblCaballos, TabCaballos_Click);
            AsignarClick(hostEnfermedades, iconEnfermedades, lblEnfermedades, TabEnfermedades_Click);
            AsignarClick(hostTratamientos, iconTratamientos, lblTratamientos, TabTratamientos_Click);
            AsignarClick(hostPrevencion, iconPrevencion, lblPrevencion, TabPrevencion_Click);
            AsignarClick(hostMinijuego, iconMinijuego, lblMinijuego, TabMinijuego_Click);

            // Doble click en tabla
            dtgv_caballos.CellDoubleClick += dtgv_caballos_CellDoubleClick;
        }

        // anti-flicker fuerte
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void saludcaballos_Load(object sender, EventArgs e)
        {
            panelTopMenu.BackColor = TopBack;
            tablaTopMenu.BackColor = TopBack;

            // Fondo opcional para que el espacio vacío no quede gris
            // (si no quieres fondo, comenta estas 2 líneas)
            panel3.BackgroundImage = Properties.Resources.fondoestablo11;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;

            // Config visual del grid (para que se vea bien sobre el fondo)
            dtgv_caballos.BackgroundColor = Color.White;
            dtgv_caballos.BorderStyle = BorderStyle.FixedSingle;

            // Cargar del JSON
            RepositorioCaballos.CargarDesdeJson();

            // Por defecto: ir a Caballos (lista)
            Seleccionar(hostCaballos);
            MostrarTablaCaballos();
        }

        // =========================
        // CONTENIDO (TU LÓGICA)
        // =========================
        private void MostrarTablaCaballos()
        {
            panel3.Controls.Clear();

            // tabla
            CargarTablaCaballos();

            // split: izquierda tabla, derecha vista previa
            _splitCaballos = new SplitContainer
            {
                Dock = DockStyle.Fill,
                Orientation = Orientation.Vertical,
                SplitterWidth = 6,
                SplitterDistance = (int)(panel3.Width * 0.70),
                BackColor = Color.Transparent
            };

            _splitCaballos.Panel1.Padding = new Padding(10, 10, 6, 10);
            _splitCaballos.Panel2.Padding = new Padding(6, 10, 10, 10);
            _splitCaballos.Panel1.BackColor = Color.Transparent;
            _splitCaballos.Panel2.BackColor = Color.Transparent;

            // grid
            dtgv_caballos.Dock = DockStyle.Top;
            dtgv_caballos.ScrollBars = ScrollBars.Both;
            dtgv_caballos.SelectionChanged -= Dtgv_caballos_SelectionChanged;
            dtgv_caballos.SelectionChanged += Dtgv_caballos_SelectionChanged;

            var wrapLeft = new Panel { Dock = DockStyle.Fill, BackColor = Color.Transparent };
            var cardTabla = new Panel { Dock = DockStyle.Top };
            SaludTheme.MakeCard(cardTabla, new Padding(10));
            cardTabla.Controls.Add(dtgv_caballos);

            var filler = new Panel { Dock = DockStyle.Fill, BackColor = Color.Transparent };

            wrapLeft.Controls.Add(filler);
            wrapLeft.Controls.Add(cardTabla);

            _splitCaballos.Panel1.Controls.Add(wrapLeft);

            void AjustarAlturaTabla()
            {
                try
                {
                    if (dtgv_caballos.Rows.Count == 0)
                    {
                        cardTabla.Height = 140;
                        return;
                    }

                    int rowsH = 0;
                    foreach (DataGridViewRow r in dtgv_caballos.Rows)
                        rowsH += r.Height;

                    int desired = dtgv_caballos.ColumnHeadersHeight + rowsH + 26; // padding
                    int max = Math.Max(220, _splitCaballos.Panel1.ClientSize.Height - 120);
                    cardTabla.Height = Math.Min(desired, max);

                    dtgv_caballos.Height = Math.Max(120, cardTabla.Height - 20);
                }
                catch { }
            }

            dtgv_caballos.DataBindingComplete += (_, __) => AjustarAlturaTabla();
            _splitCaballos.Panel1.Resize += (_, __) => AjustarAlturaTabla();

            // vista previa
            _preview = CrearVistaPrevia();
            _splitCaballos.Panel2.Controls.Add(_preview);

            panel3.Controls.Add(_splitCaballos);
            _splitCaballos.BringToFront();

            // primera carga
            ActualizarVistaPrevia();
        }

        private Panel CrearVistaPrevia()
        {
            var card = new Panel { Dock = DockStyle.Fill };
            SaludTheme.MakeCard(card, new Padding(16));

            var title = new Label
            {
                Text = "Vista previa",
                Dock = DockStyle.Top,
                Height = 30,
                TextAlign = ContentAlignment.MiddleLeft
            };
            SaludTheme.StyleLabel(title);

            _pic = new PictureBox
            {
                Dock = DockStyle.Top,
                Height = 170,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            _pvNombre = new Label { Dock = DockStyle.Top, Height = 36, TextAlign = ContentAlignment.MiddleLeft };
            SaludTheme.StyleTitle(_pvNombre);
            _pvNombre.Font = new Font("Georgia", 18F, FontStyle.Bold);

            _pvRaza = new Label { Dock = DockStyle.Top, Height = 22 };
            _pvEdad = new Label { Dock = DockStyle.Top, Height = 22 };
            _pvSexo = new Label { Dock = DockStyle.Top, Height = 22 };
            SaludTheme.StyleLabel(_pvRaza);
            SaludTheme.StyleLabel(_pvEdad);
            SaludTheme.StyleLabel(_pvSexo);
            _pvRaza.Font = new Font("Segoe UI", 10.5F);
            _pvEdad.Font = new Font("Segoe UI", 10.5F);
            _pvSexo.Font = new Font("Segoe UI", 10.5F);
            // lista de enfermedades (vista previa)
            _pvEnfTitle = new Label { Dock = DockStyle.Top, Height = 24, TextAlign = ContentAlignment.MiddleLeft, Text = "Enfermedades" };
            SaludTheme.StyleLabel(_pvEnfTitle);
            _pvEnfTitle.Font = new Font("Georgia", 11.5F, FontStyle.Bold);

            _pvEnfList = new ListBox
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10.5F),
                IntegralHeight = false
            };

            // estilo simple
            _pvEnfList.BackColor = Color.White;
            _pvEnfList.ForeColor = SaludTheme.Text;


            _pvHint = new Label
            {
                Dock = DockStyle.Bottom,
                Height = 26,
                TextAlign = ContentAlignment.MiddleLeft,
                ForeColor = SaludTheme.MutedText,
                Font = new Font("Segoe UI", 9.5F, FontStyle.Italic),
                Text = "Tip: usa \"Ver enfermedades\" para ver el historial completo"
            };

            var pnlBtns = new Panel { Dock = DockStyle.Bottom, Height = 90 };
            pnlBtns.BackColor = Color.Transparent;

            var pnlEnfs = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 10, 0, 10), BackColor = Color.Transparent };
            if (_pvEnfTitle != null) pnlEnfs.Controls.Add(_pvEnfTitle);
            if (_pvEnfList != null) pnlEnfs.Controls.Add(_pvEnfList);
            // orden interno (dock): primero title (top) luego list (fill)
            _pvEnfTitle?.BringToFront();

            _pvVerEnf = new Button { Text = "Ver enfermedades", Width = 220, Height = 38, Left = 0, Top = 0 };
            _pvAgregarEnf = new Button { Text = "Agregar enfermedad", Width = 220, Height = 38, Left = 0, Top = 46 };

            SaludTheme.StyleWarningButton(_pvVerEnf, SaludTheme.ResBtnAzul);
            _pvVerEnf.ForeColor = Color.White;
            SaludTheme.StylePrimaryButton(_pvAgregarEnf, SaludTheme.ResBtnVerde);

            _pvVerEnf.Click += (_, __) =>
            {
                var caballo = ObtenerCaballoSeleccionado();
                if (caballo == null)
                {
                    MessageBox.Show("Selecciona un caballo primero (clic en una fila).");
                    return;
                }
                MostrarPopupHistorial(caballo);
            };

            _pvAgregarEnf.Click += (_, __) =>
            {
                var caballo = ObtenerCaballoSeleccionado();
                if (caballo == null)
                {
                    MessageBox.Show("Selecciona un caballo primero (clic en una fila).");
                    return;
                }

                Seleccionar(hostEnfermedades);

                var v = new cuEnfermedadesPorCaballo(caballo);
                v.SalirRequested += (s, a) =>
                {
                    Seleccionar(hostCaballos);
                    MostrarTablaCaballos();
                };

                CargarVista(v);
                v.PrepararParaAgregar();
            };

            pnlBtns.Controls.Add(_pvVerEnf);
            pnlBtns.Controls.Add(_pvAgregarEnf);

            // orden: bottom -> top
            card.Controls.Add(_pvHint);
            card.Controls.Add(pnlBtns);
            card.Controls.Add(pnlEnfs);
            card.Controls.Add(_pvSexo);
            card.Controls.Add(_pvEdad);
            card.Controls.Add(_pvRaza);
            card.Controls.Add(_pvNombre);
            card.Controls.Add(_pic);
            card.Controls.Add(title);

            // responsive
            pnlBtns.Resize += (_, __) =>
            {
                int w = pnlBtns.ClientSize.Width;
                int btnW = Math.Min(260, w);
                int x = (w - btnW) / 2;
                _pvVerEnf.Left = x;
                _pvAgregarEnf.Left = x;
                _pvVerEnf.Width = btnW;
                _pvAgregarEnf.Width = btnW;
            };

            return card;
        }

        private void Dtgv_caballos_SelectionChanged(object? sender, EventArgs e)
        {
            ActualizarVistaPrevia();
        }

        private void ActualizarVistaPrevia()
        {
            if (_pvNombre == null || _pic == null) return;

            var c = ObtenerCaballoSeleccionado();
            if (c == null)
            {
                _pvNombre.Text = "(sin selección)";
                if (_pvRaza != null) _pvRaza.Text = "";
                if (_pvEdad != null) _pvEdad.Text = "";
                if (_pvSexo != null) _pvSexo.Text = "";
                _pic.Image = null;
                if (_pvEnfList != null) { _pvEnfList.Items.Clear(); _pvEnfList.Items.Add("(sin selección)"); }
                return;
            }

            _pvNombre.Text = c.Nombre;
            if (_pvRaza != null) _pvRaza.Text = c.Raza;
            if (_pvEdad != null) _pvEdad.Text = $"{c.Edad} años";
            if (_pvSexo != null) _pvSexo.Text = c.Sexo;
            // enfermedades (vista previa)
            try
            {
                if (_pvEnfList != null)
                {
                    _pvEnfList.BeginUpdate();
                    _pvEnfList.Items.Clear();

                    if (c.Enfermedades != null && c.Enfermedades.Count > 0)
                    {
                        // muestra primero las activas, luego las más recientes
                        var orden = c.Enfermedades
                            .OrderByDescending(x => x.Activa)
                            .ThenByDescending(x => x.Fecha)
                            .Take(12)
                            .ToList();

                        foreach (var caso in orden)
                        {
                            string estado = caso.Activa ? "Activa" : "Curada";
                            string linea = $"{caso.Nombre}  •  {caso.Fecha:dd/MM/yyyy}  •  {estado}";
                            _pvEnfList.Items.Add(linea);
                        }
                    }
                    else
                    {
                        _pvEnfList.Items.Add("(sin registros)");
                    }

                    _pvEnfList.EndUpdate();
                }
            }
            catch { }


            // imagen del recurso (si existe)
            try
            {
                if (!string.IsNullOrWhiteSpace(c.ImagenRecurso))
                {
                    var img = Properties.Resources.ResourceManager.GetObject(c.ImagenRecurso) as Image;
                    _pic.Image = img;
                }
                else
                {
                    _pic.Image = null;
                }
            }
            catch
            {
                _pic.Image = null;
            }
        }

        private void CargarTablaCaballos()
        {
            _caballos = RepositorioCaballos.ObtenerTodos();

            dtgv_caballos.AutoGenerateColumns = true;
            dtgv_caballos.DataSource = null;
            dtgv_caballos.DataSource = _caballos;

            dtgv_caballos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_caballos.MultiSelect = false;
            dtgv_caballos.ReadOnly = true;
            dtgv_caballos.RowHeadersVisible = false;
            dtgv_caballos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dtgv_caballos.Columns["Enfermedades"] != null)
                dtgv_caballos.Columns["Enfermedades"].Visible = false;

            if (dtgv_caballos.Columns["ImagenRecurso"] != null)
                dtgv_caballos.Columns["ImagenRecurso"].Visible = false;
        }

        private void CargarVista(Control vista)
        {
            panel3.Controls.Clear();

            vista.Dock = DockStyle.Fill;
            panel3.Controls.Add(vista);
            vista.BringToFront();
        }

        private Caballo? ObtenerCaballoSeleccionado()
        {
            if (dtgv_caballos.CurrentRow == null) return null;
            return dtgv_caballos.CurrentRow.DataBoundItem as Caballo;
        }

        private void AbrirEnfermedadesCaballoSeleccionado(bool mostrarMensajeSiNoHay = false)
        {
            var caballo = ObtenerCaballoSeleccionado();
            if (caballo == null)
            {
                if (mostrarMensajeSiNoHay)
                    MessageBox.Show("Selecciona un caballo primero (clic en una fila).");

                // si no hay seleccionado, volver/asegurar lista
                Seleccionar(hostCaballos);
                MostrarTablaCaballos();
                dtgv_caballos.Focus();
                return;
            }

            var v = new cuEnfermedadesPorCaballo(caballo);
            v.SalirRequested += (s, a) =>
            {
                Seleccionar(hostCaballos);
                MostrarTablaCaballos();
            };

            CargarVista(v);
        }

        

        private void MostrarPopupHistorial(Caballo caballo)
        {
            try
            {
                using var f = new HistorialPopupForm(caballo);
                f.StartPosition = FormStartPosition.CenterParent;
                var owner = FindForm();
                if (owner != null) f.ShowDialog(owner);
                else f.ShowDialog();
            }
            catch
            {
                // fallback: abre el módulo normal
                Seleccionar(hostEnfermedades);
                AbrirEnfermedadesCaballoSeleccionado(true);
            }
        }

        private sealed class HistorialPopupForm : Form
        {
            public HistorialPopupForm(Caballo caballo)
            {
                FormBorderStyle = FormBorderStyle.None;
                ShowInTaskbar = false;
                BackColor = Color.Black;
                Opacity = 0.92;
                Width = 820;
                Height = 520;

                // Permite cerrar con ESC
                KeyPreview = true;
                KeyDown += (_, e) =>
                {
                    if (e.KeyCode == Keys.Escape)
                    {
                        e.Handled = true;
                        Close();
                    }
                };

                var root = new Panel { Dock = DockStyle.Fill, BackColor = Color.Transparent, Padding = new Padding(18) };
                Controls.Add(root);

                // tarjeta
                var card = new Panel { Dock = DockStyle.Fill };
                SaludTheme.MakeCard(card, new Padding(16));
                root.Controls.Add(card);

                var top = new Panel { Dock = DockStyle.Top, Height = 54, BackColor = Color.Transparent };
                card.Controls.Add(top);

                var lbl = new Label
                {
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Text = $"Historial de enfermedades • {caballo.Nombre}",
                    Font = new Font("Georgia", 14.5F, FontStyle.Bold),
                    ForeColor = SaludTheme.Text
                };
                top.Controls.Add(lbl);

                var btnCerrar = new Button { Text = "Cerrar", Width = 110, Height = 34, Anchor = AnchorStyles.Top | AnchorStyles.Right };
                btnCerrar.Left = top.Width - btnCerrar.Width;
                btnCerrar.Top = 10;
                btnCerrar.Click += (_, __) => Close();
                SaludTheme.StyleDangerButton(btnCerrar, SaludTheme.ResBtnRojo);
                top.Controls.Add(btnCerrar);
                top.Resize += (_, __) => btnCerrar.Left = top.ClientSize.Width - btnCerrar.Width;

                // Asegura que el botón quede visible arriba del label Dock=Fill
                btnCerrar.BringToFront();

                // grid
                var grid = new DataGridView { Dock = DockStyle.Fill };
                SaludTheme.StyleGrid(grid);
                grid.ReadOnly = true;
                grid.MultiSelect = false;
                grid.RowHeadersVisible = false;
                grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                var data = (caballo.Enfermedades ?? new List<EnfermedadCaso>())
                    .Select(c => new
                    {
                        Enfermedad = c.Nombre,
                        Fecha = c.Fecha.ToString("dd/MM/yyyy"),
                        Estado = c.Activa ? "Activa" : "Curada",
                        Notas = c.Notas
                    })
                    .OrderByDescending(x => x.Estado == "Activa")
                    .ThenByDescending(x => x.Fecha)
                    .ToList();

                grid.DataSource = data;
                card.Controls.Add(grid);
                grid.BringToFront();

                // click afuera para cerrar
                root.MouseDown += (_, __) => Close();
                card.MouseDown += (_, __) => { };
            }
        }
private void dtgv_caballos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            Seleccionar(hostEnfermedades);
            AbrirEnfermedadesCaballoSeleccionado(false);
        }

        // =========================
        // EVENTOS DE TABS
        // =========================
        private void TabCaballos_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostCaballos);
            MostrarTablaCaballos();
        }

        private void TabEnfermedades_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostEnfermedades);

            // si no está la tabla, mostrarla primero
            if (!panel3.Controls.Contains(dtgv_caballos))
                MostrarTablaCaballos();

            // abrir solo si hay seleccionado; si no, vuelve a Caballos (lista)
            AbrirEnfermedadesCaballoSeleccionado(false);
        }

        private void TabTratamientos_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostTratamientos);
            var v = new cuTratamientos();
            CargarVista(v);
        }

        private void TabPrevencion_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostPrevencion);
            var v = new cuPrevencion();
            CargarVista(v);
        }

        private void TabMinijuego_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostMinijuego);

            var juego = new cuSopaEnfermedades();
            juego.SalirRequested += (s, a) =>
            {
                Seleccionar(hostCaballos);
                MostrarTablaCaballos();
            };

            CargarVista(juego);
        }

        // =========================
        // TAB STYLE (como Turismo)
        // =========================
        private void PrepararTab(Panel host, TableLayoutPanel layout, PictureBox icono, Label texto, Image? img)
        {
            host.BorderStyle = BorderStyle.None;
            host.Cursor = Cursors.Hand;

            host.Padding = new Padding(3);

            layout.Margin = new Padding(0);
            layout.Padding = new Padding(0);

            host.Tag = new HostRefs(layout, icono, texto);

            texto.ForeColor = TextIdle;
            texto.Font = new Font("Georgia", 12F, FontStyle.Regular);
            texto.Cursor = Cursors.Hand;

            icono.Image = img;
            icono.SizeMode = PictureBoxSizeMode.Zoom;
            icono.Cursor = Cursors.Hand;

            host.Paint -= Host_Paint;
            host.Paint += Host_Paint;

            host.MouseEnter += (_, __) => { if (host != _tabSeleccionado) SetHostBack(host, HoverBack); };
            host.MouseLeave += (_, __) => AplicarEstado(host);
            host.MouseDown += (_, __) => { if (host != _tabSeleccionado) SetHostBack(host, DownBack); };
            host.MouseUp += (_, __) => { if (host != _tabSeleccionado) SetHostBack(host, HoverBack); };

            DelegarEventosAlHost(host, icono);
            DelegarEventosAlHost(host, texto);

            AplicarEstado(host);
        }

        private void Host_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = p.ClientRectangle;
            rect = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width - 3, rect.Height - 3);

            bool sel = (p == _tabSeleccionado);
            Color borderColor = sel ? BorderOuterSelected : BorderOuterIdle;

            using (var pen = new Pen(borderColor, 2))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void DelegarEventosAlHost(Panel host, Control child)
        {
            child.MouseEnter += (_, __) => { if (host != _tabSeleccionado) SetHostBack(host, HoverBack); };
            child.MouseLeave += (_, __) => { AplicarEstado(host); };
            child.MouseDown += (_, __) => { if (host != _tabSeleccionado) SetHostBack(host, DownBack); };
            child.MouseUp += (_, __) => { if (host != _tabSeleccionado) SetHostBack(host, HoverBack); };
        }

        private void SetHostBack(Panel host, Color back)
        {
            host.BackColor = back;
            SincronizarFondos(host);
            host.Invalidate();
        }

        private void AplicarEstado(Panel host)
        {
            bool sel = (host == _tabSeleccionado);

            host.BackColor = sel ? SelectedBack : IdleBack;
            SincronizarFondos(host);

            lblCaballos.ForeColor = (hostCaballos == _tabSeleccionado) ? TextSelected : TextIdle;
            lblEnfermedades.ForeColor = (hostEnfermedades == _tabSeleccionado) ? TextSelected : TextIdle;
            lblTratamientos.ForeColor = (hostTratamientos == _tabSeleccionado) ? TextSelected : TextIdle;
            lblPrevencion.ForeColor = (hostPrevencion == _tabSeleccionado) ? TextSelected : TextIdle;
            lblMinijuego.ForeColor = (hostMinijuego == _tabSeleccionado) ? TextSelected : TextIdle;

            host.Invalidate();
        }

        private void SincronizarFondos(Panel host)
        {
            if (host.Tag is not HostRefs r) return;

            r.Layout.BackColor = host.BackColor;
            r.Icon.BackColor = host.BackColor;
            r.Text.BackColor = host.BackColor;
        }

        private void AsignarClick(Panel host, PictureBox icono, Label texto, EventHandler handler)
        {
            host.Click += handler;
            icono.Click += handler;
            texto.Click += handler;
        }

        private void Seleccionar(Panel host)
        {
            _tabSeleccionado = host;

            AplicarEstado(hostCaballos);
            AplicarEstado(hostEnfermedades);
            AplicarEstado(hostTratamientos);
            AplicarEstado(hostPrevencion);
            AplicarEstado(hostMinijuego);
        }

        // =========================
        // Utils
        // =========================
        private static void ActivarDoubleBuffer(Control control)
        {
            try
            {
                typeof(Control).GetProperty("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.SetValue(control, true, null);
            }
            catch { }
        }

        private static Image? GetIcon(string resourceName)
        {
            try
            {
                var rm = Properties.Resources.ResourceManager;
                return rm.GetObject(resourceName) as Image;
            }
            catch { return null; }
        }

        private sealed class HostRefs
        {
            public TableLayoutPanel Layout { get; }
            public PictureBox Icon { get; }
            public Label Text { get; }

            public HostRefs(TableLayoutPanel layout, PictureBox icon, Label text)
            {
                Layout = layout;
                Icon = icon;
                Text = text;
            }
        }
    }
}
