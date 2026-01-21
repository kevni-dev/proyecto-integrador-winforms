using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador
{
    public class Archivos
    {
        public string [] leeArchivo(string ruta)
        {
          string[] lineasArchivos =File.ReadAllLines(ruta);
            return lineasArchivos;
        }
    }

}
