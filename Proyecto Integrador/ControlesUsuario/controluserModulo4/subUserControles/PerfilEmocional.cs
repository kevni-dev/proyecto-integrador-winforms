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

            CaballoSeleccionado.CaballoActualizado += (s, e) => {
                if (CaballoSeleccionado.Actual != null)
                {
                    MostrarPerfilEmocional(CaballoSeleccionado.Actual);
                }
            };
        }

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

                    CaballoSeleccionado.Actual = caballo;

                    lblMensajeSeleccion.Text = $"Caballo: {caballo.Nombre}";
                };

                flpCaballos.Controls.Add(tarjeta);
            }
        }

        private void MostrarPerfilEmocional(Caballo caballo)
        {
            if (caballo == null) return;

            var perfil = AnalizadorEmocional.Analizar(caballo);

            pnlMensajeInicial.Visible = false;
            gbIndicadores.Visible = true;
            gbFactores.Visible = true;
            gbRecomendaciones.Visible = true;

            lblEstadoValor.Text = perfil.EstadoGeneral;

            pbEstres.Value = perfil.NivelEstres;
            lblEstresValor.Text = $"{perfil.NivelEstres}%";

            pbConfianza.Value = perfil.NivelConfianza;
            lblConfianzaValor.Text = $"{perfil.NivelConfianza}%";

            pbActivacion.Value = perfil.NivelActivacion;
            lblActivacionValor.Text = $"{perfil.NivelActivacion}%";

            lblFactores.Text = string.Join(Environment.NewLine, perfil.FactoresInfluyen);
            lblRecomendaciones.Text = string.Join(Environment.NewLine, perfil.Recomendaciones);
        }
    }
}
