/**************************************************************************
* Nom du fichier : Form1.Designer.cs
* Auteur : Ozgun Levent
* Date de création : 06.05.2026
* Description : Code généré par le designer WinForms (UI de Form1).
**************************************************************************/

namespace cs2_skins_market
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblBudget = new Label();
            btnCart = new Button();
            btnInventory = new Button();
            btnWallet = new Button();
            btnLogout = new Button();
            lblMin = new Label();
            txtMinPrice = new TextBox();
            lblMax = new Label();
            txtMaxPrice = new TextBox();
            txtSearch = new TextBox();
            btnFilter = new Button();
            flpSkins = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 20, 20);
            pnlHeader.Controls.Add(lblBudget);
            pnlHeader.Controls.Add(btnCart);
            pnlHeader.Controls.Add(btnInventory);
            pnlHeader.Controls.Add(btnWallet);
            pnlHeader.Controls.Add(btnLogout);
            pnlHeader.Controls.Add(lblMin);
            pnlHeader.Controls.Add(txtMinPrice);
            pnlHeader.Controls.Add(lblMax);
            pnlHeader.Controls.Add(txtMaxPrice);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(btnFilter);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1371, 133);
            pnlHeader.TabIndex = 1;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.ForeColor = Color.White;
            lblBudget.Location = new Point(23, 27);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(99, 20);
            lblBudget.TabIndex = 0;
            lblBudget.Text = "Budget: $0.00";
            // 
            // btnCart
            // 
            btnCart.Location = new Point(23, 67);
            btnCart.Margin = new Padding(3, 4, 3, 4);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(101, 43);
            btnCart.TabIndex = 1;
            btnCart.Text = "Cart (0)";
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // btnInventory
            // 
            btnInventory.Location = new Point(133, 67);
            btnInventory.Margin = new Padding(3, 4, 3, 4);
            btnInventory.Name = "btnInventory";
            btnInventory.Size = new Size(101, 43);
            btnInventory.TabIndex = 2;
            btnInventory.Text = "Inventory";
            btnInventory.UseVisualStyleBackColor = false;
            btnInventory.Click += btnInventory_Click;
            // 
            // btnWallet
            // 
            btnWallet.Location = new Point(242, 67);
            btnWallet.Margin = new Padding(3, 4, 3, 4);
            btnWallet.Name = "btnWallet";
            btnWallet.Size = new Size(101, 43);
            btnWallet.TabIndex = 3;
            btnWallet.Text = "Wallet";
            btnWallet.UseVisualStyleBackColor = false;
            btnWallet.Click += btnWallet_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1258, 67);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(101, 43);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.ForeColor = Color.White;
            lblMin.Location = new Point(568, 102);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(49, 20);
            lblMin.TabIndex = 5;
            lblMin.Text = "Min $:";
            // 
            // txtMinPrice
            // 
            txtMinPrice.BackColor = Color.FromArgb(45, 45, 48);
            txtMinPrice.BorderStyle = BorderStyle.FixedSingle;
            txtMinPrice.ForeColor = Color.White;
            txtMinPrice.Location = new Point(623, 98);
            txtMinPrice.Margin = new Padding(3, 4, 3, 4);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(68, 27);
            txtMinPrice.TabIndex = 6;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.ForeColor = Color.White;
            lblMax.Location = new Point(705, 102);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(52, 20);
            lblMax.TabIndex = 7;
            lblMax.Text = "Max $:";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.BackColor = Color.FromArgb(45, 45, 48);
            txtMaxPrice.BorderStyle = BorderStyle.FixedSingle;
            txtMaxPrice.ForeColor = Color.White;
            txtMaxPrice.Location = new Point(760, 98);
            txtMaxPrice.Margin = new Padding(3, 4, 3, 4);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(68, 27);
            txtMaxPrice.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(45, 45, 48);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 16F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(457, 40);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for skins, knives, gloves...";
            txtSearch.Size = new Size(509, 36);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(76, 175, 80);
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(1013, 40);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(126, 47);
            btnFilter.TabIndex = 9;
            btnFilter.Text = "FILTER";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // flpSkins
            // 
            flpSkins.AutoScroll = true;
            flpSkins.BackColor = Color.FromArgb(30, 30, 30);
            flpSkins.Dock = DockStyle.Fill;
            flpSkins.Location = new Point(0, 133);
            flpSkins.Margin = new Padding(3, 4, 3, 4);
            flpSkins.Name = "flpSkins";
            flpSkins.Size = new Size(1371, 667);
            flpSkins.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 800);
            Controls.Add(flpSkins);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "CS2 Skin Marketplace";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpSkins;
        private Panel pnlHeader;
        private TextBox txtMinPrice;
        private TextBox txtMaxPrice;
        private Button btnFilter;
        private Label lblMin;
        private Label lblMax;
        private TextBox txtSearch;
        private Label lblBudget;
        private Button btnCart;
        private Button btnInventory;
        private Button btnWallet;
        private Button btnLogout;
    }
}