namespace TelerikAcademyLearningSystem.Core.Pages.StudentsStatisticsPage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public static class StudentsStatisticsPageAsserter
    {
        private const string StudentsStatisticsPageTitle = "Статистика за изпитите - Телерик Академия - Студентска система";

        public static void VerifyTitle(this StudentsStatisticsPage page)
        {
            Assert.AreEqual(StudentsStatisticsPageTitle, page.Title, string.Format("Page title should be: {0}", StudentsStatisticsPageTitle));
        }

        public static void VerifyLiveAndOnlineRadioButtonIsVisible(this StudentsStatisticsPage page)
        {
            Assert.IsTrue(page.LiveAndOnlineRadioButton.IsVisible(), "Live And Online Radio Button is not visible");
        }

        public static void VerifyLiveRadioButtonIsVisible(this StudentsStatisticsPage page)
        {
            Assert.IsTrue(page.LiveRadioButton.IsVisible(), "Live Radio Button is not visible");
        }

        public static void VerifyOnlineRadioButtonIsVisible(this StudentsStatisticsPage page)
        {
            Assert.IsTrue(page.OnlineRadioButton.IsVisible(), "Online Radio Button is not visible");
        }

        public static void VerifyCourseFilterInputIsVisible(this StudentsStatisticsPage page)
        {
            Assert.IsTrue(page.CourseFilter.IsVisible(), "Course Filter Input is not visible");
        }

        public static void VerifyBackToAdminButtonIsVisible(this StudentsStatisticsPage page)
        {
            Assert.IsTrue(page.BackToAdminButton.IsVisible(), "Back to admin button is not visible");
        }

        public static void VerifyTotalStudentsInCourseHeaderIsVisible(this StudentsStatisticsPage page)
        {
            Assert.IsTrue(page.TotalStudentsInCourseHeader != null, "Total Students In Course Header should not be null");
        }

        public static void VerifyLiveAndOnlineRadioButtonIsSelected(this StudentsStatisticsPage page)
        {
            Assert.IsTrue(page.LiveAndOnlineRadioButton.Checked, "Live And Online RadioButton should be Checked");
        }

        public static void VerifyLiveRadioButtonIsSelected(this StudentsStatisticsPage page)
        {
            Assert.IsTrue(page.LiveRadioButton.Checked, "Live RadioButton should be Checked");
        }

        public static void VerifyOnlineRadioButtonIsSelected(this StudentsStatisticsPage page)
        {
            Assert.IsTrue(page.OnlineRadioButton.Checked, "Online RadioButton should be Checked");
        }

        public static void VerifyExamStatisticChartIsVisible(this StudentsStatisticsPage page, string courseName, string formOfEducation = "Присъствено и Онлайн")
        {
            Assert.IsTrue(page.ExamStatisticChart.IsVisible(), "Exam Statistic Chart should be Visible");
            Assert.IsTrue(page.ExamStatisticChart.InnerText.Contains(courseName));
            var contains = page.ExamStatisticChart.InnerText.Contains(formOfEducation);
            Assert.IsTrue(page.ExamStatisticChart.InnerText.Contains(formOfEducation));
        }

        public static void VerifyUniversitiesStatisticsChartIsVisible(this StudentsStatisticsPage page, string courseName, string formOfEducation = "Присъствено и Онлайн")
        {
            Assert.IsTrue(page.UniversitiesStatisticsChart.IsVisible(), "Universities Statistics Chart should be Visible");
            Assert.IsTrue(page.UniversitiesStatisticsChart.InnerText.Contains(courseName));
            Assert.IsTrue(page.UniversitiesStatisticsChart.InnerText.Contains(formOfEducation));
        }

        public static void VerifyCitiesStatisticsChartIsVisible(this StudentsStatisticsPage page, string courseName, string formOfEducation = "Присъствено и Онлайн")
        {
            Assert.IsTrue(page.CitiesStatisticsChart.IsVisible(), "Cities Statistics Chart should be Visible");
            Assert.IsTrue(page.CitiesStatisticsChart.InnerText.Contains(courseName));
            Assert.IsTrue(page.CitiesStatisticsChart.InnerText.Contains(formOfEducation));
        }

        public static void VerifyGenderStatisticsChartIsVisible(this StudentsStatisticsPage page, string courseName, string formOfEducation = "Присъствено и Онлайн")
        {
            Assert.IsTrue(page.GenderStatisticsChart.IsVisible(), "Gender Statistics Chart should be Visible");
            Assert.IsTrue(page.GenderStatisticsChart.InnerText.Contains(courseName));
            Assert.IsTrue(page.GenderStatisticsChart.InnerText.Contains(formOfEducation));
        }

        public static void VerifyYearOfBirthStatisticsChartIsVisible(this StudentsStatisticsPage page, string courseName, string formOfEducation = "Присъствено и Онлайн")
        {
            Assert.IsTrue(page.YearOfBirthStatisticsChart.IsVisible(), "Year Of Birth Statistics Chart should be Visible");
            Assert.IsTrue(page.YearOfBirthStatisticsChart.InnerText.Contains(courseName));
            Assert.IsTrue(page.YearOfBirthStatisticsChart.InnerText.Contains(formOfEducation));
        }

        public static void VerifyYearOfBirthStatisticsChartBarsIsVisible(this StudentsStatisticsPage page, string courseName, string formOfEducation = "Присъствено и Онлайн")
        {
            Assert.IsTrue(page.YearOfBirthStatisticsChartBars.IsVisible(), "Year Of Birth Statistics Chart Bars should be Visible");
            Assert.IsTrue(page.YearOfBirthStatisticsChartBars.InnerText.Contains(courseName));
            Assert.IsTrue(page.YearOfBirthStatisticsChartBars.InnerText.Contains(formOfEducation));
        }
    }
}