namespace TelerikAcademyLearningSystem.Core.Pages.LoginPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    
    public partial class LoginPage
    {
        public HtmlAnchor LogOutButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("ExitMI");
            }
        }

        public HtmlAnchor EntranceButton
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=EntranceButton"), 3000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("EntranceButton");
            }
        }

        public string Title
        {
            get
            {
                return Manager.Current.ActiveBrowser.PageTitle;
            }
        }

        public HtmlInputText UsernameOrEmail
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("UsernameOrEmail");
            }
        }

        public HtmlInputPassword Password
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputPassword>("Password");
            }
        }

        public HtmlInputControl EntryButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputControl>("class=btn btn-success pull-left");
            }
        }
    }
}