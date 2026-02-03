using Proyecto_Integrador.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles
{
    public partial class TarjetaCaballo : UserControl
    {
        private Caballo caballo;

        // Evento al dar click en la tarjeta
        public event EventHandler TarjetaClick;
        public TarjetaCaballo()
        {
            InitializeComponent();
            this.Click += UCTarjetaCaballo_Click;
            pbImagen.Click += UCTarjetaCaballo_Click;
            lblNombre.Click += UCTarjetaCaballo_Click;
            lblRaza.Click += UCTarjetaCaballo_Click;
            lblSexo.Click += UCTarjetaCaballo_Click;
            lblEdad.Click += UCTarjetaCaballo_Click;
            lblTemperamento.Click += UCTarjetaCaballo_Click;
            pnlIndicador.Click += UCTarjetaCaballo_Click;
            btnConfirmacion.Click += UCTarjetaCaballo_Click;

            btnConfirmacion.BackColor = Color.FromArgb(200, 0, 0);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Browsable(false)]
        public Caballo Caballo
        {
            get { return caballo; }
            set
            {
                caballo = value;
                ActualizarDatos();
            }
        }

        // Actualiza todos los datos visuales de la tarjeta
        private void ActualizarDatos()
        {
            if (caballo == null) return;

            lblNombre.Text = caballo.Nombre;

            lblEdad.Text = $"Edad: {caballo.Edad} años";

            lblRaza.Text = $"Raza: {caballo.Raza}";

            lblSexo.Text = $"Sexo: {caballo.Sexo}";

            lblTemperamento.Text = $"Temperamento: {caballo.Temperamento}";

            CargarImagen();

            pnlIndicador.BackColor = ObtenerColorTemperamento(caballo.Temperamento);
        }

        private void CargarImagen()
        {
            try
            {
                if (!string.IsNullOrEmpty(caballo.ImagenRecurso))
                {
                    var imagen = Properties.Resources.ResourceManager.GetObject(caballo.ImagenRecurso);
                    if (imagen != null && imagen is System.Drawing.Image)
                    {
                        pbImagen.Image = (System.Drawing.Image)imagen;
                    }
                    else
                    {
                        pbImagen.Image = null;
                    }
                }
                else
                {
                    pbImagen.Image = null;
                }
            }
            catch
            {
                pbImagen.Image = null;
            }
        }
        private Color ObtenerColorTemperamento(string temperamento)
        {
            return temperamento.ToLower() switch
            {
                "tranquilo" => Color.FromArgb(0, 150, 0),       // Verde
                "nervioso" => Color.FromArgb(200, 0, 0),        // Rojo
                "agresivo" => Color.FromArgb(150, 0, 0),        // Rojo oscuro
                "dócil" => Color.FromArgb(0, 120, 200),         // Azul
                "enérgico" => Color.FromArgb(255, 165, 0),      // Naranja
                "activo" => Color.FromArgb(255, 200, 0),        // Amarillo
                "tímido" => Color.FromArgb(150, 150, 200),      // Lila
                "dominante" => Color.FromArgb(100, 50, 150),    // Morado
                _ => Color.Gray
            };
        }

        // Maneja el evento de clic en cualquier parte de la tarjeta
        private void UCTarjetaCaballo_Click(object sender, EventArgs e)
        {
            // Disparar el evento para que ElegirCaballo lo escuche
            TarjetaClick?.Invoke(this, EventArgs.Empty);
        }

        public void Seleccionar()
        {
            this.BackColor = Color.FromArgb(220, 200, 160); // Beige resaltado
            btnConfirmacion.BackColor = Color.FromArgb(0, 150, 0); // Verde
            btnConfirmacion.Text = "Sí";
        }
        public void Deseleccionar()
        {
            this.BackColor = Color.FromArgb(245, 237, 220); // Beige normal
            btnConfirmacion.BackColor = Color.FromArgb(200, 0, 0); // Rojo
            btnConfirmacion.Text = "No";
        }
        public bool EstaSeleccionada()
        {
            return btnConfirmacion.BackColor == Color.FromArgb(0, 150, 0);
        }
    }
}
