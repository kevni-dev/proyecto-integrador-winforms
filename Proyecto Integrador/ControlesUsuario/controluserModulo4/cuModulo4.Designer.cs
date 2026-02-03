namespace Proyecto_Integrador.ControlesUsuario.cuModulo4
{
    partial class cuModulo4
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
            panel1 = new Panel();
            label1 = new Label();
            btnElegirCaballo = new Button();
            btnInteraccion = new Button();
            btnRendimiento = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnJuego = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.qwer1;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 43);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 224, 192);
            label1.Location = new Point(469, 20);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 0;
            label1.Text = "BIENESTAR EQUINO-HUMANO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnElegirCaballo
            // 
            btnElegirCaballo.BackColor = Color.Transparent;
            btnElegirCaballo.Dock = DockStyle.Fill;
            btnElegirCaballo.FlatStyle = FlatStyle.Flat;
            btnElegirCaballo.ForeColor = Color.FromArgb(255, 224, 192);
            btnElegirCaballo.Location = new Point(3, 3);
            btnElegirCaballo.Name = "btnElegirCaballo";
            btnElegirCaballo.Size = new Size(206, 45);
            btnElegirCaballo.TabIndex = 1;
            btnElegirCaballo.Text = "Eleccion y perfil";
            btnElegirCaballo.UseVisualStyleBackColor = false;
            btnElegirCaballo.Click += btnElegirCaballo_Click_1;
            // 
            // btnInteraccion
            // 
            btnInteraccion.BackColor = Color.Transparent;
            btnInteraccion.Dock = DockStyle.Fill;
            btnInteraccion.FlatStyle = FlatStyle.Flat;
            btnInteraccion.ForeColor = Color.FromArgb(255, 224, 192);
            btnInteraccion.Location = new Point(215, 3);
            btnInteraccion.Name = "btnInteraccion";
            btnInteraccion.Size = new Size(206, 45);
            btnInteraccion.TabIndex = 3;
            btnInteraccion.Text = "Interaccion equino-humano";
            btnInteraccion.UseVisualStyleBackColor = false;
            btnInteraccion.Click += btnInteraccion_Click;
            // 
            // btnRendimiento
            // 
            btnRendimiento.BackColor = Color.Transparent;
            btnRendimiento.Dock = DockStyle.Fill;
            btnRendimiento.FlatStyle = FlatStyle.Flat;
            btnRendimiento.ForeColor = Color.FromArgb(255, 224, 192);
            btnRendimiento.Location = new Point(427, 3);
            btnRendimiento.Name = "btnRendimiento";
            btnRendimiento.Size = new Size(206, 45);
            btnRendimiento.TabIndex = 4;
            btnRendimiento.Text = "Rendimiento";
            btnRendimiento.UseVisualStyleBackColor = false;
            btnRendimiento.Click += btnRendimiento_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 51);
            panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImage = Properties.Resources.qwer1;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(btnInteraccion, 1, 0);
            tableLayoutPanel1.Controls.Add(btnJuego, 3, 0);
            tableLayoutPanel1.Controls.Add(btnRendimiento, 2, 0);
            tableLayoutPanel1.Controls.Add(btnElegirCaballo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(850, 51);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnJuego
            // 
            btnJuego.BackColor = Color.Transparent;
            btnJuego.Dock = DockStyle.Fill;
            btnJuego.FlatStyle = FlatStyle.Flat;
            btnJuego.ForeColor = Color.FromArgb(255, 224, 192);
            btnJuego.Location = new Point(639, 3);
            btnJuego.Name = "btnJuego";
            btnJuego.Size = new Size(208, 45);
            btnJuego.TabIndex = 2;
            btnJuego.Text = "Juego";
            btnJuego.UseVisualStyleBackColor = false;
            btnJuego.Click += btnJuego_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 429);
            panel3.TabIndex = 2;
            // 
            // cuModulo4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "cuModulo4";
            Size = new Size(850, 523);
            Load += cuModulo4_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnElegirCaballo;
        private Button btnInteraccion;
        private Button btnRendimiento;
        private Panel panel2;
        private Label label1;
        private Button btnJuego;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
