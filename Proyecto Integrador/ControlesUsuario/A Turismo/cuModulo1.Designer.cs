// cuModulo1.Designer.cs  (REEMPLAZA TODO tu archivo por este)
// Tabs más grandes (alto del top menu + host + icono)

using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    partial class cuModulo1
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
            TurismopanelContenido = new Panel();
            panelContent = new Panel();
            panelTopMenu = new Panel();
            tablaTopMenu = new TableLayoutPanel();

            hostRegistrar = new Panel();
            layoutRegistrar = new TableLayoutPanel();
            iconRegistrar = new PictureBox();
            lblRegistrar = new Label();

            hostVer = new Panel();
            layoutVer = new TableLayoutPanel();
            iconVer = new PictureBox();
            lblVer = new Label();

            hostAgenda = new Panel();
            layoutAgenda = new TableLayoutPanel();
            iconAgenda = new PictureBox();
            lblAgenda = new Label();

            hostRutas = new Panel();
            layoutRutas = new TableLayoutPanel();
            iconRutas = new PictureBox();
            lblRutas = new Label();

            hostMinijuego = new Panel();
            layoutMinijuego = new TableLayoutPanel();
            iconMinijuego = new PictureBox();
            lblMinijuego = new Label();

            TurismopanelContenido.SuspendLayout();
            panelTopMenu.SuspendLayout();
            tablaTopMenu.SuspendLayout();

            hostRegistrar.SuspendLayout();
            layoutRegistrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRegistrar).BeginInit();

            hostVer.SuspendLayout();
            layoutVer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconVer).BeginInit();

            hostAgenda.SuspendLayout();
            layoutAgenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconAgenda).BeginInit();

            hostRutas.SuspendLayout();
            layoutRutas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconRutas).BeginInit();

            hostMinijuego.SuspendLayout();
            layoutMinijuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconMinijuego).BeginInit();

            SuspendLayout();

            // TurismopanelContenido
            TurismopanelContenido.BackColor = Color.Transparent;
            TurismopanelContenido.Controls.Add(panelContent);
            TurismopanelContenido.Controls.Add(panelTopMenu);
            TurismopanelContenido.Dock = DockStyle.Fill;
            TurismopanelContenido.Location = new Point(0, 0);
            TurismopanelContenido.Name = "TurismopanelContenido";
            TurismopanelContenido.Size = new Size(1374, 665);
            TurismopanelContenido.TabIndex = 0;

            // panelContent (baja porque top menu ahora es más alto)
            panelContent.BackColor = Color.Transparent;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 112);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1374, 553);
            panelContent.TabIndex = 1;

            // panelTopMenu (más alto)
            panelTopMenu.BackColor = Color.Transparent;
            panelTopMenu.Controls.Add(tablaTopMenu);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Padding = new Padding(18, 14, 18, 14);
            panelTopMenu.Size = new Size(1374, 112);
            panelTopMenu.TabIndex = 0;

            // tablaTopMenu
            tablaTopMenu.BackColor = Color.Transparent;
            tablaTopMenu.ColumnCount = 5;
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.Controls.Add(hostRegistrar, 0, 0);
            tablaTopMenu.Controls.Add(hostVer, 1, 0);
            tablaTopMenu.Controls.Add(hostAgenda, 2, 0);
            tablaTopMenu.Controls.Add(hostRutas, 3, 0);
            tablaTopMenu.Controls.Add(hostMinijuego, 4, 0);
            tablaTopMenu.Dock = DockStyle.Fill;
            tablaTopMenu.Location = new Point(18, 14);
            tablaTopMenu.Name = "tablaTopMenu";
            tablaTopMenu.RowCount = 1;
            tablaTopMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaTopMenu.Size = new Size(1338, 84);
            tablaTopMenu.TabIndex = 0;

            // hostRegistrar
            hostRegistrar.Controls.Add(layoutRegistrar);
            hostRegistrar.Dock = DockStyle.Fill;
            hostRegistrar.Location = new Point(12, 10);
            hostRegistrar.Margin = new Padding(12, 10, 12, 10);
            hostRegistrar.Name = "hostRegistrar";
            hostRegistrar.Size = new Size(243, 64);
            hostRegistrar.TabIndex = 1;

            layoutRegistrar.ColumnCount = 2;
            layoutRegistrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            layoutRegistrar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            layoutRegistrar.Controls.Add(iconRegistrar, 0, 0);
            layoutRegistrar.Controls.Add(lblRegistrar, 1, 0);
            layoutRegistrar.Dock = DockStyle.Fill;
            layoutRegistrar.Location = new Point(0, 0);
            layoutRegistrar.Margin = new Padding(0);
            layoutRegistrar.Name = "layoutRegistrar";
            layoutRegistrar.RowCount = 1;
            layoutRegistrar.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutRegistrar.Size = new Size(243, 64);
            layoutRegistrar.TabIndex = 0;

            iconRegistrar.Dock = DockStyle.Fill;
            iconRegistrar.Location = new Point(12, 10);
            iconRegistrar.Margin = new Padding(12, 10, 6, 10);
            iconRegistrar.Name = "iconRegistrar";
            iconRegistrar.Size = new Size(40, 44);
            iconRegistrar.TabIndex = 0;
            iconRegistrar.TabStop = false;

            lblRegistrar.Dock = DockStyle.Fill;
            lblRegistrar.Location = new Point(66, 0);
            lblRegistrar.Margin = new Padding(6, 0, 10, 0);
            lblRegistrar.Name = "lblRegistrar";
            lblRegistrar.Size = new Size(167, 64);
            lblRegistrar.TabIndex = 1;
            lblRegistrar.Text = "Registrar Caballo";
            lblRegistrar.TextAlign = ContentAlignment.MiddleCenter;

            // hostVer
            hostVer.Controls.Add(layoutVer);
            hostVer.Dock = DockStyle.Fill;
            hostVer.Location = new Point(279, 10);
            hostVer.Margin = new Padding(12, 10, 12, 10);
            hostVer.Name = "hostVer";
            hostVer.Size = new Size(243, 64);
            hostVer.TabIndex = 2;

            layoutVer.ColumnCount = 2;
            layoutVer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            layoutVer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            layoutVer.Controls.Add(iconVer, 0, 0);
            layoutVer.Controls.Add(lblVer, 1, 0);
            layoutVer.Dock = DockStyle.Fill;
            layoutVer.Location = new Point(0, 0);
            layoutVer.Margin = new Padding(0);
            layoutVer.Name = "layoutVer";
            layoutVer.RowCount = 1;
            layoutVer.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutVer.Size = new Size(243, 64);
            layoutVer.TabIndex = 0;

            iconVer.Dock = DockStyle.Fill;
            iconVer.Location = new Point(12, 10);
            iconVer.Margin = new Padding(12, 10, 6, 10);
            iconVer.Name = "iconVer";
            iconVer.Size = new Size(40, 44);
            iconVer.TabIndex = 0;
            iconVer.TabStop = false;

            lblVer.Dock = DockStyle.Fill;
            lblVer.Location = new Point(66, 0);
            lblVer.Margin = new Padding(6, 0, 10, 0);
            lblVer.Name = "lblVer";
            lblVer.Size = new Size(167, 64);
            lblVer.TabIndex = 1;
            lblVer.Text = "Ver Caballos";
            lblVer.TextAlign = ContentAlignment.MiddleCenter;

            // hostAgenda
            hostAgenda.Controls.Add(layoutAgenda);
            hostAgenda.Dock = DockStyle.Fill;
            hostAgenda.Location = new Point(546, 10);
            hostAgenda.Margin = new Padding(12, 10, 12, 10);
            hostAgenda.Name = "hostAgenda";
            hostAgenda.Size = new Size(243, 64);
            hostAgenda.TabIndex = 3;

            layoutAgenda.ColumnCount = 2;
            layoutAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            layoutAgenda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            layoutAgenda.Controls.Add(iconAgenda, 0, 0);
            layoutAgenda.Controls.Add(lblAgenda, 1, 0);
            layoutAgenda.Dock = DockStyle.Fill;
            layoutAgenda.Location = new Point(0, 0);
            layoutAgenda.Margin = new Padding(0);
            layoutAgenda.Name = "layoutAgenda";
            layoutAgenda.RowCount = 1;
            layoutAgenda.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutAgenda.Size = new Size(243, 64);
            layoutAgenda.TabIndex = 0;

            iconAgenda.Dock = DockStyle.Fill;
            iconAgenda.Location = new Point(12, 10);
            iconAgenda.Margin = new Padding(12, 10, 6, 10);
            iconAgenda.Name = "iconAgenda";
            iconAgenda.Size = new Size(40, 44);
            iconAgenda.TabIndex = 0;
            iconAgenda.TabStop = false;

            lblAgenda.Dock = DockStyle.Fill;
            lblAgenda.Location = new Point(66, 0);
            lblAgenda.Margin = new Padding(6, 0, 10, 0);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(167, 64);
            lblAgenda.TabIndex = 1;
            lblAgenda.Text = "Agenda";
            lblAgenda.TextAlign = ContentAlignment.MiddleCenter;

            // hostRutas
            hostRutas.Controls.Add(layoutRutas);
            hostRutas.Dock = DockStyle.Fill;
            hostRutas.Location = new Point(813, 10);
            hostRutas.Margin = new Padding(12, 10, 12, 10);
            hostRutas.Name = "hostRutas";
            hostRutas.Size = new Size(243, 64);
            hostRutas.TabIndex = 4;

            layoutRutas.ColumnCount = 2;
            layoutRutas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24F));
            layoutRutas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76F));
            layoutRutas.Controls.Add(iconRutas, 0, 0);
            layoutRutas.Controls.Add(lblRutas, 1, 0);
            layoutRutas.Dock = DockStyle.Fill;
            layoutRutas.Location = new Point(0, 0);
            layoutRutas.Margin = new Padding(0);
            layoutRutas.Name = "layoutRutas";
            layoutRutas.RowCount = 1;
            layoutRutas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutRutas.Size = new Size(243, 64);
            layoutRutas.TabIndex = 0;

            iconRutas.Dock = DockStyle.Fill;
            iconRutas.Location = new Point(12, 10);
            iconRutas.Margin = new Padding(12, 10, 6, 10);
            iconRutas.Name = "iconRutas";
            iconRutas.Size = new Size(40, 44);
            iconRutas.TabIndex = 0;
            iconRutas.TabStop = false;

            lblRutas.Dock = DockStyle.Fill;
            lblRutas.Location = new Point(66, 0);
            lblRutas.Margin = new Padding(6, 0, 10, 0);
            lblRutas.Name = "lblRutas";
            lblRutas.Size = new Size(167, 64);
            lblRutas.TabIndex = 1;
            lblRutas.Text = "Rutas Turísticas";
            lblRutas.TextAlign = ContentAlignment.MiddleCenter;

            // hostMinijuego
            hostMinijuego.Controls.Add(layoutMinijuego);
            hostMinijuego.Dock = DockStyle.Fill;
            hostMinijuego.Location = new Point(1080, 10);
            hostMinijuego.Margin = new Padding(12, 10, 12, 10);
            hostMinijuego.Name = "hostMinijuego";
            hostMinijuego.Size = new Size(246, 64);
            hostMinijuego.TabIndex = 5;

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
            layoutMinijuego.Size = new Size(246, 64);
            layoutMinijuego.TabIndex = 0;

            iconMinijuego.Dock = DockStyle.Fill;
            iconMinijuego.Location = new Point(12, 10);
            iconMinijuego.Margin = new Padding(12, 10, 6, 10);
            iconMinijuego.Name = "iconMinijuego";
            iconMinijuego.Size = new Size(41, 44);
            iconMinijuego.TabIndex = 0;
            iconMinijuego.TabStop = false;

            lblMinijuego.Dock = DockStyle.Fill;
            lblMinijuego.Location = new Point(67, 0);
            lblMinijuego.Margin = new Padding(6, 0, 10, 0);
            lblMinijuego.Name = "lblMinijuego";
            lblMinijuego.Size = new Size(169, 64);
            lblMinijuego.TabIndex = 1;
            lblMinijuego.Text = "Minijuego";
            lblMinijuego.TextAlign = ContentAlignment.MiddleCenter;

            // Control
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TurismopanelContenido);
            Name = "cuModulo1";
            Size = new Size(1374, 665);
            Load += cuModulo1_Load;

            TurismopanelContenido.ResumeLayout(false);
            panelTopMenu.ResumeLayout(false);
            tablaTopMenu.ResumeLayout(false);

            hostRegistrar.ResumeLayout(false);
            layoutRegistrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconRegistrar).EndInit();

            hostVer.ResumeLayout(false);
            layoutVer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconVer).EndInit();

            hostAgenda.ResumeLayout(false);
            layoutAgenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconAgenda).EndInit();

            hostRutas.ResumeLayout(false);
            layoutRutas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconRutas).EndInit();

            hostMinijuego.ResumeLayout(false);
            layoutMinijuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconMinijuego).EndInit();

            ResumeLayout(false);
        }

        private Panel TurismopanelContenido;
        private Panel panelTopMenu;
        private TableLayoutPanel tablaTopMenu;
        private Panel panelContent;

        private Panel hostRegistrar;
        private Panel hostVer;
        private Panel hostAgenda;
        private Panel hostRutas;
        private Panel hostMinijuego;

        private TableLayoutPanel layoutRegistrar;
        private TableLayoutPanel layoutVer;
        private TableLayoutPanel layoutAgenda;
        private TableLayoutPanel layoutRutas;
        private TableLayoutPanel layoutMinijuego;

        private PictureBox iconRegistrar;
        private PictureBox iconVer;
        private PictureBox iconAgenda;
        private PictureBox iconRutas;
        private PictureBox iconMinijuego;

        private Label lblRegistrar;
        private Label lblVer;
        private Label lblAgenda;
        private Label lblRutas;
        private Label lblMinijuego;
    }
}
