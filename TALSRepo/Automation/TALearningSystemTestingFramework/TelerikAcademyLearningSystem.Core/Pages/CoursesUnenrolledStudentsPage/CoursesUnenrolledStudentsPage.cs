namespace TelerikAcademyLearningSystem.Core.Pages.CoursesUnenrolledStudentsPage
{
    using System.IO;
    using System.Threading;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using TelerikAcademyLearningSystem.Core.Base;
    using TelerikAcademyLearningSystem.Core.Constants;
    using TelerikAcademyLearningSystem.Utilities;

    public partial class CoursesUnenrolledStudentsPage : BasePage<CoursesUnenrolledStudentsPage>
    {
        private const string FormOfEducationLive = FormOfEducation.FormOfEducationLive;
        private const string FormOfEducationOnline = FormOfEducation.FormOfEducationOnline;
        private bool fileExists;
        private bool consistName;
        private bool containsWarningMessage;
        private int countOfRows;
        private bool areDifferentCourses;
        private bool consistUsername;
        private bool areDifferentRowsWithStudents;

        public bool AreDifferentRowsWithStudents
        {
            get
            {
                return this.areDifferentRowsWithStudents;
            }

            private set
            {
                this.areDifferentRowsWithStudents = value;
            }
        }

        public bool ConsistUserName
        {
            get
            {
                return this.consistUsername;
            }

            private set
            {
                this.consistUsername = value;
            }
        }

        public bool AreDifferentCourses
        {
            get
            {
                return this.areDifferentCourses;
            }

            private set
            {
                this.areDifferentCourses = value;
            }
        }

        public int CountOfRows
        {
            get
            {
                return this.countOfRows;
            }

            private set
            {
                this.countOfRows = value;
            }
        }

        public bool ContainsWarningMessage
        {
            get
            {
                return this.containsWarningMessage;
            }

            private set
            {
                this.containsWarningMessage = value;
            }
        }

        public bool ConsistName
        {
            get
            {
                return this.consistName;
            }

            private set
            {
                this.consistName = value;
            }
        }

        public bool FileExists
        {
            get
            {
                return this.fileExists;
            }

            private set
            {
                this.fileExists = value;
            }
        }

        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.CoursesUnenrolledStudentsPage);
        }

        public void SelectOnline()
        {
            this.SelectCourseByFormOfEducation(FormOfEducationOnline);
        }

        public void SelectLive()
        {
            this.SelectCourseByFormOfEducation(FormOfEducationLive);
        }

        public void SelectLiveAndOnline()
        {
            this.SelectCourseByName("Всички курсове");

            this.AreDifferentRowsWithStudents = false;

            int rowsCount = this.UnenrolledStudentsGrid.BodyRows.Count;
            for (int i = 1; i < rowsCount; i++)
            {
                string firstRow = this.UnenrolledStudentsGrid.BodyRows[i - 1].Cells[9].TextContent;
                string secondRow = this.UnenrolledStudentsGrid.BodyRows[i].Cells[9].TextContent;
                if (firstRow != secondRow)
                {
                    this.AreDifferentRowsWithStudents = true;
                    break;
                }
            }
        }

        public void SelectFixedCourse(string courseName)
        {
            this.SelectCourseByName(courseName);

            this.ConsistUserName = true;

            foreach (var row in this.UnenrolledStudentsGrid.BodyRows)
            {
                if (!row.InnerText.Contains(courseName))
                {
                    this.ConsistUserName = false;
                }
            }
        }

        public void SelectAllCourses()
        {
            this.SelectCourseByName("Всички курсове");
            this.AreDifferentCourses = false;

            int rowsCount = this.UnenrolledStudentsGrid.BodyRows.Count;
            for (int i = 1; i < rowsCount; i++)
            {
                string firstRow = this.UnenrolledStudentsGrid.BodyRows[i - 1].Cells[1].TextContent;
                string secondRow = this.UnenrolledStudentsGrid.BodyRows[i].Cells[1].TextContent;
                if (firstRow != secondRow)
                {
                    this.AreDifferentCourses = true;
                    break;
                }
            }
        }

        public void NonexistentUsernameToFilter(string invalidUsername)
        {
            this.InitilizeUsernameToFilter(invalidUsername);
            this.CountOfRows = this.UnenrolledStudentsGrid.BodyRows.Count;
        }

        public void ExportToExcelDownloadsExcelFile(string fileName)
        {
            string saveLocation = GetSaveLocation() + fileName;
            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            DownloadDialogsHandler dialog = new DownloadDialogsHandler(this.Browser, DialogButton.SAVE, saveLocation, this.Browser.Desktop);
            this.Browser.Manager.DialogMonitor.Start();
            this.ExportToExcelButton.ScrollToVisible();
            this.ExportToExcelButton.Click();
            Thread.Sleep(20000);
            dialog.WaitUntilHandled(30000);
            this.FileExists = File.Exists(saveLocation);
        }

        public void ValidUsernameToFilter(string validUsername)
        {
            this.InitilizeUsernameToFilter(validUsername);
            this.ConsistName = true;

            foreach (var row in this.UnenrolledStudentsGrid.BodyRows)
            {
                if (!row.InnerText.Contains(validUsername))
                {
                    this.ConsistName = false;
                }
            }
        }

        public void CheckForInvalidUsername(string invalidUsername, string warningMessage)
        {
            this.InitilizeUsernameToFilter(invalidUsername);
            this.ContainsWarningMessage = this.Body.InnerText.Contains(warningMessage);
        }

        private static string GetSaveLocation()
        {
            return PathGenerator.GeneratePathToDownloadedFilesFolder();
        }

        private void SelectCourseByName(string courseName)
        {
            this.SelectCourseField.ScrollToVisible();
            this.SelectCourseField.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(courseName);
            this.LiveAndOnlineRadioButton.MouseClick();
            this.Browser.WaitForAjax(5000);
            this.Browser.RefreshDomTree();
        }

        private void SelectCourseByFormOfEducation(string formOfEducation)
        {
            this.SelectCourseByName("Всички курсове");
            this.LiveRadioButton.MouseClick();
            this.Browser.WaitForAjax(5000);
            this.Browser.RefreshDomTree();
            int rowsCount = this.UnenrolledStudentsGrid.BodyRows.Count;
            this.AreDifferentRowsWithStudents = true;
            for (int i = 1; i < rowsCount; i++)
            {
                string firstRow = this.UnenrolledStudentsGrid.BodyRows[i - 1].Cells[9].TextContent;
                string secondRow = this.UnenrolledStudentsGrid.BodyRows[i].Cells[9].TextContent;
                if (firstRow != secondRow && firstRow != formOfEducation)
                {
                    this.AreDifferentRowsWithStudents = false;
                    break;
                }
            }
        }

        private void InitilizeUsernameToFilter(string validUsername)
        {
            this.UsernameToFilter.Wait.ForVisible();
            this.UsernameToFilter.ScrollToVisible();
            this.UsernameToFilter.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(validUsername);
            this.LiveAndOnlineRadioButton.MouseClick();
            this.Browser.WaitForAjax(3000);
            this.Browser.RefreshDomTree();
        }
    }
}