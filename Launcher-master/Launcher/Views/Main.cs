using System;
using System.Windows.Forms;

namespace Launcher
{
	public partial class Main : Form
	{
		private LauncherConfig launcherConfig;
		private ProcessMonitor monitor;
		private ServerManager serverManager;
		private Account accountManager;
		private GameStarter gameStarter;

		public Main()
		{
			InitializeComponent();
			InitializeLauncher();
		}

		private void InitializeLauncher()
		{
			launcherConfig = JsonHandler.LoadLauncherConfig();
			monitor = new ProcessMonitor("EscapeFromTarkov", 1000, aliveCallback: null, exitCallback: GameExitCallback);
			serverManager = new ServerManager();
			accountManager = new Account(launcherConfig);
			gameStarter = new GameStarter();

			if (launcherConfig.Servers.Count == 0)
			{
				launcherConfig.Servers.Add("https://127.0.0.1");
				JsonHandler.SaveLauncherConfig(launcherConfig);
			}

			ShowServerSelectView();
		}

		private void ShowServerSelectView()
		{
			ServerLabel.Visible = true;
			ServerList.Visible = true;
			ConnectButton.Visible = true;
			AddServerInsteadButton.Visible = true;
			RefreshServerListButton.Visible = true;

			RefreshServerList();
		}

		private void HideServerSelectView()
		{
			ServerLabel.Visible = false;
			ServerList.Visible = false;
			ConnectButton.Visible = false;
			AddServerInsteadButton.Visible = false;
			RefreshServerListButton.Visible = false;
		}

		private void ShowServerAddView()
		{
			UrlLabel.Visible = true;
			AddServer.Visible = true;
			AddServerButton.Visible = true;
			ViewServersInsteadButton.Visible = true;
		}

		private void HideServerAddView()
		{
			UrlLabel.Visible = false;
			AddServer.Visible = false;
			AddServerButton.Visible = false;
			ViewServersInsteadButton.Visible = false;
		}

		private void ShowLoginView()
		{
			LoginEmailLabel.Visible = true;
			LoginPasswordLabel.Visible = true;
			LoginEmail.Visible = true;
			LoginPassword.Visible = true;
			LoginButton.Visible = true;
			RegisterInsteadButton.Visible = true;

			LoginEmail.Text = launcherConfig.Email;
			LoginPassword.Text = launcherConfig.Password;
		}

		private void HideLoginView()
		{
			LoginEmailLabel.Visible = false;
			LoginPasswordLabel.Visible = false;
			LoginButton.Visible = false;
			RegisterInsteadButton.Visible = false;
			LoginEmail.Visible = false;
			LoginPassword.Visible = false;
		}

		private void ShowRegisterView()
		{
			RegisterEmailLabel.Visible = true;
			RegisterPasswordLabel.Visible = true;
			RegisterEditionLabel.Visible = true;
			RegisterEmail.Visible = true;
			RegisterPassword.Visible = true;
			RegisterEdition.Visible = true;
			RegisterButton.Visible = true;
			LoginInsteadButton.Visible = true;

			RegisterEdition.Items.Clear();

			foreach (string edition in serverManager.SelectedServer.editions)
			{
				RegisterEdition.Items.Add(edition);
			}

			RegisterEdition.SelectedIndex = 0;
		}

		private void HideRegisterView()
		{
			RegisterEmailLabel.Visible = false;
			RegisterPasswordLabel.Visible = false;
			RegisterEditionLabel.Visible = false;
			RegisterEmail.Visible = false;
			RegisterPassword.Visible = false;
			RegisterEdition.Visible = false;
			RegisterButton.Visible = false;
			LoginInsteadButton.Visible = false;
		}

		private void ShowProfileView()
		{
			StartGame.Visible = true;
			WipeViewButton.Visible = true;
			ChangeEmailViewButton.Visible = true;
			ChangePasswordViewButton.Visible = true;
			LogoutButton.Visible = true;
		}

		private void HideProfileView()
		{
			StartGame.Visible = false;
			WipeViewButton.Visible = false;
			ChangeEmailViewButton.Visible = false;
			ChangePasswordViewButton.Visible = false;
			LogoutButton.Visible = false;
		}

		private void ShowChangeEmailView()
		{
			ChangeEmailLabel.Visible = true;
			ChangeEmail.Visible = true;
			ChangeEmailButton.Visible = true;
			BackToProfileView.Visible = true;
		}

		private void HideChangeEmailView()
		{
			ChangeEmailLabel.Visible = false;
			ChangeEmail.Visible = false;
			ChangeEmailButton.Visible = false;
			BackToProfileView.Visible = false;
		}

		private void ShowChangePasswordView()
		{
			ChangePasswordLabel.Visible = true;
			ChangePassword.Visible = true;
			ChangePasswordButton.Visible = true;
			BackToProfileView.Visible = true;
		}

		private void HideChangePasswordView()
		{
			ChangePasswordLabel.Visible = false;
			ChangePassword.Visible = false;
			ChangePasswordButton.Visible = false;
			BackToProfileView.Visible = false;
		}

		private void ShowWipeView()
		{
			WipeLabel.Visible = true;
			WipeEdition.Visible = true;
			WipeButton.Visible = true;
			BackToProfileView.Visible = true;

			WipeEdition.Items.Clear();

			foreach (string edition in serverManager.SelectedServer.editions)
			{
				WipeEdition.Items.Add(edition);
			}

			WipeEdition.SelectedIndex = 0;
		}

		private void HideWipeView()
		{
			WipeLabel.Visible = false;
			WipeEdition.Visible = false;
			WipeButton.Visible = false;
			BackToProfileView.Visible = false;
		}

		private void ConnectButton_Click(object sender, EventArgs e)
		{
			serverManager.SelectServer(ServerList.SelectedIndex);
			RequestHandler.ChangeBackendUrl(serverManager.SelectedServer.backendUrl);
			HideServerSelectView();

			if (launcherConfig.Email == "" || launcherConfig.Password == "")
			{
				ShowRegisterView();
				return;
			}

			ShowLoginView();
		}

		private void AddServerInsteadButton_Click(object sender, EventArgs e)
		{
			HideServerSelectView();
			ShowServerAddView();
		}

		private void RefreshServerListButton_Click(object sender, EventArgs e)
		{
			RefreshServerList();
		}

		private void AddServerButton_Click(object sender, EventArgs e)
		{
			if (launcherConfig.Servers.Contains(AddServer.Text))
			{
				MessageBox.Show("Server already exists");
				return;
			}

			launcherConfig.Servers.Add(AddServer.Text);
			HideServerAddView();
			ShowServerSelectView();
		}

		private void ViewServersInsteadButton_Click(object sender, EventArgs e)
		{
			HideServerAddView();
			ShowServerSelectView();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			int status = accountManager.Login(LoginEmail.Text, LoginPassword.Text);

			switch (status)
			{
				case 1:
					HideLoginView();
					ShowProfileView();
					break;

				case -1:
					MessageBox.Show("Wrong email and/or password");
					return;

				case -2:
					MessageBox.Show("Cannot establish a connection to the server");
					return;
			}
		}

		private void RegisterButton_Click(object sender, EventArgs e)
		{
			int status = accountManager.Register(RegisterEmail.Text, RegisterPassword.Text, (string)RegisterEdition.SelectedItem);

			switch (status)
			{
				case 1:
					HideRegisterView();
					ShowProfileView();
					break;

				case -1:
					MessageBox.Show("Account already exists");
					return;

				case -2:
					MessageBox.Show("Cannot establish a connection to the server");
					return;

				case -3:
					MessageBox.Show("Wrong email and/or password");
					return;
			}
		}

		private void RegisterInsteadButton_Click(object sender, EventArgs e)
		{
			HideLoginView();
			ShowRegisterView();
		}

		private void LoginInsteadButton_Click(object sender, EventArgs e)
		{
			HideRegisterView();
			ShowLoginView();
		}

		private void StartGame_Click(object sender, EventArgs e)
		{
			int status = gameStarter.LaunchGame(serverManager.SelectedServer, accountManager.SelectedAccount);

			switch (status)
			{
				case 1:
					monitor.Start();

					if (launcherConfig.MinimizeToTray)
					{
						TrayIcon.Visible = true;
						Hide();
					}
					break;

				case -1:
					MessageBox.Show("The launcher is not running from the game directory");
					return;
			}
		}

		private void BackToLoginButton_Click(object sender, EventArgs e)
		{
			HideProfileView();
			ShowLoginView();
		}

		private void ChangeEmailView_Click(object sender, EventArgs e)
		{
			HideProfileView();
			ShowChangeEmailView();
		}

		private void ChangePasswordViewButton_Click(object sender, EventArgs e)
		{
			HideProfileView();
			ShowChangePasswordView();
		}

		private void WipeViewButton_Click(object sender, EventArgs e)
		{
			HideProfileView();
			ShowWipeView();
		}

		private void BackToProfileView_Click(object sender, EventArgs e)
		{
			HideChangeEmailView();
			HideChangePasswordView();
			HideWipeView();
			ShowProfileView();
		}

		private void ChangeEmailButton_Click(object sender, EventArgs e)
		{
			int status = accountManager.ChangeEmail(ChangeEmail.Text);

			switch (status)
			{
				case 1:
					HideChangeEmailView();
					ShowProfileView();
					break;

				case -1:
					MessageBox.Show("Login failed");
					return;

				case -2:
					MessageBox.Show("Cannot establish a connection to the server");
					return;
			}
		}

		private void ChangePasswordButton_Click(object sender, EventArgs e)
		{
			int status = accountManager.ChangePassword(ChangePassword.Text);

			switch (status)
			{
				case 1:
					HideChangePasswordView();
					ShowProfileView();
					break;

				case -1:
					MessageBox.Show("Login failed");
					return;

				case -2:
					MessageBox.Show("Cannot establish a connection to the server");
					return;
			}
		}

		private void WipeButton_Click(object sender, EventArgs e)
		{
			int status = accountManager.Wipe((string)WipeEdition.SelectedItem);

			switch (status)
			{
				case 1:
					HideWipeView();
					ShowProfileView();
					break;

				case -1:
					MessageBox.Show("Login failed");
					return;

				case -2:
					MessageBox.Show("Cannot establish a connection to the server");
					return;
			}
		}

		private void RefreshServerList()
		{
			serverManager.LoadServers(launcherConfig.Servers.ToArray());

			ConnectButton.Enabled = true;
			ServerList.Enabled = true;
			ServerList.Items.Clear();

			foreach (ServerInfo server in serverManager.AvailableServers)
			{
				ServerList.Items.Add(server.name);
			}

			if (ServerList.Items.Count > 0)
			{
				ServerList.SelectedIndex = 0;
				return;
			}

			ConnectButton.Enabled = false;
			ServerList.Enabled = false;
			ServerList.Text = "No servers available";
		}

		private void GameExitCallback(ProcessMonitor monitor)
		{
			monitor.Stop();
			Show();
		}

		private void TrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Show();
			WindowState = FormWindowState.Normal;
		}

		private void Main_Resize(object sender, EventArgs e)
		{
			if (WindowState == FormWindowState.Normal)
			{
				TrayIcon.Visible = false;
			}
		}
	}
}
