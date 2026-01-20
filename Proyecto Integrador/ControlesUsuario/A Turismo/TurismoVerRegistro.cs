using System;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;


namespace Proyecto_Integrador.ControlesUsuario.A_Turismo

{
    public partial class TurismoVerRegistro : UserControl
    {
        public TurismoVerRegistro()
        {
            InitializeComponent();
            this.Load += TurismoVerRegistro_Load;
        }

        private void TurismoVerRegistro_Load(object? sender, EventArgs e)
        {
            ConfigurarTabla();
            CargarCaballos();
            ConfigurarFiltros();
        }

        private void ConfigurarTabla()
        {
            dataGridCaballos.AutoGenerateColumns = true;
            dataGridCaballos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCaballos.MultiSelect = false;
            dataGridCaballos.ReadOnly = true;
        }

        private void CargarCaballos()
        {
            dataGridCaballos.DataSource = null;
            dataGridCaballos.DataSource = RepositorioCaballos.ObtenerTodos();
        }


        private void ConfigurarFiltros()
        {
            comboFiltro.Items.Clear();
            comboFiltro.Items.Add("Todos");
            comboFiltro.Items.Add("Nombre");
            comboFiltro.Items.Add("Edad");
            comboFiltro.Items.Add("Raza");
            comboFiltro.Items.Add("Sexo");
            comboFiltro.Items.Add("Temperamento");

            comboFiltro.SelectedIndex = 0;
        }
    }
}
