namespace cs2_skins_market.UI.Forms
{
    partial class RegisterForm
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
            btnCreate = new Button();
            _txtBudget = new TextBox();
            lblBudget = new Label();
            _txtPassword = new TextBox();
            lblPassword = new Label();
            _txtUsername = new TextBox();
            lblUsername = new Label();
            lblTitle = new Label();
            cardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.FromArgb(35, 35, 35);
            cardPanel.Controls.Add(btnCreate);
            cardPanel.Controls.Add(_txtBudget);
            cardPanel.Controls.Add(lblBudget);
            cardPanel.Controls.Add(_txtPassword);
            cardPanel.Controls.Add(lblPassword);
            cardPanel.Controls.Add(_txtUsername);
            cardPanel.Controls.Add(lblUsername);
            cardPanel.Controls.Add(lblTitle);
            cardPanel.Location = new Point(35, 35);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(360, 320);
            cardPanel.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(255, 152, 0);
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(25, 252);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(310, 36);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += BtnCreate_Click;
            // 
            // _txtBudget
            // 
            _txtBudget.BackColor = Color.FromArgb(50, 50, 50);
            _txtBudget.BorderStyle = BorderStyle.FixedSingle;
            _txtBudget.ForeColor = Color.White;
            _txtBudget.Location = new Point(25, 200);
            _txtBudget.Name = "_txtBudget";
            _txtBudget.Size = new Size(310, 27);
            _txtBudget.TabIndex = 6;
            // 
            // lblBudget
            // 
            lblBudget.AutoSize = true;
            lblBudget.ForeColor = Color.Gainsboro;
            lblBudget.Location = new Point(25, 180);
            lblBudget.Name = "lblBudget";
            lblBudget.Size = new Size(111, 20);
            lblBudget.TabIndex = 5;
            lblBudget.Text = "Starting Budget";
            // 
            // _txtPassword
            // 
            _txtPassword.BackColor = Color.FromArgb(50, 50, 50);
            _txtPassword.BorderStyle = BorderStyle.FixedSingle;
            _txtPassword.ForeColor = Color.White;
            _txtPassword.Location = new Point(25, 145);
            _txtPassword.Name = "_txtPassword";
            _txtPassword.Size = new Size(310, 27);
            _txtPassword.TabIndex = 4;
            _txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.Gainsboro;
            lblPassword.Location = new Point(25, 125);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // _txtUsername
            // 
            _txtUsername.BackColor = Color.FromArgb(50, 50, 50);
            _txtUsername.BorderStyle = BorderStyle.FixedSingle;
            _txtUsername.ForeColor = Color.White;
            _txtUsername.Location = new Point(25, 90);
            _txtUsername.Name = "_txtUsername";
            _txtUsername.Size = new Size(310, 27);
            _txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.Gainsboro;
            lblUsername.Location = new Point(25, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(100, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(191, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Create Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(430, 390);
            Controls.Add(cardPanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Register";
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel cardPanel;
        private Button btnCreate;
        private TextBox _txtBudget;
        private Label lblBudget;
        private TextBox _txtPassword;
        private Label lblPassword;
        private TextBox _txtUsername;
        private Label lblUsername;
        private Label lblTitle;
    }
}

