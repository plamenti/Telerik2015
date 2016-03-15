namespace TelerikAcademyLearningSystem.Core.Pages.AdministrationPage
{
    using Base;
    using Constants;

    public partial class AdministrationPage : BasePage<AdministrationPage>
    {
        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.Admin);
            this.Browser.RefreshDomTree();
        }

        public void ClickCategoryLink()
        {
            this.CategoryButton.ScrollToVisible();
            this.CategoryButton.Click(false);
        }

        public void ClickInstanceLink()
        {
            this.InstanceButton.ScrollToVisible();
            this.InstanceButton.Click(false);
        }

        public void ClickCoursesAndLecturesLink()
        {
            this.Navigate();
            this.CoursesAndLecturesLink.ScrollToVisible();
            this.CoursesAndLecturesLink.MouseClick();
            this.Browser.RefreshDomTree();
        }

        public void ClickStudentsInCourseLink()
        {
            this.Navigate();
            this.StudentsInCoursesLink.ScrollToVisible();
            this.StudentsInCoursesLink.MouseClick();
            this.Browser.RefreshDomTree();
        }
    }
}
