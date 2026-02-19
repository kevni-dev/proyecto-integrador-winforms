// FormRegistroTemp.cs
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class FormRegistroTemp : Form
    {
        public string Usuario { get; private set; } = "";
        public string Clave { get; private set; } = "";

        public FormRegistroTemp()
        {
            InitializeComponent();

            AcceptButton = btnOk;
            CancelButton = btnCancel;

            btnOk.Click += (_, __) => TryCreate();
        }

        private void TryCreate()
        {
            lblError.Visible = false;

            var u = txtUser.Text.Trim();
            var p1 = txtPass.Text;
            var p2 = txtPass2.Text;

            if (string.IsNullOrWhiteSpace(u))
            {
                ShowError("Escribe un usuario.");
                txtUser.Focus();
                return;
            }

            if (u.Length < 3)
            {
                ShowError("El usuario debe tener al menos 3 caracteres.");
                txtUser.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(p1))
            {
                ShowError("Escribe una contraseña.");
                txtPass.Focus();
                return;
            }

            if (p1.Length < 4)
            {
                ShowError("Contraseña muy corta (mínimo 4).");
                txtPass.Focus();
                return;
            }

            if (p1 != p2)
            {
                ShowError("Las contraseñas no coinciden.");
                txtPass2.Focus();
                return;
            }

            Usuario = u;
            Clave = p1;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ShowError(string msg)
        {
            lblError.Text = msg;
            lblError.Visible = true;
        }
    }
}
