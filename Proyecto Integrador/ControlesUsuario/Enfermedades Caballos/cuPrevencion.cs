using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class cuPrevencion : UserControl
    {
        private sealed class EnfermedadItem
        {
            public int Id { get; }
            public string Nombre { get; }
            public EnfermedadItem(int id, string nombre) { Id = id; Nombre = nombre; }
            public override string ToString() => $"{Id}: {Nombre}";
        }

        private readonly Dictionary<int, string> _catalogo = new();
        private readonly Dictionary<int, string> _prevencion = new();

        public cuPrevencion()
        {
            InitializeComponent();

            // ===== Tema =====
            SaludTheme.ApplyRoot(this);
            SaludTheme.MakeCard(panelLeft, new Padding(20));
            // panelFill transparente para que se vea el fondo del módulo
            panelFill.BackColor = Color.Transparent;
            panelFill.Padding = new Padding(24);

            SaludTheme.StyleTitle(lblTitulo);
            SaludTheme.StyleLabel(lblEnfermedad);

            SaludTheme.StyleInput(cmb_enfermedades);
            // Caja central (no ocupa TODO, deja ver fondo)
            var card = new Panel
            {
                Dock = DockStyle.None,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Left = 40,
                Top = 30,
                Width = Math.Max(300, panelFill.Width - 80),
                Height = Math.Max(250, panelFill.Height - 60)
            };
            SaludTheme.MakeCard(card, new Padding(18));

            // mover el RichTextBox dentro de la tarjeta
            panelFill.Controls.Clear();
            panelFill.Controls.Add(card);

            txt_prevencion.Dock = DockStyle.Fill;
            txt_prevencion.ReadOnly = true;
            txt_prevencion.BorderStyle = BorderStyle.FixedSingle;
            txt_prevencion.Font = new Font("Segoe UI", 14.5F);
            txt_prevencion.BackColor = Color.FromArgb(250, 250, 250);
            txt_prevencion.ForeColor = SaludTheme.Text;
            card.Controls.Add(txt_prevencion);

            panelFill.Resize += (_, __) =>
            {
                int padX = 80;
                int padY = 60;
                card.Left = padX / 2;
                card.Top = padY / 2;
                card.Width = Math.Max(300, panelFill.ClientSize.Width - padX);
                card.Height = Math.Max(250, panelFill.ClientSize.Height - padY);
            };

            CargarCatalogoBase();
            CargarPrevencionBase();

            LlenarCombo();

            cmb_enfermedades.SelectedIndexChanged += (s, e) => MostrarPrevencionSeleccionada();

            if (cmb_enfermedades.Items.Count > 0)
                cmb_enfermedades.SelectedIndex = 0;
        }

        private void CargarCatalogoBase()
        {
            _catalogo.Clear();
            _catalogo[1] = "Cólico";
            _catalogo[2] = "Laminitis";
            _catalogo[3] = "Tétanos";
            _catalogo[4] = "Influenza";
            _catalogo[5] = "Anemia";
            _catalogo[6] = "Diarrea";
            _catalogo[7] = "Herida";
            _catalogo[8] = "Moquillo";
        }

        private void CargarPrevencionBase()
        {
            _prevencion.Clear();

            _prevencion[1] =
                "CÓLICO (Prevención)\r\n" +
                "• Agua limpia siempre disponible.\r\n" +
                "• Cambios de alimento: graduales (7–10 días).\r\n" +
                "• Evitar exceso de concentrado de golpe.\r\n" +
                "• Desparasitación y control dental periódico.\r\n" +
                "• Ejercicio regular y evitar estrés.";

            _prevencion[2] =
                "LAMINITIS (Prevención)\r\n" +
                "• Controlar dieta (menos azúcar/alfalfa en exceso).\r\n" +
                "• Evitar sobrepeso.\r\n" +
                "• No dejarlo en pasto muy tierno muchas horas.\r\n" +
                "• Herrado/recorte regular del casco.\r\n" +
                "• Si hay cojera o calor en cascos: revisar rápido.";

            _prevencion[3] =
                "TÉTANOS (Prevención)\r\n" +
                "• Vacunación al día.\r\n" +
                "• Limpieza y desinfección de heridas.\r\n" +
                "• Evitar objetos punzantes en establo/potreros.\r\n" +
                "• Avisar al veterinario ante heridas profundas.";

            _prevencion[4] =
                "INFLUENZA (Prevención)\r\n" +
                "• Vacunas según calendario.\r\n" +
                "• Aislar caballos nuevos (cuarentena).\r\n" +
                "• Buena ventilación, evitar hacinamiento.\r\n" +
                "• Limpieza de bebederos y comederos.\r\n" +
                "• Si hay tos/fiebre: separar y consultar.";

            _prevencion[5] =
                "ANEMIA (Prevención)\r\n" +
                "• Buena alimentación y minerales.\r\n" +
                "• Control de parásitos internos/externos.\r\n" +
                "• Revisar heridas/sangrados.\r\n" +
                "• Controles veterinarios si hay debilidad.";

            _prevencion[6] =
                "DIARREA (Prevención)\r\n" +
                "• Agua limpia y alimento de buena calidad.\r\n" +
                "• Evitar cambios bruscos de dieta.\r\n" +
                "• Higiene del establo y desparasitación.\r\n" +
                "• No dar comida en mal estado.\r\n" +
                "• Si dura >24h: veterinario.";

            _prevencion[7] =
                "HERIDAS (Prevención)\r\n" +
                "• Revisar cercas, clavos, alambres, puntas.\r\n" +
                "• Mantener pisos limpios (sin objetos).\r\n" +
                "• Supervisar peleas / separación si es necesario.\r\n" +
                "• Limpieza rápida y seguimiento de cualquier corte.";

            _prevencion[8] =
                "MOQUILLO (Prevención)\r\n" +
                "• Vacunación y control veterinario.\r\n" +
                "• Aislar animales con síntomas.\r\n" +
                "• Higiene y desinfección de áreas.\r\n" +
                "• Evitar estrés y mejorar ventilación.";
        }

        private void LlenarCombo()
        {
            cmb_enfermedades.Items.Clear();

            foreach (var kv in _catalogo.OrderBy(x => x.Key))
                cmb_enfermedades.Items.Add(new EnfermedadItem(kv.Key, kv.Value));
        }

        private void MostrarPrevencionSeleccionada()
        {
            if (cmb_enfermedades.SelectedItem is not EnfermedadItem it)
            {
                txt_prevencion.Text = "";
                return;
            }

            if (_prevencion.TryGetValue(it.Id, out var texto))
                txt_prevencion.Text = texto;
            else
                txt_prevencion.Text = "No hay información de prevención para esta enfermedad.";
        }
    }
}
