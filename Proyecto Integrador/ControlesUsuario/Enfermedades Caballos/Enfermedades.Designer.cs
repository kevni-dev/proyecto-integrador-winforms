namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class Enfermedades
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
            txt_enfermedad = new TextBox();
            txt_sintomas = new TextBox();
            txt_descripcion = new TextBox();
            lbl_enfermedad = new Label();
            lbl_sintomas = new Label();
            lbl_descripcion = new Label();
            btn_guardar = new Button();
            SuspendLayout();
            // 
            // txt_enfermedad
            // 
            txt_enfermedad.Location = new Point(122, 100);
            txt_enfermedad.Name = "txt_enfermedad";
            txt_enfermedad.Size = new Size(260, 27);
            txt_enfermedad.TabIndex = 0;
            // 
            // txt_sintomas
            // 
            txt_sintomas.Location = new Point(122, 160);
            txt_sintomas.Name = "txt_sintomas";
            txt_sintomas.Size = new Size(267, 27);
            txt_sintomas.TabIndex = 1;
            // 
            // txt_descripcion
            // 
            txt_descripcion.Location = new Point(131, 249);
            txt_descripcion.Name = "txt_descripcion";
            txt_descripcion.Size = new Size(247, 27);
            txt_descripcion.TabIndex = 2;
            // 
            // lbl_enfermedad
            // 
            lbl_enfermedad.AutoSize = true;
            lbl_enfermedad.Location = new Point(19, 103);
            lbl_enfermedad.Name = "lbl_enfermedad";
            lbl_enfermedad.Size = new Size(90, 20);
            lbl_enfermedad.TabIndex = 3;
            lbl_enfermedad.Text = "Enfermedad";
            // 
            // lbl_sintomas
            // 
            lbl_sintomas.AutoSize = true;
            lbl_sintomas.Location = new Point(24, 160);
            lbl_sintomas.Name = "lbl_sintomas";
            lbl_sintomas.Size = new Size(70, 20);
            lbl_sintomas.TabIndex = 4;
            lbl_sintomas.Text = "Sintomas";
            // 
            // lbl_descripcion
            // 
            lbl_descripcion.AutoSize = true;
            lbl_descripcion.Location = new Point(19, 256);
            lbl_descripcion.Name = "lbl_descripcion";
            lbl_descripcion.Size = new Size(91, 20);
            lbl_descripcion.TabIndex = 5;
            lbl_descripcion.Text = "Descripcion ";
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(187, 327);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(105, 68);
            btn_guardar.TabIndex = 6;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // Enfermedades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 479);
            Controls.Add(btn_guardar);
            Controls.Add(lbl_descripcion);
            Controls.Add(lbl_sintomas);
            Controls.Add(lbl_enfermedad);
            Controls.Add(txt_descripcion);
            Controls.Add(txt_sintomas);
            Controls.Add(txt_enfermedad);
            Name = "Enfermedades";
            Text = "Enfermedades";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_enfermedad;
        private TextBox txt_sintomas;
        private TextBox txt_descripcion;
        private Label lbl_enfermedad;
        private Label lbl_sintomas;
        private Label lbl_descripcion;
        private Button btn_guardar;
    }
}