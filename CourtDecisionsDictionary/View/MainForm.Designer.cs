namespace CourtDecisionsDictionary.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlAuth = new System.Windows.Forms.Panel();
            this.picAuthIcon = new System.Windows.Forms.PictureBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.pnlCurrentUserInfo = new System.Windows.Forms.Panel();
            this.picUserIcon = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.pnlUsersDesktopContainer = new System.Windows.Forms.Panel();
            this.btnLoginAsClient = new System.Windows.Forms.Button();
            this.pnlAuth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthIcon)).BeginInit();
            this.pnlCurrentUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAuth
            // 
            this.pnlAuth.Controls.Add(this.btnLoginAsClient);
            this.pnlAuth.Controls.Add(this.picAuthIcon);
            this.pnlAuth.Controls.Add(this.lblPassword);
            this.pnlAuth.Controls.Add(this.lblLogin);
            this.pnlAuth.Controls.Add(this.btnLogin);
            this.pnlAuth.Controls.Add(this.txtPassword);
            this.pnlAuth.Controls.Add(this.txtLogin);
            this.pnlAuth.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAuth.Location = new System.Drawing.Point(0, 0);
            this.pnlAuth.Name = "pnlAuth";
            this.pnlAuth.Size = new System.Drawing.Size(655, 50);
            this.pnlAuth.TabIndex = 5;
            // 
            // picAuthIcon
            // 
            this.picAuthIcon.Image = ((System.Drawing.Image)(resources.GetObject("picAuthIcon.Image")));
            this.picAuthIcon.Location = new System.Drawing.Point(6, 7);
            this.picAuthIcon.Name = "picAuthIcon";
            this.picAuthIcon.Size = new System.Drawing.Size(35, 35);
            this.picAuthIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAuthIcon.TabIndex = 10;
            this.picAuthIcon.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(211, 19);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(50, 18);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(36, 13);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(389, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(99, 26);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Авторизация";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(270, 15);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(113, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(89, 14);
            this.txtLogin.MaxLength = 20;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(113, 20);
            this.txtLogin.TabIndex = 5;
            // 
            // pnlCurrentUserInfo
            // 
            this.pnlCurrentUserInfo.Controls.Add(this.picUserIcon);
            this.pnlCurrentUserInfo.Controls.Add(this.btnLogout);
            this.pnlCurrentUserInfo.Controls.Add(this.lblCurrentUser);
            this.pnlCurrentUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCurrentUserInfo.Location = new System.Drawing.Point(0, 50);
            this.pnlCurrentUserInfo.Name = "pnlCurrentUserInfo";
            this.pnlCurrentUserInfo.Size = new System.Drawing.Size(655, 40);
            this.pnlCurrentUserInfo.TabIndex = 6;
            // 
            // picUserIcon
            // 
            this.picUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("picUserIcon.Image")));
            this.picUserIcon.Location = new System.Drawing.Point(6, 2);
            this.picUserIcon.Name = "picUserIcon";
            this.picUserIcon.Size = new System.Drawing.Size(35, 35);
            this.picUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUserIcon.TabIndex = 7;
            this.picUserIcon.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogout.Location = new System.Drawing.Point(550, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(105, 40);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Выйти";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.AutoSize = true;
            this.lblCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentUser.Location = new System.Drawing.Point(47, 14);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(116, 13);
            this.lblCurrentUser.TabIndex = 9;
            this.lblCurrentUser.Text = "Вы вошли как: %%";
            // 
            // pnlUsersDesktopContainer
            // 
            this.pnlUsersDesktopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUsersDesktopContainer.Location = new System.Drawing.Point(0, 90);
            this.pnlUsersDesktopContainer.Name = "pnlUsersDesktopContainer";
            this.pnlUsersDesktopContainer.Size = new System.Drawing.Size(655, 384);
            this.pnlUsersDesktopContainer.TabIndex = 7;
            // 
            // btnLoginAsClient
            // 
            this.btnLoginAsClient.Location = new System.Drawing.Point(494, 12);
            this.btnLoginAsClient.Name = "btnLoginAsClient";
            this.btnLoginAsClient.Size = new System.Drawing.Size(135, 26);
            this.btnLoginAsClient.TabIndex = 11;
            this.btnLoginAsClient.Text = "Войти как клиент";
            this.btnLoginAsClient.UseVisualStyleBackColor = true;
            this.btnLoginAsClient.Click += new System.EventHandler(this.btnLoginAsClient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 474);
            this.Controls.Add(this.pnlUsersDesktopContainer);
            this.Controls.Add(this.pnlCurrentUserInfo);
            this.Controls.Add(this.pnlAuth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочная система по судебным решениям";
            this.pnlAuth.ResumeLayout(false);
            this.pnlAuth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAuthIcon)).EndInit();
            this.pnlCurrentUserInfo.ResumeLayout(false);
            this.pnlCurrentUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAuth;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Panel pnlCurrentUserInfo;
        private System.Windows.Forms.PictureBox picUserIcon;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Panel pnlUsersDesktopContainer;
        private System.Windows.Forms.PictureBox picAuthIcon;
        private System.Windows.Forms.Button btnLoginAsClient;
    }
}

