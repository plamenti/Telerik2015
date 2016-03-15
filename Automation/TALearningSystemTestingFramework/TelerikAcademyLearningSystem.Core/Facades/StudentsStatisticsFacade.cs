namespace TelerikAcademyLearningSystem.Core.Facades
{
    using Pages.StudentsStatisticsPage;

    public class StudentsStatisticsFacade
    {
        public void OpenStudentsStatisticsPage()
        {
            StudentsStatisticsPage.Instance.Navigate();
        }

        public void BackToAdministration()
        {
            StudentsStatisticsPage.Instance.Navigate();
            StudentsStatisticsPage.Instance.BackToAdminButton.Click();
        }

        public void StudentsStatisticsForAllCourses()
        {
            StudentsStatisticsPage.Instance.Navigate();
            StudentsStatisticsPage.Instance.SelectAllCourses();
        }

        public void StudentsStatisticsForFixedCourse(string courseName)
        {
            StudentsStatisticsPage.Instance.Navigate();
            StudentsStatisticsPage.Instance.SelectFixedCourse(courseName);
        }

        public void StudentsStatisticsForFixedCourseInSomeForm(string courseName, string form)
        {
            StudentsStatisticsPage.Instance.Navigate();
            StudentsStatisticsPage.Instance.SelectFixedCourseInSomeForm(courseName, form);
        }

        public void AssertRadioButtonLiveAndOnline(string courseName, string liveAndOnline)
        {
            StudentsStatisticsPage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsPage.Instance.VerifyLiveAndOnlineRadioButtonIsSelected();
            StudentsStatisticsPage.Instance.VerifyExamStatisticChartIsVisible(courseName, liveAndOnline);
            StudentsStatisticsPage.Instance.VerifyUniversitiesStatisticsChartIsVisible(courseName, liveAndOnline);
            StudentsStatisticsPage.Instance.VerifyCitiesStatisticsChartIsVisible(courseName, liveAndOnline);
            StudentsStatisticsPage.Instance.VerifyGenderStatisticsChartIsVisible(courseName, liveAndOnline);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(courseName, liveAndOnline);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(courseName, liveAndOnline);
        }

        public void AssertRadioButtonLive(string courseName, string live)
        {
            StudentsStatisticsPage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsPage.Instance.VerifyLiveRadioButtonIsSelected();
            StudentsStatisticsPage.Instance.VerifyExamStatisticChartIsVisible(courseName, live);
            StudentsStatisticsPage.Instance.VerifyUniversitiesStatisticsChartIsVisible(courseName, live);
            StudentsStatisticsPage.Instance.VerifyCitiesStatisticsChartIsVisible(courseName, live);
            StudentsStatisticsPage.Instance.VerifyGenderStatisticsChartIsVisible(courseName, live);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(courseName, live);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(courseName, live);
        }

        public void AssertRadioButtonOnline(string courseName, string online)
        {
            StudentsStatisticsPage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsPage.Instance.VerifyOnlineRadioButtonIsSelected();
            StudentsStatisticsPage.Instance.VerifyExamStatisticChartIsVisible(courseName, online);
            StudentsStatisticsPage.Instance.VerifyUniversitiesStatisticsChartIsVisible(courseName, online);
            StudentsStatisticsPage.Instance.VerifyCitiesStatisticsChartIsVisible(courseName, online);
            StudentsStatisticsPage.Instance.VerifyGenderStatisticsChartIsVisible(courseName, online);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(courseName);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(courseName, online);
        }

        public void AssertAllCoursesStatistics(string allCoursesName)
        {
            StudentsStatisticsPage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsPage.Instance.VerifyLiveAndOnlineRadioButtonIsSelected();
            StudentsStatisticsPage.Instance.VerifyExamStatisticChartIsVisible(allCoursesName);
            StudentsStatisticsPage.Instance.VerifyUniversitiesStatisticsChartIsVisible(allCoursesName);
            StudentsStatisticsPage.Instance.VerifyCitiesStatisticsChartIsVisible(allCoursesName);
            StudentsStatisticsPage.Instance.VerifyGenderStatisticsChartIsVisible(allCoursesName);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(allCoursesName);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(allCoursesName);
        }

        public void AssertStudentsStatisticsForFixedCourse(string courseName)
        {
            StudentsStatisticsPage.Instance.VerifyTotalStudentsInCourseHeaderIsVisible();
            StudentsStatisticsPage.Instance.VerifyLiveAndOnlineRadioButtonIsSelected();
            StudentsStatisticsPage.Instance.VerifyExamStatisticChartIsVisible(courseName);
            StudentsStatisticsPage.Instance.VerifyUniversitiesStatisticsChartIsVisible(courseName);
            StudentsStatisticsPage.Instance.VerifyCitiesStatisticsChartIsVisible(courseName);
            StudentsStatisticsPage.Instance.VerifyGenderStatisticsChartIsVisible(courseName);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartIsVisible(courseName);
            StudentsStatisticsPage.Instance.VerifyYearOfBirthStatisticsChartBarsIsVisible(courseName);
        }

        public void AssertStudentsStatisticsPageIsOpen()
        {
            StudentsStatisticsPage.Instance.VerifyTitle();
            StudentsStatisticsPage.Instance.VerifyCourseFilterInputIsVisible();
            StudentsStatisticsPage.Instance.VerifyLiveAndOnlineRadioButtonIsVisible();
            StudentsStatisticsPage.Instance.VerifyLiveRadioButtonIsVisible();
            StudentsStatisticsPage.Instance.VerifyOnlineRadioButtonIsVisible();
            StudentsStatisticsPage.Instance.VerifyBackToAdminButtonIsVisible();
        }
    }
}