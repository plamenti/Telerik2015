namespace TelerikAcademyLearningSystem.Tests.AdminPanel.StudentsInCourses.ExportData
{
    using Core.Facades;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;

    [TestClass]
    public class ExportDataTest : BaseTest
    {
        [TestMethod,
        Priority(Priority.Medium),
        Owner(Owner.Dushka),
        TestCategory(Category.StudentsInCourses)]
        public void VeryfyStudentsInCoursesExelFileIsDownloaded()
        {
            StudentInCourseFacade studentInCourseFacade = new StudentInCourseFacade();
            string fileName = "UsersInCourseExportGrid.xlsx";
            studentInCourseFacade.DownloadExcelFile(fileName);
            studentInCourseFacade.AssertFileExist(fileName);
        }
    }
}
