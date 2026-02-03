namespace Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles
{
    partial class Juego
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblNivel = new Label();
            btnComenzarDesafio = new Button();
            progressBar1 = new ProgressBar();
            pnlEscenario = new Panel();
            pbCaballoJuego = new PictureBox();
            lblFeedback = new Label();
            pnlSecuenciaUsuario = new Panel();
            flpComandos = new FlowLayoutPanel();
            lblInstrucciones = new Label();
            pnlHeader.SuspendLayout();
            pnlEscenario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaballoJuego).BeginInit();
            SuspendLayout();

            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(101, 67, 33); // Marrón oscuro
            pnlHeader.Controls.Add(lblNivel);
            pnlHeader.Controls.Add(btnComenzarDesafio);
            pnlHeader.Controls.Add(progressBar1);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Padding = new Padding(15);
            pnlHeader.Size = new Size(900, 80);
            pnlHeader.TabIndex = 0;

            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNivel.ForeColor = Color.White;
            lblNivel.Location = new Point(15, 12);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(100, 32);
            lblNivel.TabIndex = 2;
            lblNivel.Text = "Nivel 1";

            // 
            // btnComenzarDesafio
            // 
            btnComenzarDesafio.BackColor = Color.FromArgb(184, 134, 11); // Oro oscuro
            btnComenzarDesafio.FlatAppearance.BorderSize = 0;
            btnComenzarDesafio.FlatStyle = FlatStyle.Flat;
            btnComenzarDesafio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComenzarDesafio.ForeColor = Color.White;
            btnComenzarDesafio.Location = new Point(350, 15);
            btnComenzarDesafio.Name = "btnComenzarDesafio";
            btnComenzarDesafio.Size = new Size(200, 50);
            btnComenzarDesafio.TabIndex = 0;
            btnComenzarDesafio.Text = "🐴 VER SECUENCIA";
            btnComenzarDesafio.UseVisualStyleBackColor = false;
            btnComenzarDesafio.Cursor = Cursors.Hand;

            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(150, 150, 150);
            progressBar1.ForeColor = Color.FromArgb(144, 238, 144);
            progressBar1.Location = new Point(560, 27);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(325, 25);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 10;

            // 
            // pnlEscenario
            // 
            pnlEscenario.BackgroundImage = Properties.Resources._2;
            pnlEscenario.BackgroundImageLayout = ImageLayout.Stretch;
            pnlEscenario.BorderStyle = BorderStyle.FixedSingle;
            pnlEscenario.Controls.Add(pbCaballoJuego);
            pnlEscenario.Controls.Add(lblFeedback);
            pnlEscenario.Dock = DockStyle.Top;
            pnlEscenario.Margin = new Padding(12);
            pnlEscenario.Padding = new Padding(20);
            pnlEscenario.Size = new Size(900, 320);
            pnlEscenario.TabIndex = 1;

            // 
            // pbCaballoJuego
            // 
            pbCaballoJuego.BackColor = Color.Transparent;
            pbCaballoJuego.Location = new Point(290, 50);
            pbCaballoJuego.Name = "pbCaballoJuego";
            pbCaballoJuego.Size = new Size(320, 220);
            pbCaballoJuego.SizeMode = PictureBoxSizeMode.Zoom;
            pbCaballoJuego.TabIndex = 0;
            pbCaballoJuego.TabStop = false;

            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.BackColor = Color.LightGray;
            lblFeedback.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblFeedback.ForeColor = Color.Black;
            lblFeedback.Location = new Point(20, 15);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Padding = new Padding(10, 8, 10, 8);
            lblFeedback.Size = new Size(150, 30);
            lblFeedback.TabIndex = 1;
            lblFeedback.Text = "Esperando...";

            // 
            // pnlSecuenciaUsuario
            // 
            pnlSecuenciaUsuario.AllowDrop = true;
            pnlSecuenciaUsuario.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnlSecuenciaUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlSecuenciaUsuario.Dock = DockStyle.Top;
            pnlSecuenciaUsuario.Margin = new Padding(12);
            pnlSecuenciaUsuario.Padding = new Padding(15);
            pnlSecuenciaUsuario.Size = new Size(900, 100);
            pnlSecuenciaUsuario.TabIndex = 2;

            // 
            // flpComandos
            // 
            flpComandos.AutoScroll = true;
            flpComandos.BackColor = Color.Transparent;
            flpComandos.Dock = DockStyle.Fill;
            flpComandos.Location = new Point(0, 500);
            flpComandos.Name = "flpComandos";
            flpComandos.Padding = new Padding(15);
            flpComandos.Size = new Size(900, 120);
            flpComandos.TabIndex = 3;
            flpComandos.WrapContents = true;

            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblInstrucciones.ForeColor = Color.FromArgb(100, 100, 100);
            lblInstrucciones.Location = new Point(15, 470);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(200, 23);
            lblInstrucciones.TabIndex = 4;
            lblInstrucciones.Text = "Presiona el botón para comenzar";

            // 
            // Juego
            // 
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            Controls.Add(flpComandos);
            Controls.Add(lblInstrucciones);
            Controls.Add(pnlSecuenciaUsuario);
            Controls.Add(pnlEscenario);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            Name = "Juego";
            Size = new Size(900, 620);
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlEscenario.ResumeLayout(false);
            pnlEscenario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaballoJuego).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlEscenario;
        private Panel pnlSecuenciaUsuario;
        private FlowLayoutPanel flpComandos;
        private PictureBox pbCaballoJuego;
        private Button btnComenzarDesafio;
        private Label lblFeedback;
        private ProgressBar progressBar1;
        private Label lblNivel;
        private Label lblInstrucciones;
    }
}
