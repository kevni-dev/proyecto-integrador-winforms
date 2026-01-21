namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class saludcaballos
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
            label1 = new Label();
            btn_preven = new Button();
            btn_trata = new Button();
            btn_enfer = new Button();
            btn_minijuego = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            btn_registro = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(238, 119);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // btn_preven
            // 
            btn_preven.BackColor = Color.Salmon;
            btn_preven.FlatStyle = FlatStyle.Flat;
            btn_preven.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_preven.Location = new Point(57, 259);
            btn_preven.Name = "btn_preven";
            btn_preven.Size = new Size(209, 56);
            btn_preven.TabIndex = 3;
            btn_preven.Text = "Prevención";
            btn_preven.UseVisualStyleBackColor = false;
            btn_preven.Click += btn_preven_Click;
            // 
            // btn_trata
            // 
            btn_trata.BackColor = Color.DarkSalmon;
            btn_trata.FlatStyle = FlatStyle.Flat;
            btn_trata.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_trata.ForeColor = Color.Black;
            btn_trata.Location = new Point(57, 357);
            btn_trata.Name = "btn_trata";
            btn_trata.Size = new Size(209, 58);
            btn_trata.TabIndex = 2;
            btn_trata.Text = "Tratamientos";
            btn_trata.UseVisualStyleBackColor = false;
            btn_trata.Click += btn_trata_Click;
            // 
            // btn_enfer
            // 
            btn_enfer.BackColor = Color.LightSalmon;
            btn_enfer.FlatStyle = FlatStyle.Flat;
            btn_enfer.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_enfer.ForeColor = Color.Black;
            btn_enfer.Location = new Point(57, 164);
            btn_enfer.Name = "btn_enfer";
            btn_enfer.Size = new Size(209, 50);
            btn_enfer.TabIndex = 1;
            btn_enfer.Text = "Enfermedades";
            btn_enfer.UseVisualStyleBackColor = false;
            btn_enfer.Click += btn_enfer_Click;
            // 
            // btn_minijuego
            // 
            btn_minijuego.BackColor = Color.Salmon;
            btn_minijuego.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_minijuego.Location = new Point(57, 451);
            btn_minijuego.Name = "btn_minijuego";
            btn_minijuego.Size = new Size(209, 70);
            btn_minijuego.TabIndex = 4;
            btn_minijuego.Text = "Minijuego";
            btn_minijuego.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_enfer);
            panel1.Controls.Add(btn_trata);
            panel1.Controls.Add(btn_minijuego);
            panel1.Controls.Add(btn_preven);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 698);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(304, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(703, 698);
            panel2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(703, 539);
            dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_registro);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(703, 159);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 159);
            panel4.Name = "panel4";
            panel4.Size = new Size(703, 539);
            panel4.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 44);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 0;
            label2.Text = "Lista de caballos";
            // 
            // btn_registro
            // 
            btn_registro.Location = new Point(588, 25);
            btn_registro.Name = "btn_registro";
            btn_registro.Size = new Size(112, 58);
            btn_registro.TabIndex = 1;
            btn_registro.Text = "Registrar";
            btn_registro.UseVisualStyleBackColor = true;
            // 
            // saludcaballos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "saludcaballos";
            Size = new Size(1007, 698);
            Load += saludcaballos_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_enfer;
        private Button btn_preven;
        private Button btn_trata;
        private Button btn_minijuego;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Button btn_registro;
        private Label label2;
    }
}
