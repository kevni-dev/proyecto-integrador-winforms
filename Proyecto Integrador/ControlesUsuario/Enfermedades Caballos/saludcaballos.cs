using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class Saludcaballos : UserControl
    {
        public Saludcaballos()
        {
            InitializeComponent();
            btn_minijuego.Click += btn_minijuego_Click;
        }

        private void saludcaballos_Load(object sender, EventArgs e)
        {
            Archivo.Archivo archivo = new Archivo.Archivo();

        }

        private void btn_enferme_Click(object sender, EventArgs e)
        {
            Enfermedades enfermedades = new Enfermedades();
            enfermedades.ShowDialog();
        }

        private void btn_tratamiento_Click(object sender, EventArgs e)
        {
            frmTratamiento tratamiento = new frmTratamiento();
            tratamiento.ShowDialog();
        }

        private void btn_minijuego_Click(object? sender, EventArgs e)
        {
            panel3.Controls.Clear();

            var juego = new cuSopaEnfermedades();
            juego.Dock = DockStyle.Fill;

            // Para poder salir y volver al módulo
            juego.SalirRequested += (s, args) =>
            {
                panel3.Controls.Clear();
                // Regresa a lo que tenías antes (la tabla)
                dtgv_caballos.Dock = DockStyle.Fill;
                panel3.Controls.Add(dtgv_caballos);
            };

            panel3.Controls.Add(juego);
        }
    }
}
