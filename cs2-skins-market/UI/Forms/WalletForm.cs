/**************************************************************************
* Nom du fichier : WalletForm.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Écran portefeuille (dépôt de fonds).
**************************************************************************/

using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;

namespace cs2_skins_market.UI.Forms
{
    /// <summary>
    /// Formulaire de gestion du portefeuille.
    /// </summary>
    public partial class WalletForm : Form
    {
        private readonly IAuthService _authService;

        /// <summary>
        /// Initialise l'écran portefeuille.
        /// </summary>
        public WalletForm()
        {
            InitializeComponent();
            _authService = new AuthService();
            RefreshBalance();
        }

        /// <summary>
        /// Met à jour l'affichage du solde.
        /// </summary>
        private void RefreshBalance()
        {
            _lblBalance.Text = $"Current balance: ${_authService.GetBudget():N2}";
        }

        /// <summary>
        /// Dépose des fonds sur le compte de l'utilisateur.
        /// </summary>
        private void BtnDeposit_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(_txtAmount.Text, out var amount))
            {
                MessageBox.Show("Please enter a valid number.", "Invalid amount");
                return;
            }

            if (_authService.TryDepositFunds(amount, out var error))
            {
                MessageBox.Show($"Added ${amount:N2} to your account.", "Success");
                _txtAmount.Clear();
                RefreshBalance();
            }
            else
            {
                MessageBox.Show(error, "Deposit failed");
            }
        }

        /// <summary>
        /// Retourne au marketplace.
        /// </summary>
        private void btnMarket_Click(object sender, EventArgs e) => Close();

        /// <summary>
        /// Ouvre le panier.
        /// </summary>
        private void btnCart_Click(object sender, EventArgs e) => ShopNavigation.GoToCart(this);

        /// <summary>
        /// Ouvre l'inventaire.
        /// </summary>
        private void btnInventory_Click(object sender, EventArgs e) => ShopNavigation.GoToInventory(this);
    }
}
