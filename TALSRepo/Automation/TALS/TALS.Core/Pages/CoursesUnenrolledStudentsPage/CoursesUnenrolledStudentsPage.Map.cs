namespace TALS.TestingFramework.Core.Pages.CoursesUnenrolledStudentsPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class CoursesUnenrolledStudentsPage
    {
        public string Title
        {
            get
            {
                return this.ActiveBrowser.PageTitle;
            }
        }

        public HtmlAnchor ExportToExcelButton
        {
            get
            {
                return Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button",
                    "href=~Administration");
            }
        }

        public HtmlInputRadioButton LiveAndOnlineRadioButton
        {
            get
            {
                return Find.ByExpression<HtmlInputRadioButton>("value=all");
            }
        }

        public HtmlInputRadioButton LiveRadioButton
        {
            get
            {
                return Find.ByExpression<HtmlInputRadioButton>("value=live");
            }
        }

        public HtmlInputRadioButton OnlineRadioButton
        {
            get
            {
                return Find.ByExpression<HtmlInputRadioButton>("value=online");
            }
        }

        public HtmlTable UnenrolledStudentsGrid
        {
            get
            {
                return Find.ByExpression<HtmlTable>("role=grid");
            }
        }
    }
}