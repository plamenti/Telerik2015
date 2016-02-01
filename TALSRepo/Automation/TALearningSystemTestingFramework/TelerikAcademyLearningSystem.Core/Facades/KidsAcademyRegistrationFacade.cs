namespace TelerikAcademyLearningSystem.Core.Facades
{
    using Model;
    using Pages.KidsAcademyRegistrationPage;
    using Pages.KidsAcademySuccessPage;

    public class KidsAcademyRegistrationFacade
    {
        public void Register(Kid kid)
        {
            KidsAcademyRegistrationPage.Instance.NavigateToNewAccountRegistration();
            KidsAcademyRegistrationPage.Instance.FillForm(kid);
            System.Threading.Thread.Sleep(3000);
            KidsAcademyRegistrationPage.Instance.Browser.RefreshDomTree();
            KidsAcademyRegistrationPage.Instance.Browser.WaitUntilReady();
        }

        public void VerifyRegisteredUser()
        {
            KidsAcademySuccessPage.Instance.AssertExamInfoDiv();
        }
    }
}
