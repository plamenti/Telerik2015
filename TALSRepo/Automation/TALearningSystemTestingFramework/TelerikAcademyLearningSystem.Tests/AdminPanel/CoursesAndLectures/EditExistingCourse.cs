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
    public class EditExistingCourse : BaseTest
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
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidationMessageForEmptyNameBg()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = string.Empty;
            this.facade.EditNameBg(this.testCourse, newName);
            this.testCourse.NameBg = newName;
            CourseFormPage.Instance.AssertRequiredNameBgValidationMessage();
        }

        //// Expecting to fail
        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyEditWithValidatitonMessagesForExistingNameBg()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = this.testCourse.NameBg;
            this.testCourse.NameBg = "Alabala";
            this.testCourse.NameEn = "Alabala";
            this.testCourse.UrlName = "Alabala";
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            this.facade.EditNameBg(this.testCourse, newName);
            this.testCourse.NameBg = newName;
            CourseFormPage.Instance.AssertExistingNameBgValidationMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyEditValidatitonMessagesLongNameBg()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.LongName101symbols;
            this.facade.EditNameBg(this.testCourse, newName);
            CourseFormPage.Instance.AssertLongNameBgValidationMessage();
        }

        [TestMethod,
       Priority(Priority.High),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCoursIsEditWithExact100SymbolsNameBg()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.ExactName100symbols;
            this.facade.EditNameBg(this.testCourse, newName);
            this.testCourse.NameBg = newName;
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
       Priority(Priority.High),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCoursIsEditWithValidWithExact99symbolsNameBg()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.ExactName99symbols;
            this.facade.EditNameBg(this.testCourse, newName);
            this.testCourse.NameBg = newName;
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseIsEditWithEmptyNameEn()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = string.Empty;
            this.facade.EditNameEn(this.testCourse, newName);
            this.testCourse.NameEn = newName;
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        //// expected to fail
        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyEditWithValidatitonMessagesForExistingNameEn()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = this.testCourse.NameEn;
            this.testCourse.NameBg = "Alabala";
            this.testCourse.NameEn = "Alabala";
            this.testCourse.UrlName = "Alabala";
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            this.facade.EditNameBg(this.testCourse, newName);
            this.testCourse.NameBg = newName;
            CourseFormPage.Instance.AssertExistingNameBgValidationMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyEditValidatitonMessagesLongNameEn()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.LongName101symbols;
            this.facade.EditNameEn(this.testCourse, newName);
            CourseFormPage.Instance.AssertLongNameEnValidationMessage();
        }

        [TestMethod,
       Priority(Priority.High),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCoursIsEditWithExact100SymbolsNameEn()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.ExactName100symbols;
            this.facade.EditNameEn(this.testCourse, newName);
            this.testCourse.NameEn = newName;
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
       Priority(Priority.High),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCoursIsEditWithValidWithExact99symbolsNameEn()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.ExactName99symbols;
            this.facade.EditNameEn(this.testCourse, newName);
            this.testCourse.NameEn = newName;
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
       Priority(Priority.High),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidationMessageForEmptyUrlName()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = string.Empty;
            this.facade.EditUrlName(this.testCourse, newName);
            this.testCourse.UrlName = newName;
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        //// Expecting to fail
        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyEditWithValidatitonMessagesForExistingUrlName()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = this.testCourse.UrlName;
            this.testCourse.NameBg = "Alabala";
            this.testCourse.NameEn = "Alabala";
            this.testCourse.UrlName = "Alabala";
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            this.facade.EditUrlName(this.testCourse, newName);
            this.testCourse.UrlName = newName;
            CourseFormPage.Instance.AssertExistingUrlValidationMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyEditValidatitonMessagesLongUrlName()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.LongName101symbols;
            this.facade.EditUrlName(this.testCourse, newName);
            CourseFormPage.Instance.AssertLongUrlNameValidationMessage();
        }

        //// Expecting to fail
        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyEditValidatitonMessagesInvalidUrlName()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.LongName101symbols;
            this.facade.EditUrlName(this.testCourse, newName);
            CourseFormPage.Instance.AssertInvalidUrlNameValidationMessage();
        }

        [TestMethod,
       Priority(Priority.High),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCoursIsEditWithExact100SymbolsUrlName()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.ExactName100symbols;
            this.facade.EditUrlName(this.testCourse, newName);
            this.testCourse.UrlName = newName;
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
       Priority(Priority.High),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCoursIsEditWithValidWithExact99symbolsUrlName()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.ExactName99symbols;
            this.facade.EditUrlName(this.testCourse, newName);
            this.testCourse.UrlName = newName;
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidationMessageForEmptyDescription()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newValue = string.Empty;
            this.facade.EditDescription(this.testCourse, newValue);
            CourseFormPage.Instance.AssertRequiredDescriptionValidationMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseValidationMessageForEmptyOrder()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = string.Empty;
            this.facade.EditOrder(this.testCourse, newName);
            this.testCourse.Order = newName;
            CourseFormPage.Instance.AssertRequiredOrderValidationMessage();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseIsEditWithExistingOrder()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newValue = this.testCourse.Order;
            this.testCourse.NameBg = "Alabala";
            this.testCourse.NameEn = "Alabala";
            this.testCourse.UrlName = "Alabala";
            this.testCourse.Order = "155";
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            this.facade.EditOrder(this.testCourse, newValue);
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCourseOrderEditMessageWithMaxValuePlusOne()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newName = CourseForm.OrderGraterMaxValueWithOne;
            this.facade.EditOrder(this.testCourse, newName);
            CourseFormPage.Instance.AssertInvalidOrderValidationMessage(this.testCourse);
        }

        [TestMethod,
       Priority(Priority.High),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCoursIsEditWithExactMaxValue()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newValue = CourseForm.OrderMaxValue;
            this.facade.EditOrder(this.testCourse, newValue);
            this.testCourse.Order = newValue;
            this.facade.AssertIfCourseExist(this.testCourse);
        }

        [TestMethod,
       Priority(Priority.High),
       Owner(Owner.Dushka),
       TestCategory(Category.CoursesAndLectures)]
        public void VerifyCoursIsEditWithLessOneIntMaxValue()
        {
            this.facade.AddNewCourse(this.testCourse);
            CoursesAndLecturesPage.Instance.AssertCourseIsCreated(this.testCourse);
            string newValue = CourseForm.OrderLessMaxValueWithOne;
            this.facade.EditOrder(this.testCourse, newValue);
            this.testCourse.Order = newValue;
            this.facade.AssertIfCourseExist(this.testCourse);
        }
    }
}
