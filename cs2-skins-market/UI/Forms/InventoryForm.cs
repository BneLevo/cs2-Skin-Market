using cs2_skins_market.Business.Services;
using cs2_skins_market.Core.Models;
using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.UI.UserControls;

namespace cs2_skins_market.UI.Forms
{
    public partial class InventoryForm : Form
    {
        private readonly IPurchaseService _purchaseService;
        private readonly ISkinService _skinService;

        public InventoryForm()
        {
            InitializeComponent();
            _purchaseService = new PurchaseService();
            _skinService = new SkinManager();
            RefreshInventory();
        }

        private void RefreshInventory()
        {
            var items = _purchaseService.GetInventory();
            lblCount.Text = $"{items.Count} item(s) owned";

            flpInventory.Controls.Clear();
            var skinLookup = _skinService.GetAllSkins().ToDictionary(s => s.Id, s => s);

            foreach (var item in items)
            {
                skinLookup.TryGetValue(item.SkinId, out var marketSkin);
                var skin = new Skin
                {
                    Id = item.SkinId,
                    Name = $"{item.Name} ({item.PurchasedAt:yyyy-MM-dd})",
                    Price = item.Price,
                    Img = marketSkin?.Img ?? ""
                };

                flpInventory.Controls.Add(new SkinCard(
                    skin,
                    onAction: null,
                    buttonText: "OWNED",
                    buttonColor: Color.FromArgb(70, 70, 70),
                    showButton: true,
                    buttonEnabled: false));
            }

            if (items.Count == 0)
            {
                flpInventory.Controls.Add(new Label
                {
                    Text = "Your inventory is empty.",
                    ForeColor = Color.Silver,
                    AutoSize = true,
                    Margin = new Padding(20)
                });
            }
        }

        private void btnMarket_Click(object sender, EventArgs e) => Close();
        private void btnCart_Click(object sender, EventArgs e) => ShopNavigation.GoToCart(this);
        private void btnWallet_Click(object sender, EventArgs e) => ShopNavigation.GoToWallet(this);
    }
}
