namespace TelerikAcademyLearningSystem.Core.Pages.LicensesPage.AddLicensePage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class AddLicensePage
    {
        public HtmlSpan Header
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("class=k-window-title");
            }
        }

        public HtmlInputText LicenseName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlInputText LicenseUrl
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("ImageUrl");
            }
        }

        public HtmlInputText LicenseLink
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("Link");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlAnchor CancelButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-cancel");
            }
        }

        public HtmlDiv LicenseNameWarningMessage
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=Name_validationMessage"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("Name_validationMessage");
                ////return element.Find.ByExpression<HtmlSpan>("class=k-icon k-warning");
            }
        }

        public HtmlDiv LicenseUrlWarningMessage
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=ImageUrl_validationMessage"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("ImageUrl_validationMessage");
            }
        }

        public HtmlDiv LicenseLinkWarningMessage
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=Link_validationMessage"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("Link_validationMessage");
            }
        }
    }
}
