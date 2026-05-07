using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;

namespace cs2_skins_market.UI.Forms
{
    public partial class RegisterForm : Form
    {
        private readonly IAuthService _authService;

        public RegisterForm()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(_txtBudget.Text, out var budget))
            {
                MessageBox.Show("Please enter a valid budget.", "Invalid Input");
                return;
            }

            if (_authService.TryRegister(_txtUsername.Text, _txtPassword.Text, budget, out var error))
            {
                MessageBox.Show("Account created. You can now login.", "Success");
                Close();
            }
            else
            {
                MessageBox.Show(error, "Register Failed");
            }
        }
    }
}
