namespace ont_design
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            logoPanelLoginPage = new Panel();
            loginPagePanelLogo = new PictureBox();
            LoginFormPanel = new Panel();
            viewPasswordBox = new CheckBox();
            linkLabelToQuitApp = new LinkLabel();
            signInButton = new Button();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            userNameLabel = new Label();
            signInLabel = new Label();
            forgotPasswordLink = new LinkLabel();
            logoPanelLoginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loginPagePanelLogo).BeginInit();
            LoginFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoPanelLoginPage
            // 
            logoPanelLoginPage.BackColor = SystemColors.ActiveCaptionText;
            logoPanelLoginPage.Controls.Add(loginPagePanelLogo);
            logoPanelLoginPage.Location = new Point(0, -2);
            logoPanelLoginPage.Name = "logoPanelLoginPage";
            logoPanelLoginPage.Size = new Size(404, 452);
            logoPanelLoginPage.TabIndex = 0;
            // 
            // loginPagePanelLogo
            // 
            loginPagePanelLogo.Image = (Image)resources.GetObject("loginPagePanelLogo.Image");
            loginPagePanelLogo.Location = new Point(34, 71);
            loginPagePanelLogo.Name = "loginPagePanelLogo";
            loginPagePanelLogo.Size = new Size(345, 331);
            loginPagePanelLogo.TabIndex = 0;
            loginPagePanelLogo.TabStop = false;
            // 
            // LoginFormPanel
            // 
            LoginFormPanel.BackColor = Color.Red;
            LoginFormPanel.Controls.Add(forgotPasswordLink);
            LoginFormPanel.Controls.Add(viewPasswordBox);
            LoginFormPanel.Controls.Add(linkLabelToQuitApp);
            LoginFormPanel.Controls.Add(signInButton);
            LoginFormPanel.Controls.Add(passwordTextBox);
            LoginFormPanel.Controls.Add(passwordLabel);
            LoginFormPanel.Controls.Add(usernameTextBox);
            LoginFormPanel.Controls.Add(userNameLabel);
            LoginFormPanel.Controls.Add(signInLabel);
            LoginFormPanel.Location = new Point(403, -5);
            LoginFormPanel.Name = "LoginFormPanel";
            LoginFormPanel.Size = new Size(400, 455);
            LoginFormPanel.TabIndex = 1;
            // 
            // viewPasswordBox
            // 
            viewPasswordBox.AutoSize = true;
            viewPasswordBox.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewPasswordBox.ForeColor = SystemColors.ButtonHighlight;
            viewPasswordBox.Location = new Point(245, 266);
            viewPasswordBox.Name = "viewPasswordBox";
            viewPasswordBox.Size = new Size(127, 20);
            viewPasswordBox.TabIndex = 8;
            viewPasswordBox.Text = "Show Password";
            viewPasswordBox.UseVisualStyleBackColor = true;
            viewPasswordBox.CheckedChanged += viewPasswordBox_CheckedChanged;
            // 
            // linkLabelToQuitApp
            // 
            linkLabelToQuitApp.AutoSize = true;
            linkLabelToQuitApp.DisabledLinkColor = Color.Black;
            linkLabelToQuitApp.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelToQuitApp.LinkColor = Color.White;
            linkLabelToQuitApp.Location = new Point(366, 14);
            linkLabelToQuitApp.Name = "linkLabelToQuitApp";
            linkLabelToQuitApp.Size = new Size(19, 19);
            linkLabelToQuitApp.TabIndex = 7;
            linkLabelToQuitApp.TabStop = true;
            linkLabelToQuitApp.Text = "X";
            linkLabelToQuitApp.LinkClicked += linkLabelToQuitApp_LinkClicked;
            // 
            // signInButton
            // 
            signInButton.Font = new Font("MS Reference Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signInButton.ForeColor = Color.Red;
            signInButton.Location = new Point(34, 317);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(338, 34);
            signInButton.TabIndex = 6;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(36, 216);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(336, 23);
            passwordTextBox.TabIndex = 4;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.CausesValidation = false;
            passwordLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(34, 193);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(86, 20);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(34, 136);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(338, 23);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += Username_TextChanged;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.CausesValidation = false;
            userNameLabel.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(34, 113);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(91, 20);
            userNameLabel.TabIndex = 1;
            userNameLabel.Text = "Username";
            // 
            // signInLabel
            // 
            signInLabel.AutoSize = true;
            signInLabel.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signInLabel.ForeColor = Color.White;
            signInLabel.Location = new Point(148, 40);
            signInLabel.Name = "signInLabel";
            signInLabel.Size = new Size(105, 29);
            signInLabel.TabIndex = 0;
            signInLabel.Text = "Sign In";
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.AutoSize = true;
            forgotPasswordLink.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPasswordLink.LinkColor = Color.White;
            forgotPasswordLink.Location = new Point(36, 372);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(121, 16);
            forgotPasswordLink.TabIndex = 9;
            forgotPasswordLink.TabStop = true;
            forgotPasswordLink.Text = "Forgot Password?";
            forgotPasswordLink.LinkClicked += forgotPasswordLink_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginFormPanel);
            Controls.Add(logoPanelLoginPage);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            logoPanelLoginPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)loginPagePanelLogo).EndInit();
            LoginFormPanel.ResumeLayout(false);
            LoginFormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel logoPanelLoginPage;
        private PictureBox loginPagePanelLogo;
        private Panel LoginFormPanel;
        private Label signInLabel;
        private Button signInButton;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private Label userNameLabel;
        private LinkLabel linkLabelToQuitApp;
        private CheckBox viewPasswordBox;
        private LinkLabel forgotPasswordLink;
    }
}