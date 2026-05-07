/**************************************************************************
* Nom du fichier : IAuthService.cs
* Auteur : Ozgun Levent
* Date de création : 05.05.2026
* Description : Contrat pour les opérations d'authentification.
**************************************************************************/

namespace cs2_skins_market.Business.Interfaces
{
    /// <summary>
    /// Définit les opérations d'inscription, connexion et gestion du budget.
    /// </summary>
    public interface IAuthService
    {
        /// <summary>
        /// Tente d'inscrire un nouvel utilisateur.
        /// </summary>
        bool TryRegister(string username, string password, double budget, out string errorMessage);

        /// <summary>
        /// Tente de connecter un utilisateur.
        /// </summary>
        bool TryLogin(string username, string password, out string errorMessage);

        /// <summary>
        /// Retourne le budget de l'utilisateur connecté.
        /// </summary>
        double GetBudget();

        /// <summary>
        /// Tente d'ajouter des fonds au budget de l'utilisateur connecté.
        /// </summary>
        bool TryDepositFunds(double amount, out string errorMessage);
    }
}
