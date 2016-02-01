namespace TelerikAcademyLearningSystem.Core.Pages.LoginPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Constants;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class LoginPageAsserter
    {
        public static void AssertTitle(this LoginPage page)
        {
            Assert.AreEqual(PageTitle.Login, page.Title, string.Format("Page title should be: {0}", PageTitle.Login));
        }

        public static void AssertLoginIsSuccseful(this LoginPage page)
        {
            Assert.IsTrue(page.LogOutButton.IsVisible());
        }
    }
}