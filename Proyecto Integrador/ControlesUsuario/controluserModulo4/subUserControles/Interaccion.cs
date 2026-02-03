using Proyecto_Integrador.Datos;
using Proyecto_Integrador.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Proyecto_Integrador.Properties;
namespace Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles
{
    public partial class Interaccion : UserControl
    {
        private int _nivelEstres;
        private int _nivelEnergia;
        private int _nivelVinculo;
        private Caballo _caballoActual;
        private int _contadorInteracciones = 0;
        private List<string> _datosCuriosos = new List<string> {
    "Los caballos pueden dormir tanto de pie como acostados.",
    "Tienen los ojos más grandes que cualquier otro mamífero terrestre.",
    "No pueden respirar por la boca, solo por la nariz.",
    "Sus orejas pueden girar 180 grados para localizar sonidos.",
    "Un caballo Cuarto de Milla puede correr a más de 88 km/h.",
    "Los caballos usan sus colas para comunicarse y espantar insectos."};
        public Interaccion()
        {
            InitializeComponent();
            ConfigurarBotones();
            btnContinuar.Enabled = false;
            // cambia caballo si eligen otro en modulo uno
            CaballoSeleccionado.CaballoActualizado += (s, e) =>
            {
                if (CaballoSeleccionado.HayCaballoSeleccionado())
                {
                    CargarDatosSesion(CaballoSeleccionado.Actual);
                }
            };
        }
        // Se ejecuta cada vez que se muestra el control
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (CaballoSeleccionado.HayCaballoSeleccionado())
            {
                CargarDatosSesion(CaballoSeleccionado.Actual);
            }
            else
            {
                BloquearControles("Por favor, selecciona un caballo en la pestaña 'Elección'.");
            }
        }

        private void ConfigurarBotones()
        {
            btnCepillar.Click += (s, e) => EjecutarAccion("cepillar");
            btnAlimentar.Click += (s, e) => EjecutarAccion("alimentar");
            btnAcariciar.Click += (s, e) => EjecutarAccion("acariciar");
            btnJugar.Click += (s, e) => EjecutarAccion("jugar");
        }

        private void CargarDatosSesion(Caballo caballo)
        {
            _caballoActual = caballo;
            pnlControles.Enabled = true;

            // 1. Obtener el análisis base de tu lógica de negocio
            var perfil = AnalizadorEmocional.Analizar(caballo);

            // 2. Inicializar variables de sesión basadas en el perfil real
            _nivelEstres = perfil.NivelEstres;
            _nivelEnergia = perfil.NivelActivacion;

            // El vínculo empieza bajo, pero si el caballo es "Dócil" o tiene mucha confianza, empieza mejor
            _nivelVinculo = (int)(perfil.NivelConfianza * 0.3); // Empieza al 30% de su confianza base

            lblNombreCaballo.Text = caballo.Nombre;
            lblFeedback.Text = $"Has comenzado una sesión con {caballo.Nombre}. Su estado es: {perfil.EstadoGeneral}.";
            lblFeedback.BackColor = Color.LightBlue;

            CargarImagenCaballo(caballo.ImagenRecurso);

            ActualizarBarrasUI();
        }

        private void CargarImagenCaballo(string nombreImagen)
        {
            if (string.IsNullOrEmpty(nombreImagen))
            {
                pbFotoPerfil.Image = Properties.Resources.qwer7;
                return;
            }
            object recurso = Proyecto_Integrador.Properties.Resources.ResourceManager.GetObject(nombreImagen);

            if (recurso != null && recurso is Image)
            {
                Image img = (Image)recurso;
                pbFotoPerfil.Image = img;
            }
            else
            {
                pbFotoPerfil.Image = Properties.Resources.qwer7;
            }
        }

        private void EjecutarAccion(string accion)
        {
            if (_caballoActual == null) return;

            if (_nivelEnergia < 10 && accion != "alimentar")
            {
                lblFeedback.Text = $"{_caballoActual.Nombre} no tiene fuerzas. ¡Debes alimentarlo!";
                lblFeedback.BackColor = Color.OrangeRed;
                return;
            }

            string mensaje = "";
            bool accionPositiva = true;

            switch (accion)
            {
                case "cepillar":
                    _nivelEstres -= 15;
                    _nivelVinculo += 5;
                    _nivelEnergia -= 5;
                    mensaje = $"{_caballoActual.Nombre} disfruta el cepillado y se relaja.";
                    break;

                case "alimentar":
                    _nivelEnergia += 30;
                    _nivelVinculo += 2;
                    mensaje = $"Le diste una manzana. {_caballoActual.Nombre} recupera energía.";
                    break;

                case "acariciar":
                    if (_nivelEstres > 50)
                    {
                        _nivelVinculo -= 10;
                        mensaje = $"{_caballoActual.Nombre} se asustó por el contacto. ¡Está muy estresado!";
                        accionPositiva = false;
                    }
                    else
                    {
                        _nivelVinculo += 15;
                        _nivelEstres -= 5;
                        mensaje = $"Acariciaste a {_caballoActual.Nombre}. Se siente seguro contigo.";
                    }
                    break;

                case "jugar":
                    if (_nivelEnergia < 40) {
                        mensaje = "No tiene suficiente energía para jugar ahora.";
                        accionPositiva = false;
                    } else
                    {
                        _nivelEnergia -= 40;
                        _nivelVinculo += 25;
                        _nivelEstres -= 20;
                        mensaje = $"¡Sesión de juego increíble! El vínculo subió mucho.";
                    }
                    break;
            }

            _contadorInteracciones++;
            if (_contadorInteracciones % 3 == 0) 
            {
                Random r = new Random();
                lblDatoCurioso.Text = _datosCuriosos[r.Next(_datosCuriosos.Count)];
            }

            // Clampear valores entre 0 y 100
            LimitarValores();

            // Actualizar UI
            ActualizarBarrasUI();

            // Mostrar Feedback
            lblFeedback.Text = mensaje;
            lblFeedback.BackColor = accionPositiva ? Color.PaleGreen : Color.LightSalmon;

            // Verificar si completó la sesión
            VerificarLogros();
        }

        private void LimitarValores()
        {
            _nivelEstres = Math.Max(0, Math.Min(100, _nivelEstres));
            _nivelEnergia = Math.Max(0, Math.Min(100, _nivelEnergia));
            _nivelVinculo = Math.Max(0, Math.Min(100, _nivelVinculo));
        }

        private void ActualizarBarrasUI()
        {
            pbEstresActual.Value = _nivelEstres;
            lblValEstres.Text = $"{_nivelEstres}%";

            if (_nivelEstres > 70) lblValEstres.ForeColor = Color.Red;
            else if (_nivelEstres < 30) lblValEstres.ForeColor = Color.Green;
            else lblValEstres.ForeColor = Color.Black;

            pbEnergiaActual.Value = _nivelEnergia;
            lblValEnergia.Text = $"{_nivelEnergia}%";

            pbVinculo.Value = _nivelVinculo;
            lblValVinculo.Text = $"{_nivelVinculo}%";

            pbProgresoSesion.Value = _nivelVinculo;
        }

        private void VerificarLogros()
        {
            if (_nivelVinculo >= 100)
            {
                lblFeedback.Text = $"¡Felicidades! Has creado un vínculo perfecto con {_caballoActual.Nombre}.";
                lblFeedback.BackColor = Color.Gold;

                flpAcciones.Enabled = false;

                btnContinuar.Enabled = true;
                btnContinuar.Text = "Nueva Sesión";
                btnContinuar.Size = new Size(120, 40);
                btnContinuar.BackColor = Color.Green;
                btnContinuar.ForeColor = Color.White;
                btnContinuar.FlatStyle = FlatStyle.Flat;

                btnContinuar.Click += (s, e) => {
                    ReiniciarSesion();
                    btnContinuar.Enabled = false;
                    btnContinuar.Text = "";
                    btnContinuar.BackColor = Color.Transparent;
                    btnContinuar.ForeColor = Color.Transparent;
                };

                pnlControles.Controls.Add(btnContinuar);
                btnContinuar.BringToFront();
            }
        }
        private void ReiniciarSesion()
        {
            _nivelVinculo = 0;
            _nivelEstres = 30; 
            _nivelEnergia = 50;
            flpAcciones.Enabled = true;
            _contadorInteracciones = 0;

            ActualizarBarrasUI();
            lblFeedback.Text = "Sesión reiniciada. ¡Comienza de nuevo!";
            lblFeedback.BackColor = Color.LightBlue;
        }
        private void BloquearControles(string mensaje)
        {
            pnlControles.Enabled = false;
            lblNombreCaballo.Text = "Ninguno";
            lblFeedback.Text = mensaje;
            lblFeedback.BackColor = Color.LightGray;
            pbFotoPerfil.Image = null;
            pbCaballoEscenario.Image = null;
        }
    }
}
