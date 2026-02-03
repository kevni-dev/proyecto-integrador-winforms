using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Proyecto_Integrador.Datos
{
    public static class RepositorioTratamientos
    {
        private static readonly string _ruta =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Datos\tratamientos.json");

        public static List<TratamientoGeneral> Cargar()
        {
            try
            {
                if (!File.Exists(_ruta)) return new List<TratamientoGeneral>();
                var json = File.ReadAllText(_ruta);
                return JsonSerializer.Deserialize<List<TratamientoGeneral>>(json) ?? new List<TratamientoGeneral>();
            }
            catch
            {
                return new List<TratamientoGeneral>();
            }
        }

        public static void Guardar(List<TratamientoGeneral> lista)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_ruta)!);
            var json = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_ruta, json);
        }
    }
}
