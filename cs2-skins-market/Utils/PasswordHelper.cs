using System.Security.Cryptography;
using System.Text;

namespace cs2_skins_market.Utils
{
    public static class PasswordHelper
    {
        public static string CreateHash(string password)
        {
            var bytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToHexString(SHA256.HashData(bytes));
        }

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

