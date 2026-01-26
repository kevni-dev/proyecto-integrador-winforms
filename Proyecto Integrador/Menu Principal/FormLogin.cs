using System;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class FormLogin : Form
    {
        private const string UsuarioDefecto = "Usuario";
        private const string ClaveDefecto = "hola123";

        private const string UsuarioExtra = "1";
        private const string ClaveExtra = "1";

        private const string CodigoDev = "DEV-2026";

        public FormLogin()
        {
            InitializeComponent();

            // Enter para iniciar
            usuario_textbox.KeyDown += EnterInicia;
            clave_textbox.KeyDown += EnterInicia;
        }

        private void EnterInicia(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                inicio_button.PerformClick();
            }
        }

        private void inicio_button_Click(object sender, EventArgs e)
        {
            error_label.Visible = false;

            string u = usuario_textbox.Text.Trim();
            string p = clave_textbox.Text;

            bool ok =
                (u == UsuarioDefecto && p == ClaveDefecto) ||
                (u == UsuarioExtra && p == ClaveExtra);

            if (ok)
            {
                var main = new forMain(u);
                main.FormClosed += (s, ev) => this.Close();
                main.Show();
                this.Hide();
            }
            else
            {
                error_label.Text = "Usuario o contraseña incorrectos";
                error_label.Visible = true;
            }
        }

        private void registrar_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string codigo = Prompt("Código del desarrollador", "Ingresa el código para registrar usuarios:");

            if (string.IsNullOrWhiteSpace(codigo)) return;

            if (codigo != CodigoDev)
            {
                MessageBox.Show("Código incorrecto.", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Código correcto. (Aquí abrirías el registro)", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string Prompt(string titulo, string texto)
        {
            Form prompt = new Form()
            {
                Width = 360,
                Height = 170,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = titulo,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label label = new Label() { Left = 15, Top = 15, Width = 310, Text = texto };
            TextBox input = new TextBox() { Left = 15, Top = 45, Width = 310 };
            Button ok = new Button() { Text = "OK", Left = 165, Width = 75, Top = 80, DialogResult = DialogResult.OK };
            Button cancel = new Button() { Text = "Cancelar", Left = 250, Width = 75, Top = 80, DialogResult = DialogResult.Cancel };

            prompt.Controls.Add(label);
            prompt.Controls.Add(input);
            prompt.Controls.Add(ok);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = ok;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? input.Text : "";
        }
    }
}
