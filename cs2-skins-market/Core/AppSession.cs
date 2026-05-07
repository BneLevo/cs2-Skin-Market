using cs2_skins_market.Core.Models;

namespace cs2_skins_market.Core
{
    static class AppSession
    {
        public static string? Username { get; set; }

        public static List<Skin> Cart { get; } = new();

        public static void Logout()
        {
            Username = null;
            Cart.Clear();
        }
    }
}
