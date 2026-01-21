namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class Form_prevencion
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
            lbl_tituloPrevencion = new Label();
            SuspendLayout();
            // 
            // lbl_tituloPrevencion
            // 
            lbl_tituloPrevencion.AutoSize = true;
            lbl_tituloPrevencion.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_tituloPrevencion.Location = new Point(337, 9);
            lbl_tituloPrevencion.Name = "lbl_tituloPrevencion";
            lbl_tituloPrevencion.Size = new Size(386, 38);
            lbl_tituloPrevencion.TabIndex = 0;
            lbl_tituloPrevencion.Text = "Prevención para los caballos";
            // 
            // Form_prevencion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Diseño_sin_título;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1018, 621);
            Controls.Add(lbl_tituloPrevencion);
            Name = "Form_prevencion";
            Text = "Prevención";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_tituloPrevencion;
    }
}