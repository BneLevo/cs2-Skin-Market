/**************************************************************************
* Nom du fichier : Program.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Point d'entrée de l'application WinForms.
**************************************************************************/

using cs2_skins_market.UI.Forms;

namespace cs2_skins_market
{
    /// <summary>
    /// Point d'entrée de l'application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// <summary>
        /// Démarre l'application et ouvre le formulaire de login.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}