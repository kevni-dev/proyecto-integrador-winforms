using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    partial class TurismoRegistrarCaballo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            layoutMain = new TableLayoutPanel();
            layoutLeft = new TableLayoutPanel();
            label1 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxEdad = new TextBox();
            label2 = new Label();
            comboBoxRaza = new ComboBox();
            label6 = new Label();
            comboBoxImagen = new ComboBox();
            label4 = new Label();
            comboBoxSexo = new ComboBox();
            label5 = new Label();
            comboBoxTemperamento = new ComboBox();
            panelButtons = new Panel();
            btnGuardar = new Button();
            spacer = new Panel();
            btnCancelar = new Button();
            panelRight = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            layoutMain.SuspendLayout();
            layoutLeft.SuspendLayout();
            panelButtons.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(layoutMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1371, 867);
            panel1.TabIndex = 0;
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            layoutMain.Controls.Add(layoutLeft, 0, 0);
            layoutMain.Controls.Add(panelRight, 1, 0);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(0, 0);
            layoutMain.Margin = new Padding(3, 4, 3, 4);
            layoutMain.Name = "layoutMain";
            layoutMain.Padding = new Padding(46, 40, 46, 40);
            layoutMain.RowCount = 1;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.Size = new Size(1371, 867);
            layoutMain.TabIndex = 0;
            // 
            // layoutLeft
            // 
            layoutLeft.ColumnCount = 2;
            layoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            layoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            layoutLeft.Controls.Add(label1, 0, 0);
            layoutLeft.Controls.Add(textBoxNombre, 1, 0);
            layoutLeft.Controls.Add(label3, 0, 1);
            layoutLeft.Controls.Add(textBoxEdad, 1, 1);
            layoutLeft.Controls.Add(label2, 0, 2);
            layoutLeft.Controls.Add(comboBoxRaza, 1, 2);
            layoutLeft.Controls.Add(label6, 0, 3);
            layoutLeft.Controls.Add(comboBoxImagen, 1, 3);
            layoutLeft.Controls.Add(label4, 0, 4);
            layoutLeft.Controls.Add(comboBoxSexo, 1, 4);
            layoutLeft.Controls.Add(label5, 0, 5);
            layoutLeft.Controls.Add(comboBoxTemperamento, 1, 5);
            layoutLeft.Controls.Add(panelButtons, 0, 6);
            layoutLeft.Dock = DockStyle.Fill;
            layoutLeft.Location = new Point(49, 44);
            layoutLeft.Margin = new Padding(3, 4, 3, 4);
            layoutLeft.Name = "layoutLeft";
            layoutLeft.RowCount = 7;
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 93F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutLeft.Size = new Size(569, 779);
            layoutLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 93);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Dock = DockStyle.Fill;
            textBoxNombre.Font = new Font("Segoe UI", 14F);
            textBoxNombre.Location = new Point(202, 4);
            textBoxNombre.Margin = new Padding(3, 4, 3, 4);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(364, 39);
            textBoxNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(3, 93);
            label3.Name = "label3";
            label3.Size = new Size(193, 93);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Dock = DockStyle.Left;
            textBoxEdad.Font = new Font("Segoe UI", 14F);
            textBoxEdad.Location = new Point(202, 97);
            textBoxEdad.Margin = new Padding(3, 4, 3, 4);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(159, 39);
            textBoxEdad.TabIndex = 3;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(3, 186);
            label2.Name = "label2";
            label2.Size = new Size(193, 93);
            label2.TabIndex = 4;
            label2.Text = "Raza";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxRaza
            // 
            comboBoxRaza.Dock = DockStyle.Fill;
            comboBoxRaza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRaza.Font = new Font("Segoe UI", 14F);
            comboBoxRaza.Location = new Point(202, 190);
            comboBoxRaza.Margin = new Padding(3, 4, 3, 4);
            comboBoxRaza.Name = "comboBoxRaza";
            comboBoxRaza.Size = new Size(364, 39);
            comboBoxRaza.TabIndex = 5;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 16F);
            label6.Location = new Point(3, 279);
            label6.Name = "label6";
            label6.Size = new Size(193, 93);
            label6.TabIndex = 6;
            label6.Text = "Imagen";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxImagen
            // 
            comboBoxImagen.Dock = DockStyle.Fill;
            comboBoxImagen.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxImagen.Font = new Font("Segoe UI", 14F);
            comboBoxImagen.Location = new Point(202, 283);
            comboBoxImagen.Margin = new Padding(3, 4, 3, 4);
            comboBoxImagen.Name = "comboBoxImagen";
            comboBoxImagen.Size = new Size(364, 39);
            comboBoxImagen.TabIndex = 7;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(3, 372);
            label4.Name = "label4";
            label4.Size = new Size(193, 93);
            label4.TabIndex = 8;
            label4.Text = "Sexo";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.Dock = DockStyle.Fill;
            comboBoxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSexo.Font = new Font("Segoe UI", 14F);
            comboBoxSexo.Location = new Point(202, 376);
            comboBoxSexo.Margin = new Padding(3, 4, 3, 4);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(364, 39);
            comboBoxSexo.TabIndex = 9;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 16F);
            label5.Location = new Point(3, 465);
            label5.Name = "label5";
            label5.Size = new Size(193, 93);
            label5.TabIndex = 10;
            label5.Text = "Temperamento";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxTemperamento
            // 
            comboBoxTemperamento.Dock = DockStyle.Fill;
            comboBoxTemperamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTemperamento.Font = new Font("Segoe UI", 14F);
            comboBoxTemperamento.Location = new Point(202, 469);
            comboBoxTemperamento.Margin = new Padding(3, 4, 3, 4);
            comboBoxTemperamento.Name = "comboBoxTemperamento";
            comboBoxTemperamento.Size = new Size(364, 39);
            comboBoxTemperamento.TabIndex = 11;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.Transparent;
            layoutLeft.SetColumnSpan(panelButtons, 2);
            panelButtons.Controls.Add(btnGuardar);
            panelButtons.Controls.Add(spacer);
            panelButtons.Controls.Add(btnCancelar);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 562);
            panelButtons.Margin = new Padding(3, 4, 3, 4);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(563, 213);
            panelButtons.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Gold;
            btnGuardar.Dock = DockStyle.Right;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnGuardar.Location = new Point(0, 0);
            btnGuardar.Margin = new Padding(11, 13, 11, 13);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(285, 213);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Aceptar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // spacer
            // 
            spacer.Dock = DockStyle.Right;
            spacer.Location = new Point(285, 0);
            spacer.Margin = new Padding(3, 4, 3, 4);
            spacer.Name = "spacer";
            spacer.Size = new Size(17, 213);
            spacer.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.Dock = DockStyle.Right;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCancelar.Location = new Point(302, 0);
            btnCancelar.Margin = new Padding(11, 13, 11, 13);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(261, 213);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.Transparent;
            panelRight.Controls.Add(pictureBox1);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(624, 44);
            panelRight.Margin = new Padding(3, 4, 3, 4);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(34, 40, 34, 40);
            panelRight.Size = new Size(698, 779);
            panelRight.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(240, 240, 240);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.Caballo_Arabe;
            pictureBox1.Location = new Point(34, 40);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 699);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TurismoRegistrarCaballo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TurismoRegistrarCaballo";
            Size = new Size(1371, 867);
            panel1.ResumeLayout(false);
            layoutMain.ResumeLayout(false);
            layoutLeft.ResumeLayout(false);
            layoutLeft.PerformLayout();
            panelButtons.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;

        private TableLayoutPanel layoutMain;
        private TableLayoutPanel layoutLeft;
        private Panel panelRight;
        private Panel panelButtons;

        private Button btnCancelar;
        private Button btnGuardar;

        private PictureBox pictureBox1;

        private ComboBox comboBoxTemperamento;
        private ComboBox comboBoxSexo;
        private ComboBox comboBoxRaza;
        private ComboBox comboBoxImagen;

        private TextBox textBoxEdad;
        private TextBox textBoxNombre;

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Panel spacer;
    }
}
