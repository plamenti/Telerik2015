namespace TelerikAcademyLearningSystem.Core.Pages.HomeworkPage
{
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using GridPages;

    public partial class HomeworkPage
    {
        public string Title
        {
            get 
            { 
                return this.Browser.PageTitle;
            }
        }

        public Element Header
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlDiv>("class=container").Find.AllByTagName("h1")[0];
            }
        }

        public HtmlButton ExportToExcellButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlButton>("class=k-button k-button-icontext k-grid-excel", "type=button");
            }
        }

        public HtmlButton ExportToPdfButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlButton>("class=k-button k-button-icontext k-grid-pdf");
            }
        }

        public HtmlAnchor AddHomeworkButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext", "href=/Administration_Courses/Homework/Create");
            }
        }

        public HtmlAnchor BackToAdministrationButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-custom-toolbar-button", "href=/Administration/Navigation");
            }
        }

        public HtmlAnchor DownloadAllHomeworksButton
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlAnchor>("download-all");
            }
        }

        public HtmlTable HomeworkGrid
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlTable>("role=grid");
            }
        }

        public HtmlInputText CourseNameToFilter
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputText>("aria-owns=CourseInstanceIdToFilter_listbox");
            }
        }

        public HtmlInputText LectureNameToFilter
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputText>("aria-owns=LectureIdToFilter_listbox");
            }
        }

        public HtmlInputText UserNameToFilter
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputText>("aria-owns=UsernameToFilter_listbox");
            }
        }

        public HtmlInputCheckBox ForEvaluationCheckbox
        {
            get
            {
                return Manager.Current.ActiveBrowser.Find.ById<HtmlInputCheckBox>("isSelectedForEvaluation");
            }
        }

        public GridPage GridPage
        {
            get
            {
                return new GridPage();
            }
        }

        public HtmlDiv PopUp
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("class=k-edit-form-container"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlDiv>("class=k-edit-form-container");
            }
        }

        public HtmlInputNumber MarkInput
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("id=Mark"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlInputNumber>("id=Mark");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("class=k-button k-button-icontext k-primary k-grid-update"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-primary k-grid-update");
            }
        }

        public HtmlAnchor CancelButton
        {
            get
            {
                this.Browser.WaitForElement(new HtmlFindExpression("class=k-button k-button-icontext k-grid-cancel"), 30000, false);
                return Manager.Current.ActiveBrowser.Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-cancel");
            }
        }

        public HtmlAnchor DeleteRowButton(int rowIndex)
        {
            return this.GridPage.GridTable.BodyRows[rowIndex].Find.ByExpression<HtmlAnchor>("class=k-button k-button-icontext k-grid-delete");
        }

        public HtmlAnchor DownloadUserHomeworkButton(int rowIndex)
        {
            this.Browser.WaitForElement(new HtmlFindExpression("tagname=a"), 30000, false);
            return this.GridPage.GridTable.BodyRows[rowIndex].Find.AllByTagName<HtmlAnchor>("a")[1];
        }

        public HtmlAnchor EditHomeworkButton(int rowIndex)
        {
            this.Browser.WaitForElement(new HtmlFindExpression("tagname=a"), 30000, false);
            return this.GridPage.GridTable.BodyRows[rowIndex].Find.AllByTagName<HtmlAnchor>("a")[2];
        }

        public IList<HtmlTableCell> TableDataCell(int rowindex)
        {
            return this.GridPage.GridTable.BodyRows[rowindex].Find.AllByTagName<HtmlTableCell>("td");
        }
    }
}
