namespace TelerikAcademyLearningSystem.Core.Facades
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.Win32.Dialogs;
    using TelerikAcademyLearningSystem.Core.Constants.Homework;
    using TelerikAcademyLearningSystem.Core.Model;
    using TelerikAcademyLearningSystem.Core.Pages.HomeworkPage;
    using TelerikAcademyLearningSystem.Core.Pages.HomeworkPage.AddHomeworkPage;

    public class HomeworkFacade
    {
        public void OpenHomeworkPage()
        {
            HomeworkPage.Instance.Navigate();
        }

        public void OpenAddHomeworkPage()
        {
            AddHomeworkPage.Instance.Navigate();
        }

        public void AssertHomeworkPageIsOpen()
        {
            HomeworkPageAsserter.AssertTitle(HomeworkPage.Instance);
            HomeworkPageAsserter.ExportToExcellBtnIsVisible(HomeworkPage.Instance);
            HomeworkPageAsserter.ExportToPdfBtnIsVisible(HomeworkPage.Instance);
            HomeworkPageAsserter.AddHomeworkBtnIsVisible(HomeworkPage.Instance);
            HomeworkPageAsserter.BackToAdminBtnIsVisible(HomeworkPage.Instance);
        }

        public void AssertAddHomeworkPageIsOpen()
        {
            AddHomeworkPageAsserter.AssertTitle(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.HeaderIsPresent(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.CourseNameInputIsVisible(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.CourseNameLabelIsPresent(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.LectureNameInputIsVisible(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.LectureNameLabelIsPresent(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.UserNameInputIsVisible(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.UserNameLabelIsPresent(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.MarkInputIsVisible(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.MarkLabelIsPresent(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.EvaluationCheckboxIsVisible(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.EvaluationCheckboxLabelIsPresent(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.HomeworkFileButtonIsVisible(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.HomeworkFileLabelIsPresent(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.SubmitButtonIsVisible(AddHomeworkPage.Instance);
            AddHomeworkPageAsserter.BackToAllHomeworksButtonIsVisible(AddHomeworkPage.Instance);
        }

        public void FilterHomeworkGridByCourseLectureUserAndEvaluation(Homework homework)
        {
            HomeworkPage.Instance.Navigate();
            HomeworkPage.Instance.SelectCourse(homework.CourseName);
            HomeworkPage.Instance.SelectLecture(homework.LectureName);
            HomeworkPage.Instance.SelectUserName(homework.UserName);
            HomeworkPage.Instance.SelectForEvaluation(homework.ForEvaluation);
        }

        public void ValidateAllErrorMessages()
        {
            AddHomeworkPage.Instance.CourseValidationMessageIsVisible(AddHomeworkConstants.CourseNameErrorMessageBlank);
            AddHomeworkPage.Instance.LectureValidationMessageIsVisible(AddHomeworkConstants.LectureNameErrorMessageBlank);
            AddHomeworkPage.Instance.UsernameValidationMessageIsVisibleWithRequredText(AddHomeworkConstants.UserNameErrorMessageBlank);
            AddHomeworkPage.Instance.HomeworkFileValidationMessageIsVisible(AddHomeworkConstants.HomeworkFileErrorMessageBlank);
        }

        public void CreateHomework(Homework homework, string fileName)
        {
            HomeworkPage.Instance.Navigate();
            if (HomeworkPage.Instance.ContainsHomework(homework))
            {
                HomeworkPage.Instance.DeleteHomework(homework);
            }

            AddHomeworkPage.Instance.Navigate();
            AddHomeworkPage.Instance.FillForm(homework, fileName);
        }

        public void CreateHomeworkWithNoData()
        {
            AddHomeworkPage.Instance.Navigate();
            AddHomeworkPage.Instance.FillFormWithNoData();
        }

        public void ExportFile(string fileName)
        {
            if (fileName.Contains(".xls"))
            {
                HomeworkPage.Instance.ExportToExcelButtonDownloadsExcelFile(fileName);
            }
            else if (fileName.Contains(".pdf"))
            {
                HomeworkPage.Instance.ExportToPdfDownloadsPdfFile(fileName);
            }
            else if (fileName.Contains(".zip"))
            {
                HomeworkPage.Instance.DownloadAllHomeworksButtonDownloadsArchiveFile(fileName);
            }
        }

        public void BackToAllHomeworks()
        {
            AddHomeworkPage.Instance.BackToAllHomeworksButton.ScrollToVisible();
            AddHomeworkPage.Instance.BackToAllHomeworksButton.MouseClick();
            AddHomeworkPage.Instance.Browser.RefreshDomTree();
        }

        public void DownloadUserHomework(Homework homework, string fileName)
        {
            HomeworkPage.Instance.Navigate();
            HomeworkPage.Instance.DownloadHomework(homework, fileName);
        }

        public void EditHomeworkMark(Homework homework, string newMark)
        {
            HomeworkPage.Instance.Navigate();
            HomeworkPage.Instance.FillFormWithValueInRange(homework, newMark);
            HomeworkPage.Instance.UpdateButton.ScrollToVisible();
            HomeworkPage.Instance.UpdateButton.MouseClick(MouseClickType.LeftClick, 0, 0, ArtOfTest.Common.OffsetReference.AbsoluteCenter);
        }

        public void SortHomeworkGrid()
        {
            HomeworkPage.Instance.Navigate();
            HomeworkPage.Instance.GridPage.SortGridByStringAndNumber();
        }
    }
}
