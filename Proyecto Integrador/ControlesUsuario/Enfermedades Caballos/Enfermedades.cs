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
        string rutaTratamiento;
        public Enfermedades()
        {
            InitializeComponent();
            archivo = new Archivo.Archivo();
            ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Datos\Enfermedades.txt") ;
            rutaTratamiento = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Datos\Tratamientos.txt");
        }
        private void cargarTabla()
        {
            dtgv_enfermedades.Rows.Clear();
            string[] datos = archivo.leerArchivo(ruta);
            if (datos == null) return;
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
        private void eliminarEnfermedad(int id)
        {
            archivo.eliminarLinea(id, ruta);
            string[] tratamientos = archivo.leerArchivo(rutaTratamiento);
            //archivo.limpiarArchivo(rutaTratamiento);
            //for (int i = 0; i < tratamientos.Length; i++)
            //{
            //    string[] tratamiento = tratamientos[i].Split(";");
            //    if (int.Parse(tratamiento[1]) != id)
            //    {
            //        archivo.escribirLinea(rutaTratamiento,tratamientos[i]);
            //    }
            //}
            for (int i = 0; i < tratamientos.Length; i++)
            {
                string[] tratamiento = tratamientos[i].Split(";");
                if (int.Parse(tratamiento[1]) == id)
                {
                    archivo.eliminarLinea(int.Parse(tratamiento[0]), rutaTratamiento);
                }
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_enfermedad.Text.Length <= 0)
            {
                MessageBox.Show("Rellene la enfermedad");
                return;
            }
            if (txt_enfermedad.Text.Length >= 31)
            {
                MessageBox.Show("La longuitud de la enfermedad debe tener menos de 30 caracteres");
                return;
            }
            if (txt_sintomas.Text.Length <= 0)
            {
                MessageBox.Show("Rellene los sintomas");
                return;
            }
            if (txt_sintomas.Text.Length >= 40)
            {
                MessageBox.Show("La longuitd de los síntomas debe tener menos de 40 caracteres");
                return;
            }
            if (txt_descripcion.Text.Length <= 0)
            {
                MessageBox.Show("Rellene la descripción");
                return;
            }
            if (txt_descripcion.Text.Length >= 50)
            {
                MessageBox.Show("La longuitud de la descripción debe tener menos de 50 caracteres");
                return;
            }
            bool editar = txt_id.Text.Length > 0;
            if (editar)
            {
                string datos = txt_id.Text + ";" + txt_enfermedad.Text + ";" + txt_sintomas.Text + ";" + txt_descripcion.Text;
                archivo.editarLinea(int.Parse(txt_id.Text), datos, ruta);
                cargarTabla();
                txt_id.Text = "";
                txt_enfermedad.Text = "";
                txt_sintomas.Text = "";
                txt_descripcion.Text = "";

            }
            else
            {
                int max = obtenerIdMax() + 1;
                string datos = max + ";" + txt_enfermedad.Text + ";" + txt_sintomas.Text + ";" + txt_descripcion.Text + "\n";
                archivo.escribirLinea(ruta, datos);
                cargarTabla();
                txt_id.Text = "";
                txt_enfermedad.Text = "";
                txt_sintomas.Text = "";
                txt_descripcion.Text = "";
            }


        }

        private void txt_sintomas_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgv_enfermedades_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string id = dtgv_enfermedades.Rows[e.RowIndex].Cells[0].Value.ToString();
            string enfermedad = dtgv_enfermedades.Rows[e.RowIndex].Cells[1].Value.ToString();
            string sintomas = dtgv_enfermedades.Rows[e.RowIndex].Cells[2].Value.ToString();
            string descripcion = dtgv_enfermedades.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_enfermedad.Text = enfermedad;
            txt_sintomas.Text = sintomas;
            txt_descripcion.Text = descripcion;
            txt_id.Text = id;
        }

        private void Enfermedades_Load(object sender, EventArgs e)
        {
            cargarTabla();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (txt_id.Text.Length == 0) { return; }
            int id = int.Parse(txt_id.Text);
            eliminarEnfermedad(id);
            cargarTabla();
        }
    }
}
