namespace TALS.TestingFramework.Core.Facades
{
    using TALS.TestingFramework.Core.Pages.StudentsStatisticPage;

    public class StudentsStatisticsFacade
    {
        private StudentsStatisticsPage studentsStatisticsPage;

        public StudentsStatisticsFacade()
        {
            this.studentsStatisticsPage = new StudentsStatisticsPage();
        }

        public void VerifyStudentsStatisticsPage()
        {
            this.studentsStatisticsPage.Navigate();
            this.studentsStatisticsPage.Asserter.DoAssert();
        }
    }
}