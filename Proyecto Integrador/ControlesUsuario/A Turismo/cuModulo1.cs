using System;
using System.Windows.Forms;
using Proyecto_Integrador.ControlesUsuario.A_Turismo;


namespace Proyecto_Integrador.ControlesUsuario
{
    public partial class cuModulo1 : UserControl
    {
        public cuModulo1()
        {
            InitializeComponent();
        }

        private void CentrarTabla()
        {
            if (TurismopanelContenido == null || TurismotablaCentro == null)
                return;

            TurismotablaCentro.Left =
                (TurismopanelContenido.Width - TurismotablaCentro.Width) / 2;

            TurismotablaCentro.Top =
                (TurismopanelContenido.Height - TurismotablaCentro.Height) / 2;
        }


        private void cuModulo1_Load(object sender, EventArgs e)
        {
            CentrarTabla();
        }

        private void TurismopanelContenido_Resize(object sender, EventArgs e)
        {
            CentrarTabla();
        }

        private void TurismoButtonRegistrar_Click(object sender, EventArgs e)
        {
            TurismotablaCentro.Visible = false;

            TurismoRegistrarCaballo registro = new TurismoRegistrarCaballo();
            registro.CancelarPresionado += Registro_Cancelado;
            registro.RegistroExitoso += Registro_Exitoso;

            registro.Dock = DockStyle.Fill;
            TurismopanelContenido.Controls.Add(registro);
        }





        private void TurismoButtonVer_Click(object sender, EventArgs e)
        {
            TurismotablaCentro.Visible = false;

            TurismoVerRegistro vista = new TurismoVerRegistro();
            vista.Dock = DockStyle.Fill;
            TurismopanelContenido.Controls.Add(vista);
        }




        private void CargarControl(UserControl control)
        {
            TurismopanelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            TurismopanelContenido.Controls.Add(control);
        }

        private void TurismoButtonAgenda_Click(object sender, EventArgs e)
        {
        }

        private void TurismoButtonMinijuego_Click(object sender, EventArgs e)
        {
        }

        private void Registro_Exitoso(object? sender, EventArgs e)
        {
            if (sender is Control control)
            { 
                  TurismopanelContenido.Controls.Remove((Control)sender);
            }
            TurismotablaCentro.Visible = true;
            CentrarTabla();
        }


        private void Registro_Cancelado(object? sender, EventArgs e)
        {
            if (sender is Control control)
            {
                TurismopanelContenido.Controls.Remove(control);
            }

            TurismotablaCentro.Visible = true;
            CentrarTabla();
        }


    }





}
