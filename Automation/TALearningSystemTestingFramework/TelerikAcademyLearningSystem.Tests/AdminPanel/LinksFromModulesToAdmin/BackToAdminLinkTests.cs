namespace TelerikAcademyLearningSystem.Tests.AdminPanel.LinksFromModulesToAdmin
{
    using Core.Facades;
    using Core.Pages.AdministrationPage;
    using Core.Pages.CoursesAndLecturesPage;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;

    [TestClass]
    public class BackToAdminLinkTests : BaseTest
    {
        private AdministrationFacade adminFacade;

        public override void TestInit()
        {
            base.TestInit();
            this.adminFacade = new AdministrationFacade();
        }

        ////TODO
        [TestMethod,
        Priority(Priority.Medium),
        Owner(Owner.Dushka),
        TestCategory(Category.StudentsInCourses)]
        public void VerifyAdministrationPageiOpenFromLinkUsersInCourses()
        {
            StudentInCourseFacade usersIncourseFacade = new StudentInCourseFacade();
            usersIncourseFacade.GoBackToAdminPage();
            this.adminFacade.VerifyPageIsOpen();
        }

        [TestMethod,
        Priority(Priority.Medium),
        Owner(Owner.Dushka),
        TestCategory(Category.StudentsInCourses)]
        public void VerifyAdministrationPageiOpenFromLinkCoursesAndLectures()
        {
            CoursesAndLecturesPage.Instance.GoBackToAdminPage();
            this.adminFacade.VerifyPageIsOpen();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Categories)]
        public void VerifyManualNavigateFromCategoryPageToAdmin()
        {
            CategoryFacade facade = new CategoryFacade();

            facade.GoBackToAdminPage();

            this.adminFacade.VerifyPageIsOpen();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Ventsi),
         TestCategory(Category.Instances)]
        public void VerifyManualNavigateFromInstancesPageToAdmin()
        {
            InstanceFacade facade = new InstanceFacade();

            facade.GoBackToAdminPage();

            this.adminFacade.VerifyPageIsOpen();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Plamen),
         TestCategory(Category.CoursesUnenrolledStudents)]
        public void VerifyAdministrationPageFromCoursesUnenrolledStudentsIsOpen()
        {
            CoursesUnenrolledStudentsFacade coursesUnenrolledStudentsFacade = new CoursesUnenrolledStudentsFacade();

            coursesUnenrolledStudentsFacade.BackToAdministration();

            this.adminFacade.VerifyPageIsOpen();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Plamen),
         TestCategory(Category.Groups)]
        public void VerifyAdministrationPageFromGroupsIsOpen()
        {
            GroupsFacade groupsFacade = new GroupsFacade();

            groupsFacade.BackToAdministration();

            this.adminFacade.VerifyPageIsOpen();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Plamen),
         TestCategory(Category.StudentsStatistics)]
        public void VerifyAdministrationPageFromStudentsStatisticsIsOpen()
        {
            StudentsStatisticsFacade studentsStatisticsFacade = new StudentsStatisticsFacade();

            studentsStatisticsFacade.BackToAdministration();

            this.adminFacade.VerifyPageIsOpen();
        }

        [TestMethod,
         Priority(Priority.VeryHigh),
         Owner(Owner.Blagoy),
         TestCategory(Category.StudentsStatisticsByAge)]
        public void VerifyAdministrationPageFromStudentsStatisticsByAgeIsOpen()
        {
            StudentsStatisticsByAgeFacade studentsStatisticsByAgeFacade = new StudentsStatisticsByAgeFacade();

            studentsStatisticsByAgeFacade.BackToAdministration();

            this.adminFacade.VerifyPageIsOpen();
        }
    }
}