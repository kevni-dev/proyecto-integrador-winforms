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
            tableLayoutPanel2 = new TableLayoutPanel();
            lblNivel = new Label();
            pnlBotonesControl = new FlowLayoutPanel();
            btnIniciarJuego = new Button();
            btnComenzarDesafio = new Button();
            btnDeshacerAccion = new Button();
            btnMostrarManual = new Button();
            btnReiniciarJuego = new Button();
            cmbDificultad = new ComboBox();
            progressBar1 = new ProgressBar();
            pnlEscenario = new Panel();
            lblInfoCaballo = new Label();
            pbCaballoJuego = new PictureBox();
            lblFeedback = new Label();
            pnlBienestar = new Panel();
            lblBienestar = new Label();
            progressBienestar = new ProgressBar();
            pnlSecuenciaUsuario = new FlowLayoutPanel();
            lblTooltipSecuencia = new Label();
            lblInstrucciones = new Label();
            flpComandos = new FlowLayoutPanel();
            lblTooltipComandos = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlHeader.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlBotonesControl.SuspendLayout();
            pnlEscenario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaballoJuego).BeginInit();
            pnlBienestar.SuspendLayout();
            pnlSecuenciaUsuario.SuspendLayout();
            flpComandos.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(101, 67, 33);
            pnlHeader.Controls.Add(tableLayoutPanel2);
            pnlHeader.Dock = DockStyle.Fill;
            pnlHeader.Location = new Point(3, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(5);
            pnlHeader.Size = new Size(986, 54);
            pnlHeader.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.Controls.Add(lblNivel, 0, 0);
            tableLayoutPanel2.Controls.Add(pnlBotonesControl, 1, 0);
            tableLayoutPanel2.Controls.Add(progressBar1, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 5);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(976, 44);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // lblNivel
            // 
            lblNivel.Dock = DockStyle.Fill;
            lblNivel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblNivel.ForeColor = Color.White;
            lblNivel.Location = new Point(3, 0);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(94, 44);
            lblNivel.TabIndex = 2;
            lblNivel.Text = "Nivel 1";
            lblNivel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBotonesControl
            // 
            pnlBotonesControl.Controls.Add(btnIniciarJuego);
            pnlBotonesControl.Controls.Add(btnComenzarDesafio);
            pnlBotonesControl.Controls.Add(btnDeshacerAccion);
            pnlBotonesControl.Controls.Add(btnMostrarManual);
            pnlBotonesControl.Controls.Add(btnReiniciarJuego);
            pnlBotonesControl.Controls.Add(cmbDificultad);
            pnlBotonesControl.Dock = DockStyle.Fill;
            pnlBotonesControl.Location = new Point(100, 0);
            pnlBotonesControl.Margin = new Padding(0);
            pnlBotonesControl.Name = "pnlBotonesControl";
            pnlBotonesControl.Size = new Size(525, 44);
            pnlBotonesControl.TabIndex = 3;
            // 
            // btnIniciarJuego
            // 
            btnIniciarJuego.BackColor = Color.FromArgb(34, 139, 34);
            btnIniciarJuego.Cursor = Cursors.Hand;
            btnIniciarJuego.FlatAppearance.BorderSize = 0;
            btnIniciarJuego.FlatStyle = FlatStyle.Flat;
            btnIniciarJuego.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIniciarJuego.ForeColor = Color.White;
            btnIniciarJuego.Location = new Point(3, 3);
            btnIniciarJuego.Name = "btnIniciarJuego";
            btnIniciarJuego.Size = new Size(110, 38);
            btnIniciarJuego.TabIndex = 1;
            btnIniciarJuego.Text = "▶️ INICIAR";
            btnIniciarJuego.UseVisualStyleBackColor = false;
            // 
            // btnComenzarDesafio
            // 
            btnComenzarDesafio.BackColor = Color.FromArgb(184, 134, 11);
            btnComenzarDesafio.Cursor = Cursors.Hand;
            btnComenzarDesafio.FlatAppearance.BorderSize = 0;
            btnComenzarDesafio.FlatStyle = FlatStyle.Flat;
            btnComenzarDesafio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnComenzarDesafio.ForeColor = Color.White;
            btnComenzarDesafio.Location = new Point(119, 3);
            btnComenzarDesafio.Name = "btnComenzarDesafio";
            btnComenzarDesafio.Size = new Size(120, 38);
            btnComenzarDesafio.TabIndex = 0;
            btnComenzarDesafio.Text = "🐴 VER SEC.";
            btnComenzarDesafio.UseVisualStyleBackColor = false;
            btnComenzarDesafio.Visible = false;
            // 
            // btnDeshacerAccion
            // 
            btnDeshacerAccion.BackColor = Color.FromArgb(255, 140, 0);
            btnDeshacerAccion.Cursor = Cursors.Hand;
            btnDeshacerAccion.Enabled = false;
            btnDeshacerAccion.FlatAppearance.BorderSize = 0;
            btnDeshacerAccion.FlatStyle = FlatStyle.Flat;
            btnDeshacerAccion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDeshacerAccion.ForeColor = Color.White;
            btnDeshacerAccion.Location = new Point(245, 3);
            btnDeshacerAccion.Name = "btnDeshacerAccion";
            btnDeshacerAccion.Size = new Size(100, 38);
            btnDeshacerAccion.TabIndex = 2;
            btnDeshacerAccion.Text = "↶ Deshacer";
            btnDeshacerAccion.UseVisualStyleBackColor = false;
            btnDeshacerAccion.Visible = false;
            // 
            // btnMostrarManual
            // 
            btnMostrarManual.BackColor = Color.FromArgb(70, 130, 180);
            btnMostrarManual.Cursor = Cursors.Hand;
            btnMostrarManual.FlatAppearance.BorderSize = 0;
            btnMostrarManual.FlatStyle = FlatStyle.Flat;
            btnMostrarManual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMostrarManual.ForeColor = Color.White;
            btnMostrarManual.Location = new Point(351, 3);
            btnMostrarManual.Name = "btnMostrarManual";
            btnMostrarManual.Size = new Size(80, 38);
            btnMostrarManual.TabIndex = 4;
            btnMostrarManual.Text = "📖 Manual";
            btnMostrarManual.UseVisualStyleBackColor = false;
            // 
            // btnReiniciarJuego
            // 
            btnReiniciarJuego.BackColor = Color.FromArgb(220, 20, 60);
            btnReiniciarJuego.Cursor = Cursors.Hand;
            btnReiniciarJuego.FlatAppearance.BorderSize = 0;
            btnReiniciarJuego.FlatStyle = FlatStyle.Flat;
            btnReiniciarJuego.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReiniciarJuego.ForeColor = Color.White;
            btnReiniciarJuego.Location = new Point(437, 3);
            btnReiniciarJuego.Name = "btnReiniciarJuego";
            btnReiniciarJuego.Size = new Size(80, 38);
            btnReiniciarJuego.TabIndex = 6;
            btnReiniciarJuego.Text = "🔄 Reiniciar";
            btnReiniciarJuego.UseVisualStyleBackColor = false;
            // 
            // cmbDificultad
            // 
            cmbDificultad.BackColor = Color.FromArgb(240, 240, 240);
            cmbDificultad.Cursor = Cursors.Hand;
            cmbDificultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDificultad.FlatStyle = FlatStyle.Flat;
            cmbDificultad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmbDificultad.ForeColor = Color.FromArgb(60, 60, 60);
            cmbDificultad.FormattingEnabled = true;
            cmbDificultad.Items.AddRange(new object[] { "⭐ Fácil", "⭐⭐ Difícil" });
            cmbDificultad.Location = new Point(3, 47);
            cmbDificultad.Name = "cmbDificultad";
            cmbDificultad.Size = new Size(120, 25);
            cmbDificultad.TabIndex = 5;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(628, 3);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(345, 38);
            progressBar1.TabIndex = 1;
            progressBar1.Value = 10;
            // 
            // pnlEscenario
            // 
            pnlEscenario.BackgroundImage = Properties.Resources._2;
            pnlEscenario.BackgroundImageLayout = ImageLayout.Stretch;
            pnlEscenario.BorderStyle = BorderStyle.FixedSingle;
            pnlEscenario.Controls.Add(lblInfoCaballo);
            pnlEscenario.Controls.Add(pbCaballoJuego);
            pnlEscenario.Controls.Add(lblFeedback);
            pnlEscenario.Controls.Add(pnlBienestar);
            pnlEscenario.Dock = DockStyle.Fill;
            pnlEscenario.Location = new Point(12, 72);
            pnlEscenario.Margin = new Padding(12);
            pnlEscenario.Name = "pnlEscenario";
            pnlEscenario.Padding = new Padding(20);
            pnlEscenario.Size = new Size(968, 297);
            pnlEscenario.TabIndex = 1;
            // 
            // lblInfoCaballo
            // 
            lblInfoCaballo.AutoSize = true;
            lblInfoCaballo.BackColor = Color.FromArgb(200, 0, 0, 0);
            lblInfoCaballo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInfoCaballo.ForeColor = Color.White;
            lblInfoCaballo.Location = new Point(20, 250);
            lblInfoCaballo.Name = "lblInfoCaballo";
            lblInfoCaballo.Padding = new Padding(8, 5, 8, 5);
            lblInfoCaballo.Size = new Size(227, 29);
            lblInfoCaballo.TabIndex = 4;
            lblInfoCaballo.Text = "🐴 Caballo de entrenamiento";
            lblInfoCaballo.Visible = false;
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
            // pnlBienestar
            // 
            pnlBienestar.BackColor = Color.FromArgb(200, 0, 0, 0);
            pnlBienestar.BorderStyle = BorderStyle.FixedSingle;
            pnlBienestar.Controls.Add(lblBienestar);
            pnlBienestar.Controls.Add(progressBienestar);
            pnlBienestar.Location = new Point(720, 15);
            pnlBienestar.Name = "pnlBienestar";
            pnlBienestar.Padding = new Padding(8);
            pnlBienestar.Size = new Size(220, 70);
            pnlBienestar.TabIndex = 3;
            // 
            // lblBienestar
            // 
            lblBienestar.AutoSize = true;
            lblBienestar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBienestar.ForeColor = Color.FromArgb(0, 150, 0);
            lblBienestar.Location = new Point(11, 8);
            lblBienestar.Name = "lblBienestar";
            lblBienestar.Size = new Size(132, 19);
            lblBienestar.TabIndex = 1;
            lblBienestar.Text = "💚 Vínculo: 100%";
            // 
            // progressBienestar
            // 
            progressBienestar.Dock = DockStyle.Bottom;
            progressBienestar.ForeColor = Color.FromArgb(144, 238, 144);
            progressBienestar.Location = new Point(8, 35);
            progressBienestar.Name = "progressBienestar";
            progressBienestar.Size = new Size(202, 25);
            progressBienestar.TabIndex = 0;
            progressBienestar.Value = 100;
            // 
            // pnlSecuenciaUsuario
            // 
            pnlSecuenciaUsuario.AllowDrop = true;
            pnlSecuenciaUsuario.AutoScroll = true;
            pnlSecuenciaUsuario.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnlSecuenciaUsuario.BorderStyle = BorderStyle.Fixed3D;
            pnlSecuenciaUsuario.Controls.Add(lblTooltipSecuencia);
            pnlSecuenciaUsuario.Controls.Add(lblInstrucciones);
            pnlSecuenciaUsuario.Dock = DockStyle.Fill;
            pnlSecuenciaUsuario.FlowDirection = FlowDirection.LeftToRight;
            pnlSecuenciaUsuario.Location = new Point(12, 393);
            pnlSecuenciaUsuario.Margin = new Padding(12);
            pnlSecuenciaUsuario.Name = "pnlSecuenciaUsuario";
            pnlSecuenciaUsuario.Padding = new Padding(15);
            pnlSecuenciaUsuario.Size = new Size(968, 57);
            pnlSecuenciaUsuario.TabIndex = 2;
            pnlSecuenciaUsuario.WrapContents = true;
            // 
            // lblTooltipSecuencia
            // 
            lblTooltipSecuencia.AutoSize = true;
            lblTooltipSecuencia.BackColor = Color.FromArgb(150, 255, 215, 0);
            lblTooltipSecuencia.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblTooltipSecuencia.ForeColor = Color.FromArgb(80, 80, 80);
            lblTooltipSecuencia.Location = new Point(18, 15);
            lblTooltipSecuencia.Name = "lblTooltipSecuencia";
            lblTooltipSecuencia.Padding = new Padding(5);
            lblTooltipSecuencia.Size = new Size(269, 25);
            lblTooltipSecuencia.TabIndex = 5;
            lblTooltipSecuencia.Text = "💡 Arrastra los comandos aquí en orden ➜";
            lblTooltipSecuencia.Visible = false;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.AutoSize = true;
            lblInstrucciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblInstrucciones.ForeColor = Color.White;
            lblInstrucciones.Location = new Point(293, 15);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Padding = new Padding(5);
            lblInstrucciones.Size = new Size(252, 29);
            lblInstrucciones.TabIndex = 4;
            lblInstrucciones.Text = "Presiona el botón para comenzar";
            // 
            // flpComandos
            // 
            flpComandos.AutoScroll = true;
            flpComandos.BackColor = Color.Transparent;
            flpComandos.Controls.Add(lblTooltipComandos);
            flpComandos.Dock = DockStyle.Fill;
            flpComandos.Location = new Point(3, 465);
            flpComandos.Name = "flpComandos";
            flpComandos.Padding = new Padding(15);
            flpComandos.Size = new Size(986, 78);
            flpComandos.TabIndex = 3;
            // 
            // lblTooltipComandos
            // 
            lblTooltipComandos.AutoSize = true;
            lblTooltipComandos.BackColor = Color.FromArgb(150, 173, 216, 230);
            lblTooltipComandos.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblTooltipComandos.ForeColor = Color.FromArgb(60, 60, 60);
            lblTooltipComandos.Location = new Point(18, 15);
            lblTooltipComandos.Name = "lblTooltipComandos";
            lblTooltipComandos.Padding = new Padding(8, 5, 8, 5);
            lblTooltipComandos.Size = new Size(339, 25);
            lblTooltipComandos.TabIndex = 0;
            lblTooltipComandos.Text = "💡 Estos son los comandos que puedes usar ➜";
            lblTooltipComandos.Visible = false;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(992, 546);
            tableLayoutPanel1.TabIndex = 4;
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
            tableLayoutPanel2.ResumeLayout(false);
            pnlBotonesControl.ResumeLayout(false);
            pnlEscenario.ResumeLayout(false);
            pnlEscenario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaballoJuego).EndInit();
            pnlBienestar.ResumeLayout(false);
            pnlBienestar.PerformLayout();
            pnlSecuenciaUsuario.ResumeLayout(false);
            pnlSecuenciaUsuario.PerformLayout();
            flpComandos.ResumeLayout(false);
            flpComandos.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlEscenario;
        private FlowLayoutPanel pnlSecuenciaUsuario;
        private FlowLayoutPanel flpComandos;
        private PictureBox pbCaballoJuego;
        private Button btnComenzarDesafio;
        private Label lblFeedback;
        private ProgressBar progressBar1;
        private Label lblNivel;
        private Label lblInstrucciones;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnIniciarJuego;
        private Button btnDeshacerAccion;
        private Panel pnlBienestar;
        private ProgressBar progressBienestar;
        private Label lblBienestar;
        private Label lblInfoCaballo;
        private Label lblTooltipComandos;
        private Label lblTooltipSecuencia;
        private FlowLayoutPanel pnlBotonesControl;
        private Button btnMostrarManual;
        private ComboBox cmbDificultad;
        private Button btnReiniciarJuego;
    }
}