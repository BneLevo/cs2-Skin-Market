using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;
using cs2_skins_market.Data;
using cs2_skins_market.UI.UserControls;

namespace cs2_skins_market
{
    public partial class Form1 : Form
    {
        private readonly ISkinService _skinService;

        public Form1()
        {
            InitializeComponent();
            DbInitializer.Initialize();
            _skinService = new SkinManager();
            this.WindowState = FormWindowState.Maximized;
            flpSkins.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            ShowSkins();
        }

        private void ShowSkins()
        {
            var skins = _skinService.GetAllSkins();
            flpSkins.Controls.Clear();

            flpSkins.SuspendLayout();

            foreach (var skin in skins)
            {
                var card = new SkinCard(skin);
                flpSkins.Controls.Add(card);
            }

            flpSkins.ResumeLayout();
        }
    }
}
