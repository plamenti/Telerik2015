namespace TelerikAcademyLearningSystem.Core.Facades
{
    using System.Threading;
    using Model;
    using Pages.CoursesAndLecturesPage;
    using Pages.CoursesAndLecturesPage.CourseFormPage;

    public class CourseFacade
    {
        public void AddNewCourse(Course course)
        {
            this.AddCourse(course);
            Thread.Sleep(5000);
            CourseFormPage.Instance.UpdateForm();
        }

        public void CancelAddingNewCourse(Course course)
        {
            this.AddCourse(course);
            CourseFormPage.Instance.CancelForm();
        }

        public void AddCourse(Course course)
        {
            CoursesAndLecturesPage.Instance.Navigate();
            CoursesAndLecturesPage.Instance.DeleteCourseIfExisting(course);
            CoursesAndLecturesPage.Instance.OpenCourseForm();
            CourseFormPage.Instance.FillForm(course);
        }

        public void AddCoursWithothExistingCheck(Course course)
        {
            CoursesAndLecturesPage.Instance.Navigate();
            CoursesAndLecturesPage.Instance.OpenCourseForm();
            CourseFormPage.Instance.FillForm(course);
            CourseFormPage.Instance.UpdateForm();
        }

        public void AddEmptyCourse()
        {
            CoursesAndLecturesPage.Instance.Navigate();
            CoursesAndLecturesPage.Instance.OpenCourseForm();
            CourseFormPage.Instance.ClearInput(
                CourseFormPage.Instance.Order.Text,
                CourseFormPage.Instance.Order);
            CourseFormPage.Instance.UpdateForm();
        }

        public void EditNameBg(Course course, string newValue)
        {
            CoursesAndLecturesPage.Instance.OpenEditForm(course);
            CourseFormPage.Instance.EditInput(
                CourseFormPage.Instance.NameBg.Text,
                CourseFormPage.Instance.NameBg,
                newValue);
            CourseFormPage.Instance.UpdateForm();
        }

        public void EditNameEn(Course course, string newValue)
        {
            CoursesAndLecturesPage.Instance.OpenEditForm(course);
            CourseFormPage.Instance.EditInput(
                CourseFormPage.Instance.NameEn.Text,
                CourseFormPage.Instance.NameEn, 
                newValue);
            CourseFormPage.Instance.UpdateForm();
        }

        public void EditUrlName(Course course, string newValue)
        {
            CoursesAndLecturesPage.Instance.OpenEditForm(course);
            CourseFormPage.Instance.EditInput(
                CourseFormPage.Instance.UrlName.Text,
                CourseFormPage.Instance.UrlName, 
                newValue);
            CourseFormPage.Instance.UpdateForm();
        }

        public void EditDescription(Course course, string newValue)
        {
            CoursesAndLecturesPage.Instance.OpenEditForm(course);
            CourseFormPage.Instance.EditInput(
                CourseFormPage.Instance.Description.InnerText,
                CourseFormPage.Instance.Description, 
                newValue);
            CourseFormPage.Instance.UpdateForm();
        }

        public void EditOrder(Course course, string newValue)
        {
            CoursesAndLecturesPage.Instance.OpenEditForm(course);
            CourseFormPage.Instance.EditInput(
                CourseFormPage.Instance.NameBg.Text,
                CourseFormPage.Instance.NameBg, 
                newValue);
            CourseFormPage.Instance.UpdateForm();
        }

        ////public void VerifyPageFormIsOpen()
        ////{
        ////    Thread.Sleep(1000);
        ////    CoursesAndLecturesPage.Instance.Browser.RefreshDomTree();
        ////    CourseFormPageAsserter.AssertTitle(CourseFormPage.Instance);
        ////}

        public void AssertIfCourseExist(Course course)
        {
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(course);
            CoursesAndLecturesPage.Instance.DeleteCourseIfExisting(course);
        }

        public void AssertExistingNameBgValidetionMessage(Course course)
        {
            CourseFormPage.Instance.AssertExistingNameBgValidationMessage();
            CourseFormPage.Instance.CancelForm();
            CoursesAndLecturesPage.Instance.DeleteCourseIfExisting(course);
        }

        public void AssertExistingNameEnValidetionMessage(Course course)
        {
            CourseFormPage.Instance.AssertExistingNameEnValidationMessage();
            CourseFormPage.Instance.CancelForm();
            CoursesAndLecturesPage.Instance.DeleteCourseIfExisting(course);
        }

        public void AssertExistingUrlNameValidetionMessage(Course course)
        {
            CourseFormPage.Instance.AssertExistingUrlValidationMessage();
            CourseFormPage.Instance.CancelForm();
            CoursesAndLecturesPage.Instance.DeleteCourseIfExisting(course);
        }

        public void AssertRequiredFieldsMessageIsDisplayed()
        {
            CourseFormPage.Instance.Browser.RefreshDomTree();
            CourseFormPage.Instance.AssertRequiredNameBgValidationMessage();
            CourseFormPage.Instance.AssertRequiredDescriptionValidationMessage();
            CourseFormPage.Instance.AssertRequiredOrderValidationMessage();
        }

        public void VerifyExistingDataMessageIsDisplayed()
        {
            CourseFormPageAsserter.AssertExistingNameBgValidationMessage(CourseFormPage.Instance);
            CourseFormPageAsserter.AssertExistingNameEnValidationMessage(CourseFormPage.Instance);
            CourseFormPageAsserter.AssertExistingUrlValidationMessage(CourseFormPage.Instance);
        }
    }
}
