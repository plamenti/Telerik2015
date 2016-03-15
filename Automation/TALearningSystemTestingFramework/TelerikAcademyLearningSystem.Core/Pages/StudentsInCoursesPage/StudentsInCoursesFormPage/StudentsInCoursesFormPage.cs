namespace TelerikAcademyLearningSystem.Core.Pages.StudentsInCoursesPage.StudentsInCoursesFormPage
{
    using System.Threading;
    using System.Windows.Forms;
    using Base;
    using Model;

    internal partial class StudentsInCoursesFormPage : BasePage<StudentsInCoursesFormPage>
    {
        public override void Navigate()
        {
            StudentsInCoursesPage.Instance.OpenStudentsInCourseForm();
        }

        internal void FillData(Student student)
        {
            this.UserName.Click();
            this.Browser.Desktop.KeyBoard.TypeText(student.UserName);
            Thread.Sleep(1000);
            var a = student.Course;
            if (student.Course != string.Empty)
            {
                this.AllCourses.MouseClick();
                Thread.Sleep(1000);
                var course = this.Course(student.Course);
                course.MouseClick();
            }

            Thread.Sleep(1000);
            if (student.IsLiveParticipant)
            {
                this.LiveParticipant.MouseClick();
            }

            if (student.CanDoPracticalExam)
            {
                this.PracticalExam.MouseClick();
            }

            if (student.CanDoTestExam)
            {
                this.TestExam.MouseClick();
            }

            if (student.Accommodation != null)
            {
                this.Accommodation.MouseClick();
                var accomodation = this.AccommodationOption(student.Accommodation);
                accomodation.Click();
                this.Browser.Desktop.KeyBoard.KeyPress(Keys.Enter);
                this.Browser.RefreshDomTree();
            }
        }
    }
}