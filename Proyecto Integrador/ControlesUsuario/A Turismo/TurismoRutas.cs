using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.A_Turismo
{
    public partial class TurismoRutas : UserControl
    {
        private readonly Dictionary<string, (string titulo, string desc, string servicios, string tiempo, Image? foto)> _info
            = new Dictionary<string, (string, string, string, string, Image?)>();

        public TurismoRutas()
        {
            InitializeComponent();

            // Tags (clave real)
            btnCumbaya.Tag = "Portal Cumbayá";
            btnEsperanza.Tag = "Portal La Esperanza";
            btnArrayanes.Tag = "Portal Los Arrayanes";
            btnLomita.Tag = "Portal La Lomita";
            btnPuembo.Tag = "Puembo";
            btnRutaCumbayaEsperanza.Tag = "Ruta Cumbayá y Esperanza";
            btnRutaArrayanesPuembo.Tag = "Ruta Arrayanes y Puembo";

            // Clicks
            btnCumbaya.Click += Hotspot_Click;
            btnEsperanza.Click += Hotspot_Click;
            btnArrayanes.Click += Hotspot_Click;
            btnLomita.Click += Hotspot_Click;
            btnPuembo.Click += Hotspot_Click;
            btnRutaCumbayaEsperanza.Click += Hotspot_Click;
            btnRutaArrayanesPuembo.Click += Hotspot_Click;

            // Orden visual: mapa atrás, panel adelante
            pictureMapa.SendToBack();
            panelInfo.BringToFront();

            CargarInfoBase();
        }

        private void CargarInfoBase()
        {
            _info["Portal Cumbayá"] = (
                "Portal Cumbayá",
                "Punto de inicio para rutas cortas y paseos cerca del valle.",
                "Servicios:\n- Paseos a caballo\n- Guía local",
                "Recorrido: 30 minutos",
                null
            );

            _info["Portal La Esperanza"] = (
                "Portal La Esperanza",
                "Rancho rústico ideal para cabalgatas.",
                "Servicios:\n- Paseos a caballo\n- Zona de descanso",
                "Recorrido: 35 minutos",
                null
            );

            _info["Portal Los Arrayanes"] = (
                "Portal Los Arrayanes",
                "Zona verde y tranquila, buena para grupos.",
                "Servicios:\n- Paseos a caballo\n- Restaurante campestre",
                "Recorrido: 40 minutos",
                null
            );

            _info["Portal La Lomita"] = (
                "Portal La Lomita",
                "Miradores y ruta con buenas vistas.",
                "Servicios:\n- Paseos a caballo\n- Mirador",
                "Recorrido: 25 minutos",
                null
            );

            _info["Puembo"] = (
                "Puembo",
                "Área con rutas largas y paisajes abiertos.",
                "Servicios:\n- Paseos largos\n- Guía",
                "Recorrido: 50 minutos",
                null
            );

            _info["Ruta Cumbayá y Esperanza"] = (
                "Ruta Cumbayá y Esperanza",
                "Ruta principal marcada en amarillo.",
                "Servicios:\n- Paradas recomendadas\n- Foto spots",
                "Duración: 45 minutos",
                null
            );

            _info["Ruta Arrayanes y Puembo"] = (
                "Ruta Arrayanes y Puembo",
                "Ruta secundaria marcada en azul.",
                "Servicios:\n- Paradas recomendadas\n- Zona verde",
                "Duración: 55 minutos",
                null
            );
        }

        private void Hotspot_Click(object? sender, EventArgs e)
        {
            if (sender is not Button b) return;

            string clave = b.Tag?.ToString() ?? "";

            if (_info.TryGetValue(clave, out var datos))
            {
                lblTitulo.Text = datos.titulo;
                lblDescripcion.Text = datos.desc;
                lblServicios.Text = datos.servicios;
                lblTiempo.Text = datos.tiempo;
                picturePortal.Image = datos.foto;
            }
            else
            {
                lblTitulo.Text = "Sin info";
                lblDescripcion.Text = "No se encontró información para este punto.";
                lblServicios.Text = "";
                lblTiempo.Text = "";
                picturePortal.Image = null;
            }
        }
    }
}
