namespace TALS.TestingFramework.Core.Pages.GroupsPage
{
    using ArtOfTest.Common.UnitTesting;
    using TALS.TestingFramework.Core.Base;

    public class GroupsPageAsserter : IAsserter
    {
        private GroupsPage groupsPage;

        private const string PageTitle =
            "Групи за присъствено участие в курсове - Телерик Академия - Студентска система";

        public GroupsPageAsserter(GroupsPage groupsPage)
        {
            this.groupsPage = groupsPage;
        }

        public void DoAssert()
        {
            this.AssertTitle();
            this.CreateGroupButtonIsVisible();
            this.BackToAdminButtonIsVisible();
        }

        private void AssertTitle()
        {
            Assert.AreEqual(PageTitle, this.groupsPage.Title, string.Format("Page title should be: {0}", PageTitle));
        }

        private void CreateGroupButtonIsVisible()
        {
            Assert.IsTrue(this.groupsPage.CreateGroupButton.IsVisible(), "Create group button is not visible");
        }

        private void BackToAdminButtonIsVisible()
        {
            Assert.IsTrue(this.groupsPage.BackToAdminButton.IsVisible(), "Back to admin button is not visible");
        }
    }
}