namespace TelerikAcademyLearningSystem.Core.Pages.GroupsPage
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikAcademyLearningSystem.Core.Model;

    public static class GroupsPageAsserter
    {
        private const string PageTitle = "Групи за присъствено участие в курсове - Телерик Академия - Студентска система";

        public static void AssertTitle(this GroupsPage page)
        {
            Assert.AreEqual(PageTitle, page.Title, string.Format("Page title should be: {0}", PageTitle));
        }

        public static void AssertCreateGroupButtonIsVisible(this GroupsPage page)
        {
            Assert.IsTrue(page.CreateGroupButton.IsVisible(), "Create group button is not visible");
        }

        public static void AssertBackToAdminButtonIsVisible(this GroupsPage page)
        {
            Assert.IsTrue(page.BackToAdminButton.IsVisible(), "Back to admin button is not visible");
        }

        public static void AssertGroupIsCreated(this GroupsPage page, Group group)
        {
            bool isCreated = page.ContainsGroup(group);
            Assert.IsTrue(isCreated, "Group is not created");
        }

        public static void AssertGroupIsDeleted(this GroupsPage page, Group group)
        {
            bool isDeleted = page.ContainsGroup(group);
            Assert.IsFalse(isDeleted, "Group is not deleted");
        }

        public static void AssertAreCoursesDifferent(this GroupsPage page)
        {
            bool areDifferent = page.AreCoursesDifferent();
            Assert.IsTrue(areDifferent, "Courses are not different");
        }

        public static void AssertAreCoursesSame(this GroupsPage page)
        {
            bool areDifferent = page.AreCoursesDifferent();
            Assert.IsFalse(areDifferent, "Courses are different");
        }

        public static void AssertGroupsAreSorted(this GroupsPage page, string sortBy)
        {
            Assert.IsTrue(page.IsSortedProperly, "Page is not sorted properly by" + sortBy);
        }
    }
}