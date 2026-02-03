namespace Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles
{
    partial class TarjetaCaballo
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
            pbImagen = new PictureBox();
            lblNombre = new Label();
            lblRaza = new Label();
            lblSexo = new Label();
            lblTemperamento = new Label();
            pnlIndicador = new Panel();
            lblEdad = new Label();
            btnConfirmacion = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // pbImagen
            // 
            pbImagen.BackColor = Color.White;
            pbImagen.BorderStyle = BorderStyle.FixedSingle;
            pbImagen.Location = new Point(12, 12);
            pbImagen.Margin = new Padding(4, 3, 4, 3);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(210, 185);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 0;
            pbImagen.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(101, 67, 33);
            lblNombre.Location = new Point(12, 200);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(210, 29);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRaza
            // 
            lblRaza.Font = new Font("Segoe UI", 8F);
            lblRaza.ForeColor = Color.FromArgb(101, 67, 33);
            lblRaza.Location = new Point(12, 250);
            lblRaza.Margin = new Padding(4, 0, 4, 0);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(210, 21);
            lblRaza.TabIndex = 2;
            lblRaza.Text = "Raza: Árabe";
            lblRaza.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblSexo
            // 
            lblSexo.Font = new Font("Segoe UI", 8F);
            lblSexo.ForeColor = Color.FromArgb(101, 67, 33);
            lblSexo.Location = new Point(12, 271);
            lblSexo.Margin = new Padding(4, 0, 4, 0);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(210, 21);
            lblSexo.TabIndex = 3;
            lblSexo.Text = "Sexo: Macho";
            lblSexo.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblTemperamento
            // 
            lblTemperamento.Font = new Font("Segoe UI", 8F);
            lblTemperamento.ForeColor = Color.FromArgb(101, 67, 33);
            lblTemperamento.Location = new Point(12, 292);
            lblTemperamento.Margin = new Padding(4, 0, 4, 0);
            lblTemperamento.Name = "lblTemperamento";
            lblTemperamento.Size = new Size(210, 21);
            lblTemperamento.TabIndex = 4;
            lblTemperamento.Text = "Temperamento: Tranquilo";
            lblTemperamento.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlIndicador
            // 
            pnlIndicador.BackColor = Color.Gray;
            pnlIndicador.Location = new Point(6, 316);
            pnlIndicador.Margin = new Padding(4, 3, 4, 3);
            pnlIndicador.Name = "pnlIndicador";
            pnlIndicador.Size = new Size(163, 19);
            pnlIndicador.TabIndex = 5;
            // 
            // lblEdad
            // 
            lblEdad.Font = new Font("Segoe UI", 8F);
            lblEdad.ForeColor = Color.FromArgb(101, 67, 33);
            lblEdad.Location = new Point(12, 229);
            lblEdad.Margin = new Padding(4, 0, 4, 0);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(210, 21);
            lblEdad.TabIndex = 6;
            lblEdad.Text = "Raza: Árabe";
            lblEdad.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnConfirmacion
            // 
            btnConfirmacion.Location = new Point(176, 316);
            btnConfirmacion.Name = "btnConfirmacion";
            btnConfirmacion.Size = new Size(54, 19);
            btnConfirmacion.TabIndex = 7;
            btnConfirmacion.UseVisualStyleBackColor = true;
            // 
            // TarjetaCaballo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 237, 220);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(btnConfirmacion);
            Controls.Add(lblEdad);
            Controls.Add(pnlIndicador);
            Controls.Add(lblTemperamento);
            Controls.Add(lblSexo);
            Controls.Add(lblRaza);
            Controls.Add(lblNombre);
            Controls.Add(pbImagen);
            Cursor = Cursors.Hand;
            Margin = new Padding(4, 3, 4, 3);
            Name = "TarjetaCaballo";
            Size = new Size(233, 340);
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private PictureBox pbImagen;
        private Label lblNombre;
        private Label lblRaza;
        private Label lblSexo;
        private Label lblTemperamento;
        private Panel pnlIndicador;
        private Label lblEdad;
        private Button btnConfirmacion;
    }
}
