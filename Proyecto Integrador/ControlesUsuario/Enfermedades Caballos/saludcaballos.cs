using Microsoft.VisualBasic.ApplicationServices;
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
            Archivo.Archivo archivo = new Archivo.Archivo();
            
        }

        private void btn_enferme_Click(object sender, EventArgs e)
        {
            Enfermedades enfermedades = new Enfermedades();
            enfermedades.ShowDialog();
        }
    }
}
