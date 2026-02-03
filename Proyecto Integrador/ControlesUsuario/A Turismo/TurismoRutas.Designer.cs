using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.A_Turismo
{
    partial class TurismoRutas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes
        private void InitializeComponent()
        {
            panelMapa = new Panel();
            pictureMapa = new PictureBox();
            btnCumbaya = new Button();
            btnEsperanza = new Button();
            btnArrayanes = new Button();
            btnLomita = new Button();
            btnPuembo = new Button();
            btnRutaCumbayaEsperanza = new Button();
            btnRutaArrayanesPuembo = new Button();
            panelInfo = new Panel();
            lblTiempo = new Label();
            lblServicios = new Label();
            lblDescripcion = new Label();
            picturePortal = new PictureBox();
            lblTitulo = new Label();
            panelMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureMapa).BeginInit();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picturePortal).BeginInit();
            SuspendLayout();
            // 
            // panelMapa
            // 
            panelMapa.BackColor = Color.White;
            panelMapa.Controls.Add(pictureMapa);
            panelMapa.Controls.Add(btnCumbaya);
            panelMapa.Controls.Add(btnEsperanza);
            panelMapa.Controls.Add(btnArrayanes);
            panelMapa.Controls.Add(btnLomita);
            panelMapa.Controls.Add(btnPuembo);
            panelMapa.Controls.Add(btnRutaCumbayaEsperanza);
            panelMapa.Controls.Add(btnRutaArrayanesPuembo);
            panelMapa.Dock = DockStyle.Fill;
            panelMapa.Location = new Point(0, 0);
            panelMapa.Name = "panelMapa";
            panelMapa.Size = new Size(880, 500);
            panelMapa.TabIndex = 0;
            // 
            // pictureMapa
            // 
            pictureMapa.BackColor = Color.White;
            pictureMapa.Dock = DockStyle.Fill;
            pictureMapa.Image = Properties.Resources.mapa_rutas;
            pictureMapa.Location = new Point(0, 0);
            pictureMapa.Name = "pictureMapa";
            pictureMapa.Size = new Size(880, 500);
            pictureMapa.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureMapa.TabIndex = 0;
            pictureMapa.TabStop = false;
            // 
            // btnCumbaya
            // 
            btnCumbaya.Location = new Point(95, 320);
            btnCumbaya.Name = "btnCumbaya";
            btnCumbaya.Size = new Size(90, 35);
            btnCumbaya.TabIndex = 1;
            btnCumbaya.Text = "Cumbayá";
            btnCumbaya.UseVisualStyleBackColor = true;
            // 
            // btnEsperanza
            // 
            btnEsperanza.Location = new Point(520, 155);
            btnEsperanza.Name = "btnEsperanza";
            btnEsperanza.Size = new Size(90, 35);
            btnEsperanza.TabIndex = 2;
            btnEsperanza.Text = "Esperanza";
            btnEsperanza.UseVisualStyleBackColor = true;
            // 
            // btnArrayanes
            // 
            btnArrayanes.Location = new Point(640, 70);
            btnArrayanes.Name = "btnArrayanes";
            btnArrayanes.Size = new Size(90, 35);
            btnArrayanes.TabIndex = 3;
            btnArrayanes.Text = "Arrayanes";
            btnArrayanes.UseVisualStyleBackColor = true;
            // 
            // btnLomita
            // 
            btnLomita.Location = new Point(790, 215);
            btnLomita.Name = "btnLomita";
            btnLomita.Size = new Size(90, 35);
            btnLomita.TabIndex = 4;
            btnLomita.Text = "Lomita";
            btnLomita.UseVisualStyleBackColor = true;
            // 
            // btnPuembo
            // 
            btnPuembo.Location = new Point(800, 120);
            btnPuembo.Name = "btnPuembo";
            btnPuembo.Size = new Size(90, 35);
            btnPuembo.TabIndex = 5;
            btnPuembo.Text = "Puembo";
            btnPuembo.UseVisualStyleBackColor = true;
            // 
            // btnRutaCumbayaEsperanza
            // 
            btnRutaCumbayaEsperanza.Location = new Point(35, 440);
            btnRutaCumbayaEsperanza.Name = "btnRutaCumbayaEsperanza";
            btnRutaCumbayaEsperanza.Size = new Size(160, 35);
            btnRutaCumbayaEsperanza.TabIndex = 6;
            btnRutaCumbayaEsperanza.Text = "Ruta Amarilla";
            btnRutaCumbayaEsperanza.UseVisualStyleBackColor = true;
            // 
            // btnRutaArrayanesPuembo
            // 
            btnRutaArrayanesPuembo.Location = new Point(205, 440);
            btnRutaArrayanesPuembo.Name = "btnRutaArrayanesPuembo";
            btnRutaArrayanesPuembo.Size = new Size(160, 35);
            btnRutaArrayanesPuembo.TabIndex = 7;
            btnRutaArrayanesPuembo.Text = "Ruta Azul";
            btnRutaArrayanesPuembo.UseVisualStyleBackColor = true;
            // 
            // panelInfo
            // 
            panelInfo.BackColor = Color.WhiteSmoke;
            panelInfo.Controls.Add(lblTiempo);
            panelInfo.Controls.Add(lblServicios);
            panelInfo.Controls.Add(lblDescripcion);
            panelInfo.Controls.Add(picturePortal);
            panelInfo.Controls.Add(lblTitulo);
            panelInfo.Dock = DockStyle.Right;
            panelInfo.Location = new Point(880, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(320, 500);
            panelInfo.TabIndex = 1;
            // 
            // lblTiempo
            // 
            lblTiempo.Dock = DockStyle.Top;
            lblTiempo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTiempo.Location = new Point(0, 390);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Padding = new Padding(10, 10, 10, 0);
            lblTiempo.Size = new Size(320, 40);
            lblTiempo.TabIndex = 0;
            lblTiempo.Text = "Recorrido: --";
            // 
            // lblServicios
            // 
            lblServicios.Dock = DockStyle.Top;
            lblServicios.Font = new Font("Segoe UI", 9F);
            lblServicios.Location = new Point(0, 300);
            lblServicios.Name = "lblServicios";
            lblServicios.Padding = new Padding(10, 10, 10, 0);
            lblServicios.Size = new Size(320, 90);
            lblServicios.TabIndex = 1;
            lblServicios.Text = "Servicios:\n- ...";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Dock = DockStyle.Top;
            lblDescripcion.Font = new Font("Segoe UI", 9F);
            lblDescripcion.Location = new Point(0, 210);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Padding = new Padding(10, 10, 10, 0);
            lblDescripcion.Size = new Size(320, 90);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Aquí saldrá la descripción del lugar.";
            // 
            // picturePortal
            // 
            picturePortal.BackColor = Color.LightGray;
            picturePortal.Dock = DockStyle.Top;
            picturePortal.Location = new Point(0, 50);
            picturePortal.Name = "picturePortal";
            picturePortal.Size = new Size(320, 160);
            picturePortal.SizeMode = PictureBoxSizeMode.Zoom;
            picturePortal.TabIndex = 3;
            picturePortal.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 50);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Selecciona un punto";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TurismoRutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelMapa);
            Controls.Add(panelInfo);
            Name = "TurismoRutas";
            Size = new Size(1200, 500);
            panelMapa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureMapa).EndInit();
            panelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picturePortal).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private Panel panelMapa;
        private PictureBox pictureMapa;

        private Panel panelInfo;
        private Label lblTitulo;
        private PictureBox picturePortal;
        private Label lblDescripcion;
        private Label lblServicios;
        private Label lblTiempo;

        private Button btnCumbaya;
        private Button btnEsperanza;
        private Button btnArrayanes;
        private Button btnLomita;
        private Button btnPuembo;
        private Button btnRutaCumbayaEsperanza;
        private Button btnRutaArrayanesPuembo;
    }
}
