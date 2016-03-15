namespace TALS.TestingFramework.Core.Pages.CoursesAndLecturesPage
{
    using Base;

    public partial class CoursesAndLecturesPage : BasePage
    {
        private const string CoursesAndLecturesUrl =
            @"http://stage.telerikacademy.com/Administration_Courses/CoursesAndLectures";

        public CoursesAndLecturesPage()
        {
            this.Asserter = new CoursesAndLecturesPageAsserter(this);
        }

        public override void Navigate()
        {
            this.ActiveBrowser.NavigateTo(CoursesAndLecturesUrl);
        }

        public void OpenCreateNewCourseForm()
        {
            this.Navigate();
            this.CreateCourseButton.Wait.ForExists(1000);
            this.CreateCourseButton.Click();
            this.PopUp.Wait.ForExists(1000);
          //  this.Asserter.DoAssert();
        }
    }
}
