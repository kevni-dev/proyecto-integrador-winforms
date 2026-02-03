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

        // Evento que se dispara cuando se hace clic en la tarjeta
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

            // Inicializar botón en rojo (no seleccionado)
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

            // Actualizar nombre
            lblNombre.Text = caballo.Nombre;

            // Actualizar edad
            lblEdad.Text = $"Edad: {caballo.Edad} años";

            // Actualizar raza
            lblRaza.Text = $"Raza: {caballo.Raza}";

            // Actualizar sexo
            lblSexo.Text = $"Sexo: {caballo.Sexo}";

            // Actualizar temperamento
            lblTemperamento.Text = $"Temperamento: {caballo.Temperamento}";

            // Cargar imagen
            CargarImagen();

            // Cambiar color del indicador según temperamento
            pnlIndicador.BackColor = ObtenerColorTemperamento(caballo.Temperamento);
        }

        // Carga la imagen del caballo desde Resources
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

        // Devuelve un color según el temperamento del caballo
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

        // Método público: seleccionar la tarjeta (resaltar)
        public void Seleccionar()
        {
            this.BackColor = Color.FromArgb(220, 200, 160); // Beige resaltado
            btnConfirmacion.BackColor = Color.FromArgb(0, 150, 0); // Verde
            btnConfirmacion.Text = "Sí";
        }

        // Método público: deseleccionar la tarjeta (color normal)
        public void Deseleccionar()
        {
            this.BackColor = Color.FromArgb(245, 237, 220); // Beige normal
            btnConfirmacion.BackColor = Color.FromArgb(200, 0, 0); // Rojo
            btnConfirmacion.Text = "No";
        }

        // Método público: verificar si está seleccionada
        public bool EstaSeleccionada()
        {
            return btnConfirmacion.BackColor == Color.FromArgb(0, 150, 0);
        }
    }
}
