namespace Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento
{
    partial class datocurioso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(datocurioso));
            btnPotro = new Button();
            btnJuvenil = new Button();
            btnAdulto = new Button();
            lblEtapa = new Label();
            lblInfo = new Label();
            btnVolver = new Button();
            btnMiniJuego = new Button();
            SuspendLayout();
            // 
            // btnPotro
            // 
            btnPotro.BackColor = Color.FromArgb(255, 192, 192);
            btnPotro.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPotro.Location = new Point(176, 199);
            btnPotro.Name = "btnPotro";
            btnPotro.Size = new Size(75, 29);
            btnPotro.TabIndex = 0;
            btnPotro.Text = "Potro";
            btnPotro.UseVisualStyleBackColor = false;
            btnPotro.Click += btnPotro_Click;
            // 
            // btnJuvenil
            // 
            btnJuvenil.BackColor = Color.FromArgb(255, 192, 192);
            btnJuvenil.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJuvenil.Location = new Point(176, 317);
            btnJuvenil.Name = "btnJuvenil";
            btnJuvenil.Size = new Size(75, 30);
            btnJuvenil.TabIndex = 1;
            btnJuvenil.Text = "Juvenil";
            btnJuvenil.UseVisualStyleBackColor = false;
            btnJuvenil.Click += btnJuvenil_Click;
            // 
            // btnAdulto
            // 
            btnAdulto.BackColor = Color.FromArgb(255, 192, 192);
            btnAdulto.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdulto.Location = new Point(176, 450);
            btnAdulto.Name = "btnAdulto";
            btnAdulto.Size = new Size(75, 28);
            btnAdulto.TabIndex = 2;
            btnAdulto.Text = "Adulto";
            btnAdulto.UseVisualStyleBackColor = false;
            btnAdulto.Click += btnAdulto_Click;
            // 
            // lblEtapa
            // 
            lblEtapa.AutoSize = true;
            lblEtapa.BackColor = Color.Transparent;
            lblEtapa.Font = new Font("Stencil", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEtapa.ForeColor = Color.Black;
            lblEtapa.Location = new Point(587, 137);
            lblEtapa.Name = "lblEtapa";
            lblEtapa.Size = new Size(0, 18);
            lblEtapa.TabIndex = 3;
            // 
            // lblInfo
            // 
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(459, 173);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(366, 87);
            lblInfo.TabIndex = 4;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(192, 255, 192);
            btnVolver.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.Location = new Point(3, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(73, 32);
            btnVolver.TabIndex = 5;
            btnVolver.Text = "volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // btnMiniJuego
            // 
            btnMiniJuego.BackColor = Color.FromArgb(255, 128, 128);
            btnMiniJuego.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMiniJuego.Location = new Point(992, 550);
            btnMiniJuego.Name = "btnMiniJuego";
            btnMiniJuego.Size = new Size(102, 49);
            btnMiniJuego.TabIndex = 6;
            btnMiniJuego.Text = "Jugar";
            btnMiniJuego.UseVisualStyleBackColor = false;
            btnMiniJuego.Click += btnMiniJuego_Click;
            // 
            // datocurioso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnMiniJuego);
            Controls.Add(btnVolver);
            Controls.Add(lblInfo);
            Controls.Add(lblEtapa);
            Controls.Add(btnAdulto);
            Controls.Add(btnJuvenil);
            Controls.Add(btnPotro);
            Name = "datocurioso";
            Size = new Size(1140, 607);
            Load += datocurioso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPotro;
        private Button btnJuvenil;
        private Button btnAdulto;
        private Label lblEtapa;
        private Label lblInfo;
        private Button btnVolver;
        private Button btnMiniJuego;
    }
}
