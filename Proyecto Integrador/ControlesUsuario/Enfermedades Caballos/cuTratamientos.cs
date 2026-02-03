using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class cuTratamientos : UserControl
    {
        public event EventHandler? SalirRequested;

        // ====== MODELO JSON ======
        private sealed class TratamientoRegistro
        {
            public int Id { get; set; }
            public int EnfermedadId { get; set; }
            public string Tratamiento { get; set; } = "";
        }

        private sealed class EnfermedadItem
        {
            public int Id { get; }
            public string Nombre { get; }
            public EnfermedadItem(int id, string nombre) { Id = id; Nombre = nombre; }
            public override string ToString() => $"{Id}: {Nombre}";
        }

        // ====== RUTAS ======
        private readonly string _rutaJson;

        // ====== DATOS EN MEMORIA ======
        private readonly Dictionary<int, string> _catalogo = new();  // id -> nombre
        private readonly List<TratamientoRegistro> _lista = new();

        public cuTratamientos()
        {
            InitializeComponent();

            _rutaJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Datos\Tratamientos.json");

            // eventos
            this.Load += cuTratamientos_Load;
            btn_guardar.Click += btn_guardar_Click;
            btn_eliminar.Click += btn_eliminar_Click;
            dtgv_tratamiento.CellClick += dtgv_tratamiento_CellClick;

            // opcional: si tienes botón volver en el diseñador, lo conectas así:
            // btnVolver.Click += (s,e)=> SalirRequested?.Invoke(this, EventArgs.Empty);
        }

        private void cuTratamientos_Load(object? sender, EventArgs e)
        {
            CargarCatalogoBase();      // ya no depende de Enfermedades.txt
            CargarCatalogoEnCombo();
            CargarJson();
            PintarTabla();
        }

        // ====== CATÁLOGO RÁPIDO (para no depender de Enfermedades.txt) ======
        // Si después quieres, esto se puede reemplazar por un catálogo editable.
        private void CargarCatalogoBase()
        {
            _catalogo.Clear();

            // básicos
            _catalogo[1] = "Cólico";
            _catalogo[2] = "Laminitis";
            _catalogo[3] = "Tétanos";
            _catalogo[4] = "Influenza";
            _catalogo[5] = "Anemia";
            _catalogo[6] = "Diarrea";
            _catalogo[7] = "Herida";
            _catalogo[8] = "Moquillo";
        }

        private void CargarCatalogoEnCombo()
        {
            cmb_enfermedades.Items.Clear();

            foreach (var kv in _catalogo.OrderBy(k => k.Key))
                cmb_enfermedades.Items.Add(new EnfermedadItem(kv.Key, kv.Value));

            if (cmb_enfermedades.Items.Count > 0)
                cmb_enfermedades.SelectedIndex = 0;
        }

        // ====== JSON IO ======
        private void CargarJson()
        {
            _lista.Clear();

            try
            {
                string dir = Path.GetDirectoryName(_rutaJson) ?? "";
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

                if (!File.Exists(_rutaJson))
                {
                    // crea vacío
                    File.WriteAllText(_rutaJson, "[]");
                    return;
                }

                string json = File.ReadAllText(_rutaJson);
                var items = JsonSerializer.Deserialize<List<TratamientoRegistro>>(json) ?? new List<TratamientoRegistro>();
                _lista.AddRange(items);
            }
            catch
            {
                // si se dañó el json, evita romper
                _lista.Clear();
            }
        }

        private void GuardarJson()
        {
            string dir = Path.GetDirectoryName(_rutaJson) ?? "";
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            var json = JsonSerializer.Serialize(_lista.OrderBy(x => x.Id).ToList(),
                new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(_rutaJson, json);
        }

        // ====== UI ======
        private void PintarTabla()
        {
            dtgv_tratamiento.Rows.Clear();

            foreach (var t in _lista.OrderBy(x => x.Id))
            {
                string nombre = _catalogo.TryGetValue(t.EnfermedadId, out var n) ? n : $"ID {t.EnfermedadId}";
                dtgv_tratamiento.Rows.Add(t.Id, t.EnfermedadId, nombre, t.Tratamiento);
            }

            // si quieres que se vea mejor
            dtgv_tratamiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgv_tratamiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgv_tratamiento.MultiSelect = false;
            dtgv_tratamiento.ReadOnly = true;
            dtgv_tratamiento.RowHeadersVisible = false;
        }

        private int ObtenerIdMax()
        {
            return _lista.Count == 0 ? 0 : _lista.Max(x => x.Id);
        }

        private void btn_guardar_Click(object? sender, EventArgs e)
        {
            string texto = txt_tratamiento.Text.Trim();
            if (texto.Length == 0)
            {
                MessageBox.Show("Rellene el tratamiento");
                return;
            }
            if (texto.Length > 120)
            {
                MessageBox.Show("Tratamiento muy largo (máx 120 caracteres).");
                return;
            }

            if (cmb_enfermedades.SelectedItem is not EnfermedadItem enf)
            {
                MessageBox.Show("Selecciona una enfermedad.");
                return;
            }

            bool editar = txt_id.Text.Trim().Length > 0;

            if (editar)
            {
                if (!int.TryParse(txt_id.Text, out int idEdit)) return;

                var reg = _lista.FirstOrDefault(x => x.Id == idEdit);
                if (reg == null) return;

                reg.EnfermedadId = enf.Id;
                reg.Tratamiento = texto;
            }
            else
            {
                var nuevo = new TratamientoRegistro
                {
                    Id = ObtenerIdMax() + 1,
                    EnfermedadId = enf.Id,
                    Tratamiento = texto
                };
                _lista.Add(nuevo);
            }

            GuardarJson();
            PintarTabla();

            txt_id.Text = "";
            txt_tratamiento.Text = "";
        }

        private void btn_eliminar_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txt_id.Text, out int id)) return;

            var r = MessageBox.Show("¿Eliminar este tratamiento?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r != DialogResult.Yes) return;

            _lista.RemoveAll(x => x.Id == id);

            GuardarJson();
            PintarTabla();

            txt_id.Text = "";
            txt_tratamiento.Text = "";
        }

        private void dtgv_tratamiento_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            string id = dtgv_tratamiento.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            string enfId = dtgv_tratamiento.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
            string tratamiento = dtgv_tratamiento.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";

            txt_id.Text = id;
            txt_tratamiento.Text = tratamiento;

            // seleccionar en el combo la enfermedad del registro
            if (int.TryParse(enfId, out int enfIdInt))
            {
                for (int i = 0; i < cmb_enfermedades.Items.Count; i++)
                {
                    if (cmb_enfermedades.Items[i] is EnfermedadItem it && it.Id == enfIdInt)
                    {
                        cmb_enfermedades.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
    }
}
