using Proyecto_Integrador.Datos;
using Proyecto_Integrador.Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles
{
    public partial class PerfilEmocional : UserControl
    {
        public PerfilEmocional()
        {
            InitializeComponent();

            // IMPORTANTE 1: Suscribirse al evento global para que cuando cambie el caballo
            // en cualquier parte, la parte derecha de esta pantalla se actualice.
            CaballoSeleccionado.CaballoActualizado += (s, e) => {
                if (CaballoSeleccionado.Actual != null)
                {
                    MostrarPerfilEmocional(CaballoSeleccionado.Actual);
                }
            };
        }

        // IMPORTANTE 2: El evento Load ocurre cuando el control se muestra por primera vez.
        // Es el momento perfecto para llenar el FlowLayoutPanel.
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarCaballosEnLista();
        }

        private void CargarCaballosEnLista()
        {
            flpCaballos.Controls.Clear();
            var caballos = RepositorioCaballos.ObtenerTodos();

            foreach (var caballo in caballos)
            {
                TarjetaCaballo tarjeta = new TarjetaCaballo();
                tarjeta.Caballo = caballo;

                tarjeta.TarjetaClick += (s, e) => {
                    foreach (Control c in flpCaballos.Controls)
                    {
                        if (c is TarjetaCaballo t) t.Deseleccionar();
                    }

                    tarjeta.Seleccionar();

                    // Al asignar esto, se dispara el evento 'CaballoActualizado' 
                    // que configuramos en el constructor.
                    CaballoSeleccionado.Actual = caballo;

                    // Actualizamos el label de estado que tienes abajo a la izquierda
                    lblMensajeSeleccion.Text = $"Caballo: {caballo.Nombre}";
                };

                flpCaballos.Controls.Add(tarjeta);
            }
        }

        private void MostrarPerfilEmocional(Caballo caballo)
        {
            if (caballo == null) return;

            var perfil = AnalizadorEmocional.Analizar(caballo);

            // Ocultar mensaje de bienvenida y mostrar los datos reales
            pnlMensajeInicial.Visible = false;
            gbIndicadores.Visible = true;
            gbFactores.Visible = true;
            gbRecomendaciones.Visible = true;

            // Actualizar indicadores principales
            lblEstadoValor.Text = perfil.EstadoGeneral;

            // Asignar valores a ProgressBars (asegúrate que el nombre coincida con tu Designer)
            pbEstres.Value = perfil.NivelEstres;
            lblEstresValor.Text = $"{perfil.NivelEstres}%";

            pbConfianza.Value = perfil.NivelConfianza;
            lblConfianzaValor.Text = $"{perfil.NivelConfianza}%";

            pbActivacion.Value = perfil.NivelActivacion;
            lblActivacionValor.Text = $"{perfil.NivelActivacion}%";

            // Mostrar el análisis de texto y las listas
            // Usamos Environment.NewLine para que los saltos de línea sean correctos en Windows
            lblFactores.Text = string.Join(Environment.NewLine, perfil.FactoresInfluyen);
            lblRecomendaciones.Text = string.Join(Environment.NewLine, perfil.Recomendaciones);
        }
    }
}
