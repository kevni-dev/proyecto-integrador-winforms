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
            TurismoButtonRutas = new Button();
            TurismoPictureRegistrar = new PictureBox();
            TurismoPictureVer = new PictureBox();
            TurismoPictureAgenda = new PictureBox();
            TurismoPictureMinijuego = new PictureBox();
            TurismoPictureRutas = new PictureBox();
            TurismopanelContenido = new Panel();
            panelMenu = new Panel();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureRegistrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureVer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureAgenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureMinijuego).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureRutas).BeginInit();
            TurismopanelContenido.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TurismoButtonRegistrar
            // 
            TurismoButtonRegistrar.Location = new Point(-15, 264);
            TurismoButtonRegistrar.Name = "TurismoButtonRegistrar";
            TurismoButtonRegistrar.Size = new Size(360, 55);
            TurismoButtonRegistrar.TabIndex = 1;
            TurismoButtonRegistrar.Text = "Registrar Caballo";
            TurismoButtonRegistrar.UseVisualStyleBackColor = true;
            TurismoButtonRegistrar.Click += TurismoButtonRegistrar_Click;
            // 
            // TurismoButtonVer
            // 
            TurismoButtonVer.Location = new Point(946, 236);
            TurismoButtonVer.Name = "TurismoButtonVer";
            TurismoButtonVer.Size = new Size(360, 55);
            TurismoButtonVer.TabIndex = 3;
            TurismoButtonVer.Text = "Ver Caballos";
            TurismoButtonVer.UseVisualStyleBackColor = true;
            TurismoButtonVer.Click += TurismoButtonVer_Click;
            // 
            // TurismoButtonAgenda
            // 
            TurismoButtonAgenda.Location = new Point(-15, 585);
            TurismoButtonAgenda.Name = "TurismoButtonAgenda";
            TurismoButtonAgenda.Size = new Size(360, 55);
            TurismoButtonAgenda.TabIndex = 5;
            TurismoButtonAgenda.Text = "Agenda";
            TurismoButtonAgenda.UseVisualStyleBackColor = true;
            TurismoButtonAgenda.Click += TurismoButtonAgenda_Click;
            // 
            // TurismoButtonMinijuego
            // 
            TurismoButtonMinijuego.Location = new Point(946, 569);
            TurismoButtonMinijuego.Name = "TurismoButtonMinijuego";
            TurismoButtonMinijuego.Size = new Size(360, 55);
            TurismoButtonMinijuego.TabIndex = 7;
            TurismoButtonMinijuego.Text = "Minijuego";
            TurismoButtonMinijuego.UseVisualStyleBackColor = true;
            TurismoButtonMinijuego.Click += TurismoButtonMinijuego_Click;
            // 
            // TurismoButtonRutas
            // 
            TurismoButtonRutas.Location = new Point(459, 585);
            TurismoButtonRutas.Name = "TurismoButtonRutas";
            TurismoButtonRutas.Size = new Size(360, 55);
            TurismoButtonRutas.TabIndex = 9;
            TurismoButtonRutas.Text = "Rutas Turísticas";
            TurismoButtonRutas.UseVisualStyleBackColor = true;
            TurismoButtonRutas.Click += TurismoButtonRutas_Click;
            // 
            // TurismoPictureRegistrar
            // 
            TurismoPictureRegistrar.Image = Properties.Resources.registrar;
            TurismoPictureRegistrar.Location = new Point(108, 98);
            TurismoPictureRegistrar.Name = "TurismoPictureRegistrar";
            TurismoPictureRegistrar.Size = new Size(160, 160);
            TurismoPictureRegistrar.SizeMode = PictureBoxSizeMode.Zoom;
            TurismoPictureRegistrar.TabIndex = 0;
            TurismoPictureRegistrar.TabStop = false;
            // 
            // TurismoPictureVer
            // 
            TurismoPictureVer.Image = Properties.Resources.ver_registro;
            TurismoPictureVer.Location = new Point(1046, 66);
            TurismoPictureVer.Name = "TurismoPictureVer";
            TurismoPictureVer.Size = new Size(160, 160);
            TurismoPictureVer.SizeMode = PictureBoxSizeMode.Zoom;
            TurismoPictureVer.TabIndex = 2;
            TurismoPictureVer.TabStop = false;
            // 
            // TurismoPictureAgenda
            // 
            TurismoPictureAgenda.Image = Properties.Resources.agenda;
            TurismoPictureAgenda.Location = new Point(85, 415);
            TurismoPictureAgenda.Name = "TurismoPictureAgenda";
            TurismoPictureAgenda.Size = new Size(160, 160);
            TurismoPictureAgenda.SizeMode = PictureBoxSizeMode.Zoom;
            TurismoPictureAgenda.TabIndex = 4;
            TurismoPictureAgenda.TabStop = false;
            // 
            // TurismoPictureMinijuego
            // 
            TurismoPictureMinijuego.Image = Properties.Resources.minijuego;
            TurismoPictureMinijuego.Location = new Point(1046, 399);
            TurismoPictureMinijuego.Name = "TurismoPictureMinijuego";
            TurismoPictureMinijuego.Size = new Size(160, 160);
            TurismoPictureMinijuego.SizeMode = PictureBoxSizeMode.Zoom;
            TurismoPictureMinijuego.TabIndex = 6;
            TurismoPictureMinijuego.TabStop = false;
            // 
            // TurismoPictureRutas
            // 
            TurismoPictureRutas.Image = Properties.Resources.agenda;
            TurismoPictureRutas.Location = new Point(583, 425);
            TurismoPictureRutas.Name = "TurismoPictureRutas";
            TurismoPictureRutas.Size = new Size(130, 130);
            TurismoPictureRutas.SizeMode = PictureBoxSizeMode.Zoom;
            TurismoPictureRutas.TabIndex = 8;
            TurismoPictureRutas.TabStop = false;
            // 
            // TurismopanelContenido
            // 
            TurismopanelContenido.BackColor = Color.Transparent;
            TurismopanelContenido.BackgroundImage = Properties.Resources._2;
            TurismopanelContenido.BackgroundImageLayout = ImageLayout.Stretch;
            TurismopanelContenido.Controls.Add(panelMenu);
            TurismopanelContenido.Dock = DockStyle.Fill;
            TurismopanelContenido.Location = new Point(0, 0);
            TurismopanelContenido.Name = "TurismopanelContenido";
            TurismopanelContenido.Size = new Size(1374, 665);
            TurismopanelContenido.TabIndex = 0;
            TurismopanelContenido.Resize += TurismopanelContenido_Resize;
            // 
            // panelMenu
            // 
            panelMenu.Anchor = AnchorStyles.None;
            panelMenu.BackColor = Color.Transparent;
            panelMenu.Controls.Add(TurismoPictureRegistrar);
            panelMenu.Controls.Add(TurismoButtonRegistrar);
            panelMenu.Controls.Add(TurismoPictureVer);
            panelMenu.Controls.Add(TurismoButtonVer);
            panelMenu.Controls.Add(TurismoPictureAgenda);
            panelMenu.Controls.Add(TurismoButtonAgenda);
            panelMenu.Controls.Add(TurismoPictureMinijuego);
            panelMenu.Controls.Add(TurismoButtonMinijuego);
            panelMenu.Controls.Add(TurismoPictureRutas);
            panelMenu.Controls.Add(TurismoButtonRutas);
            panelMenu.Location = new Point(3, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(1368, 659);
            panelMenu.TabIndex = 0;
            // 
            // cuModulo1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TurismopanelContenido);
            Name = "cuModulo1";
            Size = new Size(1374, 665);
            Load += cuModulo1_Load;
            ((System.ComponentModel.ISupportInitialize)TurismoPictureRegistrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureVer).EndInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureAgenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureMinijuego).EndInit();
            ((System.ComponentModel.ISupportInitialize)TurismoPictureRutas).EndInit();
            TurismopanelContenido.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        // Botones
        private Button TurismoButtonRegistrar;
        private Button TurismoButtonVer;
        private Button TurismoButtonAgenda;
        private Button TurismoButtonMinijuego;
        private Button TurismoButtonRutas;

        // Imágenes
        private PictureBox TurismoPictureRegistrar;
        private PictureBox TurismoPictureVer;
        private PictureBox TurismoPictureAgenda;
        private PictureBox TurismoPictureMinijuego;
        private PictureBox TurismoPictureRutas;

        // Contenedores
        private Panel TurismopanelContenido;
        private Panel panelMenu;
    }
}
