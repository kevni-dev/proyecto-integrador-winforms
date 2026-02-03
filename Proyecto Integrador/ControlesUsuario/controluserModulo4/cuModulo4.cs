using Proyecto_Integrador.ControlesUsuario.controluserModulo4.subUserControles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Integrador.ControlesUsuario.cuModulo4
{
    public partial class cuModulo4 : UserControl
    {
        private RichTextBox richTextBoxReferencias = null;
        public cuModulo4()
        {
            InitializeComponent();
        }

        private void CargarUserControl(UserControl uc)
        {
            panel3.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panel3.Controls.Add(uc);
        }

        private void cuModulo4_Load(object sender, EventArgs e)
        {

        }

        private void btnElegirCaballo_Click_1(object sender, EventArgs e)
        {
            CargarUserControl(new PerfilEmocional());
        }

        private void cuModulo4_Load_1(object sender, EventArgs e)
        {

        }

        private void btnInteraccion_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Interaccion());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            CargarUserControl(new Juego());
        }

        private void btnRendimiento_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo en desarrollo. Pronto estará disponible.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBoxReferencias == null)
            {
                CrearRichTextBoxReferencias();
            }
            else
            {
                EliminarRichTextBoxReferencias();
            }
        }
        private void CrearRichTextBoxReferencias()
        {
            richTextBoxReferencias = new RichTextBox();
            richTextBoxReferencias.Size = new Size(300, 200);
            richTextBoxReferencias.Location = new Point(
                this.ClientSize.Width - 310,
                50
            );
            richTextBoxReferencias.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            richTextBoxReferencias.ReadOnly = true;
            richTextBoxReferencias.BorderStyle = BorderStyle.FixedSingle;

            richTextBoxReferencias.Text = "J. P. Lopes, A. S. Silva, and R. M. Reis, \"Continuous Monitoring of Equine Emotional States Using Wearable Sensors and Machine Learning,\" in Proc. IEEE 6th Int. Conf. on Bio-Engineering and Bio-Sensing (ICBBS), Lisbon, Portugal, 2023, pp. 45–51.\n\n" +
                "M. G. Smith and K. Ross, \"Automated Recognition of Equine Facial Expressions for Welfare Assessment via Deep Learning,\" IEEE Transactions on Affective Computing, vol. 14, no. 2, pp. 1102–1115, Apr.-Jun. 2024. doi: 10.1109/TAFFC.2024.3325678.\n" +
                "L. Wang and T. Chen, \"Gait Pattern Analysis and Anomaly Detection in Equines Using Tri-Axial Accelerometry,\" IEEE Sensors Journal, vol. 22, no. 15, pp. 14890–14902, Aug. 2022.\n";

            this.Controls.Add(richTextBoxReferencias);
            richTextBoxReferencias.BringToFront();
        }

        private void EliminarRichTextBoxReferencias()
        {
            if (richTextBoxReferencias != null)
            {
                this.Controls.Remove(richTextBoxReferencias);

                richTextBoxReferencias.Dispose();

                richTextBoxReferencias = null;
            }
        }
        private void ConfigurarBotonInfo()
        {
            button1.Text = "ℹ";
            button1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            button1.Size = new Size(30, 30);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(this.ClientSize.Width - 40, 10);
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        }
    }
}
