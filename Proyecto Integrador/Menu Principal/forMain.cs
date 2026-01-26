using Proyecto_Integrador.ControlesUsuario.cuModulo4;
using Proyecto_Integrador.ControlesUsuario;
using Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento;
using Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos;

namespace Proyecto_Integrador
{
    public partial class forMain : Form
    {
        private string _t1, _t2, _t3, _t4;

        int menuAbierto = 220;
        int menuCerrado = 80;
        bool menuAfuera = true;

        private void RedondearBoton(Button b, int radio)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90);
            path.AddArc(new Rectangle(b.Width - radio, 0, radio, radio), 270, 90);
            path.AddArc(new Rectangle(b.Width - radio, b.Height - radio, radio, radio), 0, 90);
            path.AddArc(new Rectangle(0, b.Height - radio, radio, radio), 90, 90);
            path.CloseFigure();
            b.Region = new Region(path);
        }


        private readonly string _usuarioActual;

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

            // Tamaño del icono (para que no se vea gigante)

            btnModulo1.Image = new Bitmap(btnModulo1.Image, new Size(36, 36));
            btnModulo2.Image = new Bitmap(btnModulo2.Image, new Size(36, 36));
            btnModulo3.Image = new Bitmap(btnModulo3.Image, new Size(36, 36));
            btnModulo4.Image = new Bitmap(btnModulo4.Image, new Size(36, 36));



            AplicarEstiloSidebar();
            ActualizarMenuVisual();
        }

        private void forMain_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            usuario_label.Text = _usuarioActual;
        }

        private void AplicarEstiloSidebar()
        {
            Button[] botones = { btnModulo1, btnModulo2, btnModulo3, btnModulo4 };

            foreach (var b in botones)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Height = 52;

                b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                b.ForeColor = Color.White;
                b.BackColor = Color.FromArgb(17, 24, 39);

                b.TextAlign = ContentAlignment.MiddleLeft;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
                b.Padding = new Padding(14, 0, 0, 0);
            }

            plModulos.BackColor = Color.FromArgb(17, 24, 39);
            plModulos.Width = menuAbierto;
        }

        private void ActualizarMenuVisual()
        {
            Button[] botones = { btnModulo1, btnModulo2, btnModulo3, btnModulo4 };

            if (menuAfuera) // ABIERTO: imagen + texto (normal)
            {
                btnModulo1.Text = _t1;
                btnModulo2.Text = _t2;
                btnModulo3.Text = _t3;
                btnModulo4.Text = _t4;

                foreach (var b in botones)
                {
                    b.Height = 52;
                    b.FlatAppearance.BorderSize = 0;
                    b.Region = null; // vuelve a cuadrado normal

                    b.Padding = new Padding(14, 0, 0, 0);
                    b.TextAlign = ContentAlignment.MiddleLeft;
                    b.ImageAlign = ContentAlignment.MiddleLeft;
                    b.TextImageRelation = TextImageRelation.ImageBeforeText;
                }
            }
            else // CERRADO: solo icono + borde redondeado
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
                    b.FlatAppearance.BorderColor = Color.FromArgb(55, 65, 81);

                    RedondearBoton(b, 18);
                }
            }
        }


        private void MarcarActivo(Button activo)
        {
            Button[] botones = { btnModulo1, btnModulo2, btnModulo3, btnModulo4 };

            foreach (var b in botones)
                b.BackColor = Color.FromArgb(17, 24, 39);

            activo.BackColor = Color.FromArgb(31, 41, 55);
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
            CargarUserControl(new saludcaballos());
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

        private void cerrarSesion_button_Click(object sender, EventArgs e)
        {
            var login = new FormLogin();
            login.Show();
            Close();
        }

        private void plModulos_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
