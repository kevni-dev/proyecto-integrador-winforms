using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class Form_enferme : Form
    {
        public Form_enferme()
        {
            InitializeComponent();
        }

        private void Form_enferme_Load(object sender, EventArgs e)
        {
            Archivos archivos = new Archivos();
            string[] contenido = archivos.leeArchivo("C:\\Users\\patty\\OneDrive\\Escritorio\\Materias UTEQ\\Caballos.txt");
            for (int i = 0; i < contenido.Length; i++)
            {
                dtgv_enfermedades.Rows.Add();

                string linea = contenido[i];
                string[] datos = linea.Split(';');
                for (int j = 0; j < datos.Length; j++)
                {

                    dtgv_enfermedades.Rows[i].Cells[j].Value = datos[j];

                }
            }
        }

        private void dtgv_enfermedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
