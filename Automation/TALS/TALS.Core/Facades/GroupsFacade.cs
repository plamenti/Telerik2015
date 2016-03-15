namespace TALS.TestingFramework.Core.Facades
{
    using TALS.TestingFramework.Core.Pages.GroupsPage;

    public class GroupsFacade
    {
        private GroupsPage groupsPage;

        public GroupsFacade()
        {
            this.groupsPage = new GroupsPage();
        }

        public void VerifyGroupsPage()
        {
            this.groupsPage.Navigate();
            this.groupsPage.Asserter.DoAssert();
        }
    }
}