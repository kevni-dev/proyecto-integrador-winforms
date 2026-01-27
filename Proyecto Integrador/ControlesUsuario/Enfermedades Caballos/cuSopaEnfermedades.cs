using Proyecto_Integrador.Archivo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.Enfermedades_Caballos
{
    public partial class cuSopaEnfermedades : UserControl
    {
        public event EventHandler? SalirRequested;

        private const int GridSize = 12;

        private readonly Button[,] _cells = new Button[GridSize, GridSize];
        private readonly char[,] _letters = new char[GridSize, GridSize];

        private readonly HashSet<string> _found = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        private List<string> _words = new List<string>();

        private Point? _startCell = null;

        private TimeSpan _timeLeft;
        private readonly TimeSpan _timeLimit = TimeSpan.FromMinutes(2);

        private readonly Random _rng = new Random();

        // ✅ Control de timer y ventanas
        private bool _timerStarted = false;        // empieza en el primer click
        private bool _timeDialogOpen = false;      // evita múltiples MessageBox
        private bool _isExiting = false;           // si saliste, no muestres nada

        public cuSopaEnfermedades()
        {
            InitializeComponent();

            btnReiniciar.Click += btnReiniciar_Click;
            btnSalir.Click += btnSalir_Click;

            tmrJuego.Tick += tmrJuego_Tick;

            CrearGridEnTableLayout();
            StartNewGame();
        }

        private void CrearGridEnTableLayout()
        {
            tblSopa.Controls.Clear();

            tblSopa.ColumnCount = GridSize;
            tblSopa.RowCount = GridSize;
            tblSopa.ColumnStyles.Clear();
            tblSopa.RowStyles.Clear();

            for (int i = 0; i < GridSize; i++)
            {
                tblSopa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / GridSize));
                tblSopa.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / GridSize));
            }

            for (int r = 0; r < GridSize; r++)
            {
                for (int c = 0; c < GridSize; c++)
                {
                    var b = new Button
                    {
                        Dock = DockStyle.Fill,
                        Margin = new Padding(1),
                        Padding = new Padding(0),
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        Tag = new Point(r, c),
                        Text = ""
                    };
                    b.FlatAppearance.BorderSize = 1;

                    b.Click += Cell_Click;

                    _cells[r, c] = b;
                    tblSopa.Controls.Add(b, c, r);
                }
            }
        }

        private void StartNewGame()
        {
            // ✅ resetea todo
            _isExiting = false;
            _timeDialogOpen = false;

            tmrJuego.Stop();
            _timerStarted = false;   // ✅ el timer NO inicia aún

            _found.Clear();
            _startCell = null;

            _words = LoadWordsFromEnfermedadesTxt()
                        .Distinct(StringComparer.OrdinalIgnoreCase)
                        .Select(NormalizeWord)
                        .Where(w => w.Length >= 4 && w.Length <= GridSize)
                        .Take(10)
                        .ToList();

            if (_words.Count < 6)
            {
                _words = new List<string>
                {
                    "COLICO",
                    "INFLUENZA",
                    "TETANOS",
                    "LAMINITIS",
                    "MOQUILLO",
                    "ANEMIA",
                    "DIARREA",
                    "HERIDA"
                }
                .Select(NormalizeWord)
                .Where(w => w.Length >= 4 && w.Length <= GridSize)
                .Take(10)
                .ToList();
            }

            FillEmptyLetters();
            PlaceWords();
            RenderGrid();

            lstPalabras.Items.Clear();
            foreach (var w in _words)
                lstPalabras.Items.Add(w);

            _timeLeft = _timeLimit;
            UpdateTimeLabel(); // muestra 02:00 pero sin correr

            // ✅ el timer se inicia en el primer click, no aquí
        }

        private void btnReiniciar_Click(object? sender, EventArgs e)
        {
            StartNewGame();
        }

        private void btnSalir_Click(object? sender, EventArgs e)
        {
            // ✅ detener todo al salir
            _isExiting = true;
            _timeDialogOpen = false;

            tmrJuego.Stop();
            _timerStarted = false;

            SalirRequested?.Invoke(this, EventArgs.Empty);
        }

        private void StartTimerIfNeeded()
        {
            if (_isExiting) return;
            if (_timerStarted) return;

            _timerStarted = true;
            tmrJuego.Start();
        }

        private void tmrJuego_Tick(object? sender, EventArgs e)
        {
            if (_isExiting) return;        // ✅ si ya saliste, ignora
            if (_timeDialogOpen) return;   // ✅ si ya hay diálogo, ignora

            _timeLeft = _timeLeft.Subtract(TimeSpan.FromSeconds(1));

            if (_timeLeft <= TimeSpan.Zero)
            {
                tmrJuego.Stop();
                _timeLeft = TimeSpan.Zero;
                UpdateTimeLabel();

                // ✅ evita múltiples ventanas
                _timeDialogOpen = true;

                var res = MessageBox.Show(
                    "Se acabó el tiempo 😢\n¿Quieres reiniciar?",
                    "Tiempo finalizado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                _timeDialogOpen = false;

                if (_isExiting) return;

                if (res == DialogResult.Yes)
                    StartNewGame();
                else
                    btnSalir_Click(null, EventArgs.Empty);

                return;
            }

            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            lblTiempo.Text = $"Tiempo: {_timeLeft:mm\\:ss}";
        }

        private List<string> LoadWordsFromEnfermedadesTxt()
        {
            try
            {
                string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Datos\Enfermedades.txt");
                if (!File.Exists(ruta)) return new List<string>();

                var archivo = new Archivo.Archivo();
                var lines = archivo.leerArchivo(ruta);
                if (lines == null) return new List<string>();

                var words = new List<string>();
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length >= 2)
                    {
                        var enfermedad = parts[1];
                        var w = NormalizeWord(enfermedad);
                        if (!string.IsNullOrWhiteSpace(w))
                            words.Add(w);
                    }
                }
                return words;
            }
            catch
            {
                return new List<string>();
            }
        }

        private static string NormalizeWord(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";

            var sb = new StringBuilder();
            foreach (char ch in input.ToUpperInvariant())
            {
                if (ch >= 'A' && ch <= 'Z') sb.Append(ch);
            }
            return sb.ToString();
        }

        private void FillEmptyLetters()
        {
            for (int r = 0; r < GridSize; r++)
                for (int c = 0; c < GridSize; c++)
                    _letters[r, c] = '\0';
        }

        private void RenderGrid()
        {
            for (int r = 0; r < GridSize; r++)
            {
                for (int c = 0; c < GridSize; c++)
                {
                    if (_letters[r, c] == '\0')
                        _letters[r, c] = (char)('A' + _rng.Next(0, 26));

                    var b = _cells[r, c];
                    b.Text = _letters[r, c].ToString();
                    b.BackColor = SystemColors.Control;
                    b.ForeColor = Color.Black;
                }
            }
        }

        private void PlaceWords()
        {
            var dirs = new (int dr, int dc)[]
            {
                (0,1), (1,0), (0,-1), (-1,0),
                (1,1), (1,-1), (-1,1), (-1,-1)
            };

            foreach (var word in _words)
            {
                bool placed = false;

                for (int attempt = 0; attempt < 250 && !placed; attempt++)
                {
                    var (dr, dc) = dirs[_rng.Next(dirs.Length)];
                    int r0 = _rng.Next(GridSize);
                    int c0 = _rng.Next(GridSize);

                    int r1 = r0 + dr * (word.Length - 1);
                    int c1 = c0 + dc * (word.Length - 1);
                    if (r1 < 0 || r1 >= GridSize || c1 < 0 || c1 >= GridSize) continue;

                    bool ok = true;
                    for (int k = 0; k < word.Length; k++)
                    {
                        int rr = r0 + dr * k;
                        int cc = c0 + dc * k;
                        char existing = _letters[rr, cc];
                        if (existing != '\0' && existing != word[k])
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (!ok) continue;

                    for (int k = 0; k < word.Length; k++)
                    {
                        int rr = r0 + dr * k;
                        int cc = c0 + dc * k;
                        _letters[rr, cc] = word[k];
                    }

                    placed = true;
                }
            }
        }

        private void Cell_Click(object? sender, EventArgs e)
        {
            if (_isExiting) return;
            if (_timeDialogOpen) return;

            // ✅ Timer empieza con el primer click
            StartTimerIfNeeded();

            if (sender is not Button btn) return;
            if (btn.Tag is not Point p) return;

            if (_startCell == null)
            {
                _startCell = p;
                MarkTempSelection(p);
                return;
            }

            var start = _startCell.Value;
            var end = p;
            _startCell = null;

            TryResolveSelection(start, end);
        }

        private void MarkTempSelection(Point cell)
        {
            _cells[cell.X, cell.Y].BackColor = Color.LightSkyBlue;
        }

        private void TryResolveSelection(Point start, Point end)
        {
            if (_isExiting) return;
            if (_timeDialogOpen) return;

            if (!TryGetLineCells(start, end, out var lineCells))
                return;

            string formed = new string(lineCells.Select(pt => _letters[pt.X, pt.Y]).ToArray());
            string formedRev = new string(formed.Reverse().ToArray());

            string? matched = _words.FirstOrDefault(w =>
                string.Equals(w, formed, StringComparison.OrdinalIgnoreCase) ||
                string.Equals(w, formedRev, StringComparison.OrdinalIgnoreCase));

            if (matched == null) return;
            if (_found.Contains(matched)) return;

            _found.Add(matched);
            HighlightCells(lineCells);

            for (int i = 0; i < lstPalabras.Items.Count; i++)
            {
                string item = lstPalabras.Items[i]?.ToString() ?? "";
                if (string.Equals(item, matched, StringComparison.OrdinalIgnoreCase))
                {
                    lstPalabras.Items[i] = "✓ " + matched;
                    break;
                }
            }

            if (_found.Count == _words.Count)
            {
                tmrJuego.Stop();
                _timerStarted = false;

                // ✅ evita múltiples ventanas
                _timeDialogOpen = true;

                var res = MessageBox.Show(
                    "¡Ganaste! 🎉\n¿Quieres jugar otra vez?",
                    "Completado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                _timeDialogOpen = false;

                if (_isExiting) return;

                if (res == DialogResult.Yes) StartNewGame();
                else btnSalir_Click(null, EventArgs.Empty);
            }
        }

        private void HighlightCells(List<Point> cells)
        {
            foreach (var pt in cells)
            {
                var b = _cells[pt.X, pt.Y];
                b.BackColor = Color.MediumPurple;
                b.ForeColor = Color.White;
            }
        }

        private bool TryGetLineCells(Point start, Point end, out List<Point> cells)
        {
            cells = new List<Point>();

            int dr = end.X - start.X;
            int dc = end.Y - start.Y;

            int stepR = Math.Sign(dr);
            int stepC = Math.Sign(dc);

            if (!(dr == 0 || dc == 0 || Math.Abs(dr) == Math.Abs(dc)))
                return false;

            int length = Math.Max(Math.Abs(dr), Math.Abs(dc)) + 1;
            for (int k = 0; k < length; k++)
            {
                int r = start.X + stepR * k;
                int c = start.Y + stepC * k;
                cells.Add(new Point(r, c));
            }

            return true;
        }
    }
}
