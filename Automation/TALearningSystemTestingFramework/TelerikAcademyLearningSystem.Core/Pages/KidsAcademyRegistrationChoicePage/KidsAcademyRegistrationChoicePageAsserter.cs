namespace TelerikAcademyLearningSystem.Core.Pages.KidsAcademyRegistrationChoicePage
{
    using Constants;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class KidsAcademyRegistrationChoicePageAsserter
    {
        ////private const string PageTitle = "Регистрация в \"Детската академия на Телерик\" - Телерик Академия - Студентска система";
        ////private const string PageURL = @"http://stage.telerikacademy.com/KidsAcademy/Registration";

        internal static void VerifyTitle(this KidsAcademyRegistrationChoicePage page)
        {
            Assert.AreEqual(PageTitle.KidsAcademy, page.CurrentTitle, string.Format("Page title should be: {0}", PageTitle.KidsAcademy));
        }

        internal static void VerifytUrl(this KidsAcademyRegistrationChoicePage page)
        {
            Assert.AreEqual(UrlLink.KidsAcademyRegistrationChoice, page.CurrentUrl, "Different Url");
        }

        internal static void VerifySchoolsRegistrations(this KidsAcademyRegistrationChoicePage page)
        {
            Assert.IsNotNull(page.FirstRegistrationLink);
            Assert.IsNotNull(page.SecondRegistrationLink);
            Assert.IsNotNull(page.ThirdRegistrationLink);
        }

        internal static void VerifyExistingAccountRegistration(this KidsAcademyRegistrationChoicePage page)
        {
            Assert.IsNotNull(page.ExistingAccountRegistration);
        }
    }
}
