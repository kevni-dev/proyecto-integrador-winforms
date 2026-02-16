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

            btn_minijuego.Click += btn_minijuego_Click;
            btn_enferme.Click += btn_enferme_Click;
            btn_tratamiento.Click += btn_tratamiento_Click;

            dtgv_caballos.CellDoubleClick += dtgv_caballos_CellDoubleClick;
        }

        private void saludcaballos_Load(object sender, EventArgs e)
        {

            RepositorioCaballos.CargarDesdeJson();

            MostrarTablaCaballos();
        }

        private void MostrarTablaCaballos()
        {

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

            if (dtgv_caballos.Columns["Enfermedades"] != null)
                dtgv_caballos.Columns["Enfermedades"].Visible = false;

            if (dtgv_caballos.Columns["ImagenRecurso"] != null)
                dtgv_caballos.Columns["ImagenRecurso"].Visible = false;
        }

        private void CargarVista(Control vista)
        {

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

            if (!panel3.Controls.Contains(dtgv_caballos))
                MostrarTablaCaballos();

            var caballo = ObtenerCaballoSeleccionado();
            if (caballo == null)
            {
                dtgv_caballos.Focus();
                return;
            }

            var v = new cuEnfermedadesPorCaballo(caballo);
            v.SalirRequested += (s, a) => MostrarTablaCaballos();
            CargarVista(v);
        }

        private void btn_tratamiento_Click(object sender, EventArgs e)
        {
            var v = new cuTratamientos();

            CargarVista(v);
        }

        private void btn_prevencion_Click(object sender, EventArgs e)
        {
            var v = new cuPrevencion();
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