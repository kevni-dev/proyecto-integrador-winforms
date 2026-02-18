// TurismoMinijuego.cs  (REEMPLAZA este archivo COMPLETO)
// ✅ FIX RESPONSIVE: en pantallas pequeñas NO se “pierden” los paneles/imagenes
// - panelCard ahora se ajusta al tamaño del UserControl (Dock=Fill)
// - layout se compacta automáticamente según ancho/alto
// - reduce alturas, márgenes, fuentes y ancho de flechas cuando la ventana es pequeña

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class TurismoMinijuego : UserControl
    {
        private readonly Random rnd = new Random();

        private PictureBox? cartaSeleccionada;

        private readonly List<PictureBox> cartas = new();
        private readonly List<Panel> slots = new();
        private readonly List<Label> slotLabels = new();

        private readonly System.Windows.Forms.Timer timerNivel = new System.Windows.Forms.Timer();
        private int segundosRestantes = 30;

        private int intentos = 3;
        private int nivelActual = 1;

        private List<Grupo> gruposMezclados = new();
        private Grupo? grupoActual;

        private bool juegoActivo = false;
        private bool _inicializado = false;

        // modal
        private bool _modalEsFinal = false;

        // ===== estilo “papel” =====
        private readonly Color beigePapel = Color.FromArgb(245, 238, 228);
        private readonly Color beigeSlot = Color.FromArgb(242, 236, 226);

        public TurismoMinijuego()
        {
            InitializeComponent();

            // refs
            cartas.AddRange(new[] { card1, card2, card3, card4 });
            slots.AddRange(new[] { slot1, slot2, slot3, slot4 });
            slotLabels.AddRange(new[] { lblSlot1, lblSlot2, lblSlot3, lblSlot4 });

            // menos parpadeo
            TrySetDoubleBuffered(panelCard, true);
            TrySetDoubleBuffered(root, true);
            TrySetDoubleBuffered(topInfo, true);
            TrySetDoubleBuffered(tableSlots, true);
            TrySetDoubleBuffered(tableCards, true);
            TrySetDoubleBuffered(panelBottom, true);
            TrySetDoubleBuffered(tableBtns, true);
            foreach (var s in slots) TrySetDoubleBuffered(s, true);

            // eventos
            foreach (var c in cartas) c.Click += Carta_Click;
            foreach (var s in slots) s.Click += Slot_Click;

            btnReiniciar.Click += (s, e) => ReiniciarPartidaCompleta();
            btnAceptar.Click += (s, e) => ValidarOrden();

            // un solo handler para Empezar/Cerrar (evita dobles eventos)
            btnEmpezar.Click += BtnEmpezar_Click;

            // ✅ panelCard SIEMPRE se adapta al tamaño disponible
            panelCard.Dock = DockStyle.Fill;

            // resize
            this.Resize += (s, e) =>
            {
                AjustarResponsiveLayout();
                CentrarModal();
            };

            this.Load += (s, e) =>
            {
                if (_inicializado) return;
                _inicializado = true;

                AjustarResponsiveLayout();
                CentrarModal();

                PrepararNivelData();
                PintarIntentos();
                PintarTiempo();

                BloquearJuego();
            };

            // timer
            timerNivel.Interval = 1000;
            timerNivel.Tick += TimerNivel_Tick;

            // aplica colores base
            panelCard.BackColor = beigePapel;
            foreach (var p in slots) p.BackColor = beigeSlot;

            foreach (var c in cartas)
            {
                c.BackColor = beigeSlot;
                c.Image = null;
                c.SizeMode = PictureBoxSizeMode.Zoom; // mejor en pantallas pequeñas
            }

            modal.BackColor = beigePapel;

            // header
            if (lblHeaderTitle != null)
                lblHeaderTitle.Text = "MINIJUEGO: ORDENA LAS ACTIVIDADES";
        }

        // =========================
        // ✅ Responsive layout (NUEVO)
        // =========================
        private void AjustarResponsiveLayout()
        {
            int w = this.ClientSize.Width;
            int h = this.ClientSize.Height;

            // padding general del "papel"
            int padX = 26, padTop = 16, padBottom = 18;

            // compactación por tamaño
            bool muyAngosto = w < 920;
            bool superAngosto = w < 760;

            bool bajo = h < 600;
            bool superBajo = h < 520;

            if (muyAngosto)
            {
                padX = 16;
                padTop = 12;
                padBottom = 12;
            }
            if (superAngosto)
            {
                padX = 10;
                padTop = 10;
                padBottom = 10;
            }

            panelCard.Padding = new Padding(padX, padTop, padX, padBottom);

            // ========= ajustar alturas de filas del root =========
            // root: 0 header, 1 topInfo, 2 slots, 3 labels, 4 separator, 5 final
            float headerH = 66f;
            float infoH = 92f;
            float slotsH = 140f;
            float labelsH = 44f;
            float sepH = 50f;

            if (bajo)
            {
                headerH = 56f;
                infoH = 82f;
                slotsH = 120f;
                labelsH = 40f;
                sepH = 42f;
            }
            if (superBajo)
            {
                headerH = 52f;
                infoH = 76f;
                slotsH = 110f;
                labelsH = 38f;
                sepH = 38f;
            }

            // aplica
            if (root.RowStyles.Count >= 6)
            {
                root.RowStyles[0].SizeType = SizeType.Absolute;
                root.RowStyles[0].Height = headerH;

                root.RowStyles[1].SizeType = SizeType.Absolute;
                root.RowStyles[1].Height = infoH;

                root.RowStyles[2].SizeType = SizeType.Absolute;
                root.RowStyles[2].Height = slotsH;

                root.RowStyles[3].SizeType = SizeType.Absolute;
                root.RowStyles[3].Height = labelsH;

                root.RowStyles[4].SizeType = SizeType.Absolute;
                root.RowStyles[4].Height = sepH;

                root.RowStyles[5].SizeType = SizeType.Percent;
                root.RowStyles[5].Height = 100f;
            }

            // ========= fuentes =========
            lblHeaderTitle.Font = new Font("Georgia", muyAngosto ? 11.5f : 13f, FontStyle.Bold);
            lblTitulo.Font = new Font("Georgia", superAngosto ? 14.5f : (muyAngosto ? 16f : 18f), FontStyle.Bold);
            lblSubtitulo.Font = new Font("Georgia", superAngosto ? 9.5f : (muyAngosto ? 10f : 11f), FontStyle.Regular);
            lblNivel.Font = new Font("Georgia", superAngosto ? 9.5f : 11f, FontStyle.Regular);
            lblTiempo.Font = new Font("Georgia", superAngosto ? 9.5f : 11f, FontStyle.Bold);
            lblIntentos.Font = new Font("Georgia", superAngosto ? 9.5f : 11f, FontStyle.Bold);

            foreach (var l in slotLabels)
                l.Font = new Font("Georgia", superAngosto ? 8.5f : 10f, FontStyle.Italic);

            // ========= flechas + márgenes slots =========
            int arrowW = superAngosto ? 34 : (muyAngosto ? 46 : 70);
            int slotMarginLR = superAngosto ? 6 : (muyAngosto ? 8 : 12);
            int slotMarginTop = superAngosto ? 10 : (muyAngosto ? 14 : 20);
            int slotMarginBottom = superAngosto ? 10 : (muyAngosto ? 12 : 16);

            // tableSlots: columnas 1,3,5 son flechas (Absolute)
            if (tableSlots.ColumnStyles.Count >= 7)
            {
                tableSlots.ColumnStyles[1].SizeType = SizeType.Absolute;
                tableSlots.ColumnStyles[1].Width = arrowW;

                tableSlots.ColumnStyles[3].SizeType = SizeType.Absolute;
                tableSlots.ColumnStyles[3].Width = arrowW;

                tableSlots.ColumnStyles[5].SizeType = SizeType.Absolute;
                tableSlots.ColumnStyles[5].Width = arrowW;
            }

            slot1.Margin = new Padding(slotMarginLR, slotMarginTop, slotMarginLR, slotMarginBottom);
            slot2.Margin = new Padding(slotMarginLR, slotMarginTop, slotMarginLR, slotMarginBottom);
            slot3.Margin = new Padding(slotMarginLR, slotMarginTop, slotMarginLR, slotMarginBottom);
            slot4.Margin = new Padding(slotMarginLR, slotMarginTop, slotMarginLR, slotMarginBottom);

            // si está MUY angosto, las flechas se ven enormes -> ponlas en Zoom
            arrow1.SizeMode = PictureBoxSizeMode.Zoom;
            arrow2.SizeMode = PictureBoxSizeMode.Zoom;
            arrow3.SizeMode = PictureBoxSizeMode.Zoom;

            // ========= cartas abajo + botones =========
            // Si es bajo, reduce la altura del bloque de cartas y del panel de botones
            tableCards.Height = superBajo ? 140 : (bajo ? 160 : 185);
            panelBottom.Height = superBajo ? 76 : (bajo ? 84 : 92);

            // márgenes de cartas (para que quepan mejor)
            int cardMargin = superAngosto ? 6 : 10;
            foreach (var c in cartas)
                c.Margin = new Padding(cardMargin, 6, cardMargin, 6);

            // separador más corto si es angosto (para que no “empuje” todo)
            if (muyAngosto)
                lblSeparador.Text = "----------  Ordena las cartas en el orden correcto.  ----------";
            else
                lblSeparador.Text = "--------------------  Ordena las cartas en el orden correcto.  --------------------";
        }

        // =========================
        // datos (ACTUALIZADO)
        // =========================
        private void PrepararNivelData()
        {
            var grupos = new List<Grupo>
            {
                new Grupo("Limpieza", new []
                {
                    "Caballo sucio",
                    "Cepillar el cuerpo",
                    "Limpiar los cascos",
                    "Caballo limpio"
                }),
                new Grupo("Cuidado y salud", new []
                {
                    "Revisar al caballo",
                    "Curar una herida",
                    "Dar medicina",
                    "Caballo sano"
                }),
                new Grupo("Alimentación", new []
                {
                    "hambriento",
                    "Dar heno",
                    "Dar agua",
                    "Caballo comiendo"
                }),
                new Grupo("Turismo", new []
                {
                    "Colocar la silla",
                    "Montar el caballo",
                    "Pasear por el campo",
                    "Caballo descansando"
                })
            };

            gruposMezclados = grupos.OrderBy(_ => rnd.Next()).ToList();
        }

        // =========================
        // flujo
        // =========================
        private void IniciarPartidaNueva()
        {
            intentos = 3;
            nivelActual = 1;

            PrepararNivelData();
            CargarNivel(nivelActual);

            MezclarCartasAbajo();
            PintarIntentos();

            juegoActivo = true;
            timerNivel.Start();
        }

        private void ReiniciarPartidaCompleta()
        {
            timerNivel.Stop();

            _modalEsFinal = false;
            overlay.Visible = true;
            btnEmpezar.Text = "Empezar";
            CentrarModal();

            BloquearJuego();
            cartaSeleccionada = null;

            foreach (var s in slots) s.Controls.Clear();

            foreach (var c in cartas)
            {
                c.BorderStyle = BorderStyle.FixedSingle;
                c.Image = null;
                c.BackColor = beigeSlot;
                AjustarCardEnParent(c);
            }

            lblNivel.Text = "Nivel: 1/4  •  Grupo: ---";
            intentos = 3;
            segundosRestantes = 30;
            PintarTiempo();
            PintarIntentos();
        }

        private void CargarNivel(int nivel)
        {
            grupoActual = gruposMezclados[nivel - 1];
            lblNivel.Text = $"Nivel: {nivel}/4  •  Grupo: {grupoActual.Nombre}";

            segundosRestantes = SegundosPorNivel(nivel);
            PintarTiempo();

            for (int i = 0; i < 4; i++)
                slotLabels[i].Text = grupoActual.Actividades[i];

            foreach (var s in slots) s.Controls.Clear();

            DevolverCartasAbajo();
            MezclarCartasAbajo();

            // ✅ Cargar imágenes según el grupo actual (limpieza_1..4, salud_1..4, etc.)
            CargarImagenesDelGrupo(grupoActual.Nombre);

            foreach (var c in cartas)
            {
                c.BorderStyle = BorderStyle.FixedSingle;
                c.Cursor = Cursors.Hand;
            }
        }

        private int SegundosPorNivel(int nivel)
        {
            return nivel switch
            {
                1 => 45,
                2 => 40,
                3 => 35,
                _ => 30
            };
        }

        // =========================
        // imágenes por grupo
        // =========================
        private void CargarImagenesDelGrupo(string nombreGrupo)
        {
            string prefix = nombreGrupo switch
            {
                "Limpieza" => "limpieza",
                "Cuidado y salud" => "salud",
                "Alimentación" => "alimentacion",
                "Turismo" => "turismo",
                _ => "turismo"
            };

            card1.Image = GetImg($"{prefix}_1");
            card2.Image = GetImg($"{prefix}_2");
            card3.Image = GetImg($"{prefix}_3");
            card4.Image = GetImg($"{prefix}_4");
        }

        private static Image? GetImg(string resourceName)
        {
            try
            {
                object? obj = Properties.Resources.ResourceManager.GetObject(resourceName);
                return obj as Image;
            }
            catch { return null; }
        }

        // =========================
        // interacción
        // =========================
        private void Carta_Click(object? sender, EventArgs e)
        {
            if (!juegoActivo) return;
            if (sender is not PictureBox pb) return;

            if (cartaSeleccionada != null)
                cartaSeleccionada.BorderStyle = BorderStyle.FixedSingle;

            cartaSeleccionada = pb;
            cartaSeleccionada.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Slot_Click(object? sender, EventArgs e)
        {
            if (!juegoActivo) return;
            if (cartaSeleccionada == null) return;
            if (sender is not Panel destino) return;

            PictureBox? enDestino = destino.Controls.Count > 0 ? destino.Controls[0] as PictureBox : null;
            Control origenParent = cartaSeleccionada.Parent;

            if (enDestino != null)
            {
                enDestino.Parent = origenParent;
                AjustarCardEnParent(enDestino);
            }

            cartaSeleccionada.Parent = destino;
            cartaSeleccionada.Dock = DockStyle.Fill;
            cartaSeleccionada.Margin = new Padding(0);
            cartaSeleccionada.BorderStyle = BorderStyle.None;

            cartaSeleccionada = null;
        }

        private void AjustarCardEnParent(PictureBox pb)
        {
            if (pb.Parent == tableCards)
            {
                pb.Dock = DockStyle.Fill;
                pb.BorderStyle = BorderStyle.FixedSingle;
                // márgenes se reajustan en AjustarResponsiveLayout()
            }
            else if (pb.Parent is Panel)
            {
                pb.Dock = DockStyle.Fill;
                pb.Margin = new Padding(0);
                pb.BorderStyle = BorderStyle.None;
            }
            else
            {
                pb.Dock = DockStyle.Fill;
            }
        }

        // =========================
        // validar
        // =========================
        private void ValidarOrden()
        {
            if (!juegoActivo) return;
            if (grupoActual == null) return;

            bool correcto =
                slot1.Controls.Contains(card1) &&
                slot2.Controls.Contains(card2) &&
                slot3.Controls.Contains(card3) &&
                slot4.Controls.Contains(card4);

            if (correcto) { AvanzarNivel(); return; }
            Fallo();
        }

        private void AvanzarNivel()
        {
            timerNivel.Stop();

            if (nivelActual >= 4)
            {
                juegoActivo = false;
                MostrarModalFinal("¡Excelente!", "Completaste los 4 niveles.\n\nPulsa Reiniciar si quieres jugar otra vez.");
                return;
            }

            nivelActual++;
            CargarNivel(nivelActual);

            juegoActivo = true;
            timerNivel.Start();
        }

        private void Fallo()
        {
            intentos--;
            PintarIntentos();

            if (intentos <= 0)
            {
                timerNivel.Stop();
                juegoActivo = false;
                MostrarModalFinal("Se acabaron los intentos", "Perdiste los 3 intentos.\n\nPulsa Reiniciar para intentar de nuevo.");
                return;
            }

            DevolverCartasAbajo();
            MezclarCartasAbajo();

            segundosRestantes = SegundosPorNivel(nivelActual);
            PintarTiempo();
        }

        // =========================
        // timer
        // =========================
        private void TimerNivel_Tick(object? sender, EventArgs e)
        {
            if (!juegoActivo) return;

            segundosRestantes--;
            if (segundosRestantes < 0) segundosRestantes = 0;

            PintarTiempo();

            if (segundosRestantes == 0)
            {
                timerNivel.Stop();
                Fallo();
                if (juegoActivo) timerNivel.Start();
            }
        }

        private void PintarTiempo()
        {
            int m = segundosRestantes / 60;
            int s = segundosRestantes % 60;
            lblTiempo.Text = $"Tiempo: {m:00}:{s:00}";
        }

        private void PintarIntentos()
        {
            string hearts = intentos switch
            {
                3 => "♥ ♥ ♥",
                2 => "♥ ♥",
                1 => "♥",
                _ => ""
            };
            lblIntentos.Text = $"Intentos: {hearts}";
        }

        // =========================
        // cartas abajo
        // =========================
        private void DevolverCartasAbajo()
        {
            foreach (var s in slots)
            {
                if (s.Controls.Count == 0) continue;

                var pb = s.Controls[0] as PictureBox;
                if (pb == null) continue;

                pb.Parent = tableCards;
                AjustarCardEnParent(pb);
            }

            foreach (var c in cartas)
            {
                if (c.Parent != tableCards)
                {
                    c.Parent = tableCards;
                    AjustarCardEnParent(c);
                }
            }
        }

        private void MezclarCartasAbajo()
        {
            var orden = cartas.OrderBy(_ => rnd.Next()).ToList();

            tableCards.SuspendLayout();
            tableCards.Controls.Clear();

            tableCards.Controls.Add(orden[0], 0, 0);
            tableCards.Controls.Add(orden[1], 1, 0);
            tableCards.Controls.Add(orden[2], 2, 0);
            tableCards.Controls.Add(orden[3], 3, 0);

            foreach (var c in cartas) AjustarCardEnParent(c);

            tableCards.ResumeLayout();
        }

        // =========================
        // modal
        // =========================
        private void CentrarModal()
        {
            int x = (overlay.ClientSize.Width - modal.Width) / 2;
            int y = (overlay.ClientSize.Height - modal.Height) / 2;
            if (x < 10) x = 10;
            if (y < 10) y = 10;
            modal.Location = new Point(x, y);
        }

        private void MostrarModalFinal(string titulo, string texto)
        {
            _modalEsFinal = true;

            lblModalTitulo.Text = titulo;
            lblModalTexto.Text = texto;

            btnEmpezar.Text = "Cerrar";

            overlay.Visible = true;
            CentrarModal();
        }

        private void BtnEmpezar_Click(object? sender, EventArgs e)
        {
            if (_modalEsFinal)
            {
                _modalEsFinal = false;
                btnEmpezar.Text = "Empezar";
                overlay.Visible = false;
                return;
            }

            overlay.Visible = false;
            IniciarPartidaNueva();
        }

        private void BloquearJuego()
        {
            juegoActivo = false;
            timerNivel.Stop();
        }

        // =========================
        // util
        // =========================
        private static void TrySetDoubleBuffered(Control c, bool value)
        {
            try
            {
                typeof(Control)
                    .GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.SetValue(c, value, null);
            }
            catch { }
        }

        private sealed class Grupo
        {
            public string Nombre { get; }
            public string[] Actividades { get; }

            public Grupo(string nombre, string[] actividades)
            {
                Nombre = nombre;
                Actividades = actividades;
            }
        }
    }
}
