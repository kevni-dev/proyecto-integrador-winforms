using Proyecto_Integrador.ControlesUsuario.A_Turismo;
using Proyecto_Integrador.Datos;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class cuModulo1 : UserControl
    {
        private Panel? _btnSeleccionado;

        private static readonly Color TopBack = Color.FromArgb(237, 224, 210);

        private static readonly Color IdleBack = TopBack;
        private static readonly Color HoverBack = Color.FromArgb(244, 236, 226);
        private static readonly Color DownBack = Color.FromArgb(232, 221, 208);

        private static readonly Color SelectedBack = Color.FromArgb(120, 116, 105);
        private static readonly Color TextIdle = Color.FromArgb(60, 40, 25);
        private static readonly Color TextSelected = Color.FromArgb(245, 239, 230);

        // 🔥 Borde visible
        private static readonly Color BorderOuterIdle = Color.FromArgb(155, 140, 120);
        private static readonly Color BorderOuterSelected = Color.FromArgb(95, 82, 66);

        public cuModulo1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            ActivarDoubleBuffer(panelTopMenu);
            ActivarDoubleBuffer(panelContent);
            ActivarDoubleBuffer(TurismopanelContenido);

            PrepararTab(hostRegistrar, layoutRegistrar, iconRegistrar, lblRegistrar, Properties.Resources.reg_2);
            PrepararTab(hostVer, layoutVer, iconVer, lblVer, Properties.Resources.ver_2);
            PrepararTab(hostAgenda, layoutAgenda, iconAgenda, lblAgenda, Properties.Resources.cal_2);
            PrepararTab(hostRutas, layoutRutas, iconRutas, lblRutas, Properties.Resources.map_2);
            PrepararTab(hostMinijuego, layoutMinijuego, iconMinijuego, lblMinijuego, Properties.Resources.jue_2);

            AsignarClick(hostRegistrar, iconRegistrar, lblRegistrar, TurismoButtonRegistrar_Click);
            AsignarClick(hostVer, iconVer, lblVer, TurismoButtonVer_Click);
            AsignarClick(hostAgenda, iconAgenda, lblAgenda, TurismoButtonAgenda_Click);
            AsignarClick(hostRutas, iconRutas, lblRutas, TurismoButtonRutas_Click);
            AsignarClick(hostMinijuego, iconMinijuego, lblMinijuego, TurismoButtonMinijuego_Click);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void cuModulo1_Load(object? sender, EventArgs e)
        {
            panelTopMenu.BackColor = TopBack;
            tablaTopMenu.BackColor = TopBack;

            panelContent.BackgroundImage = Properties.Resources.fondoestablo11;
            panelContent.BackgroundImageLayout = ImageLayout.Stretch;

            RepositorioCaballos.CargarDesdeJson();

            Seleccionar(hostRegistrar);
            CambiarPantalla(new TurismoRegistrarCaballo());
        }

        // =========================
        // TAB STYLE
        // =========================
        private void PrepararTab(Panel host, TableLayoutPanel layout, PictureBox icono, Label texto, Image img)
        {
            host.BorderStyle = BorderStyle.None;
            host.Cursor = Cursors.Hand;

            // 🔥 IMPORTANTE: espacio para que el borde no quede tapado
            host.Padding = new Padding(3);

            layout.Margin = new Padding(0);
            layout.Padding = new Padding(0);

            host.Tag = new HostRefs(layout, icono, texto);

            texto.ForeColor = TextIdle;
            texto.Font = new Font("Georgia", 12F);
            texto.Cursor = Cursors.Hand;

            icono.Image = img;
            icono.SizeMode = PictureBoxSizeMode.Zoom;
            icono.Cursor = Cursors.Hand;

            host.Paint -= Host_Paint;
            host.Paint += Host_Paint;

            host.MouseEnter += (_, __) => { if (host != _btnSeleccionado) SetHostBack(host, HoverBack); };
            host.MouseLeave += (_, __) => AplicarEstado(host);
            host.MouseDown += (_, __) => { if (host != _btnSeleccionado) SetHostBack(host, DownBack); };
            host.MouseUp += (_, __) => { if (host != _btnSeleccionado) SetHostBack(host, HoverBack); };

            DelegarEventosAlHost(host, icono);
            DelegarEventosAlHost(host, texto);

            AplicarEstado(host);
        }

        // 🔥 MARCO REALMENTE VISIBLE
        private void Host_Paint(object? sender, PaintEventArgs e)
        {
            if (sender is not Panel p) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            var rect = p.ClientRectangle;

            // Ajuste para que no quede escondido
            rect = new Rectangle(
                rect.X + 1,
                rect.Y + 1,
                rect.Width - 3,
                rect.Height - 3
            );

            bool sel = (p == _btnSeleccionado);
            Color borderColor = sel ? BorderOuterSelected : BorderOuterIdle;

            using (var pen = new Pen(borderColor, 2))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void DelegarEventosAlHost(Panel host, Control child)
        {
            child.MouseEnter += (_, __) =>
            {
                if (host != _btnSeleccionado) SetHostBack(host, HoverBack);
            };

            child.MouseLeave += (_, __) =>
            {
                AplicarEstado(host);
            };

            child.MouseDown += (_, __) =>
            {
                if (host != _btnSeleccionado) SetHostBack(host, DownBack);
            };

            child.MouseUp += (_, __) =>
            {
                if (host != _btnSeleccionado) SetHostBack(host, HoverBack);
            };
        }

        private void SetHostBack(Panel host, Color back)
        {
            host.BackColor = back;
            SincronizarFondos(host);
            host.Invalidate();
        }

        private void AplicarEstado(Panel host)
        {
            bool sel = (host == _btnSeleccionado);

            host.BackColor = sel ? SelectedBack : IdleBack;
            SincronizarFondos(host);

            if (host == hostRegistrar) lblRegistrar.ForeColor = sel ? TextSelected : TextIdle;
            if (host == hostVer) lblVer.ForeColor = sel ? TextSelected : TextIdle;
            if (host == hostAgenda) lblAgenda.ForeColor = sel ? TextSelected : TextIdle;
            if (host == hostRutas) lblRutas.ForeColor = sel ? TextSelected : TextIdle;
            if (host == hostMinijuego) lblMinijuego.ForeColor = sel ? TextSelected : TextIdle;

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
            _btnSeleccionado = host;

            AplicarEstado(hostRegistrar);
            AplicarEstado(hostVer);
            AplicarEstado(hostAgenda);
            AplicarEstado(hostRutas);
            AplicarEstado(hostMinijuego);
        }

        private void CambiarPantalla(UserControl pantalla)
        {
            panelContent.Controls.Clear();
            pantalla.Dock = DockStyle.Fill;
            panelContent.Controls.Add(pantalla);
            pantalla.BringToFront();
        }

        private void TurismoButtonRegistrar_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostRegistrar);
            CambiarPantalla(new TurismoRegistrarCaballo());
        }

        private void TurismoButtonVer_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostVer);
            CambiarPantalla(new TurismoVerRegistro());
        }

        private void TurismoButtonAgenda_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostAgenda);

            var agenda = new TurismoAgendaCalendario();
            agenda.Caballos = RepositorioCaballos.ObtenerTodos()
                .Select(c => (c.Nombre ?? "").Trim())
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .ToList();

            CambiarPantalla(agenda);
        }

        private void TurismoButtonRutas_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostRutas);
            CambiarPantalla(new TurismoRutas());
        }

        private void TurismoButtonMinijuego_Click(object? sender, EventArgs e)
        {
            Seleccionar(hostMinijuego);
            CambiarPantalla(new TurismoMinijuego());
        }

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
