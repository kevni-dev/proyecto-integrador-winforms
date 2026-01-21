using Proyecto_Integrador.Archivo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class Enfermedades : Form
    {
        public Enfermedades()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Archivo.Archivo archivo = new Archivo.Archivo();
            string datos = txt_enfermedad.Text + ";" + txt_sintomas.Text + ";" + txt_descripcion.Text;
            archivo.escribirLinea("C:\\Users\\patty\\OneDrive\\Escritorio\\Materias UTEQ\\Enfermedades.txt", datos);
        }
    }
}
