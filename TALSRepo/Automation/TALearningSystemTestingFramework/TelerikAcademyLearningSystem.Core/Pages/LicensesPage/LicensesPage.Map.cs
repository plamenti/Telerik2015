namespace TelerikAcademyLearningSystem.Core.Pages.LicensesPage
{
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using TelerikAcademyLearningSystem.Core.Pages.GridPages;

    public partial class LicensesPage
    {
        public string Title
        {
            get
            {
                return this.Browser.PageTitle;
            }
        }

        public Element Header
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("class=container").Find.AllByTagName("h1")[0];
            }
        }

        public HtmlButton ExportToExcellButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlButton>("class=k-button k-button-icontext k-grid-excel", "type=button");
            }
        }

        public HtmlButton ExportToPdfButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlButton>("class=k-button k-button-icontext k-grid-pdf");
            }
        }

        public HtmlAnchor AddLicenseButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add", "href=/Administration_Courses/CourseLicenses/Read?DataGrid-mode=insert");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=/Administration/Navigation");
            }
        }

        public GridPage GridPage
        {
            get
            {
                return new GridPage();
            }
        }

        public HtmlDiv PopUp
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("class=k-edit-form-container"), 30000, false);

                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlDiv>("class=k-edit-form-container");
            }
        }

        public HtmlAnchor DeleteRowButton(int rowIndex)
        {
            return this.GridPage.GridTable.BodyRows[rowIndex].Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-delete");
        }

        public IList<HtmlTableCell> TableDataCell(int rowindex)
        {
            return this.GridPage.GridTable.BodyRows[rowindex].Find.AllByTagName<HtmlTableCell>("td");
        }
    }
}
