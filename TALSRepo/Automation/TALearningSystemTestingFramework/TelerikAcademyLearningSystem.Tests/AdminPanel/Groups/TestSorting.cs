namespace TelerikAcademyLearningSystem.Tests.AdminPanel.Groups
{
    using System;
    using System.Collections;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Constants;
    using TelerikAcademyLearningSystem.Core.Facades;
    using TelerikAcademyLearningSystem.Core.Factories;

    [TestClass]
    public class TestSorting : BaseTest
    {
        private GroupsFacade groupsFacade;
        private SortingHelperFactory sortingHelperFactory;
        private IComparer comparer;

        public override void TestInit()
        {
            base.TestInit();
            this.groupsFacade = new GroupsFacade();
            this.sortingHelperFactory = new SortingHelperFactory();
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifySortingByGroupsName()
        {
            string sortBy = GroupsColumnNames.GroupName;
            this.comparer = this.sortingHelperFactory.CreateSortingHelper(SortingHelpersNames.Names);

            this.groupsFacade.SortGroups(this.comparer, sortBy);

            this.groupsFacade.AssertGroupsAreSorted(sortBy);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifySortingByCourseName()
        {
            string sortBy = GroupsColumnNames.CourseName;
            this.comparer = this.sortingHelperFactory.CreateSortingHelper(SortingHelpersNames.Names);

            this.groupsFacade.SortGroups(this.comparer, sortBy);

            this.groupsFacade.AssertGroupsAreSorted(sortBy);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifySortingByDayOfTheWeek()
        {
            string sortBy = GroupsColumnNames.DayOfWeek;
            this.comparer = this.sortingHelperFactory.CreateSortingHelper(SortingHelpersNames.DaysOfWeek);

            this.groupsFacade.SortGroups(this.comparer, sortBy);

            this.groupsFacade.AssertGroupsAreSorted(sortBy);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifySortingByStartingDayTime()
        {
            string sortBy = GroupsColumnNames.Start;
            this.comparer = this.sortingHelperFactory.CreateSortingHelper(SortingHelpersNames.Times);

            this.groupsFacade.SortGroups(this.comparer, sortBy);

            this.groupsFacade.AssertGroupsAreSorted(sortBy);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifySortingByLectureNumber()
        {
            string sortBy = GroupsColumnNames.LectureNumber;
            this.comparer = this.sortingHelperFactory.CreateSortingHelper(SortingHelpersNames.Lectures);

            this.groupsFacade.SortGroups(this.comparer, sortBy);

            this.groupsFacade.AssertGroupsAreSorted(sortBy);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifySortingByLectureHallName()
        {
            string sortBy = GroupsColumnNames.Hall;
            this.comparer = this.sortingHelperFactory.CreateSortingHelper(SortingHelpersNames.Halls);

            this.groupsFacade.SortGroups(this.comparer, sortBy);

            this.groupsFacade.AssertGroupsAreSorted(sortBy);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifySortingByRegistrationTime()
        {
            string sortBy = GroupsColumnNames.EnrollAfter;
            this.comparer = this.sortingHelperFactory.CreateSortingHelper(SortingHelpersNames.DatesAndTimes);

            this.groupsFacade.SortGroups(this.comparer, sortBy);

            this.groupsFacade.AssertGroupsAreSorted(sortBy);
        }

        [TestMethod,
         Priority(Priority.Medium),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifySortingByCountOfFreePlaces()
        {
            string sortBy = GroupsColumnNames.FreePlaces;
            this.comparer = this.sortingHelperFactory.CreateSortingHelper(SortingHelpersNames.FreePlaces);

            this.groupsFacade.SortGroups(this.comparer, sortBy);

            this.groupsFacade.AssertGroupsAreSorted(sortBy);
        }
    }
}