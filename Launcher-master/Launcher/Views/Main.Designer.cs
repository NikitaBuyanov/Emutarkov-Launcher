namespace Launcher
{
    partial class Main
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.StartGame = new System.Windows.Forms.Button();
			this.LoginEmailLabel = new System.Windows.Forms.Label();
			this.LoginEmail = new System.Windows.Forms.TextBox();
			this.LoginPassword = new System.Windows.Forms.TextBox();
			this.LoginPasswordLabel = new System.Windows.Forms.Label();
			this.TrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.Background = new System.Windows.Forms.PictureBox();
			this.RegisterEdition = new System.Windows.Forms.ComboBox();
			this.RegisterEditionLabel = new System.Windows.Forms.Label();
			this.RegisterPassword = new System.Windows.Forms.TextBox();
			this.RegisterPasswordLabel = new System.Windows.Forms.Label();
			this.RegisterEmail = new System.Windows.Forms.TextBox();
			this.RegisterEmailLabel = new System.Windows.Forms.Label();
			this.RegisterButton = new System.Windows.Forms.Button();
			this.LoginButton = new System.Windows.Forms.Button();
			this.RegisterInsteadButton = new System.Windows.Forms.Button();
			this.LoginInsteadButton = new System.Windows.Forms.Button();
			this.ConnectButton = new System.Windows.Forms.Button();
			this.LogoutButton = new System.Windows.Forms.Button();
			this.BackToProfileView = new System.Windows.Forms.Button();
			this.RefreshServerListButton = new System.Windows.Forms.Button();
			this.ServerLabel = new System.Windows.Forms.Label();
			this.ServerList = new System.Windows.Forms.ComboBox();
			this.AddServerInsteadButton = new System.Windows.Forms.Button();
			this.ViewServersInsteadButton = new System.Windows.Forms.Button();
			this.UrlLabel = new System.Windows.Forms.Label();
			this.AddServer = new System.Windows.Forms.TextBox();
			this.AddServerButton = new System.Windows.Forms.Button();
			this.ChangeEmailButton = new System.Windows.Forms.Button();
			this.ChangePasswordButton = new System.Windows.Forms.Button();
			this.ChangeEmail = new System.Windows.Forms.TextBox();
			this.ChangeEmailLabel = new System.Windows.Forms.Label();
			this.ChangePassword = new System.Windows.Forms.TextBox();
			this.ChangePasswordLabel = new System.Windows.Forms.Label();
			this.ChangePasswordViewButton = new System.Windows.Forms.Button();
			this.ChangeEmailViewButton = new System.Windows.Forms.Button();
			this.WipeViewButton = new System.Windows.Forms.Button();
			this.WipeButton = new System.Windows.Forms.Button();
			this.WipeLabel = new System.Windows.Forms.Label();
			this.WipeEdition = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
			this.SuspendLayout();
			// 
			// StartGame
			// 
			this.StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.StartGame.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StartGame.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StartGame.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.StartGame.Location = new System.Drawing.Point(405, 391);
			this.StartGame.Name = "StartGame";
			this.StartGame.Size = new System.Drawing.Size(151, 38);
			this.StartGame.TabIndex = 1;
			this.StartGame.Text = "Start";
			this.StartGame.UseVisualStyleBackColor = false;
			this.StartGame.Visible = false;
			this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
			// 
			// LoginEmailLabel
			// 
			this.LoginEmailLabel.AutoSize = true;
			this.LoginEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.LoginEmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginEmailLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.LoginEmailLabel.Location = new System.Drawing.Point(333, 148);
			this.LoginEmailLabel.Name = "LoginEmailLabel";
			this.LoginEmailLabel.Size = new System.Drawing.Size(48, 21);
			this.LoginEmailLabel.TabIndex = 2;
			this.LoginEmailLabel.Text = "Email";
			this.LoginEmailLabel.Visible = false;
			// 
			// LoginEmail
			// 
			this.LoginEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.LoginEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.LoginEmail.Location = new System.Drawing.Point(387, 145);
			this.LoginEmail.Name = "LoginEmail";
			this.LoginEmail.Size = new System.Drawing.Size(230, 29);
			this.LoginEmail.TabIndex = 3;
			this.LoginEmail.Visible = false;
			// 
			// LoginPassword
			// 
			this.LoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.LoginPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.LoginPassword.Location = new System.Drawing.Point(387, 190);
			this.LoginPassword.Name = "LoginPassword";
			this.LoginPassword.Size = new System.Drawing.Size(230, 29);
			this.LoginPassword.TabIndex = 5;
			this.LoginPassword.Visible = false;
			// 
			// LoginPasswordLabel
			// 
			this.LoginPasswordLabel.AutoSize = true;
			this.LoginPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.LoginPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginPasswordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.LoginPasswordLabel.Location = new System.Drawing.Point(305, 193);
			this.LoginPasswordLabel.Name = "LoginPasswordLabel";
			this.LoginPasswordLabel.Size = new System.Drawing.Size(76, 21);
			this.LoginPasswordLabel.TabIndex = 4;
			this.LoginPasswordLabel.Text = "Password";
			this.LoginPasswordLabel.Visible = false;
			// 
			// TrayIcon
			// 
			this.TrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("TrayIcon.Icon")));
			this.TrayIcon.Text = "EmuTarkov Launcher";
			this.TrayIcon.Visible = true;
			this.TrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TrayIcon_MouseDoubleClick);
			// 
			// Background
			// 
			this.Background.BackgroundImage = global::Launcher.Properties.Resources.bg_1;
			this.Background.Image = global::Launcher.Properties.Resources.bg_alpha;
			this.Background.InitialImage = null;
			this.Background.Location = new System.Drawing.Point(0, 0);
			this.Background.Name = "Background";
			this.Background.Size = new System.Drawing.Size(728, 451);
			this.Background.TabIndex = 0;
			this.Background.TabStop = false;
			// 
			// RegisterEdition
			// 
			this.RegisterEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.RegisterEdition.DropDownHeight = 107;
			this.RegisterEdition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RegisterEdition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegisterEdition.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.RegisterEdition.FormattingEnabled = true;
			this.RegisterEdition.IntegralHeight = false;
			this.RegisterEdition.ItemHeight = 21;
			this.RegisterEdition.Location = new System.Drawing.Point(387, 227);
			this.RegisterEdition.Name = "RegisterEdition";
			this.RegisterEdition.Size = new System.Drawing.Size(230, 29);
			this.RegisterEdition.TabIndex = 6;
			this.RegisterEdition.Text = "No editions available";
			this.RegisterEdition.Visible = false;
			// 
			// RegisterEditionLabel
			// 
			this.RegisterEditionLabel.AutoSize = true;
			this.RegisterEditionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.RegisterEditionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegisterEditionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.RegisterEditionLabel.Location = new System.Drawing.Point(323, 231);
			this.RegisterEditionLabel.Name = "RegisterEditionLabel";
			this.RegisterEditionLabel.Size = new System.Drawing.Size(58, 21);
			this.RegisterEditionLabel.TabIndex = 7;
			this.RegisterEditionLabel.Text = "Edition";
			this.RegisterEditionLabel.Visible = false;
			// 
			// RegisterPassword
			// 
			this.RegisterPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.RegisterPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegisterPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.RegisterPassword.Location = new System.Drawing.Point(387, 182);
			this.RegisterPassword.Name = "RegisterPassword";
			this.RegisterPassword.Size = new System.Drawing.Size(230, 29);
			this.RegisterPassword.TabIndex = 11;
			this.RegisterPassword.Visible = false;
			// 
			// RegisterPasswordLabel
			// 
			this.RegisterPasswordLabel.AutoSize = true;
			this.RegisterPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.RegisterPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegisterPasswordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.RegisterPasswordLabel.Location = new System.Drawing.Point(305, 185);
			this.RegisterPasswordLabel.Name = "RegisterPasswordLabel";
			this.RegisterPasswordLabel.Size = new System.Drawing.Size(76, 21);
			this.RegisterPasswordLabel.TabIndex = 10;
			this.RegisterPasswordLabel.Text = "Password";
			this.RegisterPasswordLabel.Visible = false;
			// 
			// RegisterEmail
			// 
			this.RegisterEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.RegisterEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegisterEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.RegisterEmail.Location = new System.Drawing.Point(387, 137);
			this.RegisterEmail.Name = "RegisterEmail";
			this.RegisterEmail.Size = new System.Drawing.Size(230, 29);
			this.RegisterEmail.TabIndex = 9;
			this.RegisterEmail.Visible = false;
			// 
			// RegisterEmailLabel
			// 
			this.RegisterEmailLabel.AutoSize = true;
			this.RegisterEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.RegisterEmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegisterEmailLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.RegisterEmailLabel.Location = new System.Drawing.Point(333, 140);
			this.RegisterEmailLabel.Name = "RegisterEmailLabel";
			this.RegisterEmailLabel.Size = new System.Drawing.Size(48, 21);
			this.RegisterEmailLabel.TabIndex = 8;
			this.RegisterEmailLabel.Text = "Email";
			this.RegisterEmailLabel.Visible = false;
			// 
			// RegisterButton
			// 
			this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.RegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RegisterButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegisterButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.RegisterButton.Location = new System.Drawing.Point(405, 391);
			this.RegisterButton.Name = "RegisterButton";
			this.RegisterButton.Size = new System.Drawing.Size(151, 38);
			this.RegisterButton.TabIndex = 12;
			this.RegisterButton.Text = "Register";
			this.RegisterButton.UseVisualStyleBackColor = false;
			this.RegisterButton.Visible = false;
			this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
			// 
			// LoginButton
			// 
			this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.LoginButton.Location = new System.Drawing.Point(405, 391);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(151, 38);
			this.LoginButton.TabIndex = 13;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = false;
			this.LoginButton.Visible = false;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// RegisterInsteadButton
			// 
			this.RegisterInsteadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.RegisterInsteadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RegisterInsteadButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RegisterInsteadButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.RegisterInsteadButton.Location = new System.Drawing.Point(387, 233);
			this.RegisterInsteadButton.Name = "RegisterInsteadButton";
			this.RegisterInsteadButton.Size = new System.Drawing.Size(101, 23);
			this.RegisterInsteadButton.TabIndex = 14;
			this.RegisterInsteadButton.Text = "Register";
			this.RegisterInsteadButton.UseVisualStyleBackColor = false;
			this.RegisterInsteadButton.Visible = false;
			this.RegisterInsteadButton.Click += new System.EventHandler(this.RegisterInsteadButton_Click);
			// 
			// LoginInsteadButton
			// 
			this.LoginInsteadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.LoginInsteadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginInsteadButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginInsteadButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.LoginInsteadButton.Location = new System.Drawing.Point(387, 271);
			this.LoginInsteadButton.Name = "LoginInsteadButton";
			this.LoginInsteadButton.Size = new System.Drawing.Size(101, 23);
			this.LoginInsteadButton.TabIndex = 15;
			this.LoginInsteadButton.Text = "Login";
			this.LoginInsteadButton.UseVisualStyleBackColor = false;
			this.LoginInsteadButton.Visible = false;
			this.LoginInsteadButton.Click += new System.EventHandler(this.LoginInsteadButton_Click);
			// 
			// ConnectButton
			// 
			this.ConnectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ConnectButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ConnectButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ConnectButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ConnectButton.Location = new System.Drawing.Point(405, 391);
			this.ConnectButton.Name = "ConnectButton";
			this.ConnectButton.Size = new System.Drawing.Size(151, 38);
			this.ConnectButton.TabIndex = 16;
			this.ConnectButton.Text = "Connect";
			this.ConnectButton.UseVisualStyleBackColor = false;
			this.ConnectButton.Visible = false;
			this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
			// 
			// LogoutButton
			// 
			this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogoutButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.LogoutButton.Location = new System.Drawing.Point(591, 344);
			this.LogoutButton.Name = "LogoutButton";
			this.LogoutButton.Size = new System.Drawing.Size(110, 23);
			this.LogoutButton.TabIndex = 20;
			this.LogoutButton.Text = "Logout";
			this.LogoutButton.UseVisualStyleBackColor = false;
			this.LogoutButton.Visible = false;
			this.LogoutButton.Click += new System.EventHandler(this.BackToLoginButton_Click);
			// 
			// BackToProfileView
			// 
			this.BackToProfileView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.BackToProfileView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BackToProfileView.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackToProfileView.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.BackToProfileView.Location = new System.Drawing.Point(387, 225);
			this.BackToProfileView.Name = "BackToProfileView";
			this.BackToProfileView.Size = new System.Drawing.Size(101, 23);
			this.BackToProfileView.TabIndex = 21;
			this.BackToProfileView.Text = "Back";
			this.BackToProfileView.UseVisualStyleBackColor = false;
			this.BackToProfileView.Visible = false;
			this.BackToProfileView.Click += new System.EventHandler(this.BackToProfileView_Click);
			// 
			// RefreshServerListButton
			// 
			this.RefreshServerListButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.RefreshServerListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RefreshServerListButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RefreshServerListButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.RefreshServerListButton.Location = new System.Drawing.Point(516, 225);
			this.RefreshServerListButton.Name = "RefreshServerListButton";
			this.RefreshServerListButton.Size = new System.Drawing.Size(101, 23);
			this.RefreshServerListButton.TabIndex = 23;
			this.RefreshServerListButton.Text = "Refresh";
			this.RefreshServerListButton.UseVisualStyleBackColor = false;
			this.RefreshServerListButton.Visible = false;
			this.RefreshServerListButton.Click += new System.EventHandler(this.RefreshServerListButton_Click);
			// 
			// ServerLabel
			// 
			this.ServerLabel.AutoSize = true;
			this.ServerLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ServerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ServerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ServerLabel.Location = new System.Drawing.Point(326, 185);
			this.ServerLabel.Name = "ServerLabel";
			this.ServerLabel.Size = new System.Drawing.Size(55, 21);
			this.ServerLabel.TabIndex = 18;
			this.ServerLabel.Text = "Server";
			this.ServerLabel.Visible = false;
			// 
			// ServerList
			// 
			this.ServerList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ServerList.DropDownHeight = 107;
			this.ServerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ServerList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ServerList.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ServerList.FormattingEnabled = true;
			this.ServerList.IntegralHeight = false;
			this.ServerList.ItemHeight = 21;
			this.ServerList.Location = new System.Drawing.Point(387, 182);
			this.ServerList.Name = "ServerList";
			this.ServerList.Size = new System.Drawing.Size(230, 29);
			this.ServerList.TabIndex = 17;
			this.ServerList.Text = "No servers available";
			this.ServerList.Visible = false;
			// 
			// AddServerInsteadButton
			// 
			this.AddServerInsteadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.AddServerInsteadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddServerInsteadButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddServerInsteadButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.AddServerInsteadButton.Location = new System.Drawing.Point(387, 225);
			this.AddServerInsteadButton.Name = "AddServerInsteadButton";
			this.AddServerInsteadButton.Size = new System.Drawing.Size(101, 23);
			this.AddServerInsteadButton.TabIndex = 22;
			this.AddServerInsteadButton.Text = "Add server";
			this.AddServerInsteadButton.UseVisualStyleBackColor = false;
			this.AddServerInsteadButton.Visible = false;
			this.AddServerInsteadButton.Click += new System.EventHandler(this.AddServerInsteadButton_Click);
			// 
			// ViewServersInsteadButton
			// 
			this.ViewServersInsteadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ViewServersInsteadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ViewServersInsteadButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ViewServersInsteadButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ViewServersInsteadButton.Location = new System.Drawing.Point(387, 225);
			this.ViewServersInsteadButton.Name = "ViewServersInsteadButton";
			this.ViewServersInsteadButton.Size = new System.Drawing.Size(101, 23);
			this.ViewServersInsteadButton.TabIndex = 26;
			this.ViewServersInsteadButton.Text = "View servers";
			this.ViewServersInsteadButton.UseVisualStyleBackColor = false;
			this.ViewServersInsteadButton.Visible = false;
			this.ViewServersInsteadButton.Click += new System.EventHandler(this.ViewServersInsteadButton_Click);
			// 
			// UrlLabel
			// 
			this.UrlLabel.AutoSize = true;
			this.UrlLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.UrlLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UrlLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.UrlLabel.Location = new System.Drawing.Point(350, 185);
			this.UrlLabel.Name = "UrlLabel";
			this.UrlLabel.Size = new System.Drawing.Size(31, 21);
			this.UrlLabel.TabIndex = 25;
			this.UrlLabel.Text = "Url";
			this.UrlLabel.Visible = false;
			// 
			// AddServer
			// 
			this.AddServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.AddServer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddServer.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.AddServer.Location = new System.Drawing.Point(387, 182);
			this.AddServer.Name = "AddServer";
			this.AddServer.Size = new System.Drawing.Size(230, 29);
			this.AddServer.TabIndex = 27;
			this.AddServer.Text = "https://127.0.0.1";
			this.AddServer.Visible = false;
			// 
			// AddServerButton
			// 
			this.AddServerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.AddServerButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.AddServerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddServerButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddServerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.AddServerButton.Location = new System.Drawing.Point(405, 391);
			this.AddServerButton.Name = "AddServerButton";
			this.AddServerButton.Size = new System.Drawing.Size(151, 38);
			this.AddServerButton.TabIndex = 28;
			this.AddServerButton.Text = "Add";
			this.AddServerButton.UseVisualStyleBackColor = false;
			this.AddServerButton.Visible = false;
			this.AddServerButton.Click += new System.EventHandler(this.AddServerButton_Click);
			// 
			// ChangeEmailButton
			// 
			this.ChangeEmailButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ChangeEmailButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.ChangeEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangeEmailButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangeEmailButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ChangeEmailButton.Location = new System.Drawing.Point(405, 391);
			this.ChangeEmailButton.Name = "ChangeEmailButton";
			this.ChangeEmailButton.Size = new System.Drawing.Size(151, 38);
			this.ChangeEmailButton.TabIndex = 29;
			this.ChangeEmailButton.Text = "Change";
			this.ChangeEmailButton.UseVisualStyleBackColor = false;
			this.ChangeEmailButton.Visible = false;
			this.ChangeEmailButton.Click += new System.EventHandler(this.ChangeEmailButton_Click);
			// 
			// ChangePasswordButton
			// 
			this.ChangePasswordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ChangePasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.ChangePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangePasswordButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangePasswordButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ChangePasswordButton.Location = new System.Drawing.Point(405, 391);
			this.ChangePasswordButton.Name = "ChangePasswordButton";
			this.ChangePasswordButton.Size = new System.Drawing.Size(151, 38);
			this.ChangePasswordButton.TabIndex = 30;
			this.ChangePasswordButton.Text = "Change";
			this.ChangePasswordButton.UseVisualStyleBackColor = false;
			this.ChangePasswordButton.Visible = false;
			this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
			// 
			// ChangeEmail
			// 
			this.ChangeEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ChangeEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangeEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ChangeEmail.Location = new System.Drawing.Point(387, 182);
			this.ChangeEmail.Name = "ChangeEmail";
			this.ChangeEmail.Size = new System.Drawing.Size(230, 29);
			this.ChangeEmail.TabIndex = 34;
			this.ChangeEmail.Visible = false;
			// 
			// ChangeEmailLabel
			// 
			this.ChangeEmailLabel.AutoSize = true;
			this.ChangeEmailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ChangeEmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangeEmailLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ChangeEmailLabel.Location = new System.Drawing.Point(333, 185);
			this.ChangeEmailLabel.Name = "ChangeEmailLabel";
			this.ChangeEmailLabel.Size = new System.Drawing.Size(48, 21);
			this.ChangeEmailLabel.TabIndex = 32;
			this.ChangeEmailLabel.Text = "Email";
			this.ChangeEmailLabel.Visible = false;
			// 
			// ChangePassword
			// 
			this.ChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ChangePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ChangePassword.Location = new System.Drawing.Point(387, 182);
			this.ChangePassword.Name = "ChangePassword";
			this.ChangePassword.Size = new System.Drawing.Size(230, 29);
			this.ChangePassword.TabIndex = 36;
			this.ChangePassword.Visible = false;
			// 
			// ChangePasswordLabel
			// 
			this.ChangePasswordLabel.AutoSize = true;
			this.ChangePasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ChangePasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangePasswordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ChangePasswordLabel.Location = new System.Drawing.Point(305, 185);
			this.ChangePasswordLabel.Name = "ChangePasswordLabel";
			this.ChangePasswordLabel.Size = new System.Drawing.Size(76, 21);
			this.ChangePasswordLabel.TabIndex = 35;
			this.ChangePasswordLabel.Text = "Password";
			this.ChangePasswordLabel.Visible = false;
			// 
			// ChangePasswordViewButton
			// 
			this.ChangePasswordViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ChangePasswordViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangePasswordViewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangePasswordViewButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ChangePasswordViewButton.Location = new System.Drawing.Point(475, 344);
			this.ChangePasswordViewButton.Name = "ChangePasswordViewButton";
			this.ChangePasswordViewButton.Size = new System.Drawing.Size(110, 23);
			this.ChangePasswordViewButton.TabIndex = 37;
			this.ChangePasswordViewButton.Text = "Change password";
			this.ChangePasswordViewButton.UseVisualStyleBackColor = false;
			this.ChangePasswordViewButton.Visible = false;
			this.ChangePasswordViewButton.Click += new System.EventHandler(this.ChangePasswordViewButton_Click);
			// 
			// ChangeEmailViewButton
			// 
			this.ChangeEmailViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.ChangeEmailViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ChangeEmailViewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChangeEmailViewButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.ChangeEmailViewButton.Location = new System.Drawing.Point(359, 344);
			this.ChangeEmailViewButton.Name = "ChangeEmailViewButton";
			this.ChangeEmailViewButton.Size = new System.Drawing.Size(110, 23);
			this.ChangeEmailViewButton.TabIndex = 38;
			this.ChangeEmailViewButton.Text = "Change email";
			this.ChangeEmailViewButton.UseVisualStyleBackColor = false;
			this.ChangeEmailViewButton.Visible = false;
			this.ChangeEmailViewButton.Click += new System.EventHandler(this.ChangeEmailView_Click);
			// 
			// WipeViewButton
			// 
			this.WipeViewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.WipeViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WipeViewButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WipeViewButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.WipeViewButton.Location = new System.Drawing.Point(243, 344);
			this.WipeViewButton.Name = "WipeViewButton";
			this.WipeViewButton.Size = new System.Drawing.Size(110, 23);
			this.WipeViewButton.TabIndex = 39;
			this.WipeViewButton.Text = "Wipe profile";
			this.WipeViewButton.UseVisualStyleBackColor = false;
			this.WipeViewButton.Visible = false;
			this.WipeViewButton.Click += new System.EventHandler(this.WipeViewButton_Click);
			// 
			// WipeButton
			// 
			this.WipeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.WipeButton.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
			this.WipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WipeButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WipeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.WipeButton.Location = new System.Drawing.Point(405, 391);
			this.WipeButton.Name = "WipeButton";
			this.WipeButton.Size = new System.Drawing.Size(151, 38);
			this.WipeButton.TabIndex = 40;
			this.WipeButton.Text = "Wipe";
			this.WipeButton.UseVisualStyleBackColor = false;
			this.WipeButton.Visible = false;
			this.WipeButton.Click += new System.EventHandler(this.WipeButton_Click);
			// 
			// WipeLabel
			// 
			this.WipeLabel.AutoSize = true;
			this.WipeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.WipeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WipeLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.WipeLabel.Location = new System.Drawing.Point(323, 185);
			this.WipeLabel.Name = "WipeLabel";
			this.WipeLabel.Size = new System.Drawing.Size(58, 21);
			this.WipeLabel.TabIndex = 42;
			this.WipeLabel.Text = "Edition";
			this.WipeLabel.Visible = false;
			// 
			// WipeEdition
			// 
			this.WipeEdition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.WipeEdition.DropDownHeight = 107;
			this.WipeEdition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.WipeEdition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.WipeEdition.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.WipeEdition.FormattingEnabled = true;
			this.WipeEdition.IntegralHeight = false;
			this.WipeEdition.ItemHeight = 21;
			this.WipeEdition.Location = new System.Drawing.Point(387, 182);
			this.WipeEdition.Name = "WipeEdition";
			this.WipeEdition.Size = new System.Drawing.Size(230, 29);
			this.WipeEdition.TabIndex = 41;
			this.WipeEdition.Text = "No edition available";
			this.WipeEdition.Visible = false;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 441);
			this.Controls.Add(this.WipeLabel);
			this.Controls.Add(this.WipeEdition);
			this.Controls.Add(this.ServerLabel);
			this.Controls.Add(this.ServerList);
			this.Controls.Add(this.WipeButton);
			this.Controls.Add(this.StartGame);
			this.Controls.Add(this.WipeViewButton);
			this.Controls.Add(this.ChangeEmailViewButton);
			this.Controls.Add(this.ChangePasswordViewButton);
			this.Controls.Add(this.ChangePassword);
			this.Controls.Add(this.ChangePasswordLabel);
			this.Controls.Add(this.ChangeEmail);
			this.Controls.Add(this.ChangeEmailLabel);
			this.Controls.Add(this.ChangePasswordButton);
			this.Controls.Add(this.ChangeEmailButton);
			this.Controls.Add(this.AddServerButton);
			this.Controls.Add(this.AddServer);
			this.Controls.Add(this.ViewServersInsteadButton);
			this.Controls.Add(this.UrlLabel);
			this.Controls.Add(this.RefreshServerListButton);
			this.Controls.Add(this.AddServerInsteadButton);
			this.Controls.Add(this.ConnectButton);
			this.Controls.Add(this.BackToProfileView);
			this.Controls.Add(this.LogoutButton);
			this.Controls.Add(this.LoginPassword);
			this.Controls.Add(this.RegisterInsteadButton);
			this.Controls.Add(this.RegisterEdition);
			this.Controls.Add(this.RegisterEditionLabel);
			this.Controls.Add(this.RegisterEmailLabel);
			this.Controls.Add(this.RegisterEmail);
			this.Controls.Add(this.RegisterPasswordLabel);
			this.Controls.Add(this.RegisterPassword);
			this.Controls.Add(this.RegisterButton);
			this.Controls.Add(this.LoginInsteadButton);
			this.Controls.Add(this.LoginEmailLabel);
			this.Controls.Add(this.LoginPasswordLabel);
			this.Controls.Add(this.LoginEmail);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.Background);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(736, 480);
			this.MinimumSize = new System.Drawing.Size(736, 480);
			this.Name = "Main";
			this.Text = "EmuTarkov Launcher";
			this.Resize += new System.EventHandler(this.Main_Resize);
			((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label LoginEmailLabel;
        private System.Windows.Forms.TextBox LoginEmail;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.Label LoginPasswordLabel;
        private System.Windows.Forms.NotifyIcon TrayIcon;
		private System.Windows.Forms.PictureBox Background;
		private System.Windows.Forms.ComboBox RegisterEdition;
		private System.Windows.Forms.Label RegisterEditionLabel;
		private System.Windows.Forms.TextBox RegisterPassword;
		private System.Windows.Forms.Label RegisterPasswordLabel;
		private System.Windows.Forms.TextBox RegisterEmail;
		private System.Windows.Forms.Label RegisterEmailLabel;
		private System.Windows.Forms.Button RegisterButton;
		private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.Button RegisterInsteadButton;
		private System.Windows.Forms.Button LoginInsteadButton;
		private System.Windows.Forms.Button ConnectButton;
		private System.Windows.Forms.Button LogoutButton;
		private System.Windows.Forms.Button BackToProfileView;
		private System.Windows.Forms.Button RefreshServerListButton;
		private System.Windows.Forms.Label ServerLabel;
		private System.Windows.Forms.ComboBox ServerList;
		private System.Windows.Forms.Button AddServerInsteadButton;
		private System.Windows.Forms.Button ViewServersInsteadButton;
		private System.Windows.Forms.Label UrlLabel;
		private System.Windows.Forms.TextBox AddServer;
		private System.Windows.Forms.Button AddServerButton;
		private System.Windows.Forms.Button ChangeEmailButton;
		private System.Windows.Forms.Button ChangePasswordButton;
		private System.Windows.Forms.TextBox ChangeEmail;
		private System.Windows.Forms.Label ChangeEmailLabel;
		private System.Windows.Forms.TextBox ChangePassword;
		private System.Windows.Forms.Label ChangePasswordLabel;
		private System.Windows.Forms.Button ChangePasswordViewButton;
		private System.Windows.Forms.Button ChangeEmailViewButton;
		private System.Windows.Forms.Button WipeViewButton;
		private System.Windows.Forms.Button WipeButton;
		private System.Windows.Forms.Label WipeLabel;
		private System.Windows.Forms.ComboBox WipeEdition;
	}
}

