namespace TelerikAcademyLearningSystem.Core.Pages.LicensesPage.AddLicensePage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class AddLicensePageAsserter
    {
        public static void LicenseNameValidationMessageIsVisible(this AddLicensePage page, string expectedMessage)
        {
            page.Browser.RefreshDomTree();
            var actualMessage = page.LicenseNameWarningMessage.InnerText;
            Assert.IsTrue(page.LicenseNameWarningMessage.IsVisible());
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        public static void LicenseUrlValidationMessageIsVisible(this AddLicensePage page, string expectedMessage)
        {
            page.Browser.RefreshDomTree();
            var actualMessage = page.LicenseUrlWarningMessage.InnerText;
            Assert.IsTrue(page.LicenseUrlWarningMessage.IsVisible());
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        public static void LicenseLinkValidationMessageIsVisible(this AddLicensePage page, string expectedMessage)
        {
            page.Browser.RefreshDomTree();
            var actualMessage = page.LicenseLinkWarningMessage.InnerText;
            Assert.IsTrue(page.LicenseLinkWarningMessage.IsVisible());
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
