namespace TelerikAcademyLearningSystem.Tests.AdminPanel.StudentsInCourses.AddEditStudentInCourse
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TALearningSystemTestingFramework.Core.AttributeConstants;
    using TALearningSystemTestingFramework.Core.Base;
    using TelerikAcademyLearningSystem.Core.Facades;
    using TelerikAcademyLearningSystem.Core.Model;
    using TelerikAcademyLearningSystem.Core.Pages.StudentsInCoursesPage;
    using TelerikAcademyLearningSystem.Core.Pages.StudentsInCoursesPage.StudentsInCoursesFormPage;

    [TestClass]
    public class AddStusentncourseTest : BaseTest
    {
        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.StudentsInCourses)]
        public void VerifyStudentinCourseIsAddedWithValidData()
        {
            Student student = new Student("testUser1", "Giant Test Course", true, true, true, "Не");
            StudentInCourseFacade newStudentInCourse = new StudentInCourseFacade();
            newStudentInCourse.Add(student);
            newStudentInCourse.AssertNewUserInCourseIsCreated(student);
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.StudentsInCourses)]
        public void VerifyUserNameRequiredFieldsValidationMessage()
        {
            StudentInCourseFacade newStudentInCourse = new StudentInCourseFacade();
            newStudentInCourse.AddEmptyForm();
            newStudentInCourse.AssertUserNameRequiredFieldValidationMessages();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.StudentsInCourses)]
        public void VerifyCourseInstanceRequiredFieldValidationMessage()
        {
            Student student = new Student("testUser1", string.Empty);
            StudentInCourseFacade newStudentInCourse = new StudentInCourseFacade();
            newStudentInCourse.Add(student);
            newStudentInCourse.AssertCourseInstanceRequiredFieldValidationMessages();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.StudentsInCourses)]
        public void VerifyEnrolledStudentValidationMessage()
        {
            Student student = new Student("testUser1", "Giant Test Course");
            StudentInCourseFacade newStudentInCourse = new StudentInCourseFacade();
            newStudentInCourse.AddTwice(student);
            newStudentInCourse.AssertEnrolledStudentValidationMessages();
        }

        [TestMethod,
        Priority(Priority.VeryHigh),
        Owner(Owner.Dushka),
        TestCategory(Category.StudentsInCourses)]
        public void VerifyUnenrolledStudentValidationMessage()
        {
            StudentInCourseFacade newStudentInCourse = new StudentInCourseFacade();
            Student unenroledStudent = newStudentInCourse.GetUnenrolledStudent();
            newStudentInCourse.Add(unenroledStudent);
            newStudentInCourse.AssertUnEnrolledStudentValidationMessages();
        }

        [TestMethod,
       Priority(Priority.VeryHigh),
       Owner(Owner.Dushka),
       TestCategory(Category.StudentsInCourses)]
        public void VerifyNotExistingStudentValidationMessage()
        {
            StudentInCourseFacade newStudentInCourse = new StudentInCourseFacade();
            Student notExistingStudent = new Student("aaaa", "Giant Test Course");
            newStudentInCourse.Add(notExistingStudent);
            newStudentInCourse.AssertNotExistingStudentValidationMessages();
        }
    }
}