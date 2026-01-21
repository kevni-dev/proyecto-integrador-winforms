namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class Form_tratamiento
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
            lbl_tituloTratamientos = new Label();
            SuspendLayout();
            // 
            // lbl_tituloTratamientos
            // 
            lbl_tituloTratamientos.AutoSize = true;
            lbl_tituloTratamientos.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tituloTratamientos.Location = new Point(326, 9);
            lbl_tituloTratamientos.Name = "lbl_tituloTratamientos";
            lbl_tituloTratamientos.Size = new Size(413, 38);
            lbl_tituloTratamientos.TabIndex = 0;
            lbl_tituloTratamientos.Text = "Tratamientos para los caballos";
            // 
            // Form_tratamiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1020, 619);
            Controls.Add(lbl_tituloTratamientos);
            Name = "Form_tratamiento";
            Text = "Tratamiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tituloTratamientos;
    }
}