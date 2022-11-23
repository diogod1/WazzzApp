using Wazzaaap.Forms;
using Wazzaaap.BLL;

namespace Wazzaaap
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
            // Application.Run(new Login());
            user_bl teste = new user_bl();
            teste.username = "brndz1";
            teste.password = "password_teste3";
            teste.name = "Diogo Brandao";
            teste.bio = "Sou da tecla";
            teste.status = "ausente";
            //teste.register();
            teste.login();
        }
    }
}