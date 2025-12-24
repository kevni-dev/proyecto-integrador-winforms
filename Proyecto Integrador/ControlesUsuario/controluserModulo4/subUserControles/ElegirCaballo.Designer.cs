namespace Proyecto_Integrador.ControlesUsuario.cuModulo4
{
    partial class ElegirCaballo
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
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 352);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 352);
            panel3.Name = "panel3";
            panel3.Size = new Size(567, 100);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 42);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Elegir Caballo";
            // 
            // button1
            // 
            button1.Location = new Point(222, 31);
            button1.Name = "button1";
            button1.Size = new Size(108, 29);
            button1.TabIndex = 0;
            button1.Text = "Continuar";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(19, 20);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(523, 210);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Location = new Point(19, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(523, 59);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label3);
            panel5.Location = new Point(19, 85);
            panel5.Name = "panel5";
            panel5.Size = new Size(523, 63);
            panel5.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label4);
            panel6.Location = new Point(19, 154);
            panel6.Name = "panel6";
            panel6.Size = new Size(523, 76);
            panel6.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 27);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 0;
            label2.Text = "primer caballo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 24);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 0;
            label3.Text = "segundo caballo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 31);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 0;
            label4.Text = "tercer caballo";
            // 
            // ElegirCaballo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ElegirCaballo";
            Size = new Size(567, 452);
            Load += elegirCaballo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
        private Panel panel6;
        private Label label4;
        private Panel panel5;
        private Label label3;
        private Panel panel4;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
