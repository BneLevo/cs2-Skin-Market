/**************************************************************************
* Nom du fichier : CartForm.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Form affichant le contenu du panier et permettant l'achat.
**************************************************************************/

using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;
using cs2_skins_market.Core;
using cs2_skins_market.Core.Models;
using cs2_skins_market.UI.UserControls;

namespace cs2_skins_market.UI.Forms
{
    /// <summary>
    /// Écran du panier : liste des skins, suppression et achat.
    /// </summary>
    public partial class CartForm : Form
    {
        private readonly IAuthService _authService;
        private readonly IPurchaseService _purchaseService;

        /// <summary>
        /// Initialise l'écran panier.
        /// </summary>
        public CartForm()
        {
            InitializeComponent();
            _authService = new AuthService();
            _purchaseService = new PurchaseService();
            RefreshCart();
        }

        /// <summary>
        /// Rafraîchit le contenu affiché (cards, total, budget, subtitle).
        /// </summary>
        private void RefreshCart()
        {
            _cardsPanel.Controls.Clear();
            foreach (var skin in AppSession.Cart)
            {
                var card = new SkinCard(
                    skin,
                    RemoveFromCart,
                    buttonText: "REMOVE",
                    buttonColor: Color.FromArgb(180, 60, 60));
                _cardsPanel.Controls.Add(card);
            }

            if (AppSession.Cart.Count == 0)
            {
                var emptyLabel = new Label
                {
                    Text = "Your cart is empty.",
                    ForeColor = Color.Silver,
                    AutoSize = true,
                    Margin = new Padding(20)
                };
                _cardsPanel.Controls.Add(emptyLabel);
            }

            var total = AppSession.Cart.Sum(s => s.Price);
            _lblTotal.Text = $"Cart total: ${total:N2}";
            _lblBudget.Text = $"Your budget: ${_authService.GetBudget():N2}";
            _lblSubtitle.Text = $"Shopping cart  ·  {AppSession.Cart.Count} item(s)";
        }

        /// <summary>
        /// Retire un skin du panier puis rafraîchit l'écran.
        /// </summary>
        private void RemoveFromCart(Skin skin)
        {
            AppSession.Cart.Remove(skin);
            RefreshCart();
        }

        /// <summary>
        /// Ferme le formulaire et retourne à l'écran précédent.
        /// </summary>
        private void btnMarket_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Ouvre l'écran d'inventaire.
        /// </summary>
        private void btnInventory_Click(object sender, EventArgs e) => ShopNavigation.GoToInventory(this);

        /// <summary>
        /// Ouvre l'écran portefeuille.
        /// </summary>
        private void btnWallet_Click(object sender, EventArgs e) => ShopNavigation.GoToWallet(this);

        /// <summary>
        /// Lance l'achat du panier.
        /// </summary>
        private void BtnPurchase_Click(object? sender, EventArgs e)
        {
            if (_purchaseService.TryPurchaseCart(out var error))
            {
                MessageBox.Show("Purchase completed.", "Success");
                RefreshCart();
            }
            else
            {
                MessageBox.Show(error, "Purchase failed");
            }
        }
    }
}
