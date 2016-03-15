namespace TALS.TestingFramework.Core.Pages.LicensePage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class LicensePage
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

        public HtmlAnchor AddLicenseButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add", "href=/Administration_Courses/CourseLicenses/Read?DataGrid-mode=insert");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=/Administration/Navigation");
            }
        }

        public HtmlSpan PopUpTitle
        {
            get
            {
                return Find.ByExpression<HtmlSpan>("class=k-window-title");
            }
        }

        public HtmlInputText LicenseName
        {
            get
            {
                return Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlInputText LicenseUrl
        {
            get
            {
                return Find.ById<HtmlInputText>("ImageUrl");
            }
        }


        public HtmlInputText LicenseLink
        {
            get
            {
                return Find.ById<HtmlInputText>("Link");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update", "href=#");
            }
        }

        public HtmlTable LicenseGrid
        {
            get
            {
                return Find.ByExpression<HtmlTable>("role=grid");
            }
        }


        //public void GridCell
        //{
        //    get
        //    {
        //        Find.AllByAttributes("role=gridcell");
        //    }
        //}
    }
}
