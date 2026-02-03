using System;
using System.Globalization;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento
{
    public partial class desarrollo1 : UserControl
    {
        public desarrollo1()
        {
            InitializeComponent();
        }

        // ==========================
        // 1) AL CARGAR EL CONTROL
        // ==========================
        private void desarrollo1_Load(object sender, EventArgs e)
        {
            var lista = RepositorioCaballos.ObtenerTodos();

            cmbCaballos.DataSource = null;

            // OJO: si tu propiedad no se llama "Nombre", cámbialo aquí
            cmbCaballos.DisplayMember = "Nombre";
            cmbCaballos.ValueMember = "Nombre";

            cmbCaballos.DataSource = lista;

            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("No hay caballos guardados en el JSON. Registra uno primero.");
            }

            dtHistorial.DataSource = null;
            SetAlerta("");
        }

        // ==========================
        // 2) CLASIFICACIÓN POR EDAD
        // (edad viene desde el JSON del caballo)
        // ==========================
        private string CalcularClasificacion(int edad)
        {
            if (edad < 2)
                return "Potro";
            else if (edad <= 5)
                return "Juvenil";
            else
                return "Adulto";
        }

        // ==========================
        // 3) MOSTRAR IMAGEN SEGÚN ETAPA
        // ==========================
        private void MostrarImagen(string clasificacion)
        {
            if (clasificacion == "Potro")
                picCaballo.Image = Properties.Resources.potro;
            else if (clasificacion == "Juvenil")
                picCaballo.Image = Properties.Resources.juvenil;
            else if (clasificacion == "Adulto")
                picCaballo.Image = Properties.Resources.adulto;
        }

        // ==========================
        // 4) VALIDAR DATOS DE ENTRADA
        // (ya no validamos edad porque ahora es observación)
        // ==========================
        private bool ValidarDatos(out double peso, out string alimentacion, out string observacion)
        {
            peso = 0;
            alimentacion = txtAlimentacion.Text?.Trim() ?? "";
            observacion = txtEdad.Text?.Trim() ?? ""; // txtEdad ahora es OBSERVACIÓN

            // 1) caballo seleccionado
            if (cmbCaballos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un caballo primero.");
                return false;
            }

            // 2) peso válido (coma o punto)
            string pesoTxt = (txtPeso.Text ?? "").Trim();
            if (!double.TryParse(pesoTxt, NumberStyles.Any, CultureInfo.CurrentCulture, out peso) &&
                !double.TryParse(pesoTxt, NumberStyles.Any, CultureInfo.InvariantCulture, out peso))
            {
                MessageBox.Show("Ingrese un peso válido (número).");
                return false;
            }

            if (peso < 30 || peso > 1200)
            {
                MessageBox.Show("El peso debe estar entre 30 y 1200 kg.");
                return false;
            }

            // 3) alimentación válida
            if (string.IsNullOrWhiteSpace(alimentacion))
            {
                MessageBox.Show("Ingrese la alimentación del caballo.");
                return false;
            }

            if (alimentacion.Length < 3 || alimentacion.Length > 120)
            {
                MessageBox.Show("La alimentación debe tener entre 3 y 120 caracteres.");
                return false;
            }

            // 4) observación: opcional, pero con límite
            if (observacion.Length > 200)
            {
                MessageBox.Show("La observación es muy larga (máximo 200 caracteres).");
                return false;
            }

            return true;
        }

        // ==========================
        // 5) LEER EDAD DEL CABALLO DESDE JSON
        // ==========================
        private bool TryObtenerEdadDelCaballoSeleccionado(out int edad)
        {
            edad = 0;
            if (cmbCaballos.SelectedItem == null) return false;

            // Como no sé el tipo exacto de tu clase Caballo, uso dynamic.
            // Si tu propiedad no se llama "Edad", cambia aquí.
            try
            {
                dynamic c = cmbCaballos.SelectedItem;
                edad = (int)c.Edad;
                return true;
            }
            catch
            {
                return false;
            }
        }

        // ==========================
        // 6) ADVERTENCIAS (por cambio fuerte de peso)
        // ==========================
        private void EvaluarAdvertencias(string nombreCaballo, double peso, string clasificacion)
        {
            SetAlerta("");

            // comparar con el último registro (si existe)
            var anterior = RepositorioCrecimiento.ObtenerUltimoDe(nombreCaballo);

            if (anterior != null && anterior.Peso > 0)
            {
                double cambio = peso - anterior.Peso;
                double porcentaje = (cambio / anterior.Peso) * 100.0;
                double abs = Math.Abs(porcentaje);

                if (abs >= 15)
                {
                    string msg = $"🚨 Alerta: el peso cambió {porcentaje:0.0}% desde el último registro.\n" +
                                 "Recomendación: revisar alimentación y estado general del caballo.";
                    SetAlerta(msg);
                    MessageBox.Show(msg, "Alerta de crecimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (abs >= 8)
                {
                    string msg = $"⚠️ Advertencia: el peso cambió {porcentaje:0.0}% desde el último registro. " +
                                 "Revisa la alimentación y el seguimiento.";
                    SetAlerta(msg);
                }
            }

            // banderas simples por etapa (no diagnóstico)
            if (clasificacion == "Potro" && peso > 700)
                SetAlerta("⚠️ Potro con peso muy alto. Verifica si los datos ingresados son correctos.");

            if (clasificacion == "Adulto" && peso < 250)
                SetAlerta("⚠️ Adulto con peso muy bajo. Se recomienda revisar alimentación y cuidados.");
        }

        // ==========================
        // 7) ALERTA EN PANTALLA
        // ==========================
        private void SetAlerta(string texto)
        {
            lblAlerta.Text = texto;
            lblAlerta.Visible = !string.IsNullOrWhiteSpace(texto);
        }

        // ==========================
        // 8) GUARDAR REGISTRO
        // ==========================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos(out double peso, out string alimentacion, out string observacion))
                return;

            string nombreCaballo = cmbCaballos.Text;

            // edad automática desde JSON (solo para clasificación)
            int edadCaballo;
            string clasificacion;

            if (TryObtenerEdadDelCaballoSeleccionado(out edadCaballo))
            {
                clasificacion = CalcularClasificacion(edadCaballo);
                lblResultadoEdad.Text = edadCaballo + " años"; // mostrar edad real del caballo (ya no editable)
            }
            else
            {
                // por si tu Caballo no tiene Edad
                clasificacion = "Sin datos";
                lblResultadoEdad.Text = "";
            }

            // Mostrar resultados
            lblResultadoPeso.Text = peso + " kg";
            lblResultadoAlimentacion.Text = alimentacion;
            lblResultadoClasificacion.Text = clasificacion;

            // Imagen: si no hay datos, muestra adulto por defecto para no romper
            MostrarImagen(clasificacion == "Sin datos" ? "Adulto" : clasificacion);

            // Advertencias
            EvaluarAdvertencias(nombreCaballo, peso, clasificacion);

            // Guardar historial (requiere que RegistroCrecimiento tenga Observacion)
            RepositorioCrecimiento.Agregar(new RegistroCrecimiento
            {
                NombreCaballo = nombreCaballo,
                Fecha = DateTime.Now,
                Edad = edadCaballo, // se guarda la edad real (si existe) para referencia histórica
                Peso = peso,
                Alimentacion = alimentacion,
                Clasificacion = clasificacion,
                Observacion = observacion
            });

            MessageBox.Show("Registro guardado en el historial.");
            CargarHistorialDelCaballoSeleccionado();
        }

        // ==========================
        // 9) VER HISTORIAL
        // ==========================
        private void btnVerHistorial_Click(object sender, EventArgs e)
        {
            if (cmbCaballos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un caballo primero.");
                return;
            }

            CargarHistorialDelCaballoSeleccionado();
        }

        // ==========================
        // 10) CARGAR HISTORIAL
        // ==========================
        private void CargarHistorialDelCaballoSeleccionado()
        {
            string nombre = cmbCaballos.Text;

            var lista = RepositorioCrecimiento.ObtenerPorCaballo(nombre);

            dtHistorial.DataSource = null;
            dtHistorial.DataSource = lista;

            if (dtHistorial.Columns["NombreCaballo"] != null) dtHistorial.Columns["NombreCaballo"].HeaderText = "Caballo";
            if (dtHistorial.Columns["Fecha"] != null) dtHistorial.Columns["Fecha"].HeaderText = "Fecha";
            if (dtHistorial.Columns["Edad"] != null) dtHistorial.Columns["Edad"].HeaderText = "Edad";
            if (dtHistorial.Columns["Peso"] != null) dtHistorial.Columns["Peso"].HeaderText = "Peso (kg)";
            if (dtHistorial.Columns["Alimentacion"] != null) dtHistorial.Columns["Alimentacion"].HeaderText = "Alimentación";
            if (dtHistorial.Columns["Clasificacion"] != null) dtHistorial.Columns["Clasificacion"].HeaderText = "Clasificación";
            if (dtHistorial.Columns["Observacion"] != null) dtHistorial.Columns["Observacion"].HeaderText = "Observación";
        }

        // ==========================
        // 11) CAMBIO DE CABALLO
        // ==========================
        private void cmbCaballos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCaballos.SelectedIndex == -1) return;

            // limpiar inputs de este módulo
            txtPeso.Clear();
            txtAlimentacion.Clear();
            txtEdad.Clear(); // observación

            // limpiar resultados
            lblResultadoPeso.Text = "";
            lblResultadoAlimentacion.Text = "";
            lblResultadoClasificacion.Text = "";
            picCaballo.Image = null;
            SetAlerta("");

            // cargar historial del caballo seleccionado
            CargarHistorialDelCaballoSeleccionado();

            // mostrar edad (solo referencia) si existe en JSON
            if (TryObtenerEdadDelCaballoSeleccionado(out int edadCaballo))
            {
                string clas = CalcularClasificacion(edadCaballo);
                lblResultadoEdad.Text = edadCaballo + " años";
                lblResultadoClasificacion.Text = clas;
                MostrarImagen(clas);
            }
            else
            {
                lblResultadoEdad.Text = "";
            }
        }

        // ==========================
        // 12) LIMPIAR
        // ==========================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAlimentacion.Clear();
            txtEdad.Clear(); // observación

            lblResultadoEdad.Text = "";
            lblResultadoPeso.Text = "";
            lblResultadoAlimentacion.Text = "";
            lblResultadoClasificacion.Text = "";

            picCaballo.Image = null;
            dtHistorial.DataSource = null;

            SetAlerta("");
        }

        // ==========================
        // 13) DATO CURIOSO
        // ==========================
        private void btnDatoCurioso_Click(object sender, EventArgs e)
        {
            datocurioso uc = new datocurioso();
            uc.ClasificacionCaballo = lblResultadoClasificacion.Text;

            Control parent = this.Parent;
            parent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            parent.Controls.Add(uc);
        }

        // Eventos vacíos del diseñador
        private void lblEdadTexto_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
    }
}
