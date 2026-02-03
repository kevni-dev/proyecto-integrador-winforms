namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class cuEnfermedadesPorCaballo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            panelTop = new Panel();
            btnVolver = new Button();
            lblCaballo = new Label();
            panelLeft = new Panel();
            btnMarcarCurada = new Button();
            btnEliminar = new Button();
            btnAgregar = new Button();
            chkActiva = new CheckBox();
            txtNotas = new TextBox();
            lblNotas = new Label();
            dtpFecha = new DateTimePicker();
            lblFecha = new Label();
            txtEnfermedad = new TextBox();
            lblEnfermedad = new Label();
            panelRight = new Panel();
            lblTotal = new Label();
            dtgvHistorial = new DataGridView();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHistorial).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnVolver);
            panelTop.Controls.Add(lblCaballo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(962, 45);
            panelTop.TabIndex = 0;
            // 
            // btnVolver
            // 
            btnVolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVolver.Location = new Point(871, 10);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(79, 24);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // lblCaballo
            // 
            lblCaballo.AutoSize = true;
            lblCaballo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCaballo.Location = new Point(10, 12);
            lblCaballo.Name = "lblCaballo";
            lblCaballo.Size = new Size(146, 21);
            lblCaballo.TabIndex = 0;
            lblCaballo.Text = "Enfermedades de:";
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(btnMarcarCurada);
            panelLeft.Controls.Add(btnEliminar);
            panelLeft.Controls.Add(btnAgregar);
            panelLeft.Controls.Add(chkActiva);
            panelLeft.Controls.Add(txtNotas);
            panelLeft.Controls.Add(lblNotas);
            panelLeft.Controls.Add(dtpFecha);
            panelLeft.Controls.Add(lblFecha);
            panelLeft.Controls.Add(txtEnfermedad);
            panelLeft.Controls.Add(lblEnfermedad);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 45);
            panelLeft.Margin = new Padding(3, 2, 3, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(10, 9, 10, 9);
            panelLeft.Size = new Size(298, 420);
            panelLeft.TabIndex = 1;
            // 
            // btnMarcarCurada
            // 
            btnMarcarCurada.Location = new Point(13, 322);
            btnMarcarCurada.Margin = new Padding(3, 2, 3, 2);
            btnMarcarCurada.Name = "btnMarcarCurada";
            btnMarcarCurada.Size = new Size(271, 30);
            btnMarcarCurada.TabIndex = 9;
            btnMarcarCurada.Text = "Marcar como curada";
            btnMarcarCurada.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(13, 285);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(271, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar registro";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(13, 248);
            btnAgregar.Margin = new Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(271, 30);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // chkActiva
            // 
            chkActiva.AutoSize = true;
            chkActiva.Location = new Point(16, 221);
            chkActiva.Margin = new Padding(3, 2, 3, 2);
            chkActiva.Name = "chkActiva";
            chkActiva.Size = new Size(59, 19);
            chkActiva.TabIndex = 6;
            chkActiva.Text = "Activa";
            chkActiva.UseVisualStyleBackColor = true;
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(13, 156);
            txtNotas.Margin = new Padding(3, 2, 3, 2);
            txtNotas.Multiline = true;
            txtNotas.Name = "txtNotas";
            txtNotas.ScrollBars = ScrollBars.Vertical;
            txtNotas.Size = new Size(272, 61);
            txtNotas.TabIndex = 5;
            // 
            // lblNotas
            // 
            lblNotas.AutoSize = true;
            lblNotas.Location = new Point(13, 139);
            lblNotas.Name = "lblNotas";
            lblNotas.Size = new Size(38, 15);
            lblNotas.TabIndex = 4;
            lblNotas.Text = "Notas";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(13, 109);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(272, 23);
            dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(13, 92);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // txtEnfermedad
            // 
            txtEnfermedad.Location = new Point(13, 56);
            txtEnfermedad.Margin = new Padding(3, 2, 3, 2);
            txtEnfermedad.Name = "txtEnfermedad";
            txtEnfermedad.Size = new Size(272, 23);
            txtEnfermedad.TabIndex = 1;
            // 
            // lblEnfermedad
            // 
            lblEnfermedad.AutoSize = true;
            lblEnfermedad.Location = new Point(13, 39);
            lblEnfermedad.Name = "lblEnfermedad";
            lblEnfermedad.Size = new Size(71, 15);
            lblEnfermedad.TabIndex = 0;
            lblEnfermedad.Text = "Enfermedad";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(lblTotal);
            panelRight.Controls.Add(dtgvHistorial);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(298, 45);
            panelRight.Margin = new Padding(3, 2, 3, 2);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(10, 9, 10, 9);
            panelRight.Size = new Size(664, 420);
            panelRight.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Dock = DockStyle.Bottom;
            lblTotal.Location = new Point(10, 396);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Casos: 0";
            // 
            // dtgvHistorial
            // 
            dtgvHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvHistorial.Dock = DockStyle.Fill;
            dtgvHistorial.Location = new Point(10, 9);
            dtgvHistorial.Margin = new Padding(3, 2, 3, 2);
            dtgvHistorial.MultiSelect = false;
            dtgvHistorial.Name = "dtgvHistorial";
            dtgvHistorial.ReadOnly = true;
            dtgvHistorial.RowHeadersVisible = false;
            dtgvHistorial.RowHeadersWidth = 51;
            dtgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvHistorial.Size = new Size(644, 402);
            dtgvHistorial.TabIndex = 0;
            // 
            // cuEnfermedadesPorCaballo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "cuEnfermedadesPorCaballo";
            Size = new Size(962, 465);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvHistorial).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Button btnVolver;
        private Label lblCaballo;
        private Panel panelLeft;
        private Label lblEnfermedad;
        private TextBox txtEnfermedad;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private Label lblNotas;
        private TextBox txtNotas;
        private CheckBox chkActiva;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnMarcarCurada;
        private Panel panelRight;
        private DataGridView dtgvHistorial;
        private Label lblTotal;
    }
}
