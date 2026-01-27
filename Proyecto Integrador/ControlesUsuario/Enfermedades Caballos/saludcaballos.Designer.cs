namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class Saludcaballos
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
            btn_enferme = new Button();
            btn_tratamiento = new Button();
            btn_prevencion = new Button();
            btn_minijuego = new Button();
            lbl_titulo = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            dtgv_caballos = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_caballos).BeginInit();
            SuspendLayout();
            // 
            // btn_enferme
            // 
            btn_enferme.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_enferme.Location = new Point(0, 0);
            btn_enferme.Name = "btn_enferme";
            btn_enferme.Size = new Size(269, 104);
            btn_enferme.TabIndex = 0;
            btn_enferme.Text = "Enfermedades";
            btn_enferme.UseVisualStyleBackColor = true;
            btn_enferme.Click += btn_enferme_Click;
            // 
            // btn_tratamiento
            // 
            btn_tratamiento.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_tratamiento.Location = new Point(0, 110);
            btn_tratamiento.Name = "btn_tratamiento";
            btn_tratamiento.Size = new Size(272, 104);
            btn_tratamiento.TabIndex = 1;
            btn_tratamiento.Text = "Tratamientos";
            btn_tratamiento.UseVisualStyleBackColor = true;
            btn_tratamiento.Click += btn_tratamiento_Click;
            // 
            // btn_prevencion
            // 
            btn_prevencion.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_prevencion.Location = new Point(3, 220);
            btn_prevencion.Name = "btn_prevencion";
            btn_prevencion.Size = new Size(266, 104);
            btn_prevencion.TabIndex = 2;
            btn_prevencion.Text = "Prevención";
            btn_prevencion.UseVisualStyleBackColor = true;
            // 
            // btn_minijuego
            // 
            btn_minijuego.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_minijuego.Location = new Point(0, 330);
            btn_minijuego.Name = "btn_minijuego";
            btn_minijuego.Size = new Size(272, 104);
            btn_minijuego.TabIndex = 3;
            btn_minijuego.Text = "Minijuego";
            btn_minijuego.UseVisualStyleBackColor = true;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.Location = new Point(21, 26);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(393, 35);
            lbl_titulo.TabIndex = 4;
            lbl_titulo.Text = "Salud de los caballos ";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_titulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 94);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_enferme);
            panel2.Controls.Add(btn_tratamiento);
            panel2.Controls.Add(btn_minijuego);
            panel2.Controls.Add(btn_prevencion);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(269, 507);
            panel2.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgv_caballos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(269, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 507);
            panel3.TabIndex = 7;
            // 
            // dtgv_caballos
            // 
            dtgv_caballos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_caballos.Dock = DockStyle.Fill;
            dtgv_caballos.Location = new Point(0, 0);
            dtgv_caballos.Name = "dtgv_caballos";
            dtgv_caballos.RowHeadersWidth = 51;
            dtgv_caballos.Size = new Size(799, 507);
            dtgv_caballos.TabIndex = 0;
            // 
            // saludcaballos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "saludcaballos";
            Size = new Size(1068, 601);
            Load += saludcaballos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_caballos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_enferme;
        private Button btn_tratamiento;
        private Button btn_prevencion;
        private Button btn_minijuego;
        private Label lbl_titulo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dtgv_caballos;
    }
}
