namespace TelerikAcademyLearningSystem.Core.Pages.KidsAcademyRegistrationChoicePage
{
    using Base;
    using Constants;

    public partial class KidsAcademyRegistrationChoicePage : BasePage<KidsAcademyRegistrationChoicePage>
    {
        ////private string url = @"http://stage.telerikacademy.com/KidsAcademy/Registration";
        ////
        ////public string Url
        ////{
        ////    get
        ////    {
        ////        return this.url;
        ////    }
        ////}

        public override void Navigate()
        {
            this.Browser.NavigateTo(UrlLink.KidsAcademyRegistrationChoice);
        }
    }
}
