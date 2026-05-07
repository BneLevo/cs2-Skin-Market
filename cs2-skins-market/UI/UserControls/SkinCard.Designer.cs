namespace cs2_skins_market.UI.UserControls
{
    partial class SkinCard
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
            cardPanel = new Panel();
            btnAction = new Button();
            lblPrice = new Label();
            lblName = new Label();
            pbSkin = new PictureBox();
            cardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSkin).BeginInit();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.FromArgb(35, 35, 35);
            cardPanel.Controls.Add(btnAction);
            cardPanel.Controls.Add(lblPrice);
            cardPanel.Controls.Add(lblName);
            cardPanel.Controls.Add(pbSkin);
            cardPanel.Dock = DockStyle.Fill;
            cardPanel.Location = new Point(0, 0);
            cardPanel.Margin = new Padding(20);
            cardPanel.Name = "cardPanel";
            cardPanel.Padding = new Padding(10);
            cardPanel.Size = new Size(260, 380);
            cardPanel.TabIndex = 0;
            cardPanel.MouseEnter += cardPanel_MouseEnter;
            cardPanel.MouseLeave += cardPanel_MouseLeave;
            // 
            // btnAction
            // 
            btnAction.BackColor = Color.FromArgb(255, 152, 0);
            btnAction.Cursor = Cursors.Hand;
            btnAction.FlatAppearance.BorderSize = 0;
            btnAction.FlatStyle = FlatStyle.Flat;
            btnAction.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAction.ForeColor = Color.White;
            btnAction.Location = new Point(20, 310);
            btnAction.Name = "btnAction";
            btnAction.Size = new Size(220, 45);
            btnAction.TabIndex = 3;
            btnAction.Text = "ADD TO CART";
            btnAction.UseVisualStyleBackColor = false;
            btnAction.Click += btnAction_Click;
            btnAction.MouseEnter += cardPanel_MouseEnter;
            btnAction.MouseLeave += cardPanel_MouseLeave;
            // 
            // lblPrice
            // 
            lblPrice.Dock = DockStyle.Top;
            lblPrice.Font = new Font("Consolas", 16F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(128, 255, 128);
            lblPrice.Location = new Point(10, 230);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(240, 40);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "$0.00";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            lblPrice.MouseEnter += cardPanel_MouseEnter;
            lblPrice.MouseLeave += cardPanel_MouseLeave;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Top;
            lblName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(10, 170);
            lblName.Name = "lblName";
            lblName.Padding = new Padding(0, 10, 0, 0);
            lblName.Size = new Size(240, 60);
            lblName.TabIndex = 1;
            lblName.Text = "Skin Name";
            lblName.TextAlign = ContentAlignment.BottomCenter;
            lblName.MouseEnter += cardPanel_MouseEnter;
            lblName.MouseLeave += cardPanel_MouseLeave;
            // 
            // pbSkin
            // 
            pbSkin.Cursor = Cursors.Hand;
            pbSkin.Dock = DockStyle.Top;
            pbSkin.Location = new Point(10, 10);
            pbSkin.Name = "pbSkin";
            pbSkin.Size = new Size(240, 160);
            pbSkin.SizeMode = PictureBoxSizeMode.Zoom;
            pbSkin.TabIndex = 0;
            pbSkin.TabStop = false;
            pbSkin.MouseEnter += cardPanel_MouseEnter;
            pbSkin.MouseLeave += cardPanel_MouseLeave;
            // 
            // SkinCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cardPanel);
            Name = "SkinCard";
            Size = new Size(260, 380);
            cardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbSkin).EndInit();
            ResumeLayout(false);
        }

        private Panel cardPanel;
        private Button btnAction;
        private Label lblPrice;
        private Label lblName;
        private PictureBox pbSkin;
    }
}
