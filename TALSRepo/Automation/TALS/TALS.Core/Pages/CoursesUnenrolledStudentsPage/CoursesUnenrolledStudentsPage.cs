namespace TALS.TestingFramework.Core.Pages.CoursesUnenrolledStudentsPage
{
    using TALS.TestingFramework.Core.Base;

    public partial class CoursesUnenrolledStudentsPage : BasePage
    {
        private const string Url = @"http://stage.telerikacademy.com/Administration_Courses/UnenrolledUsersInCourses";

        public CoursesUnenrolledStudentsPage()
        {
            this.Asserter = new CoursesUnenrolledStudentsPageAsserter(this);
        }

        public override void Navigate()
        {
            ActiveBrowser.NavigateTo(Url);
        }
    }
}