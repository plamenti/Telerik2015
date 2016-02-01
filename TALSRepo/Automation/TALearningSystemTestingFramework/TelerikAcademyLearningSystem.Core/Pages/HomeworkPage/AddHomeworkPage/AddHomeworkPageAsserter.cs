namespace TelerikAcademyLearningSystem.Core.Pages.HomeworkPage.AddHomeworkPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikAcademyLearningSystem.Core.Constants.Homework;

    public static class AddHomeworkPageAsserter
    {
        private const string PageTitle = "Създаване на домашно - Телерик Академия - Студентска система";

        public static void AssertTitle(this AddHomeworkPage page)
        {
            Assert.AreEqual(PageTitle, page.Title, string.Format("The correct page title is: {0}", PageTitle));
        }

        public static void HeaderIsPresent(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.Header.IsVisible(), "Header is not visible");
            var title = page.Find.ByExpression("tagname=h1").InnerText;
            Assert.AreEqual("Създаване на домашно", title);
        }

        public static void CourseNameInputIsVisible(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.CourseNameInput.IsVisible(), "Course name input is not visible");
        }

        public static void CourseNameLabelIsPresent(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.CourseNameLabel.IsVisible(), "Course name label is not visible");
            var label = page.Find.ByExpression("tagname=label", "for=CourseInstanceId");
            Assert.AreEqual("Курс", label.InnerText);
        }

        public static void LectureNameInputIsVisible(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.LectureNameInput.IsVisible(), "Lecture name input is not visible");
        }

        public static void LectureNameLabelIsPresent(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.LectureNameLabel.IsVisible(), "Lecture name label is not visible");
            var label = page.Find.ByExpression("tagname=label", "for=LectureId");
            Assert.AreEqual("Лекция", label.InnerText);
        }

        public static void UserNameInputIsVisible(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.UserNameInput.IsVisible(), "User name input is not visible");
        }

        public static void UserNameLabelIsPresent(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.UserNameLabel.IsVisible(), "User name label is not visible");
            var label = page.Find.ByExpression("tagname=label", "for=Username");
            Assert.AreEqual("Потребител", label.InnerText);
        }

        public static void MarkInputIsVisible(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.MarkInput.IsVisible(), "Mark input is not visible");
        }

        public static void MarkLabelIsPresent(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.MarkLabel.IsVisible(), "Mark label is not visible");
            var label = page.Find.ByExpression("tagname=label", "for=Mark");
            Assert.AreEqual("Оценка", label.InnerText);
        }

        public static void EvaluationCheckboxIsVisible(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.EvaluationCheckbox.IsVisible(), "Evaluation checkbox is not visible");
        }

        public static void EvaluationCheckboxLabelIsPresent(this AddHomeworkPage page)
        {
            ////Assert.IsTrue(page.EvaluationCheckboxLabel.IsVisible(), "Evaluation label is not visible");

            var label = page.EvaluationCheckboxLabel.InnerText;
            Assert.AreEqual("Избрано за оценяване", label);
        }

        public static void HomeworkFileButtonIsVisible(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.UploadFileButton.IsVisible(), "Homework file button is not visible");
        }

        public static void HomeworkFileLabelIsPresent(this AddHomeworkPage page)
        {
            Assert.IsTrue(page.HomeworkFileLabel.IsVisible(), "Homework file label is not visible");
            var label = page.HomeworkFileLabel.InnerText;
            Assert.AreEqual("Файл:", label);
        }

        public static void SubmitButtonIsVisible(this AddHomeworkPage page)
        {
            page.Browser.RefreshDomTree();
            Assert.IsTrue(page.SubmitButton.IsVisible(), AddHomeworkConstants.SubmitButtonErrorMessageNotVisible);
        }

        public static void BackToAllHomeworksButtonIsVisible(this AddHomeworkPage page)
        {
            page.Browser.RefreshDomTree();
            Assert.IsTrue(page.BackToAllHomeworksButton.IsVisible(), AddHomeworkConstants.BackToAllHomeworksErrorMessageSpanNotVisible);
        }

        public static void CourseValidationMessageIsVisible(this AddHomeworkPage page, string expectedMessage)
        {
            page.Browser.RefreshDomTree();
            var actualMessage = page.CourseNameErrorMessage.InnerText;
            Assert.IsTrue(page.CourseNameErrorMessage.IsVisible(), AddHomeworkConstants.CourseNameErrorMessageSpanNotVisible);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        public static void LectureValidationMessageIsVisible(this AddHomeworkPage page, string expectedMessage)
        {
            page.Browser.RefreshDomTree();
            Assert.IsTrue(page.LectureNameErrorMessage.IsVisible(), AddHomeworkConstants.LectureNameErrorMessageSpanNotVisible);
            Assert.AreEqual(expectedMessage, page.LectureNameErrorMessage.InnerText);
        }

        public static void UsernameValidationMessageIsVisibleWithRequredText(this AddHomeworkPage page, string expectedMessage)
        {
            page.Browser.RefreshDomTree();
            Assert.IsTrue(page.UserNameErrorMessage.IsVisible(), AddHomeworkConstants.UserNameErrorMessageSpanNotVisible);
            Assert.AreEqual(expectedMessage, page.UserNameErrorMessage.InnerText);
        }

        public static void HomeworkFileValidationMessageIsVisible(this AddHomeworkPage page, string expectedMessage)
        {
            page.Browser.RefreshDomTree();
            Assert.IsTrue(page.HomeworkErrorMessage.IsVisible(), AddHomeworkConstants.HomeworkFileeErrorMessageSpanNotVisible);
            Assert.AreEqual(expectedMessage, page.HomeworkErrorMessage.InnerText);
        }
    }
}
