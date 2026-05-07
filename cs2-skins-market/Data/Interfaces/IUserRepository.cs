/**************************************************************************
* Nom du fichier : IUserRepository.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Contrat repository pour les utilisateurs.
**************************************************************************/

using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Data.Interfaces
{
    /// <summary>
    /// Définit les opérations d'accès aux utilisateurs.
    /// </summary>
    public interface IUserRepository
    {
        /// <summary>
        /// Retourne un utilisateur par son nom d'utilisateur (ou null si non trouvé).
        /// </summary>
        AppUser GetByUsername(string username);

        /// <summary>
        /// Indique si le nom d'utilisateur existe déjà.
        /// </summary>
        bool UsernameExists(string username);

        /// <summary>
        /// Insère un nouvel utilisateur.
        /// </summary>
        void Insert(AppUser user);

        /// <summary>
        /// Met à jour le budget de l'utilisateur.
        /// </summary>
        void UpdateBudget(string username, double newBudget);

        /// <summary>
        /// Incrémente le budget de l'utilisateur.
        /// </summary>
        void IncrementBudget(string username, double delta);
    }
}
