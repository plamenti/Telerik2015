namespace TelerikAcademyLearningSystem.Tests.AdminPanel.StudentsStatisticsByAge
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;

    [TestClass]
    public class TestGraphicsDisplayed : BaseTest
    {
        private const string AllCoursesName = "Всички курсове";
        private const string CourseName = "Giant Test Course";
        ////private StudentsStatisticsByAgeFacade facade;

        public override void TestInit()
        {
            base.TestInit();
            ////this.facade = new StudentsStatisticsByAgeFacade();
            StudentsStatisticsByAgeFacade facade = new StudentsStatisticsByAgeFacade();
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Blagoy),
         TestCategory(Category.StudentsStatisticsByAge)]
        public void VerifyAllCoursesStatistics()
        {
            StudentsStatisticsByAgeFacade facade = new StudentsStatisticsByAgeFacade();
            ////this.facade.StudentsStatisticsForAllCourses();

            ////this.facade.VerifyAllCoursesStatistics(AllCoursesName);
            facade.StudentsStatisticsForAllCourses();

            facade.VerifyAllCoursesStatistics(AllCoursesName);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Blagoy),
         TestCategory(Category.StudentsStatisticsByAge)]
        public void VerifyFixedCourseStatistics()
        {
            StudentsStatisticsByAgeFacade facade = new StudentsStatisticsByAgeFacade();
            ////this.facade.StudentsStatisticsForFixedCourse(CourseName);
            ////
            ////this.facade.VarifyStudentsStatisticsForFixedCourse(CourseName);
            facade.StudentsStatisticsForFixedCourse(CourseName);

            facade.VarifyStudentsStatisticsForFixedCourse(CourseName);
        }
    }
}