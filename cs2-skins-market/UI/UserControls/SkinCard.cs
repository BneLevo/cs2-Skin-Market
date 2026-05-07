/**************************************************************************
* Nom du fichier : SkinCard.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : UserControl affichant un skin (image, nom, prix) et une action optionnelle.
**************************************************************************/

using System.Windows.Forms;
using cs2_skins_market.Core.Models;

namespace cs2_skins_market.UI.UserControls
{
    /// <summary>
    /// Contrôle UI réutilisable pour afficher un skin.
    /// </summary>
    public partial class SkinCard : UserControl
    {
        private readonly Skin _skin;
        private readonly Action<Skin>? _onAction;
        private readonly string _buttonText;
        private readonly Color _buttonColor;
        private readonly bool _showButton;
        private readonly bool _buttonEnabled;

        /// <summary>
        /// Initialise le contrôle avec les données d'un skin.
        /// </summary>
        public SkinCard(
            Skin skin,
            Action<Skin>? onAction,
            string buttonText = "ADD TO CART",
            Color? buttonColor = null,
            bool showButton = true,
            bool buttonEnabled = true)
        {
            InitializeComponent();
            _skin = skin;
            _onAction = onAction;
            _buttonText = buttonText;
            _buttonColor = buttonColor ?? Color.FromArgb(255, 152, 0);
            _showButton = showButton;
            _buttonEnabled = buttonEnabled;
            ApplyCardData();
        }

        /// <summary>
        /// Applique les valeurs (image, nom, prix, bouton) au contrôle.
        /// </summary>
        private void ApplyCardData()
        {
            cardPanel.Paint += (s, e) =>
            {
                ControlPaint.DrawBorder(e.Graphics, cardPanel.ClientRectangle, Color.FromArgb(60, 60, 60), ButtonBorderStyle.Solid);
            };
            pbSkin.ImageLocation = string.IsNullOrWhiteSpace(_skin.Img) ? null : _skin.Img;
            pbSkin.BackColor = string.IsNullOrWhiteSpace(_skin.Img) ? Color.FromArgb(45, 45, 45) : Color.Transparent;
            lblName.Text = _skin.Name;
            lblPrice.Text = $"${_skin.Price:N2}";
            btnAction.Text = _buttonText;
            btnAction.BackColor = _buttonColor;
            btnAction.Enabled = _buttonEnabled;
            btnAction.Visible = _showButton;
        }

        /// <summary>
        /// Gère le clic sur le bouton d'action.
        /// </summary>
        private void btnAction_Click(object sender, EventArgs e) => _onAction?.Invoke(_skin);

        /// <summary>
        /// Met en avant le style du card au survol.
        /// </summary>
        private void cardPanel_MouseEnter(object sender, EventArgs e) => cardPanel.BackColor = Color.FromArgb(50, 50, 50);

        /// <summary>
        /// Retire la mise en avant du card à la fin du survol.
        /// </summary>
        private void cardPanel_MouseLeave(object sender, EventArgs e) => cardPanel.BackColor = Color.FromArgb(35, 35, 35);
    }
}
