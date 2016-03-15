namespace TALS.TestingFramework.Core.Pages.CoursesAndLecturesPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class CoursesAndLecturesPage
    {
        public string Title
        {
            get { return this.ActiveBrowser.PageTitle; }
        }

        public HtmlAnchor CreateCourseButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button");
            }
        }

        public HtmlDiv PopUp
        {
            get
            {
                return Find.ByExpression<HtmlDiv>("class=k-edit-form-container");
            }
        }

        public HtmlTable GridTable
        {
            get
            {
                return Find.ByExpression<HtmlTable>("tagname=table", "role=treegrid");
            }
        }

        public HtmlAnchor CourseRequirmensGridButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=?editCourseRequirements");
            }
        }

        public HtmlAnchor EditGridButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=?edit");
            }
        }

        public HtmlAnchor DeliteGridButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=?delete");
            }
        }
    }
}
