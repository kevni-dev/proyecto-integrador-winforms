// TurismoRegistrarCaballo.Designer.cs
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario
{
    partial class TurismoRegistrarCaballo
    {
        private System.ComponentModel.IContainer components = null;

        private TableLayoutPanel layoutButtons;
        private TableLayoutPanel layoutButtonsHost;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Designer

        private void InitializeComponent()
        {
            panel1 = new Panel();
            layoutMain = new TableLayoutPanel();
            panelLeftHost = new Panel();
            panelCardLeft = new Panel();
            layoutLeft = new TableLayoutPanel();
            label1 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxEdad = new TextBox();
            label2 = new Label();
            comboBoxRaza = new ComboBox();
            label4 = new Label();
            comboBoxSexo = new ComboBox();
            label5 = new Label();
            comboBoxTemperamento = new ComboBox();
            panelButtons = new Panel();
            layoutButtonsHost = new TableLayoutPanel();
            layoutButtons = new TableLayoutPanel();
            btnGuardar = new Button();
            btnCancelar = new Button();
            labelTitulo = new Label();
            panelRightHost = new Panel();
            panelCardRight = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            layoutMain.SuspendLayout();
            panelLeftHost.SuspendLayout();
            panelCardLeft.SuspendLayout();
            layoutLeft.SuspendLayout();
            panelButtons.SuspendLayout();
            layoutButtonsHost.SuspendLayout();
            layoutButtons.SuspendLayout();
            panelRightHost.SuspendLayout();
            panelCardRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(layoutMain);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(60, 35, 60, 45);
            panel1.Size = new Size(1200, 650);
            panel1.TabIndex = 0;
            // 
            // layoutMain
            // 
            layoutMain.ColumnCount = 2;
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutMain.Controls.Add(panelLeftHost, 0, 0);
            layoutMain.Controls.Add(panelRightHost, 1, 0);
            layoutMain.Dock = DockStyle.Fill;
            layoutMain.Location = new Point(60, 35);
            layoutMain.Margin = new Padding(0);
            layoutMain.Name = "layoutMain";
            layoutMain.RowCount = 1;
            layoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutMain.Size = new Size(1080, 570);
            layoutMain.TabIndex = 0;
            // 
            // panelLeftHost
            // 
            panelLeftHost.BackColor = Color.Transparent;
            panelLeftHost.Controls.Add(panelCardLeft);
            panelLeftHost.Dock = DockStyle.Fill;
            panelLeftHost.Location = new Point(3, 3);
            panelLeftHost.Name = "panelLeftHost";
            panelLeftHost.Padding = new Padding(0, 0, 18, 0);
            panelLeftHost.Size = new Size(534, 564);
            panelLeftHost.TabIndex = 0;
            // 
            // panelCardLeft
            // 
            panelCardLeft.BackColor = Color.FromArgb(238, 232, 220);
            panelCardLeft.BorderStyle = BorderStyle.FixedSingle;
            panelCardLeft.Controls.Add(layoutLeft);
            panelCardLeft.Controls.Add(labelTitulo);
            panelCardLeft.Dock = DockStyle.Fill;
            panelCardLeft.Location = new Point(0, 0);
            panelCardLeft.Name = "panelCardLeft";
            panelCardLeft.Padding = new Padding(18, 14, 18, 14);
            panelCardLeft.Size = new Size(516, 564);
            panelCardLeft.TabIndex = 0;
            // 
            // layoutLeft
            // 
            layoutLeft.ColumnCount = 2;
            layoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            layoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63F));
            layoutLeft.Controls.Add(label1, 0, 0);
            layoutLeft.Controls.Add(textBoxNombre, 1, 0);
            layoutLeft.Controls.Add(label3, 0, 1);
            layoutLeft.Controls.Add(textBoxEdad, 1, 1);
            layoutLeft.Controls.Add(label2, 0, 2);
            layoutLeft.Controls.Add(comboBoxRaza, 1, 2);
            layoutLeft.Controls.Add(label4, 0, 3);
            layoutLeft.Controls.Add(comboBoxSexo, 1, 3);
            layoutLeft.Controls.Add(label5, 0, 4);
            layoutLeft.Controls.Add(comboBoxTemperamento, 1, 4);
            layoutLeft.Controls.Add(panelButtons, 0, 5);
            layoutLeft.Dock = DockStyle.Fill;
            layoutLeft.Location = new Point(18, 48);
            layoutLeft.Name = "layoutLeft";
            layoutLeft.Padding = new Padding(10);
            layoutLeft.RowCount = 6;
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            layoutLeft.Size = new Size(478, 500);
            layoutLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Georgia", 10.5F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(92, 58, 32);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(163, 42);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Dock = DockStyle.Fill;
            textBoxNombre.Font = new Font("Segoe UI", 11F);
            textBoxNombre.Location = new Point(182, 16);
            textBoxNombre.Margin = new Padding(3, 6, 3, 6);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(283, 27);
            textBoxNombre.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Georgia", 10.5F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(92, 58, 32);
            label3.Location = new Point(13, 52);
            label3.Name = "label3";
            label3.Size = new Size(163, 42);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Font = new Font("Segoe UI", 11F);
            textBoxEdad.Location = new Point(182, 58);
            textBoxEdad.Margin = new Padding(3, 6, 3, 6);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(120, 27);
            textBoxEdad.TabIndex = 3;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Georgia", 10.5F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(92, 58, 32);
            label2.Location = new Point(13, 94);
            label2.Name = "label2";
            label2.Size = new Size(163, 42);
            label2.TabIndex = 4;
            label2.Text = "Raza";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxRaza
            // 
            comboBoxRaza.Dock = DockStyle.Fill;
            comboBoxRaza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRaza.Font = new Font("Segoe UI", 11F);
            comboBoxRaza.Location = new Point(182, 100);
            comboBoxRaza.Margin = new Padding(3, 6, 3, 6);
            comboBoxRaza.Name = "comboBoxRaza";
            comboBoxRaza.Size = new Size(283, 28);
            comboBoxRaza.TabIndex = 5;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Georgia", 10.5F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(92, 58, 32);
            label4.Location = new Point(13, 136);
            label4.Name = "label4";
            label4.Size = new Size(163, 42);
            label4.TabIndex = 6;
            label4.Text = "Sexo";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxSexo
            // 
            comboBoxSexo.Dock = DockStyle.Fill;
            comboBoxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSexo.Font = new Font("Segoe UI", 11F);
            comboBoxSexo.Location = new Point(182, 142);
            comboBoxSexo.Margin = new Padding(3, 6, 3, 6);
            comboBoxSexo.Name = "comboBoxSexo";
            comboBoxSexo.Size = new Size(283, 28);
            comboBoxSexo.TabIndex = 7;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Georgia", 10.5F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(92, 58, 32);
            label5.Location = new Point(13, 178);
            label5.Name = "label5";
            label5.Size = new Size(163, 42);
            label5.TabIndex = 8;
            label5.Text = "Temperamento";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxTemperamento
            // 
            comboBoxTemperamento.Dock = DockStyle.Fill;
            comboBoxTemperamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTemperamento.Font = new Font("Segoe UI", 11F);
            comboBoxTemperamento.Location = new Point(182, 184);
            comboBoxTemperamento.Margin = new Padding(3, 6, 3, 6);
            comboBoxTemperamento.Name = "comboBoxTemperamento";
            comboBoxTemperamento.Size = new Size(283, 28);
            comboBoxTemperamento.TabIndex = 9;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.Transparent;
            layoutLeft.SetColumnSpan(panelButtons, 2);
            panelButtons.Controls.Add(layoutButtonsHost);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(13, 223);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(0, 10, 0, 0);
            panelButtons.Size = new Size(452, 264);
            panelButtons.TabIndex = 10;
            // 
            // layoutButtonsHost
            // 
            layoutButtonsHost.ColumnCount = 3;
            layoutButtonsHost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutButtonsHost.ColumnStyles.Add(new ColumnStyle());
            layoutButtonsHost.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            layoutButtonsHost.Controls.Add(layoutButtons, 1, 0);
            layoutButtonsHost.Dock = DockStyle.Fill;
            layoutButtonsHost.Location = new Point(0, 10);
            layoutButtonsHost.Margin = new Padding(0);
            layoutButtonsHost.Name = "layoutButtonsHost";
            layoutButtonsHost.RowCount = 1;
            layoutButtonsHost.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutButtonsHost.Size = new Size(452, 254);
            layoutButtonsHost.TabIndex = 0;
            // 
            // layoutButtons
            // 
            layoutButtons.AutoSize = true;
            layoutButtons.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            layoutButtons.ColumnCount = 3;
            layoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            layoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            layoutButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 130F));
            layoutButtons.Controls.Add(btnGuardar, 0, 0);
            layoutButtons.Controls.Add(btnCancelar, 2, 0);
            layoutButtons.Location = new Point(89, 0);
            layoutButtons.Margin = new Padding(0);
            layoutButtons.Name = "layoutButtons";
            layoutButtons.RowCount = 1;
            layoutButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            layoutButtons.Size = new Size(274, 34);
            layoutButtons.TabIndex = 0;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(230, 203, 120);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Georgia", 10.5F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.FromArgb(92, 58, 32);
            btnGuardar.Location = new Point(0, 0);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(130, 34);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Aceptar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(210, 150, 140);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Georgia", 10.5F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(92, 58, 32);
            btnCancelar.Location = new Point(144, 0);
            btnCancelar.Margin = new Padding(0);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 34);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.Dock = DockStyle.Top;
            labelTitulo.Font = new Font("Georgia", 15F, FontStyle.Bold);
            labelTitulo.ForeColor = Color.FromArgb(92, 58, 32);
            labelTitulo.Location = new Point(18, 14);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(478, 34);
            labelTitulo.TabIndex = 100;
            labelTitulo.Text = "Registrar Caballo";
            labelTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelRightHost
            // 
            panelRightHost.BackColor = Color.Transparent;
            panelRightHost.Controls.Add(panelCardRight);
            panelRightHost.Dock = DockStyle.Fill;
            panelRightHost.Location = new Point(543, 3);
            panelRightHost.Name = "panelRightHost";
            panelRightHost.Padding = new Padding(18, 0, 0, 0);
            panelRightHost.Size = new Size(534, 564);
            panelRightHost.TabIndex = 1;
            // 
            // panelCardRight
            // 
            panelCardRight.BackColor = Color.FromArgb(245, 243, 238);
            panelCardRight.BorderStyle = BorderStyle.FixedSingle;
            panelCardRight.Controls.Add(pictureBox1);
            panelCardRight.Dock = DockStyle.Fill;
            panelCardRight.Location = new Point(18, 0);
            panelCardRight.Name = "panelCardRight";
            panelCardRight.Padding = new Padding(16);
            panelCardRight.Size = new Size(516, 564);
            panelCardRight.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.cab_a;
            pictureBox1.Location = new Point(16, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(482, 530);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // TurismoRegistrarCaballo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "TurismoRegistrarCaballo";
            Size = new Size(1200, 650);
            panel1.ResumeLayout(false);
            layoutMain.ResumeLayout(false);
            panelLeftHost.ResumeLayout(false);
            panelCardLeft.ResumeLayout(false);
            layoutLeft.ResumeLayout(false);
            layoutLeft.PerformLayout();
            panelButtons.ResumeLayout(false);
            layoutButtonsHost.ResumeLayout(false);
            layoutButtonsHost.PerformLayout();
            layoutButtons.ResumeLayout(false);
            panelRightHost.ResumeLayout(false);
            panelCardRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel layoutMain;

        private Panel panelLeftHost;
        private Panel panelRightHost;

        private Panel panelCardLeft;
        private Panel panelCardRight;

        private Label labelTitulo;
        private TableLayoutPanel layoutLeft;

        private Panel panelButtons;
        private Button btnCancelar;
        private Button btnGuardar;

        private PictureBox pictureBox1;

        private ComboBox comboBoxTemperamento;
        private ComboBox comboBoxSexo;
        private ComboBox comboBoxRaza;

        private TextBox textBoxEdad;
        private TextBox textBoxNombre;

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
