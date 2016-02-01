namespace TelerikAcademyLearningSystem.Core.Pages.AdministrationPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;

    public partial class AdministrationPage
    {
        public string Title
        {
            get { return this.Browser.PageTitle; }
        }

        public HtmlContainerControl MainHeader
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlContainerControl>("//*[@id='MainContent']/div/h1");
            }
        }

        public HtmlAnchor CategoryButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlAnchor>("//*[@id='MainContent']/div/a[28]");
            }
        }

        public HtmlAnchor InstanceButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlAnchor>("//*[@id='MainContent']/div/a[27]");
            }
        }

        public HtmlControl StudentsInCoursesLink
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlControl>("//*[@id='MainContent']/div/a[30]");
            }
        }
    
        public HtmlControl CoursesAndLecturesLink
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlControl>("//*[@id='MainContent']/div/a[27]");
            }
        }

        public HtmlControl CoursesInstanceAndLectures
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlControl>("//*[@id='MainContent']/div/a[33]");
            }
        }

        public HtmlAnchor Groups
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByContent<HtmlAnchor>("l:Групи");
            }
        }

        public HtmlAnchor StudentsStatistics
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByContent<HtmlAnchor>("l:Статистики за студентите");
            }
        }

        public HtmlAnchor CoursesUnenrolledStudents
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByContent<HtmlAnchor>("l:Отписани студенти от курсове");
            }
        }
    }
}