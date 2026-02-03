using System;

namespace Proyecto_Integrador.Datos
{
    public class EnfermedadCaso
    {
        public string Nombre { get; set; } = "";   
        public DateTime Fecha { get; set; }
        public string Notas { get; set; } = "";
        public bool Activa { get; set; }
    }
}
