namespace TelerikAcademyLearningSystem.Tests.AdminPanel.StudentsStatistics
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;
    using TelerikAcademyLearningSystem.Core.Pages.StudentsStatisticsPage;

    [TestClass]
    public class TestGraphicsDisplayed : BaseTest
    {
        private const string AllCoursesName = "Всички курсове";
        private const string CourseName = "Giant Test Course";
        private StudentsStatisticsFacade facade;

        public override void TestInit()
        {
            base.TestInit();
            this.facade = new StudentsStatisticsFacade();
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.StudentsStatistics)]
        public void VerifyAllCoursesStatistics()
        {
            this.facade.StudentsStatisticsForAllCourses();

            this.facade.AssertAllCoursesStatistics(AllCoursesName);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.StudentsStatistics)]
        public void VerifyFixedCourseStatistics()
        {
            this.facade.StudentsStatisticsForFixedCourse(CourseName);

            this.facade.AssertStudentsStatisticsForFixedCourse(CourseName);
        }
    }
}