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
            TurismoButtonRegistrar = new Button();
            TurismoButtonVer = new Button();
            TurismoButtonAgenda = new Button();
            TurismoButtonMinijuego = new Button();
            TurismoPictureRegistrar = new PictureBox();
            TurismoPictureVer = new PictureBox();
            TurismoPictureAgenda = new PictureBox();
            TurismoPictureMinijuego = new PictureBox();
            TurismopanelContenido = new Panel();
            TurismotablaCentro = new TableLayoutPanel();
            Turismopanel4 = new Panel();
            Turismopanel3 = new Panel();
            Turismopanel2 = new Panel();
            Turismopanel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureRegistrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureVer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureMinijuego).BeginInit();
            TurismopanelContenido.SuspendLayout();
            TurismotablaCentro.SuspendLayout();
            Turismopanel4.SuspendLayout();
            Turismopanel3.SuspendLayout();
            Turismopanel2.SuspendLayout();
            Turismopanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TurismoButtonRegistrar
            // 
            TurismoButtonRegistrar.Dock = DockStyle.Bottom;
            TurismoButtonRegistrar.Location = new Point(0, 171);
            TurismoButtonRegistrar.Name = "TurismoButtonRegistrar";
            TurismoButtonRegistrar.Size = new Size(330, 50);
            TurismoButtonRegistrar.TabIndex = 0;
            TurismoButtonRegistrar.Text = "Registrar Caballo";
            TurismoButtonRegistrar.Click += TurismoButtonRegistrar_Click;
            // 
            // TurismoButtonVer
            // 
            TurismoButtonVer.Dock = DockStyle.Bottom;
            TurismoButtonVer.Location = new Point(0, 171);
            TurismoButtonVer.Name = "TurismoButtonVer";
            TurismoButtonVer.Size = new Size(330, 50);
            TurismoButtonVer.TabIndex = 1;
            TurismoButtonVer.Text = "Ver Caballos";
            TurismoButtonVer.Click += TurismoButtonVer_Click;
            // 
            // TurismoButtonAgenda
            // 
            TurismoButtonAgenda.Dock = DockStyle.Bottom;
            TurismoButtonAgenda.Location = new Point(0, 172);
            TurismoButtonAgenda.Name = "TurismoButtonAgenda";
            TurismoButtonAgenda.Size = new Size(330, 50);
            TurismoButtonAgenda.TabIndex = 2;
            TurismoButtonAgenda.Text = "Agenda";
            TurismoButtonAgenda.Click += TurismoButtonAgenda_Click;
            // 
            // TurismoButtonMinijuego
            // 
            TurismoButtonMinijuego.Dock = DockStyle.Bottom;
            TurismoButtonMinijuego.Location = new Point(0, 172);
            TurismoButtonMinijuego.Name = "TurismoButtonMinijuego";
            TurismoButtonMinijuego.Size = new Size(330, 50);
            TurismoButtonMinijuego.TabIndex = 3;
            TurismoButtonMinijuego.Text = "Minijuego";
            TurismoButtonMinijuego.Click += TurismoButtonMinijuego_Click;
            // 
            // TurismoPictureRegistrar
            // 
            TurismoPictureRegistrar.Dock = DockStyle.Top;
            TurismoPictureRegistrar.Image = Properties.Resources.registrar;
            TurismoPictureRegistrar.Location = new Point(0, 0);
            TurismoPictureRegistrar.Name = "TurismoPictureRegistrar";
            TurismoPictureRegistrar.Size = new Size(330, 120);
            TurismoPictureRegistrar.SizeMode = PictureBoxSizeMode.Zoom;
            TurismoPictureRegistrar.TabIndex = 4;
            TurismoPictureRegistrar.TabStop = false;
            // 
            // TurismoPictureVer
            // 
            TurismoPictureVer.Dock = DockStyle.Top;
            TurismoPictureVer.Image = Properties.Resources.ver_registro;
            TurismoPictureVer.Location = new Point(0, 0);
            TurismoPictureVer.Name = "TurismoPictureVer";
            TurismoPictureVer.Size = new Size(330, 120);
            TurismoPictureVer.SizeMode = PictureBoxSizeMode.Zoom;
            TurismoPictureVer.TabIndex = 5;
            TurismoPictureVer.TabStop = false;
            // 
            // TurismoPictureAgenda
            // 
            TurismoPictureAgenda.Dock = DockStyle.Top;
            TurismoPictureAgenda.Image = Properties.Resources.agenda;
            TurismoPictureAgenda.Location = new Point(0, 0);
            TurismoPictureAgenda.Name = "TurismoPictureAgenda";
            TurismoPictureAgenda.Size = new Size(330, 120);
            TurismoPictureAgenda.SizeMode = PictureBoxSizeMode.Zoom;
            TurismoPictureAgenda.TabIndex = 6;
            TurismoPictureAgenda.TabStop = false;
            // 
            // TurismoPictureMinijuego
            // 
            TurismoPictureMinijuego.Dock = DockStyle.Top;
            TurismoPictureMinijuego.Image = Properties.Resources.minijuego;
            TurismoPictureMinijuego.Location = new Point(0, 0);
            TurismoPictureMinijuego.Name = "TurismoPictureMinijuego";
            TurismoPictureMinijuego.Size = new Size(330, 120);
            TurismoPictureMinijuego.SizeMode = PictureBoxSizeMode.Zoom;
            TurismoPictureMinijuego.TabIndex = 7;
            TurismoPictureMinijuego.TabStop = false;
            // 
            // TurismopanelContenido
            // 
            TurismopanelContenido.BackColor = Color.Transparent;
            TurismopanelContenido.BackgroundImage = Properties.Resources._2;
            TurismopanelContenido.Controls.Add(TurismotablaCentro);
            TurismopanelContenido.Dock = DockStyle.Fill;
            TurismopanelContenido.Location = new Point(0, 0);
            TurismopanelContenido.Name = "TurismopanelContenido";
            TurismopanelContenido.Size = new Size(800, 500);
            TurismopanelContenido.TabIndex = 8;
            TurismopanelContenido.Resize += TurismopanelContenido_Resize;
            // 
            // TurismotablaCentro
            // 
            TurismotablaCentro.ColumnCount = 2;
            TurismotablaCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TurismotablaCentro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TurismotablaCentro.Controls.Add(Turismopanel4, 1, 1);
            TurismotablaCentro.Controls.Add(Turismopanel3, 0, 1);
            TurismotablaCentro.Controls.Add(Turismopanel2, 1, 0);
            TurismotablaCentro.Controls.Add(Turismopanel1, 0, 0);
            TurismotablaCentro.Location = new Point(41, 23);
            TurismotablaCentro.Name = "TurismotablaCentro";
            TurismotablaCentro.RowCount = 2;
            TurismotablaCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TurismotablaCentro.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TurismotablaCentro.Size = new Size(672, 455);
            TurismotablaCentro.TabIndex = 8;
            // 
            // Turismopanel4
            // 
            Turismopanel4.Controls.Add(TurismoButtonMinijuego);
            Turismopanel4.Controls.Add(TurismoPictureMinijuego);
            Turismopanel4.Dock = DockStyle.Fill;
            Turismopanel4.Location = new Point(339, 230);
            Turismopanel4.Name = "Turismopanel4";
            Turismopanel4.Size = new Size(330, 222);
            Turismopanel4.TabIndex = 3;
            // 
            // Turismopanel3
            // 
            Turismopanel3.Controls.Add(TurismoPictureAgenda);
            Turismopanel3.Controls.Add(TurismoButtonAgenda);
            Turismopanel3.Dock = DockStyle.Fill;
            Turismopanel3.Location = new Point(3, 230);
            Turismopanel3.Name = "Turismopanel3";
            Turismopanel3.Size = new Size(330, 222);
            Turismopanel3.TabIndex = 2;
            // 
            // Turismopanel2
            // 
            Turismopanel2.Controls.Add(TurismoPictureVer);
            Turismopanel2.Controls.Add(TurismoButtonVer);
            Turismopanel2.Dock = DockStyle.Fill;
            Turismopanel2.Location = new Point(339, 3);
            Turismopanel2.Name = "Turismopanel2";
            Turismopanel2.Size = new Size(330, 221);
            Turismopanel2.TabIndex = 1;
            // 
            // Turismopanel1
            // 
            Turismopanel1.Controls.Add(TurismoPictureRegistrar);
            Turismopanel1.Controls.Add(TurismoButtonRegistrar);
            Turismopanel1.Dock = DockStyle.Fill;
            Turismopanel1.Location = new Point(3, 3);
            Turismopanel1.Name = "Turismopanel1";
            Turismopanel1.Size = new Size(330, 221);
            Turismopanel1.TabIndex = 0;
            // 
            // cuModulo1
            // 
            BackgroundImage = Properties.Resources._2;
            Controls.Add(TurismopanelContenido);
            Name = "cuModulo1";
            Size = new Size(800, 500);
            Load += cuModulo1_Load;
            ((System.ComponentModel.ISupportInitialize)TurismoPictureRegistrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureVer).EndInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureMinijuego).EndInit();
            TurismopanelContenido.ResumeLayout(false);
            TurismotablaCentro.ResumeLayout(false);
            Turismopanel4.ResumeLayout(false);
            Turismopanel3.ResumeLayout(false);
            Turismopanel2.ResumeLayout(false);
            Turismopanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Button TurismoButtonRegistrar;
        private Button TurismoButtonVer;
        private Button TurismoButtonAgenda;
        private Button TurismoButtonMinijuego;

        private PictureBox TurismoPictureRegistrar;
        private PictureBox TurismoPictureVer;
        private PictureBox TurismoPictureAgenda;
        private PictureBox TurismoPictureMinijuego;
        private Panel TurismopanelContenido;
        private TableLayoutPanel TurismotablaCentro;
        private Panel Turismopanel4;
        private Panel Turismopanel3;
        private Panel Turismopanel2;
        private Panel Turismopanel1;
    }
}
