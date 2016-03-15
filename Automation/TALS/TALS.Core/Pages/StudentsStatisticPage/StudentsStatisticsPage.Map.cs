namespace TALS.TestingFramework.Core.Pages.StudentsStatisticPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;

    public partial class StudentsStatisticsPage
    {
        public string Title
        {
            get
            {
                return this.ActiveBrowser.PageTitle;
            }
        }

        public HtmlInputRadioButton LiveAndOnlineRadioButton
        {
            get
            {
                return Find.ById<HtmlInputRadioButton>("LiveAndOnline");
            }
        }

        public HtmlInputRadioButton LiveRadioButton
        {
            get
            {
                return Find.ById<HtmlInputRadioButton>("Live");
            }
        }

        public HtmlInputRadioButton OnlineRadioButton
        {
            get
            {
                return Find.ById<HtmlInputRadioButton>("Online");
            }
        }

        public HtmlInputText CourseFilter
        {
            get
            {
                return Find.ByName<HtmlInputText>("CourseFilter_input");
            }
        }

        public HtmlAnchor BackToAdminButton
        {
            get
            {
                //return Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button",
                //    "href=~Administration");
                return null;
            }
        }
    }
}