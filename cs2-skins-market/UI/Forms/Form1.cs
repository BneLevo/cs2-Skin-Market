using cs2_skins_market.Business.Interfaces;
using cs2_skins_market.Business.Services;
using cs2_skins_market.Core.Models;
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
            ShowSkins(_skinService.GetAllSkins());
        }

        private void ShowSkins(IEnumerable<Skin> skins)
        {
            var sortedSkins = skins.ToList();
            flpSkins.Controls.Clear();

            flpSkins.SuspendLayout();

            foreach (var skin in sortedSkins)
            {
                var card = new SkinCard(skin);
                flpSkins.Controls.Add(card);
            }

            flpSkins.ResumeLayout();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            double.TryParse(txtMinPrice.Text, out double min);
            double.TryParse(txtMaxPrice.Text, out double max);
            if (max <= 0) max = double.MaxValue;

            if (min > max)
            {
                MessageBox.Show("Min price cannot be greater than max price.", "Warning");
                return;
            }

            List<Skin> skins;

            // Between min and max
            if (min > 0 && max < double.MaxValue)
            {
                skins = _skinService.GetSkinsByPriceRange(min, max);
            }
            // Only min
            else if (min > 0)
            {
                skins = _skinService.GetSkinsByMinPrice(min);
            }
            // Only max
            else if (max < double.MaxValue)
            {
                skins = _skinService.GetSkinsByMaxPrice(max);
            }
            // Both empty
            else
            {
                skins = _skinService.GetAllSkins();
            }

            ShowSkins(skins);
        }
    }
}
