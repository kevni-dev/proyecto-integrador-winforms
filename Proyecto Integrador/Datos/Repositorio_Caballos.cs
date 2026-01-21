using System.Collections.Generic;

namespace Proyecto_Integrador.Datos
{
    public static class RepositorioCaballos
    {
        private static List<Caballo> listaCaballos = new List<Caballo>();
        private static bool inicializado = false;

        // Opción B: NO agrega caballos por defecto.
        // Solo carga del JSON.
        public static void Inicializar()
        {
            if (inicializado) return;

            listaCaballos = PersistenciaCaballos.Cargar();
            inicializado = true;
        }

        public static bool Agregar(Caballo caballo)
        {
            Inicializar();

            // Validar edad
            if (caballo.Edad < 0 || caballo.Edad > 30)
                return false;

            // Nombre repetido
            for (int i = 0; i < listaCaballos.Count; i++)
            {
                if (listaCaballos[i].Nombre == caballo.Nombre)
                    return false;
            }

            listaCaballos.Add(caballo);

            // Guardar permanente
            PersistenciaCaballos.Guardar(listaCaballos);
            return true;
        }

        public static List<Caballo> ObtenerTodos()
        {
            Inicializar();
            return listaCaballos;
        }

        public static bool Editar(string nombre, int nuevaEdad, string nuevaRaza)
        {
            Inicializar();

            for (int i = 0; i < listaCaballos.Count; i++)
            {
                if (listaCaballos[i].Nombre == nombre)
                {
                    if (nuevaEdad < 0 || nuevaEdad > 30)
                        return false;

                    listaCaballos[i].Edad = nuevaEdad;
                    listaCaballos[i].Raza = nuevaRaza;

                    // Guardar permanente
                    PersistenciaCaballos.Guardar(listaCaballos);
                    return true;
                }
            }

            return false;
        }

        // (Opcional) si luego necesitas borrar
        public static bool Eliminar(string nombre)
        {
            Inicializar();

            for (int i = 0; i < listaCaballos.Count; i++)
            {
                if (listaCaballos[i].Nombre == nombre)
                {
                    listaCaballos.RemoveAt(i);
                    PersistenciaCaballos.Guardar(listaCaballos);
                    return true;
                }
            }
            return false;
        }
    }
}
