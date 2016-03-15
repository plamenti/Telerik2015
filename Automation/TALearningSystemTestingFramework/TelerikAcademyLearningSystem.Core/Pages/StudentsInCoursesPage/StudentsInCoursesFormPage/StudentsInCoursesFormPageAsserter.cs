namespace TelerikAcademyLearningSystem.Core.Pages.StudentsInCoursesPage.StudentsInCoursesFormPage
{
    using Constants;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    internal static class StudentsInCoursesFormPageAsserter
    {
        internal static void AssertTitle(this StudentsInCoursesFormPage page)
        {
            var expected = "Курс";
            var actual = page.Title.InnerText;
            Assert.AreEqual(expected, actual, "Title is {0}, not {1}", actual, expected);
        }

        internal static void AssertUpdateButtonIsVisible(this StudentsInCoursesFormPage page)
        {
            Assert.IsTrue(page.UpdateButton.IsVisible(), "Update button is not visible");
        }

        internal static void AssertCancelButtonIsVisible(this StudentsInCoursesFormPage page)
        {
            Assert.IsTrue(page.CancelButton.IsVisible(), "Cancel button is not visible");
        }

        internal static void AssertNotExistingUsernameValidationMessage(this StudentsInCoursesFormPage page)
        {
            var actualMessage = page.UserNameValidationMessage.InnerText;
            var expectedMessage = StudentInCourseForm.NotExistingUserValidationMessage;
            Assert.AreEqual(expectedMessage, actualMessage, "{0} {1}", expectedMessage, Global.NullRefferenceMessage);
        }

        internal static void AssertRequiredUsernameValidationMessage(this StudentsInCoursesFormPage page)
        {
            var actualMessage = page.UserNameValidationMessage.InnerText;
            var expectedMessage = StudentInCourseForm.RequiredUserFieldValidationMessage;
            Assert.AreEqual(expectedMessage, actualMessage, "{0} {1}", expectedMessage, Global.NullRefferenceMessage);
        }

        internal static void AssertRequiredCourseInstanceValidationMessage(this StudentsInCoursesFormPage page)
        {
            var actualMessage = page.CourseInstanceValidationMessage.InnerText;
            var expectedMessage = StudentInCourseForm.RegiredCourseFieldValidationMessage;
            Assert.AreEqual(expectedMessage, actualMessage, "{0} {1}", expectedMessage, Global.NullRefferenceMessage);
        }

        internal static void AssertEnrolledUserValidationMessage(this StudentsInCoursesFormPage page)
        {
            var actualMessage = page.UserNameValidationMessage.InnerText;
            var expectedMessage = StudentInCourseForm.EnrolledUserInCourseValidationMessage;
            Assert.AreEqual(expectedMessage, actualMessage, "{0} {1}", expectedMessage, Global.NullRefferenceMessage);
        }

        internal static void AssertUnenrolledUserValidationMessage(this StudentsInCoursesFormPage page)
        {
            var actualMessage = page.UserNameValidationMessage.InnerText;
            var expectedMessage = StudentInCourseForm.UnenrolledUsersInCoursesValidationMessage;
            Assert.AreEqual(expectedMessage, actualMessage, "{0} {1}", expectedMessage, Global.NullRefferenceMessage);
        }
    }
}
