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
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            comboFiltro = new ComboBox();

            panelMain = new Panel();
            dataGridCaballos = new DataGridView();

            panelPreview = new Panel();
            lblVista = new Label();
            pictureCaballo = new PictureBox();

            panelTop.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCaballos).BeginInit();
            panelPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCaballo).BeginInit();
            SuspendLayout();

            // 
            // panelTop
            // 
            panelTop.Controls.Add(comboFiltro);
            panelTop.Controls.Add(txtBuscar);
            panelTop.Controls.Add(lblBuscar);
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 60;
            panelTop.BackColor = System.Drawing.Color.Gainsboro;

            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(20, 22);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(45, 15);
            lblBuscar.Text = "Buscar:";

            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(80, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 23);

            // 
            // comboFiltro
            // 
            comboFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            comboFiltro.Location = new Point(300, 19);
            comboFiltro.Name = "comboFiltro";
            comboFiltro.Size = new Size(150, 23);

            // 
            // panelMain
            // 
            panelMain.Controls.Add(dataGridCaballos);
            panelMain.Dock = DockStyle.Fill;

            // 
            // dataGridCaballos
            // 
            dataGridCaballos.AllowUserToAddRows = false;
            dataGridCaballos.AllowUserToDeleteRows = false;
            dataGridCaballos.ReadOnly = true;
            dataGridCaballos.Dock = DockStyle.Fill;
            dataGridCaballos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridCaballos.MultiSelect = false;
            dataGridCaballos.Name = "dataGridCaballos";

            // 
            // panelPreview
            // 
            panelPreview.Controls.Add(pictureCaballo);
            panelPreview.Controls.Add(lblVista);
            panelPreview.Dock = DockStyle.Right;
            panelPreview.Width = 260;
            panelPreview.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // lblVista
            // 
            lblVista.Dock = DockStyle.Top;
            lblVista.Height = 40;
            lblVista.Text = "Vista previa";
            lblVista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lblVista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            // 
            // pictureCaballo
            // 
            pictureCaballo.Dock = DockStyle.Top;
            pictureCaballo.Height = 200;
            pictureCaballo.BackColor = System.Drawing.Color.LightGray;
            pictureCaballo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCaballo.Name = "pictureCaballo";

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
