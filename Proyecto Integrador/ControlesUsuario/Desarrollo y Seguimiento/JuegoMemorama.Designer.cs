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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            btnReiniciar.BackColor = Color.FromArgb(128, 255, 128);
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
            lblMemorama.Location = new Point(203, 13);
            lblMemorama.Name = "lblMemorama";
            lblMemorama.Size = new Size(235, 39);
            lblMemorama.TabIndex = 3;
            lblMemorama.Text = "Memorama";
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
            btnVolver.BackColor = Color.FromArgb(255, 192, 128);
            btnVolver.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(785, 415);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(93, 33);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // JuegoMemorama
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            Controls.Add(btnVolver);
            Controls.Add(pictureBox1);
            Controls.Add(lblMemorama);
            Controls.Add(lblRecord);
            Controls.Add(btnReiniciar);
            Controls.Add(PanelJuego);
            Name = "JuegoMemorama";
            Size = new Size(1122, 566);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
