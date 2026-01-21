using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador.ControlesUsuario.A_Turismo
{
    public partial class TurismoVerRegistro : UserControl
    {
        private List<Caballo> listaCaballos = new List<Caballo>();
        private BindingSource fuenteCaballos = new BindingSource();
        private string ultimaColumnaOrden = "";
        private bool ordenAsc = true;


        public TurismoVerRegistro()
        {
            InitializeComponent();

            Load += TurismoVerRegistro_Load;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            dataGridCaballos.SelectionChanged += DataGridCaballos_SelectionChanged;

            dataGridCaballos.ColumnHeaderMouseClick += DataGridCaballos_ColumnHeaderMouseClick; // ✅ NUEVO

            // Si no quieres usar el combo filtro:
            comboFiltro.Visible = false;
        }


        private void TurismoVerRegistro_Load(object? sender, EventArgs e)
        {
            ConfigurarTabla();
            CargarCaballos();
            MostrarVistaPreviaActual();
        }

        private void ConfigurarTabla()
        {
            dataGridCaballos.AutoGenerateColumns = true;
            dataGridCaballos.ReadOnly = true;
            dataGridCaballos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCaballos.MultiSelect = false;

            // Para que ocupe todo el espacio (lo que tú quieres)
            dataGridCaballos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCaballos.RowHeadersVisible = false;

            // Permite ordenar como explorador
            dataGridCaballos.AllowUserToOrderColumns = true;

            // Usar siempre BindingSource
            dataGridCaballos.DataSource = fuenteCaballos;

            // Importante: que el grid permita ordenar por encabezado
            dataGridCaballos.ColumnAdded += (s, e) =>
            {
                e.Column.SortMode = DataGridViewColumnSortMode.Automatic;
            };
        }

        private void CargarCaballos()
        {
            var datos = RepositorioCaballos.ObtenerTodos();

            if (datos == null)
                listaCaballos = new List<Caballo>();
            else
                listaCaballos = datos;

            // Mostrar lista completa
            fuenteCaballos.DataSource = listaCaballos;
        }

        private void TxtBuscar_TextChanged(object? sender, EventArgs e)
        {
            AplicarBusquedaPorNombre();
        }

        private void AplicarBusquedaPorNombre()
        {
            string texto = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(texto))
            {
                fuenteCaballos.DataSource = listaCaballos;
                return;
            }

            var filtrado = listaCaballos
                .Where(c => (c.Nombre ?? "").ToLower().Contains(texto))
                .ToList();

            fuenteCaballos.DataSource = filtrado;
        }

        private void DataGridCaballos_SelectionChanged(object? sender, EventArgs e)
        {
            MostrarVistaPreviaActual();
        }

        private void MostrarVistaPreviaActual()
        {
            if (dataGridCaballos.CurrentRow == null)
            {
                pictureCaballo.Image = null;
                return;
            }

            var item = dataGridCaballos.CurrentRow.DataBoundItem as Caballo;

            if (item == null)
            {
                pictureCaballo.Image = null;
                return;
            }

            // Si ImagenRecurso viene vacío o null
            string clave = item.ImagenRecurso ?? "";

            if (clave == "Caballo_Cuarto")
                pictureCaballo.Image = Properties.Resources.Caballo_Cuarto;
            else if (clave == "Caballo_Arabe")
                pictureCaballo.Image = Properties.Resources.Caballo_Arabe;
            else if (clave == "Caballo_Criollo")
                pictureCaballo.Image = Properties.Resources.Caballo_Criollo;
            else
                pictureCaballo.Image = Properties.Resources.caballito; // fallback opcional
        }

        private void pictureCaballo_Click(object sender, EventArgs e)
        {
            // Si no quieres click, puedes borrar este método y quitar el evento del designer.
        }

        private void DataGridCaballos_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            DataGridViewColumn col = dataGridCaballos.Columns[e.ColumnIndex];

            // Normalmente aquí viene "Nombre", "Edad", etc.
            string campo = col.DataPropertyName;

            if (string.IsNullOrWhiteSpace(campo))
                campo = col.Name;

            // Alternar asc/desc si vuelves a tocar la misma columna
            if (ultimaColumnaOrden == campo)
                ordenAsc = !ordenAsc;
            else
            {
                ultimaColumnaOrden = campo;
                ordenAsc = true;
            }

            // Tomar lo que esté mostrando ahora (filtrado o completo)
            IEnumerable<Caballo>? actual = fuenteCaballos.DataSource as IEnumerable<Caballo>;
            if (actual == null) actual = listaCaballos;

            IEnumerable<Caballo> ordenado;

            if (ordenAsc)
            {
                ordenado = campo switch
                {
                    "Nombre" => actual.OrderBy(c => c.Nombre),
                    "Edad" => actual.OrderBy(c => c.Edad),
                    "Raza" => actual.OrderBy(c => c.Raza),
                    "Sexo" => actual.OrderBy(c => c.Sexo),
                    "Temperamento" => actual.OrderBy(c => c.Temperamento),
                    "ImagenRecurso" => actual.OrderBy(c => c.ImagenRecurso),
                    _ => actual
                };
            }
            else
            {
                ordenado = campo switch
                {
                    "Nombre" => actual.OrderByDescending(c => c.Nombre),
                    "Edad" => actual.OrderByDescending(c => c.Edad),
                    "Raza" => actual.OrderByDescending(c => c.Raza),
                    "Sexo" => actual.OrderByDescending(c => c.Sexo),
                    "Temperamento" => actual.OrderByDescending(c => c.Temperamento),
                    "ImagenRecurso" => actual.OrderByDescending(c => c.ImagenRecurso),
                    _ => actual
                };
            }

            // Reasignar al BindingSource (para que el grid se actualice)
            fuenteCaballos.DataSource = ordenado.ToList();

            // Mantener vista previa consistente
            MostrarVistaPreviaActual();
        }

    }
}
