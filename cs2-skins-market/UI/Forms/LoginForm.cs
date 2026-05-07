/**************************************************************************
* Nom du fichier : LoginForm.cs
* Auteur : Ozgun Levent
* Date de création : 05.05.2026
* Description : Écran de connexion.
**************************************************************************/

using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;
using cs2_skins_market.Data;

namespace cs2_skins_market.UI.Forms
{
    /// <summary>
    /// Formulaire de connexion.
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly IAuthService _authService;

        /// <summary>
        /// Initialise l'écran de connexion.
        /// </summary>
        public LoginForm()
        {
            DbInitializer.Initialize();
            InitializeComponent();
            _authService = new AuthService();
        }

        /// <summary>
        /// Traite le clic sur le bouton Login.
        /// </summary>
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

        /// <summary>
        /// Ouvre l'écran d'inscription.
        /// </summary>
        private void BtnRegister_Click(object? sender, EventArgs e)
        {
            using var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
