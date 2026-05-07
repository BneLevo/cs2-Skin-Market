/**************************************************************************
* Nom du fichier : AuthService.cs
* Auteur : Ozgun Levent
* Date de création : 05.05.2026
* Description : Gère l'inscription, la connexion et le budget utilisateur.
**************************************************************************/

using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Core;
using cs2_skins_market.Core.Models;
using cs2_skins_market.Data.Interfaces;
using cs2_skins_market.Data.Repositories;
using cs2_skins_market.Utils;

namespace cs2_skins_market.Business.Services
{
    /// <summary>
    /// Service d'authentification et de gestion du portefeuille utilisateur.
    /// </summary>
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        /// <summary>
        /// Initialise le service d'authentification.
        /// </summary>
        public AuthService()
        {
            _userRepository = new MongoUserRepository();
        }

        /// <summary>
        /// Tente de créer un nouveau compte utilisateur.
        /// </summary>
        public bool TryRegister(string username, string password, double budget, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(username))
            {
                errorMessage = "Please enter a username.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length < 3)
            {
                errorMessage = "Password must be at least 3 characters.";
                return false;
            }

            if (budget < 0)
            {
                errorMessage = "Budget cannot be negative.";
                return false;
            }

            if (_userRepository.UsernameExists(username))
            {
                errorMessage = "This username is already taken.";
                return false;
            }

            var hashHex = PasswordHelper.CreateHash(password);
            var user = new AppUser
            {
                Username = username.Trim(),
                PasswordHash = hashHex,
                Budget = budget
            };

            _userRepository.Insert(user);
            return true;
        }

        /// <summary>
        /// Tente de connecter un utilisateur avec ses identifiants.
        /// </summary>
        public bool TryLogin(string username, string password, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                errorMessage = "Please enter username and password.";
                return false;
            }

            var user = _userRepository.GetByUsername(username);
            if (user == null || !PasswordHelper.Verify(password, user.PasswordHash))
            {
                errorMessage = "Invalid username or password.";
                return false;
            }

            AppSession.Username = user.Username;
            return true;
        }

        /// <summary>
        /// Retourne le budget actuel de l'utilisateur connecté.
        /// </summary>
        public double GetBudget()
        {
            if (string.IsNullOrWhiteSpace(AppSession.Username))
            {
                return 0;
            }

            var user = _userRepository.GetByUsername(AppSession.Username);
            return user?.Budget ?? 0;
        }

        /// <summary>
        /// Tente d'ajouter des fonds au budget de l'utilisateur connecté.
        /// </summary>
        public bool TryDepositFunds(double amount, out string errorMessage)
        {
            errorMessage = "";

            if (string.IsNullOrWhiteSpace(AppSession.Username))
            {
                errorMessage = "You are not logged in.";
                return false;
            }

            if (amount <= 0)
            {
                errorMessage = "Please enter an amount greater than zero.";
                return false;
            }

            if (amount > 1_000_000)
            {
                errorMessage = "Amount is too large.";
                return false;
            }

            if (_userRepository.GetByUsername(AppSession.Username) == null)
            {
                errorMessage = "User not found.";
                return false;
            }

            _userRepository.IncrementBudget(AppSession.Username, amount);
            return true;
        }
    }
}
