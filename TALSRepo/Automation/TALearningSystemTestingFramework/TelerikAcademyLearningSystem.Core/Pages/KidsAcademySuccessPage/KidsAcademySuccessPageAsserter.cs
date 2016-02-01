namespace TelerikAcademyLearningSystem.Core.Pages.KidsAcademySuccessPage
{
    using Constants;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class KidsAcademySuccessPageAsserter
    {
        public static void AssertSuccessfulRegistration(this KidsAcademySuccessPage page)
        {
            Assert.AreEqual(KidsAcademyRegistrationForm.ChooseExamMessage, page.ChooseExam.Value);
        }

        public static void AssertExamInfoDiv(this KidsAcademySuccessPage page)
        {
            Assert.IsTrue(page.InportantMessageInfoDiv.IsVisible());
        }
    }
}
