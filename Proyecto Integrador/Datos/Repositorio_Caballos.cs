using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Proyecto_Integrador.Datos
{
    public static class RepositorioCaballos
    {
        private static List<Caballo> listaCaballos = new List<Caballo>();

        // Ruta del JSON (queda dentro del output: bin/Debug/.../Datos/caballos.json)
        private static string RutaJson =>
            Path.Combine(AppContext.BaseDirectory, "Datos", "caballos.json");

        // Llamar 1 vez al iniciar el módulo / programa
        public static void CargarDesdeJson()
        {
            try
            {
                // Asegurar carpeta Datos en output
                string? carpeta = Path.GetDirectoryName(RutaJson);
                if (!string.IsNullOrWhiteSpace(carpeta) && !Directory.Exists(carpeta))
                    Directory.CreateDirectory(carpeta);

                // Si no existe el archivo, lo crea con lista vacía
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
                listaCaballos = new List<Caballo>();
            }
        }

        private static void GuardarEnJson()
        {
            try
            {
                var opciones = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(listaCaballos, opciones);
                File.WriteAllText(RutaJson, json);
            }
            catch
            {
                // no revienta
            }
        }

        public static List<Caballo> ObtenerTodos()
        {
            return listaCaballos;
        }

        public static bool Agregar(Caballo caballo)
        {
            if (caballo == null) return false;

            // ✅ CONSISTENTE con Caballo.EdadValida() (0..35)
            if (!caballo.EdadValida())
                return false;

            string nombreNuevo = (caballo.Nombre ?? "").Trim();
            if (string.IsNullOrWhiteSpace(nombreNuevo))
                return false;

            bool repetido = listaCaballos.Any(c =>
                string.Equals((c.Nombre ?? "").Trim(), nombreNuevo, StringComparison.OrdinalIgnoreCase));

            if (repetido)
                return false;

            caballo.Nombre = nombreNuevo;

            listaCaballos.Add(caballo);
            GuardarEnJson();
            return true;
        }

        // ✅ EDITAR COMPLETO (el que usa tu botón Editar)
        public static bool Actualizar(string nombreOriginal, Caballo actualizado)
        {
            if (actualizado == null) return false;

            string original = (nombreOriginal ?? "").Trim();
            if (string.IsNullOrWhiteSpace(original)) return false;

            Caballo? existente = listaCaballos.FirstOrDefault(c =>
                string.Equals((c.Nombre ?? "").Trim(), original, StringComparison.OrdinalIgnoreCase));

            if (existente == null) return false;

            string nuevoNombre = (actualizado.Nombre ?? "").Trim();
            if (string.IsNullOrWhiteSpace(nuevoNombre)) return false;

            // ✅ CONSISTENTE con Caballo.EdadValida() (0..35)
            if (!actualizado.EdadValida()) return false;

            bool repetido = listaCaballos.Any(c =>
                !ReferenceEquals(c, existente) &&
                string.Equals((c.Nombre ?? "").Trim(), nuevoNombre, StringComparison.OrdinalIgnoreCase));

            if (repetido) return false;

            // Actualizar campos
            existente.Nombre = nuevoNombre;
            existente.Edad = actualizado.Edad;
            existente.Raza = actualizado.Raza ?? "";
            existente.Sexo = actualizado.Sexo ?? "";
            existente.Temperamento = actualizado.Temperamento ?? "";
            existente.ImagenRecurso = actualizado.ImagenRecurso ?? "";

            GuardarEnJson();
            return true;
        }

        public static bool Eliminar(string nombre)
        {
            string buscado = (nombre ?? "").Trim();
            if (string.IsNullOrWhiteSpace(buscado)) return false;

            var caballo = listaCaballos.FirstOrDefault(c =>
                string.Equals((c.Nombre ?? "").Trim(), buscado, StringComparison.OrdinalIgnoreCase));

            if (caballo == null) return false;

            listaCaballos.Remove(caballo);
            GuardarEnJson();
            return true;
        }

        // ✅ (OPCIONAL) si quieres por si acaso, pero ya no lo necesitas en tu UI
        // Si no lo llamas en ninguna parte, BORRALO.
        public static bool Editar(string nombre, int nuevaEdad, string nuevaRaza)
        {
            if (string.IsNullOrWhiteSpace(nombre)) return false;

            if (nuevaEdad < 0 || nuevaEdad > 35)
                return false;

            string buscado = nombre.Trim();

            var existente = listaCaballos.FirstOrDefault(c =>
                string.Equals((c.Nombre ?? "").Trim(), buscado, StringComparison.OrdinalIgnoreCase));

            if (existente == null) return false;

            existente.Edad = nuevaEdad;
            existente.Raza = nuevaRaza ?? "";
            GuardarEnJson();
            return true;
        }
    }
}
