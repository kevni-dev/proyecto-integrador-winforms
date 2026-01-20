using System;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class TurismoRegistrarCaballo : UserControl
    {
        // EVENTOS
        public event EventHandler? CancelarPresionado;
        public event EventHandler? RegistroExitoso;

        public TurismoRegistrarCaballo()
        {
            InitializeComponent();
            CargarCombos();
        }

        private void CargarCombos()
        {
            comboBoxSexo.Items.Add("Macho");
            comboBoxSexo.Items.Add("Hembra");

            comboBoxTemperamento.Items.Add("Tranquilo");
            comboBoxTemperamento.Items.Add("Nervioso");
            comboBoxTemperamento.Items.Add("Agresivo");

            comboBoxRaza.Items.Add("Árabe");
            comboBoxRaza.Items.Add("Criollo");
            comboBoxRaza.Items.Add("Cuarto de milla");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // 🔥 Avisamos al módulo que se canceló
            CancelarPresionado?.Invoke(this, EventArgs.Empty);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // VALIDACIONES
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Ingrese el nombre");
                return;
            }

            if (!int.TryParse(textBoxEdad.Text, out int edad))
            {
                MessageBox.Show("Edad inválida");
                return;
            }

            if (comboBoxRaza.SelectedIndex == -1 ||
                comboBoxSexo.SelectedIndex == -1 ||
                comboBoxTemperamento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione todos los datos");
                return;
            }

            Caballo nuevo = new Caballo
            {
                Nombre = textBoxNombre.Text!,
                Edad = edad,
                Raza = comboBoxRaza.Text!,
                Sexo = comboBoxSexo.Text!,
                Temperamento = comboBoxTemperamento.Text!
            };

            bool agregado = RepositorioCaballos.Agregar(nuevo);

            if (!agregado)
            {
                MessageBox.Show("No se pudo registrar el caballo");
                return;
            }

            MessageBox.Show("Caballo registrado correctamente");

            // 🔥 SOLO avisamos, NO navegamos aquí
            RegistroExitoso?.Invoke(this, EventArgs.Empty);
        }
    }
}
