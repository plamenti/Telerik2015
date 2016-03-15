namespace TelerikAcademyLearningSystem.Core.Pages.HomeworkPage.AddHomeworkPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;

    public partial class AddHomeworkPage
    {
        public string Title
        {
            get { return this.Browser.PageTitle; }
        }

        public HtmlControl Header
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlControl>("//*[@id='MainContent']/div/h1");
            }
        }

        public HtmlInputText CourseNameInput
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputText>("aria-owns=CourseInstanceId_listbox");
            }
        }

        public HtmlControl CourseNameLabel
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlControl>("tagname=label", "for=CourseInstanceId");
            }
        }

        public HtmlSpan LectureNameInput
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("tagname=span", "class=k-input");
            }
        }

        public HtmlListItem LectureNameLi
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByContent<HtmlListItem>("Алгоритми за сортиране и търсене");
            }
        }

        public HtmlControl LectureNameLabel
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlControl>("tagname=label", "for=LectureId");
            }
        }

        public HtmlInputText UserNameInput
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputText>("Username");
            }
        }

        public HtmlControl UserNameLabel
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlControl>("tagname=label", "for=Username");
            }
        }

        public HtmlInputText MarkInput
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputText>("class=k-formatted-value k-input");
            }
        }

        public HtmlControl MarkLabel
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlControl>("tagname=label", "for=Mark");
            }
        }

        public HtmlInputCheckBox EvaluationCheckbox
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputCheckBox>("IsSelectedForEvaluation");
            }
        }

        public Element EvaluationCheckboxLabel
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression("tagname=label", "for=IsSelectedForEvaluation");
            }
        }

        public HtmlDiv UploadFileButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlDiv>("class=k-button k-upload-button");
            }
        }

        public HtmlInputFile UploadFileInput
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputFile>("HomeworkFile");
            }
        }

        public HtmlDiv HomeworkFileLabel
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByXPath<HtmlDiv>("//*[@id='MainContent']/div/form/fieldset/div[11]");
            }
        }

        public HtmlInputSubmit SubmitButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputSubmit>("type=submit", "value=Създаване");
            }
        }

        public HtmlAnchor BackToAllHomeworksButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("href=/Administration_Courses/Homework");
            }
        }

        public HtmlSpan UserNameErrorMessage
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=Username-error"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ById<HtmlSpan>("Username-error");
            }
        }

        public HtmlSpan CourseNameErrorMessage
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("data-valmsg-for=CourseInstanceId"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("data-valmsg-for=CourseInstanceId");
            }
        }

        public HtmlSpan LectureNameErrorMessage
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("data-valmsg-for=LectureId"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("data-valmsg-for=LectureId");
            }
        }

        public HtmlSpan HomeworkErrorMessage
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("data-valmsg-for=HomeworkFile"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlSpan>("data-valmsg-for=HomeworkFile");
            }
        }

        private HtmlListItem LocateLiByContent(string content)
        {
            this.Browser.WaitForElement(new HtmlFindExpression("class=k-list-scroller"), 30000, false);
            var el = Manager.Current.ActiveBrowser.Find.ByExpression<HtmlDiv>("class=k-list-scroller");
            this.Browser.WaitForElement(new HtmlFindExpression("innerText=" + content), 30000, false);
            return Manager.Current.ActiveBrowser.Find.ByContent<HtmlListItem>(content);
        }
    }
}
