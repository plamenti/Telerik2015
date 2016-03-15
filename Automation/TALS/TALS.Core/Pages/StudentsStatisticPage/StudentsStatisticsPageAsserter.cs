namespace TALS.TestingFramework.Core.Pages.StudentsStatisticPage
{
    using ArtOfTest.Common.UnitTesting;
    using TALS.TestingFramework.Core.Base;

    public class StudentsStatisticsPageAsserter : IAsserter
    {
        private const string StudentsStatisticsPageTitle = "Статистика за изпитите - Телерик Академия - Студентска система";
        private StudentsStatisticsPage studentsStatisticsPage;

        public StudentsStatisticsPageAsserter(StudentsStatisticsPage studentsStatisticsPage)
        {
            this.studentsStatisticsPage = studentsStatisticsPage;
        }

        public void DoAssert()
        {
            this.AssertTitle();
            this.LiveAndOnlineRadioButtonIsVisible();
            this.LiveRadioButtonIsVisible();
            this.OnlineRadioButtonIsVisible();
            this.CourseFilterInputIsVisible();
            this.BackToAdminButtonIsVisible();
        }

        private void AssertTitle()
        {
            Assert.AreEqual(StudentsStatisticsPageTitle, this.studentsStatisticsPage.Title, string.Format("Page title should be: {0}", StudentsStatisticsPageTitle));
        }

        private void LiveAndOnlineRadioButtonIsVisible()
        {
            Assert.IsTrue(this.studentsStatisticsPage.LiveAndOnlineRadioButton.IsVisible(), "Live And Online Radio Button is not visible");
        }

        private void LiveRadioButtonIsVisible()
        {
            Assert.IsTrue(this.studentsStatisticsPage.LiveRadioButton.IsVisible(), "Live Radio Button is not visible");
        }

        private void OnlineRadioButtonIsVisible()
        {
            Assert.IsTrue(this.studentsStatisticsPage.OnlineRadioButton.IsVisible(), "Online Radio Button is not visible");
        }

        private void CourseFilterInputIsVisible()
        {
            Assert.IsTrue(this.studentsStatisticsPage.CourseFilter.IsVisible(), "Course Filter Input is not visible");
        }

        private void BackToAdminButtonIsVisible()
        {
            Assert.IsTrue(this.studentsStatisticsPage.BackToAdminButton.IsVisible(), "Back to admin button is not visible");
        }
    }
}