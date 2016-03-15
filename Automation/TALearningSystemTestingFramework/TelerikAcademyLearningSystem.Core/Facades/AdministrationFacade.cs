namespace TelerikAcademyLearningSystem.Core.Facades
{
    using System.Threading;
    using Pages.AdministrationPage;

    public class AdministrationFacade
    {
        public void OpenGroupsPageButton()
        {
            AdministrationPage.Instance.Navigate();
            AdministrationPage.Instance.Groups.ScrollToVisible();
            AdministrationPage.Instance.Groups.Click();
        }

        public void OpenStudentsStatisticsButton()
        {
            AdministrationPage.Instance.Navigate();
            AdministrationPage.Instance.StudentsStatistics.ScrollToVisible();
            AdministrationPage.Instance.StudentsStatistics.Click();
        }

        public void OpenCoursesUnenrolledStudentsPageButton()
        {
            AdministrationPage.Instance.Navigate();
            AdministrationPage.Instance.CoursesUnenrolledStudents.ScrollToVisible();
            AdministrationPage.Instance.CoursesUnenrolledStudents.Click();
        }

        public void VerifyPageIsOpen()
        {
            AdministrationPageAsserter.AssertPageTitle(AdministrationPage.Instance);
            AdministrationPageAsserter.AssertHeader(AdministrationPage.Instance);
        }
    }
}