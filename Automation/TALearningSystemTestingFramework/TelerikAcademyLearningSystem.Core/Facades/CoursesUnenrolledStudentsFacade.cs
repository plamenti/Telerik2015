namespace TelerikAcademyLearningSystem.Core.Facades
{
    using Pages.CoursesUnenrolledStudentsPage;

    public class CoursesUnenrolledStudentsFacade
    {
        public void OpenCoursesUnenrolledStudentsPage()
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
        }

        public void BackToAdministration()
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.BackToAdminButton.Click();
        }

        public void ExportToExcelDownloadsExcelFile(string fileName)
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.ExportToExcelDownloadsExcelFile(fileName);
        }

        public void ValidUsernameToFilter(string validUsername)
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.ValidUsernameToFilter(validUsername);
        }

        public void InvalidUsernameToFilter(string invalidUsername, string warningMessage)
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.CheckForInvalidUsername(invalidUsername, warningMessage);
        }

        public void AssertInvalidUsername(string invalidUsername)
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.NonexistentUsernameToFilter(invalidUsername);
        }

        public void StudentsFromAllCourses()
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.SelectAllCourses();
        }

        public void AssertStudentsFromFixedCourse(string courseName)
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.SelectFixedCourse(courseName);
        }

        public void AssertRadioButtonAll()
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.SelectLiveAndOnline();
        }

        public void AssertRadioButtonLive()
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.SelectLive();
        }

        public void AssertRadioButtonOnline()
        {
            CoursesUnenrolledStudentsPage.Instance.Navigate();
            CoursesUnenrolledStudentsPage.Instance.SelectOnline();
        }

        public void AssertCoursesUnenrolledStudentsPageIsOpen()
        {
            CoursesUnenrolledStudentsPage.Instance.VerifyTitle();
            CoursesUnenrolledStudentsPage.Instance.VerifyExportToExcelButtonIsVisible();
            CoursesUnenrolledStudentsPage.Instance.VerifyLiveAndOnlineRadioButtonIsVisible();
            CoursesUnenrolledStudentsPage.Instance.VerifyLiveRadioButtonIsVisible();
            CoursesUnenrolledStudentsPage.Instance.VerifyOnlineRadioButtonIsVisible();
            CoursesUnenrolledStudentsPage.Instance.VerifyUnenrolledStudentsGridIsVisible();
        }

        public void AssertExportToExcelDownloadsExcelFile(string fileName)
        {
            CoursesUnenrolledStudentsPage.Instance.VerifyExportToExcelDownloadsExcelFile(fileName);
        }

        public void AssertValidUsernameToFilterExposeOnlyOneUser(string validUsername)
        {
            CoursesUnenrolledStudentsPage.Instance.VerifyValidUsernameToFilterExposeOnlyOneUser(validUsername);
        }

        public void AssertInvalidUsernameToFilter(string assertMessage)
        {
            CoursesUnenrolledStudentsPage.Instance.VerifyInvalidUsernameToFilter(assertMessage);
        }

        public void AssertInvalidUsernameToFilterNoExposesUser()
        {
            CoursesUnenrolledStudentsPage.Instance.VerifyInvalidUsernameToFilterNoExposesUser();
        }

        public void AssertSelectAllCourses()
        {
            CoursesUnenrolledStudentsPage.Instance.VerifySelectAllCourses();
        }

        public void AssertSelectFixedCourse(string courseName)
        {
            CoursesUnenrolledStudentsPage.Instance.VerifySelectFixedCourse(courseName);
        }

        public void AssertSelectLiveAndOnline()
        {
            CoursesUnenrolledStudentsPage.Instance.VerifySelectLiveAndOnline();
        }

        public void AssertSelectLive()
        {
            CoursesUnenrolledStudentsPage.Instance.VerifySelectLive();
        }

        public void AssertSelectOnline()
        {
            CoursesUnenrolledStudentsPage.Instance.VerifySelectOnline();
        }
    }
}