using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Proyecto_Integrador.Datos
{
    public static class PersistenciaCaballos
    {
        // Guardará en la carpeta del ejecutable: /Datos/caballos.json
        private static readonly string CarpetaDatos =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos");

        private static readonly string RutaJson =
            Path.Combine(CarpetaDatos, "caballos.json");

        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        public static List<Caballo> Cargar()
        {
            try
            {
                if (!Directory.Exists(CarpetaDatos))
                    Directory.CreateDirectory(CarpetaDatos);

                if (!File.Exists(RutaJson))
                {
                    // Si no existe, lo creamos vacío
                    File.WriteAllText(RutaJson, "[]");
                    return new List<Caballo>();
                }

                string json = File.ReadAllText(RutaJson);

                var lista = JsonSerializer.Deserialize<List<Caballo>>(json, JsonOptions);
                return lista ?? new List<Caballo>();
            }
            catch
            {
                // Si se corrompe el archivo o hay error, no revienta el programa:
                return new List<Caballo>();
            }
        }

        public static void Guardar(List<Caballo> caballos)
        {
            try
            {
                if (!Directory.Exists(CarpetaDatos))
                    Directory.CreateDirectory(CarpetaDatos);

                string json = JsonSerializer.Serialize(caballos, JsonOptions);
                File.WriteAllText(RutaJson, json);
            }
            catch
            {
                // Si quieres, aquí luego puedes mostrar MessageBox o log
            }
        }
    }
}
