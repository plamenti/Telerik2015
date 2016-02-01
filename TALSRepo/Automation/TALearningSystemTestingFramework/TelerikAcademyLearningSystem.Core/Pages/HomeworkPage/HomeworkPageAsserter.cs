namespace TelerikAcademyLearningSystem.Core.Pages.HomeworkPage
{
    using System.IO;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikAcademyLearningSystem.Core.Model;
    using TelerikAcademyLearningSystem.Utilities;

    public static class HomeworkPageAsserter
    {
        private const string PageTitle = "Домашни - Телерик Академия - Студентска система";
        private const string ExcellHomeworkButtonNotVisibleMessage = @"Button ""Сваляне на Excel"" is not viisible";
        private const string PdfHomeworkButtonNotVisibleMessage = @"Button ""Сваляне на PDF"" is not viisible";
        private const string AddHomeworkNotVisibleMessage = @"Button ""Добавяне на домашно"" is not viisible";
        private const string BackToAdminNotVisibleMessage = @"Button ""Към администрацията"" is not viisible";

        public static void AssertTitle(this HomeworkPage page)
        {
            page.Browser.RefreshDomTree();
            Assert.AreEqual(PageTitle, page.Title, string.Format("The correct page title is: {0}", PageTitle));
        }

        public static void ExportToExcellBtnIsVisible(this HomeworkPage page)
        {
            Assert.IsTrue(page.ExportToExcellButton.IsVisible(), ExcellHomeworkButtonNotVisibleMessage);
        }

        public static void ExportToPdfBtnIsVisible(this HomeworkPage page)
        {
            Assert.IsTrue(page.ExportToPdfButton.IsVisible(), PdfHomeworkButtonNotVisibleMessage);
        }

        public static void AddHomeworkBtnIsVisible(this HomeworkPage page)
        {
            Assert.IsTrue(page.AddHomeworkButton.IsVisible(), AddHomeworkNotVisibleMessage);
        }

        public static void BackToAdminBtnIsVisible(this HomeworkPage page)
        {
            Assert.IsTrue(page.BackToAdministrationButton.IsVisible(), BackToAdminNotVisibleMessage);
        }

        public static void AssertFileExist(string fileName)
        {
            var path = PathGenerator.GeneratePathToDownloadedFilesFolder() + fileName;

            bool fileExists = File.Exists(path);

            Assert.IsTrue(fileExists, "The file " + fileName + " does not exist");
        }

        public static void ExportToPdfButtonDownloadsPdfFile(this HomeworkPage page, string fileName)
        {
            page.ExportToPdfButton.Wait.ForVisible();
            page.ExportToPdfButton.Download(false, DownloadOption.Save, fileName, 15000);

            bool fileExists = File.Exists(fileName);

            Assert.IsTrue(fileExists, "The file " + fileName + " does not exist");
        }

        public static void AssertHomeworkExist(this HomeworkPage page, Homework homework)
        {
            bool isAdded = page.ContainsHomework(homework);
            Assert.IsTrue(isAdded, "Homework is not added");
        }

        public static void AssertPopupIsClosed(this HomeworkPage page)
        {
            bool isVisible = page.PopUp.IsVisible();
            Assert.IsFalse(isVisible, "Edit form is not closed");
        }
    }
}
