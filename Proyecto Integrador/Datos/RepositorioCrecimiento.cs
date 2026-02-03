using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Proyecto_Integrador.Datos
{
    public static class RepositorioCrecimiento
    {
        private static readonly string Ruta =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "crecimiento_historial.json");

        public static List<RegistroCrecimiento> ObtenerTodos()
        {
            try
            {
                if (!File.Exists(Ruta)) return new List<RegistroCrecimiento>();
                var json = File.ReadAllText(Ruta);
                return JsonSerializer.Deserialize<List<RegistroCrecimiento>>(json) ?? new List<RegistroCrecimiento>();
            }
            catch
            {
                return new List<RegistroCrecimiento>();
            }
        }

        public static void Agregar(RegistroCrecimiento reg)
        {
            var lista = ObtenerTodos();
            lista.Add(reg);

            Directory.CreateDirectory(Path.GetDirectoryName(Ruta)!);

            var opt = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(Ruta, JsonSerializer.Serialize(lista, opt));
        }

        public static List<RegistroCrecimiento> ObtenerPorCaballo(string nombreCaballo)
        {
            return ObtenerTodos()
                .Where(x => x.NombreCaballo.Equals(nombreCaballo, StringComparison.OrdinalIgnoreCase))
                .OrderByDescending(x => x.Fecha)
                .ToList();
        }

        public static RegistroCrecimiento? ObtenerUltimoDe(string nombreCaballo)
        {
            return ObtenerPorCaballo(nombreCaballo).FirstOrDefault();
        }
    }
}
