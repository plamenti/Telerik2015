namespace TelerikAcademyLearningSystem.Core.Pages.KidsAcademyRegistrationChoicePage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class KidsAcademyRegistrationChoicePage
    {
        public string CurrentTitle
        {
            get
            {
                return Browser.PageTitle;
            }
        }

        public string CurrentUrl
        {
            get
            {
                return Browser.Url;
            }
        }

        public HtmlAnchor FirstRegistrationLink
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("href=/KidsAcademy/Registration/2/Sofia");
            }
        }

        public HtmlAnchor SecondRegistrationLink
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("href=/KidsAcademy/Registration/3/Sofia");
            }
        }

        public HtmlAnchor ThirdRegistrationLink
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("href=/KidsAcademy/Registration/7/Sofia");
            }
        }

        public HtmlAnchor ExistingAccountRegistration
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("href=/KidsAcademy/Registration/ExistingAccount");
            }
        }
    }
}
