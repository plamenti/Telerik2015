namespace TALS.TestingFramework.Core.Pages.GroupsPage
{
    using TALS.TestingFramework.Core.Base;

    public partial class GroupsPage : BasePage
    {
        private const string Url = @"http://stage.telerikacademy.com/Administration_Courses/CoursesGroups";

        public GroupsPage()
        {
            this.Asserter = new GroupsPageAsserter(this);
        }

        public override void Navigate()
        {
            ActiveBrowser.NavigateTo(Url);
        }
    }
}