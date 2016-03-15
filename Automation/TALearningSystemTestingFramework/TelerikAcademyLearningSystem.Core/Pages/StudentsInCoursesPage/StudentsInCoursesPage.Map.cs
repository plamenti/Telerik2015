namespace TelerikAcademyLearningSystem.Core.Pages.StudentsInCoursesPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using GridPages;

    public partial class StudentsInCoursesPage
    {
        internal string PageTitle
        {
            get { return this.Browser.PageTitle; }
        }

        internal string GridTitle
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.AllByTagName("h1").FirstOrDefault().InnerText;
            }
        }

        internal HtmlInputControl FilterByCourseName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputControl>("class=k-input");
            }
        }

        internal HtmlControl DropdownButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.AllByExpression<HtmlControl>("tagname=span", "class=k-select").FirstOrDefault();
            }
        }

        internal HtmlInputControl FilterbyUserName
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputControl>("UsernameToFilter");
            }
        }

        internal HtmlInputRadioButton LiveAndOnlineRadioButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputRadioButton>("all");
            }
        }

        internal HtmlInputRadioButton LiveRadioButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputRadioButton>("live");
            }
        }

        internal HtmlInputRadioButton OnlineRadioButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputRadioButton>("online");
            }
        }

        internal HtmlAnchor EnrollStudentButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-add");
            }
        }

        internal HtmlAnchor AllowHelpedByEvaluationButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("AllowHelpedByEvaluation");
            }
        }

        internal HtmlAnchor AllowPracticalExamButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("AllowPracticalExam");
            }
        }

        internal HtmlAnchor AllowTestExamButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("AllowTestExam");
            }
        }

        internal HtmlAnchor AllowCourseInstanceEvaluationButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("AllowCourseInstanceEvaluation");
            }
        }

        internal HtmlAnchor ExportToExcelButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("export");
            }
        }

        internal HtmlAnchor BackToAdminButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=/Administration/Navigation");
            }
        }

        internal HtmlAnchor SendTeamworkInvitationButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("SendTeamworkInvitation");
            }
        }

        internal HtmlDiv PopUp
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlDiv>("class=k-widget k-window", "data-role=draggable");
            }
        }

        internal GridPage GridPage
        {
            get
            {
                return GridPage.Instance;
            }
        }

        internal HtmlAnchor EditGridButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=?edit");
            }
        }

        internal HtmlAnchor DeliteGridButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=?delete");
            }
        }
    }
}