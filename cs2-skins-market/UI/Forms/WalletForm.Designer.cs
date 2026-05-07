/**************************************************************************
* Nom du fichier : WalletForm.Designer.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Code généré par le designer WinForms (UI de WalletForm).
**************************************************************************/

namespace cs2_skins_market.UI.Forms
{
    partial class WalletForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Libère les ressources managées.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initialise l'arborescence des contrôles WinForms.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            btnWallet = new Button();
            btnInventory = new Button();
            btnCart = new Button();
            btnMarket = new Button();
            _lblBalance = new Label();
            lblPage = new Label();
            lblBrand = new Label();
            pnlBody = new Panel();
            pnlCard = new Panel();
            btnDeposit = new Button();
            _txtAmount = new TextBox();
            lblAmount = new Label();
            lblHint = new Label();
            lblDepositTitle = new Label();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlCard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 20, 20);
            pnlHeader.Controls.Add(btnWallet);
            pnlHeader.Controls.Add(btnInventory);
            pnlHeader.Controls.Add(btnCart);
            pnlHeader.Controls.Add(btnMarket);
            pnlHeader.Controls.Add(_lblBalance);
            pnlHeader.Controls.Add(lblPage);
            pnlHeader.Controls.Add(lblBrand);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1371, 100);
            pnlHeader.TabIndex = 0;
            // 
            // btnWallet
            // 
            btnWallet.BackColor = Color.FromArgb(0, 188, 212);
            btnWallet.Enabled = false;
            btnWallet.FlatAppearance.BorderSize = 0;
            btnWallet.FlatStyle = FlatStyle.Flat;
            btnWallet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWallet.ForeColor = Color.White;
            btnWallet.Location = new Point(920, 28);
            btnWallet.Name = "btnWallet";
            btnWallet.Size = new Size(100, 32);
            btnWallet.TabIndex = 6;
            btnWallet.Text = "Wallet";
            btnWallet.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(33, 150, 243);
            btnInventory.Cursor = Cursors.Hand;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(820, 28);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(100, 32);
            btnInventory.TabIndex = 5;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.FromArgb(255, 152, 0);
            btnCart.Cursor = Cursors.Hand;
            btnCart.FlatAppearance.BorderSize = 0;
            btnCart.FlatStyle = FlatStyle.Flat;
            btnCart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCart.ForeColor = Color.White;
            btnCart.Location = new Point(740, 28);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(80, 32);
            btnCart.TabIndex = 4;
            btnCart.Text = "Cart";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // btnMarket
            // 
            btnMarket.BackColor = Color.FromArgb(76, 175, 80);
            btnMarket.Cursor = Cursors.Hand;
            btnMarket.FlatAppearance.BorderSize = 0;
            btnMarket.FlatStyle = FlatStyle.Flat;
            btnMarket.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMarket.ForeColor = Color.White;
            btnMarket.Location = new Point(640, 28);
            btnMarket.Name = "btnMarket";
            btnMarket.Size = new Size(100, 32);
            btnMarket.TabIndex = 3;
            btnMarket.Text = "Marketplace";
            btnMarket.UseVisualStyleBackColor = false;
            btnMarket.Click += btnMarket_Click;
            // 
            // _lblBalance
            // 
            _lblBalance.AutoSize = true;
            _lblBalance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _lblBalance.ForeColor = Color.FromArgb(128, 255, 128);
            _lblBalance.Location = new Point(24, 62);
            _lblBalance.Name = "_lblBalance";
            _lblBalance.Size = new Size(160, 23);
            _lblBalance.TabIndex = 2;
            _lblBalance.Text = "Current balance: $0";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Segoe UI", 9F);
            lblPage.ForeColor = Color.Silver;
            lblPage.Location = new Point(24, 38);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(255, 20);
            lblPage.TabIndex = 1;
            lblPage.Text = "Wallet - add funds to your account";
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
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(30, 30, 30);
            pnlBody.Controls.Add(pnlCard);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 100);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(32);
            pnlBody.Size = new Size(1371, 700);
            pnlBody.TabIndex = 1;
            // 
            // pnlCard
            // 
            pnlCard.BackColor = Color.FromArgb(35, 35, 35);
            pnlCard.Controls.Add(btnDeposit);
            pnlCard.Controls.Add(_txtAmount);
            pnlCard.Controls.Add(lblAmount);
            pnlCard.Controls.Add(lblHint);
            pnlCard.Controls.Add(lblDepositTitle);
            pnlCard.Location = new Point(32, 24);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new Padding(24);
            pnlCard.Size = new Size(560, 360);
            pnlCard.TabIndex = 0;
            // 
            // btnDeposit
            // 
            btnDeposit.BackColor = Color.FromArgb(76, 175, 80);
            btnDeposit.FlatAppearance.BorderSize = 0;
            btnDeposit.FlatStyle = FlatStyle.Flat;
            btnDeposit.ForeColor = Color.White;
            btnDeposit.Location = new Point(280, 118);
            btnDeposit.Name = "btnDeposit";
            btnDeposit.Size = new Size(120, 32);
            btnDeposit.TabIndex = 4;
            btnDeposit.Text = "Deposit";
            btnDeposit.UseVisualStyleBackColor = false;
            btnDeposit.Click += BtnDeposit_Click;
            // 
            // _txtAmount
            // 
            _txtAmount.BackColor = Color.FromArgb(50, 50, 50);
            _txtAmount.BorderStyle = BorderStyle.FixedSingle;
            _txtAmount.ForeColor = Color.White;
            _txtAmount.Location = new Point(24, 122);
            _txtAmount.Name = "_txtAmount";
            _txtAmount.Size = new Size(240, 27);
            _txtAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.ForeColor = Color.Gainsboro;
            lblAmount.Location = new Point(24, 100);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(62, 20);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.ForeColor = Color.Silver;
            lblHint.Location = new Point(24, 56);
            lblHint.MaximumSize = new Size(500, 0);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(219, 20);
            lblHint.TabIndex = 1;
            lblHint.Text = "Enter how much you want to add";
            // 
            // lblDepositTitle
            // 
            lblDepositTitle.AutoSize = true;
            lblDepositTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblDepositTitle.ForeColor = Color.White;
            lblDepositTitle.Location = new Point(24, 24);
            lblDepositTitle.Name = "lblDepositTitle";
            lblDepositTitle.Size = new Size(144, 30);
            lblDepositTitle.TabIndex = 0;
            lblDepositTitle.Text = "Deposit funds";
            // 
            // WalletForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1371, 800);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            ForeColor = Color.White;
            Name = "WalletForm";
            Text = "Wallet — CS2 Skin Marketplace";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Button btnWallet;
        private Button btnInventory;
        private Button btnCart;
        private Button btnMarket;
        private Label _lblBalance;
        private Label lblPage;
        private Label lblBrand;
        private Panel pnlBody;
        private Panel pnlCard;
        private Button btnDeposit;
        private TextBox _txtAmount;
        private Label lblAmount;
        private Label lblHint;
        private Label lblDepositTitle;
    }
}

