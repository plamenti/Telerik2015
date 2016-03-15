namespace TelerikAcademyLearningSystem.Tests.AdminPanel.CoursesUnenrolledStudents
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;

    [TestClass]
    public class TestOptionUnenrolledStudentsFromCourses : BaseTest
    {
        private CoursesUnenrolledStudentsFacade coursesUnenrolledStudentsFacade;

        public override void TestInit()
        {
            base.TestInit();
            this.coursesUnenrolledStudentsFacade = new CoursesUnenrolledStudentsFacade();
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyOptionFromAllCourses()
        {
            this.coursesUnenrolledStudentsFacade.StudentsFromAllCourses();

            this.coursesUnenrolledStudentsFacade.AssertSelectAllCourses();
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyOptionFromFixedCourse()
        {
            string courseName = "Giant Test Course";
            this.coursesUnenrolledStudentsFacade.AssertStudentsFromFixedCourse(courseName);

            this.coursesUnenrolledStudentsFacade.AssertSelectFixedCourse(courseName);
        }
    }
}