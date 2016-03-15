namespace TALS.TestingFramework.Core.Pages.LoginPanelPage
{
    using TALS.TestingFramework.Core.Base;

    public partial class LoginPanelPage : BasePage
    {
        private const string Url = @"http://stage.telerikacademy.com/";

        public override void Navigate()
        {
            ActiveBrowser.NavigateTo(Url);

            if (this.LogOutButton != null)
            {
                this.LogOutButton.Click();
            }

            //this.LogInButton.Click();
        }
    }
}