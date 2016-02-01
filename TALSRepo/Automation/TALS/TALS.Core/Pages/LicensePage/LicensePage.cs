namespace TALS.TestingFramework.Core.Pages.LicensePage
{
    using TALS.TestingFramework.Core.Base;

    public partial class LicensePage : BasePage
    {
        private const string Url = @"http://stage.telerikacademy.com/Administration_Courses/CourseLicenses";

        public LicensePage()
        {
            this.Asserter = new LicensePageAsserter(this);
        }

        public override void Navigate()
        {
            ActiveBrowser.NavigateTo(Url);
        }

    }
}
