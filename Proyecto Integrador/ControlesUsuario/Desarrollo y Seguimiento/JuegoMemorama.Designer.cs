namespace Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento
{
    partial class JuegoMemorama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JuegoMemorama));
            PanelJuego = new Panel();
            btnReiniciar = new Button();
            lblRecord = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            lblMemorama = new Label();
            pictureBox1 = new PictureBox();
            btnVolver = new Button();
            btnInfo = new Button();
            panelInstrucciones = new Panel();
            btnCerrar = new Button();
            lblInstrucciones = new Label();
            lblTiempo = new Label();
            timerCronometro = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelInstrucciones.SuspendLayout();
            SuspendLayout();
            // 
            // PanelJuego
            // 
            PanelJuego.Location = new Point(62, 59);
            PanelJuego.Name = "PanelJuego";
            PanelJuego.Size = new Size(561, 481);
            PanelJuego.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            btnReiniciar.BackColor = Color.FromArgb(255, 192, 128);
            btnReiniciar.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReiniciar.Location = new Point(713, 372);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(210, 37);
            btnReiniciar.TabIndex = 1;
            btnReiniciar.Text = "Reiniciar Juego";
            btnReiniciar.UseVisualStyleBackColor = false;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblRecord
            // 
            lblRecord.AutoSize = true;
            lblRecord.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecord.Location = new Point(688, 59);
            lblRecord.Name = "lblRecord";
            lblRecord.Size = new Size(169, 36);
            lblRecord.TabIndex = 2;
            lblRecord.Text = "Record:  0";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 500;
            // 
            // lblMemorama
            // 
            lblMemorama.AutoSize = true;
            lblMemorama.BackColor = Color.Transparent;
            lblMemorama.Font = new Font("Ravie", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMemorama.Location = new Point(89, 17);
            lblMemorama.Name = "lblMemorama";
            lblMemorama.Size = new Size(403, 39);
            lblMemorama.TabIndex = 3;
            lblMemorama.Text = "Memorama ( Dificil)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(662, 98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(192, 255, 192);
            btnVolver.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(3, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 27);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Cyan;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Script MT Bold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInfo.Location = new Point(1056, 3);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(63, 49);
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
            panelInstrucciones.Location = new Point(863, 58);
            panelInstrucciones.Name = "panelInstrucciones";
            panelInstrucciones.Size = new Size(256, 329);
            panelInstrucciones.TabIndex = 7;
            panelInstrucciones.Visible = false;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.Location = new Point(222, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(29, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblInstrucciones
            // 
            lblInstrucciones.Dock = DockStyle.Fill;
            lblInstrucciones.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstrucciones.Location = new Point(0, 0);
            lblInstrucciones.Name = "lblInstrucciones";
            lblInstrucciones.Size = new Size(254, 327);
            lblInstrucciones.TabIndex = 0;
            lblInstrucciones.Text = resources.GetString("lblInstrucciones.Text");
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiempo.Location = new Point(498, 29);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(125, 27);
            lblTiempo.TabIndex = 8;
            lblTiempo.Text = "Tiempo: 20";
            // 
            // timerCronometro
            // 
            timerCronometro.Interval = 1000;
            timerCronometro.Tick += timerCronometro_Tick;
            // 
            // JuegoMemorama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(lblTiempo);
            Controls.Add(panelInstrucciones);
            Controls.Add(btnInfo);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox1);
            Controls.Add(lblMemorama);
            Controls.Add(lblRecord);
            Controls.Add(btnReiniciar);
            Controls.Add(PanelJuego);
            Name = "JuegoMemorama";
            Size = new Size(1131, 570);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelInstrucciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelJuego;
        private Button btnReiniciar;
        private Label lblRecord;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label lblMemorama;
        private PictureBox pictureBox1;
        private Button btnVolver;
        private Button btnInfo;
        private Panel panelInstrucciones;
        private Label lblInstrucciones;
        private Button btnCerrar;
        private Label lblTiempo;
        private System.Windows.Forms.Timer timerCronometro;
    }
}
