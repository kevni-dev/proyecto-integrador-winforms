namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class Enfermedades
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
            txt_enfermedad = new TextBox();
            txt_sintomas = new TextBox();
            txt_descripcion = new TextBox();
            lbl_enfermedad = new Label();
            lbl_sintomas = new Label();
            lbl_descripcion = new Label();
            btn_guardar = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            btn_eliminar = new Button();
            txt_id = new TextBox();
            lbl_id = new Label();
            dtgv_enfermedades = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            enfermedad = new DataGridViewTextBoxColumn();
            sintomas = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_enfermedades).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txt_enfermedad
            // 
            txt_enfermedad.Location = new Point(45, 113);
            txt_enfermedad.Name = "txt_enfermedad";
            txt_enfermedad.Size = new Size(267, 27);
            txt_enfermedad.TabIndex = 0;
            // 
            // txt_sintomas
            // 
            txt_sintomas.Location = new Point(45, 214);
            txt_sintomas.Name = "txt_sintomas";
            txt_sintomas.Size = new Size(267, 27);
            txt_sintomas.TabIndex = 1;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(45, 320);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(267, 27);
            txt_descripcion.TabIndex = 2;
            // 
            // lbl_enfermedad
            // 
            lbl_enfermedad.AutoSize = true;
            lbl_enfermedad.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_enfermedad.Location = new Point(45, 79);
            lbl_enfermedad.Name = "lbl_enfermedad";
            lbl_enfermedad.Size = new Size(118, 20);
            lbl_enfermedad.TabIndex = 3;
            lbl_enfermedad.Text = "Enfermedad";
            // 
            // lbl_sintomas
            // 
            lbl_sintomas.AutoSize = true;
            lbl_sintomas.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sintomas.Location = new Point(45, 179);
            lbl_sintomas.Name = "lbl_sintomas";
            lbl_sintomas.Size = new Size(92, 20);
            lbl_sintomas.TabIndex = 4;
            lbl_sintomas.Text = "Sintomas";
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.AutoSize = true;
            lbl_descripcion.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_descripcion.Location = new Point(52, 297);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(123, 20);
            lbl_descripcion.TabIndex = 5;
            lbl_descripcion.Text = "Descripción ";
            // 
            // btn_guardar
            // 
            btn_guardar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(45, 375);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(112, 73);
            btn_guardar.TabIndex = 6;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1001, 69);
            panel2.TabIndex = 9;
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
            panel1.Location = new Point(0, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 496);
            panel1.TabIndex = 11;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(206, 375);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(106, 73);
            btn_eliminar.TabIndex = 9;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(45, 35);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(267, 27);
            txt_id.TabIndex = 8;
            txt_id.TextChanged += textBox1_TextChanged;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_id.Location = new Point(52, 12);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(27, 20);
            lbl_id.TabIndex = 7;
            lbl_id.Text = "ID";
            // 
            // dtgv_enfermedades
            // 
            dtgv_enfermedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_enfermedades.Columns.AddRange(new DataGridViewColumn[] { id, enfermedad, sintomas, descripcion });
            dtgv_enfermedades.Dock = DockStyle.Fill;
            dtgv_enfermedades.Location = new Point(0, 0);
            dtgv_enfermedades.Name = "dtgv_enfermedades";
            dtgv_enfermedades.RowHeadersWidth = 51;
            dtgv_enfermedades.Size = new Size(626, 496);
            dtgv_enfermedades.TabIndex = 7;
            dtgv_enfermedades.CellClick += dtgv_enfermedades_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.Width = 125;
            // 
            // enfermedad
            // 
            enfermedad.HeaderText = "Enfermedad";
            enfermedad.MinimumWidth = 6;
            enfermedad.Name = "enfermedad";
            enfermedad.Width = 125;
            // 
            // sintomas
            // 
            sintomas.HeaderText = "Sintomas";
            sintomas.MinimumWidth = 6;
            sintomas.Name = "sintomas";
            sintomas.Width = 125;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripcion";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.Width = 125;
            // 
            // panel3
            // 
            panel3.Controls.Add(dtgv_enfermedades);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(375, 69);
            panel3.Name = "panel3";
            panel3.Size = new Size(626, 496);
            panel3.TabIndex = 12;
            // 
            // Enfermedades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 565);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Enfermedades";
            Text = "Enfermedades";
            Load += Enfermedades_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_enfermedades).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txt_enfermedad;
        private TextBox txt_sintomas;
        private TextBox txt_descripcion;
        private Label lbl_enfermedad;
        private Label lbl_sintomas;
        private Label lbl_descripcion;
        private Button btn_guardar;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dtgv_enfermedades;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn enfermedad;
        private DataGridViewTextBoxColumn sintomas;
        private DataGridViewTextBoxColumn descripcion;
        private Panel panel3;
        private TextBox txt_id;
        private Label lbl_id;
        private Button btn_eliminar;
    }
}