/**************************************************************************
* Nom du fichier : PasswordHelper.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Utilitaires pour créer et vérifier un hash de mot de passe.
**************************************************************************/

using System.Security.Cryptography;
using System.Text;

namespace cs2_skins_market.Utils
{
    /// <summary>
    /// Fournit des utilitaires pour hasher et vérifier des mots de passe.
    /// </summary>
    public static class PasswordHelper
    {
        /// <summary>
        /// Calcule le hash SHA256 (hex) d'un mot de passe.
        /// </summary>
        public static string CreateHash(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToHexString(SHA256.HashData(bytes));
        }

        /// <summary>
        /// Vérifie qu'un mot de passe correspond au hash attendu.
        /// </summary>
        public static bool Verify(string password, string expectedHashHex)
        {
            try
            {
                var actualHash = CreateHash(password);
                return CryptographicOperations.FixedTimeEquals(
                    Convert.FromHexString(actualHash),
                    Convert.FromHexString(expectedHashHex));
            }
            catch
            {
                return false;
            }
        }
    }
}

