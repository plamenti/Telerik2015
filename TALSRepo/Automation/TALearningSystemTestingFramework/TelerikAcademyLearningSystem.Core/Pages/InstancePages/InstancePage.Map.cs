namespace TelerikAcademyLearningSystem.Core.Pages.InstancePages
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using GridPages;

    public partial class InstancePage
    {
        public string Title
        {
            get
            {
                return this.Browser.PageTitle;
            }
        }

        public HtmlContainerControl Header
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlContainerControl>("//*[@id='MainContent']/div/h1");
            }
        }

        public HtmlAnchor Add
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=?k-grid-add");
            }
        }

        public HtmlControl CreateNewCourseButton
        {
            get
            {
                ////return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlControl>("class=k-button k-button-icontext k-grid-add");
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlControl>("//*[@id=\"DataGrid\"]/div[1]/a[2]");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=~Administration");
            }
        }

        public HtmlAnchor BackToAdmin
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("href=/Administration/Navigation");
            }
        }

        public HtmlButton ExportExcel
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlButton>("class=?k-grid-excel");
            }
        }

        public HtmlButton ExportPdf
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlButton>("class=?k-grid-pdf");
            }
        }

        public GridPage GridPage
        {
            get
            {
                return new GridPage();
            }
        }
    }
}
