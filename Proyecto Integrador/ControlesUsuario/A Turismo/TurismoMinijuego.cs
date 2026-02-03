using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class TurismoMinijuego : UserControl
    {
        public event EventHandler? CancelarPresionado;

        private PictureBox? imagenSeleccionada = null;

       
        private Point[] slotsAbajo = Array.Empty<Point>();
        private Size slotSize = new Size(150, 80);

        private readonly Random rnd = new Random();
        private bool _inicializado = false;

        public TurismoMinijuego()
        {
            InitializeComponent();
            InicializarJuego();

            
            this.Resize += (s, e) => AjustarLayout();

            this.Load += (s, e) =>
            {
                if (_inicializado) return;
                _inicializado = true;

                AjustarLayout();     
                MezclarImagenes();   
            };
        }

        private void InicializarJuego()
        {
            pictureBox1.Click += Imagen_Click;
            pictureBox2.Click += Imagen_Click;
            pictureBox3.Click += Imagen_Click;
            pictureBox4.Click += Imagen_Click;

            panel2.Click += Panel_Click;
            panel3.Click += Panel_Click;
            panel4.Click += Panel_Click;
            panel5.Click += Panel_Click;

            btnGuardar.Click += btnGuardar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnSalir.Click += btnSalir_Click;
        }

        // =========================
        //  LAYOUT RESPONSIVE REAL
        // =========================
        private void AjustarLayout()
        {
            if (this.ClientSize.Width <= 0 || this.ClientSize.Height <= 0) return;

            int margen = 40;

            // Botones arriba derecha
            int yBotones = 20;
            btnGuardar.Top = yBotones;
            btnCancelar.Top = yBotones;
            btnSalir.Top = yBotones;

            btnGuardar.Left = this.ClientSize.Width - margen - btnGuardar.Width;
            btnCancelar.Left = btnGuardar.Left - 10 - btnCancelar.Width;
            btnSalir.Left = btnCancelar.Left - 10 - btnSalir.Width;

            // Label orden
            label2.Left = margen;
            label2.Top = yBotones + btnGuardar.Height + 15;

           
            int anchoDisponible = this.ClientSize.Width - (margen * 2);
            int gap = 30;          // espacio entre tarjeta y flecha
            int arrowW = 60;       // ancho de flecha aproximado (luego se ajusta)
            int arrowGapTotal = 3 * (arrowW + gap);

            int cardW = (anchoDisponible - arrowGapTotal - (gap * 2)) / 4; // margen extra
            cardW = Clamp(cardW, 170, 260); // 

            int cardH = (int)(cardW * 0.55);
            cardH = Clamp(cardH, 90, 140);

            // Tamaño de flecha proporcional
            int flechaW = Clamp((int)(cardW * 0.35), 45, 85);
            int flechaH = Clamp((int)(cardH * 0.35), 22, 45);

            // ---------- Ajusta panelLineaTiempo ----------
            panelLineaTiempo.Top = label2.Bottom + 20;
            panelLineaTiempo.Height = Math.Max(cardH + 40, 120);

            // ancho real del bloque (4 tarjetas + 3 flechas + espacios)
            int totalW = (cardW * 4) + (flechaW * 3) + (gap * 6);
            panelLineaTiempo.Width = Math.Min(totalW, this.ClientSize.Width - (margen * 2));
            panelLineaTiempo.Left = (this.ClientSize.Width - panelLineaTiempo.Width) / 2;

            
            int x = (panelLineaTiempo.Width - totalW) / 2;
            if (x < 10) x = 10;
            int yCard = (panelLineaTiempo.Height - cardH) / 2;

            // Tarjetas
            panel2.Size = new Size(cardW, cardH);
            panel3.Size = new Size(cardW, cardH);
            panel4.Size = new Size(cardW, cardH);
            panel5.Size = new Size(cardW, cardH);

            panel2.Location = new Point(x, yCard);
            x += cardW + gap;

            pictureBox6.Size = new Size(flechaW, flechaH);
            pictureBox6.Location = new Point(x, yCard + (cardH - flechaH) / 2);
            x += flechaW + gap;

            panel3.Location = new Point(x, yCard);
            x += cardW + gap;

            pictureBox5.Size = new Size(flechaW, flechaH);
            pictureBox5.Location = new Point(x, yCard + (cardH - flechaH) / 2);
            x += flechaW + gap;

            panel4.Location = new Point(x, yCard);
            x += cardW + gap;

            pictureBox7.Size = new Size(flechaW, flechaH);
            pictureBox7.Location = new Point(x, yCard + (cardH - flechaH) / 2);
            x += flechaW + gap;

            panel5.Location = new Point(x, yCard);

            panel1.Top = panelLineaTiempo.Bottom + 30;
            panel1.Height = Math.Max(cardH + 60, 150);

            panel1.Width = panelLineaTiempo.Width;
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;

            slotSize = new Size(cardW, cardH);

            slotsAbajo = CalcularSlots(panel1.Width, slotSize, 4, 20);

            ReacomodarImagenesEnPanel1();

            AjustarImagenEnDestino(panel2);
            AjustarImagenEnDestino(panel3);
            AjustarImagenEnDestino(panel4);
            AjustarImagenEnDestino(panel5);
        }

        private void AjustarImagenEnDestino(Panel destino)
        {
            if (destino.Controls.Count == 0) return;
            if (destino.Controls[0] is not PictureBox pb) return;

            pb.Location = new Point(0, 0);
            pb.Size = destino.Size;
        }

        private void ReacomodarImagenesEnPanel1()
        {
            var pbs = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4 }
                .Where(pb => pb.Parent == panel1)
                .OrderBy(pb => pb.Left) // mantiene más o menos el orden actual
                .ToList();

            for (int i = 0; i < pbs.Count && i < slotsAbajo.Length; i++)
            {
                pbs[i].Size = slotSize;
                pbs[i].Location = slotsAbajo[i];
            }
        }

        private static Point[] CalcularSlots(int contenedorW, Size itemSize, int cantidad, int margenInterno)
        {
            Point[] slots = new Point[cantidad];

            int totalItemsW = cantidad * itemSize.Width;
            int espacio = contenedorW - (margenInterno * 2) - totalItemsW;

            int gap = (cantidad > 1) ? espacio / (cantidad - 1) : 0;
            gap = Math.Max(gap, 15);

            int x = margenInterno;
            int y = 25;

            for (int i = 0; i < cantidad; i++)
            {
                slots[i] = new Point(x, y);
                x += itemSize.Width + gap;
            }

            return slots;
        }

        private static int Clamp(int v, int min, int max) => Math.Max(min, Math.Min(max, v));

        // =========================
        //      LÓGICA DEL JUEGO
        // =========================
        private void Imagen_Click(object? sender, EventArgs e)
        {
            if (sender is not PictureBox pb) return;

            if (imagenSeleccionada != null)
                imagenSeleccionada.BorderStyle = BorderStyle.None;

            imagenSeleccionada = pb;
            imagenSeleccionada.BorderStyle = BorderStyle.FixedSingle;
        }

        // swap si el destino ya tiene una imagen
        private void Panel_Click(object? sender, EventArgs e)
        {
            if (imagenSeleccionada == null) return;
            if (sender is not Panel destino) return;

            Control parentOrigen = imagenSeleccionada.Parent;

            PictureBox? pbDestino = null;
            if (destino.Controls.Count > 0)
                pbDestino = destino.Controls[0] as PictureBox;

            if (pbDestino != null)
            {
                // regresa la del destino al lugar del origen
                pbDestino.Parent = parentOrigen;
                pbDestino.Size = slotSize;

                // si vuelve a panel1, colócala en un slot libre
                if (parentOrigen == panel1)
                {
                    ColocarEnSlotLibre(pbDestino);
                }
                else
                {
                    pbDestino.Location = imagenSeleccionada.Location;
                    pbDestino.Size = imagenSeleccionada.Size;
                }
            }

            // Mover la seleccionada al destino
            imagenSeleccionada.Parent = destino;
            imagenSeleccionada.Location = new Point(0, 0);
            imagenSeleccionada.Size = destino.Size;

            imagenSeleccionada.BorderStyle = BorderStyle.None;
            imagenSeleccionada = null;
        }

        private void ColocarEnSlotLibre(PictureBox pb)
        {
            // slots ocupados por otras imágenes
            var ocupados = new HashSet<Point>(
                new[] { pictureBox1, pictureBox2, pictureBox3, pictureBox4 }
                .Where(x => x.Parent == panel1 && x != pb)
                .Select(x => x.Location)
            );

            // toma el primer slot libre
            foreach (var s in slotsAbajo)
            {
                if (!ocupados.Contains(s))
                {
                    pb.Location = s;
                    pb.Size = slotSize;
                    return;
                }
            }

            // si no hay slot, lo deja donde estaba
            pb.Size = slotSize;
        }

        private void btnGuardar_Click(object? sender, EventArgs e)
        {
            bool correcto =
                panel2.Controls.Contains(pictureBox1) &&
                panel3.Controls.Contains(pictureBox2) &&
                panel4.Controls.Contains(pictureBox3) &&
                panel5.Controls.Contains(pictureBox4);

            MessageBox.Show(correcto ? "¡Orden correcto!" : "Orden incorrecto. Intenta otra vez.");
        }

        private void btnCancelar_Click(object? sender, EventArgs e)
        {
            ReiniciarJuego();
        }

        private void ReiniciarJuego()
        {
            pictureBox1.Parent = panel1;
            pictureBox2.Parent = panel1;
            pictureBox3.Parent = panel1;
            pictureBox4.Parent = panel1;

            // coloca en slots y luego mezcla
            pictureBox1.Size = slotSize;
            pictureBox2.Size = slotSize;
            pictureBox3.Size = slotSize;
            pictureBox4.Size = slotSize;

            pictureBox1.Location = slotsAbajo[0];
            pictureBox2.Location = slotsAbajo[1];
            pictureBox3.Location = slotsAbajo[2];
            pictureBox4.Location = slotsAbajo[3];

            imagenSeleccionada = null;
            MezclarImagenes();
        }

        private void MezclarImagenes()
        {
            // Mezcla posiciones SOLO para las que están en panel1
            var lista = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4 }
                .Where(pb => pb.Parent == panel1)
                .ToList();

            // Copia slots y mezcla
            Point[] copia = (Point[])slotsAbajo.Clone();
            for (int i = copia.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                (copia[i], copia[j]) = (copia[j], copia[i]);
            }

            for (int i = 0; i < lista.Count && i < copia.Length; i++)
            {
                lista[i].Location = copia[i];
                lista[i].Size = slotSize;
            }
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            CancelarPresionado?.Invoke(this, EventArgs.Empty);
        }
    }
}
