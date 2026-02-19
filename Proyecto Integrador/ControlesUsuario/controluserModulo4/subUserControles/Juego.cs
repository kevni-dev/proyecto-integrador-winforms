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
        private List<string> secuenciaCorrecta = new List<string>();
        private List<string> secuenciaUsuario = new List<string>();
        private int nivelActual = 1;
        private bool esperandoInput = false;
        private bool juegoIniciado = false;
        private int nivelVinculo = 50; 
        private int nivelesMaximos = 4;
        private string[] comandosDisponibles;
        private bool tooltipOcultadoPorNivel = false;

        private Interaccion instanciaInteraccion;

        public Juego()
        {
            InitializeComponent();
            ConfigurarUI();
        }

        private void ConfigurarUI()
        {
            btnIniciarJuego.Click += BtnIniciarJuego_Click;
            btnComenzarDesafio.Click += BtnComenzarDesafio_Click;
            btnDeshacerAccion.Click += BtnDeshacerAccion_Click;
            btnMostrarManual.Click += BtnMostrarManual_Click;
            cmbDificultad.SelectedIndexChanged += CmbDificultad_SelectedIndexChanged;
            btnReiniciarJuego.Click += BtnReiniciarJuego_Click;
            pnlSecuenciaUsuario.AllowDrop = true;
            pnlSecuenciaUsuario.DragEnter += PnlSecuenciaUsuario_DragEnter;
            pnlSecuenciaUsuario.DragDrop += PnlSecuenciaUsuario_DragDrop;

            // Configurar el panel de secuencia del usuario
            pnlSecuenciaUsuario.AutoScroll = true;
            if (pnlSecuenciaUsuario is FlowLayoutPanel flp)
            {
                flp.FlowDirection = FlowDirection.LeftToRight;
                flp.WrapContents = true;
                flp.AutoSize = false;
            }

            MostrarPantallaInicial();
        }

        private void BtnReiniciarJuego_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(
                "¿Estás seguro de que quieres reiniciar el juego?\n\n" +
                "Se perderá todo el progreso actual y volverás al inicio.\n\n" +
                "⚠️ NOTA: Tu vínculo NO se verá afectado.",
                "🔄 Reiniciar Juego",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                ReiniciarJuegoCompleto();

                MessageBox.Show(
                    "Juego reiniciado exitosamente.\n\n" +
                    $"💚 Tu vínculo actual: {nivelVinculo}%\n\n" +
                    "¡Puedes comenzar de nuevo!",
                    "✓ Reinicio Completo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BuscarInstanciaInteraccion();

            CargarVinculoDesdeInteraccion();

            ActualizarUI();
        }

        private void BuscarInstanciaInteraccion()
        {
            Control parent = this.Parent;
            while (parent != null)
            {
                foreach (Control control in parent.Controls)
                {
                    if (control is Interaccion interaccion)
                    {
                        instanciaInteraccion = interaccion;
                        return;
                    }
                }
                parent = parent.Parent;
            }
        }

        private void CargarVinculoDesdeInteraccion()
        {
            nivelVinculo = CaballoSeleccionado.VinculoActual;
            ConfigurarDificultadesSegunVinculo();
        }

        private void ConfigurarDificultadesSegunVinculo()
        {
            cmbDificultad.Items.Clear();

            if (nivelVinculo >= 50)
            {
                // Ambos modos disponibles
                cmbDificultad.Items.Add("⭐ Fácil");
                cmbDificultad.Items.Add("⭐⭐ Difícil");
                cmbDificultad.SelectedIndex = 0;
                cmbDificultad.Enabled = true;
            }
            else
            {
                // Solo modo fácil disponible
                cmbDificultad.Items.Add("⭐ Fácil");
                cmbDificultad.SelectedIndex = 0;
                cmbDificultad.Enabled = false;
            }
        }

        private void GuardarVinculoEnInteraccion()
        {
            CaballoSeleccionado.VinculoActual = nivelVinculo;
        }

        private void CmbDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (juegoIniciado)
            {
                MessageBox.Show(
                    "No puedes cambiar la dificultad durante el juego.\nReinicia para cambiar la dificultad.",
                    "Cambio de dificultad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string dificultadSeleccionada = cmbDificultad.SelectedItem.ToString();

            if (dificultadSeleccionada.Contains("Fácil"))
            {
                nivelesMaximos = 4;
                comandosDisponibles = new string[] { "Caminar", "Trotar", "Relinchar", "Girar" };
            }
            else 
            {
                nivelesMaximos = 7;
                comandosDisponibles = new string[] { "Caminar", "Trotar", "Relinchar", "Girar", "Saltar", "Galopar" };
            }

            CrearBotonesComandos();
        }

        private void MostrarPantallaInicial()
        {
            juegoIniciado = false;
            tooltipOcultadoPorNivel = false;
            btnComenzarDesafio.Visible = false;
            btnDeshacerAccion.Visible = false;
            btnIniciarJuego.Visible = true;

            lblInstrucciones.Text = "🎮 Selecciona dificultad y presiona INICIAR";
            lblInstrucciones.ForeColor = Color.White;

            lblTooltipComandos.Visible = true;
            lblTooltipSecuencia.Visible = true;

            MostrarInfoCaballo();
        }

        private void MostrarInfoCaballo()
        {
            if (CaballoSeleccionado.HayCaballoSeleccionado())
            {
                var caballo = CaballoSeleccionado.Actual;
                lblInfoCaballo.Text = $"🐴 {caballo.Nombre} - Perfil: {caballo.Temperamento}";
                lblInfoCaballo.Visible = true;

                object recurso = Proyecto_Integrador.Properties.Resources.ResourceManager
                    .GetObject(caballo.ImagenRecurso);
                if (recurso is Image img)
                    pbCaballoJuego.Image = img;
            }
            else
            {
                lblInfoCaballo.Text = "🐴 Caballo de entrenamiento";
                lblInfoCaballo.Visible = true;
            }
        }

        private void BtnIniciarJuego_Click(object sender, EventArgs e)
        {
            juegoIniciado = true;
            btnIniciarJuego.Visible = false;
            btnComenzarDesafio.Visible = true;
            cmbDificultad.Enabled = false;

            lblInstrucciones.Text = "👆 Presiona 'VER SEC.' para comenzar el desafío";
            lblInstrucciones.ForeColor = Color.FromArgb(255, 215, 0);
        }

        private void BtnMostrarManual_Click(object sender, EventArgs e)
        {
            string dificultadActual = cmbDificultad.SelectedItem?.ToString() ?? "";
            string dificultadInfo = dificultadActual.Contains("Fácil")
                ? "⭐ MODO FÁCIL:\n• 4 niveles\n• 4 comandos (Caminar, Trotar, Relinchar, Girar)\n• Acierto: +15% vínculo | Error: -25% vínculo"
                : "⭐⭐ MODO DIFÍCIL:\n• 7 niveles\n• 6 comandos (incluye Saltar y Galopar)\n• Acierto: +10% vínculo | Error: -20% vínculo";

            string manual = $@"📖 MANUAL DEL JUEGO - ENTRENAMIENTO EQUINO

🎯 OBJETIVO:
Ayuda al caballo a aprender secuencias de movimientos observando y repitiendo sus acciones.

{dificultadInfo}

🎮 CÓMO JUGAR:
1. Tu vínculo actual: {nivelVinculo}%
2. Selecciona la dificultad (según tu vínculo)
3. Presiona 'INICIAR' y luego 'VER SEC.' - El caballo mostrará movimientos
4. OBSERVA con atención cada movimiento
5. REPITE la secuencia arrastrando los comandos en orden correcto
6. Usa 'DESHACER' si te equivocas en algún paso

⚠️ SISTEMA DE VÍNCULO:
- El vínculo refleja tu conexión con el caballo
- Cada acierto AUMENTA el vínculo
- Cada error DISMINUYE el vínculo
- Si el vínculo llega a 0% = GAME OVER (reinicio total)
- El vínculo se comparte con la sección de Interacción

🏆 FINALES DIFERENTES:
- Completar con 100% vínculo = ¡LOGRO ESPECIAL!
- Completar con 70-99% = ¡Muy bien!
- Completar con 50-69% = Bien hecho
- Completar con menos de 50% = Puedes mejorar

💡 CONSEJO:
¡Practica en la sección 'Interacción' para aumentar tu vínculo antes de jugar!";

            MessageBox.Show(manual, "📖 MANUAL DE JUEGO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CrearBotonesComandos()
        {
            Dictionary<string, string> descripciones = new Dictionary<string, string>
            {
                { "Caminar", "Paso suave y relajado" },
                { "Trotar", "Movimiento más rápido" },
                { "Relinchar", "Comunicación vocal" },
                { "Girar", "Cambio de dirección" },
                { "Saltar", "Salto sobre obstáculo" },
                { "Galopar", "Máxima velocidad" }
            };

            flpComandos.Controls.Clear();
            flpComandos.Controls.Add(lblTooltipComandos);

            if (comandosDisponibles == null)
            {
                comandosDisponibles = new string[] { "Caminar", "Trotar", "Relinchar", "Girar" };
            }

            foreach (string comando in comandosDisponibles)
            {
                string descripcion = descripciones.ContainsKey(comando) ? descripciones[comando] : comando;

                Button btn = new Button
                {
                    Text = comando,
                    Tag = comando,
                    Size = new Size(120, 55),
                    BackColor = Color.FromArgb(139, 90, 43),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    FlatAppearance = { BorderSize = 0 }
                };

                ToolTip tooltip = new ToolTip();
                tooltip.SetToolTip(btn, $"{comando}\n{descripcion}\n\n💡 Arrastra este comando a la zona de secuencia");

                btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(160, 110, 60);
                btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(139, 90, 43);

                btn.MouseDown += (s, e) => {
                    if (esperandoInput)
                    {
                        btn.DoDragDrop(comando, DragDropEffects.Copy);
                        lblTooltipComandos.Visible = false;
                    }
                };

                flpComandos.Controls.Add(btn);
            }
        }

        private void BtnComenzarDesafio_Click(object sender, EventArgs e)
        {
            GenerarYMostrarSecuencia();
        }

        private void BtnDeshacerAccion_Click(object sender, EventArgs e)
        {
            if (secuenciaUsuario.Count > 0 && esperandoInput)
            {
                secuenciaUsuario.RemoveAt(secuenciaUsuario.Count - 1);

                var labels = pnlSecuenciaUsuario.Controls.OfType<Label>()
                    .Where(l => l != lblInstrucciones && l != lblTooltipSecuencia)
                    .ToList();

                if (labels.Count > 0)
                {
                    var ultimoLabel = labels.Last();
                    pnlSecuenciaUsuario.Controls.Remove(ultimoLabel);
                }

                lblFeedback.Text = "↶ Última acción eliminada";
                lblFeedback.BackColor = Color.FromArgb(255, 200, 100);

                ActualizarBotonDeshacer();
            }
        }

        private void ActualizarBotonDeshacer()
        {
            btnDeshacerAccion.Enabled = secuenciaUsuario.Count > 0 && esperandoInput;
        }

        private async void GenerarYMostrarSecuencia()
        {
            LimpiarJuego();
            btnComenzarDesafio.Enabled = false;
            btnDeshacerAccion.Visible = false;
            esperandoInput = false;

            GenerarSecuencia();
            await MostrarAnimacionSecuencia();

            esperandoInput = true;
            btnDeshacerAccion.Visible = true;
            ActualizarBotonDeshacer();

            lblInstrucciones.Text = "¡REPÍTELO! Arrastra los movimientos en orden 👇";
            lblInstrucciones.ForeColor = Color.FromArgb(255, 215, 0);
            btnComenzarDesafio.Enabled = true;
        }

        private void GenerarSecuencia()
        {
            Random rnd = new Random();
            int cantidad = 1 + nivelActual;

            if (nivelVinculo < 50)
                cantidad = Math.Max(2, cantidad - 1);

            for (int i = 0; i < cantidad; i++)
            {
                secuenciaCorrecta.Add(comandosDisponibles[rnd.Next(comandosDisponibles.Length)]);
            }
        }

        private async Task MostrarAnimacionSecuencia()
        {
            lblInstrucciones.Text = "👀 OBSERVA AL CABALLO CON ATENCIÓN...";
            lblInstrucciones.ForeColor = Color.White;
            esperandoInput = false;

            foreach (string paso in secuenciaCorrecta)
            {
                MostrarMovimientoCaballo(paso);
                lblFeedback.Text = $"🐴 {paso.ToUpper()}";
                lblFeedback.BackColor = Color.FromArgb(173, 216, 230);

                int duracion = Math.Max(800, 2000 - (nivelActual * 100));
                await Task.Delay(duracion);

                MostrarMovimientoCaballo("Reposo");
                lblFeedback.Text = "...";
                await Task.Delay(400);
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
                    if (CaballoSeleccionado.HayCaballoSeleccionado())
                    {
                        object recurso = Proyecto_Integrador.Properties.Resources.ResourceManager
                            .GetObject(CaballoSeleccionado.Actual.ImagenRecurso);
                        if (recurso is Image img2)
                            pbCaballoJuego.Image = img2;
                    }
                }
            }
            catch { }
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
            if (secuenciaUsuario.Count >= secuenciaCorrecta.Count)
                return;

            secuenciaUsuario.Add(comando);

            Label lbl = new Label
            {
                Text = $"{secuenciaUsuario.Count}. {comando}",
                Size = new Size(110, 45),
                BackColor = Color.FromArgb(255, 215, 0),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Margin = new Padding(5, 5, 5, 5),
                AutoSize = false
            };

            pnlSecuenciaUsuario.Controls.Add(lbl);
            pnlSecuenciaUsuario.Refresh();
            pnlSecuenciaUsuario.PerformLayout();

            ActualizarBotonDeshacer();

            if (secuenciaUsuario.Count == secuenciaCorrecta.Count)
            {
                esperandoInput = false;
                btnDeshacerAccion.Enabled = false;
                ValidarSecuencia();
            }
        }

        private void ValidarSecuencia()
        {
            bool esCorrecta = true;

            for (int i = 0; i < secuenciaCorrecta.Count; i++)
            {
                if (secuenciaUsuario[i] != secuenciaCorrecta[i])
                {
                    esCorrecta = false;
                    break;
                }
            }

            bool esModoFacil = cmbDificultad.SelectedItem.ToString().Contains("Fácil");

            if (esCorrecta)
            {
                int incrementoVinculo = esModoFacil ? 15 : 10;
                nivelVinculo = Math.Min(100, nivelVinculo + incrementoVinculo);

                GuardarVinculoEnInteraccion();

                string[] mensajesPositivos = {
                    "¡El caballo confía en ti!",
                    "¡Excelente comunicación!",
                    "¡El caballo se siente seguro!",
                    "¡Conexión perfecta!"
                };
                Random rnd = new Random();
                string mensaje = mensajesPositivos[rnd.Next(mensajesPositivos.Length)];

                lblFeedback.Text = $"✓ {mensaje} (+{incrementoVinculo}% vínculo)";
                lblFeedback.BackColor = Color.FromArgb(144, 238, 144);

                ActualizarVinculo();

                nivelActual++;

                if (!tooltipOcultadoPorNivel)
                {
                    lblTooltipSecuencia.Visible = false;
                    tooltipOcultadoPorNivel = true;
                }

                ActualizarProgreso();

                if (nivelActual > nivelesMaximos)
                {
                    MostrarPantallaFinal();
                }
                else
                {
                    string feedbackEducativo = GenerarFeedbackEducativo(true);
                    MessageBox.Show(
                        $"¡Bien hecho! Nivel {nivelActual} desbloqueado.\n\n{feedbackEducativo}\n\n💚 Vínculo actual: {nivelVinculo}%",
                        "SIGUIENTE NIVEL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    btnComenzarDesafio.Enabled = true;
                }
            }
            else
            {
                int decrementoVinculo = esModoFacil ? 25 : 20;
                nivelVinculo = Math.Max(0, nivelVinculo - decrementoVinculo);

                GuardarVinculoEnInteraccion();

                lblFeedback.Text = $"✗ El caballo se confundió (-{decrementoVinculo}% vínculo)";
                lblFeedback.BackColor = Color.FromArgb(255, 99, 71);

                ActualizarVinculo();

                if (nivelVinculo <= 0)
                {
                    MessageBox.Show(
                        "💔 GAME OVER\n\n" +
                        "El vínculo con el caballo se ha perdido completamente.\n" +
                        "Deberás reiniciar toda la dificultad.\n\n" +
                        "💡 Consejo: Practica en la sección 'Interacción' para mejorar tu vínculo antes de volver a intentarlo.",
                        "VÍNCULO PERDIDO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    ReiniciarJuegoCompleto();
                    return;
                }

                string feedbackEducativo = GenerarFeedbackEducativo(false);
                MessageBox.Show(
                    $"El caballo no entendió la secuencia.\n\n{feedbackEducativo}\n\n💡 Consejo: Observa con más atención.\n💚 Vínculo actual: {nivelVinculo}%",
                    "SECUENCIA INCORRECTA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                secuenciaUsuario.Clear();

                var labelsAEliminar = pnlSecuenciaUsuario.Controls.OfType<Label>()
                    .Where(l => l != lblInstrucciones && l != lblTooltipSecuencia)
                    .ToList();

                foreach (var lbl in labelsAEliminar)
                {
                    pnlSecuenciaUsuario.Controls.Remove(lbl);
                }

                btnComenzarDesafio.Enabled = true;
                ActualizarBotonDeshacer();
            }
        }

        private void MostrarPantallaFinal()
        {
            string modoCompletado = cmbDificultad.SelectedItem.ToString().Contains("Fácil") ? "FÁCIL" : "DIFÍCIL";
            string titulo;
            string mensaje;
            MessageBoxIcon icono;

            if (nivelVinculo == 100)
            {
                titulo = "🏆 ¡LOGRO DESBLOQUEADO!";
                mensaje = $"🎉 ¡PERFECCIÓN ABSOLUTA! 🎉\n\n" +
                         $"Has completado el modo {modoCompletado} con un vínculo perfecto del 100%.\n\n" +
                         $"🐴 {(CaballoSeleccionado.HayCaballoSeleccionado() ? CaballoSeleccionado.Actual.Nombre : "El caballo")} " +
                         $"ha alcanzado el nivel más alto de entrenamiento.\n\n" +
                         $"🏅 LOGRO: 'Maestro Ecuestre'\n" +
                         $"Eres un verdadero experto en la comunicación equina.";
                icono = MessageBoxIcon.Information;
            }
            else if (nivelVinculo >= 70)
            {
                // Final muy bueno
                titulo = "⭐ ¡MUY BIEN HECHO!";
                mensaje = $"🎊 ¡Felicidades! Has completado el modo {modoCompletado}.\n\n" +
                         $"💚 Vínculo final: {nivelVinculo}%\n\n" +
                         $"El caballo confía mucho en ti. ¡Excelente trabajo!\n\n" +
                         $"💡 Desafío: ¿Puedes completarlo con 100% de vínculo?";
                icono = MessageBoxIcon.Information;
            }
            else if (nivelVinculo >= 50)
            {
                // Final bueno
                titulo = "✓ ¡BIEN HECHO!";
                mensaje = $"👍 Has completado el modo {modoCompletado}.\n\n" +
                         $"💚 Vínculo final: {nivelVinculo}%\n\n" +
                         $"El caballo ha aprendido, pero aún puedes mejorar tu conexión.\n\n" +
                         $"💡 Consejo: Practica más en la sección 'Interacción' para fortalecer el vínculo.";
                icono = MessageBoxIcon.Information;
            }
            else
            {
                // Final regular
                titulo = "✓ COMPLETADO";
                mensaje = $"Has completado el modo {modoCompletado}.\n\n" +
                         $"💚 Vínculo final: {nivelVinculo}%\n\n" +
                         $"⚠️ El vínculo con el caballo es bajo.\n" +
                         $"El entrenamiento fue complicado y el caballo no confía completamente.\n\n" +
                         $"💡 Recomendación: Dedica más tiempo en 'Interacción' antes de volver a intentarlo.";
                icono = MessageBoxIcon.Warning;
            }

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, icono);
            ReiniciarJuegoCompleto();
        }

        private string GenerarFeedbackEducativo(bool exito)
        {
            if (exito)
            {
                if (nivelVinculo >= 80)
                    return "🌟 El caballo está muy feliz y confía plenamente en ti.";
                else if (nivelVinculo >= 50)
                    return "😊 El caballo se siente cómodo contigo.";
                else
                    return "🙂 El caballo está empezando a confiar.";
            }
            else
            {
                if (nivelVinculo < 30)
                    return "😰 El caballo está perdiendo la confianza. ¡Ten cuidado!";
                else if (nivelVinculo < 60)
                    return "😐 El caballo necesita más paciencia y práctica.";
                else
                    return "🤔 Todos cometemos errores. El caballo confía en que mejorarás.";
            }
        }

        private void ActualizarVinculo()
        {
            progressBienestar.Value = nivelVinculo;

            if (nivelVinculo >= 70)
            {
                progressBienestar.ForeColor = Color.FromArgb(144, 238, 144);
                lblBienestar.ForeColor = Color.FromArgb(0, 150, 0);
            }
            else if (nivelVinculo >= 40)
            {
                progressBienestar.ForeColor = Color.FromArgb(255, 215, 0);
                lblBienestar.ForeColor = Color.FromArgb(200, 150, 0);
            }
            else
            {
                progressBienestar.ForeColor = Color.FromArgb(255, 99, 71);
                lblBienestar.ForeColor = Color.FromArgb(200, 0, 0);
            }

            lblBienestar.Text = $"💚 Vínculo: {nivelVinculo}%";
        }

        private void LimpiarJuego()
        {
            secuenciaCorrecta.Clear();
            secuenciaUsuario.Clear();

            var labelsAEliminar = pnlSecuenciaUsuario.Controls.OfType<Label>()
                .Where(l => l != lblInstrucciones && l != lblTooltipSecuencia)
                .ToList();

            foreach (var lbl in labelsAEliminar)
            {
                pnlSecuenciaUsuario.Controls.Remove(lbl);
            }

            lblFeedback.Text = "Esperando...";
            lblFeedback.BackColor = Color.LightGray;
            ActualizarBotonDeshacer();
        }

        private void ActualizarProgreso()
        {
            int porcentaje = (int)((float)nivelActual / nivelesMaximos * 100);
            progressBar1.Value = Math.Min(100, porcentaje);
            lblNivel.Text = $"Nivel {nivelActual}";
        }

        private void ActualizarUI()
        {
            lblNivel.Text = $"Nivel {nivelActual}";
            progressBar1.Value = 0;
            lblFeedback.Text = "Esperando inicio...";
            ActualizarVinculo();
        }

        private void ReiniciarJuegoCompleto()
        {
            nivelActual = 1;
            LimpiarJuego();
            ActualizarUI();
            CargarVinculoDesdeInteraccion();
            MostrarPantallaInicial();
        }
    }
}