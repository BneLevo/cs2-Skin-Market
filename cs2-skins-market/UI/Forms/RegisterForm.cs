/**************************************************************************
* Nom du fichier : RegisterForm.cs
* Auteur : Ozgun Levent
* Date de création : 05.05.2026
* Description : Écran d'inscription.
**************************************************************************/

using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;

namespace cs2_skins_market.UI.Forms
{
    /// <summary>
    /// Formulaire d'inscription.
    /// </summary>
    public partial class RegisterForm : Form
    {
        private readonly IAuthService _authService;

        /// <summary>
        /// Initialise l'écran d'inscription.
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        /// <summary>
        /// Crée un compte utilisateur à partir des champs saisis.
        /// </summary>
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
