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
            lblMin = new Label();
            txtMinPrice = new TextBox();
            lblMax = new Label();
            txtMaxPrice = new TextBox();
            btnFilter = new Button();
            flpSkins = new FlowLayoutPanel();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(25, 25, 25);
            pnlHeader.Controls.Add(lblMin);
            pnlHeader.Controls.Add(txtMinPrice);
            pnlHeader.Controls.Add(lblMax);
            pnlHeader.Controls.Add(txtMaxPrice);
            pnlHeader.Controls.Add(btnFilter);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 2, 3, 2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(700, 60);
            pnlHeader.TabIndex = 1;
            pnlHeader.Height = 70;
            // 
            // lblMin
            // 
            lblMin.AutoSize = true;
            lblMin.ForeColor = Color.White;
            lblMin.Location = new Point(18, 22);
            lblMin.Name = "lblMin";
            lblMin.Size = new Size(40, 15);
            lblMin.TabIndex = 0;
            lblMin.Text = "Min $:";
            // 
            // txtMinPrice
            // 
            txtMinPrice.Location = new Point(61, 20);
            txtMinPrice.Margin = new Padding(3, 2, 3, 2);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.Size = new Size(70, 23);
            txtMinPrice.TabIndex = 1;
            txtMinPrice.BackColor = Color.FromArgb(45, 45, 48);
            txtMinPrice.ForeColor = Color.White;
            txtMinPrice.BorderStyle = BorderStyle.FixedSingle;
            // 
            // lblMax
            // 
            lblMax.AutoSize = true;
            lblMax.ForeColor = Color.White;
            lblMax.Location = new Point(149, 22);
            lblMax.Name = "lblMax";
            lblMax.Size = new Size(41, 15);
            lblMax.TabIndex = 2;
            lblMax.Text = "Max $:";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.Location = new Point(192, 20);
            txtMaxPrice.Margin = new Padding(3, 2, 3, 2);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.Size = new Size(70, 23);
            txtMaxPrice.TabIndex = 3;
            txtMaxPrice.BackColor = Color.FromArgb(45, 45, 48);
            txtMaxPrice.ForeColor = Color.White;
            txtMaxPrice.BorderStyle = BorderStyle.FixedSingle;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(76, 175, 80);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(280, 19);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(100, 30);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "FILTER";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.Cursor = Cursors.Hand;
            // 
            // flpSkins
            // 
            flpSkins.AutoScroll = true;
            flpSkins.BackColor = Color.FromArgb(30, 30, 30);
            flpSkins.Dock = DockStyle.Fill;
            flpSkins.Location = new Point(0, 60);
            flpSkins.Margin = new Padding(3, 2, 3, 2);
            flpSkins.Name = "flpSkins";
            flpSkins.Size = new Size(700, 278);
            flpSkins.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(flpSkins);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 2, 3, 2);
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
    }
}