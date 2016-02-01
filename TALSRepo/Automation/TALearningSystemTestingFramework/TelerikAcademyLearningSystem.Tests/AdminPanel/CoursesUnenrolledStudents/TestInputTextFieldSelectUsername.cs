namespace TelerikAcademyLearningSystem.Tests.AdminPanel.CoursesUnenrolledStudents
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;

    [TestClass]
    public class TestInputTextFieldSelectUsername : BaseTest
    {
        private CoursesUnenrolledStudentsFacade coursesUnenrolledStudentsFacade;

        public override void TestInit()
        {
            base.TestInit();
            this.coursesUnenrolledStudentsFacade = new CoursesUnenrolledStudentsFacade();
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyValidUsername()
        {
            string validUsername = "giant1Student";

            this.coursesUnenrolledStudentsFacade.ValidUsernameToFilter(validUsername);

            this.coursesUnenrolledStudentsFacade.AssertValidUsernameToFilterExposeOnlyOneUser(validUsername);
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyInvalidCharacters()
        {
            string invalidUsername = "@#$";
            string warningMessage = "Потребителското име може да съдържа само малки и главни латински букви, цифри и знаците точка и долна черта. Потребителското име трябва да започва с буква и да завършва с буква или цифра";
            string assertMessage = "Page should contains a warning message for invalid characters";

            this.coursesUnenrolledStudentsFacade.InvalidUsernameToFilter(invalidUsername, warningMessage);

            this.coursesUnenrolledStudentsFacade.AssertInvalidUsernameToFilter(assertMessage);
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyStringWithLengthLessThan5Characters()
        {
            string invalidUsername = "less";
            string warningMessage = "Потребителското име трябва да е между 5 и 32 символа";
            string assertMessage = "Page should contains warning message for an username with length less than 5 characters";

            this.coursesUnenrolledStudentsFacade.InvalidUsernameToFilter(invalidUsername, warningMessage);

            this.coursesUnenrolledStudentsFacade.AssertInvalidUsernameToFilter(assertMessage);
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyStringWithLengthLongerThan32Characters()
        {
            string invalidUsername = "UsernameWithMoreThanThirtyTwoCharacters";
            string warningMessage = "Потребителското име трябва да е между 5 и 32 символа";
            string assertMessage = "Page should contains a warning message for an username with length bigger than 32 characters";

            this.coursesUnenrolledStudentsFacade.InvalidUsernameToFilter(invalidUsername, warningMessage);

            this.coursesUnenrolledStudentsFacade.AssertInvalidUsernameToFilter(assertMessage);
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyNonexistentUsername()
        {
            string invalidUsername = "someNonexistentUsername";

            this.coursesUnenrolledStudentsFacade.AssertInvalidUsername(invalidUsername);

            this.coursesUnenrolledStudentsFacade.AssertInvalidUsernameToFilterNoExposesUser();
        }
    }
}