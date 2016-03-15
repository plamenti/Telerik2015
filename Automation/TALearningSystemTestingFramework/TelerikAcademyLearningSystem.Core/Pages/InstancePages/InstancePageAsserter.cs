namespace TelerikAcademyLearningSystem.Core.Pages.InstancePages
{
    using ArtOfTest.Common.UnitTesting;
    using Model;
    using System.IO;
    using Constants;
    using Utilities;

    public static class InstancePageAsserter
    {
        private const string PageTitle = "Курсове и лекции - Телерик Академия - Студентска система";
        private const string PageMainHeader = "Категории курсове";

        public static void AssertTitle(this InstancePage page)
        {
            Assert.AreEqual(PageTitle, page.Title, string.Format("Page title should be: {0}", PageTitle));
        }

        public static void AssertHeader(this InstancePage page)
        {
            Assert.IsTrue(page.Header.IsVisible());
            Assert.AreEqual(PageMainHeader, page.Header.InnerText, string.Format("Page header should be Категории курсове - Телерик Академия - Студентска система"));
        }

        public static void AssertCreateGroupButtonIsVisible(this InstancePage page)
        {
            Assert.IsTrue(page.Add.IsVisible(), "Create group button is not visible");
        }

        public static void AssertBackToAdminButtonIsVisible(this InstancePage page)
        {
            Assert.IsTrue(page.BackToAdminButton.IsVisible(), "Back to admin button is not visible");
        }

        public static void AssertInstanceExist(this InstancePage page, Instance instance)
        {
            var numberOfRow = page.GridPage.FindRow("Име", instance.Name);
            var gridRow = page.GridPage.GridTable.Rows[numberOfRow - 1];

            Assert.AreEqual(gridRow.Cells[2].InnerText, instance.Name);
            Assert.AreEqual(gridRow.Cells[3].InnerText, instance.Description.ToString());
            instance.Id = int.Parse(gridRow.Cells[1].InnerText);
        }

        public static void AssertInstanceDoesntExist(this InstancePage page, Instance instance)
        {
            var all = page.GridPage.GridTable;
            foreach (var row in all.BodyRows)
            {
                foreach (var value in row.Cells)
                {
                    Assert.IsFalse(value.InnerText.Contains(instance.Name), "Instance exist");
                }
            }
        }

        public static void AssertFileExist(this InstancePage page, string fileName)
        {
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.ExportLocation + fileName);
            Assert.IsTrue(File.Exists(path));
        }
    }
}
