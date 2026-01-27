namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    partial class cuSopaEnfermedades
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTiempo;

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ListBox lstPalabras;

        private System.Windows.Forms.Panel pnlBottomLeft;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.TableLayoutPanel tblSopa;

        private System.Windows.Forms.Timer tmrJuego;

        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();

            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblLista = new System.Windows.Forms.Label();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.pnlBottomLeft = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();

            this.tblSopa = new System.Windows.Forms.TableLayoutPanel();

            this.tmrJuego = new System.Windows.Forms.Timer(this.components);

            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Height = 60;
            this.pnlTop.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Controls.Add(this.lblTiempo);

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Text = "Sopa de letras: Enfermedades del caballo";
            this.lblTitulo.Location = new System.Drawing.Point(12, 18);

            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTiempo.Text = "Tiempo: 02:00";
            this.lblTiempo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // Se posiciona al final con Resize
            this.pnlTop.Resize += (s, e) =>
            {
                this.lblTiempo.Location = new System.Drawing.Point(this.pnlTop.Width - this.lblTiempo.Width - 20, 18);
            };

            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Width = 260;
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(12);
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Controls.Add(this.lstPalabras);
            this.pnlLeft.Controls.Add(this.pnlBottomLeft);
            this.pnlLeft.Controls.Add(this.lblLista);

            // 
            // lblLista
            // 
            this.lblLista.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLista.Height = 28;
            this.lblLista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblLista.Text = "Encuentra estas palabras:";
            this.lblLista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // pnlBottomLeft
            // 
            this.pnlBottomLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottomLeft.Height = 55;
            this.pnlBottomLeft.BackColor = System.Drawing.Color.White;
            this.pnlBottomLeft.Controls.Add(this.btnReiniciar);
            this.pnlBottomLeft.Controls.Add(this.btnSalir);

            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Width = 110;
            this.btnReiniciar.Height = 35;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.Location = new System.Drawing.Point(12, 10);

            // 
            // btnSalir
            // 
            this.btnSalir.Width = 110;
            this.btnSalir.Height = 35;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Location = new System.Drawing.Point(130, 10);

            // 
            // lstPalabras
            // 
            this.lstPalabras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPalabras.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstPalabras.IntegralHeight = false;

            // 
            // tblSopa
            // 
            this.tblSopa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSopa.BackColor = System.Drawing.Color.White;
            this.tblSopa.Padding = new System.Windows.Forms.Padding(10);
            this.tblSopa.Margin = new System.Windows.Forms.Padding(0);
            this.tblSopa.ColumnCount = 12;
            this.tblSopa.RowCount = 12;

            // Distribución uniforme (12x12)
            this.tblSopa.ColumnStyles.Clear();
            this.tblSopa.RowStyles.Clear();
            for (int i = 0; i < 12; i++)
            {
                this.tblSopa.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F / 12F));
                this.tblSopa.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F / 12F));
            }

            // 
            // tmrJuego
            // 
            this.tmrJuego.Interval = 1000;

            // 
            // cuSopaEnfermedades
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tblSopa);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlTop);
            this.Name = "cuSopaEnfermedades";
            this.Size = new System.Drawing.Size(900, 600);
        }
    }
}
