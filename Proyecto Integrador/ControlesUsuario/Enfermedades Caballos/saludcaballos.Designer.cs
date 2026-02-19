// Saludcaballos.Designer.cs (REEMPLAZA este archivo COMPLETO)
// - SIN panel1 (sin título arriba)
// - Tabs arriba estilo Turismo con 5 botones: Caballos, Enfermedades, Tratamientos, Prevención, Minijuego
// - panel3 = contenido (tabla/vistas)

using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class Saludcaballos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelTopMenu = new Panel();
            tablaTopMenu = new TableLayoutPanel();

            hostCaballos = new Panel();
            layoutCaballos = new TableLayoutPanel();
            iconCaballos = new PictureBox();
            lblCaballos = new Label();

            hostEnfermedades = new Panel();
            layoutEnfermedades = new TableLayoutPanel();
            iconEnfermedades = new PictureBox();
            lblEnfermedades = new Label();

            hostTratamientos = new Panel();
            layoutTratamientos = new TableLayoutPanel();
            iconTratamientos = new PictureBox();
            lblTratamientos = new Label();

            hostPrevencion = new Panel();
            layoutPrevencion = new TableLayoutPanel();
            iconPrevencion = new PictureBox();
            lblPrevencion = new Label();

            hostMinijuego = new Panel();
            layoutMinijuego = new TableLayoutPanel();
            iconMinijuego = new PictureBox();
            lblMinijuego = new Label();

            panel3 = new Panel();
            dtgv_caballos = new DataGridView();

            panelTopMenu.SuspendLayout();
            tablaTopMenu.SuspendLayout();

            hostCaballos.SuspendLayout();
            layoutCaballos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCaballos).BeginInit();

            hostEnfermedades.SuspendLayout();
            layoutEnfermedades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconEnfermedades).BeginInit();

            hostTratamientos.SuspendLayout();
            layoutTratamientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconTratamientos).BeginInit();

            hostPrevencion.SuspendLayout();
            layoutPrevencion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPrevencion).BeginInit();

            hostMinijuego.SuspendLayout();
            layoutMinijuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMinijuego).BeginInit();

            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_caballos).BeginInit();

            SuspendLayout();

            // =========================
            // panelTopMenu (Tabs arriba)
            // =========================
            panelTopMenu.BackColor = Color.Transparent;
            panelTopMenu.Controls.Add(tablaTopMenu);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Padding = new Padding(18, 14, 18, 14);
            panelTopMenu.Size = new Size(1068, 112);
            panelTopMenu.TabIndex = 0;

            // tablaTopMenu (5 columnas)
            tablaTopMenu.BackColor = Color.Transparent;
            tablaTopMenu.ColumnCount = 5;
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.Controls.Add(hostCaballos, 0, 0);
            tablaTopMenu.Controls.Add(hostEnfermedades, 1, 0);
            tablaTopMenu.Controls.Add(hostTratamientos, 2, 0);
            tablaTopMenu.Controls.Add(hostPrevencion, 3, 0);
            tablaTopMenu.Controls.Add(hostMinijuego, 4, 0);
            tablaTopMenu.Dock = DockStyle.Fill;
            tablaTopMenu.Location = new Point(18, 14);
            tablaTopMenu.Name = "tablaTopMenu";
            tablaTopMenu.RowCount = 1;
            tablaTopMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaTopMenu.Size = new Size(1032, 84);
            tablaTopMenu.TabIndex = 0;

            // =========================
            // TAB: Caballos
            // =========================
            hostCaballos.Controls.Add(layoutCaballos);
            hostCaballos.Dock = DockStyle.Fill;
            hostCaballos.Location = new Point(12, 10);
            hostCaballos.Margin = new Padding(12, 10, 12, 10);
            hostCaballos.Name = "hostCaballos";
            hostCaballos.Size = new Size(182, 64);
            hostCaballos.TabIndex = 0;

            layoutCaballos.ColumnCount = 2;
            layoutCaballos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            layoutCaballos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            layoutCaballos.Controls.Add(iconCaballos, 0, 0);
            layoutCaballos.Controls.Add(lblCaballos, 1, 0);
            layoutCaballos.Dock = DockStyle.Fill;
            layoutCaballos.Location = new Point(0, 0);
            layoutCaballos.Margin = new Padding(0);
            layoutCaballos.Name = "layoutCaballos";
            layoutCaballos.RowCount = 1;
            layoutCaballos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutCaballos.Size = new Size(182, 64);
            layoutCaballos.TabIndex = 0;

            iconCaballos.Dock = DockStyle.Fill;
            iconCaballos.Location = new Point(12, 10);
            iconCaballos.Margin = new Padding(12, 10, 6, 10);
            iconCaballos.Name = "iconCaballos";
            iconCaballos.Size = new Size(25, 44);
            iconCaballos.TabIndex = 0;
            iconCaballos.TabStop = false;

            lblCaballos.Dock = DockStyle.Fill;
            lblCaballos.Location = new Point(49, 0);
            lblCaballos.Margin = new Padding(6, 0, 10, 0);
            lblCaballos.Name = "lblCaballos";
            lblCaballos.Size = new Size(123, 64);
            lblCaballos.TabIndex = 1;
            lblCaballos.Text = "Caballos";
            lblCaballos.TextAlign = ContentAlignment.MiddleCenter;

            // =========================
            // TAB: Enfermedades
            // =========================
            hostEnfermedades.Controls.Add(layoutEnfermedades);
            hostEnfermedades.Dock = DockStyle.Fill;
            hostEnfermedades.Location = new Point(218, 10);
            hostEnfermedades.Margin = new Padding(12, 10, 12, 10);
            hostEnfermedades.Name = "hostEnfermedades";
            hostEnfermedades.Size = new Size(182, 64);
            hostEnfermedades.TabIndex = 1;

            layoutEnfermedades.ColumnCount = 2;
            layoutEnfermedades.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            layoutEnfermedades.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            layoutEnfermedades.Controls.Add(iconEnfermedades, 0, 0);
            layoutEnfermedades.Controls.Add(lblEnfermedades, 1, 0);
            layoutEnfermedades.Dock = DockStyle.Fill;
            layoutEnfermedades.Location = new Point(0, 0);
            layoutEnfermedades.Margin = new Padding(0);
            layoutEnfermedades.Name = "layoutEnfermedades";
            layoutEnfermedades.RowCount = 1;
            layoutEnfermedades.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutEnfermedades.Size = new Size(182, 64);
            layoutEnfermedades.TabIndex = 0;

            iconEnfermedades.Dock = DockStyle.Fill;
            iconEnfermedades.Location = new Point(12, 10);
            iconEnfermedades.Margin = new Padding(12, 10, 6, 10);
            iconEnfermedades.Name = "iconEnfermedades";
            iconEnfermedades.Size = new Size(25, 44);
            iconEnfermedades.TabIndex = 0;
            iconEnfermedades.TabStop = false;

            lblEnfermedades.Dock = DockStyle.Fill;
            lblEnfermedades.Location = new Point(49, 0);
            lblEnfermedades.Margin = new Padding(6, 0, 10, 0);
            lblEnfermedades.Name = "lblEnfermedades";
            lblEnfermedades.Size = new Size(123, 64);
            lblEnfermedades.TabIndex = 1;
            lblEnfermedades.Text = "Enfermedades";
            lblEnfermedades.TextAlign = ContentAlignment.MiddleCenter;

            // =========================
            // TAB: Tratamientos
            // =========================
            hostTratamientos.Controls.Add(layoutTratamientos);
            hostTratamientos.Dock = DockStyle.Fill;
            hostTratamientos.Location = new Point(424, 10);
            hostTratamientos.Margin = new Padding(12, 10, 12, 10);
            hostTratamientos.Name = "hostTratamientos";
            hostTratamientos.Size = new Size(182, 64);
            hostTratamientos.TabIndex = 2;

            layoutTratamientos.ColumnCount = 2;
            layoutTratamientos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            layoutTratamientos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            layoutTratamientos.Controls.Add(iconTratamientos, 0, 0);
            layoutTratamientos.Controls.Add(lblTratamientos, 1, 0);
            layoutTratamientos.Dock = DockStyle.Fill;
            layoutTratamientos.Location = new Point(0, 0);
            layoutTratamientos.Margin = new Padding(0);
            layoutTratamientos.Name = "layoutTratamientos";
            layoutTratamientos.RowCount = 1;
            layoutTratamientos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutTratamientos.Size = new Size(182, 64);
            layoutTratamientos.TabIndex = 0;

            iconTratamientos.Dock = DockStyle.Fill;
            iconTratamientos.Location = new Point(12, 10);
            iconTratamientos.Margin = new Padding(12, 10, 6, 10);
            iconTratamientos.Name = "iconTratamientos";
            iconTratamientos.Size = new Size(25, 44);
            iconTratamientos.TabIndex = 0;
            iconTratamientos.TabStop = false;

            lblTratamientos.Dock = DockStyle.Fill;
            lblTratamientos.Location = new Point(49, 0);
            lblTratamientos.Margin = new Padding(6, 0, 10, 0);
            lblTratamientos.Name = "lblTratamientos";
            lblTratamientos.Size = new Size(123, 64);
            lblTratamientos.TabIndex = 1;
            lblTratamientos.Text = "Tratamientos";
            lblTratamientos.TextAlign = ContentAlignment.MiddleCenter;

            // =========================
            // TAB: Prevención
            // =========================
            hostPrevencion.Controls.Add(layoutPrevencion);
            hostPrevencion.Dock = DockStyle.Fill;
            hostPrevencion.Location = new Point(630, 10);
            hostPrevencion.Margin = new Padding(12, 10, 12, 10);
            hostPrevencion.Name = "hostPrevencion";
            hostPrevencion.Size = new Size(182, 64);
            hostPrevencion.TabIndex = 3;

            layoutPrevencion.ColumnCount = 2;
            layoutPrevencion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            layoutPrevencion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            layoutPrevencion.Controls.Add(iconPrevencion, 0, 0);
            layoutPrevencion.Controls.Add(lblPrevencion, 1, 0);
            layoutPrevencion.Dock = DockStyle.Fill;
            layoutPrevencion.Location = new Point(0, 0);
            layoutPrevencion.Margin = new Padding(0);
            layoutPrevencion.Name = "layoutPrevencion";
            layoutPrevencion.RowCount = 1;
            layoutPrevencion.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutPrevencion.Size = new Size(182, 64);
            layoutPrevencion.TabIndex = 0;

            iconPrevencion.Dock = DockStyle.Fill;
            iconPrevencion.Location = new Point(12, 10);
            iconPrevencion.Margin = new Padding(12, 10, 6, 10);
            iconPrevencion.Name = "iconPrevencion";
            iconPrevencion.Size = new Size(25, 44);
            iconPrevencion.TabIndex = 0;
            iconPrevencion.TabStop = false;

            lblPrevencion.Dock = DockStyle.Fill;
            lblPrevencion.Location = new Point(49, 0);
            lblPrevencion.Margin = new Padding(6, 0, 10, 0);
            lblPrevencion.Name = "lblPrevencion";
            lblPrevencion.Size = new Size(123, 64);
            lblPrevencion.TabIndex = 1;
            lblPrevencion.Text = "Prevención";
            lblPrevencion.TextAlign = ContentAlignment.MiddleCenter;

            // =========================
            // TAB: Minijuego
            // =========================
            hostMinijuego.Controls.Add(layoutMinijuego);
            hostMinijuego.Dock = DockStyle.Fill;
            hostMinijuego.Location = new Point(836, 10);
            hostMinijuego.Margin = new Padding(12, 10, 12, 10);
            hostMinijuego.Name = "hostMinijuego";
            hostMinijuego.Size = new Size(184, 64);
            hostMinijuego.TabIndex = 4;

            layoutMinijuego.ColumnCount = 2;
            layoutMinijuego.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            layoutMinijuego.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            layoutMinijuego.Controls.Add(iconMinijuego, 0, 0);
            layoutMinijuego.Controls.Add(lblMinijuego, 1, 0);
            layoutMinijuego.Dock = DockStyle.Fill;
            layoutMinijuego.Location = new Point(0, 0);
            layoutMinijuego.Margin = new Padding(0);
            layoutMinijuego.Name = "layoutMinijuego";
            layoutMinijuego.RowCount = 1;
            layoutMinijuego.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMinijuego.Size = new Size(184, 64);
            layoutMinijuego.TabIndex = 0;

            iconMinijuego.Dock = DockStyle.Fill;
            iconMinijuego.Location = new Point(12, 10);
            iconMinijuego.Margin = new Padding(12, 10, 6, 10);
            iconMinijuego.Name = "iconMinijuego";
            iconMinijuego.Size = new Size(26, 44);
            iconMinijuego.TabIndex = 0;
            iconMinijuego.TabStop = false;

            lblMinijuego.Dock = DockStyle.Fill;
            lblMinijuego.Location = new Point(50, 0);
            lblMinijuego.Margin = new Padding(6, 0, 10, 0);
            lblMinijuego.Name = "lblMinijuego";
            lblMinijuego.Size = new Size(124, 64);
            lblMinijuego.TabIndex = 1;
            lblMinijuego.Text = "Minijuego";
            lblMinijuego.TextAlign = ContentAlignment.MiddleCenter;

            // =========================
            // panel3 (contenido)
            // =========================
            panel3.Controls.Add(dtgv_caballos);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 112);
            panel3.Name = "panel3";
            panel3.Size = new Size(1068, 489);
            panel3.TabIndex = 1;

            dtgv_caballos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_caballos.Dock = DockStyle.Fill;
            dtgv_caballos.Location = new Point(0, 0);
            dtgv_caballos.Name = "dtgv_caballos";
            dtgv_caballos.RowHeadersWidth = 51;
            dtgv_caballos.Size = new Size(1068, 489);
            dtgv_caballos.TabIndex = 0;

            // =========================
            // Saludcaballos
            // =========================
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panelTopMenu);
            Name = "Saludcaballos";
            Size = new Size(1068, 601);
            Load += saludcaballos_Load;

            panelTopMenu.ResumeLayout(false);
            tablaTopMenu.ResumeLayout(false);

            hostCaballos.ResumeLayout(false);
            layoutCaballos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconCaballos).EndInit();

            hostEnfermedades.ResumeLayout(false);
            layoutEnfermedades.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconEnfermedades).EndInit();

            hostTratamientos.ResumeLayout(false);
            layoutTratamientos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconTratamientos).EndInit();

            hostPrevencion.ResumeLayout(false);
            layoutPrevencion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPrevencion).EndInit();

            hostMinijuego.ResumeLayout(false);
            layoutMinijuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconMinijuego).EndInit();

            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_caballos).EndInit();

            ResumeLayout(false);
        }

        private Panel panelTopMenu;
        private TableLayoutPanel tablaTopMenu;

        private Panel hostCaballos;
        private Panel hostEnfermedades;
        private Panel hostTratamientos;
        private Panel hostPrevencion;
        private Panel hostMinijuego;

        private TableLayoutPanel layoutCaballos;
        private TableLayoutPanel layoutEnfermedades;
        private TableLayoutPanel layoutTratamientos;
        private TableLayoutPanel layoutPrevencion;
        private TableLayoutPanel layoutMinijuego;

        private PictureBox iconCaballos;
        private PictureBox iconEnfermedades;
        private PictureBox iconTratamientos;
        private PictureBox iconPrevencion;
        private PictureBox iconMinijuego;

        private Label lblCaballos;
        private Label lblEnfermedades;
        private Label lblTratamientos;
        private Label lblPrevencion;
        private Label lblMinijuego;

        private Panel panel3;
        private DataGridView dtgv_caballos;
    }
}
