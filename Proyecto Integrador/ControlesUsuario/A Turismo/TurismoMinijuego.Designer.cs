// TurismoMinijuego.Designer.cs  (REEMPLAZA COMPLETO)
// ✅ Scroll inteligente (auto on/off)
// ✅ Modal real (overlay arriba de TODO, no se recorta)
// ✅ Timer ambigüedad corregida en el .cs (aquí solo diseñador)

namespace Proyecto_Integrador.ControlesUsuario
{
    partial class TurismoMinijuego
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        // ✅ Scroll host (contenedor con AutoScroll)
        private System.Windows.Forms.Panel scrollHost;

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.TableLayoutPanel root;

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;

        private System.Windows.Forms.TableLayoutPanel topInfo;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblIntentos;

        private System.Windows.Forms.TableLayoutPanel tableSlots;
        private System.Windows.Forms.Panel slot1;
        private System.Windows.Forms.Panel slot2;
        private System.Windows.Forms.Panel slot3;
        private System.Windows.Forms.Panel slot4;
        private System.Windows.Forms.PictureBox arrow1;
        private System.Windows.Forms.PictureBox arrow2;
        private System.Windows.Forms.PictureBox arrow3;

        private System.Windows.Forms.TableLayoutPanel tableSlotLabels;
        private System.Windows.Forms.Label lblSlot1;
        private System.Windows.Forms.Label lblSlot2;
        private System.Windows.Forms.Label lblSlot3;
        private System.Windows.Forms.Label lblSlot4;

        private System.Windows.Forms.Panel panelSeparador;
        private System.Windows.Forms.Label lblSeparador;

        private System.Windows.Forms.Panel panelFinal;
        private System.Windows.Forms.TableLayoutPanel finalLayout;

        private System.Windows.Forms.TableLayoutPanel tableCards;
        private System.Windows.Forms.PictureBox card1;
        private System.Windows.Forms.PictureBox card2;
        private System.Windows.Forms.PictureBox card3;
        private System.Windows.Forms.PictureBox card4;

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.TableLayoutPanel tableBtns;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnAceptar;

        // ✅ Modal overlay (arriba del scroll)
        private System.Windows.Forms.Panel overlay;
        private System.Windows.Forms.Panel modal;
        private System.Windows.Forms.Label lblModalTitulo;
        private System.Windows.Forms.Label lblModalTexto;
        private System.Windows.Forms.Button btnEmpezar;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.scrollHost = new System.Windows.Forms.Panel();

            this.panelCard = new System.Windows.Forms.Panel();
            this.root = new System.Windows.Forms.TableLayoutPanel();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();

            this.topInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();

            this.tableSlots = new System.Windows.Forms.TableLayoutPanel();
            this.slot1 = new System.Windows.Forms.Panel();
            this.slot2 = new System.Windows.Forms.Panel();
            this.slot3 = new System.Windows.Forms.Panel();
            this.slot4 = new System.Windows.Forms.Panel();
            this.arrow1 = new System.Windows.Forms.PictureBox();
            this.arrow2 = new System.Windows.Forms.PictureBox();
            this.arrow3 = new System.Windows.Forms.PictureBox();

            this.tableSlotLabels = new System.Windows.Forms.TableLayoutPanel();
            this.lblSlot1 = new System.Windows.Forms.Label();
            this.lblSlot2 = new System.Windows.Forms.Label();
            this.lblSlot3 = new System.Windows.Forms.Label();
            this.lblSlot4 = new System.Windows.Forms.Label();

            this.panelSeparador = new System.Windows.Forms.Panel();
            this.lblSeparador = new System.Windows.Forms.Label();

            this.panelFinal = new System.Windows.Forms.Panel();
            this.finalLayout = new System.Windows.Forms.TableLayoutPanel();

            this.tableCards = new System.Windows.Forms.TableLayoutPanel();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();

            this.panelBottom = new System.Windows.Forms.Panel();
            this.tableBtns = new System.Windows.Forms.TableLayoutPanel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();

            this.overlay = new System.Windows.Forms.Panel();
            this.modal = new System.Windows.Forms.Panel();
            this.lblModalTitulo = new System.Windows.Forms.Label();
            this.lblModalTexto = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();

            this.SuspendLayout();

            // ===== UserControl =====
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Integrador.Properties.Resources.fondoestablo11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoubleBuffered = true;
            this.Name = "TurismoMinijuego";
            this.Size = new System.Drawing.Size(1100, 650);

            // ===== scrollHost =====
            this.scrollHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollHost.BackColor = System.Drawing.Color.Transparent;
            this.scrollHost.AutoScroll = false; // ✅ se enciende/apaga por código
            this.scrollHost.Margin = new System.Windows.Forms.Padding(0);
            this.Controls.Add(this.scrollHost);

            // ===== panelCard =====
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(245, 238, 228);
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // ✅ Importantísimo para scroll sin “aplastar”
            this.panelCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCard.AutoSize = true;
            this.panelCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.panelCard.Padding = new System.Windows.Forms.Padding(26, 16, 26, 18);
            this.panelCard.Margin = new System.Windows.Forms.Padding(0);

            this.scrollHost.Controls.Add(this.panelCard);

            // ===== root =====
            this.root.Dock = System.Windows.Forms.DockStyle.Top;
            this.root.AutoSize = true;
            this.root.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            this.root.ColumnCount = 1;
            this.root.RowCount = 6;
            this.root.BackColor = System.Drawing.Color.Transparent;

            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 260F)); // ✅ base; luego se ajusta por código

            this.panelCard.Controls.Add(this.root);

            // ===== Header =====
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader.BackgroundImage = global::Proyecto_Integrador.Properties.Resources.madera_1;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.root.Controls.Add(this.panelHeader, 0, 0);

            this.lblHeaderTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeaderTitle.Text = "MINIJUEGO: ORDENA LAS ACTIVIDADES";
            this.lblHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(245, 235, 220);
            this.lblHeaderTitle.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblHeaderTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelHeader.Controls.Add(this.lblHeaderTitle);

            // ===== topInfo =====
            this.topInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topInfo.BackColor = System.Drawing.Color.Transparent;
            this.topInfo.ColumnCount = 3;
            this.topInfo.RowCount = 2;

            this.topInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.topInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));

            this.topInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.topInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));

            this.topInfo.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.root.Controls.Add(this.topInfo, 0, 1);

            this.lblNivel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNivel.Text = "Nivel: 1/4  •  Grupo: ---";
            this.lblNivel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNivel.ForeColor = System.Drawing.Color.FromArgb(70, 50, 35);
            this.lblNivel.Font = new System.Drawing.Font("Georgia", 12F);
            this.topInfo.Controls.Add(this.lblNivel, 0, 0);
            this.topInfo.SetRowSpan(this.lblNivel, 2);

            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Text = "Minijuego del Módulo de Turismo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(70, 50, 35);
            this.lblTitulo.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Bold);
            this.topInfo.Controls.Add(this.lblTitulo, 1, 0);

            this.lblSubtitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtitulo.Text = "Selecciona una carta y colócala arriba en el orden correcto.";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(95, 75, 60);
            this.lblSubtitulo.Font = new System.Drawing.Font("Georgia", 12F);
            this.topInfo.Controls.Add(this.lblSubtitulo, 1, 1);

            this.lblTiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTiempo.Text = "Tiempo: 00:30";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(60, 40, 28);
            this.lblTiempo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.topInfo.Controls.Add(this.lblTiempo, 2, 0);

            this.lblIntentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIntentos.Text = "Intentos: ♥ ♥ ♥";
            this.lblIntentos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblIntentos.ForeColor = System.Drawing.Color.FromArgb(165, 40, 40);
            this.lblIntentos.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.topInfo.Controls.Add(this.lblIntentos, 2, 1);

            // ===== Slots =====
            this.tableSlots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSlots.BackColor = System.Drawing.Color.Transparent;
            this.tableSlots.ColumnCount = 7;
            this.tableSlots.RowCount = 1;
            this.tableSlots.Margin = new System.Windows.Forms.Padding(0);

            this.tableSlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableSlots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            this.root.Controls.Add(this.tableSlots, 0, 2);

            var slotBack = System.Drawing.Color.FromArgb(230, 223, 212);

            System.Windows.Forms.Panel[] slots = { this.slot1, this.slot2, this.slot3, this.slot4 };
            foreach (var s in slots)
            {
                s.BackColor = slotBack;
                s.Margin = new System.Windows.Forms.Padding(12, 20, 12, 16);
                s.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D; // ✅ efecto profundidad
            }

            this.arrow1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrow2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arrow3.Dock = System.Windows.Forms.DockStyle.Fill;

            this.arrow1.Image = global::Proyecto_Integrador.Properties.Resources.flecha;
            this.arrow2.Image = global::Proyecto_Integrador.Properties.Resources.flecha;
            this.arrow3.Image = global::Proyecto_Integrador.Properties.Resources.flecha;

            this.arrow1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.arrow3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.tableSlots.Controls.Add(this.slot1, 0, 0);
            this.tableSlots.Controls.Add(this.arrow1, 1, 0);
            this.tableSlots.Controls.Add(this.slot2, 2, 0);
            this.tableSlots.Controls.Add(this.arrow2, 3, 0);
            this.tableSlots.Controls.Add(this.slot3, 4, 0);
            this.tableSlots.Controls.Add(this.arrow3, 5, 0);
            this.tableSlots.Controls.Add(this.slot4, 6, 0);

            // ===== Labels slots =====
            this.tableSlotLabels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableSlotLabels.BackColor = System.Drawing.Color.Transparent;
            this.tableSlotLabels.ColumnCount = 4;
            this.tableSlotLabels.RowCount = 1;
            this.tableSlotLabels.Margin = new System.Windows.Forms.Padding(0);
            this.tableSlotLabels.Padding = new System.Windows.Forms.Padding(0);

            this.tableSlotLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSlotLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSlotLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableSlotLabels.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));

            this.root.Controls.Add(this.tableSlotLabels, 0, 3);

            System.Windows.Forms.Label[] slotLbls = { this.lblSlot1, this.lblSlot2, this.lblSlot3, this.lblSlot4 };
            foreach (var l in slotLbls)
            {
                l.Dock = System.Windows.Forms.DockStyle.Fill;
                l.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                l.ForeColor = System.Drawing.Color.FromArgb(95, 75, 60);
                l.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Italic);
                l.Text = "Actividad";
                l.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0); // ✅ centrado real
            }

            this.tableSlotLabels.Controls.Add(this.lblSlot1, 0, 0);
            this.tableSlotLabels.Controls.Add(this.lblSlot2, 1, 0);
            this.tableSlotLabels.Controls.Add(this.lblSlot3, 2, 0);
            this.tableSlotLabels.Controls.Add(this.lblSlot4, 3, 0);

            // ===== Separador =====
            this.panelSeparador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSeparador.BackColor = System.Drawing.Color.Transparent;
            this.panelSeparador.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.root.Controls.Add(this.panelSeparador, 0, 4);

            this.lblSeparador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSeparador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblSeparador.ForeColor = System.Drawing.Color.FromArgb(95, 75, 60);
            this.lblSeparador.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblSeparador.Text = "--------------------  Ordena las cartas en el orden correcto.  --------------------";
            this.panelSeparador.Controls.Add(this.lblSeparador);

            // ===== panelFinal =====
            this.panelFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFinal.BackColor = System.Drawing.Color.Transparent;
            this.root.Controls.Add(this.panelFinal, 0, 5);

            // ===== finalLayout (cartas + botones) =====
            this.finalLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.finalLayout.BackColor = System.Drawing.Color.Transparent;
            this.finalLayout.ColumnCount = 1;
            this.finalLayout.RowCount = 2;
            this.finalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.finalLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.panelFinal.Controls.Add(this.finalLayout);

            // ===== tableCards =====
            this.tableCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableCards.BackColor = System.Drawing.Color.Transparent;
            this.tableCards.ColumnCount = 4;
            this.tableCards.RowCount = 1;
            this.tableCards.Padding = new System.Windows.Forms.Padding(8, 8, 8, 6);
            this.tableCards.Margin = new System.Windows.Forms.Padding(0);
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.finalLayout.Controls.Add(this.tableCards, 0, 0);

            System.Windows.Forms.PictureBox[] cards = { this.card1, this.card2, this.card3, this.card4 };
            foreach (var c in cards)
            {
                c.Dock = System.Windows.Forms.DockStyle.Fill;
                c.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
                c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                c.BackColor = System.Drawing.Color.FromArgb(242, 236, 226);
                c.BorderStyle = System.Windows.Forms.BorderStyle.None; // ✅ sin marco negro
                c.Image = null;
                c.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            this.tableCards.Controls.Add(this.card1, 0, 0);
            this.tableCards.Controls.Add(this.card2, 1, 0);
            this.tableCards.Controls.Add(this.card3, 2, 0);
            this.tableCards.Controls.Add(this.card4, 3, 0);

            // ===== panelBottom =====
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottom.BackColor = System.Drawing.Color.Transparent;
            this.panelBottom.Padding = new System.Windows.Forms.Padding(10, 6, 10, 12);
            this.finalLayout.Controls.Add(this.panelBottom, 0, 1);

            this.tableBtns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableBtns.BackColor = System.Drawing.Color.Transparent;

            this.tableBtns.ColumnCount = 4;
            this.tableBtns.RowCount = 1;
            this.tableBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
            this.tableBtns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBottom.Controls.Add(this.tableBtns);

            System.Windows.Forms.Button[] btns = { this.btnReiniciar, this.btnAceptar };
            foreach (var b in btns)
            {
                b.Dock = System.Windows.Forms.DockStyle.Fill;
                b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = System.Drawing.Color.Transparent;
                b.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                b.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold);
                b.ForeColor = System.Drawing.Color.FromArgb(245, 235, 220);
                b.Cursor = System.Windows.Forms.Cursors.Hand;
                b.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
                b.UseVisualStyleBackColor = false;
            }

            this.btnReiniciar.Text = "Reiniciar";
            this.btnAceptar.Text = "Aceptar";
            this.btnReiniciar.BackgroundImage = global::Proyecto_Integrador.Properties.Resources.btn_amarillo;
            this.btnAceptar.BackgroundImage = global::Proyecto_Integrador.Properties.Resources.btn_verde;

            this.tableBtns.Controls.Add(this.btnReiniciar, 1, 0);
            this.tableBtns.Controls.Add(this.btnAceptar, 2, 0);

            // ===== Overlay modal (ARRIBA del scroll) =====
            this.overlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overlay.BackColor = System.Drawing.Color.FromArgb(150, 0, 0, 0);
            this.overlay.Visible = true;
            this.overlay.Margin = new System.Windows.Forms.Padding(0);

            // ✅ overlay va directo al UserControl (no dentro del scroll)
            this.Controls.Add(this.overlay);
            this.overlay.BringToFront();

            this.modal.Size = new System.Drawing.Size(560, 320);
            this.modal.BackColor = System.Drawing.Color.FromArgb(245, 238, 228);
            this.modal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblModalTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModalTitulo.Height = 60;
            this.lblModalTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblModalTitulo.Text = "Cómo jugar";
            this.lblModalTitulo.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Bold);
            this.lblModalTitulo.ForeColor = System.Drawing.Color.FromArgb(70, 50, 35);

            this.lblModalTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModalTexto.Padding = new System.Windows.Forms.Padding(30, 10, 30, 10);
            this.lblModalTexto.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblModalTexto.Font = new System.Drawing.Font("Georgia", 12F);
            this.lblModalTexto.ForeColor = System.Drawing.Color.FromArgb(95, 75, 60);
            this.lblModalTexto.Text =
                "• Selecciona una carta de abajo.\n" +
                "• Luego toca un cuadro de arriba para colocarla.\n" +
                "• Ordena las actividades en el orden correcto.\n" +
                "• Si fallas, pierdes un intento y las cartas vuelven abajo.\n" +
                "• Son 4 niveles y el grupo cambia en cada uno.";

            this.btnEmpezar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEmpezar.Height = 54;
            this.btnEmpezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpezar.FlatAppearance.BorderSize = 0;
            this.btnEmpezar.BackgroundImage = global::Proyecto_Integrador.Properties.Resources.btn_azul;
            this.btnEmpezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpezar.Font = new System.Drawing.Font("Georgia", 13F, System.Drawing.FontStyle.Bold);
            this.btnEmpezar.ForeColor = System.Drawing.Color.FromArgb(245, 235, 220);
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.Cursor = System.Windows.Forms.Cursors.Hand;

            this.modal.Controls.Add(this.lblModalTexto);
            this.modal.Controls.Add(this.btnEmpezar);
            this.modal.Controls.Add(this.lblModalTitulo);
            this.overlay.Controls.Add(this.modal);

            ((System.ComponentModel.ISupportInitialize)(this.arrow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrow3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();

            this.ResumeLayout(false);
        }

        #endregion
    }
}
