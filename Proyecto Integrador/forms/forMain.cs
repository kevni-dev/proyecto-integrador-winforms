using Proyecto_Integrador.ControlesUsuario;

namespace Proyecto_Integrador
{
    public partial class forMain : Form
    {
        int menuAbierto = 150;
        int menuCerrado = 60;
        bool menuAfuera = true;

        public forMain()
        {
            InitializeComponent();
        }

        private void forMain_Load(object sender, EventArgs e)
        {

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
        }

        private void btnModulo1_Click(object sender, EventArgs e)
        {
            CargarUserControl(new cuModulo1());
        }

        private void CargarUserControl(UserControl uc)
        {
            plContenido.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            plContenido.Controls.Add(uc);
        }

        private void btnModulo2_Click(object sender, EventArgs e)
        {
            CargarUserControl(new cuModulo2());
        }

        private void btnModulo3_Click(object sender, EventArgs e)
        {
            CargarUserControl(new cuModulo3());
        }

        private void btnModulo4_Click(object sender, EventArgs e)
        {
            CargarUserControl(new cuModulo4());
        }
    }
}
