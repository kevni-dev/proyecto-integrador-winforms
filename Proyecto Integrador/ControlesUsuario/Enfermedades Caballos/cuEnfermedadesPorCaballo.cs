using Proyecto_Integrador.Datos;
using System;
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

            lblCaballo.Text = $"Enfermedades de: {_caballo.Nombre}";

            btnVolver.Click += (s, e) => SalirRequested?.Invoke(this, EventArgs.Empty);
            btnAgregar.Click += btnAgregar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnMarcarCurada.Click += btnMarcarCurada_Click;

            dtgvHistorial.SelectionChanged += dtgvHistorial_SelectionChanged;

            dtpFecha.Value = DateTime.Now;
            chkActiva.Checked = true;

            RefrescarHistorial();
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

            dtgvHistorial.ReadOnly = true;
            dtgvHistorial.RowHeadersVisible = false;
            dtgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvHistorial.MultiSelect = false;
            dtgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblTotal.Text = $"Casos: {_caballo.Enfermedades.Count}";
        }

        private void GuardarCambios()
        {

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

            txtEnfermedad.Text = "";
            txtNotas.Text = "";
            chkActiva.Checked = true;
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

            txtEnfermedad.Text = "";
            txtNotas.Text = "";
            chkActiva.Checked = true;
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