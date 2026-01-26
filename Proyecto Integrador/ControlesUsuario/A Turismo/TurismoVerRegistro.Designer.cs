namespace Proyecto_Integrador.ControlesUsuario.A_Turismo
{
    partial class TurismoVerRegistro
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
            comboFiltro = new ComboBox();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            panelMain = new Panel();
            dataGridCaballos = new DataGridView();
            panelPreview = new Panel();
            pictureCaballo = new PictureBox();
            lblVista = new Label();
            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCaballos).BeginInit();
            panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCaballo).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.Gainsboro;
            panelTop.Controls.Add(comboFiltro);
            panelTop.Controls.Add(txtBuscar);
            panelTop.Controls.Add(lblBuscar);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1212, 60);
            panelTop.TabIndex = 2;
            // 
            // comboFiltro
            // 
            comboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltro.Location = new Point(300, 19);
            comboFiltro.Name = "comboFiltro";
            comboFiltro.Size = new Size(150, 23);
            comboFiltro.TabIndex = 0;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(80, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 23);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(20, 22);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.TabIndex = 2;
            lblBuscar.Text = "Buscar:";
            // 
            // panelMain
            // 
            panelMain.Controls.Add(dataGridCaballos);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 60);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(952, 344);
            panelMain.TabIndex = 0;
            panelMain.BackColor = System.Drawing.Color.Transparent;
            // 
            // dataGridCaballos
            // 
            dataGridCaballos.AllowUserToAddRows = false;
            dataGridCaballos.AllowUserToDeleteRows = false;
            dataGridCaballos.Dock = DockStyle.Fill;
            dataGridCaballos.Location = new Point(0, 0);
            dataGridCaballos.MultiSelect = false;
            dataGridCaballos.Name = "dataGridCaballos";
            dataGridCaballos.ReadOnly = true;
            dataGridCaballos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCaballos.Size = new Size(952, 344);
            dataGridCaballos.TabIndex = 0;
            // 
            // panelPreview
            // 
            panelPreview.BackColor = Color.WhiteSmoke;
            panelPreview.Controls.Add(pictureCaballo);
            panelPreview.Controls.Add(lblVista);
            panelPreview.Dock = DockStyle.Right;
            panelPreview.Location = new Point(952, 60);
            panelPreview.Name = "panelPreview";
            panelPreview.Size = new Size(260, 344);
            panelPreview.TabIndex = 1;
            // 
            // pictureCaballo
            // 
            pictureCaballo.BackColor = Color.LightGray;
            pictureCaballo.Dock = DockStyle.Top;
            pictureCaballo.Location = new Point(0, 40);
            pictureCaballo.Name = "pictureCaballo";
            pictureCaballo.Size = new Size(260, 200);
            pictureCaballo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCaballo.TabIndex = 0;
            pictureCaballo.TabStop = false;
            pictureCaballo.Click += pictureCaballo_Click;
            // 
            // lblVista
            // 
            lblVista.Dock = DockStyle.Top;
            lblVista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVista.Location = new Point(0, 0);
            lblVista.Name = "lblVista";
            lblVista.Size = new Size(260, 40);
            lblVista.TabIndex = 1;
            lblVista.Text = "Vista previa";
            lblVista.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TurismoVerRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMain);
            Controls.Add(panelPreview);
            Controls.Add(panelTop);
            Name = "TurismoVerRegistro";
            Size = new Size(1212, 404);
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCaballos).EndInit();
            panelPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureCaballo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private ComboBox comboFiltro;

        private Panel panelMain;
        private DataGridView dataGridCaballos;

        private Panel panelPreview;
        private Label lblVista;
        private PictureBox pictureCaballo;
    }
}
