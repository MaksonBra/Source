using System;
using System.Windows.Forms;

namespace CourtDecisionsDictionary.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            UsersPanels(ShowAuthPanel: true);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text.Trim();
            string password = txtPassword.Text;

            txtLogin.Text = txtPassword.Text = "";

            switch (Controller.DB.AccessDB.Login(login, password))
            {
                case Controller.DB.UserRrole.Client:

                    // Iimpossible
                    break;


                case Controller.DB.UserRrole.Admin:

                    RunDesktop(Controller.DB.UserRrole.Admin);
                    break;


                case Controller.DB.UserRrole.ContentManager:

                    RunDesktop(Controller.DB.UserRrole.ContentManager);
                    break;


                case Controller.DB.UserRrole.NotAuthorized:

                    MessageBox.Show("Пользователя с таким логином и паролем не найдено!",
                        Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    break;


                case Controller.DB.UserRrole.Failed:

                    MessageBox.Show("Ошибка обращения к БД при попытке авторизации:\n\n" +
                        Controller.DB.AccessDB.LastErrorText,
                        Application.ProductName, MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;


                default:
                    break;
            }
        }
        private void btnLoginAsClient_Click(object sender, EventArgs e)
        {
            RunDesktop(Controller.DB.UserRrole.Client);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            pnlUsersDesktopContainer.Controls.Clear();
            UsersPanels(ShowAuthPanel: true);
        }


        private void RunDesktop(Controller.DB.UserRrole UserRole)
        {
            txtLogin.Text = txtPassword.Text = "";
            pnlUsersDesktopContainer.Controls.Clear();

            UsersPanels(ShowLogoutPanel: true);

            UserControl Desktop = null;

            switch (UserRole)
            {
                case Controller.DB.UserRrole.Client:
                    lblCurrentUser.Text = $"Вы вошли как: клиент";
                    Desktop = new ClientForm();
                    break;

                case Controller.DB.UserRrole.Admin:
                    Desktop = new AdministratorForm();
                    lblCurrentUser.Text = $"Вы вошли как: администратор";
                    break;

                case Controller.DB.UserRrole.ContentManager:
                    Desktop = new ContentManagerForm();
                    lblCurrentUser.Text = $"Вы вошли как: контент-менеджер";
                    break;

                case Controller.DB.UserRrole.NotAuthorized: return;
                case Controller.DB.UserRrole.Failed: return;
                default: return;
            }

            pnlUsersDesktopContainer.Controls.Add(Desktop);
            Desktop.Dock = DockStyle.Fill;
        }

        private void UsersPanels(bool ShowAuthPanel = false, bool ShowLogoutPanel = false)
        {
            pnlAuth.Visible = ShowAuthPanel;
            pnlCurrentUserInfo.Visible = ShowLogoutPanel;
        }
    }
}