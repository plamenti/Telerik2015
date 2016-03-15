namespace TelerikAcademyLearningSystem.Core.Pages.CategoryPages
{
    using System.IO;
    using ArtOfTest.Common.UnitTesting;

    public static class CategoryPageAsserter
    {
        private const string PageTitle = "Категории курсове - Телерик Академия - Студентска система";
        private const string PageMainHeader = "Категории курсове";
        private const string PageURL = @"http://stage.telerikacademy.com/Administration_Courses/CourseInstanceCategories";

        internal static void AssertTitle(this CategoryPage page)
        {
            Assert.AreEqual(PageTitle, page.Title, string.Format("Page title should be: {0}", PageTitle));
        }

        internal static void AssertHeader(this CategoryPage page)
        {
            Assert.IsTrue(page.Header.IsVisible());
            Assert.AreEqual(PageMainHeader, page.Header.InnerText, string.Format("Page header should be Категории курсове - Телерик Академия - Студентска система"));
        }
        
        //internal static void AssertUrl(this CategoryPage page)
        //{
        //    Assert.AreEqual(PageURL, page.Url, "Different Url");
        //}
        //
        //internal static void AssertCategoryExist(this CategoryPage page, Categories category)
        //{
        //    var numberOfRow = page.GridPage.FindRow("Категория", category.Name);
        //    var gridRow = page.GridPage.GridTable.Rows[numberOfRow - 1];
        //
        //    Assert.AreEqual(gridRow.Cells[2].InnerText, category.Name);
        //    Assert.AreEqual(gridRow.Cells[3].InnerText, category.Order.ToString());
        //    category.Id = int.Parse(gridRow.Cells[1].InnerText);
        //}
        //
        //internal static void AssertCategoryDoesntExist(this CategoryPage page, Categories category)
        //{
        //    var all = page.GridPage.GridTable;
        //    foreach (var row in all.BodyRows)
        //    {
        //        foreach (var value in row.Cells)
        //        {
        //            Assert.IsFalse(value.InnerText.Contains(category.Name), "Category exist");
        //        }
        //    }
        //}
        //
        //internal static void AssertFileExist(string fileName)
        //{
        //    var path = PathGenerator.AbsoluteRelativeCombine(Paths.ExportLocation + fileName);
        //    Assert.IsTrue(File.Exists(path));
        //}
    }
}
