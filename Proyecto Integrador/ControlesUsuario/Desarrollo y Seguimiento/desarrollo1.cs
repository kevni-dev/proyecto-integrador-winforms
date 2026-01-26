using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento
{
    public partial class desarrollo1 : UserControl
    {
        public desarrollo1()
        {
            InitializeComponent();
        }

        private void desarrollo1_Load(object sender, EventArgs e)
        {
            cmbCaballos.DataSource = null;
            cmbCaballos.DataSource = DatosGlobales.Caballos;
        }

        private void lblEdadTexto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string CalcularClasificacion(int edad)
        {
            if (edad < 2)
                return "Potro";
            else if (edad <= 5)
                return "Juvenil";
            else
                return "Adulto";
        }
        private void MostrarImagen(string clasificacion)
        {
            if (clasificacion == "Potro")
            {
                picCaballo.Image = Properties.Resources.potro;
            }
            else if (clasificacion == "Juvenil")
            {
                picCaballo.Image = Properties.Resources.juvenil;
            }
            else if (clasificacion == "Adulto")
            {
                picCaballo.Image = Properties.Resources.adulto;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //  Validar selección de caballo
            if (cmbCaballos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un caballo primero.");
                return; // detiene la ejecución si no hay caballo seleccionado
            }

            //  Validar edad
            if (!int.TryParse(txtEdad.Text, out int edad))
            {
                MessageBox.Show("Ingrese una edad válida (número entero).");
                return;
            }
            //  Validar peso
            if (!double.TryParse(txtPeso.Text, out double peso))
            {
                MessageBox.Show("Ingrese un peso válido (número).");
                return; // detiene la ejecución si el peso no es válido
            }
            //  Validar alimentación
            string alimentacion = txtAlimentacion.Text; // tomamos lo que escribió el usuario
            if (string.IsNullOrWhiteSpace(alimentacion))
            {
                MessageBox.Show("Ingrese la alimentación del caballo.");
                return; // detiene la ejecución si está vacío
            }
            string clasificacion = CalcularClasificacion(edad);

            lblResultadoEdad.Text = edad + " años";
            lblResultadoPeso.Text = peso + " kg";
            lblResultadoAlimentacion.Text = alimentacion;
            lblResultadoClasificacion.Text = clasificacion;

            // Mostrar imagen
            MostrarImagen(clasificacion);
        }

        private void btnDatoCurioso_Click(object sender, EventArgs e)
        {
            datocurioso uc = new datocurioso();
            uc.ClasificacionCaballo = lblResultadoClasificacion.Text;

            Control parent = this.Parent;
            parent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            parent.Controls.Add(uc);
        }

        private void cmbCaballos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
