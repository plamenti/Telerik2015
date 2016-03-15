namespace TALS.TestingFramework.Core.Pages.CoursesUnenrolledStudentsPage
{
    using ArtOfTest.Common.UnitTesting;
    using TALS.TestingFramework.Core.Base;

    public class CoursesUnenrolledStudentsPageAsserter : IAsserter
    {
        private const string CoursesUnenrolledStudentsPageTitle = "Отписани потребители от курсове - Телерик Академия - Студентска система";
        private CoursesUnenrolledStudentsPage coursesUnenrolledStudentsPage;

        public CoursesUnenrolledStudentsPageAsserter(CoursesUnenrolledStudentsPage coursesUnenrolledStudentsPage)
        {
            this.coursesUnenrolledStudentsPage = coursesUnenrolledStudentsPage;
        }

        public void DoAssert()
        {
            this.AssertTitle();
            this.ExportToExcelButtonIsVisible();
            this.LiveAndOnlineRadioButtonIsVisible();
            this.LiveRadioButtonIsVisible();
            this.OnlineRadioButtonIsVisible();
            this.UnenrolledStudentsGridIsVisible();
        }

        private void AssertTitle()
        {
            Assert.AreEqual(CoursesUnenrolledStudentsPageTitle, this.coursesUnenrolledStudentsPage.Title, string.Format("Page title should be: {0}", CoursesUnenrolledStudentsPageTitle));
        }

        private void ExportToExcelButtonIsVisible()
        {
            Assert.IsTrue(this.coursesUnenrolledStudentsPage.ExportToExcelButton.IsVisible(), "ExportToExcel Button is not visible");
        }

        private void LiveAndOnlineRadioButtonIsVisible()
        {
            Assert.IsTrue(this.coursesUnenrolledStudentsPage.LiveAndOnlineRadioButton.IsVisible(), "Live And Online Radio Button is not visible");
        }

        private void LiveRadioButtonIsVisible()
        {
            Assert.IsTrue(this.coursesUnenrolledStudentsPage.LiveRadioButton.IsVisible(), "Live Radio Button is not visible");
        }

        private void OnlineRadioButtonIsVisible()
        {
            Assert.IsTrue(this.coursesUnenrolledStudentsPage.OnlineRadioButton.IsVisible(), "Online Radio Button is not visible");
        }

        private void UnenrolledStudentsGridIsVisible()
        {
            Assert.IsTrue(this.coursesUnenrolledStudentsPage.UnenrolledStudentsGrid.IsVisible(), "UnenrolledStudents Grid is not visible");
        }
    }
}