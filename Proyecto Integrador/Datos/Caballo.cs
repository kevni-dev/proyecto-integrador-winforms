namespace Proyecto_Integrador.Datos
{
    public class Caballo
    {
        public string Nombre { get; set; } = "";
        public int Edad { get; set; }
        public string Raza { get; set; } = "";
        public string Sexo { get; set; } = "";
        public string Temperamento { get; set; } = "";

        public string ImagenRecurso { get; set; } = ""; 

        public bool EdadValida()
        {
            return Edad >= 0 && Edad <= 35;
        }
    }
}
