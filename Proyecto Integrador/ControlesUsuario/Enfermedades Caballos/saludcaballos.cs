using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class Saludcaballos : UserControl
    {
        private List<Caballo> _caballos = new();

        public Saludcaballos()
        {
            InitializeComponent();

            // Por si no está enganchado en el Designer
            btn_minijuego.Click += btn_minijuego_Click;
            btn_enferme.Click += btn_enferme_Click;
            btn_tratamiento.Click += btn_tratamiento_Click;

            // Doble click en tabla
            dtgv_caballos.CellDoubleClick += dtgv_caballos_CellDoubleClick;
        }

        private void saludcaballos_Load(object sender, EventArgs e)
        {
            // Cargar del JSON
            RepositorioCaballos.CargarDesdeJson();

            // Mostrar tabla por defecto
            MostrarTablaCaballos();
        }

        private void MostrarTablaCaballos()
        {
            // 👇 IMPORTANTE: NO DISPOSE aquí
            panel3.Controls.Clear();

            CargarTablaCaballos();

            dtgv_caballos.Dock = DockStyle.Fill;
            panel3.Controls.Add(dtgv_caballos);
        }

        private void CargarTablaCaballos()
        {
            _caballos = RepositorioCaballos.ObtenerTodos();

            dtgv_caballos.AutoGenerateColumns = true;
            dtgv_caballos.DataSource = null;
            dtgv_caballos.DataSource = _caballos;

            dtgv_caballos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_caballos.MultiSelect = false;
            dtgv_caballos.ReadOnly = true;
            dtgv_caballos.RowHeadersVisible = false;
            dtgv_caballos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Ocultar columnas que no quieres mostrar
            if (dtgv_caballos.Columns["Enfermedades"] != null)
                dtgv_caballos.Columns["Enfermedades"].Visible = false;

            if (dtgv_caballos.Columns["ImagenRecurso"] != null)
                dtgv_caballos.Columns["ImagenRecurso"].Visible = false;
        }

        private void CargarVista(Control vista)
        {
            // 👇 IMPORTANTE: NO DISPOSE aquí
            panel3.Controls.Clear();

            vista.Dock = DockStyle.Fill;
            panel3.Controls.Add(vista);
        }

        private Caballo? ObtenerCaballoSeleccionado()
        {
            if (dtgv_caballos.CurrentRow == null) return null;
            return dtgv_caballos.CurrentRow.DataBoundItem as Caballo;
        }

        private void AbrirEnfermedadesCaballoSeleccionado()
        {
            var caballo = ObtenerCaballoSeleccionado();
            if (caballo == null)
            {
                MessageBox.Show("Selecciona un caballo primero (clic en una fila).");
                return;
            }

            var v = new cuEnfermedadesPorCaballo(caballo);
            v.SalirRequested += (s, a) => MostrarTablaCaballos();
            CargarVista(v);
        }

        private void dtgv_caballos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            AbrirEnfermedadesCaballoSeleccionado();
        }

        private void btn_enferme_Click(object sender, EventArgs e)
        {
            // Si estás viendo otra vista, vuelve a tabla primero
            if (!panel3.Controls.Contains(dtgv_caballos))
            {
                MostrarTablaCaballos();
                MessageBox.Show("Ahora selecciona un caballo (clic en una fila) y vuelve a presionar ENFERMEDADES.\n\nTip: con doble click se abre directo.");
                return;
            }

            AbrirEnfermedadesCaballoSeleccionado();
        }

        private void btn_tratamiento_Click(object sender, EventArgs e)
        {
            var v = new cuTratamientos();
            // si luego agregas SalirRequested en tratamientos:
            // v.SalirRequested += (s,a)=> MostrarTablaCaballos();
            CargarVista(v);
        }

        private void btn_minijuego_Click(object? sender, EventArgs e)
        {
            var juego = new cuSopaEnfermedades();
            juego.SalirRequested += (s, a) => MostrarTablaCaballos();
            CargarVista(juego);
        }
    }
}
