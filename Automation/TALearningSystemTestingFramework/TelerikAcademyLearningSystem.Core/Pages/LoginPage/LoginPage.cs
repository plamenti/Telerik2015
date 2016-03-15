namespace TelerikAcademyLearningSystem.Core.Pages.LoginPage
{
    using Base;
    using Constants;
    using Model;

    public partial class LoginPage : BasePage<LoginPage>
    {
        //// private const string Url = @"http://stage.telerikacademy.com/";

        ////private const string UrlLogin = @"http://stage.telerikacademy.com/Users/Auth/Login";
        ////private readonly AdminUser adminUser;
        ////public LoginPage(AdminUser adminUser)
        ////{
        ////    this.adminUser = adminUser;
        ////}

        public override void Navigate()
        {
            this.Browser.NavigateTo("http://stage.telerikacademy.com");
            this.EntranceButton.Click();
        }

        public void Login(AdminUser adminUser)
        {
            this.Navigate();
            this.UsernameOrEmail.Text = adminUser.Username;
            this.Password.Text = adminUser.Password;
            this.EntryButton.Click();
        }

        //// Added nwe method if wold dont work without constructor
        ////public void Login(AdminUser adminUser)
        ////{
        ////    LoginPage.Instance.Navigate();
        ////    LoginPage.Instance.UsernameOrEmail.Text = adminUser.Username;
        ////    LoginPage.Instance.Password.Text = adminUser.Password;
        ////    LoginPage.Instance.EntryButton.Click();
        ////}
    }
}