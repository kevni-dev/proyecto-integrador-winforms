namespace Proyecto_Integrador.ControlesUsuario
{
    partial class TurismoRegistrarCaballo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            pictureBox1 = new PictureBox();
            comboBoxTemperamento = new ComboBox();
            comboBoxSexo = new ComboBox();
            comboBoxRaza = new ComboBox();
            textBoxEdad = new TextBox();
            textBoxNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(comboBoxTemperamento);
            panel1.Controls.Add(comboBoxSexo);
            panel1.Controls.Add(comboBoxRaza);
            panel1.Controls.Add(textBoxEdad);
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 500);
            panel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Location = new Point(460, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Gold;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Location = new Point(600, 400);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Aceptar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.caballito;
            pictureBox1.Location = new Point(500, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // comboBoxTemperamento
            // 
            comboBoxTemperamento.FormattingEnabled = true;
            comboBoxTemperamento.Location = new Point(200, 330);
            comboBoxTemperamento.Name = "comboBoxTemperamento";
            comboBoxTemperamento.Size = new Size(150, 23);
            comboBoxTemperamento.TabIndex = 13;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.FormattingEnabled = true;
            comboBoxSexo.Location = new Point(200, 260);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(150, 23);
            comboBoxSexo.TabIndex = 14;
            // 
            // comboBoxRaza
            // 
            comboBoxRaza.FormattingEnabled = true;
            comboBoxRaza.Location = new Point(200, 190);
            comboBoxRaza.Name = "comboBoxRaza";
            comboBoxRaza.Size = new Size(150, 23);
            comboBoxRaza.TabIndex = 15;
          
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(200, 120);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(60, 23);
            textBoxEdad.TabIndex = 16;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(200, 50);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(150, 23);
            textBoxNombre.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14F);
            label5.Location = new Point(40, 330);
            label5.Name = "label5";
            label5.Size = new Size(140, 24);
            label5.TabIndex = 18;
            label5.Text = "Temperamento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14F);
            label4.Location = new Point(40, 260);
            label4.Name = "label4";
            label4.Size = new Size(54, 24);
            label4.TabIndex = 19;
            label4.Text = "Sexo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F);
            label3.Location = new Point(40, 120);
            label3.Name = "label3";
            label3.Size = new Size(55, 24);
            label3.TabIndex = 20;
            label3.Text = "Edad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14F);
            label2.Location = new Point(40, 190);
            label2.Name = "label2";
            label2.Size = new Size(52, 24);
            label2.TabIndex = 21;
            label2.Text = "Raza";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F);
            label1.Location = new Point(40, 50);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 22;
            label1.Text = "Nombre";
            // 
            // cuRegistrarCaballo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "cuRegistrarCaballo";
            Size = new Size(800, 500);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxTemperamento;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.ComboBox comboBoxRaza;
        private System.Windows.Forms.TextBox textBoxEdad;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
