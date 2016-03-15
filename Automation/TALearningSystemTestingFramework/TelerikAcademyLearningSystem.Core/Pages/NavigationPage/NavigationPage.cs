namespace TelerikAcademyLearningSystem.Core.Pages.NavigationPage
{
    using Base;

    public partial class NavigationPage : BasePage<NavigationPage>
    {
        public void GoToAdminPage()
        {
            var nav = new NavigationPage();
            nav.AdminButton.Click(false);
            nav.Browser.WaitForUrl("http://stage.telerikacademy.com/Administration/Navigation", false, 10000);
        }
    }
}
