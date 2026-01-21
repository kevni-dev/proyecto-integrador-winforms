using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Proyecto_Integrador.Datos
{
    public static class RepositorioCaballos
    {
        private static List<Caballo> listaCaballos = new List<Caballo>();
        private static bool cargado = false;

        // Ruta REAL donde corre el programa (bin/Debug/...)
        private static string RutaJson =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Datos", "caballos.json");

        // Llamar UNA vez al iniciar
        public static void CargarDesdeJson()
        {
            if (cargado) return;
            cargado = true;

            try
            {
                // Si no existe, crearlo con lista vacía
                string carpeta = Path.GetDirectoryName(RutaJson)!;
                if (!Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                if (!File.Exists(RutaJson))
                {
                    listaCaballos = new List<Caballo>();
                    GuardarEnJson();
                    return;
                }

                string json = File.ReadAllText(RutaJson);

                if (string.IsNullOrWhiteSpace(json))
                {
                    listaCaballos = new List<Caballo>();
                    return;
                }

                var datos = JsonSerializer.Deserialize<List<Caballo>>(json);
                listaCaballos = datos ?? new List<Caballo>();
            }
            catch
            {
                // Si el JSON está dañado, no crashear:
                listaCaballos = new List<Caballo>();
            }
        }

        private static void GuardarEnJson()
        {
            var opciones = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(listaCaballos, opciones);
            File.WriteAllText(RutaJson, json);
        }

        // --- CRUD ---

        public static bool Agregar(Caballo caballo)
        {
            CargarDesdeJson();

            if (caballo.Edad < 0 || caballo.Edad > 30) return false;

            for (int i = 0; i < listaCaballos.Count; i++)
            {
                if (string.Equals(listaCaballos[i].Nombre, caballo.Nombre, StringComparison.OrdinalIgnoreCase))
                    return false;
            }

            listaCaballos.Add(caballo);
            GuardarEnJson();
            return true;
        }

        public static List<Caballo> ObtenerTodos()
        {
            CargarDesdeJson();
            return listaCaballos;
        }

        // Ejemplo de edición simple (ajústalo luego a lo que necesites)
        public static bool Editar(string nombre, int nuevaEdad, string nuevaRaza)
        {
            CargarDesdeJson();

            for (int i = 0; i < listaCaballos.Count; i++)
            {
                if (string.Equals(listaCaballos[i].Nombre, nombre, StringComparison.OrdinalIgnoreCase))
                {
                    if (nuevaEdad < 0 || nuevaEdad > 30) return false;

                    listaCaballos[i].Edad = nuevaEdad;
                    listaCaballos[i].Raza = nuevaRaza;

                    GuardarEnJson();
                    return true;
                }
            }

            return false;
        }
    }
}
