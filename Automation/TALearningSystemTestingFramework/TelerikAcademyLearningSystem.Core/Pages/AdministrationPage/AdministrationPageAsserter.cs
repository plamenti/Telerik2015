namespace TelerikAcademyLearningSystem.Core.Pages.AdministrationPage
{
    using Constants;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class AdministrationPageAsserter
    {
        private const string Header = "Администрация";

        public static void AssertPageTitle(this AdministrationPage page)
        {
            var expected = PageTitle.Administration;
            var actual = page.Title;
            var message = string.Format("Page title should be: {0}", expected);

            Assert.AreEqual(expected, actual, message);
        }

        public static void AssertHeader(AdministrationPage page)
        {
            var expected = Header;
            var actual = page.MainHeader.InnerText;
            var message = string.Format("Page header should be: {0}", expected);

            Assert.AreEqual(expected, actual, message);
        }
    }
}
