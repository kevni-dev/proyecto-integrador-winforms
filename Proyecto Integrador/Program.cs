namespace Proyecto_Integrador
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DatosGlobales.Caballos.Add("Pepe");
            DatosGlobales.Caballos.Add("Relámpago");
            DatosGlobales.Caballos.Add("Tormenta");
            DatosGlobales.Caballos.Add("Estrella");
            Application.Run(new FormLogin());


        }
    }
}