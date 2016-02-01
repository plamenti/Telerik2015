namespace TelerikAcademyLearningSystem.Core.Facades
{
    using Pages.StudentsStatisticsByAgePage;

    public class StudentsStatisticsByAgeFacade
    {
        public void OpenStudentsStatisticsPage()
        {
            StudentsStatisticsByAgePage.Instance.Navigate();
        }

        public void BackToAdministration()
        {
            StudentsStatisticsByAgePage.Instance.Navigate();
            StudentsStatisticsByAgePage.Instance.BackToAdminButton.Click();
        }

        public void StudentsStatisticsForAllCourses()
        {
            StudentsStatisticsByAgePage.Instance.Navigate();
            StudentsStatisticsByAgePage.Instance.SelectAllCourses();
        }

        public void StudentsStatisticsForFixedCourse(string courseName)
        {
            StudentsStatisticsByAgePage.Instance.Navigate();
            StudentsStatisticsByAgePage.Instance.SelectFixedCourse(courseName);
        }

        public void StudentsStatisticsForFixedCourseInSomeForm(string courseName, string form)
        {
            StudentsStatisticsByAgePage.Instance.Navigate();
            StudentsStatisticsByAgePage.Instance.SelectFixedCourseInSomeForm(courseName, form);
        }

        public void VerifyRadioButtonLiveAndOnline(string courseName, string liveAndOnline)
        {
            StudentsStatisticsByAgePage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsByAgePage.Instance.VerifyLiveAndOnlineRadioButtonIsSelected();
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(courseName, liveAndOnline);
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(courseName, liveAndOnline);
        }

        public void VerifyRadioButtonLive(string courseName, string live)
        {
            StudentsStatisticsByAgePage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsByAgePage.Instance.VerifyLiveRadioButtonIsSelected();
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(courseName, live);
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(courseName, live);
        }

        public void VerifyRadioButtonOnline(string courseName, string online)
        {
            StudentsStatisticsByAgePage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsByAgePage.Instance.VerifyOnlineRadioButtonIsSelected();
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(courseName);
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(courseName, online);
        }

        public void VerifyAllCoursesStatistics(string allCoursesName)
        {
            StudentsStatisticsByAgePage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsByAgePage.Instance.VerifyLiveAndOnlineRadioButtonIsSelected();
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(allCoursesName);
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(allCoursesName);
        }

        public void VarifyStudentsStatisticsForFixedCourse(string courseName)
        {
            StudentsStatisticsByAgePage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsByAgePage.Instance.VerifyLiveAndOnlineRadioButtonIsSelected();
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(courseName);
            StudentsStatisticsByAgePage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(courseName);
        }
    }
}