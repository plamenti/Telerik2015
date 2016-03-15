namespace TelerikAcademyLearningSystem.Core.Pages.StudentsInCoursesPage
{
    using System.IO;
    using System.Threading;
    using ArtOfTest.Common.UnitTesting;
    using ArtOfTest.WebAii.Core;
    using Constants;
    using Model;
    using Utilities;
    
    public static class StudentsInCoursesPageAsserter
    {
        public static void AssertPageTitle(this StudentsInCoursesPage page)
        {
            var message = string.Format("Page title should be: {0}", PageTitle.StudentsInCourses);
            Assert.AreEqual(PageTitle.StudentsInCourses, page.PageTitle, message);
        }

        public static void AssertGridTitle(this StudentsInCoursesPage page)
        {
            var message = string.Format("Page title should be: {0}", GridTitle.StudentsInCourses);
            Assert.AreEqual(GridTitle.StudentsInCourses, page.GridTitle, message);
        }

        public static void AssertStudentInCoursesPageIsOpen(this StudentsInCoursesPage page)
        {
            var expectedUrl = UrlLink.StudentsInCourses;
            var actualUrl = Manager.Current.ActiveBrowser.Url.ToString();
            var message = string.Format("Link {0} is not open.", expectedUrl);
            Assert.AreEqual(expectedUrl, actualUrl, message);
        }

        public static void CourseFilterInputIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.FilterByCourseName.IsVisible(), "Course Filter Input is not visible");
        }

        public static void StudentFilterInputIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.FilterbyUserName.IsVisible(), " Filter Input is not visible");
        }

        public static void LiveAndOnlineRadioButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.LiveAndOnlineRadioButton.IsVisible(), "Live And Online Radio Button is not visible");
        }

        public static void LiveRadioButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.LiveRadioButton.IsVisible(), "Live Radio Button is not visible");
        }

        public static void OnlineRadioButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.OnlineRadioButton.IsVisible(), "Online Radio Button is not visible");
        }

        public static void AssertEnrollStudentButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.EnrollStudentButton.IsVisible(), "Enroll student button is not visible");
        }

        public static void AssertAllowHelpedByEvaluationButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.AllowHelpedByEvaluationButton.IsVisible(), "Help evaluation button is not visible");
        }

        public static void AssertAllowPracticalExamButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.AllowPracticalExamButton.IsVisible(), "Allow Practical Exam button is not visible");
        }

        public static void AssertAllowTestExamButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.AllowTestExamButton.IsVisible(), "Allow Test Exam button is not visible");
        }

        public static void AssertAllowCourseInstanceEvaluationButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.AllowCourseInstanceEvaluationButton.IsVisible(), "Course evaluation button is not visible");
        }

        public static void AssertExportToExelButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.ExportToExcelButton.IsVisible(), "Export to Excel button is not visible");
        }

        public static void AssertBackToAdminButtonIsVisible(this StudentsInCoursesPage page)
        {
            Assert.IsTrue(page.BackToAdminButton.IsVisible(), "Back to admin button is not visible");
        }

        public static void AssertStudentInCourseIsEnrolled(this StudentsInCoursesPage page, Student student)
        {
            var newRowIndex = page.FindExistingStudentIncourseRowIndex(student);
            var newRow = page.GridPage.GridTable.Rows[newRowIndex];
            var currentRow = page.GridPage.GridTable.Rows[newRowIndex];

            var expectedName = student.UserName;
            var actualName = newRow.Cells[2].InnerText;
            Assert.AreEqual(actualName, expectedName);

            var expectedCourse = student.Course;
            var actualCourse = newRow.Cells[1].InnerText;
            Assert.AreEqual(actualCourse, expectedCourse);

            var expected = string.Empty;
            if (student.IsLiveParticipant)
            {
                expected = "Присъствено";
            }
            else
            {
                expected = "Онлайн";
            }

            var message = string.Format("{0}, не е записан {1}", student.UserName, expected);
            var actual = newRow.Cells[8].InnerText;
            Assert.AreEqual(actual, expected);
            var expectedAcomudation = student.Accommodation;
            var actualAcomudation = newRow.Cells[9].InnerText;
            Assert.AreEqual(actualAcomudation, expectedAcomudation);
            student.Id = int.Parse(currentRow.Cells[0].InnerText);
        }

        public static void AssertStudentInCourseDoesntExist(this StudentsInCoursesPage page, Student student)
        {
            var all = page.GridPage.GridTable;

            foreach (var row in all.BodyRows)
            {
                var currentRowIndex = page.GridPage.FindRow("Потребител", student.UserName);
                var currentRow = page.GridPage.GridTable.Rows[currentRowIndex];
                var message = string.Format("Student {0}, is already enrolled in course {1}", student.UserName, student.Course);
                Assert.IsFalse(currentRow.Cells[2].InnerText.Contains(student.Course), message);
            }
        }

        public static void AssertFileExist(string fileName)
        {
            var path = PathGenerator.AbsoluteRelativeCombine(Paths.ExportLocation + fileName);
            var message = string.Format("{0} {1}", fileName, Global.NullRefferenceMessage);
            Thread.Sleep(5000);
            Assert.IsTrue(File.Exists(path), message);
        }
    }
}