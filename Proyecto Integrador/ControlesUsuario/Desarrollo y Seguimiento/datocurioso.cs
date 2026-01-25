using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento
{
    public partial class datocurioso : UserControl
    {
        public string ClasificacionCaballo;

        public datocurioso()
        {
            InitializeComponent();
        }

        private void datocurioso_Load(object sender, EventArgs e)
        {
            lblEtapa.Text = "Seleccione una etapa";
            lblInfo.Text = "Presione Potro, Juvenil o Adulto para ver la información correspondiente.";
        }

        private void btnPotro_Click(object sender, EventArgs e)
        {
            lblEtapa.Text = "ETAPA: POTRO";
            lblInfo.Text = "En sus primeros meses su fuente de alimentación será la leche materna, heno de alta calidad y pienso especial para potros, aproximadamente comerá el 2.5% de su peso total al día.";
        }

        private void btnJuvenil_Click(object sender, EventArgs e)
        {
            lblEtapa.Text = "ETAPA: JUVENIL";
            lblInfo.Text = "Debe consumir entre el 2% y 2.5% de su peso vivo en materia seca su dieta debe ser mayoritariamente forraje (60-70%) para mantener la salud del ciego y la microbiota intestinal.";
        }

        private void btnAdulto_Click(object sender, EventArgs e)
        {
            lblEtapa.Text = "ETAPA: ADULTO";
            lblInfo.Text = "Para un caballo adulto su alimentación se basa entre el 80-100% en forraje, heno o alfalfa ( con moderación), en el concentrado ( pienso) es de 0 a 20 kg solo si el forraje no es suficiente para su condición corporal";
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            desarrollo1 uc = new desarrollo1();

            Control parent = this.Parent;
            parent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            parent.Controls.Add(uc);
        }

        private void btnMiniJuego_Click(object sender, EventArgs e)
        {
            JuegoMemorama uc = new JuegoMemorama();

            Control parent = this.Parent;
            parent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            parent.Controls.Add(uc);
        }
    }
}
