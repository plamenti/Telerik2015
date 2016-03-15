namespace TALS.TestingFramework.Core.Pages.HomeworkPage
{
    using TALS.TestingFramework.Core.Base;

    public partial class HomeworkPage : BasePage
    {
        private const string Url = @"http://stage.telerikacademy.com/Administration_Courses/Homework";

        public HomeworkPage()
        {
            this.Asserter = new HomeworkPageAsserter(this);
        }

        public override void Navigate()
        {
            ActiveBrowser.NavigateTo(Url);
        }

    }
}
