using Proyecto_Integrador.ControlesUsuario.A_Turismo;
using Proyecto_Integrador.Datos;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class cuModulo1 : UserControl
    {
        public cuModulo1()
        {
            InitializeComponent();

            // Anti-parpadeo en el control
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            // Anti-parpadeo en el panel contenedor
            ActivarDoubleBuffer(TurismopanelContenido);
            ActivarDoubleBuffer(panelMenu);
        }

        // Reduce parpadeo cuando hay BackgroundImage 
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void cuModulo1_Load(object sender, EventArgs e)
        {
            RepositorioCaballos.CargarDesdeJson();
            MostrarMenu();
            CentrarMenu();
        }

        private void TurismopanelContenido_Resize(object sender, EventArgs e)
        {
            CentrarMenu();
        }

        private void CentrarMenu()
        {
            if (panelMenu == null || TurismopanelContenido == null) return;

            panelMenu.Left = (TurismopanelContenido.Width - panelMenu.Width) / 2;
            panelMenu.Top = (TurismopanelContenido.Height - panelMenu.Height) / 2;
        }

        private void MostrarMenu()
        {
            panelMenu.Visible = true;
            CentrarMenu();

            // Borra todo lo que NO sea el menú
            for (int i = TurismopanelContenido.Controls.Count - 1; i >= 0; i--)
            {
                Control c = TurismopanelContenido.Controls[i];
                if (c != panelMenu)
                    TurismopanelContenido.Controls.RemoveAt(i);
            }

            panelMenu.BringToFront();
        }

        private void OcultarMenu()
        {
            panelMenu.Visible = false;
        }

        private void CambiarPantalla(UserControl pantalla)
        {
            TurismopanelContenido.SuspendLayout();
            try
            {
                // Quitar todo excepto el menú
                for (int i = TurismopanelContenido.Controls.Count - 1; i >= 0; i--)
                {
                    Control c = TurismopanelContenido.Controls[i];
                    if (c != panelMenu)
                        TurismopanelContenido.Controls.RemoveAt(i);
                }

                pantalla.Dock = DockStyle.Fill;
                TurismopanelContenido.Controls.Add(pantalla);
                pantalla.BringToFront();
            }
            finally
            {
                TurismopanelContenido.ResumeLayout(true);
            }
        }

        private void TurismoButtonRegistrar_Click(object sender, EventArgs e)
        {
            OcultarMenu();

            var registro = new TurismoRegistrarCaballo();
            registro.CancelarPresionado += Registro_Cancelado;
            registro.RegistroExitoso += Registro_Exitoso;

            CambiarPantalla(registro);
        }

        private void TurismoButtonVer_Click(object sender, EventArgs e)
        {
            OcultarMenu();

            var vista = new TurismoVerRegistro();
            CambiarPantalla(vista);
        }

        private void TurismoButtonAgenda_Click(object sender, EventArgs e)
        {
            OcultarMenu();

            var agenda = new TurismoAgendaCalendario();

            // ✅ Caballos reales del JSON
            agenda.Caballos = RepositorioCaballos.ObtenerTodos()
                .Select(c => (c.Nombre ?? "").Trim())
                .Where(n => !string.IsNullOrWhiteSpace(n))
                .ToList();

            CambiarPantalla(agenda);
        }



        private void TurismoButtonMinijuego_Click(object sender, EventArgs e)
        {
            OcultarMenu();

            var mini = new TurismoMinijuego();
            mini.CancelarPresionado += (s, ev) =>
            {
                if (s is Control control && TurismopanelContenido.Controls.Contains(control))
                    TurismopanelContenido.Controls.Remove(control);

                MostrarMenu();
            };

            CambiarPantalla(mini);
        }


        private void TurismoButtonRutas_Click(object sender, EventArgs e)
        {
            OcultarMenu();
            CambiarPantalla(new TurismoRutas());
        }


        private void Registro_Exitoso(object? sender, EventArgs e)
        {
            if (sender is Control control && TurismopanelContenido.Controls.Contains(control))
                TurismopanelContenido.Controls.Remove(control);

            MostrarMenu();
        }

        private void Registro_Cancelado(object? sender, EventArgs e)
        {
            if (sender is Control control && TurismopanelContenido.Controls.Contains(control))
                TurismopanelContenido.Controls.Remove(control);

            MostrarMenu();
        }

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
