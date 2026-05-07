/**************************************************************************
* Nom du fichier : AppSession.cs
* Auteur : Ozgun Levent
* Date de création : 05.05.2026
* Description : Stocke l'état de session (utilisateur connecté, panier).
**************************************************************************/

using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Core
{
    /// <summary>
    /// Stocke les informations de session de l'application.
    /// </summary>
    static class AppSession
    {
        /// <summary>
        /// Nom d'utilisateur actuellement connecté (null si non connecté).
        /// </summary>
        public static string? Username { get; set; }

        /// <summary>
        /// Contenu du panier courant.
        /// </summary>
        public static List<Skin> Cart { get; } = new();

        /// <summary>
        /// Déconnecte l'utilisateur et vide le panier.
        /// </summary>
        public static void Logout()
        {
            Username = null;
            Cart.Clear();
        }
    }
}
