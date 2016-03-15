namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Homework
{
    using Core.Facades;
    using Core.Pages.HomeworkPage;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;

    [TestClass]
    public class ExportDataTests : BaseTest
    {
        private HomeworkFacade homeworkFacade;

        public override void TestInit()
        {
            base.TestInit();
            this.homeworkFacade = new HomeworkFacade();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void VerifyExportToExcellButton()
        {
            string fileName = "GridExcelExport.xlsx";

            this.homeworkFacade.ExportFile(fileName);
            HomeworkPageAsserter.AssertFileExist(fileName);
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void VerifyExportToPdfButton()
        {
            string fileName = "GridPdfExport.pdf";

            this.homeworkFacade.ExportFile(fileName);
            HomeworkPageAsserter.AssertFileExist(fileName);
        }

        /// <summary>
        /// This Testmethod is supposed to Fail
        /// </summary>
        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void VerifyDownloadAllHomeworksButton()
        {
            string fileName = "AllHomeworks.zip";

            this.homeworkFacade.ExportFile(fileName);
            HomeworkPageAsserter.AssertFileExist(fileName);
        }
    }
}
