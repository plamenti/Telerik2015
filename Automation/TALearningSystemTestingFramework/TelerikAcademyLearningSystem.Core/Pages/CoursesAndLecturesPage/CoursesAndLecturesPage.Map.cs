namespace TelerikAcademyLearningSystem.Core.Pages.CoursesAndLecturesPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using GridPages;
  
    public partial class CoursesAndLecturesPage
    {
        public GridPage GridPage
        {
            get
            {
                return GridPage.Instance;
            }
        }

        internal string Title
        {
            get { return this.Browser.PageTitle; }
        }

        internal string GridTitle
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.AllByAttributes("h2").FirstOrDefault().InnerText;
            }
        }

        internal HtmlAnchor CreateCourseButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add");
            }
        }

        internal HtmlAnchor BackToAdminButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=/Administration/Navigation");
            }
        }

        internal HtmlDiv PopUp
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlDiv>("class=k-edit-form-container");
            }
        }

        internal HtmlAnchor CourseRequirmensGridButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=?editCourseRequirements");
            }
        }

        internal HtmlAnchor EditGridButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=?edit");
            }
        }

        internal HtmlAnchor DeliteGridButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=?delete");
            }
        }
    }
}
