using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador.ControlesUsuario.A_Turismo
{
    public partial class TurismoVerRegistro : UserControl
    {
        private List<Caballo> listaCaballos = new List<Caballo>();
        private readonly BindingSource fuenteCaballos = new BindingSource();

        private bool _recargando = false;
        private bool _inicializando = true;

        private string? _sortProp = null;
        private bool _sortAsc = true;

        private readonly System.Windows.Forms.Timer _tBuscar = new System.Windows.Forms.Timer();

        private string _ultimaClaveImg = "";

        public TurismoVerRegistro()
        {
            InitializeComponent();

            Dock = DockStyle.Fill;
            DoubleBuffered = true;

            // Fondo general (si tienes este recurso, queda brutal)
            try
            {
                BackgroundImage = Properties.Resources.fondoestablo11;
                BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch { }

            // Debounce buscar
            _tBuscar.Interval = 250;
            _tBuscar.Tick += (_, __) =>
            {
                _tBuscar.Stop();
                if (!_inicializando) AplicarFiltroYBusqueda();
            };

            // Eventos
            Load += TurismoVerRegistro_Load;

            txtBuscar.TextChanged += (_, __) =>
            {
                if (_inicializando) return;
                _tBuscar.Stop();
                _tBuscar.Start();
            };

            comboBuscarPor.SelectedIndexChanged += (_, __) => { if (!_inicializando) AplicarFiltroYBusqueda(); };
            comboRaza.SelectedIndexChanged += (_, __) => { if (!_inicializando) AplicarFiltroYBusqueda(); };
            comboSexo.SelectedIndexChanged += (_, __) => { if (!_inicializando) AplicarFiltroYBusqueda(); };
            comboTemperamento.SelectedIndexChanged += (_, __) => { if (!_inicializando) AplicarFiltroYBusqueda(); };

            dataGridCaballos.ColumnHeaderMouseClick += DataGridCaballos_ColumnHeaderMouseClick;
            dataGridCaballos.SelectionChanged += (_, __) =>
            {
                if (_recargando) return;
                MostrarVistaPreviaActual();
            };

            // Botones textura
            PrepararBotonConImagen(btnEditar, Properties.Resources.btn_verde);
            PrepararBotonConImagen(btnEliminar, Properties.Resources.btn_rojo);

            btnEditar.ForeColor = Color.FromArgb(245, 239, 230);
            btnEliminar.ForeColor = Color.FromArgb(245, 239, 230);

            // Preview
            pictureCaballo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCaballo.BackColor = Color.Transparent;
        }

        private async void TurismoVerRegistro_Load(object? sender, EventArgs e)
        {
            if (_recargando) return;

            _recargando = true;
            _inicializando = true;

            panelRoot.Visible = false;
            SuspendLayout();
            panelRoot.SuspendLayout();
            dataGridCaballos.SuspendLayout();

            try
            {
                ConfigurarTabla();
                CargarCombos();

                await Task.Delay(1);

                await Task.Run(() => CargarCaballos());

                AplicarFiltroYBusqueda();
                MostrarVistaPreviaActual();
            }
            finally
            {
                dataGridCaballos.ResumeLayout(true);
                panelRoot.ResumeLayout(true);
                ResumeLayout(true);

                panelRoot.Visible = true;
                _inicializando = false;
                _recargando = false;
            }
        }

        // -----------------------
        // Estilos
        // -----------------------
        private static void PrepararBotonConImagen(Button btn, Image bg)
        {
            btn.BackgroundImage = bg;
            btn.BackgroundImageLayout = ImageLayout.Stretch;

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn.BackColor = Color.Transparent;
            btn.UseVisualStyleBackColor = false;
        }

        private void ConfigurarTabla()
        {
            dataGridCaballos.AutoGenerateColumns = true;
            dataGridCaballos.ReadOnly = true;
            dataGridCaballos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCaballos.MultiSelect = false;

            dataGridCaballos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCaballos.RowHeadersVisible = false;
            dataGridCaballos.AllowUserToAddRows = false;
            dataGridCaballos.AllowUserToDeleteRows = false;
            dataGridCaballos.AllowUserToResizeRows = false;

            // Estilo tipo pergamino
            dataGridCaballos.BackgroundColor = Color.FromArgb(235, 230, 220);
            dataGridCaballos.BorderStyle = BorderStyle.None;
            dataGridCaballos.GridColor = Color.FromArgb(205, 195, 180);
            dataGridCaballos.EnableHeadersVisualStyles = false;

            dataGridCaballos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 215, 200);
            dataGridCaballos.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(60, 40, 25);
            dataGridCaballos.ColumnHeadersDefaultCellStyle.Font = new Font("Georgia", 11F, FontStyle.Bold);
            dataGridCaballos.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridCaballos.ColumnHeadersHeight = 38;

            dataGridCaballos.DefaultCellStyle.BackColor = Color.FromArgb(245, 241, 234);
            dataGridCaballos.DefaultCellStyle.ForeColor = Color.FromArgb(35, 25, 18);
            dataGridCaballos.DefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            dataGridCaballos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(170, 160, 135);
            dataGridCaballos.DefaultCellStyle.SelectionForeColor = Color.White;

            dataGridCaballos.RowTemplate.Height = 34;

            // DoubleBuffered (para que no parpadee)
            try
            {
                typeof(DataGridView).InvokeMember("DoubleBuffered",
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
                    null, dataGridCaballos, new object[] { true });
            }
            catch { }

            // DataSource una sola vez
            dataGridCaballos.DataSource = fuenteCaballos;
        }

        private void CargarCombos()
        {
            comboBuscarPor.Items.Clear();
            comboBuscarPor.Items.AddRange(new object[] { "Nombre", "Raza", "Sexo", "Temperamento", "Imagen", "Todos" });
            comboBuscarPor.SelectedIndex = 0;

            comboRaza.Items.Clear();
            comboRaza.Items.AddRange(new object[] { "Todos", "Árabe", "Criollo", "Cuarto de milla" });
            comboRaza.SelectedIndex = 0;

            comboSexo.Items.Clear();
            comboSexo.Items.AddRange(new object[] { "Todos", "Macho", "Hembra" });
            comboSexo.SelectedIndex = 0;

            comboTemperamento.Items.Clear();
            comboTemperamento.Items.AddRange(new object[] { "Todos", "Tranquilo", "Nervioso", "Agresivo", "Activo" });
            comboTemperamento.SelectedIndex = 0;
        }

        private void CargarCaballos()
        {
            var datos = RepositorioCaballos.ObtenerTodos();
            listaCaballos = datos ?? new List<Caballo>();
        }

        // -----------------------
        // Filtro + búsqueda
        // -----------------------
        private void AplicarFiltroYBusqueda()
        {
            _recargando = true;
            try
            {
                string texto = (txtBuscar.Text ?? "").Trim();
                string buscarPor = comboBuscarPor.SelectedItem?.ToString() ?? "Nombre";

                IEnumerable<Caballo> query = listaCaballos;

                // Filtros extra
                if (comboRaza.Text != "Todos")
                    query = query.Where(c => (c.Raza ?? "") == comboRaza.Text);

                if (comboSexo.Text != "Todos")
                    query = query.Where(c => (c.Sexo ?? "") == comboSexo.Text);

                if (comboTemperamento.Text != "Todos")
                    query = query.Where(c => (c.Temperamento ?? "") == comboTemperamento.Text);

                // Búsqueda
                if (!string.IsNullOrWhiteSpace(texto))
                {
                    string t = texto.ToLower();

                    query = buscarPor switch
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

                var listaVista = query.ToList();
                listaVista = AplicarOrden(listaVista);

                dataGridCaballos.SuspendLayout();
                try
                {
                    fuenteCaballos.DataSource = listaVista;
                    fuenteCaballos.ResetBindings(false);

                    lblTotal.Text = $"Total: {listaVista.Count}";

                    dataGridCaballos.ClearSelection();
                    if (dataGridCaballos.Rows.Count > 0)
                    {
                        dataGridCaballos.Rows[0].Selected = true;
                        dataGridCaballos.CurrentCell = dataGridCaballos.Rows[0].Cells[0];
                    }

                    AplicarFlechitaSort();
                }
                finally
                {
                    dataGridCaballos.ResumeLayout(true);
                }
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

            if (prop.PropertyType == typeof(int))
            {
                return _sortAsc
                    ? lista.OrderBy(c => (int)(prop.GetValue(c) ?? 0)).ToList()
                    : lista.OrderByDescending(c => (int)(prop.GetValue(c) ?? 0)).ToList();
            }

            return _sortAsc
                ? lista.OrderBy(c => (prop.GetValue(c)?.ToString() ?? "")).ToList()
                : lista.OrderByDescending(c => (prop.GetValue(c)?.ToString() ?? "")).ToList();
        }

        private void DataGridCaballos_ColumnHeaderMouseClick(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;

            var colClick = dataGridCaballos.Columns[e.ColumnIndex];
            if (colClick == null) return;

            string prop = !string.IsNullOrWhiteSpace(colClick.DataPropertyName)
                ? colClick.DataPropertyName
                : colClick.Name;

            if (string.IsNullOrWhiteSpace(prop)) return;

            if (string.Equals(_sortProp, prop, StringComparison.OrdinalIgnoreCase))
                _sortAsc = !_sortAsc;
            else
            {
                _sortProp = prop;
                _sortAsc = true;
            }

            AplicarFiltroYBusqueda();
        }

        private void AplicarFlechitaSort()
        {
            foreach (DataGridViewColumn c in dataGridCaballos.Columns)
                c.HeaderCell.SortGlyphDirection = SortOrder.None;

            if (string.IsNullOrWhiteSpace(_sortProp))
                return;

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
            if (col.DataGridView == null) return;

            col.HeaderCell.SortGlyphDirection = _sortAsc ? SortOrder.Ascending : SortOrder.Descending;
        }

        // -----------------------
        // Selección + preview
        // -----------------------
        private Caballo? CaballoSeleccionado()
        {
            if (_recargando) return null;
            if (dataGridCaballos.SelectedRows.Count == 0) return null;

            var row = dataGridCaballos.SelectedRows[0];
            if (row == null || row.IsNewRow) return null;

            return row.DataBoundItem as Caballo;
        }

        private void MostrarVistaPreviaActual()
        {
            if (_recargando) return;

            var item = CaballoSeleccionado();
            if (item == null)
            {
                pictureCaballo.Image = null;
                lblPrevNombre.Text = "—";
                lblPrevRaza.Text = "—";
                lblPrevEdad.Text = "—";
                lblPrevSexo.Text = "—";
                return;
            }

            lblPrevNombre.Text = item.Nombre ?? "—";
            lblPrevRaza.Text = item.Raza ?? "—";
            lblPrevEdad.Text = $"{item.Edad} años";
            lblPrevSexo.Text = item.Sexo ?? "—";

            string clave = item.ImagenRecurso ?? "";
            if (clave == _ultimaClaveImg) return;
            _ultimaClaveImg = clave;

            if (clave == "Caballo_Cuarto")
                pictureCaballo.Image = Properties.Resources.Caballo_Cuarto;
            else if (clave == "Caballo_Arabe")
                pictureCaballo.Image = Properties.Resources.Caballo_Arabe;
            else if (clave == "Caballo_Criollo")
                pictureCaballo.Image = Properties.Resources.Caballo_Criollo;
            else
                pictureCaballo.Image = null;
        }

        // -----------------------
        // Acciones
        // -----------------------
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

            CargarCaballos();
            AplicarFiltroYBusqueda();
        }
    }
}
