namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class cuTratamientos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes
        private void InitializeComponent()
        {
            panelTop = new Panel();
            panelLeft = new Panel();
            panelFill = new Panel();

            cmb_enfermedades = new ComboBox();
            btn_eliminar = new Button();
            btn_guardar = new Button();

            txt_id = new TextBox();
            txt_tratamiento = new TextBox();

            lbl_id = new Label();
            lbl_enfermedad = new Label();
            lbl_tratamiento = new Label();

            dtgv_tratamiento = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Enfermedad_id = new DataGridViewTextBoxColumn();
            enfermedad = new DataGridViewTextBoxColumn();
            Tratamiento = new DataGridViewTextBoxColumn();

            panelLeft.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_tratamiento).BeginInit();
            SuspendLayout();

            // panelTop
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 52;
            panelTop.Name = "panelTop";

            // panelLeft
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Width = 328;
            panelLeft.Padding = new Padding(18, 16, 18, 16);
            panelLeft.Name = "panelLeft";

            // panelFill
            panelFill.Dock = DockStyle.Fill;
            panelFill.Padding = new Padding(10);
            panelFill.Name = "panelFill";

            // lbl_id
            lbl_id.AutoSize = true;
            lbl_id.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_id.Location = new Point(18, 16);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(23, 17);
            lbl_id.Text = "ID";

            // txt_id
            txt_id.Location = new Point(18, 38);
            txt_id.ReadOnly = true;
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(290, 23);

            // lbl_enfermedad
            lbl_enfermedad.AutoSize = true;
            lbl_enfermedad.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_enfermedad.Location = new Point(18, 78);
            lbl_enfermedad.Name = "lbl_enfermedad";
            lbl_enfermedad.Size = new Size(97, 17);
            lbl_enfermedad.Text = "Enfermedad";

            // cmb_enfermedades
            cmb_enfermedades.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_enfermedades.Location = new Point(18, 100);
            cmb_enfermedades.Name = "cmb_enfermedades";
            cmb_enfermedades.Size = new Size(290, 23);

            // lbl_tratamiento
            lbl_tratamiento.AutoSize = true;
            lbl_tratamiento.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_tratamiento.Location = new Point(18, 142);
            lbl_tratamiento.Name = "lbl_tratamiento";
            lbl_tratamiento.Size = new Size(103, 17);
            lbl_tratamiento.Text = "Tratamiento";

            // txt_tratamiento
            txt_tratamiento.Location = new Point(18, 164);
            txt_tratamiento.Multiline = true;
            txt_tratamiento.ScrollBars = ScrollBars.Vertical;
            txt_tratamiento.Name = "txt_tratamiento";
            txt_tratamiento.Size = new Size(290, 70);

            // btn_guardar
            btn_guardar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_guardar.Location = new Point(18, 248);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(135, 45);
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;

            // btn_eliminar
            btn_eliminar.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_eliminar.Location = new Point(173, 248);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(135, 45);
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;

            // dtgv_tratamiento
            dtgv_tratamiento.AllowUserToAddRows = false;
            dtgv_tratamiento.AllowUserToDeleteRows = false;
            dtgv_tratamiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_tratamiento.Columns.AddRange(new DataGridViewColumn[] { id, Enfermedad_id, enfermedad, Tratamiento });
            dtgv_tratamiento.Dock = DockStyle.Fill;
            dtgv_tratamiento.Name = "dtgv_tratamiento";
            dtgv_tratamiento.RowHeadersVisible = false;

            // columnas
            id.HeaderText = "id";
            id.Name = "id";
            id.Width = 60;

            Enfermedad_id.HeaderText = "Enfermedad_id";
            Enfermedad_id.Name = "Enfermedad_id";
            Enfermedad_id.Width = 110;

            enfermedad.HeaderText = "Enfermedad";
            enfermedad.Name = "enfermedad";
            enfermedad.Width = 170;

            Tratamiento.HeaderText = "Tratamiento";
            Tratamiento.Name = "Tratamiento";
            Tratamiento.Width = 300;

            // panelLeft controls
            panelLeft.Controls.Add(lbl_id);
            panelLeft.Controls.Add(txt_id);
            panelLeft.Controls.Add(lbl_enfermedad);
            panelLeft.Controls.Add(cmb_enfermedades);
            panelLeft.Controls.Add(lbl_tratamiento);
            panelLeft.Controls.Add(txt_tratamiento);
            panelLeft.Controls.Add(btn_guardar);
            panelLeft.Controls.Add(btn_eliminar);

            // panelFill controls
            panelFill.Controls.Add(dtgv_tratamiento);

            // cuTratamientos
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;

            Controls.Add(panelFill);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);

            Name = "cuTratamientos";
            Size = new Size(1091, 582);

            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_tratamiento).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelTop;
        private Panel panelLeft;
        private Panel panelFill;

        private ComboBox cmb_enfermedades;
        private Button btn_eliminar;
        private TextBox txt_id;
        private Label lbl_id;
        private Label lbl_enfermedad;
        private Label lbl_tratamiento;
        private Button btn_guardar;
        private TextBox txt_tratamiento;

        private DataGridView dtgv_tratamiento;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Enfermedad_id;
        private DataGridViewTextBoxColumn enfermedad;
        private DataGridViewTextBoxColumn Tratamiento;
    }
}
