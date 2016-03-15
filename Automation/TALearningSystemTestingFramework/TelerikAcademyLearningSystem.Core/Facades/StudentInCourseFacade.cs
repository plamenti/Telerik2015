namespace TelerikAcademyLearningSystem.Core.Facades
{
    using System.Threading;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using Model;
    using Pages.CoursesUnenrolledStudentsPage;
    using Pages.StudentsInCoursesPage;
    using Pages.StudentsInCoursesPage.StudentsInCoursesFormPage;

    public class StudentInCourseFacade
    {
        public void DownloadExcelFile(string fileName)
        {
            this.OpenPage();
            StudentsInCoursesPage.Instance.DownloadExcelFile(fileName);
        }

        public void GoBackToAdminPage()
        {
            this.OpenPage();
            StudentsInCoursesPage.Instance.BackToAdminButton.ScrollToVisible();
            StudentsInCoursesPage.Instance.BackToAdminButton.Click();
        }

        public void Add(Student student)
        {
            this.OpenPage();
            if (StudentsInCoursesPage.Instance.FindExistingStudentIncourseRowIndex(student) != int.MaxValue)
            {
                this.DeleteStudentInCourse(student);
            }

            this.UpdateForm(student);
        }

        public void AddEmptyForm()
        {
            this.OpenPage();
            StudentsInCoursesPage.Instance.OpenStudentsInCourseForm();
            StudentsInCoursesFormPage.Instance.UpdateButton.Click();
        }

        public void AddTwice(Student student)
        {
            this.OpenPage();
            if (StudentsInCoursesPage.Instance.FindExistingStudentIncourseRowIndex(student) != int.MaxValue)
            {
                this.DeleteStudentInCourse(student);
            }

            this.UpdateForm(student);
            this.UpdateForm(student);
        }

        public void OpenPage()
        {
            StudentsInCoursesPage.Instance.Navigate();
            Thread.Sleep(1000);
        }

        public void UpdateForm(Student student)
        {
            StudentsInCoursesPage.Instance.OpenStudentsInCourseForm();
            StudentsInCoursesFormPage.Instance.FillData(student);
            StudentsInCoursesFormPage.Instance.UpdateButton.MouseClick();
        }

        public void DeleteStudentInCourse(Student student)
        {
            StudentsInCoursesPage.Instance.Browser.Manager.DialogMonitor.AddDialog(new ConfirmDialog(StudentsInCoursesPage.Instance.Browser, DialogButton.OK));
            StudentsInCoursesPage.Instance.Browser.Manager.DialogMonitor.Start();
            var rowForDeleteIndex = StudentsInCoursesPage.Instance.FindExistingStudentIncourseRowIndex(student);
            var buttonToClick = StudentsInCoursesPage.Instance.GridPage.DeleteButton[rowForDeleteIndex];
            buttonToClick.ScrollToVisible();
            buttonToClick.Click();
        }

        public Student GetUnenrolledStudent()
        {
            CoursesUnenrolledStudentsPage helpPage = new CoursesUnenrolledStudentsPage();
            helpPage.Navigate();
            helpPage.VerifyTitle();
            Thread.Sleep(1000);
            helpPage.Browser.RefreshDomTree();

            string name = helpPage.GridPage.GridTable.Rows[0].Cells[2].InnerText;
            string course = helpPage.GridPage.GridTable.Rows[0].Cells[1].InnerText;
            Student student = new Student(name, course);
            return student;
        }

        public void AssertPageIsOpen()
        {
            Thread.Sleep(1000);
            StudentsInCoursesPage.Instance.Browser.RefreshDomTree();
            StudentsInCoursesPageAsserter.AssertPageTitle(StudentsInCoursesPage.Instance);
            StudentsInCoursesPageAsserter.AssertGridTitle(StudentsInCoursesPage.Instance);
            StudentsInCoursesPageAsserter.AssertAllowCourseInstanceEvaluationButtonIsVisible(StudentsInCoursesPage.Instance);
            StudentsInCoursesPageAsserter.AssertAllowHelpedByEvaluationButtonIsVisible(StudentsInCoursesPage.Instance);
            StudentsInCoursesPageAsserter.AssertAllowPracticalExamButtonIsVisible(StudentsInCoursesPage.Instance);
            StudentsInCoursesPageAsserter.AssertAllowTestExamButtonIsVisible(StudentsInCoursesPage.Instance);
            StudentsInCoursesPageAsserter.AssertBackToAdminButtonIsVisible(StudentsInCoursesPage.Instance);
            StudentsInCoursesPageAsserter.AssertEnrollStudentButtonIsVisible(StudentsInCoursesPage.Instance);
            StudentsInCoursesPageAsserter.AssertExportToExelButtonIsVisible(StudentsInCoursesPage.Instance);
        }

        public void AssertNewUserInCourseIsCreated(Student user)
        {
            Thread.Sleep(2000);
            StudentsInCoursesPageAsserter.AssertStudentInCourseIsEnrolled(StudentsInCoursesPage.Instance, user);
        }

        public void AssertUserNameRequiredFieldValidationMessages()
        {
            Thread.Sleep(1000);
            StudentsInCoursesFormPage.Instance.Browser.RefreshDomTree();
            StudentsInCoursesFormPageAsserter.AssertRequiredUsernameValidationMessage(StudentsInCoursesFormPage.Instance);
        }

        public void AssertCourseInstanceRequiredFieldValidationMessages()
        {
            Thread.Sleep(1000);
            StudentsInCoursesFormPage.Instance.Browser.RefreshDomTree();
            StudentsInCoursesFormPageAsserter.AssertRequiredCourseInstanceValidationMessage(StudentsInCoursesFormPage.Instance);
        }

        public void AssertEnrolledStudentValidationMessages()
        {
            Thread.Sleep(1000);
            StudentsInCoursesFormPage.Instance.Browser.RefreshDomTree();
            StudentsInCoursesFormPageAsserter.AssertEnrolledUserValidationMessage(StudentsInCoursesFormPage.Instance);
        }

        public void AssertUnEnrolledStudentValidationMessages()
        {
            Thread.Sleep(1000);
            StudentsInCoursesFormPage.Instance.Browser.RefreshDomTree();
            StudentsInCoursesFormPageAsserter.AssertUnenrolledUserValidationMessage(StudentsInCoursesFormPage.Instance);
        }

        public void AssertNotExistingStudentValidationMessages()
        {
            Thread.Sleep(1000);
            StudentsInCoursesFormPage.Instance.Browser.RefreshDomTree();
            StudentsInCoursesFormPageAsserter.AssertNotExistingUsernameValidationMessage(StudentsInCoursesFormPage.Instance);
        }

        public void AssertFileExist(string fileName)
        {
            StudentsInCoursesPageAsserter.AssertFileExist(fileName);
        }
    }
}