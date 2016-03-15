namespace TALS.TestingFramework.Core.Pages.InstancePage
{
    using TALS.TestingFramework.Core.Base;

    public partial class InstancePage : BasePage
    {
        private const string Url = @"http://stage.telerikacademy.com/Administration_Courses/CoursesInstancesAndLectures";

        public InstancePage()
        {
            this.Asserter = new InstancePageAsserter(this);
        }

        public override void Navigate()
        {
            ActiveBrowser.NavigateTo(Url);
        }

        public void CreateNewInstance()
        {
            this.Navigate();
            this.SearchInstance.Text = "52525522552525525252";
            this.CreateInstanceButton.Wait.ForExists(1000);
            this.CreateInstanceButton.Click();
        }
    }
}