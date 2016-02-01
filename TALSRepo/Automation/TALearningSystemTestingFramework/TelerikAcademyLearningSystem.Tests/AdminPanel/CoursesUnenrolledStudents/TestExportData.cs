namespace TelerikAcademyLearningSystem.Tests.AdminPanel.CoursesUnenrolledStudents
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;

    [TestClass]
    public class TestExportData : BaseTest
    {
        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyButtonExportToExcel()
        {
            CoursesUnenrolledStudentsFacade coursesUnenrolledStudentsFacade = new CoursesUnenrolledStudentsFacade();
            string fileName = "GridExcelExport.xls";

            coursesUnenrolledStudentsFacade.ExportToExcelDownloadsExcelFile(fileName);

            coursesUnenrolledStudentsFacade.AssertExportToExcelDownloadsExcelFile(fileName);
        }
    }
}