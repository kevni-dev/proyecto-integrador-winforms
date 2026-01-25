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
        Archivo.Archivo archivo;
        string ruta;
        public Enfermedades()
        {
            InitializeComponent();
            archivo = new Archivo.Archivo();
            ruta = "C:\\Users\\patty\\OneDrive\\Escritorio\\Materias UTEQ\\Enfermedades.txt";
        }
        private void cargarTabla()
        {
            dtgv_enfermedades.Rows.Clear();
            string[] datos = archivo.leerArchivo(ruta);
            for (int i = 0; i < datos.Length; i++)
            {
                dtgv_enfermedades.Rows.Add();
                string[] linea = datos[i].Split(';');
                for (int j = 0; j < 4; j++)
                {
                    dtgv_enfermedades.Rows[i].Cells[j].Value = linea[j];

                }

            }
        }
        private int obtenerIdMax()
        {
            string[] datos = archivo.leerArchivo(ruta);
            int max = 0;
            for (int i = 0; i < datos.Length; i++)

            {
                string[] linea = datos[i].Split(';');
                int id = int.Parse(linea[0]);
                if (id > max)
                {
                    max = id;
                }
            }
            return max;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_enfermedad.Text.Length <= 0)
            {
                MessageBox.Show("Rellene la enfermedad");
                return;
            }
            if (txt_sintomas.Text.Length <= 0)
            {
                MessageBox.Show("Rellene los sintomas");
                return;
            }
            if (txt_descripcion.Text.Length <= 0)
            {
                MessageBox.Show("Rellene la descripcion");
                return;
            }
            int max = obtenerIdMax() + 1;
            string datos = max + ";" + txt_enfermedad.Text + ";" + txt_sintomas.Text + ";" + txt_descripcion.Text + "\n";
            archivo.escribirLinea(ruta, datos);
            cargarTabla();


        }

        private void txt_sintomas_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_enfermedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Enfermedades_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }
    }
}
