using System.Collections.Generic;

namespace Proyecto_Integrador.Datos
{
    public static class RepositorioCaballos
    {
        // Lista global de caballos
        private static List<Caballo> listaCaballos = new List<Caballo>();

        // Agregar un caballo con validaciones
        public static bool Agregar(Caballo caballo)
        {
            // Validar edad
            if (caballo.Edad < 0 || caballo.Edad > 30)
            {
                return false;
            }

            // Validar nombre repetido
            for (int i = 0; i < listaCaballos.Count; i++)
            {
                if (listaCaballos[i].Nombre == caballo.Nombre)
                {
                    return false;
                }
            }

            listaCaballos.Add(caballo);
            return true;
        }

        // Obtener todos los caballos
        public static List<Caballo> ObtenerTodos()
        {
            return listaCaballos;
        }

        // Editar caballo por nombre
        public static bool Editar(string nombre, int nuevaEdad, string nuevaRaza)
        {
            for (int i = 0; i < listaCaballos.Count; i++)
            {
                if (listaCaballos[i].Nombre == nombre)
                {
                    if (nuevaEdad < 0 || nuevaEdad > 30)
                        return false;

                    listaCaballos[i].Edad = nuevaEdad;
                    listaCaballos[i].Raza = nuevaRaza;
                    return true;
                }
            }

            return false;
        }
    }
}
