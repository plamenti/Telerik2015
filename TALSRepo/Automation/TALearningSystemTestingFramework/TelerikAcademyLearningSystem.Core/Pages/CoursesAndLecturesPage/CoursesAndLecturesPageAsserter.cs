namespace TelerikAcademyLearningSystem.Core.Pages.CoursesAndLecturesPage
{
    using System.Linq;
    using System.Threading;
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Core;
    using Constants;
    using Model;
    
    public static class CoursesAndLecturesPageAsserter
    {
        public static void AssertPageTitle(this CoursesAndLecturesPage page)
        {
            var message = string.Format("Page title should be: {0}", PageTitle.CoursesAndLectures);
            Assert.AreEqual(PageTitle.CoursesAndLectures, page.Title, message);
        }

        public static void AssertGridTitle(this CoursesAndLecturesPage page)
        {
            var expected = GridTitle.CoursesAndLectures;
            var actual = page.GridTitle;
            var message = string.Format("Grid title should be: {0}", expected);
        }

        public static void AssertCoursesAndLecturesUrlIsOpen(this CoursesAndLecturesPage page)
        {
            var actualUrl = Manager.Current.ActiveBrowser.Url.ToString();
            var expectedUrl = UrlLink.CoursesAndLectures;
            var message = string.Format("Link {0} is not open.", expectedUrl);
            Assert.AreEqual(expectedUrl, actualUrl, message);
        }

        public static void AssertCreateCourseButtonIsVisible(this CoursesAndLecturesPage page)
        {
            Assert.IsTrue(page.CreateCourseButton.IsVisible(), "Create course button is not visible");
        }

        public static void AssertBackToAdminButtonIsVisible(this CoursesAndLecturesPage page)
        {
            Assert.IsTrue(page.BackToAdminButton.IsVisible(), "Back to admin button is not visible");
        }

        public static void AssertIsFormVissible(this CoursesAndLecturesPage page)
        {
            Assert.IsTrue(page.PopUp.IsVisible(), "Popup is not open");
        }

        public static void AssertCourseIsCreated(this CoursesAndLecturesPage page, Course course)
        {
            page.Browser.Refresh();
            Thread.Sleep(10000);
            page.Browser.RefreshDomTree();
                
            var newRowIndex = page.GridPage.FindRow("Име (BG)", course.NameBg);
            var newRow = page.GridPage.GridTable.Rows[newRowIndex];
            var currentRow = page.GridPage.GridTable.Rows[newRowIndex - 1];

            Assert.AreEqual(course.NameEn, currentRow.Cells[3].InnerText);
            Assert.AreEqual(course.UrlName, currentRow.Cells[4].InnerText);
            Assert.AreEqual(course.Description, currentRow.Cells[5].InnerText);

            string color = string.Empty;
            var style = currentRow.Cells[6].Find.AllByTagName("span").FirstOrDefault().Attributes.FirstOrDefault().Value;
            var index = style.IndexOf('#') + 1;
            color = style.Substring(index, 6);
            //// Assert.AreEqual(course.Color, color);
            Assert.AreEqual(course.Order.ToString(), currentRow.Cells[7].InnerText);
            page.Browser.RefreshDomTree();
            course.Id = int.Parse(currentRow.Cells[1].InnerText);
        }

        public static void AssertCourseDoesntExist(this CoursesAndLecturesPage page, Course course)
        {
            var all = page.GridPage.GridTable;
            foreach (var row in all.BodyRows)
            {
                foreach (var value in row.Cells)
                {
                    Assert.IsFalse(value.InnerText.Contains(course.NameBg), string.Format("The NameBg \"{0}\" is exist", course.NameBg));
                    Assert.IsFalse(value.InnerText.Contains(course.NameEn), string.Format("The NameEn \"{0}\" is exist", course.NameEn));
                    Assert.IsFalse(value.InnerText.Contains(course.UrlName), string.Format("The URlName \"{0}\" is exist", course.UrlName));
                }
            }
        }

        public static void AssertPageIsFullDownladed(this CoursesAndLecturesPage page)
        {
            page.Browser.RefreshDomTree();
            AssertPageTitle(page);
            AssertCreateCourseButtonIsVisible(page);
            AssertBackToAdminButtonIsVisible(page);
            AssertGridTitle(page);
        }
    }
}
