/**************************************************************************
* Nom du fichier : Form1.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Écran principal du marketplace (liste des skins + filtre + ajout au panier).
**************************************************************************/

using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;
using cs2_skins_market.Core;
using cs2_skins_market.Core.Models;
using cs2_skins_market.UI.Forms;
using cs2_skins_market.UI.UserControls;

namespace cs2_skins_market
{
    /// <summary>
    /// Form principal du marketplace.
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly ISkinService _skinService;
        private readonly IAuthService _authService;

        /// <summary>
        /// Initialise le formulaire et les dépendances nécessaires.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            _skinService = new SkinManager();
            _authService = new AuthService();
            this.WindowState = FormWindowState.Maximized;
            flpSkins.BackColor = Color.FromArgb(30, 30, 30);
            StyleNavButtons();
        }

        /// <summary>
        /// Applique le style visuel aux boutons de navigation.
        /// </summary>
        private void StyleNavButtons()
        {
            void Style(Button b, Color bg)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.BackColor = bg;
                b.ForeColor = Color.White;
                b.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                b.Cursor = Cursors.Hand;
            }

            Style(btnCart, Color.FromArgb(255, 152, 0));
            Style(btnInventory, Color.FromArgb(33, 150, 243));
            Style(btnWallet, Color.FromArgb(0, 188, 212));
            Style(btnLogout, Color.FromArgb(180, 60, 60));
        }

        /// <summary>
        /// Callback exécuté lors du chargement du formulaire.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ShowSkins(_skinService.GetAllSkins());
            RefreshHeader();
        }

        /// <summary>
        /// Affiche la liste de skins dans le panneau défilant.
        /// </summary>
        private void ShowSkins(IEnumerable<Skin> skins)
        {
            var sortedSkins = skins.ToList();
            flpSkins.Controls.Clear();

            flpSkins.SuspendLayout();

            foreach (var skin in sortedSkins)
            {
                var card = new SkinCard(skin, AddToCart);
                flpSkins.Controls.Add(card);
            }

            flpSkins.ResumeLayout();
        }

        /// <summary>
        /// Ajoute un skin au panier.
        /// </summary>
        private void AddToCart(Skin skin)
        {
            AppSession.Cart.Add(skin);
            RefreshHeader();
            MessageBox.Show($"{skin.Name} added to cart.", "Cart");
        }

        /// <summary>
        /// Met à jour le budget et le nombre d'items dans le panier.
        /// </summary>
        private void RefreshHeader()
        {
            lblBudget.Text = $"Budget: ${_authService.GetBudget():N2}";
            btnCart.Text = $"Cart ({AppSession.Cart.Count})";
        }

        /// <summary>
        /// Gère le clic sur le bouton de filtre.
        /// </summary>
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string searchName = txtSearch.Text;
            double.TryParse(txtMinPrice.Text, out double min);
            double.TryParse(txtMaxPrice.Text, out double max);

            if (max <= 0) max = double.MaxValue;

            if (min > max)
            {
                MessageBox.Show("Min price cannot be greater than max price.", "Validation");
                return;
            }

            var filteredSkins = _skinService.GetSkinsByFilter(searchName, min, max);

            ShowSkins(filteredSkins);
        }

        bool allSkins = true;
        /// <summary>
        /// Gère la recherche en temps réel quand le texte change.
        /// </summary>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword.Length <= 2 && allSkins == false)
            {
                var results = _skinService.GetAllSkins();
                allSkins = true;
                ShowSkins(results);
            }
            if (keyword.Length >= 3)
            {
                var results = _skinService.GetSkinsByFilter(keyword, 0, double.MaxValue);
                allSkins = false;
                ShowSkins(results);
            }
         
        }

        /// <summary>
        /// Ouvre la fenêtre du panier.
        /// </summary>
        private void btnCart_Click(object sender, EventArgs e)
        {
            using var cart = new CartForm();
            cart.ShowDialog();
            RefreshHeader();
        }

        /// <summary>
        /// Ouvre la fenêtre d'inventaire.
        /// </summary>
        private void btnInventory_Click(object sender, EventArgs e)
        {
            using var inventory = new InventoryForm();
            inventory.ShowDialog();
            RefreshHeader();
        }

        /// <summary>
        /// Ouvre la fenêtre wallet.
        /// </summary>
        private void btnWallet_Click(object sender, EventArgs e)
        {
            using var wallet = new WalletForm();
            wallet.ShowDialog();
            RefreshHeader();
        }

        /// <summary>
        /// Déconnecte l'utilisateur et ferme l'écran principal.
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            AppSession.Logout();
            Close();
        }
    }
}
