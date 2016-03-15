namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Homework
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Constants.Homework;
    using TelerikAcademyLearningSystem.Core.Facades;
    using TelerikAcademyLearningSystem.Core.Model;
    using TelerikAcademyLearningSystem.Core.Pages.HomeworkPage;
    using TelerikAcademyLearningSystem.Core.Pages.HomeworkPage.AddHomeworkPage;

    [TestClass]
    public class AddHomeworkTests : BaseTest
    {
        private HomeworkFacade homeworkFacade;

        public override void TestInit()
        {
            base.TestInit();
            this.homeworkFacade = new HomeworkFacade();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void VerifyAddHomeworkPage()
        {
            this.homeworkFacade.OpenAddHomeworkPage();
            this.homeworkFacade.AssertAddHomeworkPageIsOpen();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void AddHomeworkWithCorrectData()
        {
            var homework = new Homework("ДСА2016", "Рекурсия", "GiantTestUser", "4", true);
            var homeworkFileName = "TestHomeworkForUpload.xlsx";
            this.homeworkFacade.CreateHomework(homework, homeworkFileName);
            HomeworkPageAsserter.AssertHomeworkExist(HomeworkPage.Instance, homework);
        }

        /// <summary>
        /// This Test metod is acceptable to Fail
        /// </summary>
        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void AddHomeworkWithOurOfRangeCorseName()
        {
            var homework = new Homework(
                "ThisCourseNameIsOverOneHundredCharactersAndShouldBeTooLongToBeAValidCourseNameAndShouldBeNotAcceptedByTelerikAcademySystem",
                string.Empty,
                "GiantTestUser",
                "4",
                true);

            var homeworkFileName = "TestHomeworkForUpload.xlsx";
            this.homeworkFacade.CreateHomework(homework, homeworkFileName);
            AddHomeworkPageAsserter.CourseValidationMessageIsVisible(AddHomeworkPage.Instance, AddHomeworkConstants.CourseNameErrorMessageTooLong);
        }

        /// <summary>
        /// This Test metod is acceptable to Fail
        /// </summary>
        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void AddHomeworkWithNoData()
        {
            this.homeworkFacade.CreateHomeworkWithNoData();
            this.homeworkFacade.ValidateAllErrorMessages();
        }

        [TestMethod,
        Priority(Priority.Low),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void BackToAllHomeworkButtonIsFunctional()
        {
            this.homeworkFacade.OpenAddHomeworkPage();
            this.homeworkFacade.BackToAllHomeworks();
            this.homeworkFacade.AssertHomeworkPageIsOpen();
        }
    }
}
