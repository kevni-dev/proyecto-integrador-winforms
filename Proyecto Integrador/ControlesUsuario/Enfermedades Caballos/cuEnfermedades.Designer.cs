namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class cuEnfermedades
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
            panel3 = new Panel();
            dtgv_enfermedades = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            enfermedad = new DataGridViewTextBoxColumn();
            sintomas = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            btn_eliminar = new Button();
            txt_id = new TextBox();
            lbl_id = new Label();
            panel1 = new Panel();
            lbl_enfermedad = new Label();
            lbl_sintomas = new Label();
            btn_guardar = new Button();
            lbl_descripcion = new Label();
            txt_enfermedad = new TextBox();
            txt_sintomas = new TextBox();
            txt_descripcion = new TextBox();
            panel2 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_enfermedades).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgv_enfermedades);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(328, 52);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(842, 559);
            panel3.TabIndex = 15;
            // 
            // dtgv_enfermedades
            // 
            dtgv_enfermedades.AllowUserToAddRows = false;
            dtgv_enfermedades.AllowUserToDeleteRows = false;
            dtgv_enfermedades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_enfermedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_enfermedades.Columns.AddRange(new DataGridViewColumn[] { id, enfermedad, sintomas, descripcion });
            dtgv_enfermedades.Dock = DockStyle.Fill;
            dtgv_enfermedades.Location = new Point(0, 0);
            dtgv_enfermedades.Margin = new Padding(3, 2, 3, 2);
            dtgv_enfermedades.Name = "dtgv_enfermedades";
            dtgv_enfermedades.ReadOnly = true;
            dtgv_enfermedades.RowHeadersVisible = false;
            dtgv_enfermedades.RowHeadersWidth = 51;
            dtgv_enfermedades.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_enfermedades.Size = new Size(842, 559);
            dtgv_enfermedades.TabIndex = 7;

            
            dtgv_enfermedades.CellContentClick += dtgv_enfermedades_CellContentClick;

            

            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // enfermedad
            // 
            enfermedad.HeaderText = "Enfermedad";
            enfermedad.MinimumWidth = 6;
            enfermedad.Name = "enfermedad";
            enfermedad.ReadOnly = true;
            // 
            // sintomas
            // 
            sintomas.HeaderText = "Sintomas";
            sintomas.MinimumWidth = 6;
            sintomas.Name = "sintomas";
            sintomas.ReadOnly = true;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.ReadOnly = true;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(180, 281);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(93, 55);
            btn_eliminar.TabIndex = 9;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(39, 26);
            txt_id.Margin = new Padding(3, 2, 3, 2);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(234, 23);
            txt_id.TabIndex = 8;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_id.Location = new Point(46, 9);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(23, 17);
            lbl_id.TabIndex = 7;
            lbl_id.Text = "ID";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_eliminar);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(lbl_id);
            panel1.Controls.Add(lbl_enfermedad);
            panel1.Controls.Add(lbl_sintomas);
            panel1.Controls.Add(btn_guardar);
            panel1.Controls.Add(lbl_descripcion);
            panel1.Controls.Add(txt_enfermedad);
            panel1.Controls.Add(txt_sintomas);
            panel1.Controls.Add(txt_descripcion);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 52);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 559);
            panel1.TabIndex = 14;
            // 
            // lbl_enfermedad
            // 
            lbl_enfermedad.AutoSize = true;
            lbl_enfermedad.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_enfermedad.Location = new Point(39, 59);
            lbl_enfermedad.Name = "lbl_enfermedad";
            lbl_enfermedad.Size = new Size(97, 17);
            lbl_enfermedad.TabIndex = 3;
            lbl_enfermedad.Text = "Enfermedad";
            // 
            // lbl_sintomas
            // 
            lbl_sintomas.AutoSize = true;
            lbl_sintomas.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sintomas.Location = new Point(39, 134);
            lbl_sintomas.Name = "lbl_sintomas";
            lbl_sintomas.Size = new Size(76, 17);
            lbl_sintomas.TabIndex = 4;
            lbl_sintomas.Text = "Sintomas";
            // 
            // btn_guardar
            // 
            btn_guardar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(39, 281);
            btn_guardar.Margin = new Padding(3, 2, 3, 2);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(98, 55);
            btn_guardar.TabIndex = 6;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.AutoSize = true;
            lbl_descripcion.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_descripcion.Location = new Point(46, 223);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(102, 17);
            lbl_descripcion.TabIndex = 5;
            lbl_descripcion.Text = "Descripción ";
            // 
            // txt_enfermedad
            // 
            txt_enfermedad.Location = new Point(39, 85);
            txt_enfermedad.Margin = new Padding(3, 2, 3, 2);
            txt_enfermedad.Name = "txt_enfermedad";
            txt_enfermedad.Size = new Size(234, 23);
            txt_enfermedad.TabIndex = 0;
            // 
            // txt_sintomas
            // 
            txt_sintomas.Location = new Point(39, 160);
            txt_sintomas.Margin = new Padding(3, 2, 3, 2);
            txt_sintomas.Name = "txt_sintomas";
            txt_sintomas.Size = new Size(234, 23);
            txt_sintomas.TabIndex = 1;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(39, 240);
            txt_descripcion.Margin = new Padding(3, 2, 3, 2);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(234, 23);
            txt_descripcion.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1170, 52);
            panel2.TabIndex = 13;
            // 
            // cuEnfermedades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "cuEnfermedades";
            Size = new Size(1170, 611);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_enfermedades).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private DataGridView dtgv_enfermedades;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn enfermedad;
        private DataGridViewTextBoxColumn sintomas;
        private DataGridViewTextBoxColumn descripcion;
        private Button btn_eliminar;
        private TextBox txt_id;
        private Label lbl_id;
        private Panel panel1;
        private Label lbl_enfermedad;
        private Label lbl_sintomas;
        private Button btn_guardar;
        private Label lbl_descripcion;
        private TextBox txt_enfermedad;
        private TextBox txt_sintomas;
        private TextBox txt_descripcion;
        private Panel panel2;
    }
}
