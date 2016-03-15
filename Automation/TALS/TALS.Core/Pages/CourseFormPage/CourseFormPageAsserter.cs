
namespace TALS.TestingFramework.Core.Pages.CourseFormPage
{
    using ArtOfTest.Common.UnitTesting;
    using TALS.TestingFramework.Core.Base;

    public class CourseFormPageAsserter:IAsserter
    {

        private CourseFormPage courseFormPage;

        public CourseFormPageAsserter(CourseFormPage courseFormPage)
        {
            this.courseFormPage = courseFormPage;
        }

        public void DoAssert()
        {
            // this.IsDivVissible();
        }

        private void VerifyErrorMessage(string message)
        {
            // Assert.IsTrue(this.courseFormPage.);
        }




    }
}
