using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class saludcaballos : UserControl
    {
        public saludcaballos()
        {
            InitializeComponent();
        }

        private void saludcaballos_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_enfer_Click(object sender, EventArgs e)
        {
            Form_enferme sdl = new Form_enferme();
            sdl.Show();
        }

        private void dgv_enfermedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel_contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_trata_Click(object sender, EventArgs e)
        {
            Form_tratamiento sdl = new Form_tratamiento();
            sdl.Show();
        }

        private void btn_preven_Click(object sender, EventArgs e)
        {
            Form_prevencion sdl = new Form_prevencion();
            sdl.Show();
        }
    }
}
