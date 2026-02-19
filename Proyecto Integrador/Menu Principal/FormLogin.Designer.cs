// FormLogin.Designer.cs
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel layout_center;
        private ShadowCardPanel card;

        internal TableLayoutPanel card_layout;

        internal Panel header_panel;
        internal PictureBox logo_picture;
        internal Label titulo_label;
        internal Label subtitulo_label;

        private RoundedPanel inputs_panel;
        private TableLayoutPanel inputs_layout;

        private Label usuario_label;
        private TextBox usuario_textbox;

        private Label clave_label;
        private TextBox clave_textbox;

        private Button inicio_button;
        private LinkLabel registrar_link;
        private Label error_label;
        private Label pie_label;

        internal Button closeBtn;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            layout_center = new TableLayoutPanel();
            card = new ShadowCardPanel();
            card_layout = new TableLayoutPanel();
            header_panel = new Panel();
            logo_picture = new PictureBox();
            titulo_label = new Label();
            subtitulo_label = new Label();
            spacer = new Panel();
            inputs_panel = new RoundedPanel();
            inputs_layout = new TableLayoutPanel();
            usuario_label = new Label();
            usuario_textbox = new TextBox();
            clave_label = new Label();
            clave_textbox = new TextBox();
            inicio_button = new Button();
            registrar_link = new LinkLabel();
            error_label = new Label();
            pie_label = new Label();
            closeBtn = new Button();
            layout_center.SuspendLayout();
            card.SuspendLayout();
            card_layout.SuspendLayout();
            header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo_picture).BeginInit();
            inputs_panel.SuspendLayout();
            inputs_layout.SuspendLayout();
            SuspendLayout();
            // 
            // layout_center
            // 
            layout_center.BackColor = Color.Transparent;
            layout_center.ColumnCount = 3;
            layout_center.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layout_center.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 620F));
            layout_center.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layout_center.Controls.Add(card, 1, 1);
            layout_center.Dock = DockStyle.Fill;
            layout_center.Location = new Point(0, 0);
            layout_center.Name = "layout_center";
            layout_center.RowCount = 3;
            layout_center.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout_center.RowStyles.Add(new RowStyle(SizeType.Absolute, 760F));
            layout_center.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layout_center.Size = new Size(980, 860);
            layout_center.TabIndex = 1;
            // 
            // card
            // 
            card.BackColor = Color.Transparent;
            card.Controls.Add(card_layout);
            card.Dock = DockStyle.Fill;
            card.Location = new Point(180, 50);
            card.Margin = new Padding(0);
            card.Name = "card";
            card.Size = new Size(620, 760);
            card.TabIndex = 0;
            // 
            // card_layout
            // 
            card_layout.BackColor = Color.Transparent;
            card_layout.ColumnCount = 1;
            card_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            card_layout.Controls.Add(header_panel, 0, 0);
            card_layout.Controls.Add(spacer, 0, 1);
            card_layout.Controls.Add(inputs_panel, 0, 2);
            card_layout.Controls.Add(inicio_button, 0, 3);
            card_layout.Controls.Add(registrar_link, 0, 4);
            card_layout.Controls.Add(error_label, 0, 5);
            card_layout.Controls.Add(pie_label, 0, 6);
            card_layout.Dock = DockStyle.Fill;
            card_layout.Location = new Point(0, 0);
            card_layout.Name = "card_layout";
            card_layout.Padding = new Padding(58, 52, 58, 60);
            card_layout.RowCount = 7;
            card_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
            card_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            card_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F));
            card_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            card_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            card_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F));
            card_layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            card_layout.Size = new Size(620, 760);
            card_layout.TabIndex = 0;
            // 
            // header_panel
            // 
            header_panel.BackColor = Color.Transparent;
            header_panel.Controls.Add(logo_picture);
            header_panel.Controls.Add(titulo_label);
            header_panel.Controls.Add(subtitulo_label);
            header_panel.Dock = DockStyle.Fill;
            header_panel.Location = new Point(61, 55);
            header_panel.Name = "header_panel";
            header_panel.Size = new Size(498, 184);
            header_panel.TabIndex = 0;
            // 
            // logo_picture
            // 
            logo_picture.BackColor = Color.Transparent;
            logo_picture.Location = new Point(0, 0);
            logo_picture.Name = "logo_picture";
            logo_picture.Size = new Size(86, 86);
            logo_picture.SizeMode = PictureBoxSizeMode.Zoom;
            logo_picture.TabIndex = 0;
            logo_picture.TabStop = false;
            // 
            // titulo_label
            // 
            titulo_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            titulo_label.BackColor = Color.Transparent;
            titulo_label.Font = new Font("Georgia", 21F);
            titulo_label.ForeColor = Color.FromArgb(110, 90, 74);
            titulo_label.Location = new Point(0, 92);
            titulo_label.Name = "titulo_label";
            titulo_label.Size = new Size(498, 50);
            titulo_label.TabIndex = 1;
            titulo_label.Text = "Manejo Integral de Caballos";
            titulo_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // subtitulo_label
            // 
            subtitulo_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            subtitulo_label.BackColor = Color.Transparent;
            subtitulo_label.Font = new Font("Segoe UI", 13.5F);
            subtitulo_label.ForeColor = Color.FromArgb(140, 125, 112);
            subtitulo_label.Location = new Point(0, 142);
            subtitulo_label.Name = "subtitulo_label";
            subtitulo_label.Size = new Size(498, 36);
            subtitulo_label.TabIndex = 2;
            subtitulo_label.Text = "Inicio de sesión";
            subtitulo_label.TextAlign = ContentAlignment.TopCenter;
            // 
            // spacer
            // 
            spacer.Location = new Point(61, 245);
            spacer.Name = "spacer";
            spacer.Size = new Size(200, 24);
            spacer.TabIndex = 1;
            // 
            // inputs_panel
            // 
            inputs_panel.BackColor = Color.Transparent;
            inputs_panel.Controls.Add(inputs_layout);
            inputs_panel.Dock = DockStyle.Fill;
            inputs_panel.Location = new Point(58, 272);
            inputs_panel.Margin = new Padding(0, 0, 0, 10);
            inputs_panel.Name = "inputs_panel";
            inputs_panel.Size = new Size(504, 210);
            inputs_panel.TabIndex = 2;
            // 
            // inputs_layout
            // 
            inputs_layout.BackColor = Color.Transparent;
            inputs_layout.ColumnCount = 1;
            inputs_layout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            inputs_layout.Controls.Add(usuario_label, 0, 0);
            inputs_layout.Controls.Add(usuario_textbox, 0, 1);
            inputs_layout.Controls.Add(clave_label, 0, 2);
            inputs_layout.Controls.Add(clave_textbox, 0, 3);
            inputs_layout.Dock = DockStyle.Fill;
            inputs_layout.Location = new Point(0, 0);
            inputs_layout.Name = "inputs_layout";
            inputs_layout.Padding = new Padding(30, 24, 30, 22);
            inputs_layout.RowCount = 4;
            inputs_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            inputs_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            inputs_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            inputs_layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            inputs_layout.Size = new Size(504, 210);
            inputs_layout.TabIndex = 0;
            // 
            // usuario_label
            // 
            usuario_label.BackColor = Color.Transparent;
            usuario_label.Dock = DockStyle.Fill;
            usuario_label.Font = new Font("Segoe UI", 12.5F);
            usuario_label.ForeColor = Color.FromArgb(120, 105, 95);
            usuario_label.Location = new Point(33, 24);
            usuario_label.Name = "usuario_label";
            usuario_label.Size = new Size(438, 26);
            usuario_label.TabIndex = 0;
            usuario_label.Text = "Usuario";
            usuario_label.TextAlign = ContentAlignment.BottomLeft;
            // 
            // usuario_textbox
            // 
            usuario_textbox.BorderStyle = BorderStyle.FixedSingle;
            usuario_textbox.Dock = DockStyle.Fill;
            usuario_textbox.Font = new Font("Segoe UI", 12.5F);
            usuario_textbox.Location = new Point(33, 53);
            usuario_textbox.Name = "usuario_textbox";
            usuario_textbox.Size = new Size(438, 30);
            usuario_textbox.TabIndex = 1;
            // 
            // clave_label
            // 
            clave_label.BackColor = Color.Transparent;
            clave_label.Dock = DockStyle.Fill;
            clave_label.Font = new Font("Segoe UI", 12.5F);
            clave_label.ForeColor = Color.FromArgb(120, 105, 95);
            clave_label.Location = new Point(33, 94);
            clave_label.Name = "clave_label";
            clave_label.Size = new Size(438, 26);
            clave_label.TabIndex = 2;
            clave_label.Text = "Contraseña";
            clave_label.TextAlign = ContentAlignment.BottomLeft;
            // 
            // clave_textbox
            // 
            clave_textbox.BorderStyle = BorderStyle.FixedSingle;
            clave_textbox.Dock = DockStyle.Fill;
            clave_textbox.Font = new Font("Segoe UI", 12.5F);
            clave_textbox.Location = new Point(33, 123);
            clave_textbox.Name = "clave_textbox";
            clave_textbox.Size = new Size(438, 30);
            clave_textbox.TabIndex = 3;
            clave_textbox.UseSystemPasswordChar = true;
            // 
            // inicio_button
            // 
            inicio_button.BackColor = Color.FromArgb(110, 104, 86);
            inicio_button.Cursor = Cursors.Hand;
            inicio_button.Dock = DockStyle.Fill;
            inicio_button.FlatAppearance.BorderSize = 0;
            inicio_button.FlatStyle = FlatStyle.Flat;
            inicio_button.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            inicio_button.ForeColor = Color.FromArgb(245, 240, 235);
            inicio_button.Location = new Point(58, 498);
            inicio_button.Margin = new Padding(0, 6, 0, 8);
            inicio_button.Name = "inicio_button";
            inicio_button.Size = new Size(504, 64);
            inicio_button.TabIndex = 3;
            inicio_button.Text = "Iniciar sesión";
            inicio_button.UseVisualStyleBackColor = false;
            inicio_button.Click += inicio_button_Click;
            // 
            // registrar_link
            // 
            registrar_link.ActiveLinkColor = Color.FromArgb(110, 90, 74);
            registrar_link.BackColor = Color.Transparent;
            registrar_link.Dock = DockStyle.Fill;
            registrar_link.Font = new Font("Segoe UI", 12.5F);
            registrar_link.LinkColor = Color.FromArgb(140, 125, 112);
            registrar_link.Location = new Point(61, 570);
            registrar_link.Name = "registrar_link";
            registrar_link.Size = new Size(498, 38);
            registrar_link.TabIndex = 4;
            registrar_link.TabStop = true;
            registrar_link.Text = "Registrar nuevo usuario";
            registrar_link.TextAlign = ContentAlignment.MiddleCenter;
            registrar_link.VisitedLinkColor = Color.FromArgb(140, 125, 112);
            registrar_link.LinkClicked += registrar_link_LinkClicked;
            // 
            // error_label
            // 
            error_label.BackColor = Color.Transparent;
            error_label.Dock = DockStyle.Fill;
            error_label.Font = new Font("Segoe UI", 10.5F);
            error_label.ForeColor = Color.Firebrick;
            error_label.Location = new Point(61, 608);
            error_label.Name = "error_label";
            error_label.Size = new Size(498, 28);
            error_label.TabIndex = 5;
            error_label.Text = "Usuario o contraseña incorrectos";
            error_label.TextAlign = ContentAlignment.MiddleCenter;
            error_label.Visible = false;
            // 
            // pie_label
            // 
            pie_label.BackColor = Color.Transparent;
            pie_label.Dock = DockStyle.Fill;
            pie_label.Font = new Font("Segoe UI", 12.5F);
            pie_label.ForeColor = Color.FromArgb(145, 130, 120);
            pie_label.Location = new Point(61, 636);
            pie_label.Name = "pie_label";
            pie_label.Size = new Size(498, 64);
            pie_label.TabIndex = 6;
            pie_label.Text = "Proyecto Integrador";
            pie_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.FromArgb(80, 255, 255, 255);
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            closeBtn.ForeColor = Color.FromArgb(70, 60, 52);
            closeBtn.Location = new Point(0, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(42, 42);
            closeBtn.TabIndex = 0;
            closeBtn.TabStop = false;
            closeBtn.Text = "✕";
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(980, 860);
            ControlBox = false;
            Controls.Add(closeBtn);
            Controls.Add(layout_center);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            layout_center.ResumeLayout(false);
            card.ResumeLayout(false);
            card_layout.ResumeLayout(false);
            header_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo_picture).EndInit();
            inputs_panel.ResumeLayout(false);
            inputs_layout.ResumeLayout(false);
            inputs_layout.PerformLayout();
            ResumeLayout(false);
        }

        private Panel spacer;
    }
}
