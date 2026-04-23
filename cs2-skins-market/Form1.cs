using cs2_skins_market.Services;
using MongoDB.Driver;

namespace cs2_skins_market
{
    public partial class Form1 : Form
    {
        private readonly ISkinService _skinService;

        public Form1()
        {
            InitializeComponent();
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
                Panel card = new Panel
                {
                    Size = new Size(260, 380),
                    BackColor = Color.FromArgb(35, 35, 35),
                    Margin = new Padding(20),
                    Padding = new Padding(10)
                };

                card.Paint += (s, e) => {
                    ControlPaint.DrawBorder(e.Graphics, card.ClientRectangle, Color.FromArgb(60, 60, 60), ButtonBorderStyle.Solid);
                };

                PictureBox pb = new PictureBox
                {
                    Size = new Size(240, 160),
                    Dock = DockStyle.Top,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = skin.Img,
                    Cursor = Cursors.Hand
                };

                Label lblName = new Label
                {
                    Text = skin.Name,
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 11, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    Size = new Size(240, 60),
                    TextAlign = ContentAlignment.BottomCenter,
                    Padding = new Padding(0, 10, 0, 0)
                };

                Label lblPrice = new Label
                {
                    Text = $"${skin.Price:N2}",
                    ForeColor = Color.FromArgb(128, 255, 128),
                    Font = new Font("Consolas", 16, FontStyle.Bold),
                    Dock = DockStyle.Top,
                    Size = new Size(240, 40),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                Button btnBuy = new Button
                {
                    Text = "PURCHASE",
                    Size = new Size(220, 45),
                    Location = new Point(20, 310),
                    BackColor = Color.FromArgb(255, 152, 0),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Cursor = Cursors.Hand
                };
                btnBuy.FlatAppearance.BorderSize = 0;

                btnBuy.Click += (s, e) => {
                    MessageBox.Show($"You will be soon able to purchase {skin.Name}!", "Marketplace");
                };

                card.MouseEnter += (s, e) => card.BackColor = Color.FromArgb(50, 50, 50);
                card.MouseLeave += (s, e) => card.BackColor = Color.FromArgb(35, 35, 35);
                foreach (Control c in card.Controls)
                {
                    c.MouseEnter += (s, e) => card.BackColor = Color.FromArgb(50, 50, 50);
                }

                card.Controls.Add(btnBuy);
                card.Controls.Add(lblPrice);
                card.Controls.Add(lblName);
                card.Controls.Add(pb);

                flpSkins.Controls.Add(card);
            }

            flpSkins.ResumeLayout();
        }
    }
}
