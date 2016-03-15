namespace TALS.TestingFramework.Core.Pages.GroupsPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class GroupsPage
    {
        public string Title
        {
            get { return this.ActiveBrowser.PageTitle; }
        }

        public HtmlAnchor CreateGroupButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add", "href=~CoursesGroups");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=~Administration");
            }
        }
    }
}