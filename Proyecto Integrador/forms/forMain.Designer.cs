namespace Proyecto_Integrador
{
    partial class forMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            plTitulo = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTituloPrincipal = new Label();
            btnIconoMenu = new Button();
            plModulos = new Panel();
            btnModulo4 = new Button();
            btnModulo3 = new Button();
            btnModulo2 = new Button();
            btnModulo1 = new Button();
            plContenido = new Panel();
            plTitulo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            plModulos.SuspendLayout();
            SuspendLayout();
            // 
            // plTitulo
            // 
            plTitulo.Controls.Add(tableLayoutPanel1);
            plTitulo.Dock = DockStyle.Top;
            plTitulo.Location = new Point(0, 0);
            plTitulo.Name = "plTitulo";
            plTitulo.Size = new Size(800, 60);
            plTitulo.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTituloPrincipal, 1, 0);
            tableLayoutPanel1.Controls.Add(btnIconoMenu, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 60);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.Anchor = AnchorStyles.None;
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.Location = new Point(213, 17);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(423, 25);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "MANEJO CLINICO Y CUIDADO DE CABALLOS";
            lblTituloPrincipal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnIconoMenu
            // 
            btnIconoMenu.Dock = DockStyle.Fill;
            btnIconoMenu.FlatStyle = FlatStyle.Flat;
            btnIconoMenu.Location = new Point(3, 3);
            btnIconoMenu.Name = "btnIconoMenu";
            btnIconoMenu.Size = new Size(44, 54);
            btnIconoMenu.TabIndex = 1;
            btnIconoMenu.Text = "☰";
            btnIconoMenu.UseVisualStyleBackColor = true;
            btnIconoMenu.Click += btnIconoMenu_Click;
            // 
            // plModulos
            // 
            plModulos.Controls.Add(btnModulo4);
            plModulos.Controls.Add(btnModulo3);
            plModulos.Controls.Add(btnModulo2);
            plModulos.Controls.Add(btnModulo1);
            plModulos.Dock = DockStyle.Left;
            plModulos.Location = new Point(0, 60);
            plModulos.Name = "plModulos";
            plModulos.Size = new Size(220, 390);
            plModulos.TabIndex = 1;
            // 
            // btnModulo4
            // 
            btnModulo4.Dock = DockStyle.Top;
            btnModulo4.FlatStyle = FlatStyle.Flat;
            btnModulo4.Location = new Point(0, 153);
            btnModulo4.Name = "btnModulo4";
            btnModulo4.Size = new Size(220, 49);
            btnModulo4.TabIndex = 0;
            btnModulo4.Text = "Gestion emocional equina";
            btnModulo4.UseVisualStyleBackColor = true;
            btnModulo4.Click += btnModulo4_Click;
            // 
            // btnModulo3
            // 
            btnModulo3.Dock = DockStyle.Top;
            btnModulo3.FlatStyle = FlatStyle.Flat;
            btnModulo3.Location = new Point(0, 100);
            btnModulo3.Name = "btnModulo3";
            btnModulo3.Size = new Size(220, 53);
            btnModulo3.TabIndex = 0;
            btnModulo3.Text = "Salud general";
            btnModulo3.UseVisualStyleBackColor = true;
            btnModulo3.Click += btnModulo3_Click;
            // 
            // btnModulo2
            // 
            btnModulo2.Dock = DockStyle.Top;
            btnModulo2.FlatStyle = FlatStyle.Flat;
            btnModulo2.Location = new Point(0, 48);
            btnModulo2.Name = "btnModulo2";
            btnModulo2.Size = new Size(220, 52);
            btnModulo2.TabIndex = 0;
            btnModulo2.Text = "Desarrollo y alimentación";
            btnModulo2.UseVisualStyleBackColor = true;
            btnModulo2.Click += btnModulo2_Click;
            // 
            // btnModulo1
            // 
            btnModulo1.Dock = DockStyle.Top;
            btnModulo1.FlatStyle = FlatStyle.Flat;
            btnModulo1.Location = new Point(0, 0);
            btnModulo1.Name = "btnModulo1";
            btnModulo1.Size = new Size(220, 48);
            btnModulo1.TabIndex = 1;
            btnModulo1.Text = "Gestión y Turismo";
            btnModulo1.UseVisualStyleBackColor = true;
            btnModulo1.Click += btnModulo1_Click;
            // 
            // plContenido
            // 
            plContenido.Dock = DockStyle.Fill;
            plContenido.Location = new Point(220, 60);
            plContenido.Name = "plContenido";
            plContenido.Size = new Size(580, 390);
            plContenido.TabIndex = 2;
            // 
            // forMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(plContenido);
            Controls.Add(plModulos);
            Controls.Add(plTitulo);
            Name = "forMain";
            Text = "Form1";
            Load += forMain_Load;
            plTitulo.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
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
    }
}
