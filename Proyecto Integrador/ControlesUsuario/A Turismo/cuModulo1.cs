using System;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class cuModulo1 : UserControl
    {
        public cuModulo1()
        {
            InitializeComponent();
        }

        private void CentrarTabla()
        {
            if (TurismopanelContenido == null || TurismotablaCentro == null)
                return;

            TurismotablaCentro.Left =
                (TurismopanelContenido.Width - TurismotablaCentro.Width) / 2;

            TurismotablaCentro.Top =
                (TurismopanelContenido.Height - TurismotablaCentro.Height) / 2;
        }

        private void cuModulo1_Load(object sender, EventArgs e)
        {
            CentrarTabla();
        }

        private void TurismopanelContenido_Resize(object sender, EventArgs e)
        {
            CentrarTabla();
        }

        private void TurismoButtonRegistrar_Click(object sender, EventArgs e)
        {
        }

        private void TurismoButtonVer_Click(object sender, EventArgs e)
        {
        }

        private void TurismoButtonAgenda_Click(object sender, EventArgs e)
        {
        }

        private void TurismoButtonMinijuego_Click(object sender, EventArgs e)
        {
        }
    }
}
