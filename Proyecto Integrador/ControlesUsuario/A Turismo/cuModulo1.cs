// cuModulo1.cs
using Proyecto_Integrador.ControlesUsuario.A_Turismo;
using Proyecto_Integrador.Datos;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class cuModulo1 : UserControl
    {
        private Button? _btnSeleccionado;

        // ----- estilo texto -----
        private static readonly Color ColorTextoMenu = Color.FromArgb(92, 58, 32);

        // ----- brillo ajustado (-25% del extra) -----
        private const float BrilloBase = 0.85f;
        private const float BrilloHover = 0.91f;
        private const float BrilloSeleccionado = 1.04f;

        public cuModulo1()
        {
            InitializeComponent();

            // ----- render suave -----
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            ActivarDoubleBuffer(panelTopMenu);
            ActivarDoubleBuffer(panelContent);
            ActivarDoubleBuffer(TurismopanelContenido);

            // ----- botones top -----
            PrepararBotonMenu(TurismoButtonRegistrar, Properties.Resources.reg_2);
            PrepararBotonMenu(TurismoButtonVer, Properties.Resources.ver_2);
            PrepararBotonMenu(TurismoButtonAgenda, Properties.Resources.cal_2);
            PrepararBotonMenu(TurismoButtonRutas, Properties.Resources.map_2);
            PrepararBotonMenu(TurismoButtonMinijuego, Properties.Resources.jue_2);
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
            panelTopMenu.BackgroundImage = Properties.Resources.madera_1;
            panelTopMenu.BackgroundImageLayout = ImageLayout.Stretch;

            panelContent.BackgroundImage = Properties.Resources.fondoestablo11;
            panelContent.BackgroundImageLayout = ImageLayout.Stretch;

            RepositorioCaballos.CargarDesdeJson();

            SeleccionarBoton(TurismoButtonRegistrar);
            CambiarPantalla(new TurismoRegistrarCaballo());
        }

        // ----- configurar botones (solo tamaño + texto más compacto) -----
        private void PrepararBotonMenu(Button b, Image botonImg)
        {
            Image baseImg = AjustarBrillo(botonImg, BrilloBase);
            Image hoverImg = AjustarBrillo(botonImg, BrilloHover);
            Image selectedImg = AjustarBrillo(botonImg, BrilloSeleccionado);

            b.Tag = Tuple.Create(baseImg, hoverImg, selectedImg);

            b.UseVisualStyleBackColor = false;
            b.BackColor = Color.Transparent;

            b.BackgroundImage = baseImg;
            b.BackgroundImageLayout = ImageLayout.Stretch;

            b.FlatStyle = FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseOverBackColor = Color.Transparent;
            b.FlatAppearance.MouseDownBackColor = Color.Transparent;

            b.TabStop = false;

            // Más pequeño (para que entre en barra baja)
            b.TextAlign = ContentAlignment.BottomCenter;
            b.Font = ObtenerFuenteMenu(12F, FontStyle.Bold);
            b.Padding = new Padding(8, 8, 8, 4);
            b.ForeColor = ColorTextoMenu;

            b.MouseEnter -= Boton_MouseEnter;
            b.MouseLeave -= Boton_MouseLeave;
            b.MouseEnter += Boton_MouseEnter;
            b.MouseLeave += Boton_MouseLeave;
        }

        private static Font ObtenerFuenteMenu(float size, FontStyle style)
        {
            string[] fuentes = { "Georgia", "Cambria", "Palatino Linotype", "Segoe UI" };

            foreach (var f in fuentes)
            {
                try { return new Font(f, size, style); }
                catch { }
            }

            return new Font(FontFamily.GenericSansSerif, size, style);
        }

        private void Boton_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is not Button b) return;
            if (ReferenceEquals(b, _btnSeleccionado)) return;

            if (b.Tag is Tuple<Image, Image, Image> imgs)
                b.BackgroundImage = imgs.Item2;
        }

        private void Boton_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is not Button b) return;
            if (ReferenceEquals(b, _btnSeleccionado)) return;

            if (b.Tag is Tuple<Image, Image, Image> imgs)
                b.BackgroundImage = imgs.Item1;
        }

        private void SeleccionarBoton(Button b)
        {
            if (_btnSeleccionado != null && _btnSeleccionado.Tag is Tuple<Image, Image, Image> oldImgs)
                _btnSeleccionado.BackgroundImage = oldImgs.Item1;

            _btnSeleccionado = b;

            if (b.Tag is Tuple<Image, Image, Image> imgs)
                b.BackgroundImage = imgs.Item3;

            try
            {
                ActiveControl = null;
                panelTopMenu.Select();
                panelTopMenu.Focus();
            }
            catch { }
        }

        // ----- ajustar brillo -----
        private Image AjustarBrillo(Image img, float factor)
        {
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                float[][] matrixItems =
                {
                    new float[] {factor, 0, 0, 0, 0},
                    new float[] {0, factor, 0, 0, 0},
                    new float[] {0, 0, factor, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                };

                ColorMatrix matrix = new ColorMatrix(matrixItems);
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix);

                g.DrawImage(
                    img,
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    0, 0, img.Width, img.Height,
                    GraphicsUnit.Pixel,
                    attributes
                );
            }

            return bmp;
        }

        // ----- cambiar pantalla -----
        private void CambiarPantalla(UserControl pantalla)
        {
            panelContent.SuspendLayout();
            try
            {
                panelContent.Controls.Clear();
                pantalla.Dock = DockStyle.Fill;
                panelContent.Controls.Add(pantalla);
                pantalla.BringToFront();
            }
            finally
            {
                panelContent.ResumeLayout(true);
            }
        }

        // ----- botones -----
        private void TurismoButtonRegistrar_Click(object? sender, EventArgs e)
        {
            SeleccionarBoton(TurismoButtonRegistrar);
            CambiarPantalla(new TurismoRegistrarCaballo());
        }

        private void TurismoButtonVer_Click(object? sender, EventArgs e)
        {
            SeleccionarBoton(TurismoButtonVer);
            CambiarPantalla(new TurismoVerRegistro());
        }

        private void TurismoButtonAgenda_Click(object? sender, EventArgs e)
        {
            SeleccionarBoton(TurismoButtonAgenda);

            var agenda = new TurismoAgendaCalendario();
            agenda.Caballos = RepositorioCaballos.ObtenerTodos()
                .Select(c => (c.Nombre ?? "").Trim())
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .ToList();

            CambiarPantalla(agenda);
        }

        private void TurismoButtonRutas_Click(object? sender, EventArgs e)
        {
            SeleccionarBoton(TurismoButtonRutas);
            CambiarPantalla(new TurismoRutas());
        }

        private void TurismoButtonMinijuego_Click(object? sender, EventArgs e)
        {
            SeleccionarBoton(TurismoButtonMinijuego);
            CambiarPantalla(new TurismoMinijuego());
        }

        // ----- activar double buffer -----
        private static void ActivarDoubleBuffer(Control control)
        {
            try
            {
                typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                    ?.SetValue(control, true, null);
            }
            catch { }
        }
    }
}
