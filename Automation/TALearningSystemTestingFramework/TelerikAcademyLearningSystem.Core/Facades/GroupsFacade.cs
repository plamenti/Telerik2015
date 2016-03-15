namespace TelerikAcademyLearningSystem.Core.Facades
{
    using System.Collections;
    using Pages.GroupsPage;
    using TelerikAcademyLearningSystem.Core.Factories;
    using TelerikAcademyLearningSystem.Core.Model;

    public class GroupsFacade
    {
        private ColumnIndexFacory columnIndexFactory = new ColumnIndexFacory();

        public void OpenGroupsPage()
        {
            GroupsPage.Instance.Navigate();
        }

        public void BackToAdministration()
        {
            GroupsPage.Instance.Navigate();
            GroupsPage.Instance.BackToAdminButton.Click();
        }

        public void CreateNewGroup(Group group)
        {
            GroupsPage.Instance.Navigate();
            if (GroupsPage.Instance.ContainsGroup(group))
            {
                GroupsPage.Instance.DeleteGroup(group);
            }

            GroupsPage.Instance.CreateNewGroup(group);
        }

        public void AssertGroupIsCreated(Group group)
        {
            GroupsPage.Instance.AssertGroupIsCreated(group);
        }

        public void DeleteGroup(Group group)
        {
            GroupsPage.Instance.Navigate();
            if (GroupsPage.Instance.ContainsGroup(group))
            {
                GroupsPage.Instance.DeleteGroup(group);
            }
        }

        public void AssertGroupIsDeleted(Group group)
        {
            GroupsPage.Instance.AssertGroupIsDeleted(group);
        }

        public void FilterCoursesFacade(string courseName)
        {
            GroupsPage.Instance.Navigate();
            GroupsPage.Instance.FilterCourses(courseName);
            GroupsPage.Instance.Browser.WaitForAjax(3000);
            GroupsPage.Instance.Browser.RefreshDomTree();
        }

        public void AssertAreCoursesDifferent()
        {
            GroupsPage.Instance.AssertAreCoursesDifferent();
        }

        public void AssertAreCoursesSame()
        {
            GroupsPage.Instance.AssertAreCoursesSame();
        }

        public void AssertGroupsPageIsOpen()
        {
            GroupsPage.Instance.AssertTitle();
            GroupsPage.Instance.AssertCreateGroupButtonIsVisible();
            GroupsPage.Instance.AssertBackToAdminButtonIsVisible();
        }

        public void SortGroups(IComparer comparer, string sortBy)
        {
            GroupsPage.Instance.Navigate();
            GroupsPage.Instance.SortGroups(sortBy);
            int columnIndex = this.columnIndexFactory.CreateIndex(sortBy);

            string[] actual = GroupsPage.Instance.ExtractColumnValues(columnIndex);

            string[] expected = GroupsPage.Instance.SortColumn(comparer, columnIndex);

            GroupsPage.Instance.IsSortedProperly = GroupsPage.Instance.AreColumnsEqual(actual, expected);
        }

        public void AssertGroupsAreSorted(string sortBy)
        {
            GroupsPage.Instance.AssertGroupsAreSorted(sortBy);
        }
    }
}