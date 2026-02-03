namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class cuPrevencion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer

        private void InitializeComponent()
        {
            panelLeft = new Panel();
            lblTitulo = new Label();
            lblEnfermedad = new Label();
            cmb_enfermedades = new ComboBox();

            panelFill = new Panel();
            txt_prevencion = new RichTextBox();

            SuspendLayout();

            // ================= LEFT =================
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Width = 320;
            panelLeft.Padding = new Padding(20);

            lblTitulo.Text = "PREVENCIÓN";
            lblTitulo.Font = new Font("Stencil", 16F, FontStyle.Bold);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Height = 50;

            lblEnfermedad.Text = "ENFERMEDAD";
            lblEnfermedad.Font = new Font("Stencil", 10F);
            lblEnfermedad.Top = 70;

            cmb_enfermedades.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_enfermedades.Top = 95;
            cmb_enfermedades.Width = 260;

            panelLeft.Controls.Add(cmb_enfermedades);
            panelLeft.Controls.Add(lblEnfermedad);
            panelLeft.Controls.Add(lblTitulo);

            // ================= FILL =================
            panelFill.Dock = DockStyle.Fill;
            panelFill.Padding = new Padding(15);

            txt_prevencion.Dock = DockStyle.Fill;
            txt_prevencion.ReadOnly = true;
            txt_prevencion.Font = new Font("Segoe UI", 11F);
            txt_prevencion.BackColor = Color.White;
            txt_prevencion.BorderStyle = BorderStyle.FixedSingle;

            panelFill.Controls.Add(txt_prevencion);

            // ================= CONTROL =================
            Controls.Add(panelFill);
            Controls.Add(panelLeft);

            Name = "cuPrevencion";
            Size = new Size(1200, 600);

            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelFill;
        private Label lblTitulo;
        private Label lblEnfermedad;
        private ComboBox cmb_enfermedades;
        private RichTextBox txt_prevencion;
    }
}
