using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento
{
    public partial class JuegoMemoramaFacil : UserControl
    {
        int Filas = 2;
        int Columnas = 4;
        int Movimientos = 0;
        int CantidadDeCartasVolteadas = 0;
        int TiempoRestante = 30;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;
        bool BloquearClick = false;
        public JuegoMemoramaFacil()
        {
            InitializeComponent();
            InicializarJuego();
            MostrarVistaPrevia();
        }
        public void InicializarJuego()
        {
            timerCronometro.Stop();
            TiempoRestante = 25;
            lblTiempo.Text = "Tiempo: 25";

            timer2.Stop();

            timer1.Enabled = true;
            timer1.Stop();
            lblRecord.Text = "0";
            CantidadDeCartasVolteadas = 0;
            Movimientos = 0;
            PanelJuego.Controls.Clear();
            CartasEnumeradas = new List<string>();
            CartasRevueltas = new List<string>();
            CartasSeleccionadas = new ArrayList();
            for (int i = 0; i < 4; i++)
            {
                CartasEnumeradas.Add(i.ToString());
                CartasEnumeradas.Add(i.ToString());
            }
            var NumeroAleatorio = new Random();
            var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
            foreach (string ValorCarta in Resultado)
            {
                CartasRevueltas.Add(ValorCarta);
            }
            var tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = Filas;
            tablaPanel.ColumnCount = Columnas;
            for (int i = 0; i < Columnas; i++)
            {
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / Columnas));
            }

            for (int i = 0; i < Filas; i++)
            {
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Filas));
            }

            int contadorFichas = 1;
            for (var i = 0; i < Filas; i++)
            {
                for (var j = 0; j < Columnas; j++)
                {
                    var CartasJuego = new PictureBox();
                    CartasJuego.Name = string.Format("{0}", contadorFichas);
                    CartasJuego.Dock = DockStyle.Fill;
                    CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                    CartasJuego.Image = Properties.Resources.Girada;
                    CartasJuego.Cursor = Cursors.Hand;
                    CartasJuego.Click += btnCarta_Click;
                    tablaPanel.Controls.Add(CartasJuego, j, i);
                    contadorFichas++;
                }
            }
            tablaPanel.Dock = DockStyle.Fill;
            PanelJuego.Controls.Add(tablaPanel);
        }
        private void MostrarVistaPrevia()
        {
            int i = 0;
            foreach (Control c in PanelJuego.Controls[0].Controls)
            {
                PictureBox pb = (PictureBox)c;
                int valor = int.Parse(CartasRevueltas[i]);
                pb.Image = RecuperarImagen(valor);
                i++;
            }
            timer2.Interval = 2000; // 2 segundos
            timer2.Start();
        }
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            InicializarJuego();
            timerCronometro.Start();
        }
        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (BloquearClick) return;
            if (CartasSeleccionadas.Count < 2)
            {


                Movimientos++;
                lblRecord.Text = Convert.ToString(Movimientos);
                var CartasSeleccionadasUsuario = (PictureBox)sender;

                CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                CartasSeleccionadas.Add(CartasSeleccionadasUsuario);

                // 2 Veces se realizo el evento click
                if (CartasSeleccionadas.Count == 2)
                {
                    BloquearClick = true;
                    CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                    CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                    int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                    int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);

                    if (Carta1 != Carta2)
                    {
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        CantidadDeCartasVolteadas++;
                        TiempoRestante = 25;
                        lblTiempo.Text = "Tiempo: 25";
                        if (CantidadDeCartasVolteadas > 3)
                        {
                            timerCronometro.Stop();
                            MessageBox.Show("Felicidades el juego termino");
                        }
                        CartaTemporal1.Enabled = false;
                        CartaTemporal2.Enabled = false;
                        CartasSeleccionadas.Clear();
                        BloquearClick = false;
                    }
                }
            }
        }
        public Bitmap RecuperarImagen(int NumeroImagen)
        {
            switch (NumeroImagen)
            {
                case 0:
                    return Properties.Resources.imgFacil1;
                case 1:
                    return Properties.Resources.imgFacil2;
                case 2:
                    return Properties.Resources.imgFacil3;
                case 3:
                    return Properties.Resources.imgFacil4;
                default:
                    return Properties.Resources.imgFacil1;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            CartaTemporal1.Image = Properties.Resources.Girada;
            CartaTemporal2.Image = Properties.Resources.Girada;

            CartasSeleccionadas.Clear();
            BloquearClick = false;

            timer1.Stop();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            foreach (Control c in PanelJuego.Controls[0].Controls)
            {
                ((PictureBox)c).Image = Properties.Resources.Girada;
            }
            timer2.Stop();
        }
        private void lblRecord_Click(object sender, EventArgs e)
        {
            MostrarVistaPrevia();
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            datocurioso uc = new datocurioso();

            Control parent = this.Parent;
            parent.Controls.Clear();

            uc.Dock = DockStyle.Fill;
            parent.Controls.Add(uc);
        }

        private void timerCronometro_Tick(object sender, EventArgs e)
        {
            TiempoRestante--;
            lblTiempo.Text = "Tiempo: " + TiempoRestante;

            if (TiempoRestante == 0)
            {
                timerCronometro.Stop();
                MessageBox.Show("Se acabó el tiempo ");
            }

        }
        private void btnInfo_Click(object sender, EventArgs e)
        {
            panelInstrucciones.Visible = true;
            panelInstrucciones.BringToFront();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            panelInstrucciones.Visible = false;
        }

        private void JuegoMemoramaFacil_Load(object sender, EventArgs e)
        {

        }

        private void btnModoNormal_Click(object sender, EventArgs e)
        {
            JuegoMemorama uc = new JuegoMemorama();

            Control parent = this.Parent;
            parent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            parent.Controls.Add(uc);
        }
    }
}
