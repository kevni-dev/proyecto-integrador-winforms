using System;

namespace Proyecto_Integrador.Datos
{
    public class RegistroCrecimiento
    {
        public string NombreCaballo { get; set; } = "";
        public DateTime Fecha { get; set; } = DateTime.Now;
        public int Edad { get; set; }
        public double Peso { get; set; }
        public string Alimentacion { get; set; } = "";
        public string Clasificacion { get; set; } = "";
        public string Observacion { get; set; } = "";

    }
}
