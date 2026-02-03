using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.A_Turismo
{
    public partial class TurismoAgendaCalendario : UserControl
    {
        // === DATOS (esto es lo que hace que NO se borre al cambiar de mes) ===
        private readonly Dictionary<DateTime, List<AgendaItem>> _agenda = new();

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public List<string> Caballos { get; set; } = new List<string>();

        private TableLayoutPanel tabla;
        private Label lblMes;
        private DateTime mesActual;

        // Contenedor donde se renderizan los items por día
        private Dictionary<DateTime, FlowLayoutPanel> dias = new();

        public TurismoAgendaCalendario()
        {
            Dock = DockStyle.Fill;
            BackColor = Color.White;

            var contenedor = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2
            };
            contenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, 70));  // MÁS ALTO
            contenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            Controls.Add(contenedor);

            // ENCABEZADO
            var header = new Panel { Dock = DockStyle.Fill };
            contenedor.Controls.Add(header, 0, 0);

            var btnAnt = new Button
            {
                Text = "◀",
                Width = 50,
                Height = 40,
                Left = 10,
                Top = 15,
                Font = new Font("Segoe UI", 12f, FontStyle.Bold)
            };

            var btnSig = new Button
            {
                Text = "▶",
                Width = 50,
                Height = 40,
                Top = 15,
                Font = new Font("Segoe UI", 12f, FontStyle.Bold)
            };

            lblMes = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 16f, FontStyle.Bold) // MÁS GRANDE
            };

            header.Controls.Add(btnAnt);
            header.Controls.Add(btnSig);
            header.Controls.Add(lblMes);

            header.Resize += (s, e) =>
                btnSig.Left = header.Width - btnSig.Width - 10;

            btnAnt.Click += (s, e) => CargarMes(mesActual.AddMonths(-1));
            btnSig.Click += (s, e) => CargarMes(mesActual.AddMonths(1));

            // TABLA
            tabla = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 7,
                RowCount = 7,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            for (int i = 0; i < 7; i++)
                tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / 7));

            tabla.RowStyles.Add(new RowStyle(SizeType.Absolute, 42)); // encabezado días MÁS ALTO
            for (int i = 1; i < 7; i++)
                tabla.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / 6));

            contenedor.Controls.Add(tabla, 0, 1);

            string[] diasSemana = { "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb", "Dom" };
            for (int i = 0; i < 7; i++)
            {
                tabla.Controls.Add(new Label
                {
                    Text = diasSemana[i],
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 13f, FontStyle.Bold) // MÁS GRANDE
                }, i, 0);
            }

            CargarMes(DateTime.Today);
        }

        private void CargarMes(DateTime fecha)
        {
            mesActual = new DateTime(fecha.Year, fecha.Month, 1);
            lblMes.Text = mesActual.ToString("MMMM yyyy").ToUpper();

            // borrar celdas (menos encabezado)
            for (int i = tabla.Controls.Count - 1; i >= 7; i--)
                tabla.Controls.RemoveAt(i);

            dias.Clear();

            int inicio = (int)mesActual.DayOfWeek;
            inicio = inicio == 0 ? 6 : inicio - 1;
            DateTime d = mesActual.AddDays(-inicio);

            for (int f = 1; f <= 6; f++)
            {
                for (int c = 0; c < 7; c++)
                {
                    DateTime fechaDia = d.Date;

                    var panel = new Panel
                    {
                        Dock = DockStyle.Fill,
                        Padding = new Padding(8) // MÁS ESPACIO
                    };

                    var lbl = new Label
                    {
                        Text = d.Day.ToString(),
                        Font = new Font("Segoe UI", 13f, FontStyle.Bold), // MÁS GRANDE
                        ForeColor = d.Month == mesActual.Month ? Color.Black : Color.Gray,
                        Dock = DockStyle.Top,
                        Height = 28
                    };

                    var lista = new FlowLayoutPanel
                    {
                        Dock = DockStyle.Fill,
                        FlowDirection = FlowDirection.TopDown,
                        WrapContents = false,
                        AutoScroll = true,
                        Padding = new Padding(0),
                        Margin = new Padding(0)
                    };

                    panel.Controls.Add(lista);
                    panel.Controls.Add(lbl);

                    // click en celda -> abrir mini ventana
                    panel.Click += (s, e) => AbrirRegistro(fechaDia);
                    lista.Click += (s, e) => AbrirRegistro(fechaDia);
                    lbl.Click += (s, e) => AbrirRegistro(fechaDia);

                    tabla.Controls.Add(panel, c, f);
                    dias[fechaDia] = lista;

                    // repintar lo guardado para ese día
                    RenderDia(fechaDia);

                    d = d.AddDays(1);
                }
            }
        }

        // === MINI VENTANA PARA REGISTRAR ===
        private void AbrirRegistro(DateTime fecha)
        {
            if (Caballos == null || Caballos.Count == 0)
            {
                MessageBox.Show("No hay caballos cargados todavía.", "Agenda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var existentes = GetItems(fecha);

            using (var frm = new FrmRegistrar(Caballos, existentes))
            {
                frm.StartPosition = FormStartPosition.CenterParent;

                var r = frm.ShowDialog(this);
                if (r != DialogResult.OK) return;

                if (frm.EliminarIndex >= 0)
                {
                    if (existentes.Count > frm.EliminarIndex)
                    {
                        existentes.RemoveAt(frm.EliminarIndex);
                        SetItems(fecha, existentes);
                        RenderDia(fecha);
                    }
                    return;
                }

                var item = new AgendaItem
                {
                    Fecha = fecha.Date,
                    Caballo = frm.CaballoSeleccionado,
                    Actividad = frm.ActividadSeleccionada
                };

                existentes.Add(item);
                SetItems(fecha, existentes);
                RenderDia(fecha);
            }
        }

        // === RENDER ===
        private void RenderDia(DateTime fecha)
        {
            if (!dias.ContainsKey(fecha.Date)) return;

            var cont = dias[fecha.Date];
            cont.SuspendLayout();
            cont.Controls.Clear();

            var items = GetItems(fecha.Date);

            foreach (var it in items)
            {
                var lbl = new Label
                {
                    AutoSize = false,
                    Height = 34,                 // MÁS ALTO
                    Width = cont.Width - 10,      // MÁS ANCHO
                    Text = $"{ActividadEmoji(it.Actividad)} {it.Caballo}",
                    Font = new Font("Segoe UI", 13f, FontStyle.Bold), // MÁS GRANDE Y NEGRITA
                    ForeColor = Color.Black,
                    BackColor = Color.Transparent,
                    Padding = new Padding(2, 2, 2, 2)
                };

                lbl.MouseEnter += (s, e) => lbl.BackColor = Color.FromArgb(240, 240, 240);
                lbl.MouseLeave += (s, e) => lbl.BackColor = Color.Transparent;

                cont.Controls.Add(lbl);
            }

            cont.ResumeLayout();
        }

        // === CRUD en memoria ===
        private List<AgendaItem> GetItems(DateTime fecha)
        {
            fecha = fecha.Date;
            if (!_agenda.ContainsKey(fecha))
                _agenda[fecha] = new List<AgendaItem>();
            return _agenda[fecha];
        }

        private void SetItems(DateTime fecha, List<AgendaItem> items)
        {
            fecha = fecha.Date;
            _agenda[fecha] = items;
        }

        // === ACTIVIDADES ===
        public enum TipoActividad
        {
            Alimentacion,
            Salida,
            Turismo,
            Limpieza,
            Veterinario,
            Entrenamiento
        }

        private string ActividadEmoji(TipoActividad t)
        {
            return t switch
            {
                TipoActividad.Alimentacion => "🍽️",
                TipoActividad.Salida => "🚶",
                TipoActividad.Turismo => "🗺️",
                TipoActividad.Limpieza => "🧼",
                TipoActividad.Veterinario => "💉",
                TipoActividad.Entrenamiento => "🏇",
                _ => "✅"
            };
        }

        public class AgendaItem
        {
            public DateTime Fecha { get; set; }
            public string Caballo { get; set; }
            public TipoActividad Actividad { get; set; }
        }

        // === FORM MINI INTERNO ===
        private class FrmRegistrar : Form
        {
            ComboBox cbCaballo;
            ComboBox cbActividad;
            ListBox lstHoy;
            Button btnGuardar;
            Button btnBorrar;
            Button btnCerrar;

            public string CaballoSeleccionado => cbCaballo.SelectedItem?.ToString();
            public TipoActividad ActividadSeleccionada => (TipoActividad)cbActividad.SelectedItem;

            public int EliminarIndex { get; private set; } = -1;

            public FrmRegistrar(List<string> caballos, List<AgendaItem> existentes)
            {
                Text = "Registrar actividad";
                FormBorderStyle = FormBorderStyle.FixedDialog;
                MaximizeBox = false;
                MinimizeBox = false;
                Width = 460;
                Height = 470;

                Font = new Font("Segoe UI", 12f, FontStyle.Regular); // MÁS GRANDE

                var lbl1 = new Label { Text = "Caballo:", Left = 14, Top = 14, Width = 150 };
                cbCaballo = new ComboBox { Left = 14, Top = 44, Width = 410, DropDownStyle = ComboBoxStyle.DropDownList };
                cbCaballo.Font = new Font("Segoe UI", 12f, FontStyle.Regular);
                cbCaballo.Items.AddRange(caballos.Cast<object>().ToArray());
                cbCaballo.SelectedIndex = 0;

                var lbl2 = new Label { Text = "Actividad:", Left = 14, Top = 86, Width = 150 };
                cbActividad = new ComboBox { Left = 14, Top = 116, Width = 410, DropDownStyle = ComboBoxStyle.DropDownList };
                cbActividad.Font = new Font("Segoe UI", 12f, FontStyle.Regular);
                cbActividad.Items.AddRange(Enum.GetValues(typeof(TipoActividad)).Cast<object>().ToArray());
                cbActividad.SelectedIndex = 0;

                var lbl3 = new Label { Text = "Registrado en este día:", Left = 14, Top = 160, Width = 250 };
                lstHoy = new ListBox { Left = 14, Top = 190, Width = 410, Height = 170 };
                lstHoy.Font = new Font("Segoe UI", 12f, FontStyle.Regular);

                RefrescarLista(existentes);

                btnGuardar = new Button { Text = "Guardar", Left = 14, Top = 375, Width = 130, Height = 40 };
                btnBorrar = new Button { Text = "Borrar", Left = 154, Top = 375, Width = 130, Height = 40 };
                btnCerrar = new Button { Text = "Cerrar", Left = 294, Top = 375, Width = 130, Height = 40 };

                btnGuardar.Click += (s, e) =>
                {
                    if (cbCaballo.SelectedItem == null || cbActividad.SelectedItem == null)
                    {
                        MessageBox.Show("Selecciona caballo y actividad.");
                        return;
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                };

                btnBorrar.Click += (s, e) =>
                {
                    if (lstHoy.SelectedIndex < 0)
                    {
                        MessageBox.Show("Selecciona algo de la lista para borrar.");
                        return;
                    }
                    EliminarIndex = lstHoy.SelectedIndex;
                    DialogResult = DialogResult.OK;
                    Close();
                };

                btnCerrar.Click += (s, e) =>
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                };

                Controls.Add(lbl1);
                Controls.Add(cbCaballo);
                Controls.Add(lbl2);
                Controls.Add(cbActividad);
                Controls.Add(lbl3);
                Controls.Add(lstHoy);
                Controls.Add(btnGuardar);
                Controls.Add(btnBorrar);
                Controls.Add(btnCerrar);
            }

            private void RefrescarLista(List<AgendaItem> existentes)
            {
                lstHoy.Items.Clear();
                foreach (var it in existentes)
                    lstHoy.Items.Add($"{it.Caballo} - {it.Actividad}");
            }
        }
    }
}
