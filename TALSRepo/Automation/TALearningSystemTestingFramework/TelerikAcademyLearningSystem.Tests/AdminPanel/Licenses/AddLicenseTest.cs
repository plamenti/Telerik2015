namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Licenses
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;
    using TelerikAcademyLearningSystem.Core.Model;
    using TelerikAcademyLearningSystem.Core.Pages.LicensesPage;

    [TestClass]
    public class AddLicenseTest : BaseTest
    {
        private LicenseFacade facade;

        public override void TestInit()
        {
            base.TestInit();
            this.facade = new LicenseFacade();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Biser),
        TestCategory(Category.Licenses)]
        public void AddLicenseWithValidData()
        {
            var license = new License("GiantLicense", "TestUrl", "TestLink");

            this.facade.CreateLicense(license);
            LicensesPageAsserter.AssertLicenseExist(LicensesPage.Instance, license);
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Licenses)]
        public void AddLicenseWithNoData()
        {
            this.facade.CreateLicenseWithNoData();
            this.facade.ValidateAllErrorMessages();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Licenses)]
        public void CancelAddLicense()
        {
            var license = new License("TestLicense", "TestUrl", "TestLink");

            this.facade.CancelCreateLicense(license);
            LicensesPageAsserter.AssertLicenseNotExist(LicensesPage.Instance, license);
        }
    }
}
