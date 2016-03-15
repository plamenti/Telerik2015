namespace TelerikAcademyLearningSystem.Core.Pages.CoursesAndLecturesPage.CourseFormPage
{
    using System;
    using System.Linq;
    using Constants;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Model;

    public static class CourseFormPageAsserter
    {
        public static void AssertTitle(this CourseFormPage page)
        {
            var expected = "Курс";
            var actual = page.Title.InnerText;
            Assert.AreEqual(expected, actual, "Title is {0}, not {1}", actual, expected);
        }

        public static void AssertUpdateButtonIsVisible(this CourseFormPage page)
        {
            Assert.IsTrue(page.UpdateButton.IsVisible(), "Update button is not visible");
        }

        public static void AssertCancelButtonIsVisible(this CourseFormPage page)
        {
            Assert.IsTrue(page.CancelButton.IsVisible(), "Cancel button is not visible");
        }

        public static void AssertRequiredNameBgValidationMessage(this CourseFormPage page)
        {
            var actualNameBgMessage = page.NameBgValidationMessage.InnerText;
            Assert.AreEqual(CourseForm.RequiredNameBgMessage, actualNameBgMessage, "{0} {1}", CourseForm.RequiredNameBgMessage, Global.NullRefferenceMessage);
        }

        public static void AssertRequiredDescriptionValidationMessage(this CourseFormPage page)
        {
            var actualDiscriptionMessage = page.DescriptionValidationMessage.InnerText;
            Assert.AreEqual(CourseForm.RequiredDescriptionMessage, actualDiscriptionMessage, "{0} {1}", CourseForm.RequiredDescriptionMessage, Global.NullRefferenceMessage);
        }

        public static void AssertRequiredOrderValidationMessage(this CourseFormPage page)
        {
            var actualOrderMessage = page.OrderValidationMessage.InnerText;
            Assert.AreEqual(CourseForm.RequiredOrderMessage, actualOrderMessage, "{0} {1}", CourseForm.RequiredOrderMessage, Global.NullRefferenceMessage);
        }

        public static void AssertExistingNameBgValidationMessage(this CourseFormPage page)
        {
            page.NameBgValidationMessage.ScrollToVisible();
            var actualNameBgMessage = page.NameBgValidationMessage.InnerText;
            Assert.AreEqual(CourseForm.ExistingNameMesage, actualNameBgMessage, "{0} {1}", CourseForm.ExistingNameMesage, Global.NullRefferenceMessage);
        }

        public static void AssertExistingNameEnValidationMessage(this CourseFormPage page)
        {
            var actualNameEnMessage = page.NameEnValidationMessage.InnerText;
            Assert.AreEqual(CourseForm.ExistingNameMesage, actualNameEnMessage, "{0} {1}", CourseForm.ExistingNameMesage, Global.NullRefferenceMessage);
        }

        public static void AssertExistingUrlValidationMessage(this CourseFormPage page)
        {
            var actualUrlMessage = page.UrlNameValidationMessage.InnerText;
            var a = page.UrlNameValidationMessage;
            var aa = page.UrlNameValidationMessage.ChildNodes;
            var b = page.UrlNameValidationMessage.ChildNodes.FirstOrDefault().InnerText;
            var c = page.UrlNameValidationMessage.ChildNodes.FirstOrDefault().TextContent;

            Assert.AreEqual(CourseForm.ExistingUrlNAmeMesage, actualUrlMessage, "{0} {1}", CourseForm.ExistingUrlNAmeMesage, Global.NullRefferenceMessage);
        }

        public static void AssertLongNameBgValidationMessage(this CourseFormPage page)
        {
            var actualNameBgMessage = page.NameBgValidationMessage.InnerText;
            Assert.AreEqual(CourseForm.InvalidLengthNameBgMessage, actualNameBgMessage, "{0} {1}", CourseForm.InvalidLengthNameBgMessage, Global.NullRefferenceMessage);
        }

        public static void AssertLongNameEnValidationMessage(this CourseFormPage page)
        {
            var actualNameEnMessage = page.NameEnValidationMessage.InnerText;
            Assert.AreEqual(CourseForm.InvalidLengthNameEnMessage, actualNameEnMessage, "{0} {1}", CourseForm.InvalidLengthNameEnMessage, Global.NullRefferenceMessage);
        }

        public static void AssertLongUrlNameValidationMessage(this CourseFormPage page)
        {
            var actualUrlMessage = page.UrlNameValidationMessage.InnerText;
            Assert.AreEqual(CourseForm.InvalidLengthUrNamelMessage, actualUrlMessage, "{0} {1}", CourseForm.InvalidLengthUrNamelMessage, Global.NullRefferenceMessage);
        }

        public static void AssertInvalidUrlNameValidationMessage(this CourseFormPage page)
        {
            var actualUrlMessage = page.UrlNameValidationMessage.InnerText;
            Assert.AreEqual(CourseForm.InvalidUrlNameMessage, actualUrlMessage, " {0} {1}", CourseForm.InvalidUrlNameMessage, Global.NullRefferenceMessage);
        }

        public static void AssertInvalidOrderValidationMessage(this CourseFormPage page, Course course)
        {
            var expected = string.Format(CourseForm.InvalidOrderMessage, course.Order);
            var actual = page.OrderValidationMessage.InnerText;
            Assert.AreEqual(expected, actual, string.Format(expected, Global.NullRefferenceMessage));
        }

        public static void AssertPageFormIsOpen(this CourseFormPage page)
        {
            page.Browser.RefreshDomTree();
            AssertTitle(page);
        }
    }
}
