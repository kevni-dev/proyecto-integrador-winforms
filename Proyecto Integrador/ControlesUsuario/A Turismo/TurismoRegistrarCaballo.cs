// TurismoRegistrarCaballo.cs
using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class TurismoRegistrarCaballo : UserControl
    {
        public event EventHandler? CancelarPresionado;
        public event EventHandler? RegistroExitoso;

        public TurismoRegistrarCaballo()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;

            // Render más suave
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();

            // Estilo botones
            btnGuardar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(120, 80, 40);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(120, 80, 40);

            // Ajuste visual imagen
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.Transparent;

            // Data combos
            CargarCombos();

            // Imagen por raza
            comboBoxRaza.SelectedIndexChanged += ComboBoxRaza_SelectedIndexChanged;
        }

        // Combos
        private void CargarCombos()
        {
            comboBoxSexo.Items.Clear();
            comboBoxSexo.Items.Add("Macho");
            comboBoxSexo.Items.Add("Hembra");

            comboBoxTemperamento.Items.Clear();
            comboBoxTemperamento.Items.Add("Tranquilo");
            comboBoxTemperamento.Items.Add("Nervioso");
            comboBoxTemperamento.Items.Add("Agresivo");
            comboBoxTemperamento.Items.Add("Activo");

            comboBoxRaza.Items.Clear();
            comboBoxRaza.Items.Add("Árabe");
            comboBoxRaza.Items.Add("Criollo");
            comboBoxRaza.Items.Add("Cuarto de milla");

            comboBoxSexo.SelectedIndex = 0;
            comboBoxTemperamento.SelectedIndex = 0;
            comboBoxRaza.SelectedIndex = 0;

            AplicarImagenPorRaza(comboBoxRaza.Text);
        }

        // Imagen por raza
        private void ComboBoxRaza_SelectedIndexChanged(object? sender, EventArgs e)
        {
            AplicarImagenPorRaza(comboBoxRaza.Text);
        }

        private void AplicarImagenPorRaza(string raza)
        {
            if (raza == "Árabe")
                pictureBox1.Image = Properties.Resources.cab_a;
            else if (raza == "Criollo")
                pictureBox1.Image = Properties.Resources.cab_c;
            else if (raza == "Cuarto de milla")
                pictureBox1.Image = Properties.Resources.cab_m;
            else
                pictureBox1.Image = Properties.Resources.cab_a;
        }

        // Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarPresionado?.Invoke(this, EventArgs.Empty);
        }

        // Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
                Nombre = textBoxNombre.Text.Trim(),
                Edad = edad,
                Raza = comboBoxRaza.Text,
                Sexo = comboBoxSexo.Text,
                Temperamento = comboBoxTemperamento.Text,
                ImagenRecurso = ""
            };

            bool agregado = RepositorioCaballos.Agregar(nuevo);

            if (!agregado)
            {
                MessageBox.Show("No se pudo registrar el caballo (edad inválida o nombre repetido)");
                return;
            }

            MessageBox.Show("Caballo registrado correctamente");
            LimpiarFormulario();

            RegistroExitoso?.Invoke(this, EventArgs.Empty);
        }

        // Limpiar
        private void LimpiarFormulario()
        {
            textBoxNombre.Clear();
            textBoxEdad.Clear();

            comboBoxRaza.SelectedIndex = 0;
            comboBoxSexo.SelectedIndex = 0;
            comboBoxTemperamento.SelectedIndex = 0;

            AplicarImagenPorRaza(comboBoxRaza.Text);
        }
    }
}
