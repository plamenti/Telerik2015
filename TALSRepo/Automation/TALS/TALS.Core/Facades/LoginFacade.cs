namespace TALS.TestingFramework.Core.Facades
{
    using TALS.TestingFramework.Core.Pages.Login;
    using TALS.TestingFramework.Core.Pages.LoginPanelPage;

    public class LoginFacade
    {
        private LoginPanelPage loginPanelPage;
        private LoginPage loginPage;

        public LoginFacade(string username, string password)
        {
            this.loginPanelPage = new LoginPanelPage();
            this.loginPage = new LoginPage();
            this.Username = username;
            this.Password = password;
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public void LogIn()
        {
            this.loginPanelPage.Navigate();

            this.loginPage.Login(Username, Password);
        }
    }
}