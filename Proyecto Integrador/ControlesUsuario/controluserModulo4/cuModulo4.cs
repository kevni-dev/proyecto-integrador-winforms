using Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.cuModulo4
{
    public partial class cuModulo4 : UserControl
    {
        public cuModulo4()
        {
            InitializeComponent();
        }

        private void CargarUserControl(UserControl uc)
        {
            panel3.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }

        private void cuModulo4_Load(object sender, EventArgs e)
        {

        }

        private void btnElegirCaballo_Click_1(object sender, EventArgs e)
        {
            CargarUserControl(new ElegirCaballo());
        }

        private void btnRegistroEmocional_Click(object sender, EventArgs e)
        {
            CargarUserControl(new RegistroEmocional());
        }

        private void cuModulo4_Load_1(object sender, EventArgs e)
        {

        }

        private void btnInteraccion_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Interaccion());
        }
    }
}
