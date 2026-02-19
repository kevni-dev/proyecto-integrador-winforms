namespace Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento
{
    partial class JuegoMemoramaFacil
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoMemoramaFacil));
            PanelJuego = new Panel();
            btnReiniciar = new Button();
            lblRecord = new Label();
            lblMemorama = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            timerCronometro = new System.Windows.Forms.Timer(components);
            lblTiempo = new Label();
            btnVolver = new Button();
            btnInfo = new Button();
            panelInstrucciones = new Panel();
            btnCerrar = new Button();
            lblInstrucciones = new Label();
            btnModoNormal = new Button();
            pictureBox1 = new PictureBox();
            panelInstrucciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelJuego
            // 
            PanelJuego.Location = new Point(71, 79);
            PanelJuego.Name = "PanelJuego";
            PanelJuego.Size = new Size(564, 481);
            PanelJuego.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(255, 192, 128);
            btnReiniciar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReiniciar.Location = new Point(680, 370);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(211, 40);
            btnReiniciar.TabIndex = 1;
            btnReiniciar.Text = "Reiniciar Juego";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecord.Location = new Point(680, 83);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(156, 33);
            lblRecord.TabIndex = 2;
            lblRecord.Text = "Record:  0";
            // 
            // lblMemorama
            // 
            lblMemorama.AutoSize = true;
            lblMemorama.Font = new Font("Ravie", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMemorama.Location = new Point(162, 29);
            lblMemorama.Name = "lblMemorama";
            lblMemorama.Size = new Size(340, 36);
            lblMemorama.TabIndex = 3;
            lblMemorama.Text = "Memorama (facil)";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 500;
            timer2.Tick += timer2_Tick;
            // 
            // timerCronometro
            // 
            timerCronometro.Interval = 1000;
            timerCronometro.Tick += timerCronometro_Tick;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempo.Location = new Point(523, 49);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(124, 27);
            lblTiempo.TabIndex = 4;
            lblTiempo.Text = "Tiempo: 25";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(192, 255, 192);
            btnVolver.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(3, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(83, 28);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver ";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.FromArgb(128, 255, 255);
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Script MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfo.Location = new Point(1076, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(55, 45);
            btnInfo.TabIndex = 6;
            btnInfo.Text = "i";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // panelInstrucciones
            // 
            panelInstrucciones.BackColor = Color.White;
            panelInstrucciones.BorderStyle = BorderStyle.FixedSingle;
            panelInstrucciones.Controls.Add(btnCerrar);
            panelInstrucciones.Controls.Add(lblInstrucciones);
            panelInstrucciones.Location = new Point(852, 54);
            panelInstrucciones.Name = "panelInstrucciones";
            panelInstrucciones.Size = new Size(263, 379);
            panelInstrucciones.TabIndex = 7;
            panelInstrucciones.Visible = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(223, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(35, 30);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.Dock = DockStyle.Fill;
            lblInstrucciones.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstrucciones.Location = new Point(0, 0);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(261, 377);
            lblInstrucciones.TabIndex = 0;
            lblInstrucciones.Text = resources.GetString("lblInstrucciones.Text");
            // 
            // btnModoNormal
            // 
            btnModoNormal.BackColor = Color.FromArgb(192, 255, 192);
            btnModoNormal.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModoNormal.Location = new Point(718, 416);
            btnModoNormal.Name = "btnModoNormal";
            btnModoNormal.Size = new Size(157, 30);
            btnModoNormal.TabIndex = 8;
            btnModoNormal.Text = "Siguiente nivel";
            btnModoNormal.UseVisualStyleBackColor = false;
            btnModoNormal.Click += btnModoNormal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(668, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // JuegoMemoramaFacil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(pictureBox1);
            Controls.Add(btnModoNormal);
            Controls.Add(panelInstrucciones);
            Controls.Add(btnInfo);
            Controls.Add(btnVolver);
            Controls.Add(lblTiempo);
            Controls.Add(lblMemorama);
            Controls.Add(lblRecord);
            Controls.Add(btnReiniciar);
            Controls.Add(PanelJuego);
            Name = "JuegoMemoramaFacil";
            Size = new Size(1134, 572);
            Load += JuegoMemoramaFacil_Load;
            panelInstrucciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelJuego;
        private Button btnReiniciar;
        private Label lblRecord;
        private Label lblMemorama;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerCronometro;
        private Label lblTiempo;
        private Button btnVolver;
        private Button btnInfo;
        private Panel panelInstrucciones;
        private Label lblInstrucciones;
        private Button btnCerrar;
        private Button btnModoNormal;
        private PictureBox pictureBox1;
    }
}
