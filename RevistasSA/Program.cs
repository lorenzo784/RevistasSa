using RevistasSA.Datos;

namespace RevistasSA
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
            DatabaseInitializer dbManager = new DatabaseInitializer();
            dbManager.CrearBaseDeDatos();
            Database database = new Database();
            Application.Run(new FrmPrincipal(database));

        }
    }
}