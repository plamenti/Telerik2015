namespace TelerikAcademyLearningSystem.Core.Pages.CoursesUnenrolledStudentsPage
{
    using System.IO;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikAcademyLearningSystem.Utilities;

    public static class CoursesUnenrolledStudentsPageAsserter
    {
        private const string CoursesUnenrolledStudentsPageTitle = "Отписани потребители от курсове - Телерик Академия - Студентска система";

        public static void VerifyTitle(this CoursesUnenrolledStudentsPage page)
        {
            Assert.AreEqual(CoursesUnenrolledStudentsPageTitle, page.GridTitle, string.Format("Page title should be: {0}", CoursesUnenrolledStudentsPageTitle));
        }

        public static void VerifyExportToExcelButtonIsVisible(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.ExportToExcelButton.IsVisible(), "ExportToExcel Button is not visible");
        }

        public static void VerifyLiveAndOnlineRadioButtonIsVisible(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.LiveAndOnlineRadioButton.IsVisible(), "Live And Online Radio Button is not visible");
        }

        public static void VerifyLiveRadioButtonIsVisible(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.LiveRadioButton.IsVisible(), "Live Radio Button is not visible");
        }

        public static void VerifyOnlineRadioButtonIsVisible(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.OnlineRadioButton.IsVisible(), "Online Radio Button is not visible");
        }

        public static void VerifyUnenrolledStudentsGridIsVisible(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.UnenrolledStudentsGrid.IsVisible(), "UnenrolledStudents Grid is not visible");
        }

        public static void VerifyBackToAdminButtonIsVisible(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.BackToAdminButton.IsVisible(), "Back to admin button is not visible");
        }

        public static void VerifyExportToExcelDownloadsExcelFile(this CoursesUnenrolledStudentsPage page, string fileName)
        {
            Assert.IsTrue(page.FileExists, fileName + " does not exist");
        }

        public static void VerifyValidUsernameToFilterExposeOnlyOneUser(this CoursesUnenrolledStudentsPage page, string validUsername)
        {
            Assert.IsTrue(page.ConsistName, "Every one row should consist the valid username");
        }

        public static void VerifyInvalidUsernameToFilter(this CoursesUnenrolledStudentsPage page, string assertMessage)
        {
            Assert.IsTrue(page.ContainsWarningMessage, assertMessage);
        }

        public static void VerifyInvalidUsernameToFilterNoExposesUser(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.CountOfRows == 0, "There should not be rows with students");
        }

        public static void VerifySelectAllCourses(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.AreDifferentCourses, "There should be different courses");
        }

        public static void VerifySelectLiveAndOnline(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.AreDifferentRowsWithStudents, "There should be live and online");
        }

        public static void VerifySelectLive(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.AreDifferentRowsWithStudents, "There should be only live");
        }

        public static void VerifySelectOnline(this CoursesUnenrolledStudentsPage page)
        {
            Assert.IsTrue(page.AreDifferentRowsWithStudents, "There should be only online");
        }

        public static void VerifySelectFixedCourse(this CoursesUnenrolledStudentsPage page, string courseName)
        {
            Assert.IsTrue(page.ConsistUserName, "Every one row should consist the course name");
        }
    }
}