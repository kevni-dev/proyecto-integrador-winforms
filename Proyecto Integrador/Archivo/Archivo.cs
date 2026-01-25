using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Integrador.Archivo
{
    public class Archivo
    {
        private void crearArchivo (string ruta)
        {
            File.Create (ruta).Close ();
        }
        public string[] leerArchivo(string ruta)
        {
            
            string[] contenido = null;
            bool archivoExiste = File.Exists(ruta);
            
            if (archivoExiste)
            {
                contenido = File.ReadAllLines(ruta);

            }
            else {
                crearArchivo (ruta);
            }
            return contenido;
        }
        public void escribirLinea(string ruta, string linea)
        {
            
            File.AppendAllText(ruta, linea);
        }
        public void editarLinea(int idEditar, string nuevaLinea, string ruta)
        {
            string[] datos = leerArchivo(ruta);
            bool encontrado = false;
            for (int i = 0; i < datos.Length; i++)

            {
                string[] linea = datos[i].Split(';');
                int id = int.Parse(linea[0]);
                if (id == idEditar)
                {
                    datos[i] = nuevaLinea;
                    encontrado = true;
                    break;
                }
            }
            if (encontrado)
            {
                
                File.WriteAllLines(ruta, datos);
            }
        }
        public void eliminarLinea(int idEliminar, string ruta)
        {
            string[] datos = leerArchivo(ruta);
            

            bool encontrado = false;
            for (int i = 0; i < datos.Length; i++)

            {
                string[] linea = datos[i].Split(';');
                int id = int.Parse(linea[0]);
                if (id == idEliminar)
                {
                    
                    encontrado = true;
                    break;
                }
            }
            if (encontrado)
            {
                File.WriteAllText(ruta, "");
                for (int i = 0; i < datos.Length; i++)

                {
                    string[] linea = datos[i].Split(';');
                    int id = int.Parse(linea[0]);
                    if (id != idEliminar)
                    {

                        File.AppendAllText(ruta, datos[i]+"\n");
                    }
                }
               
            }
        }
        public void limpiarArchivo(string ruta) 
        {
            File.WriteAllText(ruta, "");
        }

    }       
}
