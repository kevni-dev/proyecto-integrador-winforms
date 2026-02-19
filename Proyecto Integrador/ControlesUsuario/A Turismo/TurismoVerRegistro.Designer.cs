using System.Drawing;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.A_Turismo
{
    partial class TurismoVerRegistro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer

        private Panel panelRoot;

        private Panel panelTop;
        private TableLayoutPanel layoutTop;

        private TextBox txtBuscar;
        private ComboBox comboBuscarPor;
        private ComboBox comboRaza;
        private ComboBox comboSexo;
        private ComboBox comboTemperamento;

        private Label lblBuscar;
        private Label lblBuscarPor;
        private Label lblRaza;
        private Label lblSexo;
        private Label lblTemperamento;

        private Panel panelContent;
        private TableLayoutPanel layoutContent;

        private Panel panelGridCard;
        private DataGridView dataGridCaballos;
        private Panel panelBottomLeft;
        private Label lblTotal;

        private Panel panelPreviewCard;
        private Label lblVista;

        private PictureBox pictureCaballo;
        private Label lblPrevNombre;
        private Label lblPrevRaza;
        private Label lblPrevEdad;
        private Label lblPrevSexo;

        private Panel panelPreviewButtons;
        private Button btnEditar;
        private Button btnEliminar;

        private void InitializeComponent()
        {
            panelRoot = new Panel();

            panelTop = new Panel();
            layoutTop = new TableLayoutPanel();

            lblBuscar = new Label();
            txtBuscar = new TextBox();

            lblBuscarPor = new Label();
            comboBuscarPor = new ComboBox();

            lblRaza = new Label();
            comboRaza = new ComboBox();

            lblSexo = new Label();
            comboSexo = new ComboBox();

            lblTemperamento = new Label();
            comboTemperamento = new ComboBox();

            panelContent = new Panel();
            layoutContent = new TableLayoutPanel();

            panelGridCard = new Panel();
            dataGridCaballos = new DataGridView();
            panelBottomLeft = new Panel();
            lblTotal = new Label();

            panelPreviewCard = new Panel();
            lblVista = new Label();
            pictureCaballo = new PictureBox();

            lblPrevNombre = new Label();
            lblPrevRaza = new Label();
            lblPrevEdad = new Label();
            lblPrevSexo = new Label();

            panelPreviewButtons = new Panel();
            btnEditar = new Button();
            btnEliminar = new Button();

            SuspendLayout();

            // Root
            panelRoot.Dock = DockStyle.Fill;
            panelRoot.Padding = new Padding(18, 14, 18, 14);
            panelRoot.BackColor = Color.Transparent;
            panelRoot.Name = "panelRoot";

            // Top bar
            panelTop.Dock = DockStyle.Top;
            panelTop.Height = 74;
            panelTop.Padding = new Padding(14, 10, 14, 10);
            panelTop.BackColor = Color.FromArgb(240, 235, 226);
            panelTop.BorderStyle = BorderStyle.FixedSingle;

            layoutTop.Dock = DockStyle.Fill;
            layoutTop.ColumnCount = 10;
            layoutTop.RowCount = 2;
            layoutTop.RowStyles.Clear();
            layoutTop.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            layoutTop.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            layoutTop.ColumnStyles.Clear();
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Buscar label
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F)); // Buscar box
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // BuscarPor label
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); // BuscarPor combo
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Raza label
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F)); // Raza combo
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Sexo label
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14F)); // Sexo combo
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));  // Temp label
            layoutTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F)); // Temp combo

            // Labels estilo
            Font fLabel = new Font("Georgia", 10.5F, FontStyle.Bold);
            Color cLabel = Color.FromArgb(92, 58, 32);

            lblBuscar.Text = "Buscar:";
            lblBuscar.Font = fLabel;
            lblBuscar.ForeColor = cLabel;
            lblBuscar.TextAlign = ContentAlignment.MiddleLeft;
            lblBuscar.Dock = DockStyle.Fill;

            txtBuscar.Font = new Font("Segoe UI", 11F);
            txtBuscar.Dock = DockStyle.Fill;
            txtBuscar.Margin = new Padding(6, 2, 12, 2);

            lblBuscarPor.Text = "Buscar por:";
            lblBuscarPor.Font = fLabel;
            lblBuscarPor.ForeColor = cLabel;
            lblBuscarPor.TextAlign = ContentAlignment.MiddleLeft;
            lblBuscarPor.Dock = DockStyle.Fill;

            comboBuscarPor.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBuscarPor.Font = new Font("Segoe UI", 11F);
            comboBuscarPor.Dock = DockStyle.Fill;
            comboBuscarPor.Margin = new Padding(6, 2, 12, 2);

            lblRaza.Text = "Raza:";
            lblRaza.Font = fLabel;
            lblRaza.ForeColor = cLabel;
            lblRaza.TextAlign = ContentAlignment.MiddleLeft;
            lblRaza.Dock = DockStyle.Fill;

            comboRaza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRaza.Font = new Font("Segoe UI", 11F);
            comboRaza.Dock = DockStyle.Fill;
            comboRaza.Margin = new Padding(6, 2, 12, 2);

            lblSexo.Text = "Sexo:";
            lblSexo.Font = fLabel;
            lblSexo.ForeColor = cLabel;
            lblSexo.TextAlign = ContentAlignment.MiddleLeft;
            lblSexo.Dock = DockStyle.Fill;

            comboSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSexo.Font = new Font("Segoe UI", 11F);
            comboSexo.Dock = DockStyle.Fill;
            comboSexo.Margin = new Padding(6, 2, 12, 2);

            lblTemperamento.Text = "Temperamento:";
            lblTemperamento.Font = fLabel;
            lblTemperamento.ForeColor = cLabel;
            lblTemperamento.TextAlign = ContentAlignment.MiddleLeft;
            lblTemperamento.Dock = DockStyle.Fill;

            comboTemperamento.DropDownStyle = ComboBoxStyle.DropDownList;
            comboTemperamento.Font = new Font("Segoe UI", 11F);
            comboTemperamento.Dock = DockStyle.Fill;
            comboTemperamento.Margin = new Padding(6, 2, 0, 2);

            // LayoutTop placement (dos filas para que respire en 1366x768)
            layoutTop.Controls.Add(lblBuscar, 0, 0);
            layoutTop.Controls.Add(txtBuscar, 1, 0);

            layoutTop.Controls.Add(lblBuscarPor, 2, 0);
            layoutTop.Controls.Add(comboBuscarPor, 3, 0);

            layoutTop.Controls.Add(lblRaza, 4, 0);
            layoutTop.Controls.Add(comboRaza, 5, 0);

            layoutTop.Controls.Add(lblSexo, 6, 0);
            layoutTop.Controls.Add(comboSexo, 7, 0);

            layoutTop.Controls.Add(lblTemperamento, 8, 0);
            layoutTop.Controls.Add(comboTemperamento, 9, 0);

            // Segunda fila: dejamos que controles crezcan con Dock, sin duplicar
            // (esta fila solo sirve para centrar verticalmente)
            layoutTop.SetRowSpan(lblBuscar, 2);
            layoutTop.SetRowSpan(txtBuscar, 2);
            layoutTop.SetRowSpan(lblBuscarPor, 2);
            layoutTop.SetRowSpan(comboBuscarPor, 2);
            layoutTop.SetRowSpan(lblRaza, 2);
            layoutTop.SetRowSpan(comboRaza, 2);
            layoutTop.SetRowSpan(lblSexo, 2);
            layoutTop.SetRowSpan(comboSexo, 2);
            layoutTop.SetRowSpan(lblTemperamento, 2);
            layoutTop.SetRowSpan(comboTemperamento, 2);

            panelTop.Controls.Add(layoutTop);

            // Content
            panelContent.Dock = DockStyle.Fill;
            panelContent.Padding = new Padding(0, 12, 0, 0);
            panelContent.BackColor = Color.Transparent;

            layoutContent.Dock = DockStyle.Fill;
            layoutContent.ColumnCount = 2;
            layoutContent.RowCount = 1;
            layoutContent.ColumnStyles.Clear();
            layoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72F));
            layoutContent.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28F));
            layoutContent.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Grid card
            panelGridCard.Dock = DockStyle.Fill;
            panelGridCard.Padding = new Padding(14);
            panelGridCard.BackColor = Color.FromArgb(240, 235, 226);
            panelGridCard.BorderStyle = BorderStyle.FixedSingle;

            dataGridCaballos.Dock = DockStyle.Fill;

            panelBottomLeft.Dock = DockStyle.Bottom;
            panelBottomLeft.Height = 36;
            panelBottomLeft.BackColor = Color.Transparent;
            panelBottomLeft.Padding = new Padding(2, 6, 2, 2);

            lblTotal.Text = "Total: 0";
            lblTotal.Font = new Font("Georgia", 11F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(92, 58, 32);
            lblTotal.Dock = DockStyle.Left;

            panelBottomLeft.Controls.Add(lblTotal);

            panelGridCard.Controls.Add(dataGridCaballos);
            panelGridCard.Controls.Add(panelBottomLeft);

            // Preview card
            panelPreviewCard.Dock = DockStyle.Fill;
            panelPreviewCard.Padding = new Padding(14);
            panelPreviewCard.BackColor = Color.FromArgb(240, 235, 226);
            panelPreviewCard.BorderStyle = BorderStyle.FixedSingle;

            lblVista.Text = "Vista previa";
            lblVista.Font = new Font("Georgia", 13F, FontStyle.Bold);
            lblVista.ForeColor = Color.FromArgb(92, 58, 32);
            lblVista.Dock = DockStyle.Top;
            lblVista.Height = 34;

            pictureCaballo.Dock = DockStyle.Top;
            pictureCaballo.Height = 220;
            pictureCaballo.BackColor = Color.FromArgb(225, 215, 200);

            lblPrevNombre.Text = "—";
            lblPrevNombre.Font = new Font("Georgia", 16F, FontStyle.Bold);
            lblPrevNombre.ForeColor = Color.FromArgb(50, 33, 20);
            lblPrevNombre.Dock = DockStyle.Top;
            lblPrevNombre.Padding = new Padding(2, 10, 2, 0);
            lblPrevNombre.Height = 42;

            lblPrevRaza.Text = "—";
            lblPrevRaza.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            lblPrevRaza.ForeColor = Color.FromArgb(60, 40, 25);
            lblPrevRaza.Dock = DockStyle.Top;
            lblPrevRaza.Height = 24;

            lblPrevEdad.Text = "—";
            lblPrevEdad.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            lblPrevEdad.ForeColor = Color.FromArgb(60, 40, 25);
            lblPrevEdad.Dock = DockStyle.Top;
            lblPrevEdad.Height = 24;

            lblPrevSexo.Text = "—";
            lblPrevSexo.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            lblPrevSexo.ForeColor = Color.FromArgb(60, 40, 25);
            lblPrevSexo.Dock = DockStyle.Top;
            lblPrevSexo.Height = 24;

            panelPreviewButtons.Dock = DockStyle.Bottom;
            panelPreviewButtons.Height = 92;
            panelPreviewButtons.Padding = new Padding(0, 10, 0, 0);
            panelPreviewButtons.BackColor = Color.Transparent;

            btnEditar.Text = "Editar";
            btnEditar.Font = new Font("Georgia", 11F, FontStyle.Bold);
            btnEditar.Size = new Size(150, 42);
            btnEditar.Anchor = AnchorStyles.Bottom;
            btnEditar.Click += btnEditar_Click;

            btnEliminar.Text = "Eliminar";
            btnEliminar.Font = new Font("Georgia", 11F, FontStyle.Bold);
            btnEliminar.Size = new Size(150, 42);
            btnEliminar.Anchor = AnchorStyles.Bottom;
            btnEliminar.Click += btnEliminar_Click;

            // Botones centrados
            btnEditar.Location = new Point(0, 0);
            btnEliminar.Location = new Point(0, 0);
            panelPreviewButtons.Resize += (_, __) =>
            {
                int gap = 12;
                int totalW = btnEditar.Width + gap + btnEliminar.Width;
                int startX = (panelPreviewButtons.Width - totalW) / 2;
                int y = 18;

                btnEditar.Location = new Point(startX, y);
                btnEliminar.Location = new Point(startX + btnEditar.Width + gap, y);
            };

            panelPreviewButtons.Controls.Add(btnEditar);
            panelPreviewButtons.Controls.Add(btnEliminar);

            panelPreviewCard.Controls.Add(panelPreviewButtons);
            panelPreviewCard.Controls.Add(lblPrevSexo);
            panelPreviewCard.Controls.Add(lblPrevEdad);
            panelPreviewCard.Controls.Add(lblPrevRaza);
            panelPreviewCard.Controls.Add(lblPrevNombre);
            panelPreviewCard.Controls.Add(pictureCaballo);
            panelPreviewCard.Controls.Add(lblVista);

            layoutContent.Controls.Add(panelGridCard, 0, 0);
            layoutContent.Controls.Add(panelPreviewCard, 1, 0);

            panelContent.Controls.Add(layoutContent);

            panelRoot.Controls.Add(panelContent);
            panelRoot.Controls.Add(panelTop);

            Controls.Add(panelRoot);

            Name = "TurismoVerRegistro";
            Size = new Size(1183, 553);

            ResumeLayout(false);
        }

        #endregion
    }
}
