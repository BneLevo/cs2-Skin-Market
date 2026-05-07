namespace cs2_skins_market.UI.Forms
{
    partial class LoginForm
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
            btnRegister = new Button();
            btnLogin = new Button();
            _txtPassword = new TextBox();
            lblPassword = new Label();
            _txtUsername = new TextBox();
            lblUsername = new Label();
            lblSubtitle = new Label();
            lblTitle = new Label();
            cardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cardPanel
            // 
            cardPanel.BackColor = Color.FromArgb(35, 35, 35);
            cardPanel.Controls.Add(btnRegister);
            cardPanel.Controls.Add(btnLogin);
            cardPanel.Controls.Add(_txtPassword);
            cardPanel.Controls.Add(lblPassword);
            cardPanel.Controls.Add(_txtUsername);
            cardPanel.Controls.Add(lblUsername);
            cardPanel.Controls.Add(lblSubtitle);
            cardPanel.Controls.Add(lblTitle);
            cardPanel.Location = new Point(35, 35);
            cardPanel.Name = "cardPanel";
            cardPanel.Size = new Size(360, 255);
            cardPanel.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(255, 152, 0);
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(187, 205);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(148, 34);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += BtnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(76, 175, 80);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(25, 205);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(148, 34);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // _txtPassword
            // 
            _txtPassword.BackColor = Color.FromArgb(50, 50, 50);
            _txtPassword.BorderStyle = BorderStyle.FixedSingle;
            _txtPassword.ForeColor = Color.White;
            _txtPassword.Location = new Point(25, 158);
            _txtPassword.Name = "_txtPassword";
            _txtPassword.Size = new Size(310, 27);
            _txtPassword.TabIndex = 5;
            _txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = Color.Gainsboro;
            lblPassword.Location = new Point(25, 138);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // _txtUsername
            // 
            _txtUsername.BackColor = Color.FromArgb(50, 50, 50);
            _txtUsername.BorderStyle = BorderStyle.FixedSingle;
            _txtUsername.ForeColor = Color.White;
            _txtUsername.Location = new Point(25, 102);
            _txtUsername.Name = "_txtUsername";
            _txtUsername.Size = new Size(310, 27);
            _txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = Color.Gainsboro;
            lblUsername.Location = new Point(25, 82);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.Silver;
            lblSubtitle.Location = new Point(125, 50);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(120, 20);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Login to continue";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(95, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(186, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CS2 Marketplace";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(430, 330);
            Controls.Add(cardPanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            cardPanel.ResumeLayout(false);
            cardPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel cardPanel;
        private Button btnRegister;
        private Button btnLogin;
        private TextBox _txtPassword;
        private Label lblPassword;
        private TextBox _txtUsername;
        private Label lblUsername;
        private Label lblSubtitle;
        private Label lblTitle;
    }
}

