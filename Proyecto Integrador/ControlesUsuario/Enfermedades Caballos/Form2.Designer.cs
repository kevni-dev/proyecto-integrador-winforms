namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class Form_enferme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lbl_tituloEnfer = new Label();
            dtgv_enfermedades = new DataGridView();
            Caballo = new DataGridViewTextBoxColumn();
            Síntomas = new DataGridViewTextBoxColumn();
            Enfermedad = new DataGridViewTextBoxColumn();
            Descripción = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dtgv_enfermedades).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_tituloEnfer
            // 
            lbl_tituloEnfer.AutoSize = true;
            lbl_tituloEnfer.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tituloEnfer.Location = new Point(12, 9);
            lbl_tituloEnfer.Name = "lbl_tituloEnfer";
            lbl_tituloEnfer.Size = new Size(587, 38);
            lbl_tituloEnfer.TabIndex = 0;
            lbl_tituloEnfer.Text = "Enfermedades más comunes de los caballos";
            // 
            // dtgv_enfermedades
            // 
            dtgv_enfermedades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_enfermedades.BackgroundColor = Color.White;
            dtgv_enfermedades.BorderStyle = BorderStyle.None;
            dtgv_enfermedades.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Salmon;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgv_enfermedades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgv_enfermedades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_enfermedades.Columns.AddRange(new DataGridViewColumn[] { Caballo, Síntomas, Enfermedad, Descripción });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgv_enfermedades.DefaultCellStyle = dataGridViewCellStyle2;
            dtgv_enfermedades.Dock = DockStyle.Fill;
            dtgv_enfermedades.GridColor = Color.LightGray;
            dtgv_enfermedades.Location = new Point(0, 0);
            dtgv_enfermedades.Name = "dtgv_enfermedades";
            dtgv_enfermedades.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgv_enfermedades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgv_enfermedades.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dtgv_enfermedades.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dtgv_enfermedades.Size = new Size(1057, 565);
            dtgv_enfermedades.TabIndex = 1;
            dtgv_enfermedades.CellContentClick += dtgv_enfermedades_CellContentClick;
            // 
            // Caballo
            // 
            Caballo.HeaderText = "Caballo";
            Caballo.MinimumWidth = 6;
            Caballo.Name = "Caballo";
            // 
            // Síntomas
            // 
            Síntomas.HeaderText = "Síntomas";
            Síntomas.MinimumWidth = 6;
            Síntomas.Name = "Síntomas";
            // 
            // Enfermedad
            // 
            Enfermedad.HeaderText = "Enfermedad";
            Enfermedad.MinimumWidth = 6;
            Enfermedad.Name = "Enfermedad";
            // 
            // Descripción
            // 
            Descripción.HeaderText = "Descripción";
            Descripción.MinimumWidth = 6;
            Descripción.Name = "Descripción";
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_tituloEnfer);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1057, 66);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgv_enfermedades);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(1057, 565);
            panel1.TabIndex = 4;
            // 
            // Form_enferme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1057, 631);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form_enferme";
            Text = "Enfermedades ";
            WindowState = FormWindowState.Maximized;
            Load += Form_enferme_Load;
            ((System.ComponentModel.ISupportInitialize)dtgv_enfermedades).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_tituloEnfer;
        private DataGridView dtgv_enfermedades;
        private DataGridViewTextBoxColumn Caballo;
        private DataGridViewTextBoxColumn Síntomas;
        private DataGridViewTextBoxColumn Enfermedad;
        private DataGridViewTextBoxColumn Descripción;
        private Panel panel2;
        private Panel panel1;
    }
}