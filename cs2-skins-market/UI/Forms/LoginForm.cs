using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;
using cs2_skins_market.Data;

namespace cs2_skins_market.UI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;

        public LoginForm()
        {
            DbInitializer.Initialize();
            InitializeComponent();
            _authService = new AuthService();
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            if (_authService.TryLogin(_txtUsername.Text, _txtPassword.Text, out var error))
            {
                Hide();
                using var market = new Form1();
                market.ShowDialog();
                Show();
                _txtPassword.Clear();
            }
            else
            {
                MessageBox.Show(error, "Login Failed");
            }
        }

        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            using var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
