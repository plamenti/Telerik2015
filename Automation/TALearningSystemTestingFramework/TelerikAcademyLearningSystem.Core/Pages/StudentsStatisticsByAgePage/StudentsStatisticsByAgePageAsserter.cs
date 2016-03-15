namespace TelerikAcademyLearningSystem.Core.Pages.StudentsStatisticsByAgePage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class StudentsStatisticsByAgePageAsserter
    {
        private const string StudentsStatisticsByAgePageTitle = "Статистика за студентите по навършени години - Телерик Академия - Студентска система";

        public static void VerifyTitle(this StudentsStatisticsByAgePage page)
        {
            Assert.AreEqual(StudentsStatisticsByAgePageTitle, page.Title, string.Format("Page title should be: {0}", StudentsStatisticsByAgePageTitle));
        }

        public static void VerifyLiveAndOnlineRadioButtonIsVisible(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.LiveAndOnlineRadioButton.IsVisible(), "Live And Online Radio Button is not visible");
        }

        public static void VerifyLiveRadioButtonIsVisible(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.LiveRadioButton.IsVisible(), "Live Radio Button is not visible");
        }

        public static void VerifyOnlineRadioButtonIsVisible(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.OnlineRadioButton.IsVisible(), "Online Radio Button is not visible");
        }

        public static void VerifyCourseFilterInputIsVisible(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.CourseFilter.IsVisible(), "Course Filter Input is not visible");
        }

        public static void VerifyYearRangeIsVisible(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.YearRange.IsVisible(), "Year range select is not visible");
        }

        public static void VerifyBackToAdminButtonIsVisible(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.BackToAdminButton.IsVisible(), "Back to admin button is not visible");
        }

        public static void VerifyTotalStudentsInCourseHeaderIsVisible(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.TotalStudentsInCourseHeader != null, "Total Students In Course Header should not be null");
        }

        public static void VerifyLiveAndOnlineRadioButtonIsSelected(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.LiveAndOnlineRadioButton.Checked, "Live And Online RadioButton should be Checked");
        }

        public static void VerifyLiveRadioButtonIsSelected(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.LiveRadioButton.Checked, "Live RadioButton should be Checked");
        }

        public static void VerifyOnlineRadioButtonIsSelected(this StudentsStatisticsByAgePage page)
        {
            Assert.IsTrue(page.OnlineRadioButton.Checked, "Online RadioButton should be Checked");
        }

        public static void VerifyYearOfBirthStatisticsChartIsVisible(this StudentsStatisticsByAgePage page, string courseName, string formOfEducation = "Присъствено и Онлайн")
        {
            Assert.IsTrue(page.YearOfBirthStatisticsChart.IsVisible(), "Year Of Birth Statistics Chart should be Visible");
            Assert.IsTrue(page.YearOfBirthStatisticsChart.InnerText.Contains(courseName));
            Assert.IsTrue(page.YearOfBirthStatisticsChart.InnerText.Contains(formOfEducation));
        }

        public static void VerifyYearOfBirthStatisticsChartBarsIsVisible(this StudentsStatisticsByAgePage page, string courseName, string formOfEducation = "Присъствено и Онлайн")
        {
            Assert.IsTrue(page.YearOfBirthStatisticsChartBars.IsVisible(), "Year Of Birth Statistics Chart Bars should be Visible");
            Assert.IsTrue(page.YearOfBirthStatisticsChartBars.InnerText.Contains(courseName));
            Assert.IsTrue(page.YearOfBirthStatisticsChartBars.InnerText.Contains(formOfEducation));
        }
    }
}