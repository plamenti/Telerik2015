namespace TelerikAcademyLearningSystem.Tests.AdminPanel.StudentsStatisticsByAge
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;

    [TestClass]
    public class TestRadioButtons : BaseTest
    {
        private const string CourseName = "Giant Test Course";
        private const string LiveAndOnline = "Присъствено и Онлайн";
        private const string Live = "Присъствено";
        private const string Online = "Онлайн";

        public override void TestInit()
        {
            base.TestInit();
            StudentsStatisticsByAgeFacade facade = new StudentsStatisticsByAgeFacade();
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Blagoy),
         TestCategory(Category.StudentsStatisticsByAge)]
        public void VerifyRadioButtonLiveAndOnline()
        {
            StudentsStatisticsByAgeFacade facade = new StudentsStatisticsByAgeFacade();
            ////this.facade.StudentsStatisticsForFixedCourseInSomeForm(CourseName, LiveAndOnline);
            ////
            ////this.facade.VerifyRadioButtonLiveAndOnline(CourseName, LiveAndOnline);
            facade.StudentsStatisticsForFixedCourseInSomeForm(CourseName, LiveAndOnline);

            facade.VerifyRadioButtonLiveAndOnline(CourseName, LiveAndOnline);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Blagoy),
         TestCategory(Category.StudentsStatisticsByAge)]
        public void VerifyRadioButtonLive()
        {
            StudentsStatisticsByAgeFacade facade = new StudentsStatisticsByAgeFacade();
            ////this.facade.StudentsStatisticsForFixedCourseInSomeForm(CourseName, Live);
            ////
            ////this.facade.VerifyRadioButtonLive(CourseName, Live);
            facade.StudentsStatisticsForFixedCourseInSomeForm(CourseName, Live);

            facade.VerifyRadioButtonLive(CourseName, Live);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Blagoy),
         TestCategory(Category.StudentsStatisticsByAge)]
        public void VerifyRadioButtonOnline()
        {
            StudentsStatisticsByAgeFacade facade = new StudentsStatisticsByAgeFacade();
            ////this.facade.StudentsStatisticsForFixedCourseInSomeForm(CourseName, Online);
            ////
            ////this.facade.VerifyRadioButtonOnline(CourseName, Online);
            facade.StudentsStatisticsForFixedCourseInSomeForm(CourseName, Online);

            facade.VerifyRadioButtonOnline(CourseName, Online);
        }
    }
}