namespace Proyecto_Integrador
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;

        private PictureBox logo_picture;
        private Label inicio_label;
        private Label desc_label;
        private TextBox usuario_textbox;
        private TextBox clave_textbox;
        private Button inicio_button;
        private LinkLabel registrar_link;
        private Label error_label;
        private Label pie_label;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            logo_picture = new PictureBox();
            inicio_label = new Label();
            desc_label = new Label();
            usuario_textbox = new TextBox();
            clave_textbox = new TextBox();
            inicio_button = new Button();
            registrar_link = new LinkLabel();
            error_label = new Label();
            pie_label = new Label();
            ((System.ComponentModel.ISupportInitialize)logo_picture).BeginInit();
            SuspendLayout();
            // 
            // logo_picture
            // 
            logo_picture.Image = Properties.Resources.caballito;
            logo_picture.Location = new Point(120, 30);
            logo_picture.Name = "logo_picture";
            logo_picture.Size = new Size(120, 120);
            logo_picture.SizeMode = PictureBoxSizeMode.Zoom;
            logo_picture.TabIndex = 0;
            logo_picture.TabStop = false;
            // 
            // inicio_label
            // 
            inicio_label.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            inicio_label.ForeColor = Color.Black;
            inicio_label.Location = new Point(30, 160);
            inicio_label.Name = "inicio_label";
            inicio_label.Size = new Size(300, 30);
            inicio_label.TabIndex = 1;
            inicio_label.Text = "Inicio de sesión";
            inicio_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // desc_label
            // 
            desc_label.Font = new Font("Segoe UI", 9F);
            desc_label.ForeColor = Color.DimGray;
            desc_label.Location = new Point(30, 195);
            desc_label.Name = "desc_label";
            desc_label.Size = new Size(300, 20);
            desc_label.TabIndex = 2;
            desc_label.Text = "Ingresa tu usuario y contraseña";
            desc_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // usuario_textbox
            // 
            usuario_textbox.Font = new Font("Segoe UI", 10F);
            usuario_textbox.Location = new Point(50, 240);
            usuario_textbox.Name = "usuario_textbox";
            usuario_textbox.PlaceholderText = "Usuario";
            usuario_textbox.Size = new Size(260, 25);
            usuario_textbox.TabIndex = 3;
            // 
            // clave_textbox
            // 
            clave_textbox.Font = new Font("Segoe UI", 10F);
            clave_textbox.Location = new Point(50, 290);
            clave_textbox.Name = "clave_textbox";
            clave_textbox.PlaceholderText = "Contraseña";
            clave_textbox.Size = new Size(260, 25);
            clave_textbox.TabIndex = 4;
            clave_textbox.UseSystemPasswordChar = true;
            // 
            // inicio_button
            // 
            inicio_button.BackColor = Color.RoyalBlue;
            inicio_button.FlatAppearance.BorderSize = 0;
            inicio_button.FlatStyle = FlatStyle.Flat;
            inicio_button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            inicio_button.ForeColor = Color.White;
            inicio_button.Location = new Point(50, 350);
            inicio_button.Name = "inicio_button";
            inicio_button.Size = new Size(260, 42);
            inicio_button.TabIndex = 5;
            inicio_button.Text = "Iniciar sesión";
            inicio_button.UseVisualStyleBackColor = false;
            inicio_button.Click += inicio_button_Click;
            // 
            // registrar_link
            // 
            registrar_link.Location = new Point(50, 398);
            registrar_link.Name = "registrar_link";
            registrar_link.Size = new Size(260, 20);
            registrar_link.TabIndex = 6;
            registrar_link.TabStop = true;
            registrar_link.Text = "Registrar nuevo usuario";
            registrar_link.TextAlign = ContentAlignment.MiddleCenter;
            registrar_link.LinkClicked += registrar_link_LinkClicked;
            // 
            // error_label
            // 
            error_label.Font = new Font("Segoe UI", 9F);
            error_label.ForeColor = Color.Firebrick;
            error_label.Location = new Point(30, 425);
            error_label.Name = "error_label";
            error_label.Size = new Size(300, 20);
            error_label.TabIndex = 7;
            error_label.Text = "Usuario o contraseña incorrectos";
            error_label.TextAlign = ContentAlignment.MiddleCenter;
            error_label.Visible = false;
            // 
            // pie_label
            // 
            pie_label.Font = new Font("Segoe UI", 9F);
            pie_label.ForeColor = Color.Gray;
            pie_label.Location = new Point(30, 470);
            pie_label.Name = "pie_label";
            pie_label.Size = new Size(300, 20);
            pie_label.TabIndex = 8;
            pie_label.Text = "Proyecto Integrador";
            pie_label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(360, 520);
            Controls.Add(logo_picture);
            Controls.Add(inicio_label);
            Controls.Add(desc_label);
            Controls.Add(usuario_textbox);
            Controls.Add(clave_textbox);
            Controls.Add(inicio_button);
            Controls.Add(registrar_link);
            Controls.Add(error_label);
            Controls.Add(pie_label);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)logo_picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
