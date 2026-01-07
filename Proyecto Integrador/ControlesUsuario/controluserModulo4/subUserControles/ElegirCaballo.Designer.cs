namespace Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles
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
            plRegistro = new Panel();
            gbSensibilidad = new GroupBox();
            trackBar1 = new TrackBar();
            label6 = new Label();
            textBox1 = new TextBox();
            lblEleccion2 = new Label();
            gbEstadoEmocional = new GroupBox();
            comboBox2 = new ComboBox();
            gbTemperamento = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            continuar = new Button();
            eleccionCaballo = new Panel();
            seleccionCaballo = new TableLayoutPanel();
            tituloEleccion = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            lblEleccion1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            lblEleccion3 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            lblEleccion4 = new Label();
            pictureBox4 = new PictureBox();
            tablaPrincipal = new TableLayoutPanel();
            registroEmocional = new TableLayoutPanel();
            titulo2 = new Label();
            continuar2 = new Button();
            plRegistro.SuspendLayout();
            gbSensibilidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            gbEstadoEmocional.SuspendLayout();
            gbTemperamento.SuspendLayout();
            eleccionCaballo.SuspendLayout();
            seleccionCaballo.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tablaPrincipal.SuspendLayout();
            registroEmocional.SuspendLayout();
            SuspendLayout();
            // 
            // plRegistro
            // 
            plRegistro.Controls.Add(gbSensibilidad);
            plRegistro.Controls.Add(gbEstadoEmocional);
            plRegistro.Controls.Add(gbTemperamento);
            plRegistro.Dock = DockStyle.Fill;
            plRegistro.Location = new Point(3, 73);
            plRegistro.Name = "plRegistro";
            plRegistro.Size = new Size(497, 373);
            plRegistro.TabIndex = 1;
            plRegistro.Paint += plRegistro_Paint;
            // 
            // gbSensibilidad
            // 
            gbSensibilidad.Controls.Add(trackBar1);
            gbSensibilidad.Controls.Add(label6);
            gbSensibilidad.Controls.Add(textBox1);
            gbSensibilidad.Location = new Point(15, 223);
            gbSensibilidad.Name = "gbSensibilidad";
            gbSensibilidad.Size = new Size(416, 115);
            gbSensibilidad.TabIndex = 2;
            gbSensibilidad.TabStop = false;
            gbSensibilidad.Text = "Sensibilidad";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(6, 47);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(121, 45);
            trackBar1.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 32);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 3;
            label6.Text = "Sensibilidad:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 23);
            textBox1.TabIndex = 1;
            // 
            // lblEleccion2
            // 
            lblEleccion2.AutoSize = true;
            lblEleccion2.Location = new Point(103, 15);
            lblEleccion2.Name = "lblEleccion2";
            lblEleccion2.Size = new Size(56, 15);
            lblEleccion2.TabIndex = 1;
            lblEleccion2.Text = "Caballo 2";
            // 
            // gbEstadoEmocional
            // 
            gbEstadoEmocional.Controls.Add(comboBox2);
            gbEstadoEmocional.Location = new Point(15, 15);
            gbEstadoEmocional.Name = "gbEstadoEmocional";
            gbEstadoEmocional.Size = new Size(271, 68);
            gbEstadoEmocional.TabIndex = 1;
            gbEstadoEmocional.TabStop = false;
            gbEstadoEmocional.Text = "Estado Emocional";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Calmado", "Estresado", "Ansioso", "Confiado" });
            comboBox2.Location = new Point(16, 22);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 4;
            // 
            // gbTemperamento
            // 
            gbTemperamento.Controls.Add(radioButton4);
            gbTemperamento.Controls.Add(radioButton3);
            gbTemperamento.Controls.Add(radioButton2);
            gbTemperamento.Controls.Add(radioButton1);
            gbTemperamento.Location = new Point(15, 106);
            gbTemperamento.Name = "gbTemperamento";
            gbTemperamento.Size = new Size(271, 91);
            gbTemperamento.TabIndex = 0;
            gbTemperamento.TabStop = false;
            gbTemperamento.Text = "Temperamento";
            gbTemperamento.Enter += gbTemperamento_Enter;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(144, 66);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(64, 19);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "Sumiso";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(16, 66);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(84, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Dominante";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(144, 22);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Nervioso";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(16, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Tranquilo";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // continuar
            // 
            continuar.Location = new Point(3, 458);
            continuar.Name = "continuar";
            continuar.Size = new Size(108, 29);
            continuar.TabIndex = 0;
            continuar.Text = "Siguiente";
            continuar.UseVisualStyleBackColor = true;
            continuar.Paint += panel3_Paint;
            // 
            // eleccionCaballo
            // 
            eleccionCaballo.Controls.Add(seleccionCaballo);
            eleccionCaballo.Dock = DockStyle.Fill;
            eleccionCaballo.Location = new Point(0, 0);
            eleccionCaballo.Margin = new Padding(0);
            eleccionCaballo.Name = "eleccionCaballo";
            eleccionCaballo.Size = new Size(508, 515);
            eleccionCaballo.TabIndex = 3;
            // 
            // seleccionCaballo
            // 
            seleccionCaballo.ColumnCount = 1;
            seleccionCaballo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            seleccionCaballo.Controls.Add(tituloEleccion, 0, 0);
            seleccionCaballo.Controls.Add(continuar, 0, 2);
            seleccionCaballo.Controls.Add(flowLayoutPanel1, 0, 1);
            seleccionCaballo.Dock = DockStyle.Fill;
            seleccionCaballo.Location = new Point(0, 0);
            seleccionCaballo.Name = "seleccionCaballo";
            seleccionCaballo.RowCount = 3;
            seleccionCaballo.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            seleccionCaballo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            seleccionCaballo.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            seleccionCaballo.Size = new Size(508, 515);
            seleccionCaballo.TabIndex = 1;
            // 
            // tituloEleccion
            // 
            tituloEleccion.AutoSize = true;
            tituloEleccion.Location = new Point(3, 0);
            tituloEleccion.Name = "tituloEleccion";
            tituloEleccion.Size = new Size(77, 15);
            tituloEleccion.TabIndex = 1;
            tituloEleccion.Text = "Elegir caballo";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 73);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(502, 379);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblEleccion1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            // 
            // lblEleccion1
            // 
            lblEleccion1.AutoSize = true;
            lblEleccion1.Location = new Point(94, 18);
            lblEleccion1.Name = "lblEleccion1";
            lblEleccion1.Size = new Size(56, 15);
            lblEleccion1.TabIndex = 1;
            lblEleccion1.Text = "Caballo 1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 71);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblEleccion2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(3, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 100);
            panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(17, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(68, 71);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblEleccion3);
            panel3.Controls.Add(pictureBox3);
            panel3.Location = new Point(3, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 2;
            // 
            // lblEleccion3
            // 
            lblEleccion3.AutoSize = true;
            lblEleccion3.Location = new Point(99, 16);
            lblEleccion3.Name = "lblEleccion3";
            lblEleccion3.Size = new Size(56, 15);
            lblEleccion3.TabIndex = 1;
            lblEleccion3.Text = "Caballo 3";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(8, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(66, 72);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblEleccion4);
            panel4.Controls.Add(pictureBox4);
            panel4.Location = new Point(209, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 3;
            // 
            // lblEleccion4
            // 
            lblEleccion4.AutoSize = true;
            lblEleccion4.Location = new Point(108, 21);
            lblEleccion4.Name = "lblEleccion4";
            lblEleccion4.Size = new Size(56, 15);
            lblEleccion4.TabIndex = 1;
            lblEleccion4.Text = "Caballo 4";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(17, 13);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(68, 72);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // tablaPrincipal
            // 
            tablaPrincipal.ColumnCount = 2;
            tablaPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaPrincipal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaPrincipal.Controls.Add(eleccionCaballo, 0, 0);
            tablaPrincipal.Controls.Add(registroEmocional, 1, 0);
            tablaPrincipal.Dock = DockStyle.Fill;
            tablaPrincipal.Location = new Point(0, 0);
            tablaPrincipal.Name = "tablaPrincipal";
            tablaPrincipal.RowCount = 1;
            tablaPrincipal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaPrincipal.Size = new Size(1017, 515);
            tablaPrincipal.TabIndex = 5;
            tablaPrincipal.Paint += tablaPrincipal_Paint;
            // 
            // registroEmocional
            // 
            registroEmocional.ColumnCount = 1;
            registroEmocional.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            registroEmocional.Controls.Add(titulo2, 0, 0);
            registroEmocional.Controls.Add(continuar2, 0, 2);
            registroEmocional.Controls.Add(plRegistro, 0, 1);
            registroEmocional.Dock = DockStyle.Fill;
            registroEmocional.Location = new Point(511, 3);
            registroEmocional.Name = "registroEmocional";
            registroEmocional.RowCount = 3;
            registroEmocional.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            registroEmocional.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            registroEmocional.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            registroEmocional.Size = new Size(503, 509);
            registroEmocional.TabIndex = 4;
            registroEmocional.Paint += registroEmocional_Paint;
            // 
            // titulo2
            // 
            titulo2.AutoSize = true;
            titulo2.Location = new Point(3, 0);
            titulo2.Name = "titulo2";
            titulo2.Size = new Size(109, 15);
            titulo2.TabIndex = 0;
            titulo2.Text = "Registro emocional";
            // 
            // continuar2
            // 
            continuar2.Location = new Point(3, 452);
            continuar2.Name = "continuar2";
            continuar2.Size = new Size(75, 23);
            continuar2.TabIndex = 1;
            continuar2.Text = "Continuar";
            continuar2.UseVisualStyleBackColor = true;
            // 
            // ElegirCaballo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tablaPrincipal);
            Name = "ElegirCaballo";
            Size = new Size(1017, 515);
            Load += elegirCaballo_Load;
            plRegistro.ResumeLayout(false);
            gbSensibilidad.ResumeLayout(false);
            gbSensibilidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            gbEstadoEmocional.ResumeLayout(false);
            gbTemperamento.ResumeLayout(false);
            gbTemperamento.PerformLayout();
            eleccionCaballo.ResumeLayout(false);
            seleccionCaballo.ResumeLayout(false);
            seleccionCaballo.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tablaPrincipal.ResumeLayout(false);
            registroEmocional.ResumeLayout(false);
            registroEmocional.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel plRegistro;
        private GroupBox gbSensibilidad;
        private Label label6;
        private Label lblEleccion2;
        private TextBox textBox1;
        private GroupBox gbEstadoEmocional;
        private GroupBox gbTemperamento;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button continuar;
        private Panel eleccionCaballo;
        private TableLayoutPanel tablaPrincipal;
        private TableLayoutPanel seleccionCaballo;
        private Label tituloEleccion;
        private TableLayoutPanel registroEmocional;
        private Label titulo2;
        private Button continuar2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Label lblEleccion1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label lblEleccion3;
        private PictureBox pictureBox3;
        private Panel panel4;
        private Label lblEleccion4;
        private PictureBox pictureBox4;
        private TrackBar trackBar1;
        private ComboBox comboBox2;
    }
}
