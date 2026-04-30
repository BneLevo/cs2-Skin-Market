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
            txtSearch = new TextBox();
            btnFilter = new Button();
            lblMin = new Label();
            txtMinPrice = new TextBox();
            lblMax = new Label();
            txtMaxPrice = new TextBox();
            flpSkins = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(20, 20, 20);
            pnlHeader.Controls.Add(lblMin);
            pnlHeader.Controls.Add(txtMinPrice);
            pnlHeader.Controls.Add(lblMax);
            pnlHeader.Controls.Add(txtMaxPrice);
            pnlHeader.Controls.Add(txtSearch);
            pnlHeader.Controls.Add(btnFilter);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 100;            
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1200, 100);
            // 
            // lblMin
            // 
            txtSearch.BackColor = Color.FromArgb(45, 45, 48);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Segoe UI", 16F);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(350, 30);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search for skins, knives, gloves...";
            txtSearch.Size = new Size(500, 40);
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
            btnFilter.Location = new Point(860, 30);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(110, 35);
            btnFilter.Text = "FILTER";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // lblMin
            // 
            lblMin.ForeColor = Color.White;
            lblMin.Location = new Point(350, 75);
            lblMin.Text = "Min $:";
            lblMin.AutoSize = true;
            // 
            // txtMinPrice
            // 
            txtMinPrice.BackColor = Color.FromArgb(45, 45, 48);
            txtMinPrice.BorderStyle = BorderStyle.FixedSingle;
            txtMinPrice.ForeColor = Color.White;
            txtMinPrice.Location = new Point(400, 72);
            txtMinPrice.Size = new Size(60, 23);
            // 
            // lblMax
            // 
            lblMax.ForeColor = Color.White;
            lblMax.Location = new Point(480, 75);
            lblMax.Text = "Max $:";
            lblMax.AutoSize = true;
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.BackColor = Color.FromArgb(45, 45, 48);
            txtMaxPrice.BorderStyle = BorderStyle.FixedSingle;
            txtMaxPrice.ForeColor = Color.White;
            txtMaxPrice.Location = new Point(530, 72);
            txtMaxPrice.Size = new Size(60, 23);
            // 
            // flpSkins
            // 
            flpSkins.AutoScroll = true;
            flpSkins.BackColor = Color.FromArgb(30, 30, 30);
            flpSkins.Dock = DockStyle.Fill;
            flpSkins.Location = new Point(0, 100);
            flpSkins.Name = "flpSkins";
            flpSkins.Size = new Size(1200, 500);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(flpSkins);
            Controls.Add(pnlHeader);
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
    }
}