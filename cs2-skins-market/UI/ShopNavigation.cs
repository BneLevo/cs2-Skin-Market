using cs2_skins_market.UI.Forms;

namespace cs2_skins_market.UI
{
    public static class ShopNavigation
    {
        public static void GoToCart(Form current)
        {
            Switch(current, static () => new CartForm());
        }

        public static void GoToInventory(Form current)
        {
            Switch(current, static () => new InventoryForm());
        }

        public static void GoToWallet(Form current)
        {
            Switch(current, static () => new WalletForm());
        }

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
