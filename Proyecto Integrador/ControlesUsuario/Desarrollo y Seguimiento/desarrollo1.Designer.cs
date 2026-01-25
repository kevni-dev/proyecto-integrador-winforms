namespace Proyecto_Integrador.ControlesUsuario.Desarrollo_y_Seguimiento
{
    partial class desarrollo1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(desarrollo1));
            cmbCaballos = new ComboBox();
            lblCaballo = new Label();
            lblEdadTexto = new Label();
            txtEdad = new TextBox();
            lblPesoTexto = new Label();
            txtPeso = new TextBox();
            lblAlimentacionTexto = new Label();
            txtAlimentacion = new TextBox();
            lblClasificacionTexto = new Label();
            lblClasificacion = new Label();
            btnGuardar = new Button();
            grpResultados = new GroupBox();
            lblResultadoClasificacion = new Label();
            lblResultadoAlimentacion = new Label();
            lblResultadoPeso = new Label();
            lblResultadoEdad = new Label();
            picCaballo = new PictureBox();
            btnDatoCurioso = new Button();
            grpResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCaballo).BeginInit();
            SuspendLayout();
            // 
            // cmbCaballos
            // 
            cmbCaballos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCaballos.FormattingEnabled = true;
            cmbCaballos.Location = new Point(601, 132);
            cmbCaballos.Name = "cmbCaballos";
            cmbCaballos.Size = new Size(179, 23);
            cmbCaballos.TabIndex = 0;
            // 
            // lblCaballo
            // 
            lblCaballo.AutoSize = true;
            lblCaballo.BackColor = Color.FromArgb(255, 255, 192);
            lblCaballo.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCaballo.Location = new Point(601, 101);
            lblCaballo.Name = "lblCaballo";
            lblCaballo.Size = new Size(159, 19);
            lblCaballo.TabIndex = 1;
            lblCaballo.Text = "Seleccione el caballo:";
            // 
            // lblEdadTexto
            // 
            lblEdadTexto.AutoSize = true;
            lblEdadTexto.BackColor = Color.FromArgb(192, 255, 192);
            lblEdadTexto.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEdadTexto.Location = new Point(601, 170);
            lblEdadTexto.Name = "lblEdadTexto";
            lblEdadTexto.Size = new Size(50, 19);
            lblEdadTexto.TabIndex = 2;
            lblEdadTexto.Text = "Edad:";
            lblEdadTexto.Click += lblEdadTexto_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(601, 201);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 23);
            txtEdad.TabIndex = 3;
            // 
            // lblPesoTexto
            // 
            lblPesoTexto.AutoSize = true;
            lblPesoTexto.BackColor = Color.FromArgb(192, 255, 255);
            lblPesoTexto.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPesoTexto.Location = new Point(601, 247);
            lblPesoTexto.Name = "lblPesoTexto";
            lblPesoTexto.Size = new Size(82, 19);
            lblPesoTexto.TabIndex = 4;
            lblPesoTexto.Text = "Peso (kg):";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(601, 281);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(125, 23);
            txtPeso.TabIndex = 5;
            // 
            // lblAlimentacionTexto
            // 
            lblAlimentacionTexto.AutoSize = true;
            lblAlimentacionTexto.BackColor = Color.FromArgb(255, 224, 192);
            lblAlimentacionTexto.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlimentacionTexto.Location = new Point(892, 101);
            lblAlimentacionTexto.Name = "lblAlimentacionTexto";
            lblAlimentacionTexto.Size = new Size(105, 19);
            lblAlimentacionTexto.TabIndex = 6;
            lblAlimentacionTexto.Text = "Alimentación:";
            // 
            // txtAlimentacion
            // 
            txtAlimentacion.Location = new Point(892, 132);
            txtAlimentacion.Name = "txtAlimentacion";
            txtAlimentacion.Size = new Size(140, 23);
            txtAlimentacion.TabIndex = 7;
            // 
            // lblClasificacionTexto
            // 
            lblClasificacionTexto.AutoSize = true;
            lblClasificacionTexto.BackColor = Color.FromArgb(255, 192, 255);
            lblClasificacionTexto.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClasificacionTexto.Location = new Point(892, 184);
            lblClasificacionTexto.Name = "lblClasificacionTexto";
            lblClasificacionTexto.Size = new Size(103, 19);
            lblClasificacionTexto.TabIndex = 8;
            lblClasificacionTexto.Text = "Clasificación:";
            // 
            // lblClasificacion
            // 
            lblClasificacion.AutoSize = true;
            lblClasificacion.BackColor = Color.FromArgb(128, 255, 128);
            lblClasificacion.Location = new Point(892, 281);
            lblClasificacion.Name = "lblClasificacion";
            lblClasificacion.Size = new Size(0, 15);
            lblClasificacion.TabIndex = 9;
            lblClasificacion.Click += label1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(128, 255, 128);
            btnGuardar.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(766, 342);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(110, 34);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar:";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // grpResultados
            // 
            grpResultados.Controls.Add(lblResultadoClasificacion);
            grpResultados.Controls.Add(lblResultadoAlimentacion);
            grpResultados.Controls.Add(lblResultadoPeso);
            grpResultados.Controls.Add(lblResultadoEdad);
            grpResultados.Location = new Point(892, 215);
            grpResultados.Name = "grpResultados";
            grpResultados.Size = new Size(159, 124);
            grpResultados.TabIndex = 11;
            grpResultados.TabStop = false;
            grpResultados.Text = "Resultados del caballo:";
            // 
            // lblResultadoClasificacion
            // 
            lblResultadoClasificacion.AutoSize = true;
            lblResultadoClasificacion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoClasificacion.Location = new Point(6, 102);
            lblResultadoClasificacion.Name = "lblResultadoClasificacion";
            lblResultadoClasificacion.Size = new Size(0, 17);
            lblResultadoClasificacion.TabIndex = 3;
            // 
            // lblResultadoAlimentacion
            // 
            lblResultadoAlimentacion.AutoSize = true;
            lblResultadoAlimentacion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoAlimentacion.Location = new Point(6, 74);
            lblResultadoAlimentacion.Name = "lblResultadoAlimentacion";
            lblResultadoAlimentacion.Size = new Size(0, 17);
            lblResultadoAlimentacion.TabIndex = 2;
            // 
            // lblResultadoPeso
            // 
            lblResultadoPeso.AutoSize = true;
            lblResultadoPeso.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoPeso.Location = new Point(6, 45);
            lblResultadoPeso.Name = "lblResultadoPeso";
            lblResultadoPeso.Size = new Size(0, 17);
            lblResultadoPeso.TabIndex = 1;
            // 
            // lblResultadoEdad
            // 
            lblResultadoEdad.AutoSize = true;
            lblResultadoEdad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoEdad.Location = new Point(6, 19);
            lblResultadoEdad.Name = "lblResultadoEdad";
            lblResultadoEdad.Size = new Size(0, 17);
            lblResultadoEdad.TabIndex = 0;
            // 
            // picCaballo
            // 
            picCaballo.BackColor = Color.Transparent;
            picCaballo.BorderStyle = BorderStyle.FixedSingle;
            picCaballo.Location = new Point(690, 382);
            picCaballo.Name = "picCaballo";
            picCaballo.Size = new Size(305, 163);
            picCaballo.SizeMode = PictureBoxSizeMode.StretchImage;
            picCaballo.TabIndex = 12;
            picCaballo.TabStop = false;
            // 
            // btnDatoCurioso
            // 
            btnDatoCurioso.BackColor = Color.FromArgb(128, 255, 255);
            btnDatoCurioso.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDatoCurioso.Location = new Point(783, 577);
            btnDatoCurioso.Name = "btnDatoCurioso";
            btnDatoCurioso.Size = new Size(135, 27);
            btnDatoCurioso.TabIndex = 13;
            btnDatoCurioso.Text = "Dato curioso";
            btnDatoCurioso.UseVisualStyleBackColor = false;
            btnDatoCurioso.Click += btnDatoCurioso_Click;
            // 
            // desarrollo1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(btnDatoCurioso);
            Controls.Add(picCaballo);
            Controls.Add(grpResultados);
            Controls.Add(btnGuardar);
            Controls.Add(lblClasificacion);
            Controls.Add(lblClasificacionTexto);
            Controls.Add(txtAlimentacion);
            Controls.Add(lblAlimentacionTexto);
            Controls.Add(txtPeso);
            Controls.Add(lblPesoTexto);
            Controls.Add(txtEdad);
            Controls.Add(lblEdadTexto);
            Controls.Add(cmbCaballos);
            Controls.Add(lblCaballo);
            Name = "desarrollo1";
            Size = new Size(1140, 607);
            Load += desarrollo1_Load;
            grpResultados.ResumeLayout(false);
            grpResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCaballo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCaballos;
        private Label lblCaballo;
        private Label lblEdadTexto;
        private TextBox txtEdad;
        private Label lblPesoTexto;
        private TextBox txtPeso;
        private Label lblAlimentacionTexto;
        private TextBox txtAlimentacion;
        private Label lblClasificacionTexto;
        private Label lblClasificacion;
        private Button btnGuardar;
        private GroupBox grpResultados;
        private Label lblResultadoAlimentacion;
        private Label lblResultadoPeso;
        private Label lblResultadoEdad;
        private Label lblResultadoClasificacion;
        private PictureBox picCaballo;
        private Button btnDatoCurioso;
    }
}
