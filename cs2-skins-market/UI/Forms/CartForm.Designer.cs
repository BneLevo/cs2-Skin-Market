namespace cs2_skins_market.UI.Forms
{
    partial class CartForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblBrand = new Label();
            _lblSubtitle = new Label();
            _lblBudget = new Label();
            btnMarket = new Button();
            btnCart = new Button();
            btnInventory = new Button();
            btnWallet = new Button();
            pnlBody = new Panel();
            pnlCard = new Panel();
            tblLayout = new TableLayoutPanel();
            lblTitle = new Label();
            _cardsPanel = new FlowLayoutPanel();
            pnlBottom = new Panel();
            _lblTotal = new Label();
            btnPurchase = new Button();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlCard.SuspendLayout();
            tblLayout.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 20, 20);
            pnlHeader.Controls.Add(btnWallet);
            pnlHeader.Controls.Add(btnInventory);
            pnlHeader.Controls.Add(btnCart);
            pnlHeader.Controls.Add(btnMarket);
            pnlHeader.Controls.Add(_lblBudget);
            pnlHeader.Controls.Add(_lblSubtitle);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1371, 100);
            pnlHeader.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(24, 14);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(189, 25);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "CS2 Skin Marketplace";
            // 
            // _lblSubtitle
            // 
            _lblSubtitle.AutoSize = true;
            _lblSubtitle.Font = new Font("Segoe UI", 9F);
            _lblSubtitle.ForeColor = Color.Silver;
            _lblSubtitle.Location = new Point(24, 38);
            _lblSubtitle.Name = "_lblSubtitle";
            _lblSubtitle.Size = new Size(98, 20);
            _lblSubtitle.TabIndex = 1;
            _lblSubtitle.Text = "Shopping cart";
            // 
            // _lblBudget
            // 
            _lblBudget.AutoSize = true;
            _lblBudget.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _lblBudget.ForeColor = Color.FromArgb(128, 255, 128);
            _lblBudget.Location = new Point(24, 60);
            _lblBudget.Name = "_lblBudget";
            _lblBudget.Size = new Size(111, 23);
            _lblBudget.TabIndex = 2;
            _lblBudget.Text = "Budget: $0.00";
            // 
            // btnMarket
            // 
            btnMarket.BackColor = Color.FromArgb(76, 175, 80);
            btnMarket.Cursor = Cursors.Hand;
            btnMarket.FlatAppearance.BorderSize = 0;
            btnMarket.FlatStyle = FlatStyle.Flat;
            btnMarket.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMarket.ForeColor = Color.White;
            btnMarket.Location = new Point(520, 28);
            btnMarket.Name = "btnMarket";
            btnMarket.Size = new Size(100, 32);
            btnMarket.TabIndex = 3;
            btnMarket.Text = "Marketplace";
            btnMarket.UseVisualStyleBackColor = false;
            btnMarket.Click += btnMarket_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.FromArgb(255, 152, 0);
            btnCart.Enabled = false;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCart.ForeColor = Color.White;
            btnCart.Location = new Point(628, 28);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(100, 32);
            btnCart.TabIndex = 4;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(33, 150, 243);
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(736, 28);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(100, 32);
            btnInventory.TabIndex = 5;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnWallet
            // 
            btnWallet.BackColor = Color.FromArgb(0, 188, 212);
            btnWallet.Cursor = Cursors.Hand;
            btnWallet.FlatAppearance.BorderSize = 0;
            btnWallet.FlatStyle = FlatStyle.Flat;
            btnWallet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWallet.ForeColor = Color.White;
            btnWallet.Location = new Point(844, 28);
            btnWallet.Name = "btnWallet";
            btnWallet.Size = new Size(100, 32);
            btnWallet.TabIndex = 6;
            btnWallet.Text = "Wallet";
            btnWallet.UseVisualStyleBackColor = false;
            btnWallet.Click += btnWallet_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(30, 30, 30);
            pnlBody.Controls.Add(pnlCard);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 100);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(24);
            pnlBody.Size = new Size(1371, 700);
            pnlBody.TabIndex = 1;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(35, 35, 35);
            pnlCard.Controls.Add(tblLayout);
            pnlCard.Dock = DockStyle.Fill;
            pnlCard.Location = new Point(24, 24);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(20);
            pnlCard.Size = new Size(1323, 652);
            pnlCard.TabIndex = 0;
            // 
            // tblLayout
            // 
            tblLayout.BackColor = Color.FromArgb(35, 35, 35);
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(lblTitle, 0, 0);
            tblLayout.Controls.Add(_cardsPanel, 0, 1);
            tblLayout.Controls.Add(pnlBottom, 0, 2);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(20, 20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 3;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 108F));
            tblLayout.Size = new Size(1283, 612);
            tblLayout.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1277, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Items in your cart";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // _cardsPanel
            // 
            _cardsPanel.AutoScroll = true;
            _cardsPanel.BackColor = Color.FromArgb(35, 35, 35);
            _cardsPanel.Dock = DockStyle.Fill;
            _cardsPanel.Location = new Point(3, 35);
            _cardsPanel.Name = "_cardsPanel";
            _cardsPanel.Size = new Size(1277, 466);
            _cardsPanel.TabIndex = 1;
            _cardsPanel.WrapContents = true;
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.FromArgb(35, 35, 35);
            pnlBottom.Controls.Add(btnPurchase);
            pnlBottom.Controls.Add(_lblTotal);
            pnlBottom.Dock = DockStyle.Fill;
            pnlBottom.Location = new Point(3, 507);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Padding = new Padding(0, 12, 0, 0);
            pnlBottom.Size = new Size(1277, 102);
            pnlBottom.TabIndex = 2;
            // 
            // _lblTotal
            // 
            _lblTotal.AutoSize = true;
            _lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _lblTotal.ForeColor = Color.Gainsboro;
            _lblTotal.Location = new Point(0, 0);
            _lblTotal.Name = "_lblTotal";
            _lblTotal.Size = new Size(110, 23);
            _lblTotal.TabIndex = 0;
            _lblTotal.Text = "Cart total: $0";
            // 
            // btnPurchase
            // 
            btnPurchase.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPurchase.BackColor = Color.FromArgb(76, 175, 80);
            btnPurchase.Cursor = Cursors.Hand;
            btnPurchase.FlatAppearance.BorderSize = 0;
            btnPurchase.FlatStyle = FlatStyle.Flat;
            btnPurchase.ForeColor = Color.White;
            btnPurchase.Location = new Point(1117, 32);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(160, 36);
            btnPurchase.TabIndex = 1;
            btnPurchase.Text = "Purchase";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += BtnPurchase_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1371, 800);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            ForeColor = Color.White;
            Name = "CartForm";
            Text = "Cart — CS2 Skin Marketplace";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            tblLayout.ResumeLayout(false);
            tblLayout.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblBrand;
        private Label _lblSubtitle;
        private Label _lblBudget;
        private Button btnMarket;
        private Button btnCart;
        private Button btnInventory;
        private Button btnWallet;
        private Panel pnlBody;
        private Panel pnlCard;
        private TableLayoutPanel tblLayout;
        private Label lblTitle;
        private FlowLayoutPanel _cardsPanel;
        private Panel pnlBottom;
        private Label _lblTotal;
        private Button btnPurchase;
    }
}

