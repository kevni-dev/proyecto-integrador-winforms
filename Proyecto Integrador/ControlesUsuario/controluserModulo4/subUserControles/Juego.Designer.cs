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
            lblInstrucciones = new Label();
            flpComandos = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlHeader.SuspendLayout();
            pnlEscenario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaballoJuego).BeginInit();
            pnlSecuenciaUsuario.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(101, 67, 33);
            pnlHeader.Controls.Add(tableLayoutPanel2);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(2);
            pnlHeader.Size = new Size(986, 48);
            pnlHeader.TabIndex = 0;
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Dock = DockStyle.Fill;
            lblNivel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNivel.ForeColor = Color.White;
            lblNivel.Location = new Point(3, 0);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(92, 44);
            lblNivel.TabIndex = 2;
            lblNivel.Text = "Nivel 1";
            lblNivel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnComenzarDesafio
            // 
            btnComenzarDesafio.BackColor = Color.FromArgb(184, 134, 11);
            btnComenzarDesafio.Cursor = Cursors.Hand;
            btnComenzarDesafio.Dock = DockStyle.Right;
            btnComenzarDesafio.FlatAppearance.BorderSize = 0;
            btnComenzarDesafio.FlatStyle = FlatStyle.Flat;
            btnComenzarDesafio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComenzarDesafio.ForeColor = Color.White;
            btnComenzarDesafio.Location = new Point(250, 3);
            btnComenzarDesafio.Name = "btnComenzarDesafio";
            btnComenzarDesafio.Size = new Size(286, 38);
            btnComenzarDesafio.TabIndex = 0;
            btnComenzarDesafio.Text = "🐴 VER SECUENCIA";
            btnComenzarDesafio.UseVisualStyleBackColor = false;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.FromArgb(150, 150, 150);
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.ForeColor = Color.FromArgb(144, 238, 144);
            progressBar1.Location = new Point(542, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(437, 38);
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
            pnlEscenario.Dock = DockStyle.Fill;
            pnlEscenario.Location = new Point(12, 66);
            pnlEscenario.Margin = new Padding(12);
            pnlEscenario.Name = "pnlEscenario";
            pnlEscenario.Padding = new Padding(20);
            pnlEscenario.Size = new Size(968, 303);
            pnlEscenario.TabIndex = 1;
            // 
            // pbCaballoJuego
            // 
            pbCaballoJuego.BackColor = Color.Transparent;
            pbCaballoJuego.Location = new Point(347, 58);
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
            lblFeedback.Size = new Size(114, 36);
            lblFeedback.TabIndex = 1;
            lblFeedback.Text = "Esperando...";
            // 
            // pnlSecuenciaUsuario
            // 
            pnlSecuenciaUsuario.AllowDrop = true;
            pnlSecuenciaUsuario.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnlSecuenciaUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlSecuenciaUsuario.Controls.Add(lblInstrucciones);
            pnlSecuenciaUsuario.Dock = DockStyle.Fill;
            pnlSecuenciaUsuario.Location = new Point(12, 393);
            pnlSecuenciaUsuario.Margin = new Padding(12);
            pnlSecuenciaUsuario.Name = "pnlSecuenciaUsuario";
            pnlSecuenciaUsuario.Padding = new Padding(15);
            pnlSecuenciaUsuario.Size = new Size(968, 57);
            pnlSecuenciaUsuario.TabIndex = 2;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblInstrucciones.ForeColor = Color.FromArgb(100, 100, 100);
            lblInstrucciones.Location = new Point(750, 36);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(216, 19);
            lblInstrucciones.TabIndex = 4;
            lblInstrucciones.Text = "Presiona el botón para comenzar";
            // 
            // flpComandos
            // 
            flpComandos.AutoScroll = true;
            flpComandos.BackColor = Color.Transparent;
            flpComandos.Dock = DockStyle.Fill;
            flpComandos.Location = new Point(3, 465);
            flpComandos.Name = "flpComandos";
            flpComandos.Padding = new Padding(15);
            flpComandos.Size = new Size(986, 78);
            flpComandos.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(255, 224, 192);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flpComandos, 0, 3);
            tableLayoutPanel1.Controls.Add(pnlHeader, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlEscenario, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlSecuenciaUsuario, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(992, 546);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel2.Controls.Add(progressBar1, 2, 0);
            tableLayoutPanel2.Controls.Add(lblNivel, 0, 0);
            tableLayoutPanel2.Controls.Add(btnComenzarDesafio, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 2);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(982, 44);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // Juego
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F);
            Name = "Juego";
            Size = new Size(992, 546);
            pnlHeader.ResumeLayout(false);
            pnlEscenario.ResumeLayout(false);
            pnlEscenario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaballoJuego).EndInit();
            pnlSecuenciaUsuario.ResumeLayout(false);
            pnlSecuenciaUsuario.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
