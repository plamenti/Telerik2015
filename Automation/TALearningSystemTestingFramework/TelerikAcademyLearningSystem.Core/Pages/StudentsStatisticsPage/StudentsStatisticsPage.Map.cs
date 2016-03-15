namespace TelerikAcademyLearningSystem.Core.Pages.StudentsStatisticsPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;

    public partial class StudentsStatisticsPage
    {
        public string Title
        {
            get
            {
                return this.Browser.PageTitle;
            }
        }

        public HtmlInputRadioButton LiveAndOnlineRadioButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputRadioButton>("LiveAndOnline");
            }
        }

        public HtmlInputRadioButton LiveRadioButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputRadioButton>("Live");
            }
        }

        public HtmlInputRadioButton OnlineRadioButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputRadioButton>("Online");
            }
        }

        public HtmlInputText CourseFilter
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByName<HtmlInputText>("CourseFilter_input");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=~Administration");
            }
        }

        public HtmlContainerControl MainContent
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlContainerControl>("MainContent");
            }
        }

        public HtmlDiv Statistics
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("Statistics");
            }
        }

        public HtmlDiv ExamStatisticChart
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("ExamStatisticChart");
            }
        }

        public HtmlDiv UniversitiesStatisticsChart
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("UniversitiesStatisticsChart");
            }
        }

        public HtmlDiv CitiesStatisticsChart
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("CitiesStatisticsChart");
            }
        }

        public HtmlDiv GenderStatisticsChart
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("GenderStatisticsChart");
            }
        }

        public HtmlDiv YearOfBirthStatisticsChart
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("YearOfBirthStatisticsChart");
            }
        }

        public HtmlDiv YearOfBirthStatisticsChartBars
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("YearOfBirthStatisticsChartBars");
            }
        }

        public Element TotalStudentsInCourseHeader
        {
            get
            {
                return this.Statistics.Find.ByExpression("innerText=~Общо студенти в избранания курс и форма на обучение:");
            }
        }
    }
}