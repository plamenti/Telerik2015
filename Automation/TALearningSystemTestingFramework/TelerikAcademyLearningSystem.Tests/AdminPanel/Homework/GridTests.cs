namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Homework
{
    using System;
    using Core.Facades;
    using Core.Pages.HomeworkPage;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Model;

    [TestClass]
    public class GridTests : BaseTest
    {
        private HomeworkFacade homeworkFacade;

        public override void TestInit()
        {
            base.TestInit();
            this.homeworkFacade = new HomeworkFacade();
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Biser),
         TestCategory(Category.Homework)]
        public void AssertGridSort()
        {
            throw new NotImplementedException();
            ////facade.SortHomeworkGrid();
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Biser),
         TestCategory(Category.Homework)]
        public void DownloadUserHomework()
        {
            var homework = new Homework("ДСА2016", "Рекурсия", "GiantTestUser", "4", true);
            var homeworkFileName = "TestHomeworkForUpload.xlsx";
            this.homeworkFacade.CreateHomework(homework, homeworkFileName);
            HomeworkPageAsserter.AssertHomeworkExist(HomeworkPage.Instance, homework);
            this.homeworkFacade.DownloadUserHomework(homework, homeworkFileName);
            HomeworkPageAsserter.AssertFileExist(homeworkFileName);
        }

        /// <summary>
        /// This test metod is acceptable to Fail
        /// </summary>
        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Biser),
         TestCategory(Category.Homework)]
        public void EditHomeworkMarkInGrid()
        {
            var homework = new Homework("ДСА2016", "Рекурсия", "GiantTestUser", "4", true);
            string homeworkFileName = "TestHomeworkForUpload.xlsx";
            string newMark = "5";
            this.homeworkFacade.CreateHomework(homework, homeworkFileName);
            HomeworkPageAsserter.AssertHomeworkExist(HomeworkPage.Instance, homework);
            this.homeworkFacade.EditHomeworkMark(homework, newMark);
            HomeworkPageAsserter.AssertPopupIsClosed(HomeworkPage.Instance);

            homework.Mark = newMark;
            HomeworkPageAsserter.AssertHomeworkExist(HomeworkPage.Instance, homework);
        }
    }
}
