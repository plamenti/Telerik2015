namespace TALS.TestingFramework.Core.Pages.Login
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class LoginPage
    {
        public string Title
        {
            get { return this.ActiveBrowser.PageTitle; }
        }

        public HtmlInputText UsernameOrEmail
        {
            get
            {
                return Find.ById<HtmlInputText>("UsernameOrEmail");
            }
        }

        public HtmlInputPassword Password
        {
            get
            {
                return Find.ById<HtmlInputPassword>("Password");
            }
        }

        public HtmlInputControl EntryButton
        {
            get
            {
                return Find.ByExpression<HtmlInputControl>("class=btn btn-success pull-left");
            }
        }
    }
}