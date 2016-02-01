namespace TALS.TestingFramework.Core.Pages.StudentsStatisticPage
{
    using TALS.TestingFramework.Core.Base;

    public partial class StudentsStatisticsPage : BasePage
    {
        private const string Url = @"http://stage.telerikacademy.com/Administration_Courses/CourseInstancesStatistics";

        public StudentsStatisticsPage()
        {
            this.Asserter = new StudentsStatisticsPageAsserter(this);
        }

        public override void Navigate()
        {
            ActiveBrowser.NavigateTo(Url);
        }
    }
}