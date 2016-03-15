namespace TALS.TestingFramework.Core.Pages.LoginPanelPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class LoginPanelPage
    {
        public string Title
        {
            get { return this.ActiveBrowser.PageTitle; }
        }

        public HtmlAnchor LogInButton
        {
            get
            {
                return Find.ById<HtmlAnchor>("EntranceButton");
            }
        }

        public HtmlAnchor FacebookLogInButton
        {
            get
            {
                return Find.ById<HtmlAnchor>("FbLogin");
            }
        }

        public HtmlAnchor LogOutButton
        {
            get
            {
                return Find.ById<HtmlAnchor>("ExitMI");
            }
        }
    }
}