// FormRegistroTemp.Designer.cs
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    partial class FormRegistroTemp
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblUser;
        private Label lblPass;
        private Label lblPass2;

        private TextBox txtUser;
        private TextBox txtPass;
        private TextBox txtPass2;

        private Label lblError;

        internal Button btnOk;
        internal Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblUser = new Label();
            lblPass = new Label();
            lblPass2 = new Label();

            txtUser = new TextBox();
            txtPass = new TextBox();
            txtPass2 = new TextBox();

            lblError = new Label();

            btnOk = new Button();
            btnCancel = new Button();

            SuspendLayout();

            // ===== Form =====
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(360, 260);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistroTemp";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Registrar usuario";
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);

            // ===== Labels =====
            lblUser.AutoSize = false;
            lblUser.Location = new Point(18, 18);
            lblUser.Size = new Size(320, 20);
            lblUser.Text = "Usuario";

            lblPass.AutoSize = false;
            lblPass.Location = new Point(18, 78);
            lblPass.Size = new Size(320, 20);
            lblPass.Text = "Contraseña";

            lblPass2.AutoSize = false;
            lblPass2.Location = new Point(18, 138);
            lblPass2.Size = new Size(320, 20);
            lblPass2.Text = "Confirmar contraseña";

            // ===== TextBoxes =====
            txtUser.Location = new Point(18, 42);
            txtUser.Size = new Size(320, 25);
            txtUser.TabIndex = 0;

            txtPass.Location = new Point(18, 102);
            txtPass.Size = new Size(320, 25);
            txtPass.UseSystemPasswordChar = true;
            txtPass.TabIndex = 1;

            txtPass2.Location = new Point(18, 162);
            txtPass2.Size = new Size(320, 25);
            txtPass2.UseSystemPasswordChar = true;
            txtPass2.TabIndex = 2;

            // ===== Error label =====
            lblError.Location = new Point(18, 192);
            lblError.Size = new Size(320, 20);
            lblError.ForeColor = Color.Firebrick;
            lblError.Text = "Error";
            lblError.Visible = false;

            // ===== Buttons =====
            btnOk.Location = new Point(180, 218);
            btnOk.Size = new Size(76, 30);
            btnOk.Text = "Crear";
            btnOk.TabIndex = 3;
            btnOk.UseVisualStyleBackColor = true;

            btnCancel.Location = new Point(262, 218);
            btnCancel.Size = new Size(76, 30);
            btnCancel.Text = "Cancelar";
            btnCancel.TabIndex = 4;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.DialogResult = DialogResult.Cancel;

            // ===== Add controls =====
            Controls.Add(lblUser);
            Controls.Add(txtUser);

            Controls.Add(lblPass);
            Controls.Add(txtPass);

            Controls.Add(lblPass2);
            Controls.Add(txtPass2);

            Controls.Add(lblError);

            Controls.Add(btnOk);
            Controls.Add(btnCancel);

            ResumeLayout(false);
            PerformLayout();
        }
    }
}
