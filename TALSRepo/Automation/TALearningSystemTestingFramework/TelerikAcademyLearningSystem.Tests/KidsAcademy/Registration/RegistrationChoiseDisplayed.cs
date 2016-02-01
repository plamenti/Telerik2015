namespace TelerikAcademyLearningSystem.Tests.AdminPanel.StudentsStatisticsByAge
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;

    [TestClass]
    public class RegistrationChoiseDisplayed : BaseTest
    {
        ////private KidsAcademyRegistrationChoiceFacade facade;

        public override void TestInit()
        {
            base.TestInit();
            ////this.facade = new KidsAcademyRegistrationChoiceFacade();
            KidsAcademyRegistrationChoiceFacade facade = new KidsAcademyRegistrationChoiceFacade();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Blagoy),
         TestCategory(Category.KidsAcademyRegistrationChoice)]
        public void VerifyPageIsCorrect()
        {
            KidsAcademyRegistrationChoiceFacade facade = new KidsAcademyRegistrationChoiceFacade();
            facade.OpenStudentsStatisticsPage();
            facade.VerifyPageIsOpen();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Blagoy),
         TestCategory(Category.KidsAcademyRegistrationChoice)]
        public void VerifySchoolsAreDisplayed()
        {
            KidsAcademyRegistrationChoiceFacade facade = new KidsAcademyRegistrationChoiceFacade();
            ///this.facade.OpenStudentsStatisticsPage();
            ///this.facade.VerifySchoolsExist();
            facade.OpenStudentsStatisticsPage();
            facade.VerifySchoolsExist();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Blagoy),
         TestCategory(Category.KidsAcademyRegistrationChoice)]
        public void VerifyRegistrationWithExistingAccount()
        {
            KidsAcademyRegistrationChoiceFacade facade = new KidsAcademyRegistrationChoiceFacade();
            ////this.facade.OpenStudentsStatisticsPage();
            ////this.facade.VerifyExistingAccountRegistration();
            facade.OpenStudentsStatisticsPage();
            facade.VerifyExistingAccountRegistration();
        }
    }
}