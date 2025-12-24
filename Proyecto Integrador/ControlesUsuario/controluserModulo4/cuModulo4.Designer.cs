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
            btnRegistroEmocional = new Button();
            btnInteraccion = new Button();
            btnRendimiento = new Button();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnBienestar = new Button();
            btnJuego = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 80);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 10);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 0;
            label1.Text = "BIENESTAR EQUINO-HUMANO";
            // 
            // btnElegirCaballo
            // 
            btnElegirCaballo.Location = new Point(3, 3);
            btnElegirCaballo.Name = "btnElegirCaballo";
            btnElegirCaballo.Size = new Size(150, 40);
            btnElegirCaballo.TabIndex = 1;
            btnElegirCaballo.Text = "Elegir caballo";
            btnElegirCaballo.UseVisualStyleBackColor = true;
            // 
            // btnRegistroEmocional
            // 
            btnRegistroEmocional.Location = new Point(159, 3);
            btnRegistroEmocional.Name = "btnRegistroEmocional";
            btnRegistroEmocional.Size = new Size(150, 40);
            btnRegistroEmocional.TabIndex = 2;
            btnRegistroEmocional.Text = "Registro emocional";
            btnRegistroEmocional.UseVisualStyleBackColor = true;
            // 
            // btnInteraccion
            // 
            btnInteraccion.Location = new Point(315, 3);
            btnInteraccion.Name = "btnInteraccion";
            btnInteraccion.Size = new Size(150, 40);
            btnInteraccion.TabIndex = 3;
            btnInteraccion.Text = "Interaccion equino-humano";
            btnInteraccion.UseVisualStyleBackColor = true;
            // 
            // btnRendimiento
            // 
            btnRendimiento.Location = new Point(471, 3);
            btnRendimiento.Name = "btnRendimiento";
            btnRendimiento.Size = new Size(150, 40);
            btnRendimiento.TabIndex = 4;
            btnRendimiento.Text = "Rendimiento";
            btnRendimiento.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 60);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(btnElegirCaballo);
            flowLayoutPanel1.Controls.Add(btnRegistroEmocional);
            flowLayoutPanel1.Controls.Add(btnInteraccion);
            flowLayoutPanel1.Controls.Add(btnRendimiento);
            flowLayoutPanel1.Controls.Add(btnBienestar);
            flowLayoutPanel1.Controls.Add(btnJuego);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(850, 60);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnBienestar
            // 
            btnBienestar.Location = new Point(627, 3);
            btnBienestar.Name = "btnBienestar";
            btnBienestar.Size = new Size(150, 40);
            btnBienestar.TabIndex = 2;
            btnBienestar.Text = "Bienestar general";
            btnBienestar.UseVisualStyleBackColor = true;
            // 
            // btnJuego
            // 
            btnJuego.Location = new Point(783, 3);
            btnJuego.Name = "btnJuego";
            btnJuego.Size = new Size(150, 40);
            btnJuego.TabIndex = 2;
            btnJuego.Text = "Juego";
            btnJuego.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(850, 383);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnElegirCaballo;
        private Button btnRegistroEmocional;
        private Button btnInteraccion;
        private Button btnRendimiento;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnBienestar;
        private Button btnJuego;
        private Panel panel3;
    }
}
