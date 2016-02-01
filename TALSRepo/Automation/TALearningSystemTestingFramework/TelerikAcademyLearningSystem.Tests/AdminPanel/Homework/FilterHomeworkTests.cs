namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Homework
{
    using Core.Facades;
    using Core.Pages.HomeworkPage;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Model;

    [TestClass]
    public class FilterHomeworkTests : BaseTest
    {
        private HomeworkFacade homeworkFacade;

        public override void TestInit()
        {
            base.TestInit();
            this.homeworkFacade = new HomeworkFacade();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void FilterByCourseLectureUserAndEvaluation()
        {
            var homework = new Homework("ДСА2016", "Рекурсия", "GiantTestUser", "4", true);
            var homeworkFileName = "TestHomeworkForUpload.xlsx";
            this.homeworkFacade.CreateHomework(homework, homeworkFileName);
            this.homeworkFacade.FilterHomeworkGridByCourseLectureUserAndEvaluation(homework);
            HomeworkPageAsserter.AssertHomeworkExist(HomeworkPage.Instance, homework);
        }
    }
}
