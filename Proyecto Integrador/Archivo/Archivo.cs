using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Archivo
{
    public class Archivo
    {
        public string[] leerArchivo(string ruta)
        {
            string [] contenido = File.ReadAllLines(ruta);
            return contenido;
        }
        public void escribirLinea(string ruta, string linea)
        {
            File.AppendAllText(ruta, linea);

        }
    }

}
