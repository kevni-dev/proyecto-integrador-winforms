using Proyecto_Integrador.Datos;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class cuEnfermedadesPorCaballo : UserControl
    {
        public event EventHandler? SalirRequested;

        private readonly Caballo _caballo;

        public cuEnfermedadesPorCaballo(Caballo caballo)
        {
            InitializeComponent();
            _caballo = caballo;

            // ===== Tema =====
            SaludTheme.ApplyRoot(this);

            panelTop.BackColor = Color.Transparent;
            panelTop.Padding = new Padding(12, 10, 12, 10);

            SaludTheme.MakeCard(panelLeft, new Padding(16));
            SaludTheme.MakeCard(panelRight, new Padding(16));

            SaludTheme.StyleTitle(lblCaballo);
            lblTotal.ForeColor = SaludTheme.MutedText;
            lblTotal.Font = new Font("Georgia", 10.5F, FontStyle.Bold);

            lblEnfermedad.ForeColor = SaludTheme.Text;
            lblFecha.ForeColor = SaludTheme.Text;
            lblNotas.ForeColor = SaludTheme.Text;
            lblEnfermedad.Font = new Font("Georgia", 11F, FontStyle.Bold);
            lblFecha.Font = new Font("Georgia", 11F, FontStyle.Bold);
            lblNotas.Font = new Font("Georgia", 11F, FontStyle.Bold);

            SaludTheme.StyleInput(txtEnfermedad);
            txtEnfermedad.Font = new Font("Segoe UI", 12F);
            SaludTheme.StyleInput(txtNotas);
            txtNotas.Font = new Font("Segoe UI", 12F);

            btnVolver.Text = "Volver";
            SaludTheme.StyleWarningButton(btnVolver, SaludTheme.ResBtnAzul);
            btnVolver.ForeColor = Color.White;

            SaludTheme.StylePrimaryButton(btnAgregar, SaludTheme.ResBtnVerde);
            SaludTheme.StyleDangerButton(btnEliminar, SaludTheme.ResBtnRojo);
            SaludTheme.StyleWarningButton(btnMarcarCurada, SaludTheme.ResBtnAmarillo);

            SaludTheme.StyleGrid(dtgvHistorial);

            lblCaballo.Text = $"Enfermedades de: {_caballo.Nombre}";

            // Eventos
            btnVolver.Click += (s, e) => SalirRequested?.Invoke(this, EventArgs.Empty);
            btnAgregar.Click += btnAgregar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnMarcarCurada.Click += btnMarcarCurada_Click;

            dtgvHistorial.SelectionChanged += dtgvHistorial_SelectionChanged;

            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Value = DateTime.Now;
            chkActiva.Checked = true;

            // ===== Layout (evita que las etiquetas queden pegadas / "descuadradas") =====
            void RelayoutLeft()
            {
                try
                {
                    int x = 16;
                    int w = Math.Max(220, panelLeft.ClientSize.Width - (x * 2));
                    int y = 22;

                    lblEnfermedad.Text = "Enfermedad:";
                    lblFecha.Text = "Fecha:";
                    lblNotas.Text = "Notas:";

                    lblEnfermedad.Location = new Point(x, y);
                    txtEnfermedad.Location = new Point(x, y + 26);
                    txtEnfermedad.Width = w;

                    y += 70;
                    lblFecha.Location = new Point(x, y);
                    dtpFecha.Location = new Point(x, y + 26);
                    dtpFecha.Width = w;

                    y += 70;
                    lblNotas.Location = new Point(x, y);
                    txtNotas.Location = new Point(x, y + 26);
                    txtNotas.Width = w;
                    txtNotas.Height = 86;

                    y += 126;
                    chkActiva.Location = new Point(x + 2, y);

                    y += 30;
                    btnAgregar.Location = new Point(x, y);
                    btnAgregar.Width = w;
                    btnAgregar.Height = 36;

                    y += 44;
                    btnEliminar.Location = new Point(x, y);
                    btnEliminar.Width = w;
                    btnEliminar.Height = 36;

                    y += 44;
                    btnMarcarCurada.Location = new Point(x, y);
                    btnMarcarCurada.Width = w;
                    btnMarcarCurada.Height = 36;
                }
                catch { }
            }

            panelLeft.Resize += (_, __) => RelayoutLeft();
            RelayoutLeft();

            RefrescarHistorial();
        }

        // Para cuando se abre desde "Agregar enfermedad" en la vista previa del caballo
        public void PrepararParaAgregar()
        {
            try
            {
                txtEnfermedad.Focus();
                txtEnfermedad.SelectAll();
            }
            catch { }
        }

        private void RefrescarHistorial()
        {
            var data = _caballo.Enfermedades
                .Select((c, idx) => new
                {
                    Index = idx,
                    Enfermedad = c.Nombre,
                    Fecha = c.Fecha.ToString("yyyy-MM-dd"),
                    Activa = c.Activa,
                    Notas = c.Notas
                })
                .ToList();

            dtgvHistorial.AutoGenerateColumns = true;
            dtgvHistorial.DataSource = null;
            dtgvHistorial.DataSource = data;

            if (dtgvHistorial.Columns["Index"] != null)
                dtgvHistorial.Columns["Index"].Visible = false;

            // vista mejor
            dtgvHistorial.ReadOnly = true;
            dtgvHistorial.RowHeadersVisible = false;
            dtgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvHistorial.MultiSelect = false;
            dtgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblTotal.Text = $"Casos: {_caballo.Enfermedades.Count}";
        }

        private void GuardarCambios()
        {
            // Guarda el JSON actualizado
            PersistenciaCaballos.Guardar(RepositorioCaballos.ObtenerTodos());
        }

        private void btnAgregar_Click(object? sender, EventArgs e)
        {
            string nombre = txtEnfermedad.Text.Trim();
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Escribe el nombre de la enfermedad.");
                return;
            }

            var caso = new EnfermedadCaso
            {
                Nombre = nombre,
                Fecha = dtpFecha.Value.Date,
                Notas = txtNotas.Text.Trim(),
                Activa = chkActiva.Checked
            };

            _caballo.Enfermedades.Add(caso);
            GuardarCambios();
            RefrescarHistorial();

            // limpiar
            txtEnfermedad.Text = "";
            txtNotas.Text = "";
            chkActiva.Checked = true;
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Value = DateTime.Now;
        }

        private int? GetSelectedCaseIndex()
        {
            if (dtgvHistorial.CurrentRow == null) return null;
            object? v = dtgvHistorial.CurrentRow.Cells["Index"].Value;
            if (v == null) return null;

            if (int.TryParse(v.ToString(), out int idx)) return idx;
            return null;
        }

        private void btnEliminar_Click(object? sender, EventArgs e)
        {
            var idx = GetSelectedCaseIndex();
            if (idx == null) return;
            if (idx < 0 || idx >= _caballo.Enfermedades.Count) return;

            var r = MessageBox.Show("¿Eliminar este registro?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r != DialogResult.Yes) return;

            _caballo.Enfermedades.RemoveAt(idx.Value);
            GuardarCambios();
            RefrescarHistorial();

            // limpiar selección
            txtEnfermedad.Text = "";
            txtNotas.Text = "";
            chkActiva.Checked = true;
            dtpFecha.Font = new Font("Segoe UI", 12F);
            dtpFecha.Value = DateTime.Now;
        }

        private void btnMarcarCurada_Click(object? sender, EventArgs e)
        {
            var idx = GetSelectedCaseIndex();
            if (idx == null) return;
            if (idx < 0 || idx >= _caballo.Enfermedades.Count) return;

            _caballo.Enfermedades[idx.Value].Activa = false;
            GuardarCambios();
            RefrescarHistorial();
        }

        private void dtgvHistorial_SelectionChanged(object? sender, EventArgs e)
        {
            var idx = GetSelectedCaseIndex();
            if (idx == null) return;
            if (idx < 0 || idx >= _caballo.Enfermedades.Count) return;

            var c = _caballo.Enfermedades[idx.Value];

            txtEnfermedad.Text = c.Nombre;
            dtpFecha.Value = c.Fecha;
            txtNotas.Text = c.Notas;
            chkActiva.Checked = c.Activa;
        }
    }
}
