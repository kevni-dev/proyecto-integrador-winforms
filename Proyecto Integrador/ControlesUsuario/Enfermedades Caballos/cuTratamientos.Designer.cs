namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class cuTratamientos
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
            panel2 = new Panel();
            cmb_enfermedades = new ComboBox();
            btn_eliminar = new Button();
            txt_id = new TextBox();
            lbl_id = new Label();
            lbl_enfermedad = new Label();
            lbl_tratamiento = new Label();
            btn_guardar = new Button();
            txt_tratamiento = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            dtgv_tratamiento = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Enfermedad_id = new DataGridViewTextBoxColumn();
            enfermedad = new DataGridViewTextBoxColumn();
            Tratamiento = new DataGridViewTextBoxColumn();

            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_tratamiento).BeginInit();
            SuspendLayout();

            // panel1 (Top)
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1091, 52);
            panel1.TabIndex = 3;

            // panel2 (Left)
            panel2.Controls.Add(cmb_enfermedades);
            panel2.Controls.Add(btn_eliminar);
            panel2.Controls.Add(txt_id);
            panel2.Controls.Add(lbl_id);
            panel2.Controls.Add(lbl_enfermedad);
            panel2.Controls.Add(lbl_tratamiento);
            panel2.Controls.Add(btn_guardar);
            panel2.Controls.Add(txt_tratamiento);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(328, 530);
            panel2.TabIndex = 4;

            // panel3 (Fill)  ✅ ahora sí debe ir después del Left y Top
            panel3.Controls.Add(dtgv_tratamiento);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(328, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(763, 530);
            panel3.TabIndex = 5;

            // dtgv_tratamiento
            dtgv_tratamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_tratamiento.Columns.AddRange(new DataGridViewColumn[] { id, Enfermedad_id, enfermedad, Tratamiento });
            dtgv_tratamiento.Dock = DockStyle.Fill;
            dtgv_tratamiento.Location = new Point(0, 0);
            dtgv_tratamiento.Name = "dtgv_tratamiento";
            dtgv_tratamiento.RowHeadersWidth = 51;
            dtgv_tratamiento.Size = new Size(763, 530);
            dtgv_tratamiento.TabIndex = 8;

            // columnas
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 80;

            Enfermedad_id.HeaderText = "Enfermedad_id";
            Enfermedad_id.MinimumWidth = 6;
            Enfermedad_id.Name = "Enfermedad_id";
            Enfermedad_id.Width = 120;

            enfermedad.HeaderText = "Enfermedad";
            enfermedad.MinimumWidth = 6;
            enfermedad.Name = "enfermedad";
            enfermedad.Width = 200;

            Tratamiento.HeaderText = "Tratamiento";
            Tratamiento.MinimumWidth = 6;
            Tratamiento.Name = "Tratamiento";
            Tratamiento.Width = 300;

            // cuTratamientos
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            // ✅ ORDEN CORRECTO:
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);

            Name = "cuTratamientos";
            Size = new Size(1091, 582);

            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_tratamiento).EndInit();
            ResumeLayout(false);
        }


        #endregion

        private Panel panel2;
        private ComboBox cmb_enfermedades;
        private Button btn_eliminar;
        private TextBox txt_id;
        private Label lbl_id;
        private Label lbl_enfermedad;
        private Label lbl_tratamiento;
        private Button btn_guardar;
        private TextBox txt_tratamiento;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dtgv_tratamiento;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Enfermedad_id;
        private DataGridViewTextBoxColumn enfermedad;
        private DataGridViewTextBoxColumn Tratamiento;
    }
}
