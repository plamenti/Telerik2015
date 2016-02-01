namespace TALS.TestingFramework.Core.Pages.CoursesAndLecturesPage
{
    using ArtOfTest.Common.UnitTesting;
    using TALS.TestingFramework.Core.Base;

    public class CoursesAndLecturesPageAsserter: IAsserter
    {
        private CoursesAndLecturesPage page;
        private const string Title = "Курсове и лекции - Телерик Академия - Студентска система";

        public CoursesAndLecturesPageAsserter(CoursesAndLecturesPage page)
        {
            this.page = page;
        }

        public void DoAssert()
        {
            this.IsDivVissible();
        }

        private void AssertTitle()
        {
            Assert.AreEqual(Title, this.page.Title, string.Format("Page title should be: {0}", Title));
        }

        private void IsDivVissible()
        {
            Assert.IsTrue(this.page.PopUp.IsVisible());
        }

        private void VeryfyDataPresentInGrid(string name)
        {
            Assert.IsTrue(this.page.GridTable.InnerText.Contains(name));
        }
    }
}
