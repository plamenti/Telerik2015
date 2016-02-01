namespace TALS.TestingFramework.Core.Pages.HomeworkPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class HomeworkPage
    {
        public string Title
        {
            get { return this.ActiveBrowser.PageTitle; }
        }

        public HtmlButton ExportToExcellButton
        {
            get
            {
                return Find.ByExpression<HtmlButton>("class=k-button k-button-icontext k-grid-excel", "type=button");
            }
        }

        public HtmlButton ExportToPdfButton
        {
            get
            {
                return Find.ByExpression<HtmlButton>("class=k-button k-button-icontext k-grid-pdf");
            }
        }

        public HtmlAnchor AddHomeworkButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext", "href=/Administration_Courses/Homework/Create");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=/Administration/Navigation");
            }
        }

    }
}
