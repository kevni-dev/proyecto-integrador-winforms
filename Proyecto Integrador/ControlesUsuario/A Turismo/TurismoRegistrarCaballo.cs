using System;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class TurismoRegistrarCaballo : UserControl
    {
        public TurismoRegistrarCaballo()
        {
            InitializeComponent();
            this.Load += TurismoRegistrarCaballo_Load;
        }

        private void TurismoRegistrarCaballo_Load(object sender, EventArgs e)
        {
            // Llenar combos (solo una vez)
            comboBoxSexo.Items.Clear();
            comboBoxSexo.Items.Add("Macho");
            comboBoxSexo.Items.Add("Hembra");

            comboBoxRaza.Items.Clear();
            comboBoxRaza.Items.Add("Pura sangre");
            comboBoxRaza.Items.Add("Árabe");
            comboBoxRaza.Items.Add("Criollo");

            comboBoxTemperamento.Items.Clear();
            comboBoxTemperamento.Items.Add("Tranquilo");
            comboBoxTemperamento.Items.Add("Nervioso");
            comboBoxTemperamento.Items.Add("Activo");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el nombre del caballo");
                return;
            }

            int edad;
            if (!int.TryParse(textBoxEdad.Text, out edad))
            {
                MessageBox.Show("La edad debe ser un número válido");
                textBoxEdad.Focus();
                return;
            }

            if (comboBoxRaza.SelectedIndex == -1 ||
                comboBoxSexo.SelectedIndex == -1 ||
                comboBoxTemperamento.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione todos los campos");
                return;
            }

            // Aquí luego puedes guardar en BD o lista
            MessageBox.Show(
                "Caballo registrado correctamente\n\n" +
                "Nombre: " + textBoxNombre.Text + "\n" +
                "Edad: " + edad + "\n" +
                "Raza: " + comboBoxRaza.Text + "\n" +
                "Sexo: " + comboBoxSexo.Text + "\n" +
                "Temperamento: " + comboBoxTemperamento.Text
            );
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void comboBoxRaza_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío por ahora
        }
    }
}
