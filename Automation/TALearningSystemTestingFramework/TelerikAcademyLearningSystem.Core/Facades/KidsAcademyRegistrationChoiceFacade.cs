namespace TelerikAcademyLearningSystem.Core.Facades
{
    using Pages.KidsAcademyRegistrationChoicePage;

    public class KidsAcademyRegistrationChoiceFacade
    {
        public void OpenStudentsStatisticsPage()
        {
            KidsAcademyRegistrationChoicePage.Instance.Navigate();
        }

        public void VerifyPageIsOpen()
        {
            KidsAcademyRegistrationChoicePage.Instance.VerifyTitle();
            KidsAcademyRegistrationChoicePage.Instance.VerifytUrl();
        }

        public void VerifySchoolsExist()
        {
            KidsAcademyRegistrationChoicePage.Instance.VerifySchoolsRegistrations();
        }

        public void VerifyExistingAccountRegistration()
        {
            KidsAcademyRegistrationChoicePage.Instance.VerifyExistingAccountRegistration();
        }
    }
}
