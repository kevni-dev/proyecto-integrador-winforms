using System;
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

            // Anti-parpadeo
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();

            CargarCombos();

            comboBoxImagen.SelectedIndexChanged += ComboBoxImagen_SelectedIndexChanged;
            comboBoxRaza.SelectedIndexChanged += ComboBoxRaza_SelectedIndexChanged;
        }

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

            // IMÁGENES (clave -> recurso)
            comboBoxImagen.Items.Clear();
            comboBoxImagen.Items.Add("Caballo_Arabe");
            comboBoxImagen.Items.Add("Caballo_Criollo");
            comboBoxImagen.Items.Add("Caballo_Cuarto");

            // defaults
            comboBoxSexo.SelectedIndex = 0;
            comboBoxTemperamento.SelectedIndex = 0;
            comboBoxRaza.SelectedIndex = 0;
            comboBoxImagen.SelectedIndex = 0; // mostrará la imagen
        }

        private void ComboBoxImagen_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string clave = comboBoxImagen.Text;

            if (clave == "Caballo_Cuarto")
                pictureBox1.Image = Properties.Resources.Caballo_Cuarto;
            else if (clave == "Caballo_Arabe")
                pictureBox1.Image = Properties.Resources.Caballo_Arabe;
            else if (clave == "Caballo_Criollo")
                pictureBox1.Image = Properties.Resources.Caballo_Criollo;
            else
                pictureBox1.Image = Properties.Resources.Caballo_Arabe; // fallback
        }

        private void ComboBoxRaza_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Opcional: si quieres que al elegir raza se ponga imagen acorde
            string raza = comboBoxRaza.Text;

            if (raza == "Árabe")
                comboBoxImagen.Text = "Caballo_Arabe";
            else if (raza == "Criollo")
                comboBoxImagen.Text = "Caballo_Criollo";
            else if (raza == "Cuarto de milla")
                comboBoxImagen.Text = "Caballo_Cuarto";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarPresionado?.Invoke(this, EventArgs.Empty);
        }

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
                comboBoxTemperamento.SelectedIndex == -1 ||
                comboBoxImagen.SelectedIndex == -1)
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
                ImagenRecurso = comboBoxImagen.Text
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

        private void LimpiarFormulario()
        {
            textBoxNombre.Clear();
            textBoxEdad.Clear();

            comboBoxRaza.SelectedIndex = 0;
            comboBoxSexo.SelectedIndex = 0;
            comboBoxTemperamento.SelectedIndex = 0;
            comboBoxImagen.SelectedIndex = 0;
        }
    }
}
