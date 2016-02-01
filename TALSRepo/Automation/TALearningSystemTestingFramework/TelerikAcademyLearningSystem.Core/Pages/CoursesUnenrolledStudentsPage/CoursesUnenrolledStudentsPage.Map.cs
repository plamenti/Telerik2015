namespace TelerikAcademyLearningSystem.Core.Pages.CoursesUnenrolledStudentsPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using GridPages;

    public partial class CoursesUnenrolledStudentsPage
    {
        public string PageTitle
        {
            get
            {
                return this.Browser.PageTitle;
            }
        }

        public string GridTitle
        {
            get
            {
                return this.Browser.PageTitle;
            }
        }

        public GridPage GridPage
        {
            get
            {
                return new GridPage();
            }
        }

        public HtmlAnchor ExportToExcelButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("export");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=~Administration");
            }
        }

        public HtmlInputRadioButton LiveAndOnlineRadioButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputRadioButton>("value=all");
            }
        }

        public HtmlInputRadioButton LiveRadioButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputRadioButton>("value=live");
            }
        }

        public HtmlInputRadioButton OnlineRadioButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputRadioButton>("value=online");
            }
        }

        public HtmlTable UnenrolledStudentsGrid
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlTable>("role=grid");
            }
        }

        public HtmlInputText UsernameToFilter
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("UsernameToFilter");
            }
        }

        public HtmlSpan CoursesDropDownArrow
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlSpan>("//*[contains(@class, 'k-dropdown-wrap k-state-default')]/span[contains(@class,'k-select')]/span[contains(@class,'k-icon k-i-arrow-s')]");
            }
        }

        public HtmlInputText SelectCourseField
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputText>("class=k-input", "placeholder=Избери курс...");
            }
        }

        public Element Body
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.AllByTagName("body")[0];
            }
        }

        public HtmlListItem FindCourseByName(string courseName)
        {
            string xpath = @"//*[@id='CourseInstanceIdToFilter_listbox']/li[text()='" + courseName + "']" + '"';

            return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlListItem>(xpath);
        }
    }
}