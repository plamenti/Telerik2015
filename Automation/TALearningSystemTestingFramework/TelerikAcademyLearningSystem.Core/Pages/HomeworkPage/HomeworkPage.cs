namespace TelerikAcademyLearningSystem.Core.Pages.HomeworkPage
{
    using System.IO;
    using ArtOfTest.Common;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using Base;
    using Constants;
    using Model;
    using Utilities;

    public partial class HomeworkPage : BasePage<HomeworkPage>
    {
        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.Homework);
        }

        public void SelectCourse(string courseName)
        {
            this.CourseNameToFilter.Wait.ForExists(1000);
            this.CourseNameToFilter.ScrollToVisible();
            this.CourseNameToFilter.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            this.Browser.Desktop.KeyBoard.TypeText(courseName);
            this.GridPage.Footer.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            this.Browser.RefreshDomTree();
        }

        public void SelectLecture(string lectureName)
        {
            this.LectureNameToFilter.Wait.ForExists(1000);
            this.LectureNameToFilter.ScrollToVisible();
            this.LectureNameToFilter.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            this.Browser.Desktop.KeyBoard.TypeText(lectureName);
            this.GridPage.Footer.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            this.Browser.RefreshDomTree();
        }

        public void SelectUserName(string userName)
        {
            this.UserNameToFilter.Wait.ForExists(1000);
            this.UserNameToFilter.ScrollToVisible();
            this.UserNameToFilter.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            this.Browser.Desktop.KeyBoard.TypeText(userName);
            this.GridPage.Footer.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            this.Browser.RefreshDomTree();
        }

        public void SelectForEvaluation(bool forEvaluation)
        {
            if (!forEvaluation)
            {
                this.ForEvaluationCheckbox.Wait.ForExists(1000);
                this.ForEvaluationCheckbox.ScrollToVisible();
                this.ForEvaluationCheckbox.MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            }
        }

        public bool ContainsHomework(Homework homework)
        {
            int indexOfHomeworkInTable = this.FindHomeworkIndexInTable(homework);
            if (indexOfHomeworkInTable > -1)
            {
                return true;
            }

            return false;
        }

        public void DeleteHomework(Homework homework)
        {
            this.Browser.Manager.DialogMonitor.AddDialog(new ConfirmDialog(this.Browser.Manager.ActiveBrowser, DialogButton.OK));
            this.Browser.Manager.DialogMonitor.Start();
            int indexOfHomeworkInTable = this.FindHomeworkIndexInTable(homework);
            this.DeleteRowButton(indexOfHomeworkInTable).Click();
        }

        public void OpenAddHomeworkForm()
        {
            this.Navigate();
            this.AddHomeworkButton.Wait.ForExists(1000);
            this.AddHomeworkButton.ScrollToVisible();
            this.AddHomeworkButton.MouseClick();
            Browser.WaitForUrl(UrlLink.AddHomework, false, 10000);
            this.Browser.RefreshDomTree();
        }

        public void ExportToExcelButtonDownloadsExcelFile(string fileName)
        {
            this.Navigate();
            string saveLocation = PathGenerator.GeneratePathToDownloadedFilesFolder() + fileName;

            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            this.ExportToExcellButton.Wait.ForVisible();
            this.ExportToExcellButton.Download(false, DownloadOption.Save, saveLocation, 50000);
        }

        public void ExportToPdfDownloadsPdfFile(string fileName)
        {
            this.Navigate();
            string saveLocation = PathGenerator.GeneratePathToDownloadedFilesFolder() + fileName;

            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            this.ExportToPdfButton.Wait.ForVisible();
            this.ExportToPdfButton.Download(false, DownloadOption.Save, saveLocation, 50000);
        }

        public void DownloadHomework(Homework homework, string fileName)
        {
            string saveLocation = PathGenerator.GeneratePathToDownloadedFilesFolder() + fileName;
            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            int index = this.FindHomeworkIndexInTable(homework);

            ////DownloadDialogsHandler dialog = new DownloadDialogsHandler(this.Browser, DialogButton.SAVE, saveLocation, this.Browser.Desktop);
            ////this.Browser.Manager.DialogMonitor.Start();
            ////this.DownloadUserHomeworkButton(index).ScrollToVisible();
            ////this.DownloadUserHomeworkButton(index).Click();
            ////Thread.Sleep(20000);
            ////dialog.WaitUntilHandled(30000);
            this.DownloadUserHomeworkButton(index).Download(false, DownloadOption.Save, saveLocation, 50000);
        }

        public void DownloadAllHomeworksButtonDownloadsArchiveFile(string fileName)
        {
            HomeworkPage.Instance.Navigate();

            string saveLocation = PathGenerator.GeneratePathToDownloadedFilesFolder() + fileName;
            
            if (File.Exists(saveLocation))
            {
                File.Delete(saveLocation);
            }

            HomeworkPage.Instance.DownloadAllHomeworksButton.Wait.ForVisible();
            HomeworkPage.Instance.DownloadAllHomeworksButton.Download(false, DownloadOption.Save, fileName, 15000);
        }

        public void FillFormWithValueInRange(Homework homework, string newMark)
        {
            int index = this.FindHomeworkIndexInTable(homework);
            this.EditHomeworkButton(index).MouseClick(MouseClickType.LeftClick, 0, 0, OffsetReference.AbsoluteCenter);
            this.PopUp.Wait.ForExists(5000);
            this.Browser.RefreshDomTree();
            this.MarkInput.Wait.ForExists(5000);
            this.MarkInput.MouseClick();
            this.CleanInput(this.MarkInput.Text);
            this.Browser.Desktop.KeyBoard.TypeText(newMark);
        }

        private int FindHomeworkIndexInTable(Homework homework)
        {
            this.Browser.RefreshDomTree();
            int homeworkIndex = -1;

            this.GridPage.GridTable.ScrollToVisible();
            string forEvaluationBGText = "Не";
            var bodyRowsCount = this.GridPage.GridTable.BodyRows.Count;

            if (homework.ForEvaluation)
            {
                forEvaluationBGText = "Да";
            }

            for (int i = 0; i < bodyRowsCount; i++)
            {
                if (this.TableDataCell(i)[1].InnerText == homework.CourseName &&
                    this.TableDataCell(i)[2].InnerText == homework.LectureName &&
                    this.TableDataCell(i)[3].InnerText == homework.UserName &&
                    this.TableDataCell(i)[11].InnerText == forEvaluationBGText)
                {
                    homeworkIndex = i;
                    break;
                }
            }

            return homeworkIndex;
        }
    }
}