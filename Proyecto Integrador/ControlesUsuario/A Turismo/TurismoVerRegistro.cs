using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador.ControlesUsuario.A_Turismo
{
    public partial class TurismoVerRegistro : UserControl
    {
        private List<Caballo> listaCaballos = new List<Caballo>();
        private BindingSource fuenteCaballos = new BindingSource();

        private bool _recargando = false;

        // sorting
        private string? _sortProp = null;
        private bool _sortAsc = true;

        public TurismoVerRegistro()
        {
            InitializeComponent();

            Load += TurismoVerRegistro_Load;

            txtBuscar.TextChanged += (_, __) => AplicarFiltroYBusqueda();
            comboFiltro.SelectedIndexChanged += (_, __) => AplicarFiltroYBusqueda();

            dataGridCaballos.ColumnHeaderMouseClick += DataGridCaballos_ColumnHeaderMouseClick;
            dataGridCaballos.SelectionChanged += (_, __) =>
            {
                if (_recargando) return;
                MostrarVistaPreviaActual();
            };
        }

        private void TurismoVerRegistro_Load(object? sender, EventArgs e)
        {
            ConfigurarTabla();
            CargarFiltros();
            CargarCaballos();
            AplicarFiltroYBusqueda(); // aplica filtro + orden si existe
            MostrarVistaPreviaActual();
        }

        private void ConfigurarTabla()
        {
            dataGridCaballos.AutoGenerateColumns = true;
            dataGridCaballos.ReadOnly = true;
            dataGridCaballos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCaballos.MultiSelect = false;

            dataGridCaballos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCaballos.RowHeadersVisible = false;

            // IMPORTANTE: enlazar UNA sola vez
            dataGridCaballos.DataSource = fuenteCaballos;
        }

        private void CargarFiltros()
        {
            comboFiltro.Items.Clear();
            comboFiltro.Items.AddRange(new object[]
            {
                "Nombre",
                "Raza",
                "Sexo",
                "Temperamento",
                "Imagen",
                "Todos"
            });

            if (comboFiltro.Items.Count > 0)
                comboFiltro.SelectedIndex = 0; // Nombre
        }

        private void CargarCaballos()
        {
            var datos = RepositorioCaballos.ObtenerTodos();
            listaCaballos = datos ?? new List<Caballo>();
        }

        private void AplicarFiltroYBusqueda()
        {
            _recargando = true;
            try
            {
                string texto = (txtBuscar.Text ?? "").Trim();
                string filtro = comboFiltro.SelectedItem?.ToString() ?? "Nombre";

                IEnumerable<Caballo> query = listaCaballos;

                if (!string.IsNullOrWhiteSpace(texto))
                {
                    string t = texto.ToLower();

                    query = filtro switch
                    {
                        "Nombre" => query.Where(c => (c.Nombre ?? "").ToLower().Contains(t)),
                        "Raza" => query.Where(c => (c.Raza ?? "").ToLower().Contains(t)),
                        "Sexo" => query.Where(c => (c.Sexo ?? "").ToLower().Contains(t)),
                        "Temperamento" => query.Where(c => (c.Temperamento ?? "").ToLower().Contains(t)),
                        "Imagen" => query.Where(c => (c.ImagenRecurso ?? "").ToLower().Contains(t)),
                        "Todos" => query.Where(c =>
                            (c.Nombre ?? "").ToLower().Contains(t) ||
                            (c.Raza ?? "").ToLower().Contains(t) ||
                            (c.Sexo ?? "").ToLower().Contains(t) ||
                            (c.Temperamento ?? "").ToLower().Contains(t) ||
                            (c.ImagenRecurso ?? "").ToLower().Contains(t)
                        ),
                        _ => query
                    };
                }

                // aplicar orden si existe
                var listaVista = query.ToList();
                listaVista = AplicarOrden(listaVista);

                // ✅ NO poner DataSource = null (evita que se rompan columnas)
                fuenteCaballos.DataSource = listaVista;
                fuenteCaballos.ResetBindings(false);

                // selección segura
                dataGridCaballos.ClearSelection();
                if (dataGridCaballos.Rows.Count > 0)
                {
                    dataGridCaballos.Rows[0].Selected = true;
                    dataGridCaballos.CurrentCell = dataGridCaballos.Rows[0].Cells[0];
                }

                // flechita segura (buscar columna otra vez)
                AplicarFlechitaSort();
            }
            finally
            {
                _recargando = false;
            }

            MostrarVistaPreviaActual();
        }

        private List<Caballo> AplicarOrden(List<Caballo> lista)
        {
            if (string.IsNullOrWhiteSpace(_sortProp))
                return lista;

            PropertyInfo? prop = typeof(Caballo).GetProperty(_sortProp,
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase);

            if (prop == null)
                return lista;

            // Edad (int) como número
            if (prop.PropertyType == typeof(int))
            {
                return _sortAsc
                    ? lista.OrderBy(c => (int)(prop.GetValue(c) ?? 0)).ToList()
                    : lista.OrderByDescending(c => (int)(prop.GetValue(c) ?? 0)).ToList();
            }

            // texto
            return _sortAsc
                ? lista.OrderBy(c => (prop.GetValue(c)?.ToString() ?? "")).ToList()
                : lista.OrderByDescending(c => (prop.GetValue(c)?.ToString() ?? "")).ToList();
        }

        private void DataGridCaballos_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            var colClick = dataGridCaballos.Columns[e.ColumnIndex];
            if (colClick == null) return;

            // propiedad real (Nombre, Edad, Raza...)
            string prop = !string.IsNullOrWhiteSpace(colClick.DataPropertyName)
                ? colClick.DataPropertyName
                : colClick.Name;

            if (string.IsNullOrWhiteSpace(prop)) return;

            // toggle asc/desc
            if (string.Equals(_sortProp, prop, StringComparison.OrdinalIgnoreCase))
                _sortAsc = !_sortAsc;
            else
            {
                _sortProp = prop;
                _sortAsc = true;
            }

            // vuelve a aplicar todo (filtro + orden)
            AplicarFiltroYBusqueda();
        }

        private void AplicarFlechitaSort()
        {
            // limpiar flechas
            foreach (DataGridViewColumn c in dataGridCaballos.Columns)
                c.HeaderCell.SortGlyphDirection = SortOrder.None;

            if (string.IsNullOrWhiteSpace(_sortProp))
                return;

            // buscar la columna actual que corresponde a _sortProp
            DataGridViewColumn? col = null;

            foreach (DataGridViewColumn c in dataGridCaballos.Columns)
            {
                string prop = !string.IsNullOrWhiteSpace(c.DataPropertyName) ? c.DataPropertyName : c.Name;
                if (string.Equals(prop, _sortProp, StringComparison.OrdinalIgnoreCase))
                {
                    col = c;
                    break;
                }
            }

            if (col == null) return;
            if (col.DataGridView == null) return; // seguridad total

            col.HeaderCell.SortGlyphDirection = _sortAsc ? SortOrder.Ascending : SortOrder.Descending;
        }

        private Caballo? CaballoSeleccionado()
        {
            if (_recargando) return null;

            if (dataGridCaballos.SelectedRows.Count == 0)
                return null;

            var row = dataGridCaballos.SelectedRows[0];
            if (row == null || row.IsNewRow)
                return null;

            return row.DataBoundItem as Caballo;
        }

        private void MostrarVistaPreviaActual()
        {
            if (_recargando) return;

            var item = CaballoSeleccionado();
            if (item == null)
            {
                pictureCaballo.Image = null;
                return;
            }

            string clave = item.ImagenRecurso ?? "";

            if (clave == "Caballo_Cuarto")
                pictureCaballo.Image = Properties.Resources.Caballo_Cuarto;
            else if (clave == "Caballo_Arabe")
                pictureCaballo.Image = Properties.Resources.Caballo_Arabe;
            else if (clave == "Caballo_Criollo")
                pictureCaballo.Image = Properties.Resources.Caballo_Criollo;
            else
                pictureCaballo.Image = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var item = CaballoSeleccionado();
            if (item == null)
            {
                MessageBox.Show("Selecciona un caballo primero.");
                return;
            }

            var ok = MessageBox.Show(
                $"¿Eliminar a \"{item.Nombre}\"?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (ok != DialogResult.Yes) return;

            bool eliminado = RepositorioCaballos.Eliminar(item.Nombre);

            if (!eliminado)
            {
                MessageBox.Show("No se pudo eliminar.");
                return;
            }

            // recargar lista base y reaplicar vista
            CargarCaballos();
            AplicarFiltroYBusqueda();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var item = CaballoSeleccionado();
            if (item == null)
            {
                MessageBox.Show("Selecciona un caballo primero.");
                return;
            }

            string nombreOriginal = item.Nombre ?? "";

            using (var f = new FormEditarCaballo(item))
            {
                if (f.ShowDialog() != DialogResult.OK)
                    return;

                Caballo actualizado = f.CaballoActualizado;

                bool ok = RepositorioCaballos.Actualizar(nombreOriginal, actualizado);

                if (!ok)
                {
                    MessageBox.Show("No se pudo editar (edad inválida o nombre repetido).");
                    return;
                }
            }

            // recargar lista base y reaplicar vista
            CargarCaballos();
            AplicarFiltroYBusqueda();
        }
    }

    // ==================================================
    //  FORM PARA EDITAR
    // ==================================================
    internal class FormEditarCaballo : Form
    {
        public Caballo CaballoActualizado { get; private set; } = new Caballo();

        private TextBox txtNombre = new TextBox();
        private TextBox txtEdad = new TextBox();
        private ComboBox cbRaza = new ComboBox();
        private ComboBox cbSexo = new ComboBox();
        private ComboBox cbTemperamento = new ComboBox();
        private ComboBox cbImagen = new ComboBox();
        private Button btnOk = new Button();
        private Button btnCancel = new Button();

        public FormEditarCaballo(Caballo original)
        {
            Text = "Editar Caballo";
            Width = 420;
            Height = 360;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            Label L(string t, int y)
            {
                var l = new Label { Text = t, Left = 20, Top = y, Width = 120 };
                Controls.Add(l);
                return l;
            }

            void Place(Control c, int y)
            {
                c.Left = 150;
                c.Top = y;
                c.Width = 220;
                Controls.Add(c);
            }

            L("Nombre:", 20); Place(txtNombre, 18);
            L("Edad:", 60); Place(txtEdad, 58);
            L("Raza:", 100); Place(cbRaza, 98);
            L("Sexo:", 140); Place(cbSexo, 138);
            L("Temperamento:", 180); Place(cbTemperamento, 178);
            L("Imagen:", 220); Place(cbImagen, 218);

            cbRaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTemperamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImagen.DropDownStyle = ComboBoxStyle.DropDownList;

            cbRaza.Items.AddRange(new object[] { "Árabe", "Criollo", "Cuarto de milla" });
            cbSexo.Items.AddRange(new object[] { "Macho", "Hembra" });
            cbTemperamento.Items.AddRange(new object[] { "Tranquilo", "Nervioso", "Agresivo", "Activo" });
            cbImagen.Items.AddRange(new object[] { "Caballo_Arabe", "Caballo_Criollo", "Caballo_Cuarto" });

            // cargar datos originales
            txtNombre.Text = original.Nombre ?? "";
            txtEdad.Text = original.Edad.ToString();
            cbRaza.SelectedItem = original.Raza;
            cbSexo.SelectedItem = original.Sexo;
            cbTemperamento.SelectedItem = original.Temperamento;
            cbImagen.SelectedItem = original.ImagenRecurso;

            if (cbRaza.SelectedIndex < 0) cbRaza.SelectedIndex = 0;
            if (cbSexo.SelectedIndex < 0) cbSexo.SelectedIndex = 0;
            if (cbTemperamento.SelectedIndex < 0) cbTemperamento.SelectedIndex = 0;
            if (cbImagen.SelectedIndex < 0) cbImagen.SelectedIndex = 0;

            btnOk.Text = "Guardar";
            btnOk.Left = 150;
            btnOk.Top = 260;
            btnOk.Width = 100;
            btnOk.Click += (_, __) => Guardar();

            btnCancel.Text = "Cancelar";
            btnCancel.Left = 270;
            btnCancel.Top = 260;
            btnCancel.Width = 100;
            btnCancel.Click += (_, __) => { DialogResult = DialogResult.Cancel; Close(); };

            Controls.Add(btnOk);
            Controls.Add(btnCancel);
        }

        
        private void Guardar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Nombre vacío");
                return;
            }

            if (!int.TryParse(txtEdad.Text.Trim(), out int edad))
            {
                MessageBox.Show("Edad inválida");
                return;
            }

            CaballoActualizado = new Caballo
            {
                Nombre = txtNombre.Text.Trim(),
                Edad = edad,
                Raza = cbRaza.Text,
                Sexo = cbSexo.Text,
                Temperamento = cbTemperamento.Text,
                ImagenRecurso = cbImagen.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
