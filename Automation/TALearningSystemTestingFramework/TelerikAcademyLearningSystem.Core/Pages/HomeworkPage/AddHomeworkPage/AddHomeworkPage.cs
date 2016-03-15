namespace TelerikAcademyLearningSystem.Core.Pages.HomeworkPage.AddHomeworkPage
{
    using System.Threading;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using TelerikAcademyLearningSystem.Core.Base;
    using TelerikAcademyLearningSystem.Core.Model;
    using TelerikAcademyLearningSystem.Utilities;

    public partial class AddHomeworkPage : BasePage<AddHomeworkPage>
    {
        public override void Navigate()
        {
            HomeworkPage.Instance.OpenAddHomeworkForm();
        }

        public void FillForm(Homework homework, string fileName)
        {
            this.CourseNameInput.ScrollToVisible();
            this.CourseNameInput.MouseClick();
            this.CleanInput(this.CourseNameInput.Text);
            this.Browser.Desktop.KeyBoard.TypeText(homework.CourseName);
            this.Header.MouseClick();

            if (homework.LectureName != string.Empty)
            {
                this.LectureNameInput.ScrollToVisible();
                this.LectureNameInput.MouseClick();
                var lectureElement = this.LocateLiByContent(homework.LectureName);
                lectureElement.ScrollToVisible();
                lectureElement.MouseClick();
                this.Header.MouseClick();
            }

            this.UserNameInput.ScrollToVisible();
            this.UserNameInput.MouseClick();
            this.CleanInput(this.UserNameInput.Text);
            this.Browser.Desktop.KeyBoard.TypeText(homework.UserName);
            this.Header.MouseClick();

            this.MarkInput.ScrollToVisible();
            this.MarkInput.MouseClick();
            this.Browser.Desktop.KeyBoard.TypeText(homework.Mark);

            if (!homework.ForEvaluation)
            {
                this.EvaluationCheckbox.ScrollToVisible();
                this.EvaluationCheckbox.MouseClick();
            }

            string uploadLocation = GetUploadLocation() + fileName;
            ////DownloadDialogsHandler dialog = new DownloadDialogsHandler(this.Browser, DialogButton.OPEN, uploadLocation, this.Browser.Desktop);
            ////this.Browser.Manager.DialogMonitor.Start();
            ////this.UploadFileInput.ScrollToVisible();
            ////this.UploadFileInput.Click();
            ////Thread.Sleep(20000);
            ////dialog.WaitUntilHandled(30000);
            this.UploadFileInput.Upload(uploadLocation, 50000);

            this.SubmitButton.ScrollToVisible();
            this.SubmitButton.MouseClick();
        }

        public void FillFormWithNoData()
        {
            this.Browser.ScrollBy(0, 500);
            this.SubmitButton.ScrollToVisible();
            this.SubmitButton.MouseClick();
        }

        private static string GetUploadLocation()
        {
            return PathGenerator.GeneratePathToUploadedFilesFolder();
        }
    }
}
