namespace TALS.TestingFramework.Core.Pages.CourseFormPage
{
    using Base;

    public partial class CourseFormPage : BasePage
    {
        public CourseFormPage()
        {
            this.Asserter = new CourseFormPageAsserter(this);
        }


        public void FillCourseInformation(string nameBG, string url, string description, string nameEn = null, string color = null, string order = "0")
        {
            this.NameBg.Text = nameBG;
            this.NameEn.Text = nameEn;
            this.UrlName.Text = url;
            //this.Description = description;
            this.NameEn.Text = nameEn;
            this.Color.Text = color;
            this.Order.Text = order;
        }
    }
}
