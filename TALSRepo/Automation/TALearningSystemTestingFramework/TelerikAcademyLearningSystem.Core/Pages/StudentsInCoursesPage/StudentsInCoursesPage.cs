namespace TelerikAcademyLearningSystem.Core.Pages.StudentsInCoursesPage
{
    using System.IO;
    using System.Threading;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using Base;
    using Constants;
    using Model;
    using Utilities;

    public partial class StudentsInCoursesPage : BasePage<StudentsInCoursesPage>
    {
        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.StudentsInCourses);
        }

        public void OpenStudentsInCourseForm()
        {
            this.Navigate();
            this.EnrollStudentButton.Wait.ForExists(1000);
            this.EnrollStudentButton.Click();
            this.PopUp.Wait.ForExists(1000);
            this.Browser.RefreshDomTree();
        }

        public void DownloadExcelFile(string fileName)
        {
            string saveLocation = PathGenerator.AbsoluteRelativeCombine(Paths.ExportLocation + fileName);
            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            Thread.Sleep(5000);
            DownloadDialogsHandler dialog = new DownloadDialogsHandler(
                this.Browser,
                DialogButton.SAVE,
                saveLocation,
                this.Browser.Desktop);
            this.Browser.Manager.DialogMonitor.Start();
            this.ExportToExcelButton.ScrollToVisible();
            this.ExportToExcelButton.Click();
            Thread.Sleep(20000);
        }

        public int FindExistingStudentIncourseRowIndex(Student student)
        {
            int currentIndex = int.MaxValue;
            var currentRowIndex = this.GridPage.FindRow("Потребител", student.UserName);
            if (currentRowIndex != int.MaxValue)
            {
                var currentRow = this.GridPage.GridTable.Rows[currentRowIndex - 1];
                string currentCourse = currentRow.Cells[1].InnerText;

                if (currentCourse == student.Course)
                {
                    currentIndex = currentRowIndex - 1;
                }
            }

            return currentIndex;
        }
    }
}