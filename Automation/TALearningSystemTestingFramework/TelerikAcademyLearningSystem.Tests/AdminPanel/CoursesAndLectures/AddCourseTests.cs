namespace TelerikAcademyLearningSystem.Tests.AdminPanel.CoursesAndLectures
{
    using Core.Constants;
    using Core.Facades;
    using Core.Model;
    using Core.Pages.CoursesAndLecturesPage;
    using Core.Pages.CoursesAndLecturesPage.CourseFormPage;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;

    [TestClass]
    public class AddCourseTests : BaseTest
    {
        private CourseFacade facade = new CourseFacade();
        private Course testCourse = new Course
        {
            NameBg = "Тест Giant",
            NameEn = "Test Giant",
            UrlName = "testGiant",
            Description = "Team Giant",
            Color = "aaaaaa",
            Order = "7"
        };

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyANewCourseIsNotCreatedWithValidDataWhenCancelButtonIsClicked()
        {
            this.facade.CancelAddingNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseDoesntExist(this.testCourse);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Dushka),
         TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidatitonMessagesForRequiredFields()
        {
            this.facade.AddEmptyCourse();
            this.facade.AssertRequiredFieldsMessageIsDisplayed();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Dushka),
         TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidatitonMessagesForExistingNameBG()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            this.testCourse.NameEn = "Alabala";
            this.testCourse.UrlName = "Alabala";
            this.facade.AddCoursWithothExistingCheck(this.testCourse);
            this.facade.AssertExistingNameBgValidetionMessage(this.testCourse);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Dushka),
         TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidatitonMessagesForExistingNameEn()
        {
            this.facade.AddNewCourse(this.testCourse);
            this.testCourse.NameBg = "Alabala";
            this.testCourse.UrlName = "Alabala";
            this.facade.AddCoursWithothExistingCheck(this.testCourse);
            this.facade.AssertExistingNameEnValidetionMessage(this.testCourse);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Dushka),
         TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidatitonMessagesForExistingUrlName()
        {
            this.facade.AddNewCourse(this.testCourse);
            this.testCourse.NameBg = "Alabala";
            this.testCourse.NameEn = "Alabala";
            this.facade.AddCoursWithothExistingCheck(this.testCourse);
            this.facade.AssertExistingUrlNameValidetionMessage(this.testCourse);
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Dushka),
         TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidatitonMessagesLongNameBg()
        {
            this.testCourse.NameBg = CourseForm.LongName101symbols;
            this.facade.AddNewCourse(this.testCourse);
            CourseFormPage.Instance.AssertLongNameBgValidationMessage();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Dushka),
         TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidatitonMessagesLongNameEn()
        {
            this.testCourse.NameEn = CourseForm.LongName101symbols;
            this.facade.AddNewCourse(this.testCourse);
            CourseFormPage.Instance.AssertLongNameEnValidationMessage();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Dushka),
         TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidatitonMessagesLongUrlName()
        {
            this.testCourse.UrlName = CourseForm.LongUrlName51symbols;
            this.facade.AddNewCourse(this.testCourse);
            CourseFormPage.Instance.AssertLongUrlNameValidationMessage();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Dushka),
         TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseCreatedMaxLengthNames()
        {
            this.testCourse.NameBg = CourseForm.ExactName100symbols;
            this.testCourse.NameEn = CourseForm.ExactName100symbols;
            this.testCourse.UrlName = CourseForm.ExactName50symbols;
            this.facade.AddNewCourse(this.testCourse);
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseCreatedLessOneThanMaxLengthNames()
        {
            this.testCourse.NameBg = CourseForm.ExactName99symbols;
            this.testCourse.NameEn = CourseForm.ExactName99symbols;
            this.testCourse.UrlName = CourseForm.ExactName49symbols;
            this.facade.AddNewCourse(this.testCourse);
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseOrderValueMessageWithMaxValuePlusOne()
        {
            this.testCourse.Order = CourseForm.OrderGraterMaxValueWithOne;
            this.facade.AddNewCourse(this.testCourse);
            CourseFormPage.Instance.AssertInvalidOrderValidationMessage(this.testCourse);
        }

        [TestMethod,
       Priority(Priority.VeryHigh),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseCreatedWithMaxOrderValue()
        {
            this.testCourse.Order = CourseForm.OrderMaxValue;
            this.facade.AddNewCourse(this.testCourse);
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseCreatedWithMaxOrderValueLessOne()
        {
            this.testCourse.Order = CourseForm.OrderLessMaxValueWithOne;
            this.facade.AddNewCourse(this.testCourse);
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseOrderInvalidValueMessage()
        {
            this.testCourse.Order = "1.24";
            this.facade.AddNewCourse(this.testCourse);
            CourseFormPage.Instance.AssertInvalidOrderValidationMessage(this.testCourse);
        }

        ////Expected To Fail 
        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseUrlNameInvalidValueMessage()
        {
            this.testCourse.UrlName = @"http://www....";
            this.facade.AddNewCourse(this.testCourse);
            CourseFormPage.Instance.AssertInvalidUrlNameValidationMessage();
        }
    }
}