/**************************************************************************
* Nom du fichier : InventoryForm.Designer.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Code généré par le designer WinForms (UI de InventoryForm).
**************************************************************************/

namespace cs2_skins_market.UI.Forms
{
    partial class InventoryForm
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
            lblCount = new Label();
            lblPage = new Label();
            lblBrand = new Label();
            pnlBody = new Panel();
            pnlCard = new Panel();
            tblLayout = new TableLayoutPanel();
            lblTitle = new Label();
            flpInventory = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlCard.SuspendLayout();
            tblLayout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 20, 20);
            pnlHeader.Controls.Add(btnWallet);
            pnlHeader.Controls.Add(btnInventory);
            pnlHeader.Controls.Add(btnCart);
            pnlHeader.Controls.Add(btnMarket);
            pnlHeader.Controls.Add(lblCount);
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
            // btnInventory
            // 
            btnInventory.BackColor = Color.FromArgb(33, 150, 243);
            btnInventory.Enabled = false;
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
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.FromArgb(255, 152, 0);
            btnCart.Cursor = Cursors.Hand;
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
            btnMarket.Location = new Point(520, 28);
            btnMarket.Name = "btnMarket";
            btnMarket.Size = new Size(100, 32);
            btnMarket.TabIndex = 3;
            btnMarket.Text = "Marketplace";
            btnMarket.UseVisualStyleBackColor = false;
            btnMarket.Click += btnMarket_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCount.ForeColor = Color.FromArgb(128, 255, 128);
            lblCount.Location = new Point(24, 60);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(136, 23);
            lblCount.TabIndex = 2;
            lblCount.Text = "0 item(s) owned";
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Segoe UI", 9F);
            lblPage.ForeColor = Color.Silver;
            lblPage.Location = new Point(24, 38);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(102, 20);
            lblPage.TabIndex = 1;
            lblPage.Text = "Your inventory";
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
            tblLayout.ColumnCount = 1;
            tblLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblLayout.Controls.Add(lblTitle, 0, 0);
            tblLayout.Controls.Add(flpInventory, 0, 1);
            tblLayout.Dock = DockStyle.Fill;
            tblLayout.Location = new Point(20, 20);
            tblLayout.Name = "tblLayout";
            tblLayout.RowCount = 2;
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tblLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
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
            lblTitle.Text = "Purchased skins";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flpInventory
            // 
            flpInventory.AutoScroll = true;
            flpInventory.Dock = DockStyle.Fill;
            flpInventory.Location = new Point(3, 35);
            flpInventory.Name = "flpInventory";
            flpInventory.Size = new Size(1277, 574);
            flpInventory.TabIndex = 1;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1371, 800);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            ForeColor = Color.White;
            Name = "InventoryForm";
            Text = "Inventory — CS2 Skin Marketplace";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            tblLayout.ResumeLayout(false);
            tblLayout.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Button btnWallet;
        private Button btnInventory;
        private Button btnCart;
        private Button btnMarket;
        private Label lblCount;
        private Label lblPage;
        private Label lblBrand;
        private Panel pnlBody;
        private Panel pnlCard;
        private TableLayoutPanel tblLayout;
        private Label lblTitle;
        private FlowLayoutPanel flpInventory;
    }
}

