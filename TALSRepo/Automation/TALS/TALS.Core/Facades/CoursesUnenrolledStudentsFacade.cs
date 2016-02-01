namespace TALS.TestingFramework.Core.Facades
{
    using TALS.TestingFramework.Core.Pages.CoursesUnenrolledStudentsPage;

    public class CoursesUnenrolledStudentsFacade
    {
        private CoursesUnenrolledStudentsPage coursesUnenrolledStudentsPage;

        public CoursesUnenrolledStudentsFacade()
        {
            this.coursesUnenrolledStudentsPage = new CoursesUnenrolledStudentsPage();
        }

        public void VerifyCoursesUnenrolledStudentsPage()
        {
            this.coursesUnenrolledStudentsPage.Navigate();
            this.coursesUnenrolledStudentsPage.Asserter.DoAssert();
        }
    }
}