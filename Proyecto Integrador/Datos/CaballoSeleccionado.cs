using System;

namespace Proyecto_Integrador.Datos
{
    public static class CaballoSeleccionado
    {
        private static Caballo _caballoActual;

        public static event EventHandler CaballoActualizado;

        public static Caballo Actual
        {
            get => _caballoActual;
            set
            {
                _caballoActual = value;
                CaballoActualizado?.Invoke(null, EventArgs.Empty);
            }
        }

        public static bool HayCaballoSeleccionado()
        {
            return _caballoActual != null;
        }

        public static void Limpiar()
        {
            _caballoActual = null;
            CaballoActualizado?.Invoke(null, EventArgs.Empty);
        }
    }
}
