namespace TALS.TestingFramework.Core.Pages.HomeworkPage
{
    using ArtOfTest.Common.UnitTesting;
    using TALS.TestingFramework.Core.Base;

    public class HomeworkPageAsserter : IAsserter
    {
        private const string PageTitle = "Домашни - Телерик Академия - Студентска система";
        private const string ExcellHomeworkButtonNotVisibleMessage= @"Button ""Сваляне на Excel"" is not viisible";
        private const string PdfHomeworkButtonNotVisibleMessage = @"Button ""Сваляне на PDF"" is not viisible";
        private const string AddHomeworkNotVisibleMessage = @"Button ""Добавяне на домашно"" is not viisible";
        private const string BackToAdminNotVisibleMessage = @"Button ""Към администрацията"" is not viisible";

        private HomeworkPage homeworkPage;

        public HomeworkPageAsserter(HomeworkPage homeworkPage)
        {
            this.homeworkPage = homeworkPage;
        }

        public void DoAssert()
        {
            this.AssertTitle();
            this.ExportToExcellBtnIsVisible();
            this.ExportToPdfBtnIsVisible();
            this.AddHomeworkBtnIsVisible();
            this.BackToAdminBtnIsVisible();
        }

        private void AssertTitle()
        {
            Assert.AreEqual(PageTitle, homeworkPage.Title, string.Format("The correct page title is: {0}", PageTitle));
        }

        private void ExportToExcellBtnIsVisible()
        {
            Assert.IsTrue(this.homeworkPage.ExportToExcellButton.IsVisible(), ExcellHomeworkButtonNotVisibleMessage);
        }

        private void ExportToPdfBtnIsVisible()
        {
            Assert.IsTrue(this.homeworkPage.ExportToPdfButton.IsVisible(), PdfHomeworkButtonNotVisibleMessage);
        }

        private void AddHomeworkBtnIsVisible()
        {
            Assert.IsTrue(this.homeworkPage.AddHomeworkButton.IsVisible(), AddHomeworkNotVisibleMessage);
        }

        private void BackToAdminBtnIsVisible()
        {
            Assert.IsTrue(this.homeworkPage.BackToAdministrationButton.IsVisible(), BackToAdminNotVisibleMessage);
        }



    }
}
