using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class frmTratamiento : Form
    {
        Archivo.Archivo archivo;
        string ruta;
        string rutaEnfermedades;

        string[] enfermedades;
        public frmTratamiento()
        {
            InitializeComponent();
            archivo = new Archivo.Archivo();
            ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Datos\Tratamientos.txt");
            rutaEnfermedades = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Datos\Enfermedades.txt");
        }
        private string[] obtenerEnfermedades()
        {
            string[] datos = archivo.leerArchivo(rutaEnfermedades);


            return datos;
        }
        private void cargarEnfermedadesComboBox(string[] enfermedadesS)
        {
            string[] enfermedadesFormateadas = new string[enfermedadesS.Length];
            for (int i = 0; i < enfermedades.Length; i++)
            {

                string[] linea = enfermedades[i].Split(';');
                string enfermedad = linea[0] + ':' + linea[1];
                enfermedadesFormateadas[i] = enfermedad;

            }
            cmb_enfermedades.DataSource = enfermedadesFormateadas;
        }

        private void cargarTabla(string[] enfermedades)
        {
            dtgv_tratamiento.Rows.Clear();
            string[] datos = archivo.leerArchivo(ruta);
            if (datos == null) return;
            for (int i = 0; i < datos.Length; i++)
            {
                dtgv_tratamiento.Rows.Add();
                string[] tratamiento = datos[i].Split(';');
                string nombreEnfermedad = "";
                for (int j = 0; j < enfermedades.Length; j++)
                {
                    string[] enfermedad = enfermedades[j].Split(";");
                    if (enfermedad[0] == tratamiento[1])
                    {
                        nombreEnfermedad = enfermedad[1];
                        break;
                    }

                }

                dtgv_tratamiento.Rows[i].Cells[0].Value = tratamiento[0];
                dtgv_tratamiento.Rows[i].Cells[1].Value = tratamiento[1];
                dtgv_tratamiento.Rows[i].Cells[2].Value = nombreEnfermedad;
                dtgv_tratamiento.Rows[i].Cells[3].Value = tratamiento[2];


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
        private void frmTratamiento_Load(object sender, EventArgs e)
        {
            enfermedades = obtenerEnfermedades();
            if (enfermedades == null) return;
            cargarEnfermedadesComboBox(enfermedades);

            cargarTabla(enfermedades);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            if (txt_tratamiento.Text.Length <= 0)
            {
                MessageBox.Show("Rellene los sintomas");
                return;
            }
            if (txt_tratamiento.Text.Length >= 30)
            {
                MessageBox.Show("La longuitud del tratamiento debe ser menos a 30 caracteres");
                return;
            }

            bool editar = txt_id.Text.Length > 0;
            if (editar)
            {
                string datos = txt_id.Text + ";" + cmb_enfermedades.Text.Split(':')[0] + ";" + txt_tratamiento.Text;
                archivo.editarLinea(int.Parse(txt_id.Text), datos, ruta);
                cargarTabla(enfermedades);
                txt_id.Text = "";
                txt_tratamiento.Text = "";
            }
            else
            {
                int max = obtenerIdMax() + 1;

                string datos = max + ";" + cmb_enfermedades.Text.Split(':')[0] + ";" + txt_tratamiento.Text + "\n";
                archivo.escribirLinea(ruta, datos);
                cargarTabla(enfermedades);
                txt_id.Text = "";
                txt_tratamiento.Text = "";
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
           if (txt_id.Text.Length == 0) { return; }
            int id = int.Parse(txt_id.Text);
            archivo.eliminarLinea(id, ruta);
            cargarTabla(enfermedades);
        }

        private void dtgv_tratamiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string id = dtgv_tratamiento.Rows[e.RowIndex].Cells[0].Value.ToString();
            string tratamiento = dtgv_tratamiento.Rows[e.RowIndex].Cells[3].Value.ToString();
         
            txt_tratamiento.Text = tratamiento;
            txt_id.Text = id;
        }
    }
}
