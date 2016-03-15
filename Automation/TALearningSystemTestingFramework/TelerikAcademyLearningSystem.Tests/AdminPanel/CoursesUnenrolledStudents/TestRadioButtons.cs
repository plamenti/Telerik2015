namespace TelerikAcademyLearningSystem.Tests.AdminPanel.CoursesUnenrolledStudents
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;

    [TestClass]
    public class TestRadioButtons : BaseTest
    {
        private CoursesUnenrolledStudentsFacade coursesUnenrolledStudentsFacade;

        public override void TestInit()
        {
            base.TestInit();
            this.coursesUnenrolledStudentsFacade = new CoursesUnenrolledStudentsFacade();
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyRadioButtonAll()
        {
            this.coursesUnenrolledStudentsFacade.AssertRadioButtonAll();

            this.coursesUnenrolledStudentsFacade.AssertSelectLiveAndOnline();
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyRadioButtonLive()
        {
            this.coursesUnenrolledStudentsFacade.AssertRadioButtonLive();

            this.coursesUnenrolledStudentsFacade.AssertSelectLive();
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyRadioButtonOnline()
        {
            this.coursesUnenrolledStudentsFacade.AssertRadioButtonOnline();

            this.coursesUnenrolledStudentsFacade.AssertSelectOnline();
        }
    }
}