using Microsoft.VisualBasic.Devices;
using Proyecto_Integrador.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles
{
    public partial class Juego : UserControl
    {
        // Estado del juego
        private List<string> secuenciaCorrecta = new List<string>();
        private List<string> secuenciaUsuario = new List<string>();
        private int nivelActual = 1;
        private bool esperandoInput = false;

        public Juego()
        {
            InitializeComponent();
            ConfigurarUI();
        }

        private void ConfigurarUI()
        {
            // Configurar eventos
            btnComenzarDesafio.Click += BtnComenzarDesafio_Click;
            pnlSecuenciaUsuario.AllowDrop = true;
            pnlSecuenciaUsuario.DragEnter += PnlSecuenciaUsuario_DragEnter;
            pnlSecuenciaUsuario.DragDrop += PnlSecuenciaUsuario_DragDrop;

            // Crear botones de comandos
            CrearBotonesComandos();

            // Inicializar UI
            ActualizarUI();
        }

        private void CrearBotonesComandos()
        {
            string[] comandos = { "Caminar", "Trotar", "Relinchar", "Girar" };
            flpComandos.Controls.Clear();

            foreach (string comando in comandos)
            {
                Button btn = new Button
                {
                    Text = comando,
                    Tag = comando,
                    Size = new Size(120, 55),
                    BackColor = Color.FromArgb(139, 90, 43), // Marrón ecuestre
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    FlatAppearance = { BorderSize = 0 }
                };

                btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(160, 110, 60);
                btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(139, 90, 43);

                btn.MouseDown += (s, e) => {
                    if (esperandoInput)
                        btn.DoDragDrop(comando, DragDropEffects.Copy);
                };

                flpComandos.Controls.Add(btn);
            }
        }

        private void BtnComenzarDesafio_Click(object sender, EventArgs e)
        {
            GenerarYMostrarSecuencia();
        }

        private async void GenerarYMostrarSecuencia()
        {
            // Limpiar estado anterior
            LimpiarJuego();
            btnComenzarDesafio.Enabled = false;
            esperandoInput = false;

            // Generar secuencia
            GenerarSecuencia();

            // Mostrar secuencia
            await MostrarAnimacionSecuencia();

            // Permitir input del usuario
            esperandoInput = true;
            lblInstrucciones.Text = "¡REPITELO! Arrastra los movimientos en orden.";
            btnComenzarDesafio.Enabled = true;
        }

        private void GenerarSecuencia()
        {
            string[] opciones = { "Caminar", "Trotar", "Relinchar", "Girar" };
            Random rnd = new Random();

            // Cantidad de pasos según nivel: Nivel 1=2, Nivel 2=3, etc
            int cantidad = 1 + nivelActual;

            for (int i = 0; i < cantidad; i++)
            {
                secuenciaCorrecta.Add(opciones[rnd.Next(opciones.Length)]);
            }
        }

        private async Task MostrarAnimacionSecuencia()
        {
            lblInstrucciones.Text = "OBSERVA AL CABALLO...";
            esperandoInput = false;

            foreach (string paso in secuenciaCorrecta)
            {
                // Mostrar movimiento
                MostrarMovimientoCaballo(paso);
                lblFeedback.Text = $"🐴 {paso.ToUpper()}";
                lblFeedback.BackColor = Color.FromArgb(173, 216, 230);

                int duracion = Math.Max(600, 1800 - (nivelActual * 150));
                await Task.Delay(duracion);

                // Volver a reposo
                MostrarMovimientoCaballo("Reposo");
                lblFeedback.Text = "...";
                await Task.Delay(300);
            }
        }

        private void MostrarMovimientoCaballo(string movimiento)
        {
            try
            {
                string nombreRecurso = "Caballo_" + movimiento;
                object img = Proyecto_Integrador.Properties.Resources.ResourceManager.GetObject(nombreRecurso);

                if (img != null && img is Image)
                {
                    pbCaballoJuego.Image = (Image)img;
                }
                else
                {
                    // Imagen por defecto
                    if (CaballoSeleccionado.HayCaballoSeleccionado())
                    {
                        object recurso = Proyecto_Integrador.Properties.Resources.ResourceManager
                            .GetObject(CaballoSeleccionado.Actual.ImagenRecurso);
                        if (recurso is Image img2)
                            pbCaballoJuego.Image = img2;
                    }
                }
            }
            catch { /* Ignorar errores de recursos */ }
        }

        private void PnlSecuenciaUsuario_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.StringFormat) && esperandoInput)
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void PnlSecuenciaUsuario_DragDrop(object sender, DragEventArgs e)
        {
            if (!esperandoInput) return;

            string comando = (string)e.Data.GetData(DataFormats.StringFormat);
            AgregarComando(comando);
        }

        private void AgregarComando(string comando)
        {
            // Validar que no nos pasemos del límite
            if (secuenciaUsuario.Count >= secuenciaCorrecta.Count)
                return;

            secuenciaUsuario.Add(comando);

            // Crear bloque visual
            Label lbl = new Label
            {
                Text = $"{secuenciaUsuario.Count}. {comando}",
                Size = new Size(110, 45),
                BackColor = Color.FromArgb(255, 215, 0), // Oro
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Margin = new Padding(5, 8, 5, 0)
            };

            pnlSecuenciaUsuario.Controls.Add(lbl);

            // Validar si completó la secuencia
            if (secuenciaUsuario.Count == secuenciaCorrecta.Count)
            {
                esperandoInput = false;
                ValidarSecuencia();
            }
        }

        private void ValidarSecuencia()
        {
            bool esCorrecta = true;

            // Comparar comando por comando
            for (int i = 0; i < secuenciaCorrecta.Count; i++)
            {
                if (secuenciaUsuario[i] != secuenciaCorrecta[i])
                {
                    esCorrecta = false;
                    break;
                }
            }

            if (esCorrecta)
            {
                lblFeedback.Text = "✓ ¡EXCELENTE!";
                lblFeedback.BackColor = Color.FromArgb(144, 238, 144);
                nivelActual++;
                ActualizarProgreso();

                if (nivelActual > 10)
                {
                    MessageBox.Show("¡🎉 FELICIDADES! ¡Has completado todos los niveles!",
                        "¡GANASTE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReiniciarJuego();
                }
                else
                {
                    MessageBox.Show($"¡Bien hecho! Nivel {nivelActual} desbloqueado.",
                        "SIGUIENTE NIVEL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnComenzarDesafio.Enabled = true;
                }
            }
            else
            {
                lblFeedback.Text = "✗ INCORRECTO";
                lblFeedback.BackColor = Color.FromArgb(255, 99, 71);
                MessageBox.Show("El caballo no entendió el comando. ¡Inténtalo de nuevo!",
                    "SECUENCIA INCORRECTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                // Limpiar solo la entrada del usuario
                secuenciaUsuario.Clear();
                pnlSecuenciaUsuario.Controls.Clear();
                btnComenzarDesafio.Enabled = true;
            }
        }

        private void LimpiarJuego()
        {
            secuenciaCorrecta.Clear();
            secuenciaUsuario.Clear();
            pnlSecuenciaUsuario.Controls.Clear();
            lblFeedback.Text = "Esperando...";
            lblFeedback.BackColor = Color.LightGray;
        }

        private void ActualizarProgreso()
        {
            int porcentaje = Math.Min(100, nivelActual * 10);
            progressBar1.Value = porcentaje;
            lblNivel.Text = $"Nivel {nivelActual}";
        }

        private void ActualizarUI()
        {
            lblNivel.Text = $"Nivel {nivelActual}";
            progressBar1.Value = (nivelActual - 1) * 10;
            lblFeedback.Text = "Esperando inicio...";
        }

        private void ReiniciarJuego()
        {
            nivelActual = 1;
            LimpiarJuego();
            ActualizarUI();
            btnComenzarDesafio.Enabled = true;

            if (CaballoSeleccionado.HayCaballoSeleccionado())
            {
                object recurso = Proyecto_Integrador.Properties.Resources.ResourceManager
                    .GetObject(CaballoSeleccionado.Actual.ImagenRecurso);
                if (recurso is Image img)
                    pbCaballoJuego.Image = img;
            }
        }
    }
}