namespace BID_Demirbas
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameText = new TextBox();
            passwordText = new TextBox();
            loginButton = new Button();
            staffRoleHolder = new Label();
            staffNameHolder = new Label();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 13F);
            usernameLabel.Location = new Point(125, 250);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(111, 25);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Kullanıcı Adı:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 13F);
            passwordLabel.Location = new Point(185, 297);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(51, 25);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Şifre:";
            // 
            // usernameText
            // 
            usernameText.Location = new Point(310, 252);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(185, 23);
            usernameText.TabIndex = 2;
            // 
            // passwordText
            // 
            passwordText.Location = new Point(310, 299);
            passwordText.Name = "passwordText";
            passwordText.Size = new Size(185, 23);
            passwordText.TabIndex = 3;
            passwordText.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 13F);
            loginButton.Location = new Point(310, 369);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(185, 38);
            loginButton.TabIndex = 4;
            loginButton.Text = "Giriş Yap";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // staffRoleHolder
            // 
            staffRoleHolder.AutoSize = true;
            staffRoleHolder.Location = new Point(191, 485);
            staffRoleHolder.Name = "staffRoleHolder";
            staffRoleHolder.Size = new Size(89, 15);
            staffRoleHolder.TabIndex = 5;
            staffRoleHolder.Text = "staffRoleHolder";
            staffRoleHolder.Visible = false;
            // 
            // staffNameHolder
            // 
            staffNameHolder.AutoSize = true;
            staffNameHolder.Location = new Point(485, 485);
            staffNameHolder.Name = "staffNameHolder";
            staffNameHolder.Size = new Size(98, 15);
            staffNameHolder.TabIndex = 6;
            staffNameHolder.Text = "staffNameHolder";
            staffNameHolder.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 578);
            Controls.Add(staffNameHolder);
            Controls.Add(staffRoleHolder);
            Controls.Add(loginButton);
            Controls.Add(passwordText);
            Controls.Add(usernameText);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox passwordText;
        private Button loginButton;
        public TextBox usernameText;
        public Label staffRoleHolder;
        public Label staffNameHolder;
    }
}