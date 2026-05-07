/**************************************************************************
* Nom du fichier : ShopNavigation.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Centralise la navigation entre formulaires.
**************************************************************************/

using cs2_skins_market.UI.Forms;

namespace cs2_skins_market.UI
{
    /// <summary>
    /// Fournit des méthodes de navigation entre les écrans du shop.
    /// </summary>
    public static class ShopNavigation
    {
        /// <summary>
        /// Navigue vers le panier.
        /// </summary>
        public static void GoToCart(Form current)
        {
            Switch(current, static () => new CartForm());
        }

        /// <summary>
        /// Navigue vers l'inventaire.
        /// </summary>
        public static void GoToInventory(Form current)
        {
            Switch(current, static () => new InventoryForm());
        }

        /// <summary>
        /// Navigue vers le portefeuille.
        /// </summary>
        public static void GoToWallet(Form current)
        {
            Switch(current, static () => new WalletForm());
        }

        /// <summary>
        /// Ferme l'écran courant et ouvre le suivant.
        /// </summary>
        private static void Switch(Form current, Func<Form> createNext)
        {
            var next = createNext();
            next.StartPosition = FormStartPosition.Manual;
            next.Bounds = current.Bounds;
            if (current.WindowState != FormWindowState.Minimized)
            {
                next.WindowState = current.WindowState;
            }

            current.Hide();
            next.ShowDialog();
            current.Close();
        }
    }
}
