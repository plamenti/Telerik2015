namespace TelerikAcademyLearningSystem.Tests.AdminPanel.LinksFromAdminToModules
{
    using Core.Constants;
    using Core.Facades;
    using Core.Pages.AdministrationPage;
    using Core.Pages.CoursesAndLecturesPage;
    using Core.Pages.GroupsPage;
    using Core.Pages.HomeworkPage;
    using Core.Pages.StudentsInCoursesPage;
    using Core.Pages.StudentsStatisticsPage;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;

    [TestClass]
    public class LinksFromAdminToModulesTests : BaseTest
    {
        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.LinksFromAdminToModules)]
        public void VerifyGroupsPageIsOpen()
        {
            GroupsFacade groupsFacade = new GroupsFacade();
            AdministrationFacade adminFacade = new AdministrationFacade();

            adminFacade.OpenGroupsPageButton();

            groupsFacade.AssertGroupsPageIsOpen();
        }

        [TestMethod,
        Priority(Priority.High),
        Owner(Owner.Plamen),
        TestCategory(Category.LinksFromAdminToModules)]
        public void VerifyCoursesUnenrolledStudentsPageIsOpen()
        {
            CoursesUnenrolledStudentsFacade coursesUnenrolledStudentsFacade = new CoursesUnenrolledStudentsFacade();
            AdministrationFacade adminFacade = new AdministrationFacade();

            adminFacade.OpenCoursesUnenrolledStudentsPageButton();

            coursesUnenrolledStudentsFacade.AssertCoursesUnenrolledStudentsPageIsOpen();
        }

        [TestMethod,
         Priority(Priority.High),
         Owner(Owner.Plamen),
         TestCategory(Category.LinksFromAdminToModules)]
        public void VerifyStudentsStatisticsPageIsOpen()
        {
            StudentsStatisticsFacade studentsStatisticsFacade = new StudentsStatisticsFacade();
            AdministrationFacade adminFacade = new AdministrationFacade();

            adminFacade.OpenStudentsStatisticsButton();

            studentsStatisticsFacade.AssertStudentsStatisticsPageIsOpen();
        }

        [TestMethod,
        Priority(Priority.Medium),
        Owner(Owner.Biser),
        TestCategory(Category.Homework)]
        public void AssertHomeworkPageIsOpen()
        {
            HomeworkFacade homeworkFacade = new HomeworkFacade();
            homeworkFacade.OpenHomeworkPage();
            homeworkFacade.AssertHomeworkPageIsOpen();
        }

        [TestMethod,
        Priority(Priority.Medium),
        Owner(Owner.Dushka),
        TestCategory(Category.StudentsInCourses)]
        public void VerifyStudentssInCoursesPageIsOpen()
        {
            AdministrationPage.Instance.ClickStudentsInCourseLink();
            StudentsInCoursesPage.Instance.AssertStudentInCoursesPageIsOpen();
        }

        ////Expected to fail
        [TestMethod,
        Priority(Priority.Medium),
        Owner(Owner.Dushka),
        TestCategory(Category.CoursesAndLectures)]
        public void VerifyCoursesAndLecturesPageIsOpen()
        {
            AdministrationPage.Instance.ClickCoursesAndLecturesLink();
            CoursesAndLecturesPage.Instance.AssertCoursesAndLecturesUrlIsOpen();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyManualNavigateToCategoriesPage()
        {
            CategoryFacade facade = new CategoryFacade();

            facade.ManualNavigate();

            facade.AssertCategoryPageIsOpen();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyManualNavigateToInstancesPage()
        {
            InstanceFacade facade = new InstanceFacade();

            facade.ManualNavigate();

            facade.AssertInstancePageIsOpen();
        }
    }
}