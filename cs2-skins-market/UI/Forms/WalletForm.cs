using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;

namespace cs2_skins_market.UI.Forms
{
    public partial class WalletForm : Form
    {
        private readonly IAuthService _authService;

        public WalletForm()
        {
            InitializeComponent();
            _authService = new AuthService();
            RefreshBalance();
        }

        private void RefreshBalance()
        {
            _lblBalance.Text = $"Current balance: ${_authService.GetBudget():N2}";
        }

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

        private void btnMarket_Click(object sender, EventArgs e) => Close();
        private void btnCart_Click(object sender, EventArgs e) => ShopNavigation.GoToCart(this);
        private void btnInventory_Click(object sender, EventArgs e) => ShopNavigation.GoToInventory(this);
    }
}
