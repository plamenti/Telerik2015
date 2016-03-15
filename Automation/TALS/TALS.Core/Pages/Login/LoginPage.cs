namespace TALS.TestingFramework.Core.Pages.Login
{
    using TALS.TestingFramework.Core.Base;

    public partial class LoginPage : BasePage
    {
        private const string Url = @"http://stage.telerikacademy.com/Users/Auth/Login";

        public override void Navigate()
        {
            ActiveBrowser.NavigateTo(Url);
        }

        public void Login(string username, string password)
        {
            this.Navigate();
            this.UsernameOrEmail.Text = username;
            this.Password.Text = password;
            this.EntryButton.Click();
        }
    }
}