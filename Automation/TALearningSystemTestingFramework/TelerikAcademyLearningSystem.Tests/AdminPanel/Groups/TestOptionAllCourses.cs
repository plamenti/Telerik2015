namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Groups
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Constants;
    using TelerikAcademyLearningSystem.Core.Facades;

    [TestClass]
    public class TestOptionAllCourses : BaseTest
    {
        private GroupsFacade groupsFacade;

        public override void TestInit()
        {
            base.TestInit();
            this.groupsFacade = new GroupsFacade();
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifyOptionAllCourses()
        {
            string courseName = CourseNames.AllCourses;

            this.groupsFacade.FilterCoursesFacade(courseName);

            this.groupsFacade.AssertAreCoursesDifferent();
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifySomeFixedCourse()
        {
            string courseName = CourseNames.GiantTestCourse;

            this.groupsFacade.FilterCoursesFacade(courseName);

            this.groupsFacade.AssertAreCoursesSame();
        }
    }
}