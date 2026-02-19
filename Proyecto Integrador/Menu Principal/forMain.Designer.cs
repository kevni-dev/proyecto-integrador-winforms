// forMain.Designer.cs (REEMPLAZA este archivo COMPLETO)
// - Arreglo visual: usuario_picture + usuario_label más a la izquierda
// - usuario_label más pequeño (no invade al botón)
// - cerrarSesion_button con tamaño compacto + Anchor Right (posición final la ajusta forMain.cs)

namespace Proyecto_Integrador
{
    partial class forMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            plTitulo = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnIconoMenu = new Button();
            lblTituloPrincipal = new Label();
            userPanel = new Panel();
            usuario_picture = new PictureBox();
            usuario_label = new Label();
            cerrarSesion_button = new Button();
            plModulos = new Panel();
            btnModulo4 = new Button();
            btnModulo3 = new Button();
            btnModulo2 = new Button();
            btnModulo1 = new Button();
            plContenido = new Panel();
            plTitulo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)usuario_picture).BeginInit();
            plModulos.SuspendLayout();
            SuspendLayout();
            // 
            // plTitulo
            // 
            plTitulo.BackColor = Color.White;
            plTitulo.BackgroundImage = Properties.Resources.Recurso_222;
            plTitulo.BackgroundImageLayout = ImageLayout.Stretch;
            plTitulo.Controls.Add(tableLayoutPanel1);
            plTitulo.Dock = DockStyle.Top;
            plTitulo.Location = new Point(0, 0);
            plTitulo.Name = "plTitulo";
            plTitulo.Padding = new Padding(8);
            plTitulo.Size = new Size(1350, 70);
            plTitulo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 320F));
            tableLayoutPanel1.Controls.Add(btnIconoMenu, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTituloPrincipal, 1, 0);
            tableLayoutPanel1.Controls.Add(userPanel, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(8, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1334, 54);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnIconoMenu
            // 
            btnIconoMenu.BackColor = Color.Transparent;
            btnIconoMenu.BackgroundImageLayout = ImageLayout.Stretch;
            btnIconoMenu.Dock = DockStyle.Fill;
            btnIconoMenu.FlatAppearance.BorderSize = 0;
            btnIconoMenu.FlatStyle = FlatStyle.Flat;
            btnIconoMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnIconoMenu.Location = new Point(3, 3);
            btnIconoMenu.Name = "btnIconoMenu";
            btnIconoMenu.Size = new Size(54, 48);
            btnIconoMenu.TabIndex = 0;
            btnIconoMenu.Text = "☰";
            btnIconoMenu.UseVisualStyleBackColor = false;
            btnIconoMenu.Click += btnIconoMenu_Click;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.Dock = DockStyle.Fill;
            lblTituloPrincipal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloPrincipal.ForeColor = Color.FromArgb(30, 30, 30);
            lblTituloPrincipal.Location = new Point(63, 0);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(948, 54);
            lblTituloPrincipal.TabIndex = 1;
            lblTituloPrincipal.Text = "MANEJO INTEGRAL DE CABALLOS";
            lblTituloPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.White;
            userPanel.Controls.Add(usuario_picture);
            userPanel.Controls.Add(usuario_label);
            userPanel.Controls.Add(cerrarSesion_button);
            userPanel.Dock = DockStyle.Fill;
            userPanel.Location = new Point(1017, 3);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(314, 48);
            userPanel.TabIndex = 2;
            // 
            // usuario_picture
            // 
            usuario_picture.BackColor = Color.FromArgb(240, 242, 245);
            usuario_picture.Image = Properties.Resources.potro;
            usuario_picture.Location = new Point(6, 6);
            usuario_picture.Name = "usuario_picture";
            usuario_picture.Size = new Size(36, 36);
            usuario_picture.SizeMode = PictureBoxSizeMode.Zoom;
            usuario_picture.TabIndex = 0;
            usuario_picture.TabStop = false;
            // 
            // usuario_label
            // 
            usuario_label.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            usuario_label.ForeColor = Color.FromArgb(60, 60, 60);
            usuario_label.Location = new Point(46, 5);
            usuario_label.Name = "usuario_label";
            usuario_label.Size = new Size(120, 42);
            usuario_label.TabIndex = 1;
            usuario_label.Text = "Usuario";
            usuario_label.TextAlign = ContentAlignment.MiddleLeft;
            usuario_label.AutoEllipsis = true;
            // 
            // cerrarSesion_button
            // 
            cerrarSesion_button.BackColor = Color.Transparent;
            cerrarSesion_button.BackgroundImageLayout = ImageLayout.Stretch;
            cerrarSesion_button.FlatAppearance.BorderSize = 0;
            cerrarSesion_button.FlatStyle = FlatStyle.Flat;
            cerrarSesion_button.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cerrarSesion_button.ForeColor = Color.White;
            cerrarSesion_button.Location = new Point(0, 7);
            cerrarSesion_button.Name = "cerrarSesion_button";
            cerrarSesion_button.Size = new Size(130, 34);
            cerrarSesion_button.TabIndex = 2;
            cerrarSesion_button.Text = "Cerrar sesión";
            cerrarSesion_button.UseVisualStyleBackColor = false;
            cerrarSesion_button.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cerrarSesion_button.Click += cerrarSesion_button_Click;
            // 
            // plModulos
            // 
            plModulos.BackColor = Color.FromArgb(17, 24, 39);
            plModulos.BackgroundImage = Properties.Resources.Recurso_1;
            plModulos.BackgroundImageLayout = ImageLayout.Stretch;
            plModulos.Controls.Add(btnModulo4);
            plModulos.Controls.Add(btnModulo3);
            plModulos.Controls.Add(btnModulo2);
            plModulos.Controls.Add(btnModulo1);
            plModulos.Dock = DockStyle.Left;
            plModulos.Location = new Point(0, 70);
            plModulos.Name = "plModulos";
            plModulos.Size = new Size(220, 659);
            plModulos.TabIndex = 1;
            plModulos.Paint += plModulos_Paint;
            // 
            // btnModulo4
            // 
            btnModulo4.BackColor = Color.FromArgb(17, 24, 39);
            btnModulo4.Dock = DockStyle.Top;
            btnModulo4.FlatAppearance.BorderSize = 0;
            btnModulo4.FlatStyle = FlatStyle.Flat;
            btnModulo4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModulo4.ForeColor = Color.White;
            btnModulo4.ImageAlign = ContentAlignment.MiddleLeft;
            btnModulo4.Location = new Point(0, 156);
            btnModulo4.Name = "btnModulo4";
            btnModulo4.Padding = new Padding(14, 0, 0, 0);
            btnModulo4.Size = new Size(220, 52);
            btnModulo4.TabIndex = 3;
            btnModulo4.Text = "Gestión emocional equina";
            btnModulo4.TextAlign = ContentAlignment.MiddleLeft;
            btnModulo4.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModulo4.UseVisualStyleBackColor = false;
            btnModulo4.Click += btnModulo4_Click;
            // 
            // btnModulo3
            // 
            btnModulo3.BackColor = Color.FromArgb(17, 24, 39);
            btnModulo3.Dock = DockStyle.Top;
            btnModulo3.FlatAppearance.BorderSize = 0;
            btnModulo3.FlatStyle = FlatStyle.Flat;
            btnModulo3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModulo3.ForeColor = Color.White;
            btnModulo3.ImageAlign = ContentAlignment.MiddleLeft;
            btnModulo3.Location = new Point(0, 104);
            btnModulo3.Name = "btnModulo3";
            btnModulo3.Padding = new Padding(14, 0, 0, 0);
            btnModulo3.Size = new Size(220, 52);
            btnModulo3.TabIndex = 2;
            btnModulo3.Text = "Salud general";
            btnModulo3.TextAlign = ContentAlignment.MiddleLeft;
            btnModulo3.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModulo3.UseVisualStyleBackColor = false;
            btnModulo3.Click += btnModulo3_Click;
            // 
            // btnModulo2
            // 
            btnModulo2.BackColor = Color.FromArgb(17, 24, 39);
            btnModulo2.Dock = DockStyle.Top;
            btnModulo2.FlatAppearance.BorderSize = 0;
            btnModulo2.FlatStyle = FlatStyle.Flat;
            btnModulo2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModulo2.ForeColor = Color.White;
            btnModulo2.ImageAlign = ContentAlignment.MiddleLeft;
            btnModulo2.Location = new Point(0, 52);
            btnModulo2.Name = "btnModulo2";
            btnModulo2.Padding = new Padding(14, 0, 0, 0);
            btnModulo2.Size = new Size(220, 52);
            btnModulo2.TabIndex = 1;
            btnModulo2.Text = "Desarrollo y alimentación";
            btnModulo2.TextAlign = ContentAlignment.MiddleLeft;
            btnModulo2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModulo2.UseVisualStyleBackColor = false;
            btnModulo2.Click += btnModulo2_Click;
            // 
            // btnModulo1
            // 
            btnModulo1.BackColor = Color.FromArgb(17, 24, 39);
            btnModulo1.Dock = DockStyle.Top;
            btnModulo1.FlatAppearance.BorderSize = 0;
            btnModulo1.FlatStyle = FlatStyle.Flat;
            btnModulo1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModulo1.ForeColor = Color.White;
            btnModulo1.ImageAlign = ContentAlignment.MiddleLeft;
            btnModulo1.Location = new Point(0, 0);
            btnModulo1.Name = "btnModulo1";
            btnModulo1.Padding = new Padding(14, 0, 0, 0);
            btnModulo1.Size = new Size(220, 52);
            btnModulo1.TabIndex = 0;
            btnModulo1.Text = "Gestión y Turismo";
            btnModulo1.TextAlign = ContentAlignment.MiddleLeft;
            btnModulo1.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnModulo1.UseVisualStyleBackColor = false;
            btnModulo1.Click += btnModulo1_Click;
            // 
            // plContenido
            // 
            plContenido.BackColor = Color.FromArgb(245, 246, 250);
            plContenido.Dock = DockStyle.Fill;
            plContenido.Location = new Point(220, 70);
            plContenido.Name = "plContenido";
            plContenido.Size = new Size(1130, 659);
            plContenido.TabIndex = 2;
            // 
            // forMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(1350, 729);
            Controls.Add(plContenido);
            Controls.Add(plModulos);
            Controls.Add(plTitulo);
            Name = "forMain";
            Text = "Manejo Integral de Caballos";
            Load += forMain_Load;
            plTitulo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)usuario_picture).EndInit();
            plModulos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel plTitulo;
        private Panel plModulos;
        private Panel plContenido;

        private Button btnIconoMenu;
        private Button btnModulo4;
        private Button btnModulo3;
        private Button btnModulo1;
        private Button btnModulo2;

        private Label lblTituloPrincipal;
        private TableLayoutPanel tableLayoutPanel1;

        private Panel userPanel;
        private PictureBox usuario_picture;
        private Label usuario_label;
        private Button cerrarSesion_button;
    }
}
