using Microsoft.VisualBasic.Logging;
using Proyecto_Integrador.Archivo;
using Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles;
using System;
using System.ComponentModel.Design;
using System.Drawing;
using System.Numerics;

namespace Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles
    {
    partial class Interaccion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            tlpPrincipal = new TableLayoutPanel();
            pnlDatosLateral = new Panel();
            gbInfoCuriosa = new GroupBox();
            lblDatoCurioso = new Label();
            gbEstadisticas = new GroupBox();
            lblValEstres = new Label();
            pbEstresActual = new ProgressBar();
            lblTitEstres = new Label();
            lblValEnergia = new Label();
            pbEnergiaActual = new ProgressBar();
            lblTitEnergia = new Label();
            lblValVinculo = new Label();
            pbVinculo = new ProgressBar();
            lblTitVinculo = new Label();
            lblNombreCaballo = new Label();
            pbFotoPerfil = new PictureBox();
            pnlEscenario = new Panel();
            pbCaballoEscenario = new PictureBox();
            pnlControles = new Panel();
            btnContinuar = new Button();
            pbProgresoSesion = new ProgressBar();
            lblFeedback = new Label();
            flpAcciones = new FlowLayoutPanel();
            btnCepillar = new Button();
            btnAlimentar = new Button();
            btnAcariciar = new Button();
            btnJugar = new Button();
            tlpPrincipal.SuspendLayout();
            pnlDatosLateral.SuspendLayout();
            gbInfoCuriosa.SuspendLayout();
            gbEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoPerfil).BeginInit();
            pnlEscenario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCaballoEscenario).BeginInit();
            pnlControles.SuspendLayout();
            flpAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // tlpPrincipal
            // 
            tlpPrincipal.ColumnCount = 2;
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlpPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlpPrincipal.Controls.Add(pnlDatosLateral, 0, 0);
            tlpPrincipal.Controls.Add(pnlEscenario, 1, 0);
            tlpPrincipal.Dock = DockStyle.Fill;
            tlpPrincipal.Location = new Point(0, 0);
            tlpPrincipal.Margin = new Padding(4, 3, 4, 3);
            tlpPrincipal.Name = "tlpPrincipal";
            tlpPrincipal.RowCount = 1;
            tlpPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrincipal.Size = new Size(1148, 536);
            tlpPrincipal.TabIndex = 0;
            // 
            // pnlDatosLateral
            // 
            pnlDatosLateral.BackColor = Color.BurlyWood;
            pnlDatosLateral.BorderStyle = BorderStyle.FixedSingle;
            pnlDatosLateral.Controls.Add(gbInfoCuriosa);
            pnlDatosLateral.Controls.Add(gbEstadisticas);
            pnlDatosLateral.Controls.Add(lblNombreCaballo);
            pnlDatosLateral.Controls.Add(pbFotoPerfil);
            pnlDatosLateral.Dock = DockStyle.Fill;
            pnlDatosLateral.Location = new Point(4, 3);
            pnlDatosLateral.Margin = new Padding(4, 3, 4, 3);
            pnlDatosLateral.Name = "pnlDatosLateral";
            pnlDatosLateral.Padding = new Padding(12);
            pnlDatosLateral.Size = new Size(336, 530);
            pnlDatosLateral.TabIndex = 0;
            // 
            // gbInfoCuriosa
            // 
            gbInfoCuriosa.Controls.Add(lblDatoCurioso);
            gbInfoCuriosa.Dock = DockStyle.Bottom;
            gbInfoCuriosa.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            gbInfoCuriosa.Location = new Point(12, 405);
            gbInfoCuriosa.Margin = new Padding(4, 3, 4, 3);
            gbInfoCuriosa.Name = "gbInfoCuriosa";
            gbInfoCuriosa.Padding = new Padding(4, 3, 4, 3);
            gbInfoCuriosa.Size = new Size(310, 111);
            gbInfoCuriosa.TabIndex = 3;
            gbInfoCuriosa.TabStop = false;
            gbInfoCuriosa.Text = "¿Sabías que?";
            // 
            // lblDatoCurioso
            // 
            lblDatoCurioso.Dock = DockStyle.Fill;
            lblDatoCurioso.Font = new Font("Segoe UI", 9F);
            lblDatoCurioso.Location = new Point(4, 19);
            lblDatoCurioso.Margin = new Padding(4, 0, 4, 0);
            lblDatoCurioso.Name = "lblDatoCurioso";
            lblDatoCurioso.Size = new Size(302, 89);
            lblDatoCurioso.TabIndex = 0;
            lblDatoCurioso.Text = "Se comunican más con el lenguaje corporal que con sonidos.";
            lblDatoCurioso.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbEstadisticas
            // 
            gbEstadisticas.BackColor = Color.Transparent;
            gbEstadisticas.Controls.Add(lblValEstres);
            gbEstadisticas.Controls.Add(pbEstresActual);
            gbEstadisticas.Controls.Add(lblTitEstres);
            gbEstadisticas.Controls.Add(lblValEnergia);
            gbEstadisticas.Controls.Add(pbEnergiaActual);
            gbEstadisticas.Controls.Add(lblTitEnergia);
            gbEstadisticas.Controls.Add(lblValVinculo);
            gbEstadisticas.Controls.Add(pbVinculo);
            gbEstadisticas.Controls.Add(lblTitVinculo);
            gbEstadisticas.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            gbEstadisticas.Location = new Point(12, 186);
            gbEstadisticas.Margin = new Padding(4, 3, 4, 3);
            gbEstadisticas.Name = "gbEstadisticas";
            gbEstadisticas.Padding = new Padding(4, 3, 4, 3);
            gbEstadisticas.Size = new Size(310, 198);
            gbEstadisticas.TabIndex = 2;
            gbEstadisticas.TabStop = false;
            gbEstadisticas.Text = "Estado Actual";
            // 
            // lblValEstres
            // 
            lblValEstres.AutoSize = true;
            lblValEstres.Font = new Font("Segoe UI", 8F);
            lblValEstres.Location = new Point(257, 143);
            lblValEstres.Margin = new Padding(4, 0, 4, 0);
            lblValEstres.Name = "lblValEstres";
            lblValEstres.Size = new Size(22, 13);
            lblValEstres.TabIndex = 8;
            lblValEstres.Text = "0%";
            // 
            // pbEstresActual
            // 
            pbEstresActual.Location = new Point(18, 159);
            pbEstresActual.Margin = new Padding(4, 3, 4, 3);
            pbEstresActual.Name = "pbEstresActual";
            pbEstresActual.Size = new Size(274, 17);
            pbEstresActual.TabIndex = 7;
            // 
            // lblTitEstres
            // 
            lblTitEstres.AutoSize = true;
            lblTitEstres.Location = new Point(13, 137);
            lblTitEstres.Margin = new Padding(4, 0, 4, 0);
            lblTitEstres.Name = "lblTitEstres";
            lblTitEstres.Size = new Size(45, 19);
            lblTitEstres.TabIndex = 6;
            lblTitEstres.Text = "Estrés";
            // 
            // lblValEnergia
            // 
            lblValEnergia.AutoSize = true;
            lblValEnergia.Font = new Font("Segoe UI", 8F);
            lblValEnergia.Location = new Point(257, 83);
            lblValEnergia.Margin = new Padding(4, 0, 4, 0);
            lblValEnergia.Name = "lblValEnergia";
            lblValEnergia.Size = new Size(22, 13);
            lblValEnergia.TabIndex = 5;
            lblValEnergia.Text = "0%";
            // 
            // pbEnergiaActual
            // 
            pbEnergiaActual.Location = new Point(18, 99);
            pbEnergiaActual.Margin = new Padding(4, 3, 4, 3);
            pbEnergiaActual.Name = "pbEnergiaActual";
            pbEnergiaActual.Size = new Size(274, 17);
            pbEnergiaActual.TabIndex = 4;
            // 
            // lblTitEnergia
            // 
            lblTitEnergia.AutoSize = true;
            lblTitEnergia.Location = new Point(13, 77);
            lblTitEnergia.Margin = new Padding(4, 0, 4, 0);
            lblTitEnergia.Name = "lblTitEnergia";
            lblTitEnergia.Size = new Size(55, 19);
            lblTitEnergia.TabIndex = 3;
            lblTitEnergia.Text = "Energía";
            // 
            // lblValVinculo
            // 
            lblValVinculo.AutoSize = true;
            lblValVinculo.Font = new Font("Segoe UI", 8F);
            lblValVinculo.Location = new Point(257, 27);
            lblValVinculo.Margin = new Padding(4, 0, 4, 0);
            lblValVinculo.Name = "lblValVinculo";
            lblValVinculo.Size = new Size(22, 13);
            lblValVinculo.TabIndex = 2;
            lblValVinculo.Text = "0%";
            // 
            // pbVinculo
            // 
            pbVinculo.Location = new Point(18, 43);
            pbVinculo.Margin = new Padding(4, 3, 4, 3);
            pbVinculo.Name = "pbVinculo";
            pbVinculo.Size = new Size(274, 17);
            pbVinculo.TabIndex = 1;
            // 
            // lblTitVinculo
            // 
            lblTitVinculo.AutoSize = true;
            lblTitVinculo.Location = new Point(13, 21);
            lblTitVinculo.Margin = new Padding(4, 0, 4, 0);
            lblTitVinculo.Name = "lblTitVinculo";
            lblTitVinculo.Size = new Size(57, 19);
            lblTitVinculo.TabIndex = 0;
            lblTitVinculo.Text = "Vínculo";
            // 
            // lblNombreCaballo
            // 
            lblNombreCaballo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNombreCaballo.Location = new Point(15, 146);
            lblNombreCaballo.Margin = new Padding(4, 0, 4, 0);
            lblNombreCaballo.Name = "lblNombreCaballo";
            lblNombreCaballo.Size = new Size(310, 37);
            lblNombreCaballo.TabIndex = 1;
            lblNombreCaballo.Text = "Nombre Caballo";
            lblNombreCaballo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbFotoPerfil
            // 
            pbFotoPerfil.BackColor = Color.White;
            pbFotoPerfil.BackgroundImageLayout = ImageLayout.Stretch;
            pbFotoPerfil.BorderStyle = BorderStyle.FixedSingle;
            pbFotoPerfil.Location = new Point(94, 15);
            pbFotoPerfil.Margin = new Padding(4, 3, 4, 3);
            pbFotoPerfil.Name = "pbFotoPerfil";
            pbFotoPerfil.Size = new Size(150, 128);
            pbFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbFotoPerfil.TabIndex = 0;
            pbFotoPerfil.TabStop = false;
            // 
            // pnlEscenario
            // 
            pnlEscenario.BackgroundImage = Properties.Resources.qwer7;
            pnlEscenario.BackgroundImageLayout = ImageLayout.Stretch;
            pnlEscenario.Controls.Add(pbCaballoEscenario);
            pnlEscenario.Controls.Add(pnlControles);
            pnlEscenario.Dock = DockStyle.Fill;
            pnlEscenario.Location = new Point(348, 3);
            pnlEscenario.Margin = new Padding(4, 3, 4, 3);
            pnlEscenario.Name = "pnlEscenario";
            pnlEscenario.Size = new Size(796, 530);
            pnlEscenario.TabIndex = 1;
            // 
            // pbCaballoEscenario
            // 
            pbCaballoEscenario.Anchor = AnchorStyles.None;
            pbCaballoEscenario.BackColor = Color.Transparent;
            pbCaballoEscenario.BackgroundImage = Properties.Resources.qwer8;
            pbCaballoEscenario.BackgroundImageLayout = ImageLayout.Zoom;
            pbCaballoEscenario.Location = new Point(62, 58);
            pbCaballoEscenario.Margin = new Padding(4, 3, 4, 3);
            pbCaballoEscenario.Name = "pbCaballoEscenario";
            pbCaballoEscenario.Size = new Size(640, 291);
            pbCaballoEscenario.SizeMode = PictureBoxSizeMode.Zoom;
            pbCaballoEscenario.TabIndex = 1;
            pbCaballoEscenario.TabStop = false;
            // 
            // pnlControles
            // 
            pnlControles.BackColor = Color.SaddleBrown;
            pnlControles.Controls.Add(btnContinuar);
            pnlControles.Controls.Add(pbProgresoSesion);
            pnlControles.Controls.Add(lblFeedback);
            pnlControles.Controls.Add(flpAcciones);
            pnlControles.Dock = DockStyle.Bottom;
            pnlControles.Location = new Point(0, 355);
            pnlControles.Margin = new Padding(4, 3, 4, 3);
            pnlControles.Name = "pnlControles";
            pnlControles.Size = new Size(796, 175);
            pnlControles.TabIndex = 0;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.Transparent;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Location = new Point(664, 41);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(75, 23);
            btnContinuar.TabIndex = 3;
            btnContinuar.UseVisualStyleBackColor = false;
            // 
            // pbProgresoSesion
            // 
            pbProgresoSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pbProgresoSesion.Location = new Point(27, 145);
            pbProgresoSesion.Margin = new Padding(4, 3, 4, 3);
            pbProgresoSesion.Name = "pbProgresoSesion";
            pbProgresoSesion.Size = new Size(742, 17);
            pbProgresoSesion.TabIndex = 2;
            // 
            // lblFeedback
            // 
            lblFeedback.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblFeedback.BackColor = Color.PaleGreen;
            lblFeedback.BorderStyle = BorderStyle.FixedSingle;
            lblFeedback.Font = new Font("Segoe UI", 11F);
            lblFeedback.ForeColor = Color.DarkGreen;
            lblFeedback.Location = new Point(27, 98);
            lblFeedback.Margin = new Padding(4, 0, 4, 0);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Padding = new Padding(6);
            lblFeedback.Size = new Size(742, 40);
            lblFeedback.TabIndex = 1;
            lblFeedback.Text = "Selecciona una herramienta para interactuar con el caballo.";
            lblFeedback.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpAcciones
            // 
            flpAcciones.Anchor = AnchorStyles.Top;
            flpAcciones.AutoSize = true;
            flpAcciones.BackColor = Color.Transparent;
            flpAcciones.Controls.Add(btnCepillar);
            flpAcciones.Controls.Add(btnAlimentar);
            flpAcciones.Controls.Add(btnAcariciar);
            flpAcciones.Controls.Add(btnJugar);
            flpAcciones.Location = new Point(162, 12);
            flpAcciones.Margin = new Padding(4, 3, 4, 3);
            flpAcciones.Name = "flpAcciones";
            flpAcciones.Size = new Size(481, 81);
            flpAcciones.TabIndex = 0;
            // 
            // btnCepillar
            // 
            btnCepillar.BackColor = Color.Wheat;
            btnCepillar.BackgroundImage = Properties.Resources.qwer3;
            btnCepillar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCepillar.Cursor = Cursors.Hand;
            btnCepillar.FlatStyle = FlatStyle.Flat;
            btnCepillar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnCepillar.Location = new Point(4, 3);
            btnCepillar.Margin = new Padding(4, 3, 4, 3);
            btnCepillar.Name = "btnCepillar";
            btnCepillar.Size = new Size(111, 69);
            btnCepillar.TabIndex = 0;
            btnCepillar.Text = "Cepillar";
            btnCepillar.TextAlign = ContentAlignment.BottomCenter;
            btnCepillar.UseVisualStyleBackColor = false;
            // 
            // btnAlimentar
            // 
            btnAlimentar.BackColor = Color.Wheat;
            btnAlimentar.BackgroundImage = Properties.Resources.qwer2;
            btnAlimentar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAlimentar.Cursor = Cursors.Hand;
            btnAlimentar.FlatStyle = FlatStyle.Flat;
            btnAlimentar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAlimentar.Location = new Point(123, 3);
            btnAlimentar.Margin = new Padding(4, 3, 4, 3);
            btnAlimentar.Name = "btnAlimentar";
            btnAlimentar.Size = new Size(111, 69);
            btnAlimentar.TabIndex = 1;
            btnAlimentar.Text = "Manzana";
            btnAlimentar.TextAlign = ContentAlignment.BottomCenter;
            btnAlimentar.UseVisualStyleBackColor = false;
            // 
            // btnAcariciar
            // 
            btnAcariciar.BackColor = Color.Wheat;
            btnAcariciar.BackgroundImage = Properties.Resources.qwer4;
            btnAcariciar.BackgroundImageLayout = ImageLayout.Zoom;
            btnAcariciar.Cursor = Cursors.Hand;
            btnAcariciar.FlatStyle = FlatStyle.Flat;
            btnAcariciar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnAcariciar.Location = new Point(242, 3);
            btnAcariciar.Margin = new Padding(4, 3, 4, 3);
            btnAcariciar.Name = "btnAcariciar";
            btnAcariciar.Size = new Size(111, 69);
            btnAcariciar.TabIndex = 2;
            btnAcariciar.Text = "Acariciar";
            btnAcariciar.TextAlign = ContentAlignment.BottomCenter;
            btnAcariciar.UseVisualStyleBackColor = false;
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.Wheat;
            btnJugar.BackgroundImage = Properties.Resources.qwer6;
            btnJugar.BackgroundImageLayout = ImageLayout.Zoom;
            btnJugar.Cursor = Cursors.Hand;
            btnJugar.FlatStyle = FlatStyle.Flat;
            btnJugar.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnJugar.Location = new Point(361, 3);
            btnJugar.Margin = new Padding(4, 3, 4, 3);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(111, 69);
            btnJugar.TabIndex = 3;
            btnJugar.Text = "Juguete";
            btnJugar.TextAlign = ContentAlignment.BottomCenter;
            btnJugar.UseVisualStyleBackColor = false;
            // 
            // Interaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpPrincipal);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Interaccion";
            Size = new Size(1148, 536);
            tlpPrincipal.ResumeLayout(false);
            pnlDatosLateral.ResumeLayout(false);
            gbInfoCuriosa.ResumeLayout(false);
            gbEstadisticas.ResumeLayout(false);
            gbEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotoPerfil).EndInit();
            pnlEscenario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCaballoEscenario).EndInit();
            pnlControles.ResumeLayout(false);
            pnlControles.PerformLayout();
            flpAcciones.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.Panel pnlDatosLateral;
        private System.Windows.Forms.PictureBox pbFotoPerfil;
        private System.Windows.Forms.Label lblNombreCaballo;
        private System.Windows.Forms.GroupBox gbEstadisticas;
        private System.Windows.Forms.Label lblTitVinculo;
        private System.Windows.Forms.Label lblValVinculo;
        private System.Windows.Forms.ProgressBar pbVinculo;
        private System.Windows.Forms.Label lblValEnergia;
        private System.Windows.Forms.ProgressBar pbEnergiaActual;
        private System.Windows.Forms.Label lblTitEnergia;
        private System.Windows.Forms.GroupBox gbInfoCuriosa;
        private System.Windows.Forms.Label lblDatoCurioso;
        private System.Windows.Forms.Panel pnlEscenario;
        private System.Windows.Forms.Panel pnlControles;
        private System.Windows.Forms.FlowLayoutPanel flpAcciones;
        private System.Windows.Forms.Button btnCepillar;
        private System.Windows.Forms.Button btnAlimentar;
        private System.Windows.Forms.Button btnAcariciar;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.ProgressBar pbProgresoSesion;
        private System.Windows.Forms.PictureBox pbCaballoEscenario;
        private System.Windows.Forms.Label lblValEstres;
        private System.Windows.Forms.ProgressBar pbEstresActual;
        private System.Windows.Forms.Label lblTitEstres;
        private Button btnContinuar;
    }
}
