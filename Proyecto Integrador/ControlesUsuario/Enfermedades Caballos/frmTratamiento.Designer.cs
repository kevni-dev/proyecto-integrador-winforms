namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class frmTratamiento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            cmb_enfermedades = new ComboBox();
            btn_eliminar = new Button();
            txt_id = new TextBox();
            lbl_id = new Label();
            lbl_enfermedad = new Label();
            lbl_tratamiento = new Label();
            btn_guardar = new Button();
            txt_tratamiento = new TextBox();
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
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1016, 69);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(cmb_enfermedades);
            panel2.Controls.Add(btn_eliminar);
            panel2.Controls.Add(txt_id);
            panel2.Controls.Add(lbl_id);
            panel2.Controls.Add(lbl_enfermedad);
            panel2.Controls.Add(lbl_tratamiento);
            panel2.Controls.Add(btn_guardar);
            panel2.Controls.Add(txt_tratamiento);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 69);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 473);
            panel2.TabIndex = 1;
            // 
            // cmb_enfermedades
            // 
            cmb_enfermedades.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_enfermedades.FormattingEnabled = true;
            cmb_enfermedades.Location = new Point(57, 119);
            cmb_enfermedades.Name = "cmb_enfermedades";
            cmb_enfermedades.Size = new Size(257, 28);
            cmb_enfermedades.TabIndex = 20;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(194, 263);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(106, 73);
            btn_eliminar.TabIndex = 19;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(54, 41);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(267, 27);
            txt_id.TabIndex = 18;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_id.Location = new Point(61, 18);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(27, 20);
            lbl_id.TabIndex = 17;
            lbl_id.Text = "ID";
            // 
            // lbl_enfermedad
            // 
            lbl_enfermedad.AutoSize = true;
            lbl_enfermedad.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_enfermedad.Location = new Point(54, 85);
            lbl_enfermedad.Name = "lbl_enfermedad";
            lbl_enfermedad.Size = new Size(118, 20);
            lbl_enfermedad.TabIndex = 13;
            lbl_enfermedad.Text = "Enfermedad";
            // 
            // lbl_tratamiento
            // 
            lbl_tratamiento.AutoSize = true;
            lbl_tratamiento.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_tratamiento.Location = new Point(54, 185);
            lbl_tratamiento.Name = "lbl_tratamiento";
            lbl_tratamiento.Size = new Size(125, 20);
            lbl_tratamiento.TabIndex = 14;
            lbl_tratamiento.Text = "Tratamiento";
            // 
            // btn_guardar
            // 
            btn_guardar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(43, 263);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(112, 73);
            btn_guardar.TabIndex = 16;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // txt_tratamiento
            // 
            txt_tratamiento.Location = new Point(54, 220);
            txt_tratamiento.Name = "txt_tratamiento";
            txt_tratamiento.Size = new Size(267, 27);
            txt_tratamiento.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgv_tratamiento);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(375, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(641, 473);
            panel3.TabIndex = 2;
            // 
            // dtgv_tratamiento
            // 
            dtgv_tratamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_tratamiento.Columns.AddRange(new DataGridViewColumn[] { id, Enfermedad_id, enfermedad, Tratamiento });
            dtgv_tratamiento.Dock = DockStyle.Fill;
            dtgv_tratamiento.Location = new Point(0, 0);
            dtgv_tratamiento.Name = "dtgv_tratamiento";
            dtgv_tratamiento.RowHeadersWidth = 51;
            dtgv_tratamiento.Size = new Size(641, 473);
            dtgv_tratamiento.TabIndex = 8;
            dtgv_tratamiento.CellClick += dtgv_tratamiento_CellClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // Enfermedad_id
            // 
            Enfermedad_id.HeaderText = "Enfermedad_id";
            Enfermedad_id.MinimumWidth = 6;
            Enfermedad_id.Name = "Enfermedad_id";
            Enfermedad_id.Width = 125;
            // 
            // enfermedad
            // 
            enfermedad.HeaderText = "Enfermedad";
            enfermedad.MinimumWidth = 6;
            enfermedad.Name = "enfermedad";
            enfermedad.Width = 125;
            // 
            // Tratamiento
            // 
            Tratamiento.HeaderText = "Tratamiento";
            Tratamiento.MinimumWidth = 6;
            Tratamiento.Name = "Tratamiento";
            Tratamiento.Width = 125;
            // 
            // frmTratamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1016, 542);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmTratamiento";
            Text = "frmTratamiento";
            Load += frmTratamiento_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_tratamiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btn_eliminar;
        private TextBox txt_id;
        private Label lbl_id;
        private Label lbl_enfermedad;
        private Label lbl_tratamiento;
        private Button btn_guardar;
        private TextBox txt_tratamiento;
        private DataGridView dtgv_tratamiento;
        private ComboBox cmb_enfermedades;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Enfermedad_id;
        private DataGridViewTextBoxColumn enfermedad;
        private DataGridViewTextBoxColumn Tratamiento;
    }
}