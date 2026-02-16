// cuModulo1.Designer.cs
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
            TurismoButtonRegistrar = new Button();
            TurismoButtonVer = new Button();
            TurismoButtonAgenda = new Button();
            TurismoButtonRutas = new Button();
            TurismoButtonMinijuego = new Button();
            TurismopanelContenido.SuspendLayout();
            panelTopMenu.SuspendLayout();
            tablaTopMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TurismopanelContenido
            // 
            TurismopanelContenido.BackColor = Color.Transparent;
            TurismopanelContenido.Controls.Add(panelContent);
            TurismopanelContenido.Controls.Add(panelTopMenu);
            TurismopanelContenido.Dock = DockStyle.Fill;
            TurismopanelContenido.Location = new Point(0, 0);
            TurismopanelContenido.Name = "TurismopanelContenido";
            TurismopanelContenido.Size = new Size(1374, 665);
            TurismopanelContenido.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 95);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1374, 570);
            panelContent.TabIndex = 1;
            // 
            // panelTopMenu
            // 
            panelTopMenu.BackColor = Color.Transparent;
            panelTopMenu.Controls.Add(tablaTopMenu);
            panelTopMenu.Dock = DockStyle.Top;
            panelTopMenu.Location = new Point(0, 0);
            panelTopMenu.Name = "panelTopMenu";
            panelTopMenu.Padding = new Padding(18, 12, 18, 12);
            panelTopMenu.Size = new Size(1374, 95);
            panelTopMenu.TabIndex = 0;
            // 
            // tablaTopMenu
            // 
            tablaTopMenu.BackColor = Color.Transparent;
            tablaTopMenu.ColumnCount = 5;
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaTopMenu.Controls.Add(TurismoButtonRegistrar, 0, 0);
            tablaTopMenu.Controls.Add(TurismoButtonVer, 1, 0);
            tablaTopMenu.Controls.Add(TurismoButtonAgenda, 2, 0);
            tablaTopMenu.Controls.Add(TurismoButtonRutas, 3, 0);
            tablaTopMenu.Controls.Add(TurismoButtonMinijuego, 4, 0);
            tablaTopMenu.Dock = DockStyle.Fill;
            tablaTopMenu.Location = new Point(18, 12);
            tablaTopMenu.Name = "tablaTopMenu";
            tablaTopMenu.RowCount = 1;
            tablaTopMenu.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaTopMenu.Size = new Size(1338, 71);
            tablaTopMenu.TabIndex = 0;
            // 
            // TurismoButtonRegistrar
            // 
            TurismoButtonRegistrar.Dock = DockStyle.Fill;
            TurismoButtonRegistrar.Location = new Point(12, 10);
            TurismoButtonRegistrar.Margin = new Padding(12, 10, 12, 10);
            TurismoButtonRegistrar.Name = "TurismoButtonRegistrar";
            TurismoButtonRegistrar.Size = new Size(243, 51);
            TurismoButtonRegistrar.TabIndex = 1;
            TurismoButtonRegistrar.Text = "Registrar Caballo";
            TurismoButtonRegistrar.UseVisualStyleBackColor = true;
            TurismoButtonRegistrar.Click += TurismoButtonRegistrar_Click;
            // 
            // TurismoButtonVer
            // 
            TurismoButtonVer.Dock = DockStyle.Fill;
            TurismoButtonVer.Location = new Point(279, 10);
            TurismoButtonVer.Margin = new Padding(12, 10, 12, 10);
            TurismoButtonVer.Name = "TurismoButtonVer";
            TurismoButtonVer.Size = new Size(243, 51);
            TurismoButtonVer.TabIndex = 2;
            TurismoButtonVer.Text = "Ver Caballos";
            TurismoButtonVer.UseVisualStyleBackColor = true;
            TurismoButtonVer.Click += TurismoButtonVer_Click;
            // 
            // TurismoButtonAgenda
            // 
            TurismoButtonAgenda.Dock = DockStyle.Fill;
            TurismoButtonAgenda.Location = new Point(546, 10);
            TurismoButtonAgenda.Margin = new Padding(12, 10, 12, 10);
            TurismoButtonAgenda.Name = "TurismoButtonAgenda";
            TurismoButtonAgenda.Size = new Size(243, 51);
            TurismoButtonAgenda.TabIndex = 3;
            TurismoButtonAgenda.Text = "Agenda";
            TurismoButtonAgenda.UseVisualStyleBackColor = true;
            TurismoButtonAgenda.Click += TurismoButtonAgenda_Click;
            // 
            // TurismoButtonRutas
            // 
            TurismoButtonRutas.Dock = DockStyle.Fill;
            TurismoButtonRutas.Location = new Point(813, 10);
            TurismoButtonRutas.Margin = new Padding(12, 10, 12, 10);
            TurismoButtonRutas.Name = "TurismoButtonRutas";
            TurismoButtonRutas.Size = new Size(243, 51);
            TurismoButtonRutas.TabIndex = 4;
            TurismoButtonRutas.Text = "Rutas Turísticas";
            TurismoButtonRutas.UseVisualStyleBackColor = true;
            TurismoButtonRutas.Click += TurismoButtonRutas_Click;
            // 
            // TurismoButtonMinijuego
            // 
            TurismoButtonMinijuego.Dock = DockStyle.Fill;
            TurismoButtonMinijuego.Location = new Point(1080, 10);
            TurismoButtonMinijuego.Margin = new Padding(12, 10, 12, 10);
            TurismoButtonMinijuego.Name = "TurismoButtonMinijuego";
            TurismoButtonMinijuego.Size = new Size(246, 51);
            TurismoButtonMinijuego.TabIndex = 5;
            TurismoButtonMinijuego.Text = "Minijuego";
            TurismoButtonMinijuego.UseVisualStyleBackColor = true;
            TurismoButtonMinijuego.Click += TurismoButtonMinijuego_Click;
            // 
            // cuModulo1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TurismopanelContenido);
            Name = "cuModulo1";
            Size = new Size(1374, 665);
            Load += cuModulo1_Load;
            TurismopanelContenido.ResumeLayout(false);
            panelTopMenu.ResumeLayout(false);
            tablaTopMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel TurismopanelContenido;
        private Panel panelTopMenu;
        private TableLayoutPanel tablaTopMenu;
        private Panel panelContent;

        private Button TurismoButtonRegistrar;
        private Button TurismoButtonVer;
        private Button TurismoButtonAgenda;
        private Button TurismoButtonRutas;
        private Button TurismoButtonMinijuego;
    }
}
