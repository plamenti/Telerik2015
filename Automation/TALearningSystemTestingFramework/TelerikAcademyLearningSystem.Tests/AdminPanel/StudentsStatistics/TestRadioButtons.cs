namespace TelerikAcademyLearningSystem.Tests.AdminPanel.StudentsStatistics
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;
    using TelerikAcademyLearningSystem.Core.Pages.StudentsStatisticsPage;

    [TestClass]
    public class TestRadioButtons : BaseTest
    {
        private const string CourseName = "Giant Test Course";
        private const string LiveAndOnline = "Присъствено и Онлайн";
        private const string Live = "Присъствено";
        private const string Online = "Онлайн";
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
        public void VerifyRadioButtonLiveAndOnline()
        {
            this.facade.StudentsStatisticsForFixedCourseInSomeForm(CourseName, LiveAndOnline);

            this.facade.AssertRadioButtonLiveAndOnline(CourseName, LiveAndOnline);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.StudentsStatistics)]
        public void VerifyRadioButtonLive()
        {
            this.facade.StudentsStatisticsForFixedCourseInSomeForm(CourseName, Live);

            this.facade.AssertRadioButtonLive(CourseName, Live);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.StudentsStatistics)]
        public void VerifyRadioButtonOnline()
        {
            this.facade.StudentsStatisticsForFixedCourseInSomeForm(CourseName, Online);

            this.facade.AssertRadioButtonOnline(CourseName, Online);
        }
    }
}