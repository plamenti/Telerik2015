namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Licenses
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;
    using TelerikAcademyLearningSystem.Core.Pages.LicensesPage;

    [TestClass]
    public class ExportDataTest : BaseTest
    {
        private LicenseFacade facade;

        public override void TestInit()
        {
            base.TestInit();
            this.facade = new LicenseFacade();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Licenses)]
        public void AssertExportToExcellButton()
        {
            string fileName = "LicenseExcelExport.xls";

            this.facade.ExportFile(fileName);
            LicensesPageAsserter.AssertFileExist(fileName);
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Licenses)]
        public void AssertExportToPdfButton()
        {
            string fileName = "LicensePdfExport.pdf";

            this.facade.ExportFile(fileName);
            LicensesPageAsserter.AssertFileExist(fileName);
        }
    }
}
