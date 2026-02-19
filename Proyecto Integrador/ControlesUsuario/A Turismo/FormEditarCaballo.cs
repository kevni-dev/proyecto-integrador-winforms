using System;
using System.Drawing;
using System.Windows.Forms;
using Proyecto_Integrador.Datos;

namespace Proyecto_Integrador.ControlesUsuario.A_Turismo
{
    internal class FormEditarCaballo : Form
    {
        public Caballo CaballoActualizado { get; private set; } = new Caballo();

        private TextBox txtNombre = new TextBox();
        private TextBox txtEdad = new TextBox();
        private ComboBox cbRaza = new ComboBox();
        private ComboBox cbSexo = new ComboBox();
        private ComboBox cbTemperamento = new ComboBox();
        private ComboBox cbImagen = new ComboBox();

        private Button btnOk = new Button();
        private Button btnCancel = new Button();

        public FormEditarCaballo(Caballo original)
        {
            Text = "Editar Caballo";
            Width = 520;
            Height = 380;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;

            BackColor = Color.FromArgb(240, 235, 226);

            // Layout
            var grid = new TableLayoutPanel();
            grid.Dock = DockStyle.Fill;
            grid.Padding = new Padding(18, 16, 18, 16);
            grid.ColumnCount = 2;
            grid.RowCount = 7;
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));

            for (int i = 0; i < 6; i++)
                grid.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            grid.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            Font fLabel = new Font("Georgia", 10.5F, FontStyle.Bold);
            Color cLabel = Color.FromArgb(92, 58, 32);

            Label MakeLabel(string t)
            {
                return new Label
                {
                    Text = t,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = fLabel,
                    ForeColor = cLabel
                };
            }

            Control MakeBox(Control c)
            {
                c.Dock = DockStyle.Fill;
                c.Font = new Font("Segoe UI", 11F);
                return c;
            }

            cbRaza.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTemperamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbImagen.DropDownStyle = ComboBoxStyle.DropDownList;

            cbRaza.Items.AddRange(new object[] { "Árabe", "Criollo", "Cuarto de milla" });
            cbSexo.Items.AddRange(new object[] { "Macho", "Hembra" });
            cbTemperamento.Items.AddRange(new object[] { "Tranquilo", "Nervioso", "Agresivo", "Activo" });
            cbImagen.Items.AddRange(new object[] { "Caballo_Arabe", "Caballo_Criollo", "Caballo_Cuarto" });

            grid.Controls.Add(MakeLabel("Nombre:"), 0, 0);
            grid.Controls.Add(MakeBox(txtNombre), 1, 0);

            grid.Controls.Add(MakeLabel("Edad:"), 0, 1);
            grid.Controls.Add(MakeBox(txtEdad), 1, 1);

            grid.Controls.Add(MakeLabel("Raza:"), 0, 2);
            grid.Controls.Add(MakeBox(cbRaza), 1, 2);

            grid.Controls.Add(MakeLabel("Sexo:"), 0, 3);
            grid.Controls.Add(MakeBox(cbSexo), 1, 3);

            grid.Controls.Add(MakeLabel("Temperamento:"), 0, 4);
            grid.Controls.Add(MakeBox(cbTemperamento), 1, 4);

            grid.Controls.Add(MakeLabel("Imagen:"), 0, 5);
            grid.Controls.Add(MakeBox(cbImagen), 1, 5);

            // Botones
            var panelBtns = new Panel { Dock = DockStyle.Fill, Padding = new Padding(0, 12, 0, 0) };

            btnOk.Text = "Guardar";
            btnCancel.Text = "Cancelar";

            btnOk.Font = new Font("Georgia", 11F, FontStyle.Bold);
            btnCancel.Font = new Font("Georgia", 11F, FontStyle.Bold);

            btnOk.Size = new Size(160, 44);
            btnCancel.Size = new Size(160, 44);

            try
            {
                btnOk.BackgroundImage = Properties.Resources.btn_verde;
                btnCancel.BackgroundImage = Properties.Resources.btn_rojo;
                btnOk.BackgroundImageLayout = ImageLayout.Stretch;
                btnCancel.BackgroundImageLayout = ImageLayout.Stretch;
                btnOk.FlatStyle = FlatStyle.Flat;
                btnCancel.FlatStyle = FlatStyle.Flat;
                btnOk.FlatAppearance.BorderSize = 0;
                btnCancel.FlatAppearance.BorderSize = 0;
                btnOk.ForeColor = Color.FromArgb(245, 239, 230);
                btnCancel.ForeColor = Color.FromArgb(245, 239, 230);
            }
            catch { }

            btnOk.Click += (_, __) => Guardar();
            btnCancel.Click += (_, __) => { DialogResult = DialogResult.Cancel; Close(); };

            panelBtns.Controls.Add(btnOk);
            panelBtns.Controls.Add(btnCancel);

            panelBtns.Resize += (_, __) =>
            {
                int gap = 12;
                int totalW = btnOk.Width + gap + btnCancel.Width;
                int startX = (panelBtns.Width - totalW) / 2;
                int y = 10;
                btnOk.Location = new Point(startX, y);
                btnCancel.Location = new Point(startX + btnOk.Width + gap, y);
            };

            grid.Controls.Add(panelBtns, 0, 6);
            grid.SetColumnSpan(panelBtns, 2);

            Controls.Add(grid);

            // cargar valores
            txtNombre.Text = original.Nombre ?? "";
            txtEdad.Text = original.Edad.ToString();
            cbRaza.SelectedItem = original.Raza;
            cbSexo.SelectedItem = original.Sexo;
            cbTemperamento.SelectedItem = original.Temperamento;
            cbImagen.SelectedItem = original.ImagenRecurso;

            if (cbRaza.SelectedIndex < 0) cbRaza.SelectedIndex = 0;
            if (cbSexo.SelectedIndex < 0) cbSexo.SelectedIndex = 0;
            if (cbTemperamento.SelectedIndex < 0) cbTemperamento.SelectedIndex = 0;
            if (cbImagen.SelectedIndex < 0) cbImagen.SelectedIndex = 0;
        }

        private void Guardar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text.Trim()))
            {
                MessageBox.Show("Nombre vacío");
                return;
            }

            if (!int.TryParse(txtEdad.Text.Trim(), out int edad))
            {
                MessageBox.Show("Edad inválida");
                return;
            }

            CaballoActualizado = new Caballo
            {
                Nombre = txtNombre.Text.Trim(),
                Edad = edad,
                Raza = cbRaza.Text,
                Sexo = cbSexo.Text,
                Temperamento = cbTemperamento.Text,
                ImagenRecurso = cbImagen.Text
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
